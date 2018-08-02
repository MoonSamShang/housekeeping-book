using System;
using System.IO;
using System.Text;
using System.Windows.Forms;


namespace MyHousekeepingBook
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			LoadData();
			categoryDataSet1.CategoryDataTable.AddCategoryDataTableRow("給料", "入金");
			categoryDataSet1.CategoryDataTable.AddCategoryDataTableRow("食費", "出金");
			categoryDataSet1.CategoryDataTable.AddCategoryDataTableRow("雑費", "出金");
			categoryDataSet1.CategoryDataTable.AddCategoryDataTableRow("住居", "出金");
		}

		private void buttonAdd_Click(object sender, EventArgs e)
		{
		}

		//Create sub routine method to be utilized in different places
		private void AddData()
		{
		}

		private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		//登録されたデータをDGVからデータセットに格納する処理
		private void SaveData()
		{
		
		}

		private void SaveStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
		}

		private void LoadData()
		{
			
		}

		//データ変更機能のスープルーチンメソッドの生成
		private void UpdateData()
		{
		
		}

		private void buttonChange_Click(object sender, EventArgs e)
		{
		}

		private void 変更CToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		private void DeleteData()
		{
		}

		private void buttonDelete_Click(object sender, EventArgs e)
		{
		}

		private void 削除DToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		//出力金額を集計するメソッド
		private void CalcSummary()
		{
		
		}

		private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		private void 一覧表LToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		private void 集計表示SToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

	}
}
