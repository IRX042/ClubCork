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
		private static Api ApiKapcs()
		{
			string url = "http://20.234.113.211:8107";
			string key = "1-79771cd1-cb22-4710-a786-b360d8a92c2f";
			var p = new Api(url, key);
			return p;
		}

		public Form1()
		{
			InitializeComponent();
			termekadatok = TermekAdatokKi();

		}

		private static ApiResponse<List<ProductDTO>> TermekAdatokKi()
		{
			Api p = ApiKapcs();
			ApiResponse<List<ProductDTO>> termekadatok = p.ProductsFindAll();
			return termekadatok;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			TermekNevSzures();

		}

		private void TermekNevSzures()
		{
			termekadatok = TermekAdatokKi();
			var trmk = from x in termekadatok.Content.ToList()
					   where x.ProductName.Contains(textBox1.Text)
					   select x;
			listBox1.DataSource = trmk.ToList();
			listBox1.DisplayMember = "ProductName";
			//listBox1.ValueMember = "";
		}


		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			TermekNevSzures();
		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			Api p = ApiKapcs();
			int id = listBox1.SelectedIndex;
			//var inventoryId = "4d9443f7-589e-4618-a17b-85f1996250f9";
			termekadatok = TermekAdatokKi();
			var bvin = termekadatok.Content[id].Bvin;

			string ar = p.ProductsFind(bvin).Content.ListPrice.ToString();

			// call the API to find the product inventory record
			//ApiResponse<ProductInventoryDTO> keszlet = p.ProductInventoryFind(inventoryId);

			textBox2.Text = ar;
		}

		private void button1_Click(object sender, EventArgs e)
		{

		}
	}
}
