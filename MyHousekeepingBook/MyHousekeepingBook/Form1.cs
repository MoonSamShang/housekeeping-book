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
			AddData();
		}

		//Create sub routine method to be utilized in different places
		private void AddData()
		{
			//登録画面の呼び出し
			ItemForms frmItem = new ItemForms(categoryDataSet1);
			DialogResult drRet = frmItem.ShowDialog();

			//if the user click "登録" button on 登録画面
			if (drRet == DialogResult.OK)
			{
				//add the input data into the moneydatatable of money data set
				moneyDataSet.moneyDataTable.AddmoneyDataTableRow(
					frmItem.monCalendar.SelectionRange.Start,
					frmItem.cmbCategory.Text,
					frmItem.txtItem.Text,
					//data type casting from text(string) into int datatype
					int.Parse(frmItem.mtxtMoney.Text),
					frmItem.txtRemarks.Text);
			}

		}

		private void 追加AToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AddData();
		}

		private void buttonEnd_Click(object sender, EventArgs e)
		{
			this.SaveData();
			this.Close();
		}

		private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		//登録されたデータをDGVからデータセットに格納する処理
		private void SaveData()
		{
			//CSVfileの名前を付ける
			string path = "MoneyData.csv"; //出力ファイル
			//インスタンスの初期化
			string strData = null;
			//create object instance for streamwriter
			StreamWriter sw = new StreamWriter(
					path,
					false,
					Encoding.Default);
			foreach (MoneyDataSet.moneyDataTableRow drMoney in moneyDataSet.moneyDataTable)
			{
				strData = drMoney.日付.ToShortDateString() + ","
						+ drMoney.分類 + ","
						+ drMoney.品名 + ","
						+ drMoney.金額 + ","
						+ drMoney.備考;
				sw.WriteLine(strData);
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
			string path = "MoneyData.csv"; //入力ファイル名
			string delimStr = ",";　//区切り文字
			char[] delimiter = delimStr.ToCharArray();　//区切り文字をまとめる
			string[] strData;　//分解後の文字の入れ物
			string strLine; //1行分のデータ

			//ファイルが存在するかの確認
			bool fileExists = File.Exists(path);
			if (fileExists)
			{
				//存在する場合ファイルを読み込んだ後、代入するインスタンスの生成
				StreamReader sr = new StreamReader("MoneyData.csv", Encoding.Default);

				//CSVファイルのデータがある間繰り返し
				while (sr.Peek() > 0)
				{
					//streamの一行分を読み込んで、Stringを返す
					strLine = sr.ReadLine();
					//読み込んだStringデータを区切ってArrayに代入する
					strData = strLine.Split(delimiter);
					//データテーブルに値を付けてそれぞれ入れる
					moneyDataSet.moneyDataTable.AddmoneyDataTableRow(
												DateTime.Parse(strData[0]),
												strData[1],
												strData[2],
												int.Parse(strData[3]),
												strData[4]);
				}
				//StreamReaderを閉じる
				sr.Close();
			}
			
		}

		//データ変更機能のスープルーチンメソッドの生成
		private void UpdateData()
		{
			//選択された列の値を代入するインスタンスの生成
			int nowRow = dgv.CurrentRow.Index;

			//各columnから値を代入するインスタンスの生成

			DateTime oldDate = DateTime.Parse(dgv.Rows[nowRow].Cells[0].Value.ToString());
			string oldCategory = dgv.Rows[nowRow].Cells[1].Value.ToString();
			string oldItem = dgv.Rows[nowRow].Cells[2].Value.ToString();
			int oldMoney = int.Parse(dgv.Rows[nowRow].Cells[3].Value.ToString());
			string oldRemarks = dgv.Rows[nowRow].Cells[4].Value.ToString();

			//各columnから値を取得する
			//コンストラクタの呼び出し
			ItemForms frmItem = new ItemForms(categoryDataSet1,
												oldDate,
												oldCategory,
												oldItem,
												oldMoney,
												oldRemarks);

			//取得した値を登録画面の呼び出し時に表示する
			DialogResult drRet = frmItem.ShowDialog();

			//変更の処理
			if (drRet == DialogResult.OK)
			{
				dgv.Rows[nowRow].Cells[0].Value = frmItem.monCalendar.SelectionRange.Start;
				dgv.Rows[nowRow].Cells[1].Value = frmItem.cmbCategory.Text;
				dgv.Rows[nowRow].Cells[2].Value = frmItem.txtItem.Text;
				dgv.Rows[nowRow].Cells[3].Value = int.Parse(frmItem.mtxtMoney.Text.ToString());
				dgv.Rows[nowRow].Cells[4].Value = frmItem.txtRemarks.Text;
			}
		}

		private void buttonChange_Click(object sender, EventArgs e)
		{
			UpdateData();
		}

		private void 変更CToolStripMenuItem_Click(object sender, EventArgs e)
		{
			UpdateData();
		}

		private void DeleteData()
		{
			int nowRow = dgv.CurrentRow.Index;
			dgv.Rows.RemoveAt(nowRow);
		}

		private void buttonDelete_Click(object sender, EventArgs e)
		{
			DeleteData();
		}

		private void 削除DToolStripMenuItem_Click(object sender, EventArgs e)
		{
			DeleteData();
		}

		//出力金額を集計するメソッド
		private void CalcSummary()
		{
			string expression;
			//DataTableの初期化
			summaryDataSet.SumDataTable.Clear();
			//
			foreach (MoneyDataSet.moneyDataTableRow  drMoney 
				in moneyDataSet.moneyDataTable)
			{
				expression = "日付= '" + drMoney.日付.ToShortDateString() + "'";
				
				//データ型casting日付をSumDataTableRow[]にする
				SummaryDataSet.SumDataTableRow[] curDR = (SummaryDataSet.SumDataTableRow[])
														summaryDataSet.SumDataTable.Select(expression);

				//CategoryDataSetの中の“入出金分類”を使うので
				CategoryDataSet.CategoryDataTableRow[] selectedDataRow;
				selectedDataRow = (CategoryDataSet.CategoryDataTableRow[])
				categoryDataSet1.CategoryDataTable.Select("分類= '" + drMoney.分類 + "'");

				//if there is no data entry at the same date 
				if (curDR.Length == 0)
				{
					//addrow to the table
					//set the selectedDataRow as a base data that's why use zero
					if (selectedDataRow[0].入出金分類　== "入金")
					{
						summaryDataSet.SumDataTable.AddSumDataTableRow(drMoney.日付,
																		drMoney.金額,
																		0);
					}
					else if (selectedDataRow[0].入出金分類 == "出金")
					{
						summaryDataSet.SumDataTable.AddSumDataTableRow(drMoney.日付,
																		0,
																		drMoney.金額);
					}
				}
				//if there is data entry with the same date
				else
				{
					if (selectedDataRow[0].入出金分類 == "入金")
					{
						//cur = current date
						curDR[0].入金合計 += drMoney.金額;

					}
					else if (selectedDataRow[0].入出金分類 == "出金")
					{
						curDR[0].出金合計 += drMoney.金額;
					}
				}
			}

		}

		private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
		{
			CalcSummary();
		}

		private void 一覧表LToolStripMenuItem_Click(object sender, EventArgs e)
		{
			tabControl1.SelectTab(tabList);
		}

		private void 集計表示SToolStripMenuItem_Click(object sender, EventArgs e)
		{
			tabControl1.SelectTab(tabSummary);
		}

	}
}
