using Hotcakes.Commerce.Marketing.PromotionQualifications;
using Hotcakes.CommerceDTO.v1;
using Hotcakes.CommerceDTO.v1.Catalog;
using Hotcakes.CommerceDTO.v1.Client;
using IronBarCode;
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
			p = new Api(url, key);

			termekadatok = p.ProductsFindAll();

		}

		private void Form1_Load(object sender, EventArgs e)
		{
			TermekNevSzures();

		}

		public class TermekListaElem
		{
			public string ProductName { get; set; }
			public string Bvin { get; set; }

			public override string ToString()
			{
				return $"{ProductName}_{Bvin}";
			}
		}

		private void TermekNevSzures()
		{
			var trmk = from x in termekadatok.Content.ToList()
					   where x.ProductName.IndexOf(textBoxNev.Text, StringComparison.OrdinalIgnoreCase) >= 0	
					   select new TermekListaElem
					   {
						   ProductName = x.ProductName,
						   Bvin = x.Bvin,
					   };
			listBox1.DataSource = trmk.ToList();
			listBox1.DisplayMember = "ProductName";
		}


		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			TermekNevSzures();
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

		private void button1_Click(object sender, EventArgs e)
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

		private void button2_Click(object sender, EventArgs e)
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

		private void buttonKeszites_Click(object sender, EventArgs e)
		{

		}

		private void buttonMentes_Click(object sender, EventArgs e)
		{

		}

		private void buttonBeolvasas_Click(object sender, EventArgs e)
		{

		}
	}
}
