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
			//実行じにForm1が立ち上がりまし
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			LoadData();
			//Form1からCategoryDataSetにデータの入力
			categoryDataSet1.CategoryDataTable.AddCategoryDataTableRow("給料", "入金");
			categoryDataSet1.CategoryDataTable.AddCategoryDataTableRow("食費", "出金");
			categoryDataSet1.CategoryDataTable.AddCategoryDataTableRow("雑費", "出金");
			categoryDataSet1.CategoryDataTable.AddCategoryDataTableRow("住居", "出金");
		}
        #region
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            this.AddData();
        }

        private void 追加AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.AddData();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonEnd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveStripMenuItem_Click(object sender, EventArgs e)
        {
            this.SaveData();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.SaveData();
        }
        private void buttonChange_Click(object sender, EventArgs e)
        {
            this.UpdateData();
        }

        private void 変更CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.UpdateData();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            this.DeleteData();
        }

        private void 削除DToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.DeleteData();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.CalcSummary();
        }

        private void 一覧表LToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabList);
        }

        private void 集計表示SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabSummary);
        }

        #endregion


        //moneyDataTableにデータを追加するメソッド
        private void AddData()
		{
			//登録画面の表示
			ItemForms itemForms = new ItemForms(categoryDataSet1);
			DialogResult dialogResult = itemForms.ShowDialog();

            //登録ボタンを押した場合
            if (dialogResult == DialogResult.OK)
            {
                //金額のTextBoxで金額入力しなかった場合
                if (string.IsNullOrEmpty(itemForms.mtxtMoney.Text))
                {
                    MessageBox.Show("金額を入れてください。",
                                    "入力ミス！",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);

                }
                else
                {
                    moneyDataSet.moneyDataTable.Rows.Add(itemForms.monCalendar.SelectionRange.Start,
                                                      itemForms.cmbCategory.Text,
                                                      itemForms.txtItem.Text,
                                                      int.Parse(itemForms.mtxtMoney.Text),
                                                      itemForms.txtRemarks.Text);
                }
            }
       
        }

		//登録されたデータをデータセットに通してCSVファイル形式で保存する処理
		private void SaveData()
		{
            //ユーザーのパソコンで“MoneyData”の名前で、CSVファイルを自動生成する
            string path = "MoneyData.csv";
            //StreamWriterクラスインスタンスの生成
            StreamWriter sw = new StreamWriter(path, false, Encoding.Default);

			//MoneyDataTableのデータをCSVファイル式で書き込む処理
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

        //CSVファイルに保存しいたデータをForm1立ち上がる際にDataGridViewに読み込んで表示する処理
		private void LoadData()
		{
			string path = "MoneyData.csv";
			string delimiter = ",";
			char[] spliter = delimiter.ToCharArray();
			string[] strData;

			if (File.Exists(path))
			{
				StreamReader sr = new StreamReader(path, Encoding.Default);

				//CSVファイルに保存しているデータの全行を読み込む処理
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
		
		//データ変更を行う処理
		private void UpdateData()
		{
            int selectRow = dgv.CurrentRow.Index;

            //データGridviewに前回格納してたデータを取得する
			ItemForms update = new ItemForms(categoryDataSet1,
											DateTime.Parse(dgv.CurrentRow.Cells[0].Value.ToString()),
											dgv.CurrentRow.Cells[1].Value.ToString(),
											dgv.CurrentRow.Cells[2].Value.ToString(),
											dgv.CurrentRow.Cells[3].Value.ToString(),
											dgv.CurrentRow.Cells[4].Value.ToString());

            //取得したデータを登録画面のそれぞれのTextboxに表示する
            DialogResult diaResult = update.ShowDialog();

			if (diaResult == DialogResult.OK)
			{
                //金額のTextBoxで金額入力しなかった場合
                if (string.IsNullOrEmpty(update.mtxtMoney.Text))
                {
                    MessageBox.Show("金額を入れてください。",
                                    "入力ミス！",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);

                }
                else
                {
                    dgv.CurrentRow.Cells[0].Value = update.monCalendar.SelectionRange.Start;
                    dgv.CurrentRow.Cells[1].Value = update.cmbCategory.Text;
                    dgv.CurrentRow.Cells[2].Value = update.txtItem.Text;
                    dgv.CurrentRow.Cells[3].Value = int.Parse(update.mtxtMoney.Text);
                    dgv.CurrentRow.Cells[4].Value = update.txtRemarks.Text;
                }
			}
		}

        //データ削除を行う処理
        private void DeleteData()
        {
            int selectRow = dgv.CurrentRow.Index;
            dgv.Rows.RemoveAt(selectRow);
        }

        //出力金額を集計するメソッド
        private void CalcSummary()
		{
            //summaryDataSetの初期化
            summaryDataSet.Clear();
            
            foreach (MoneyDataSet.moneyDataTableRow drMoney in moneyDataSet.moneyDataTable)
			{
                //SummaryDatatableから各データの“日付”を取得する
                SummaryDataSet.SumDataTableRow[] curDR = (SummaryDataSet.SumDataTableRow[])summaryDataSet.SumDataTable.
																Select("日付= '" + drMoney.日付.ToShortDateString() + "'");

                //CategoryDatatableから各データの“分類”を取得する
                CategoryDataSet.CategoryDataTableRow[] catData = (CategoryDataSet.CategoryDataTableRow[])categoryDataSet1.CategoryDataTable.
                                                               Select("分類= '" + drMoney.分類.ToString() + "'");

                //入力してきたデータの日付がSummaryDatatableに存在しない場合
                if (curDR.Length == 0)
				{
                   //入力してきたデータが入金の場合
                    if (catData[0].入出金分類 == "入金")
					{
						summaryDataSet.SumDataTable.AddSumDataTableRow(drMoney.日付,
																		drMoney.金額,
																		0);																	
					}
                    //入力してきたデータが出金の場合
                    else if (catData[0].入出金分類 == "出金")
					{
						summaryDataSet.SumDataTable.AddSumDataTableRow(drMoney.日付,
																		0,
																		drMoney.金額);
					}
				}
                //入力してきたデータの日付がSummaryDatatableに存在しする場合
                else
                {    //入金の場合               
                    if (catData[0].入出金分類 == "入金")
					{
                        //同じ日付の入力行に入る、又はプラスされる
                        curDR[0].入金合計 += drMoney.金額;
					}
                    //出金の場合
                    else if (catData[0].入出金分類 == "出金")
					{
                        //同じ日付の入力行に入る、又はプラスされる
                        curDR[0].出金合計 += drMoney.金額;
					}
				}

			}
            
        }
    }
}
