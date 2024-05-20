using NUnit.Framework;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using KliensAlk;
using System.Drawing;
using Hotcakes.CommerceDTO.v1.Catalog;
using Hotcakes.CommerceDTO.v1;
using System.Reflection;

namespace KliensAlk.Tests
{
	[TestFixture]
	public class Form1Tests
	{
		ApiResponse<List<ProductDTO>> termekadatok = new ApiResponse<List<ProductDTO>>();
		public class Api
        {
            private string _url;
            private string _token;

            public Api(string url, string token)
            {
                _url = url;
                _token = token;
            }
        }

        private Form1 _form;
		private Mock<Api> _mockApi;

		[SetUp]
		public void Setup()
		{
			_mockApi = new Mock<Api>("http://20.234.113.211:8107", "1-79771cd1-cb22-4710-a786-b360d8a92c2f");
			_form = new Form1();
		}

		[Test]
		public void Form1_Load_SetsPictureBoxImage()
		{
			// Arrange
			var pictureBox2 = GetControl<PictureBox>(_form, "pictureBox1");

			// Act
			_form.Form1_Load(null, EventArgs.Empty);

			// Assert
			Assert.That(pictureBox2.Image, Is.Not.Null);
		}

		[Test]
		public void TermekNevSzures_FiltersProductsCorrectly()
		{
			// Arrange
			var products = new List<ProductDTO>
			{
				new ProductDTO { ProductName = "Apple", Sku = "123", Bvin = "1" },
				new ProductDTO { ProductName = "Banana", Sku = "456", Bvin = "2" }
			};

			SetPrivateField(_form, "termekadatok", new ApiResponse<List<ProductDTO>> { Content = products });

			var textBoxNev = GetControl<TextBox>(_form, "textBoxNev");
			textBoxNev.Text = "App";

			// Act
			_form.TermekNevSzures();

			// Assert
			var listBox1 = GetControl<ListBox>(_form, "listBox1");
			Assert.That(listBox1.Items.Count, Is.EqualTo(1));
			Assert.That(((Form1.TermekListaElem)listBox1.Items[0]).ProductName, Is.EqualTo("Apple"));
		}

		[Test]
		public void TextBoxSKU_TextChanged_FiltersBySku()
		{
			// Arrange
			var products = new List<ProductDTO>
			{
				new ProductDTO { ProductName = "Apple", Sku = "123", Bvin = "1" },
				new ProductDTO { ProductName = "Banana", Sku = "456", Bvin = "2" }
			};

			SetPrivateField(_form, "termekadatok", new ApiResponse<List<ProductDTO>> { Content = products });

			var textBoxSKU = GetControl<TextBox>(_form, "textBoxSKU");
			textBoxSKU.Text = "123";

			// Act
			_form.textBoxSKU_TextChanged(null, EventArgs.Empty);

			// Assert
			var listBox1 = GetControl<ListBox>(_form, "listBox1");
			Assert.That(listBox1.Items.Count, Is.EqualTo(1));
			Assert.That(((Form1.TermekListaElem)listBox1.Items[0]).ProductName, Is.EqualTo("Apple"));
		}

		private T GetControl<T>(Control parent, string name) where T : Control
		{
			return parent.Controls.Find(name, true).FirstOrDefault() as T;
		}

		private void SetPrivateField(object obj, string fieldName, object value)
		{
			var field = obj.GetType().GetField(fieldName, BindingFlags.NonPublic | BindingFlags.Instance);
			if (field != null)
			{
				field.SetValue(obj, value);
			}
		}
	}
}