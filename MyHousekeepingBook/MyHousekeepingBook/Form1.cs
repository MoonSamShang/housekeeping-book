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
			this.AddData();
		}

		private void 追加AToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.AddData();
		}

		//Create sub routine method to be utilized in different places
		private void AddData()
		{

			ItemForms itemForms = new ItemForms(categoryDataSet1);
			DialogResult diaRet = itemForms.ShowDialog();

			if (diaRet == DialogResult.OK)
			{

				moneyDataSet.moneyDataTable.Rows.Add(itemForms.monCalendar.SelectionRange.Start,
													 itemForms.cmbCategory.Text,
													 itemForms.txtItem.Text,
													 int.Parse(itemForms.mtxtMoney.Text),
													 itemForms.txtRemarks.Text);
			}


		}

		private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void buttonEnd_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		//登録されたデータをDGVからデータセットに格納する処理
		private void SaveData()
		{
			string path = "MoneyData.csv";
			StreamWriter sw = new StreamWriter(path, false, Encoding.Default);

			//drMoney is the reference to the moneyDatarow
			foreach (MoneyDataSet.moneyDataTableRow drMoney in moneyDataSet.moneyDataTable)
			{
				string moneyData = drMoney.日付.ToShortDateString() + ","
									+ drMoney.分類 + ","
									+ drMoney.品名 + ","
									+ drMoney.金額.ToString() + ","
									+ drMoney.備考;
				sw.WriteLine(moneyData);
			}
			sw.Close();

		}

		private void SaveStripMenuItem_Click(object sender, EventArgs e)
		{
			this.SaveData();
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.SaveData();
		}

		private void LoadData()
		{
			string path = "MoneyData.csv";
			string delimiter = ",";
			char[] spliter = delimiter.ToCharArray();
			string[] strData;

			if (File.Exists(path))
			{
				StreamReader sr = new StreamReader(path, Encoding.Default);

				
				while (sr.Peek() > 0)
				{
					string strLine = sr.ReadLine();
					strData = strLine.Split(spliter);
					moneyDataSet.moneyDataTable.AddmoneyDataTableRow(DateTime.Parse(strData[0]),
																	strData[1],
																	strData[2],
																	int.Parse(strData[3]),
																	strData[4]);
				}
				sr.Close();
			}
		}
		
		//データ変更機能のスープルーチンメソッドの生成
		private void UpdateData()
		{
			int selectRow = dgv.CurrentRow.Index;

			ItemForms update = new ItemForms(categoryDataSet1,
											DateTime.Parse(dgv.CurrentRow.Cells[0].Value.ToString()),
											dgv.CurrentRow.Cells[1].Value.ToString(),
											dgv.CurrentRow.Cells[2].Value.ToString(),
											dgv.CurrentRow.Cells[3].Value.ToString(),
											dgv.CurrentRow.Cells[4].Value.ToString());

			DialogResult diaRet = update.ShowDialog();

			if (diaRet == DialogResult.OK)
			{
				dgv.CurrentRow.Cells[0].Value = update.monCalendar.SelectionRange.Start;
				dgv.CurrentRow.Cells[1].Value = update.cmbCategory.Text;
				dgv.CurrentRow.Cells[2].Value = update.txtItem.Text;
				dgv.CurrentRow.Cells[3].Value = int.Parse(update.mtxtMoney.Text);
				dgv.CurrentRow.Cells[4].Value = update.txtRemarks.Text;
			}


		}

		private void buttonChange_Click(object sender, EventArgs e)
		{
			this.UpdateData();
		}

		private void 変更CToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.UpdateData();
		}

		private void DeleteData()
		{
			int selectRow = dgv.CurrentRow.Index;
			dgv.Rows.RemoveAt(selectRow);
		}

		private void buttonDelete_Click(object sender, EventArgs e)
		{
			this.DeleteData();
		}

		private void 削除DToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.DeleteData();
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
