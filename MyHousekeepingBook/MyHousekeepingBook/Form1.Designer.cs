namespace MyHousekeepingBook
{
	partial class Form1
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
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.MainMenu = new System.Windows.Forms.MenuStrip();
			this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.SaveStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.編集EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.追加AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.変更CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.削除DToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.表示VToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.一覧表LToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.集計表示SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ヘルプHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.バージョン情報VToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.dgv = new System.Windows.Forms.DataGridView();
			this.日付DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.分類DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.品名DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.金額DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.備考DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.moneyDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.moneyDataSet = new MyHousekeepingBook.MoneyDataSet();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.buttonChange = new System.Windows.Forms.Button();
			this.buttonDelete = new System.Windows.Forms.Button();
			this.buttonEnd = new System.Windows.Forms.Button();
			this.tabSummary = new System.Windows.Forms.TabPage();
			this.SumDgv = new System.Windows.Forms.DataGridView();
			this.日付DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.入金合計DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.sumDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.summaryDataSet = new MyHousekeepingBook.SummaryDataSet();
			this.tabList = new System.Windows.Forms.TabPage();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.categoryDataSet1 = new MyHousekeepingBook.CategoryDataSet();
			this.MainMenu.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.moneyDataTableBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.moneyDataSet)).BeginInit();
			this.tabSummary.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.SumDgv)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sumDataTableBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.summaryDataSet)).BeginInit();
			this.tabList.SuspendLayout();
			this.tabControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.categoryDataSet1)).BeginInit();
			this.SuspendLayout();
			// 
			// MainMenu
			// 
			this.MainMenu.BackColor = System.Drawing.SystemColors.Control;
			this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.編集EToolStripMenuItem,
            this.表示VToolStripMenuItem,
            this.ヘルプHToolStripMenuItem});
			this.MainMenu.Location = new System.Drawing.Point(0, 0);
			this.MainMenu.Name = "MainMenu";
			this.MainMenu.Size = new System.Drawing.Size(656, 24);
			this.MainMenu.TabIndex = 2;
			// 
			// FileToolStripMenuItem
			// 
			this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveStripMenuItem,
            this.ExitToolStripMenuItem});
			this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
			this.FileToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
			this.FileToolStripMenuItem.Text = "ファイル(&F)";
			// 
			// SaveStripMenuItem
			// 
			this.SaveStripMenuItem.Name = "SaveStripMenuItem";
			this.SaveStripMenuItem.Size = new System.Drawing.Size(113, 22);
			this.SaveStripMenuItem.Text = "保存(S)";
			this.SaveStripMenuItem.Click += new System.EventHandler(this.SaveStripMenuItem_Click);
			// 
			// ExitToolStripMenuItem
			// 
			this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
			this.ExitToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
			this.ExitToolStripMenuItem.Text = "終了(&X)";
			this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
			// 
			// 編集EToolStripMenuItem
			// 
			this.編集EToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.追加AToolStripMenuItem,
            this.変更CToolStripMenuItem,
            this.削除DToolStripMenuItem});
			this.編集EToolStripMenuItem.Name = "編集EToolStripMenuItem";
			this.編集EToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
			this.編集EToolStripMenuItem.Text = "編集(&E)";
			// 
			// 追加AToolStripMenuItem
			// 
			this.追加AToolStripMenuItem.Name = "追加AToolStripMenuItem";
			this.追加AToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
			this.追加AToolStripMenuItem.Text = "追加(&A)";
			this.追加AToolStripMenuItem.Click += new System.EventHandler(this.追加AToolStripMenuItem_Click);
			// 
			// 変更CToolStripMenuItem
			// 
			this.変更CToolStripMenuItem.Name = "変更CToolStripMenuItem";
			this.変更CToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
			this.変更CToolStripMenuItem.Text = "変更(&C)";
			this.変更CToolStripMenuItem.Click += new System.EventHandler(this.変更CToolStripMenuItem_Click);
			// 
			// 削除DToolStripMenuItem
			// 
			this.削除DToolStripMenuItem.Name = "削除DToolStripMenuItem";
			this.削除DToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
			this.削除DToolStripMenuItem.Text = "削除(&D)";
			this.削除DToolStripMenuItem.Click += new System.EventHandler(this.削除DToolStripMenuItem_Click);
			// 
			// 表示VToolStripMenuItem
			// 
			this.表示VToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.一覧表LToolStripMenuItem,
            this.集計表示SToolStripMenuItem});
			this.表示VToolStripMenuItem.Name = "表示VToolStripMenuItem";
			this.表示VToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
			this.表示VToolStripMenuItem.Text = "表示(&V)";
			// 
			// 一覧表LToolStripMenuItem
			// 
			this.一覧表LToolStripMenuItem.Name = "一覧表LToolStripMenuItem";
			this.一覧表LToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
			this.一覧表LToolStripMenuItem.Text = "一覧表(&L)";
			this.一覧表LToolStripMenuItem.Click += new System.EventHandler(this.一覧表LToolStripMenuItem_Click);
			// 
			// 集計表示SToolStripMenuItem
			// 
			this.集計表示SToolStripMenuItem.Name = "集計表示SToolStripMenuItem";
			this.集計表示SToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
			this.集計表示SToolStripMenuItem.Text = "集計表示(&S)";
			this.集計表示SToolStripMenuItem.Click += new System.EventHandler(this.集計表示SToolStripMenuItem_Click);
			// 
			// ヘルプHToolStripMenuItem
			// 
			this.ヘルプHToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.バージョン情報VToolStripMenuItem});
			this.ヘルプHToolStripMenuItem.Name = "ヘルプHToolStripMenuItem";
			this.ヘルプHToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
			this.ヘルプHToolStripMenuItem.Text = "ヘルプ(&H)";
			// 
			// バージョン情報VToolStripMenuItem
			// 
			this.バージョン情報VToolStripMenuItem.Name = "バージョン情報VToolStripMenuItem";
			this.バージョン情報VToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
			this.バージョン情報VToolStripMenuItem.Text = "バージョン情報(&V)";
			// 
			// dgv
			// 
			this.dgv.AutoGenerateColumns = false;
			this.dgv.BackgroundColor = System.Drawing.SystemColors.MenuBar;
			this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
			this.dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Snow;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgv.ColumnHeadersHeight = 30;
			this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.日付DataGridViewTextBoxColumn,
            this.分類DataGridViewTextBoxColumn,
            this.品名DataGridViewTextBoxColumn,
            this.金額DataGridViewTextBoxColumn,
            this.備考DataGridViewTextBoxColumn});
			this.dgv.DataSource = this.moneyDataTableBindingSource;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.Bisque;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgv.DefaultCellStyle = dataGridViewCellStyle2;
			this.dgv.GridColor = System.Drawing.Color.SeaShell;
			this.dgv.Location = new System.Drawing.Point(-4, 0);
			this.dgv.Name = "dgv";
			this.dgv.RowHeadersWidth = 60;
			this.dgv.RowTemplate.Height = 21;
			this.dgv.Size = new System.Drawing.Size(658, 347);
			this.dgv.TabIndex = 3;
			// 
			// 日付DataGridViewTextBoxColumn
			// 
			this.日付DataGridViewTextBoxColumn.DataPropertyName = "日付";
			this.日付DataGridViewTextBoxColumn.HeaderText = "日付";
			this.日付DataGridViewTextBoxColumn.Name = "日付DataGridViewTextBoxColumn";
			// 
			// 分類DataGridViewTextBoxColumn
			// 
			this.分類DataGridViewTextBoxColumn.DataPropertyName = "分類";
			this.分類DataGridViewTextBoxColumn.HeaderText = "分類";
			this.分類DataGridViewTextBoxColumn.Name = "分類DataGridViewTextBoxColumn";
			// 
			// 品名DataGridViewTextBoxColumn
			// 
			this.品名DataGridViewTextBoxColumn.DataPropertyName = "品名";
			this.品名DataGridViewTextBoxColumn.HeaderText = "品名";
			this.品名DataGridViewTextBoxColumn.Name = "品名DataGridViewTextBoxColumn";
			// 
			// 金額DataGridViewTextBoxColumn
			// 
			this.金額DataGridViewTextBoxColumn.DataPropertyName = "金額";
			this.金額DataGridViewTextBoxColumn.HeaderText = "金額";
			this.金額DataGridViewTextBoxColumn.Name = "金額DataGridViewTextBoxColumn";
			// 
			// 備考DataGridViewTextBoxColumn
			// 
			this.備考DataGridViewTextBoxColumn.DataPropertyName = "備考";
			this.備考DataGridViewTextBoxColumn.HeaderText = "備考";
			this.備考DataGridViewTextBoxColumn.Name = "備考DataGridViewTextBoxColumn";
			// 
			// moneyDataTableBindingSource
			// 
			this.moneyDataTableBindingSource.DataMember = "moneyDataTable";
			this.moneyDataTableBindingSource.DataSource = this.moneyDataSet;
			// 
			// moneyDataSet
			// 
			this.moneyDataSet.DataSetName = "MoneyDataSet";
			this.moneyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// buttonAdd
			// 
			this.buttonAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.buttonAdd.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.buttonAdd.Location = new System.Drawing.Point(37, 353);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(80, 30);
			this.buttonAdd.TabIndex = 4;
			this.buttonAdd.Text = "追加";
			this.buttonAdd.UseVisualStyleBackColor = false;
			this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
			// 
			// buttonChange
			// 
			this.buttonChange.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.buttonChange.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.buttonChange.Location = new System.Drawing.Point(134, 353);
			this.buttonChange.Name = "buttonChange";
			this.buttonChange.Size = new System.Drawing.Size(80, 30);
			this.buttonChange.TabIndex = 5;
			this.buttonChange.Text = "変更";
			this.buttonChange.UseVisualStyleBackColor = false;
			this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
			// 
			// buttonDelete
			// 
			this.buttonDelete.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.buttonDelete.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.buttonDelete.Location = new System.Drawing.Point(230, 353);
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.Size = new System.Drawing.Size(80, 30);
			this.buttonDelete.TabIndex = 6;
			this.buttonDelete.Text = "削除";
			this.buttonDelete.UseVisualStyleBackColor = false;
			this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
			// 
			// buttonEnd
			// 
			this.buttonEnd.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.buttonEnd.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Bold);
			this.buttonEnd.Location = new System.Drawing.Point(489, 353);
			this.buttonEnd.Name = "buttonEnd";
			this.buttonEnd.Size = new System.Drawing.Size(80, 30);
			this.buttonEnd.TabIndex = 7;
			this.buttonEnd.Text = "終了";
			this.buttonEnd.UseVisualStyleBackColor = false;
			this.buttonEnd.Click += new System.EventHandler(this.buttonEnd_Click);
			// 
			// tabSummary
			// 
			this.tabSummary.Controls.Add(this.SumDgv);
			this.tabSummary.Location = new System.Drawing.Point(4, 22);
			this.tabSummary.Name = "tabSummary";
			this.tabSummary.Padding = new System.Windows.Forms.Padding(3);
			this.tabSummary.Size = new System.Drawing.Size(624, 386);
			this.tabSummary.TabIndex = 1;
			this.tabSummary.Text = "集計表示";
			this.tabSummary.UseVisualStyleBackColor = true;
			// 
			// SumDgv
			// 
			this.SumDgv.AutoGenerateColumns = false;
			this.SumDgv.BackgroundColor = System.Drawing.SystemColors.MenuBar;
			this.SumDgv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.SumDgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
			this.SumDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.SumDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.日付DataGridViewTextBoxColumn1,
            this.入金合計DataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1});
			this.SumDgv.DataSource = this.sumDataTableBindingSource;
			this.SumDgv.GridColor = System.Drawing.Color.SeaShell;
			this.SumDgv.Location = new System.Drawing.Point(-4, 0);
			this.SumDgv.Name = "SumDgv";
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.MistyRose;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.SumDgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.SumDgv.RowTemplate.Height = 21;
			this.SumDgv.Size = new System.Drawing.Size(644, 400);
			this.SumDgv.TabIndex = 0;
			// 
			// 日付DataGridViewTextBoxColumn1
			// 
			this.日付DataGridViewTextBoxColumn1.DataPropertyName = "日付";
			this.日付DataGridViewTextBoxColumn1.HeaderText = "日付";
			this.日付DataGridViewTextBoxColumn1.Name = "日付DataGridViewTextBoxColumn1";
			// 
			// 入金合計DataGridViewTextBoxColumn
			// 
			this.入金合計DataGridViewTextBoxColumn.DataPropertyName = "入金合計";
			this.入金合計DataGridViewTextBoxColumn.HeaderText = "入金合計";
			this.入金合計DataGridViewTextBoxColumn.Name = "入金合計DataGridViewTextBoxColumn";
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "出金合計";
			this.dataGridViewTextBoxColumn1.HeaderText = "出金合計";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			// 
			// sumDataTableBindingSource
			// 
			this.sumDataTableBindingSource.DataMember = "SumDataTable";
			this.sumDataTableBindingSource.DataSource = this.summaryDataSet;
			// 
			// summaryDataSet
			// 
			this.summaryDataSet.DataSetName = "SummaryDataSet";
			this.summaryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// tabList
			// 
			this.tabList.BackColor = System.Drawing.SystemColors.Menu;
			this.tabList.Controls.Add(this.dgv);
			this.tabList.Controls.Add(this.buttonEnd);
			this.tabList.Controls.Add(this.buttonAdd);
			this.tabList.Controls.Add(this.buttonDelete);
			this.tabList.Controls.Add(this.buttonChange);
			this.tabList.Location = new System.Drawing.Point(4, 22);
			this.tabList.Name = "tabList";
			this.tabList.Padding = new System.Windows.Forms.Padding(3);
			this.tabList.Size = new System.Drawing.Size(624, 386);
			this.tabList.TabIndex = 0;
			this.tabList.Text = "一覧表";
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabList);
			this.tabControl1.Controls.Add(this.tabSummary);
			this.tabControl1.Location = new System.Drawing.Point(12, 27);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(632, 412);
			this.tabControl1.TabIndex = 8;
			this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
			// 
			// categoryDataSet1
			// 
			this.categoryDataSet1.DataSetName = "CategoryDataSet";
			this.categoryDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(656, 451);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.MainMenu);
			this.Name = "Form1";
			this.Text = "簡易家計簿";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.MainMenu.ResumeLayout(false);
			this.MainMenu.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.moneyDataTableBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.moneyDataSet)).EndInit();
			this.tabSummary.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.SumDgv)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sumDataTableBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.summaryDataSet)).EndInit();
			this.tabList.ResumeLayout(false);
			this.tabControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.categoryDataSet1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.MenuStrip MainMenu;
		private System.Windows.Forms.DataGridView dgv;
		private System.Windows.Forms.Button buttonAdd;
		private System.Windows.Forms.Button buttonChange;
		private System.Windows.Forms.Button buttonDelete;
		private System.Windows.Forms.Button buttonEnd;
		private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem SaveStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 編集EToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 追加AToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 変更CToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 削除DToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 表示VToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 一覧表LToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 集計表示SToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ヘルプHToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem バージョン情報VToolStripMenuItem;
		private System.Windows.Forms.DataGridViewTextBoxColumn 日付DataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn 分類DataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn 品名DataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn 金額DataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn 備考DataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource moneyDataTableBindingSource;
		private MoneyDataSet moneyDataSet;
		private CategoryDataSet categoryDataSet1;
		private System.Windows.Forms.TabPage tabSummary;
		private System.Windows.Forms.TabPage tabList;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.DataGridView SumDgv;
		private SummaryDataSet summaryDataSet;
		private System.Windows.Forms.BindingSource sumDataTableBindingSource;
		private System.Windows.Forms.DataGridViewTextBoxColumn 日付DataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn 入金合計DataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
	}
}

