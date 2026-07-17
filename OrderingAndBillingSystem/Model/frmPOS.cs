	using MySql.Data.MySqlClient;
	using OrderingAndBillingSystem.Entity;
	using OrderingAndBillingSystem.LoginForm;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.ComponentModel;
	using System.Data;
	using System.Drawing;
	using System.Drawing.Imaging;
	using System.Drawing.Printing;
	using System.IO;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;
	using System.Windows.Forms;

namespace OrderingAndBillingSystem.Model
{
	public partial class frmPOS : Form
	{	
		public MySqlConnection connection;
		public MySql.Data.MySqlClient.MySqlCommand command;

		CategoryManager catmngr = new CategoryManager();
		CustomerManager custmngr = new CustomerManager();
		OrdersManager ordermngr = new OrdersManager();
		OrderItemsManager orderitmmngr = new OrderItemsManager();
		ProductsManager prodmngr = new ProductsManager();

		List<Category> cat = new List<Category>();
		List<Orders> orders = new List<Orders>();
		List<Product> products = new List<Product>();
		List<OrderItems> selectedProducts = new List<OrderItems>();
		TableManager tablemgr = new TableManager();
		Orders order = new Orders();
		Customer currCustomer = new Customer();

		public frmDelivery frm = new frmDelivery();

		private string selectedOrderType = "";
		private bool IsNewOrder = false;

		//04.08.2024
		private int tblId;
		private bool currOrdrType = false;

		public frmPOS()
		{   
			InitializeComponent();
		}

			
		private void frmPOS_Load(object sender, EventArgs e)
		{            
		
			LoadCategoryToGrid();
			LoadProductsToGrid(null);

			ClearFields();

            //string onum = NewOrderNumber().ToString();
            //lblOrderNumber.Text = onum.Length < 2 ? "00" + onum : "0" + onum;			
        }

        //private void LoadNew()
        //{
        //	string onum = NewOrderNumber().ToString();
        //	lblOrderNumber.Text = onum.Length < 2 ? "00" + onum : "0" + onum;
        //}

        public void LoadCurrOrder(int id)
        {
            orders = new List<Orders>();
            selectedProducts = new List<OrderItems>();

            orders = ordermngr.GetOrdersAll();
            var orderItms = orderitmmngr.GetOrderItemsAll();

            var cstmr = custmngr.GetCustomerAll();
            var currOrder = orders.FirstOrDefault(x => x.Id == id);
            selectedProducts = orderItms.Where(x => x.OrderId == id).ToList();

            IsNewOrder = false;

            if (currOrder is null)
            {
                currOrder.CustomerName = "";
            }
            else
            {
                var cust = cstmr.FirstOrDefault(x => x.Id == currOrder.CustomerId);
                currOrder.CustomerName = cust.Name;
            }

            Order.CurrentOrder = currOrder;

            string onum = Convert.ToString(currOrder.OrderNo);
            lblOrderNumber.Text = onum.Length < 2 ? "00" + onum : "0" + onum;
            lblTable.Text = currOrder.TableName;
            lblWaiter.Text = currOrder.WaiterName;

			btnDelivery.Checked = currOrder.OrderType == "Delivery" ? true : false;
            btnTakeOut.Checked = currOrder.OrderType == "Take-Out" ? true : false;
            btnDineIn.Checked = currOrder.OrderType == "Dine-In" ? true : false;

            selectedOrderType = btnDelivery.Checked ? "Delivery" :
                                btnTakeOut.Checked ? "Take-Out" :
                                btnDineIn.Checked ? "Dine-In" : "";

            // load items
            pnlOrderList.Controls.Clear();
            foreach (var i in selectedProducts)
            {
                LoadSelectedOrderToList(i);
            }

            //CalculateTotalQuantity();
        }

