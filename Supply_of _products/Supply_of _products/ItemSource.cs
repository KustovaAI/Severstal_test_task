
namespace Supply_of__products
{
	class ItemSource
	{
		/* The class that stores the data of report. Used in DataGridViewer. */

		public ItemSource(string _name_supplier, string _name_good, string _date, string _weight, string _price, string _total_cost)
		{
			this.name_supplier = _name_supplier;
			this.name_good = _name_good;
			this.date = _date;
			this.weight = _weight;
			this.price = _price;
			this.total_cost = _total_cost;
		}

		public string name_supplier { get; set; }
		public string name_good { get; set; }
		public string date { get; set; }
		public string weight { get; set; }
		public string price { get; set; }
		public string total_cost { get; set; }

	}
}
