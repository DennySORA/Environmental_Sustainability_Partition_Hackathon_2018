using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackzon
{
	class MemberList
	{
		public List<Member> AllMemberList { get; set; }
		//Constructor
		public MemberList()
		{
			AllMemberList = new List<Member>();
		}
		public void AddMember(string name, int point, string level)
		{
			AllMemberList.Add(new Member(name, point, level));
		}
		public void AddGoodsList(int index, string name, int price)
		{
			int goodsIndex = FindGoodsIndex(index, name, price);
			if(goodsIndex == -1)
			{
				AllMemberList[index].MemberGoodsList.AllGoodsList.Add(new Goods(name, price, 1));
			}
			else
			{
				AllMemberList[index].MemberGoodsList.AllGoodsList[goodsIndex].Amount += 1;
			}
		}
		private int FindGoodsIndex(int index, string name, int price)
		{
			int goodsIndex = -1;
			for(int i = 0; i < AllMemberList[index].MemberGoodsList.AllGoodsList.Count(); i++)
			{
				if(AllMemberList[index].MemberGoodsList.AllGoodsList[i].GoodsName == name)
				{
					goodsIndex = i;
				}
			}
			return goodsIndex;
		}
		public void DecreasePoint(int index, int point)
		{
			AllMemberList[index].DecreasePoint(point);
		}
	}
}
