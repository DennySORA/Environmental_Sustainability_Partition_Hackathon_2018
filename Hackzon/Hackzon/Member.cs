using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackzon
{
	class Member
	{
		public string UserName { get; set; }
		public int Point { get; set; }
		public string Level { get; set; }
		public GoodsList MemberGoodsList { get; set; }
		
		//Constructor
		public Member(string name, int point, string level)
		{
			UserName = name;
			Point = point;
			Level = level;
			MemberGoodsList = new GoodsList();
		}
		public void DecreasePoint(int point)
		{
			Point -= point;
		}
	}
}
