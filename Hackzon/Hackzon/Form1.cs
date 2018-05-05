using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hackzon
{
	public partial class Form1 : Form
	{
		private Model _model = new Model();
		delegate void PrintHandler(Label lb, string text);
		public Form1()
		{
			InitializeComponent();
			string path1 = System.AppDomain.CurrentDomain.BaseDirectory + "..\\..\\GoodsList.txt";
			string path2 = System.AppDomain.CurrentDomain.BaseDirectory + "..\\..\\MemberList.txt";
			using (StreamReader r = new StreamReader(path1))
			{
				string json = r.ReadToEnd();
				_model.EditGoodList = JsonConvert.DeserializeObject<GoodsList>(json);
			}
			using (StreamReader r = new StreamReader(path2))
			{
				string json = r.ReadToEnd();
				_model.MemberList = JsonConvert.DeserializeObject<MemberList>(json);
			}
			Thread socketThread = new Thread(ReceiveSocket);
			socketThread.Start();
			Update();
			UpdateUserOwnList(0);
		}
		public void Print(Label lb, string text)
		{
			//判斷這個TextBox的物件是否在同一個執行緒上
			if (lb.InvokeRequired)
			{
				//當InvokeRequired為true時，表示在不同的執行緒上，所以進行委派的動作!!
				PrintHandler ph = new PrintHandler(Print);
				lb.Invoke(ph, lb, text);
			}
			else
			{
				//表示在同一個執行緒上了，所以可以正常的呼叫到這個TextBox物件
				lb.Text = _model.MemberList.AllMemberList[0].Point.ToString();
			}
		}
		private void ReceiveSocket()
		{
			while (true)
			{
				_model.AddPoint();
				Print(_userPointLabel, _model.MemberList.AllMemberList[0].Point.ToString());
			}
		}
		private void Update()
		{
			_editView.Rows.Clear();
			_goodsView.Rows.Clear();
			for(int i=0; i< _model.EditGoodList.AllGoodsList.Count(); i++)
			{
				string name = _model.EditGoodList.AllGoodsList[i].GoodsName;
				int price = _model.EditGoodList.AllGoodsList[i].Price;
				int amount = _model.EditGoodList.AllGoodsList[i].Amount;
				_editView.Rows.Add(name, price, amount ,"刪除");
				_goodsView.Rows.Add(name, price, amount, "購買");
			}
			string path1 =  System.AppDomain.CurrentDomain.BaseDirectory  + "..\\..\\GoodsList.txt" ;
			string path2 = System.AppDomain.CurrentDomain.BaseDirectory + "..\\..\\MemberList.txt";
			using (StreamWriter file = File.CreateText(path1))
			{
				JsonSerializer serializer = new JsonSerializer();
				//serialize object directly into file stream
				serializer.Serialize(file, _model.EditGoodList);
			}
			using (StreamWriter file = File.CreateText(path2))
			{
				JsonSerializer serializer = new JsonSerializer();
				//serialize object directly into file stream
				serializer.Serialize(file, _model.MemberList);
			}
			//***********
		}
		private void UpdateUserOwnList(int index)
		{
			_userNameLabel.Text = _model.MemberList.AllMemberList[index].UserName;
			_userPointLabel.Text = _model.MemberList.AllMemberList[index].Point.ToString();
			_ownView.Rows.Clear();
			for(int i = 0; i < _model.MemberList.AllMemberList[index].MemberGoodsList.AllGoodsList.Count(); i++)
			{
				string name = _model.MemberList.AllMemberList[index].MemberGoodsList.AllGoodsList[i].GoodsName;
				int amount = _model.MemberList.AllMemberList[index].MemberGoodsList.AllGoodsList[i].Amount;
				_ownView.Rows.Add(name, amount);
			}
		}
		//*
		//*
		private void PressBuyButton(object sender, DataGridViewCellEventArgs e)
		{
			int userIndex = _model.userId;
			int index = e.RowIndex;
			string name = _model.EditGoodList.AllGoodsList[index].GoodsName;
			int point = _model.EditGoodList.AllGoodsList[index].Price;
			if (_model.MemberList.AllMemberList[userIndex].Point - point >= 0)
			{
				_model.EditGoodList.DecreaseAmoount(index);
				_model.MemberList.DecreasePoint(userIndex, point);
			}
			else
			{
				MessageBox.Show("你的點數不足");
			}
			
			_model.MemberList.AddGoodsList(userIndex, name, -1);
			UpdateUserOwnList(userIndex);
			Update();
		}

		private void RemoveGoods(object sender, DataGridViewCellEventArgs e)
		{
			int index = e.RowIndex;
			_model.EditGoodList.AllGoodsList.RemoveAt(index);
			Update();
		}

		private void AddNewGoods(object sender, EventArgs e)
		{
			string name = _addGoodsNameTextbox.Text;
			int price = int.Parse(_addPriceTextbox.Text);
			int amount = int.Parse(_addAmountTextbox.Text);
			_model.AddGoods(name, price, amount);
			Update();
		}
	}
}
