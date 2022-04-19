using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Supply_of__products
{
	public partial class Form1 : Form
	{
		DataBaseService db;
		bool is_init = true;

		public Form1()
		{
			InitializeComponent();
			db = new DataBaseService();
			panel3.Visible = false;
			InitializeComponentsFromDb();
		}

		public void InitializeComponentsFromDb()
		{
			// Get suppliers
			Dictionary<string, string> comboSuppliersSource = new Dictionary<string, string>();			
			List<ComboboxItem> list_suppliers = db.GetData("suppliers");
			foreach (ComboboxItem item in list_suppliers)
			{
				comboSuppliersSource.Add(item.Id, item.Text);
			}
			cmbSuppliers.DataSource = new BindingSource(comboSuppliersSource, null);
			cmbSuppliers.DisplayMember = "Value";
			cmbSuppliers.ValueMember = "Key";
			cmbSuppliers.SelectedIndex = 0;

			// Get goods
			Dictionary<string, string> comboGoodsSource = new Dictionary<string, string>();
			List<ComboboxItem> list_goods = db.GetData("goods");
			foreach (ComboboxItem item in list_goods)
			{
				comboGoodsSource.Add(item.Id, item.Text);
			}
			cmbGoods.DataSource = new BindingSource(comboGoodsSource, null);
			cmbGoods.DisplayMember = "Value";
			cmbGoods.ValueMember = "Key";
			cmbGoods.SelectedIndex = 0;

			SetPrice();
			is_init = false;
		}

		public void SetPrice()
		{
			if (cmbSuppliers.SelectedIndex >= 0 && cmbGoods.SelectedIndex >= 0)
			{
				String good_id = cmbGoods.GetItemText(cmbGoods.SelectedValue);
				String suppler_id = cmbSuppliers.GetItemText(cmbSuppliers.SelectedValue);
				
				String price = db.GetPrice(suppler_id, good_id);
				if (price != "error")
				{
					textBoxPrice.Text = price;
				}				
			}
		}

		private void textBoxWeight_TextChanged(object sender, EventArgs e)
		{
			SetPrice();
		}

		private void cmbGoods_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (is_init == false)
				SetPrice();
		}

		private void cmbSuppliers_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (is_init == false)
				SetPrice();
		}

		private void btWrite_Click(object sender, EventArgs e)
		{
			String name_supplier = cmbSuppliers.GetItemText(cmbSuppliers.SelectedItem);
			String name_good = cmbGoods.GetItemText(cmbGoods.SelectedItem);
			DateTime date = dateTimePicker1.Value.Date;
			double weight = Convert.ToDouble(textBoxWeight.Text);
			double price = Convert.ToDouble(textBoxPrice.Text);
			double total_cost = weight * price;

			String res = db.AddNote(name_supplier, name_good, date, weight, price, total_cost);
		}

		private void buttonShowNotes_Click(object sender, EventArgs e)
		{
			List<ItemSource> result = db.GetNotes(datePicker2.Value.Date, datePicker3.Value.Date);
			dataGridView1.DataSource = result;

		}

		private void button_food_intake_Click(object sender, EventArgs e)
		{
			panel2.Visible = true;
			panel3.Visible = false;
			button_food_intake.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			button_report.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
		}


		private void button_report_Click(object sender, EventArgs e)
		{
			panel3.Visible = true;
			panel2.Visible = false;			
			button_food_intake.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			button_report.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
		}
	}
}
