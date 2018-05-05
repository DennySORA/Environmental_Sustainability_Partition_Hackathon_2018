namespace Hackzon
{
	partial class Form1
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			this._page4 = new System.Windows.Forms.TabControl();
			this._page1 = new System.Windows.Forms.TabPage();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this._page2 = new System.Windows.Forms.TabPage();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this._goodsView = new System.Windows.Forms.DataGridView();
			this._goodsColume = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this._priceColume = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this._amountCloume = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this._buyButton = new System.Windows.Forms.DataGridViewButtonColumn();
			this._groupBox1 = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this._userNameLabel = new System.Windows.Forms.Label();
			this._userPointLabel = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this._ownView = new System.Windows.Forms.DataGridView();
			this._ownGoodsNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this._ownGoodsAmountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this._page3 = new System.Windows.Forms.TabPage();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this._addPriceTextbox = new System.Windows.Forms.TextBox();
			this._addAmountTextbox = new System.Windows.Forms.TextBox();
			this._addGoodsNameTextbox = new System.Windows.Forms.TextBox();
			this._addButton = new System.Windows.Forms.Button();
			this._editView = new System.Windows.Forms.DataGridView();
			this._editGoodsColume = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this._editPriceColume = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this._editAmountColume = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this._deleteButton = new System.Windows.Forms.DataGridViewButtonColumn();
			this.label6 = new System.Windows.Forms.Label();
			this._page4.SuspendLayout();
			this._page1.SuspendLayout();
			this._page2.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this._goodsView)).BeginInit();
			this._groupBox1.SuspendLayout();
			this.tableLayoutPanel5.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this._ownView)).BeginInit();
			this._page3.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			this.tableLayoutPanel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this._editView)).BeginInit();
			this.SuspendLayout();
			// 
			// _page4
			// 
			this._page4.Controls.Add(this._page1);
			this._page4.Controls.Add(this._page2);
			this._page4.Controls.Add(this._page3);
			this._page4.Dock = System.Windows.Forms.DockStyle.Fill;
			this._page4.Location = new System.Drawing.Point(0, 0);
			this._page4.Name = "_page4";
			this._page4.SelectedIndex = 0;
			this._page4.Size = new System.Drawing.Size(687, 450);
			this._page4.TabIndex = 1;
			// 
			// _page1
			// 
			this._page1.Controls.Add(this.tableLayoutPanel1);
			this._page1.ForeColor = System.Drawing.Color.Chocolate;
			this._page1.Location = new System.Drawing.Point(4, 22);
			this._page1.Name = "_page1";
			this._page1.Padding = new System.Windows.Forms.Padding(3);
			this._page1.Size = new System.Drawing.Size(679, 424);
			this._page1.TabIndex = 0;
			this._page1.Text = "首頁";
			this._page1.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Location = new System.Drawing.Point(130, 53);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(330, 232);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// _page2
			// 
			this._page2.Controls.Add(this.tableLayoutPanel2);
			this._page2.Location = new System.Drawing.Point(4, 22);
			this._page2.Name = "_page2";
			this._page2.Padding = new System.Windows.Forms.Padding(3);
			this._page2.Size = new System.Drawing.Size(679, 424);
			this._page2.TabIndex = 1;
			this._page2.Text = "兌換";
			this._page2.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 2;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.07875F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.92125F));
			this.tableLayoutPanel2.Controls.Add(this._goodsView, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this._groupBox1, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.groupBox1, 0, 1);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 2;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 59.09091F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.90909F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(673, 418);
			this.tableLayoutPanel2.TabIndex = 0;
			// 
			// _goodsView
			// 
			this._goodsView.AllowUserToAddRows = false;
			this._goodsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this._goodsView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._goodsColume,
            this._priceColume,
            this._amountCloume,
            this._buyButton});
			this._goodsView.Dock = System.Windows.Forms.DockStyle.Fill;
			this._goodsView.Location = new System.Drawing.Point(265, 3);
			this._goodsView.Name = "_goodsView";
			this._goodsView.RowHeadersVisible = false;
			this.tableLayoutPanel2.SetRowSpan(this._goodsView, 2);
			this._goodsView.RowTemplate.Height = 24;
			this._goodsView.Size = new System.Drawing.Size(405, 412);
			this._goodsView.TabIndex = 0;
			this._goodsView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PressBuyButton);
			// 
			// _goodsColume
			// 
			this._goodsColume.HeaderText = "優惠名稱";
			this._goodsColume.Name = "_goodsColume";
			// 
			// _priceColume
			// 
			this._priceColume.HeaderText = "需求點數";
			this._priceColume.Name = "_priceColume";
			// 
			// _amountCloume
			// 
			this._amountCloume.HeaderText = "剩餘數量";
			this._amountCloume.Name = "_amountCloume";
			// 
			// _buyButton
			// 
			this._buyButton.HeaderText = "";
			this._buyButton.Name = "_buyButton";
			// 
			// _groupBox1
			// 
			this._groupBox1.Controls.Add(this.tableLayoutPanel5);
			this._groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this._groupBox1.Location = new System.Drawing.Point(3, 3);
			this._groupBox1.Name = "_groupBox1";
			this._groupBox1.Size = new System.Drawing.Size(256, 241);
			this._groupBox1.TabIndex = 1;
			this._groupBox1.TabStop = false;
			this._groupBox1.Text = "個人資料";
			// 
			// tableLayoutPanel5
			// 
			this.tableLayoutPanel5.ColumnCount = 3;
			this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.53846F));
			this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.46154F));
			this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 83F));
			this.tableLayoutPanel5.Controls.Add(this.label4, 0, 0);
			this.tableLayoutPanel5.Controls.Add(this.label5, 0, 1);
			this.tableLayoutPanel5.Controls.Add(this._userNameLabel, 2, 0);
			this.tableLayoutPanel5.Controls.Add(this._userPointLabel, 2, 1);
			this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 18);
			this.tableLayoutPanel5.Name = "tableLayoutPanel5";
			this.tableLayoutPanel5.RowCount = 3;
			this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.55556F));
			this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.44444F));
			this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 163F));
			this.tableLayoutPanel5.Size = new System.Drawing.Size(250, 220);
			this.tableLayoutPanel5.TabIndex = 0;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label4.Location = new System.Drawing.Point(3, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(96, 25);
			this.label4.TabIndex = 0;
			this.label4.Text = "使用者名稱";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label5.Location = new System.Drawing.Point(3, 25);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(96, 31);
			this.label5.TabIndex = 1;
			this.label5.Text = "持有點數";
			// 
			// _userNameLabel
			// 
			this._userNameLabel.AutoSize = true;
			this._userNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this._userNameLabel.Location = new System.Drawing.Point(169, 0);
			this._userNameLabel.Name = "_userNameLabel";
			this._userNameLabel.Size = new System.Drawing.Size(78, 25);
			this._userNameLabel.TabIndex = 2;
			// 
			// _userPointLabel
			// 
			this._userPointLabel.AutoSize = true;
			this._userPointLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this._userPointLabel.Location = new System.Drawing.Point(169, 25);
			this._userPointLabel.Name = "_userPointLabel";
			this._userPointLabel.Size = new System.Drawing.Size(78, 31);
			this._userPointLabel.TabIndex = 3;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this._ownView);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox1.Location = new System.Drawing.Point(3, 250);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(256, 165);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "使用者擁有優惠";
			// 
			// _ownView
			// 
			this._ownView.AllowUserToAddRows = false;
			this._ownView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this._ownView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._ownGoodsNameColumn,
            this._ownGoodsAmountColumn});
			this._ownView.Dock = System.Windows.Forms.DockStyle.Fill;
			this._ownView.Location = new System.Drawing.Point(3, 18);
			this._ownView.Name = "_ownView";
			this._ownView.RowHeadersVisible = false;
			this._ownView.RowTemplate.Height = 24;
			this._ownView.Size = new System.Drawing.Size(250, 144);
			this._ownView.TabIndex = 3;
			// 
			// _ownGoodsNameColumn
			// 
			this._ownGoodsNameColumn.HeaderText = "優惠名稱";
			this._ownGoodsNameColumn.Name = "_ownGoodsNameColumn";
			// 
			// _ownGoodsAmountColumn
			// 
			this._ownGoodsAmountColumn.HeaderText = "數量";
			this._ownGoodsAmountColumn.Name = "_ownGoodsAmountColumn";
			// 
			// _page3
			// 
			this._page3.Controls.Add(this.tableLayoutPanel3);
			this._page3.Location = new System.Drawing.Point(4, 22);
			this._page3.Name = "_page3";
			this._page3.Padding = new System.Windows.Forms.Padding(3);
			this._page3.Size = new System.Drawing.Size(679, 424);
			this._page3.TabIndex = 2;
			this._page3.Text = "編輯商品";
			this._page3.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.ColumnCount = 2;
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.71953F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.28046F));
			this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 1);
			this.tableLayoutPanel3.Controls.Add(this._editView, 1, 0);
			this.tableLayoutPanel3.Controls.Add(this.label6, 0, 0);
			this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 2;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.74641F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.25359F));
			this.tableLayoutPanel3.Size = new System.Drawing.Size(673, 418);
			this.tableLayoutPanel3.TabIndex = 0;
			// 
			// tableLayoutPanel4
			// 
			this.tableLayoutPanel4.ColumnCount = 3;
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.98113F));
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.01887F));
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 101F));
			this.tableLayoutPanel4.Controls.Add(this.label1, 0, 1);
			this.tableLayoutPanel4.Controls.Add(this.label2, 0, 0);
			this.tableLayoutPanel4.Controls.Add(this.label3, 0, 2);
			this.tableLayoutPanel4.Controls.Add(this._addPriceTextbox, 2, 1);
			this.tableLayoutPanel4.Controls.Add(this._addAmountTextbox, 2, 2);
			this.tableLayoutPanel4.Controls.Add(this._addGoodsNameTextbox, 2, 0);
			this.tableLayoutPanel4.Controls.Add(this._addButton, 2, 3);
			this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 281);
			this.tableLayoutPanel4.Name = "tableLayoutPanel4";
			this.tableLayoutPanel4.RowCount = 4;
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.23077F));
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.76923F));
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel4.Size = new System.Drawing.Size(207, 134);
			this.tableLayoutPanel4.TabIndex = 6;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Location = new System.Drawing.Point(3, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(65, 34);
			this.label1.TabIndex = 0;
			this.label1.Text = "要求點數";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label2.Location = new System.Drawing.Point(3, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(65, 32);
			this.label2.TabIndex = 1;
			this.label2.Text = "商品名稱";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label3.Location = new System.Drawing.Point(3, 66);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(65, 34);
			this.label3.TabIndex = 2;
			this.label3.Text = "剩餘數量";
			// 
			// _addPriceTextbox
			// 
			this._addPriceTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
			this._addPriceTextbox.Location = new System.Drawing.Point(109, 35);
			this._addPriceTextbox.Name = "_addPriceTextbox";
			this._addPriceTextbox.Size = new System.Drawing.Size(95, 22);
			this._addPriceTextbox.TabIndex = 4;
			// 
			// _addAmountTextbox
			// 
			this._addAmountTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
			this._addAmountTextbox.Location = new System.Drawing.Point(109, 69);
			this._addAmountTextbox.Name = "_addAmountTextbox";
			this._addAmountTextbox.Size = new System.Drawing.Size(95, 22);
			this._addAmountTextbox.TabIndex = 5;
			// 
			// _addGoodsNameTextbox
			// 
			this._addGoodsNameTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
			this._addGoodsNameTextbox.Location = new System.Drawing.Point(109, 3);
			this._addGoodsNameTextbox.Name = "_addGoodsNameTextbox";
			this._addGoodsNameTextbox.Size = new System.Drawing.Size(95, 22);
			this._addGoodsNameTextbox.TabIndex = 3;
			// 
			// _addButton
			// 
			this._addButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this._addButton.Location = new System.Drawing.Point(109, 103);
			this._addButton.Name = "_addButton";
			this._addButton.Size = new System.Drawing.Size(95, 28);
			this._addButton.TabIndex = 7;
			this._addButton.Text = "新增";
			this._addButton.UseVisualStyleBackColor = true;
			this._addButton.Click += new System.EventHandler(this.AddNewGoods);
			// 
			// _editView
			// 
			this._editView.AllowUserToAddRows = false;
			this._editView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this._editView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._editGoodsColume,
            this._editPriceColume,
            this._editAmountColume,
            this._deleteButton});
			this._editView.Dock = System.Windows.Forms.DockStyle.Fill;
			this._editView.Location = new System.Drawing.Point(216, 3);
			this._editView.Name = "_editView";
			this._editView.RowHeadersVisible = false;
			this.tableLayoutPanel3.SetRowSpan(this._editView, 2);
			this._editView.RowTemplate.Height = 24;
			this._editView.Size = new System.Drawing.Size(454, 412);
			this._editView.TabIndex = 0;
			this._editView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RemoveGoods);
			// 
			// _editGoodsColume
			// 
			this._editGoodsColume.HeaderText = "商品名稱";
			this._editGoodsColume.Name = "_editGoodsColume";
			// 
			// _editPriceColume
			// 
			this._editPriceColume.HeaderText = "要求點數";
			this._editPriceColume.Name = "_editPriceColume";
			// 
			// _editAmountColume
			// 
			this._editAmountColume.HeaderText = "剩餘數量";
			this._editAmountColume.Name = "_editAmountColume";
			// 
			// _deleteButton
			// 
			this._deleteButton.HeaderText = "";
			this._deleteButton.Name = "_deleteButton";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label6.Font = new System.Drawing.Font("新細明體", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label6.Location = new System.Drawing.Point(3, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(207, 278);
			this.label6.TabIndex = 7;
			this.label6.Text = "廣告";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(687, 450);
			this.Controls.Add(this._page4);
			this.Name = "Form1";
			this.Text = "Form1";
			this._page4.ResumeLayout(false);
			this._page1.ResumeLayout(false);
			this._page2.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this._goodsView)).EndInit();
			this._groupBox1.ResumeLayout(false);
			this.tableLayoutPanel5.ResumeLayout(false);
			this.tableLayoutPanel5.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this._ownView)).EndInit();
			this._page3.ResumeLayout(false);
			this.tableLayoutPanel3.ResumeLayout(false);
			this.tableLayoutPanel3.PerformLayout();
			this.tableLayoutPanel4.ResumeLayout(false);
			this.tableLayoutPanel4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this._editView)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl _page4;
		private System.Windows.Forms.TabPage _page1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TabPage _page2;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.DataGridView _goodsView;
		private System.Windows.Forms.DataGridViewTextBoxColumn _goodsColume;
		private System.Windows.Forms.DataGridViewTextBoxColumn _priceColume;
		private System.Windows.Forms.DataGridViewTextBoxColumn _amountCloume;
		private System.Windows.Forms.DataGridViewButtonColumn _buyButton;
		private System.Windows.Forms.TabPage _page3;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
		private System.Windows.Forms.DataGridView _editView;
		private System.Windows.Forms.DataGridViewTextBoxColumn _editGoodsColume;
		private System.Windows.Forms.DataGridViewTextBoxColumn _editPriceColume;
		private System.Windows.Forms.DataGridViewTextBoxColumn _editAmountColume;
		private System.Windows.Forms.DataGridViewButtonColumn _deleteButton;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox _addPriceTextbox;
		private System.Windows.Forms.TextBox _addAmountTextbox;
		private System.Windows.Forms.TextBox _addGoodsNameTextbox;
		private System.Windows.Forms.Button _addButton;
		private System.Windows.Forms.GroupBox _groupBox1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label _userNameLabel;
		private System.Windows.Forms.Label _userPointLabel;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DataGridView _ownView;
		private System.Windows.Forms.DataGridViewTextBoxColumn _ownGoodsNameColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn _ownGoodsAmountColumn;
		private System.Windows.Forms.Label label6;
	}
}

