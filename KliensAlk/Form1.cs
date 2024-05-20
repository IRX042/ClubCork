using Hotcakes.Commerce.Marketing.PromotionQualifications;
using Hotcakes.CommerceDTO.v1;
using Hotcakes.CommerceDTO.v1.Catalog;
using Hotcakes.CommerceDTO.v1.Client;
using Hotcakes.Web.Barcodes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace KliensAlk
{
	public partial class Form1 : Form
	{
		ApiResponse<List<ProductDTO>> termekadatok = new ApiResponse<List<ProductDTO>>();
		Api p;

		public Form1()
		{
			InitializeComponent();

			string url = "http://20.234.113.211:8107";
			string key = "1-79771cd1-cb22-4710-a786-b360d8a92c2f";

			try
			{
				p = new Api(url, key);
				termekadatok = p.ProductsFindAll();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Hiba az oldalhoz való csatlakozás közben: " + ex.Message);
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			pictureBox2.Image = Image.FromFile(Path.Combine(Application.StartupPath, "logo.jpeg"));
			try
			{
				TermekNevSzures();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Hiba az oldalhoz való csatlakozás közben: " + ex.Message);
			}
		}

		public class TermekListaElem
		{
			public string ProductName { get; set; }
			public string Bvin { get; set; }
			public string ProductSKU { get; set; }

			public override string ToString()
			{
				return $"{ProductName}_{Bvin}_{ProductSKU}";
			}
		}

		public void TermekNevSzures()
		{
			var trmk = from x in termekadatok.Content.ToList()
					   where x.ProductName.IndexOf(textBoxNev.Text, StringComparison.OrdinalIgnoreCase) >= 0
					   select new TermekListaElem
					   {
						   ProductName = x.ProductName,
						   ProductSKU = x.Sku,
						   Bvin = x.Bvin,
					   };
			listBox1.DataSource = trmk.ToList();
			listBox1.DisplayMember = "ProductName";
		}

		private void textBoxNev_TextChanged(object sender, EventArgs e)
		{
			TermekNevSzures();
		}

		private void textBoxSKU_TextChanged(object sender, EventArgs e)
		{
			var trmk = from x in termekadatok.Content.ToList()
					   where x.Sku == textBoxSKU.Text
					   select new TermekListaElem
					   {
						   ProductName = x.ProductName,
						   ProductSKU = x.Sku,
						   Bvin = x.Bvin,
					   };
			listBox1.DataSource = trmk.ToList();
			listBox1.DisplayMember = "ProductName";
		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

			string bvin = listBox1.SelectedItem.ToString().Split('_')[1];
			var keszlet = p.ProductInventoryFindAll().Content;

			string raktar = "hiba";
			for (int i = 0; i < keszlet.Count; i++)
			{
				if (keszlet[i].ProductBvin.ToString() == bvin)
				{
					raktar = keszlet[i].QuantityOnHand.ToString();
					break;
				}
			}

			textBoxRaktar.Text = raktar.ToString();

		}

		private void buttonPlusz_Click(object sender, EventArgs e)
		{
			string bvin = listBox1.SelectedItem.ToString().Split('_')[1];
			var keszlet = p.ProductInventoryFindAll().Content;

			ProductInventoryDTO keszletelem = null;
			for (int i = 0; i < keszlet.Count; i++)
			{
				if (keszlet[i].ProductBvin.ToString() == bvin)
				{
					keszletelem = keszlet[i];
					break;
				}
			}

			if (keszletelem == null) Console.WriteLine("Raktarkészlet nem található");
			else
			{
				keszletelem.QuantityOnHand += 1;
				ApiResponse<ProductInventoryDTO> response = p.ProductInventoryUpdate(keszletelem);
			}

			textBoxRaktar.Text = keszletelem.QuantityOnHand.ToString();
		}

		private void buttonMinusz_Click(object sender, EventArgs e)
		{
			string bvin = listBox1.SelectedItem.ToString().Split('_')[1];
			var keszlet = p.ProductInventoryFindAll().Content;

			ProductInventoryDTO keszletelem = null;
			for (int i = 0; i < keszlet.Count; i++)
			{
				if (keszlet[i].ProductBvin.ToString() == bvin)
				{
					keszletelem = keszlet[i];
					break;
				}
			}

			if (keszletelem == null) Console.WriteLine("Raktarkészlet nem található");
			else
			{
				if (keszletelem.QuantityOnHand > 0)
				{
					keszletelem.QuantityOnHand -= 1;
					ApiResponse<ProductInventoryDTO> response = p.ProductInventoryUpdate(keszletelem);
				}
			}

			textBoxRaktar.Text = keszletelem.QuantityOnHand.ToString();
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			DialogResult result = MessageBox.Show("Biztosan bezárja az alkalmazást?", "Bezárás megerősítése", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (result == DialogResult.No)
			{
				e.Cancel = true;
			}
		}

		private void buttonKeszites_Click(object sender, EventArgs e)
		{
			string sku = listBox1.SelectedItem.ToString().Split('_')[2];
			BarcodeWriter writer = new BarcodeWriter() { Format = BarcodeFormat.CODE_128 };
			pictureBox1.Image = writer.Write(sku);


		}

		private void buttonMentes_Click(object sender, EventArgs e)
		{
			SaveFileDialog sf = new SaveFileDialog();
			sf.Filter = "JPEG Image|*.jpg|PNG Image|*.png|BMP Image|*.bmp|All files|*.*";
			sf.Title = "Vonalkód mentése képként";
			sf.ShowDialog();

			if (sf.FileName != "")
			{
				try
				{
					Image img = pictureBox1.Image;
					img.Save(sf.FileName);

					MessageBox.Show("Kép mentve!");
				}
				catch (Exception ex)
				{
					MessageBox.Show("Hiba a kép mentése közben: " + ex.Message);
				}
			}
		}

		private void buttonBeolvasas_Click(object sender, EventArgs e)
		{
			OpenFileDialog of = new OpenFileDialog();
			of.Filter = "Image Files (*.jpg;*.jpeg;*.gif;*.bmp;*.png)|*.jpg;*.jpeg;*.gif;*.bmp;*.png";

			if (of.ShowDialog() == DialogResult.OK)
			{
				pictureBox1.Image = Image.FromFile(of.FileName);
				BarcodeReader reader = new BarcodeReader();
				var sku = reader.Decode((Bitmap)pictureBox1.Image);
				if (sku != null) { textBoxSKU.Text = sku.Text; }
			}
		}

		private void buttonTorles_Click(object sender, EventArgs e)
		{
			pictureBox1.Image = null;
			textBoxSKU.Text = null;
			TermekNevSzures();
		}
	}
}
