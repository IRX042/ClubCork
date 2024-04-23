﻿using Hotcakes.Commerce.Marketing.PromotionQualifications;
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
			public string ProductSKU { get; set; }

			public override string ToString()
			{
				return $"{ProductName}_{Bvin}_{ProductSKU}";
			}
		}

		private void TermekNevSzures()
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
	}
}
