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
			this.MainMenu = new System.Windows.Forms.MenuStrip();
			this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.SaveStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.dgv = new System.Windows.Forms.DataGridView();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.buttonChange = new System.Windows.Forms.Button();
			this.buttonDelete = new System.Windows.Forms.Button();
			this.buttonEnd = new System.Windows.Forms.Button();
			this.編集EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.追加AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.変更CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.削除DToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.表示VToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.一覧表LToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.集計表示SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ヘルプHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.バージョン情報VToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.MainMenu.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
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
			this.MainMenu.Size = new System.Drawing.Size(800, 24);
			this.MainMenu.TabIndex = 2;
			this.MainMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MainMenu_ItemClicked);
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
			this.SaveStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.SaveStripMenuItem.Text = "保存(S)";
			// 
			// ExitToolStripMenuItem
			// 
			this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
			this.ExitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.ExitToolStripMenuItem.Text = "終了(&X)";
			// 
			// dgv
			// 
			this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv.Location = new System.Drawing.Point(37, 51);
			this.dgv.Name = "dgv";
			this.dgv.RowTemplate.Height = 21;
			this.dgv.Size = new System.Drawing.Size(730, 337);
			this.dgv.TabIndex = 3;
			// 
			// buttonAdd
			// 
			this.buttonAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.buttonAdd.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.buttonAdd.Location = new System.Drawing.Point(37, 408);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(80, 30);
			this.buttonAdd.TabIndex = 4;
			this.buttonAdd.Text = "追加";
			this.buttonAdd.UseVisualStyleBackColor = false;
			// 
			// buttonChange
			// 
			this.buttonChange.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.buttonChange.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.buttonChange.Location = new System.Drawing.Point(134, 408);
			this.buttonChange.Name = "buttonChange";
			this.buttonChange.Size = new System.Drawing.Size(80, 30);
			this.buttonChange.TabIndex = 5;
			this.buttonChange.Text = "変更";
			this.buttonChange.UseVisualStyleBackColor = false;
			// 
			// buttonDelete
			// 
			this.buttonDelete.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.buttonDelete.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.buttonDelete.Location = new System.Drawing.Point(230, 408);
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.Size = new System.Drawing.Size(80, 30);
			this.buttonDelete.TabIndex = 6;
			this.buttonDelete.Text = "削除";
			this.buttonDelete.UseVisualStyleBackColor = false;
			// 
			// buttonEnd
			// 
			this.buttonEnd.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.buttonEnd.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Bold);
			this.buttonEnd.Location = new System.Drawing.Point(687, 408);
			this.buttonEnd.Name = "buttonEnd";
			this.buttonEnd.Size = new System.Drawing.Size(80, 30);
			this.buttonEnd.TabIndex = 7;
			this.buttonEnd.Text = "終了";
			this.buttonEnd.UseVisualStyleBackColor = false;
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
			this.追加AToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.追加AToolStripMenuItem.Text = "追加(&A)";
			// 
			// 変更CToolStripMenuItem
			// 
			this.変更CToolStripMenuItem.Name = "変更CToolStripMenuItem";
			this.変更CToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.変更CToolStripMenuItem.Text = "変更(&C)";
			// 
			// 削除DToolStripMenuItem
			// 
			this.削除DToolStripMenuItem.Name = "削除DToolStripMenuItem";
			this.削除DToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.削除DToolStripMenuItem.Text = "削除(&D)";
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
			this.一覧表LToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.一覧表LToolStripMenuItem.Text = "一覧表(&L)";
			// 
			// 集計表示SToolStripMenuItem
			// 
			this.集計表示SToolStripMenuItem.Name = "集計表示SToolStripMenuItem";
			this.集計表示SToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.集計表示SToolStripMenuItem.Text = "集計表示(&S)";
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
			this.バージョン情報VToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.バージョン情報VToolStripMenuItem.Text = "バージョン情報(&V)";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.buttonEnd);
			this.Controls.Add(this.buttonDelete);
			this.Controls.Add(this.buttonChange);
			this.Controls.Add(this.buttonAdd);
			this.Controls.Add(this.MainMenu);
			this.Controls.Add(this.dgv);
			this.Name = "Form1";
			this.Text = "簡易家計簿";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.MainMenu.ResumeLayout(false);
			this.MainMenu.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
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
	}
}

