using SocketClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Hackzon
{

	class Model
	{
		public int userId = 0; 
		public MemberList MemberList { get; set; }
		public GoodsList EditGoodList { get; set; }
		public SocketClientClass _socketClient = new SocketClientClass();
		public Model()
		{
			MemberList = new MemberList();
			EditGoodList = new GoodsList();
			//MemberList.AddMember("johnson", 1000, "使用者");
		}
		public void AddGoods( string name, int price, int amount)
		{
			EditGoodList.AddGoods(name, price, amount);
		}
		public void AddPoint()
		{
			int point = _socketClient.GetValue();
			MemberList.AllMemberList[userId].Point += point;
		}
	}
}