        private void ClearCategory(object sender, EventArgs e)
		{
			foreach (var pnl in pnlCategoryList.Controls)
			{
				var p = (ucCategory)pnl;
				if (p.IsBtnClicked) p.IsBtnClicked = false;
			}

			LoadProductsToGrid(null);

			lblSelectedCategory.Text = "All Items";
            btnCloseTab.Visible = false;
			pbCatPanel.Width = lblSelectedCategory.Width + 142;
			pnlCat.Width = pbCatPanel.Width + 17;
		}

		private void LoadCategoryToGrid()
		{
			cat = catmngr.GetCategoryAll();

			pnlCategoryList.Controls.Clear();
			foreach (var i in cat)
			{
				ucCategory lst = new ucCategory();

				lst.CategoryName = i.Name;
				lst.CategoryId = i.Id;
				lst.CategoryImage = null;

				if (i.CategoryImage != null)
				{
					lst.CategoryImage = Image.FromStream(new MemoryStream(i.CategoryImage));
				}

				pnlCategoryList.Controls.Add(lst);

				lst.EventHndlr += (a, b) =>
				{
					lblSelectedCategory.Text = i.Name;

                    btnCloseTab.Visible = false;
                    btnCloseTab.Visible = true;
					pbCatPanel.Width = lblSelectedCategory.Width + 142;
					pnlCat.Width = pbCatPanel.Width + 17;

					foreach (var pnl in pnlCategoryList.Controls)
					{
						var p = (ucCategory)pnl;
						if (p.IsBtnClicked) p.IsBtnClicked = false;
					}

					foreach (var pnl in pnlCategoryList.Controls)
					{
						var p = (ucCategory)pnl;
						if (p.CategoryName == i.Name) p.IsBtnClicked = true;
					}

					LoadProductsToGrid(i.Id);
				};
			}
		}

		private void LoadProductsToGrid(int? catId)
		{
			products = prodmngr.GetProductsAll();

			if (catId != null)
			{
				products = products.Where(x => x.CategoryId == catId).ToList();
			}
			products = products.OrderByDescending(x => x.Status).ToList();

			pnlProductList.Controls.Clear();
			foreach (var i in products)
			{
				ucProducts lst = new ucProducts();

				lst.ProductName = i.ItemName;
				lst.ProductImage = null;

				if (i.ItemImage != null)
				{
					lst.ProductImage = Image.FromStream(new MemoryStream(i.ItemImage));
				}
				lst.ProdStatus = Convert.ToBoolean(i.Status);

				pnlProductList.Controls.Add(lst);

				lst.EventHndlr += (a, b) =>
				{
					var c = (ucProducts)a;

					// Open QuantityForm for adding quantity
					frmAddQuantity quantityForm = new frmAddQuantity();
                    quantityForm.lblItem.Text = "(" + i.ItemName + " - ₱ " + i.Price.ToString() + ")";

                    if (quantityForm.ShowDialog() == DialogResult.OK)
					{
						int quantity = quantityForm.Quantity;

						pnlOrderList.Controls.Clear();
						OrderItems oi = new OrderItems();

						if (!CheckOrderItemExist(i.Id))
						{
							oi.ProID = i.Id;
							oi.Quantity = quantity;
							oi.Price = i.Price;
							oi.Amount = i.Price * quantity;
							order.Total += oi.Amount;

							selectedProducts.Add(oi);

							foreach (var sp in selectedProducts)
							{
								LoadSelectedOrderToList(sp);
								CalculateTotalQuantity();
							}
						}
						else
						{
							foreach (var sp in selectedProducts)
							{
								if (sp.ProID == i.Id)
								{
									sp.Quantity += quantity;
									sp.Amount = sp.Price * sp.Quantity;
									order.Total += i.Price * quantity;

									//pnlOrderList.Controls.Clear();
									//LoadSelectedOrderToList(sp);
									//CalculateTotalQuantity();
									//break;
								}

								LoadSelectedOrderToList(sp);
								CalculateTotalQuantity();
							}
						}
					}
				};
			}
		}

