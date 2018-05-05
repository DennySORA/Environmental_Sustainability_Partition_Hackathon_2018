using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackzon
{
	class GoodsList
	{
		public List<Goods> AllGoodsList { get; set; }
		
		//Constructor
		public GoodsList()
		{
			AllGoodsList = new List<Goods>();
		}
		//增加商品
		public void AddGoods(string name, int price, int amount)
		{
			AllGoodsList.Add(new Goods(name, price, amount));
		}
		public void DecreaseAmoount(int index)
		{
			AllGoodsList[index].AmountDecrease();
			if (AllGoodsList[index].Amount <= 0)
			{
				AllGoodsList.RemoveAt(index);
			}
		}
	}

}
