using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
					//data type casting
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
			this.Close();
		}

		private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
		
		}

		private void dgv_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			int rowIndex = e.RowIndex;
		}
	}
}
