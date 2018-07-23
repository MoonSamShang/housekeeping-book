namespace MyHousekeepingBook
{
	partial class ItemForms
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.monCalendar = new System.Windows.Forms.MonthCalendar();
			this.Category = new System.Windows.Forms.Label();
			this.ItemName = new System.Windows.Forms.Label();
			this.Price = new System.Windows.Forms.Label();
			this.Remark = new System.Windows.Forms.Label();
			this.cmbCategory = new System.Windows.Forms.ComboBox();
			this.txtItem = new System.Windows.Forms.TextBox();
			this.txtMoney = new System.Windows.Forms.TextBox();
			this.txtRemarks = new System.Windows.Forms.TextBox();
			this.buttonOK = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// monCalendar
			// 
			this.monCalendar.Location = new System.Drawing.Point(27, 37);
			this.monCalendar.Name = "monCalendar";
			this.monCalendar.TabIndex = 0;
			this.monCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monCalendar_DateChanged);
			// 
			// Category
			// 
			this.Category.AutoSize = true;
			this.Category.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Bold);
			this.Category.Location = new System.Drawing.Point(265, 50);
			this.Category.Name = "Category";
			this.Category.Size = new System.Drawing.Size(35, 13);
			this.Category.TabIndex = 1;
			this.Category.Text = "分類";
			// 
			// ItemName
			// 
			this.ItemName.AutoSize = true;
			this.ItemName.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Bold);
			this.ItemName.Location = new System.Drawing.Point(265, 83);
			this.ItemName.Name = "ItemName";
			this.ItemName.Size = new System.Drawing.Size(35, 13);
			this.ItemName.TabIndex = 2;
			this.ItemName.Text = "品名";
			// 
			// Price
			// 
			this.Price.AutoSize = true;
			this.Price.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Bold);
			this.Price.Location = new System.Drawing.Point(265, 123);
			this.Price.Name = "Price";
			this.Price.Size = new System.Drawing.Size(35, 13);
			this.Price.TabIndex = 3;
			this.Price.Text = "金額";
			// 
			// Remark
			// 
			this.Remark.AutoSize = true;
			this.Remark.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Bold);
			this.Remark.Location = new System.Drawing.Point(265, 165);
			this.Remark.Name = "Remark";
			this.Remark.Size = new System.Drawing.Size(35, 13);
			this.Remark.TabIndex = 4;
			this.Remark.Text = "備考";
			// 
			// cmbCategory
			// 
			this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbCategory.FormattingEnabled = true;
			this.cmbCategory.Location = new System.Drawing.Point(349, 47);
			this.cmbCategory.Name = "cmbCategory";
			this.cmbCategory.Size = new System.Drawing.Size(121, 20);
			this.cmbCategory.TabIndex = 5;
			// 
			// txtItem
			// 
			this.txtItem.Location = new System.Drawing.Point(349, 83);
			this.txtItem.Name = "txtItem";
			this.txtItem.Size = new System.Drawing.Size(100, 19);
			this.txtItem.TabIndex = 6;
			// 
			// txtMoney
			// 
			this.txtMoney.Location = new System.Drawing.Point(349, 123);
			this.txtMoney.Name = "txtMoney";
			this.txtMoney.Size = new System.Drawing.Size(100, 19);
			this.txtMoney.TabIndex = 7;
			// 
			// txtRemarks
			// 
			this.txtRemarks.Location = new System.Drawing.Point(349, 165);
			this.txtRemarks.Name = "txtRemarks";
			this.txtRemarks.Size = new System.Drawing.Size(100, 19);
			this.txtRemarks.TabIndex = 8;
			// 
			// buttonOK
			// 
			this.buttonOK.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonOK.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Bold);
			this.buttonOK.Location = new System.Drawing.Point(27, 230);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(80, 30);
			this.buttonOK.TabIndex = 9;
			this.buttonOK.Text = "登録";
			this.buttonOK.UseVisualStyleBackColor = false;
			// 
			// buttonCancel
			// 
			this.buttonCancel.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Bold);
			this.buttonCancel.Location = new System.Drawing.Point(349, 230);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(80, 30);
			this.buttonCancel.TabIndex = 10;
			this.buttonCancel.Text = "キャンセル";
			this.buttonCancel.UseVisualStyleBackColor = false;
			// 
			// ItemForms
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(520, 291);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonOK);
			this.Controls.Add(this.txtRemarks);
			this.Controls.Add(this.txtMoney);
			this.Controls.Add(this.txtItem);
			this.Controls.Add(this.cmbCategory);
			this.Controls.Add(this.Remark);
			this.Controls.Add(this.Price);
			this.Controls.Add(this.ItemName);
			this.Controls.Add(this.Category);
			this.Controls.Add(this.monCalendar);
			this.Name = "ItemForms";
			this.Text = "登録";
			this.Load += new System.EventHandler(this.ItemForms_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MonthCalendar monCalendar;
		private System.Windows.Forms.Label Category;
		private System.Windows.Forms.Label ItemName;
		private System.Windows.Forms.Label Price;
		private System.Windows.Forms.Label Remark;
		private System.Windows.Forms.ComboBox cmbCategory;
		private System.Windows.Forms.TextBox txtItem;
		private System.Windows.Forms.TextBox txtMoney;
		private System.Windows.Forms.TextBox txtRemarks;
		private System.Windows.Forms.Button buttonOK;
		private System.Windows.Forms.Button buttonCancel;
	}
}