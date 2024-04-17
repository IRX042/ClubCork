using Hotcakes.Commerce.Marketing.PromotionQualifications;
using Hotcakes.CommerceDTO.v1;
using Hotcakes.CommerceDTO.v1.Catalog;
using Hotcakes.CommerceDTO.v1.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
				return $"{ProductName} _ {Bvin}";
			}
		}

		private void TermekNevSzures()
		{
			var trmk = from x in termekadatok.Content.ToList()
					   where x.ProductName.Contains(textBox1.Text)
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

			//Console.WriteLine(keszlet[0].ProductBvin.ToString());
			//Console.WriteLine(keszlet[0].Bvin.ToString());

			Console.WriteLine(p.ProductsFind(bvin).Content.Bvin);
			Console.WriteLine(p.ProductsFind(bvin).Content.ProductName);

			string raktar = "hiba";

			string[] tomb = new string[keszlet.Count];

            for (int i = 0; i < keszlet.Count; i++)
            {
				tomb[i] = keszlet[i].ProductBvin;
				Console.WriteLine(keszlet[i].ProductBvin);
				if (keszlet[i].ProductBvin == bvin)
				{
					raktar = keszlet[i].QuantityOnHand.ToString();
					Console.WriteLine("profi");
					break;
				}
            }
            textBox2.Text = raktar.ToString();
			
		}

		private void button1_Click(object sender, EventArgs e)
		{
			var keszlet = p.ProductInventoryFindAll().Content[listBox1.SelectedIndex];
			keszlet.QuantityOnHand += 1;
			ApiResponse<ProductInventoryDTO> response = p.ProductInventoryUpdate(keszlet);
			textBox2.Text = keszlet.QuantityOnHand.ToString();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			var keszlet = p.ProductInventoryFindAll().Content[listBox1.SelectedIndex];
			if (keszlet.QuantityOnHand > 0) { keszlet.QuantityOnHand -= 1; }
			ApiResponse<ProductInventoryDTO> response = p.ProductInventoryUpdate(keszlet);
			textBox2.Text = keszlet.QuantityOnHand.ToString();
		}
	}
}