		public void LoadSelectedOrder(Orders selectedOrder)
		{            
			pnlOrderList.Controls.Clear();
			CalculateTotal();
			CalculateTotalQuantity();
		}

		private void CalculateTotalQuantity()
		{
			
			int totalQuantity = selectedProducts.Sum(item => item.Quantity);
		}

		private void CalculateTotal()
		{
			int qty = selectedProducts.Sum(x => x.Quantity);
			decimal total = (decimal)selectedProducts.Sum(item => item.Amount);
			lblTotal.Text = total.ToString("C");
			lblTotalQty.Text = qty.ToString() + "x";

			order.Total = Convert.ToDouble(total);

        }

		private void LoadSelectedOrderToList(OrderItems itm)
		{
			if (products == null || !products.Any())
			{
				return;
			}

			var allProd = prodmngr.GetProductsAll();
            var i = allProd.FirstOrDefault(x => x.Id == itm.ProID);
			if (i == null)
			{
				return;
			}

			ucItemOrderList lst = new ucItemOrderList();
			lst.ItemName = i.ItemName;
			lst.Quantity = itm.Quantity.ToString() + "x";
			lst.Price = "₱ " + itm.Price.ToString();
			lst.Amount = "₱ " + itm.Amount.ToString();

			lst.Width = pnlOrderList.Width;

			lst.UpdateItemClicked += (sender, e) =>
            {
                var clickedItem = sender as ucItemOrderList;
                var orderItem = selectedProducts.FirstOrDefault(p => p.ProID == i.Id);

                if (orderItem != null)
                {
                    frmAddQuantity quantityForm = new frmAddQuantity();
					quantityForm.lblQtyHeader.Text = "Edit Quantity";
                    quantityForm.lblItem.Text = "(" + i.ItemName + " - ₱ " + itm.Price.ToString() + ")";

                    quantityForm.Quantity = itm.Quantity;

                    if (quantityForm.ShowDialog() == DialogResult.OK)
					{
                        //orderItem.Quantity += quantityForm.Quantity;
                        orderItem.Quantity = quantityForm.Quantity;
                        int qty = orderItem.Quantity;

                        lst.Quantity = qty.ToString() + "x";

						var result = selectedProducts.ToList();
						foreach (var r in result)
						{
							if (r.ProID == itm.ProID)
							{
								r.Quantity = qty;
								r.Amount = r.Price * qty;
                                lst.Amount = "₱ " + itm.Amount.ToString();
                                break;
							}
						}
                        selectedProducts = result;

                        CalculateTotal();
                    }
                }
            };


			lst.RemoveItemClicked += (sender, e) =>
			{
				var clickedItem = sender as ucItemOrderList;

				if (clickedItem.Status != "Done")
				{
					var orderItem = selectedProducts.FirstOrDefault(p => p.ProID == i.Id);
					if (orderItem != null)
					{
                        DialogResult dgResult = MessageBox.Show("Are you sure you want to remove item " + "'" + i.ItemName + "'" + "?", 
																"Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
						if (dgResult == DialogResult.Yes)
						{
                            order.Total -= orderItem.Amount;
							selectedProducts.Remove(orderItem);
							pnlOrderList.Controls.Remove(clickedItem);
                            CalculateTotal();
                        }                        
					}
				}
			};				

			pnlOrderList.Controls.Add(lst);

			CalculateTotal();
		}

		private bool CheckOrderItemExist(int id)
		{
			if (selectedProducts != null)
			{
				var i = selectedProducts.Where(x => x.ProID == id);
				if (i.Any()) return true;

				return false;
			}

			return false;
		}

		private int NewOrderNumber()
		{
			int num = 1;
			var ordrs = ordermngr.GetOrdersAll();
			ordrs = ordrs.Where(x => x.OrderDate == DateTime.Now.Date).ToList();

			if (ordrs.Any())
				num = ordrs.Max(x => x.OrderNo ) + 1;

			return num;
		}

		private void CurrOrderDetails(bool isKOT)
		{
			order.OrderDate = DateTime.Now;
			order.OrderTime = DateTime.Now.ToLongTimeString();
			order.TableName = lblTable.Text;
			order.WaiterName = lblWaiter.Text;
			order.PaymentStatus = isKOT ? "Pending" : "Paid";
			order.OrderNo = NewOrderNumber();
			order.OrderType = selectedOrderType;
		}

		private void PayOrder()
		{
			try
			{
				order = IsNewOrder ? order : Order.CurrentOrder;

				order.Received =  Order.CurrentOrder.Received;
				order.OrderChanged = Order.CurrentOrder.OrderChanged;
				order.Discount = Order.CurrentOrder.Discount;
				order.PaymentStatus = "Paid";

				frmPayment frm = new frmPayment();
				string discounttext = frm.txtDiscount.Text;
				if (double.TryParse(discounttext, out double discount))
				{
					double netIncome = Order.CurrentOrder.Total - discount;
					order.Discount = discount;
				}
				if (IsNewOrder)
				{
					CurrOrderDetails(false);
					SaveCustomer();
					ordermngr.AddOrder(order);
				}
				else
				{
					ordermngr.UpdateOrder(order);
				}

				//MessageBox.Show("Order saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void SaveOrder()
		{
			try
			{
				CurrOrderDetails(true);
				SaveCustomer();

				if (IsNewOrder)
                {
                    ordermngr.AddOrder(order);
					return;
                }

				order.Id = Order.CurrentOrder.Id;
                order.OrderDate = DateTime.Now;
                ordermngr.UpdateOrder(order);

                //MessageBox.Show("Order saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
			catch (Exception ex)
			{
				MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void SaveOrderItems()
		{
			try
			{
				if (selectedProducts == null) return;

				int id = 0;
				if (IsNewOrder)
				{
					var ordrs = ordermngr.GetOrdersAll();
					if (ordrs.Any())
						id = ordrs.Max(x => x.Id);
				}
				else
				{
					id = order.Id;
                }

				//delete
				var result = orderitmmngr.GetOrderItemsByOrderId(id);
				var toDelete = result.Where(x => !selectedProducts.Any(y => y.ID == x.ID));
				foreach (var i in toDelete)
				{
					orderitmmngr.DeleteOrederItem(i.ID);
                }


                foreach (var itm in selectedProducts)
				{
					// insert item
					if (itm.OrderId < 1)
					{
						itm.OrderId = id;
						orderitmmngr.AddOrderItem(itm);
						continue;
					}

					// update item
					orderitmmngr.UpdateOrderItem(itm);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void SaveCustomer()
		{
			try
			{
				CustomerManager custmngr = new CustomerManager();
				custmngr.AddCustomer(currCustomer);

				var cust = custmngr.GetCustomerAll();
				int id = cust.Max(x => x.Id);
				order.CustomerId = id;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private bool SetCustomer()
		{
			if (selectedOrderType != "Dine-In")
			{
				currCustomer.Name = frm.txtCusName.Text;
				currCustomer.Address = frm.txtAddress.Text;
				currCustomer.Phone = frm.txtPhone.Text;
			}

			if (currCustomer is null)
			{
				MessageBox.Show("Please enter customer details.");
				return false;
			}

			return true;
		}

		public void ClearFields()
		{
			lblTable.Text = "";
			lblWaiter.Text = "";
			lblTable.Visible = false;
			lblWaiter.Visible = false;
			lblName.Text = "";
			lblOrderType.Text = "";
			lblOrderType.Visible = false;
			lblDate.Visible = false;
			pnlOrderList.Controls.Clear();
			lblTotal.Text = "₱ 0.00";
			lblTotalQty.Text = "0";
			IsNewOrder = true;

            string onum = NewOrderNumber().ToString();
            lblOrderNumber.Text = onum.Length < 2 ? "00" + onum : "0" + onum;

            order = new Orders();
			Order.CurrentOrder = null;
			selectedProducts = new List<OrderItems>();

            selectedOrderType = "";
			btnDelivery.Checked = false;
            btnTakeOut.Checked = false;
            btnDineIn.Checked = false;
		}

		private void btnNew_Click(object sender, EventArgs e)
		{
			ClearFields();

			//pnlOrderList.Controls.Clear();
			//selectedProducts.Clear();
			//lblTotal.Text = "₱ 0.00";

			//order.Total = 0;
			//string onum = NewOrderNumber().ToString();
			//lblOrderNumber.Text = onum.Length < 2 ? "00" + onum : "0" + onum;

			//btnTakeOut.Checked = false;
			//btnDineIn.Checked = false;
			//btnDelivery.Checked = false;
		}

		private void btnDelivery_Click(object sender, EventArgs e)
		{				
			selectedOrderType = "Delivery";
			//frm.ShowDialog();
		}

		private void btnTakeOut_Click(object sender, EventArgs e)
		{				
			selectedOrderType = "Take-Out"; 
			//frm.ShowDialog();
		}

		private void btnDineIn_Click(object sender, EventArgs e)
		{		
			selectedOrderType = "Dine-In"; 

			//frmTableSelect select = new frmTableSelect();
			//if (select.ShowDialog() == DialogResult.OK)
			//{
			//	lblTable.Text = select.tableName;
			//	lblWaiter.Text = select.sName;
			//	tblId = select.id; //04.08.2024

			//	lblTable.Visible = !string.IsNullOrEmpty(select.tableName);
			//	lblWaiter.Visible = !string.IsNullOrEmpty(select.sName);
			//}

		}
		
		private void btnBill_Click(object sender, EventArgs e)
		{
			frmBillList billLst = new frmBillList();
			billLst.WindowState = FormWindowState.Maximized;
			//billLst.ShowDialog();

			if (billLst.ShowDialog() == DialogResult.OK)
			{
				LoadCurrOrder(billLst.currOrderId);
            }
		}


		private void txtFind_TextChanged(object sender, EventArgs e)
		{
			foreach (var item in pnlProductList.Controls)
			{
				var pro = (ucProducts)item;
				pro.Visible = pro.productName.ToLower().Contains(txtFind.Text.Trim().ToLower());
			}
		}

	
		private void btnCheckOut_Click_1(object sender, EventArgs e)
		{
			try
			{
				if (selectedProducts.Count == 0) return;

				if (selectedOrderType == "")
				{
					MessageBox.Show("Please Select Order Type To Continue.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
					return;
				}

				currOrdrType = selectedOrderType == "Dine-In" ? true : false;

				DialogResult dgResult = MessageBox.Show("Are you sure you want to continue? \n" +
														"'Yes' To Continue Payment \n" +
														"'No' To Place Order", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

				if (dgResult == DialogResult.Yes)
				{
					frmPayment payment = new frmPayment();
					payment.SetSelectedOrderItems(selectedProducts);

					if (Order.CurrentOrder is null)
					{
						Order.CurrentOrder = new Orders();
						Order.CurrentOrder.OrderNo = Convert.ToInt32(lblOrderNumber.Text);
						Order.CurrentOrder.Total = order.Total;
						Order.CurrentOrder.CustomerName = currCustomer.Name;
						Order.CurrentOrder.OrderDate = DateTime.Now;
						Order.CurrentOrder.OrderType = selectedOrderType;
						Order.CurrentOrder.TableName = lblTable.Text;
					}

					if (payment.ShowDialog() == DialogResult.OK)
					{
						if (!SetCustomer()) return;
						PayOrder();
						SaveOrderItems();
						ClearFields();

						string onum = NewOrderNumber().ToString();
						lblOrderNumber.Text = onum.Length < 2 ? "00" + onum : "0" + onum;
					}
				}
				else if (dgResult == DialogResult.No)
				{
					// Retrieve necessary data before printing
					products = prodmngr.GetProductsAll();
					PrintDocument printDocument = new PrintDocument();
					printDocument.PrintPage += new PrintPageEventHandler(RprintDocument_PrintPage);
					printDocument.Print();
					SetCustomer();
					SaveOrder();
					SaveOrderItems();
					ClearFields();
					order.Total = 0;
					string onum = NewOrderNumber().ToString();
					lblOrderNumber.Text = onum.Length < 2 ? "00" + onum : "0" + onum;
                    
                  
                }

                //04.08.2024
                UpdateSelectedTable();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

			//if (selectedProducts.Count == 0) return;

			//if (selectedOrderType == "")
			//{
			//	MessageBox.Show("Please Select Order Type To Continue.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
			//	return;
			//}

			//DialogResult dgResult = MessageBox.Show("Are you sure you want to continue? \n" +
			//										"'Yes' To Continue Payment \n" +
			//										"'No' To Place Order", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

			//if (dgResult == DialogResult.Yes)
			//{
			//	// Code for 'Yes' option
			//	// Proceed with payment
			//	frmPayment payment = new frmPayment();
			//	payment.SetSelectedOrderItems(selectedProducts);

			//	if (Order.CurrentOrder is null)
			//	{
			//		Order.CurrentOrder = new Orders();
			//		Order.CurrentOrder.OrderNo = Convert.ToInt32(lblOrderNumber.Text);
			//		Order.CurrentOrder.Total = order.Total;
			//		Order.CurrentOrder.CustomerName = currCustomer.Name;
			//		Order.CurrentOrder.OrderDate = DateTime.Now;
			//		Order.CurrentOrder.OrderType = selectedOrderType;
			//		Order.CurrentOrder.TableName = lblTable.Text;
			//	}

			//	if (payment.ShowDialog() == DialogResult.OK)
			//	{
			//		if (!SetCustomer()) return;
			//		PayOrder();
			//		SaveOrderItems();
			//		ClearFields();

			//		string onum = NewOrderNumber().ToString();
			//		lblOrderNumber.Text = onum.Length < 2 ? "00" + onum : "0" + onum;
			//	}
			//}
			//else if (dgResult == DialogResult.No)
			//{
			//	PrintDocument printDocument = new PrintDocument();
			//	printDocument.PrintPage += new PrintPageEventHandler(RprintDocument_PrintPage);
			//	printDocument.Print();
			//	// Code for 'No' option
			//	SetCustomer();
			//	SaveOrder();
			//	SaveOrderItems();
			//	ClearFields();
			//	order.Total = 0;
			//	string onum = NewOrderNumber().ToString();
			//	lblOrderNumber.Text = onum.Length < 2 ? "00" + onum : "0" + onum;

			//	// Retrieve necessary data before printing
			//	products = prodmngr.GetProductsAll();
			//	//PrintOrderDetails(); // Call the printing method

			//}
			//UpdateSelectedTable();
		}

		// Method to print order details

		//04.08.2024
		private void UpdateSelectedTable()
		{
			try
			{
				if (!currOrdrType)
				{
					return;
				}

				var tblData = tablemgr.GetTables();
				var curr = tblData.FirstOrDefault(x => x.Id == tblId);
				if (curr != null)
				{
					curr.Status = 1;
					tablemgr.UpdateTables(curr);
				}

			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message);
			}
		}
		private void btnCashDrawer_Click(object sender, EventArgs e)
		{
			frmCashDrawer frm = new frmCashDrawer();
			frm.ShowDialog();
		}

        private void btnExit_Click(object sender, EventArgs e)
        {            
			if (MessageBox.Show("Are you Sure You want to Exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                frmLoginForm frm = new frmLoginForm();
                frm.Show();
            };
        }
	
		private void RprintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // Set the paper size to 58mm width (approximately 2.28 inches)
            e.PageSettings.PaperSize = new System.Drawing.Printing.PaperSize("Custom", 230, 1100);

            //// Print header information
            //e.Graphics.DrawString("Green House Resto", new Font("Courier New", 12, FontStyle.Bold), Brushes.Black, new Point(10, 10));
            //e.Graphics.DrawString("Rizal st. Gubat Sorsogon", new Font("Courier New", 8, FontStyle.Regular), Brushes.Black, new Point(20, 30));
            //e.Graphics.DrawString($"Date: {DateTime.Now.ToShortDateString()}", new Font("Courier New", 8, FontStyle.Regular), Brushes.Black, new Point(60, 45));
            //e.Graphics.DrawString($"Order #: {lblOrderNumber.Text}", new Font("Courier New", 8, FontStyle.Regular), Brushes.Black, new Point(60, 60));
            //e.Graphics.DrawString($"Table: {lblTable.Text}", new Font("Courier New", 8, FontStyle.Regular), Brushes.Black, new Point(50, 75));
            //e.Graphics.DrawString($"{selectedOrderType}", new Font("Courier New", 10, FontStyle.Bold), Brushes.Black, new Point(70, 90));
            //e.Graphics.DrawString("-----------------------------", new Font("Courier New", 8, FontStyle.Regular), Brushes.Black, new Point(10, 105));

            //int yPos = 105;
            //yPos += 10;
            //int totalItems = 0;

            //// Print item details
            //foreach (var item in selectedProducts)
            //{
            //	//Product product = products.FirstOrDefault(p => p.Id == item.ProID);
            //	products = prodmngr.GetProductsAll();
            //	var product = products.FirstOrDefault(p => p.Id == item.ProID);
            //	if (product != null)
            //	{
            //		e.Graphics.DrawString(product.ItemName, new Font("Courier New", 8, FontStyle.Regular), Brushes.Black, new Point(5, yPos + 5));
            //		e.Graphics.DrawString(item.Quantity.ToString() + "x", new Font("Courier New", 8, FontStyle.Regular), Brushes.Black, new Point(15, yPos + 20));
            //		e.Graphics.DrawString($"₱{product.Price}", new Font("Courier New", 8, FontStyle.Regular), Brushes.Black, new Point(100, yPos + 20));
            //		e.Graphics.DrawString($"₱{item.Amount}", new Font("Courier New", 8, FontStyle.Regular), Brushes.Black, new Point(150, yPos + 20));

            //		yPos += 20;
            //		totalItems += item.Quantity;
            //		yPos += 10; // Adjust this value as needed for your spacing
            //	}
            //}

            //// Add line separator
            //e.Graphics.DrawString("-----------------------------", new Font("Courier New", 8, FontStyle.Regular), Brushes.Black, new Point(5, yPos + 5));

            //e.Graphics.DrawString($"{totalItems}" + ".0", new Font("Courier New", 8, FontStyle.Regular), Brushes.Black, new Point(40, yPos + 15));
            //e.Graphics.DrawString($"Item(s)", new Font("Courier New", 8, FontStyle.Regular), Brushes.Black, new Point(100, yPos + 15));

            //e.Graphics.DrawString("-----------------------------", new Font("Courier New", 8, FontStyle.Regular), Brushes.Black, new Point(5, yPos + 25));

            //// Print total amounts and other details
            //yPos += 30;

            //e.Graphics.DrawString($"TOTAL:", new Font("Courier New", 9, FontStyle.Bold), Brushes.Black, new Point(15, yPos + 5));
            //e.Graphics.DrawString($"{lblTotal.Text}", new Font("Courier New", 9, FontStyle.Bold), Brushes.Black, new Point(120, yPos + 5));

            //e.Graphics.DrawString("-----------------------------", new Font("Courier New", 8, FontStyle.Regular), Brushes.Black, new Point(5, yPos + 20));

            //e.Graphics.DrawString($"PAYMENT RECEIVED:", new Font("Courier New", 8, FontStyle.Regular), Brushes.Black, new Point(5, yPos + 30));
            //e.Graphics.DrawString("0.00", new Font("Courier New", 8, FontStyle.Regular), Brushes.Black, new Point(130, yPos + 30));
            //e.Graphics.DrawString($"CHANGE AMOUNT:", new Font("Courier New", 8, FontStyle.Regular), Brushes.Black, new Point(5, yPos + 45));
            //e.Graphics.DrawString("0.00", new Font("Courier New", 8, FontStyle.Regular), Brushes.Black, new Point(130, yPos + 45));
            //e.Graphics.DrawString($"DISCOUNT:", new Font("Courier New", 8, FontStyle.Regular), Brushes.Black, new Point(5, yPos + 60));
            //e.Graphics.DrawString("0.00", new Font("Courier New", 8, FontStyle.Regular), Brushes.Black, new Point(130, yPos + 60));

            //yPos += 80;

            //e.Graphics.DrawString("OFFICIAL RECEIPT", new Font("Courier New", 8, FontStyle.Regular), Brushes.Black, new Point(40, yPos + 10));
            //e.Graphics.DrawString("Thank you for coming!", new Font("Courier New", 8, FontStyle.Bold), Brushes.Black, new Point(30, yPos + 30));


            //for kot
          
			// Print header information
			e.Graphics.DrawString("Kitchen Order Tickets", new Font("Arial", 6, FontStyle.Bold), Brushes.Black, new Point(10, 10));
			e.Graphics.DrawString($"Date: {DateTime.Now.ToShortDateString()}", new Font("Arial", 6, FontStyle.Regular), Brushes.Black, new Point(10, 20));
			e.Graphics.DrawString($"Order #: {lblOrderNumber.Text}", new Font("Arial", 6, FontStyle.Regular), Brushes.Black, new Point(10, 30));
			e.Graphics.DrawString($"Order Type: {lblOrderType.Text}", new Font("Arial", 6, FontStyle.Regular), Brushes.Black, new Point(10, 40));
			e.Graphics.DrawString($"Table: {lblTable.Text}", new Font("Arial", 6, FontStyle.Regular), Brushes.Black, new Point(10, 50));
			e.Graphics.DrawString("-------------------------------------------", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, new Point(10, 60));

			// Reset yPos for printing item details for KOT
			int yPos = 80;

			// Add header
			e.Graphics.DrawString("Item Name", new Font("Arial", 6, FontStyle.Bold), Brushes.Black, new Point(10, yPos));
			e.Graphics.DrawString("Qty", new Font("Arial", 6, FontStyle.Bold), Brushes.Black, new Point(100, yPos));

			yPos += 10;

			// Print item details for KOT
			foreach (var item in selectedProducts)
			{
				Product product = products.FirstOrDefault(p => p.Id == item.ProID);
				if (product != null)
				{
					e.Graphics.DrawString(product.ItemName, new Font("Arial", 6, FontStyle.Regular), Brushes.Black, new Point(10, yPos));
					e.Graphics.DrawString(item.Quantity.ToString(), new Font("Arial", 6, FontStyle.Regular), Brushes.Black, new Point(100, yPos));
					yPos += 10;
				}
			}
		}

        private void RprintDocument_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
			RprintDocument.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("Custom", 230, 550);
		}

        private void btnTable_Click(object sender, EventArgs e)
        {
			frmViewTable select = new frmViewTable();
			if (select.ShowDialog() == DialogResult.OK)
			{
				lblTable.Text = select.tableName;
				tblId = select.id; //04.08.2024

				lblTable.Visible = !string.IsNullOrEmpty(select.tableName);
			}


		}
	}
}
