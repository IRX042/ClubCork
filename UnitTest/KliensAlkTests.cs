using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using KliensAlk;

namespace UnitTest
{
	namespace KliensAlkTests
	{
		[TestFixture]
		public class Form1Tests
		{
			private Mock<Api> mockApi;
			private Form1 form;

			[SetUp]
			public void Setup()
			{
				mockApi = new Mock<Api>("http://dummyurl", "dummykey");
				form = new Form1
				{
					p = mockApi.Object
				};
				form.termekadatok = new ApiResponse<List<ProductDTO>>
				{
					Content = new List<ProductDTO>
				{
					new ProductDTO { ProductName = "TestProduct1", Sku = "SKU1", Bvin = "Bvin1" },
					new ProductDTO { ProductName = "TestProduct2", Sku = "SKU2", Bvin = "Bvin2" }
				}
				};

				form.textBoxNev = new TextBox();
				form.textBoxSKU = new TextBox();
				form.listBox1 = new ListBox();
				form.textBoxRaktar = new TextBox();
			}

			[Test]
			public void TermekNevSzures_FiltersProductsCorrectly()
			{
				// Arrange
				form.textBoxNev.Text = "TestProduct1";

				// Act
				form.TermekNevSzures();

				// Assert
				var listBoxItems = form.listBox1.DataSource as List<Form1.TermekListaElem>;
				Assert.IsNotNull(listBoxItems);
				Assert.AreEqual(1, listBoxItems.Count);
				Assert.AreEqual("TestProduct1", listBoxItems[0].ProductName);
			}

			[Test]
			public void textBoxSKU_TextChanged_FiltersProductsBySKU()
			{
				// Arrange
				form.textBoxSKU.Text = "SKU1";

				// Act
				form.textBoxSKU_TextChanged(null, null);

				// Assert
				var listBoxItems = form.listBox1.DataSource as List<Form1.TermekListaElem>;
				Assert.IsNotNull(listBoxItems);
				Assert.AreEqual(1, listBoxItems.Count);
				Assert.AreEqual("SKU1", listBoxItems[0].ProductSKU);
			}

			[Test]
			public void listBox1_SelectedIndexChanged_UpdatesStockQuantity()
			{
				// Arrange
				mockApi.Setup(api => api.ProductInventoryFindAll()).Returns(new ApiResponse<List<ProductInventoryDTO>>
				{
					Content = new List<ProductInventoryDTO>
				{
					new ProductInventoryDTO { ProductBvin = "Bvin1", QuantityOnHand = 10 }
				}
				});

				var listBoxItem = new Form1.TermekListaElem
				{
					ProductName = "TestProduct1",
					ProductSKU = "SKU1",
					Bvin = "Bvin1"
				};
				form.listBox1.DataSource = new List<Form1.TermekListaElem> { listBoxItem };
				form.listBox1.SelectedIndex = 0;

				// Act
				form.listBox1_SelectedIndexChanged(null, null);

				// Assert
				Assert.AreEqual("10", form.textBoxRaktar.Text);
			}

			[Test]
			public void buttonPlusz_Click_IncrementsStockQuantity()
			{
				// Arrange
				var productInventory = new ProductInventoryDTO { ProductBvin = "Bvin1", QuantityOnHand = 10 };
				mockApi.Setup(api => api.ProductInventoryFindAll()).Returns(new ApiResponse<List<ProductInventoryDTO>>
				{
					Content = new List<ProductInventoryDTO> { productInventory }
				});
				mockApi.Setup(api => api.ProductInventoryUpdate(It.IsAny<ProductInventoryDTO>())).Returns(new ApiResponse<ProductInventoryDTO>());

				var listBoxItem = new Form1.TermekListaElem
				{
					ProductName = "TestProduct1",
					ProductSKU = "SKU1",
					Bvin = "Bvin1"
				};
				form.listBox1.DataSource = new List<Form1.TermekListaElem> { listBoxItem };
				form.listBox1.SelectedIndex = 0;

				// Act
				form.buttonPlusz_Click(null, null);

				// Assert
				Assert.AreEqual("11", form.textBoxRaktar.Text);
			}

			[Test]
			public void buttonMinusz_Click_DecrementsStockQuantity()
			{
				// Arrange
				var productInventory = new ProductInventoryDTO { ProductBvin = "Bvin1", QuantityOnHand = 10 };
				mockApi.Setup(api => api.ProductInventoryFindAll()).Returns(new ApiResponse<List<ProductInventoryDTO>>
				{
					Content = new List<ProductInventoryDTO> { productInventory }
				});
				mockApi.Setup(api => api.ProductInventoryUpdate(It.IsAny<ProductInventoryDTO>())).Returns(new ApiResponse<ProductInventoryDTO>());

				var listBoxItem = new Form1.TermekListaElem
				{
					ProductName = "TestProduct1",
					ProductSKU = "SKU1",
					Bvin = "Bvin1"
				};
				form.listBox1.DataSource = new List<Form1.TermekListaElem> { listBoxItem };
				form.listBox1.SelectedIndex = 0;

				// Act
				form.buttonMinusz_Click(null, null);

				// Assert
				Assert.AreEqual("9", form.textBoxRaktar.Text);
			}
		}
	}
}
