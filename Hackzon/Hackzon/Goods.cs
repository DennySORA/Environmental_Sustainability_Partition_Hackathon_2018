using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackzon
{
	class Goods
	{
		public string GoodsName { get; set; }
		public int Price { get; set; }
		public int Amount { get; set; }
		//Constructor
		public Goods(string name, int price, int amount)
		{
			GoodsName = name;
			Price = price;
			Amount = amount;
		}
		public void AmountDecrease()
		{
			Amount -= 1;
		}
	}
}
