using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Npgsql;

namespace Supply_of__products
{
	class DataBaseService
	{
		NpgsqlConnection nc;
		String conn_param = "Server=127.0.0.1;Port=5433;User Id=postgres;Password=rootroot;Database=severstal";

		public DataBaseService()
		{
			nc = new NpgsqlConnection(conn_param);
		}

		public List<ComboboxItem> GetData(String needed_data)
		{
			List<ComboboxItem> result = new List<ComboboxItem>();
			try
			{
				NpgsqlCommand com = new NpgsqlCommand("SELECT id, name FROM " + needed_data, nc);
				nc.Open();  //ОpenConnection
				NpgsqlDataReader reader;
				reader = com.ExecuteReader();
				while (reader.Read())
				{
					try
					{
						ComboboxItem item = new ComboboxItem();
						item.Id = reader.GetInt32(0).ToString();
						item.Text = reader.GetString(1);
						result.Add(item);
					}
					catch (Exception ex)
					{
						Console.WriteLine(ex.Message);
					}

				}
				nc.Close();
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				return result;
			}
			return result;
		}

		public String GetPrice(String supplier_id, String good_id)
		{
			String price = "";
			try
			{
				NpgsqlCommand com = new NpgsqlCommand("SELECT price FROM goods_of_suppliers_table WHERE supplier_id=" 
					+ supplier_id + " AND good_id=" + good_id, nc);
				nc.Open();  //ОpenConnection
				NpgsqlDataReader reader;
				reader = com.ExecuteReader();
				while (reader.Read())
				{
					try
					{
						price = reader.GetDouble(0).ToString();
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.ToString());
						return "error";
					}

				}
				nc.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
				return "error";
			}
			return price;
		}

		public String AddNote(String name_supplier, String name_good, DateTime date, double weight, double price, double total_cost)
		{
			String new_weight= weight.ToString(System.Globalization.CultureInfo.GetCultureInfo("en-US"));
			string sql1 = "INSERT INTO report_table(name_supplier,name_good,date,weight,price,total_cost) VALUES ('" +
				name_supplier + "','" + name_good + "','" + date + "','" + weight.ToString(System.Globalization.CultureInfo.GetCultureInfo("en-US"))
				+ "','" + price.ToString(System.Globalization.CultureInfo.GetCultureInfo("en-US")) + "','" + total_cost.ToString(System.Globalization.CultureInfo.GetCultureInfo("en-US")) + "')";
			String res = RequestToDB(sql1);
			if (res != "ok")
				MessageBox.Show(res);
			return res;
		}


		public String RequestToDB(String sql1)
		{
			try
			{
				nc.Open();
				NpgsqlCommand dbcmd = nc.CreateCommand();
				try
				{
					dbcmd.CommandText = sql1;
					dbcmd.ExecuteNonQuery();
				}
				catch (Exception ex)
				{
					Console.WriteLine(ex.Message);
					return ex.Message.ToString();
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				return ex.Message.ToString();
			}
			nc.Close();
			return "ok";
		}


		public List<ItemSource> GetNotes(DateTime start_date, DateTime end_date)
		{
			List<ItemSource> result = new List<ItemSource>();
			try
			{
				NpgsqlCommand com = new NpgsqlCommand("SELECT * FROM report_table WHERE date BETWEEN '" + start_date + "' AND '" 
					+ end_date + "' ORDER BY date", nc);
				nc.Open();  //ОpenConnection
				NpgsqlDataReader reader;
				reader = com.ExecuteReader();
				while (reader.Read())
				{
					try
					{
						String name_supplier = reader.GetString(1);
						String name_good = reader.GetString(2);
						String date = reader.GetDate(3).ToString();
						String weight = reader.GetDouble(4).ToString();
						String price = reader.GetDouble(5).ToString();
						String total_cost = reader.GetDouble(6).ToString();
						ItemSource item = new ItemSource(name_supplier, name_good, date, weight, price, total_cost);
						result.Add(item);
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.ToString());
					}

				}
				nc.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			return result;
		}

	}
	public class ComboboxItem
	{
		public string Text { get; set; }
		public string Id { get; set; }
		public override string ToString() => Text;
	}

	
}
