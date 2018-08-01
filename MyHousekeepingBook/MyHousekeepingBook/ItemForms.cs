using System;
using System.Windows.Forms;

namespace MyHousekeepingBook
{
	public partial class ItemForms : Form
	{
		public ItemForms(CategoryDataSet dsCategory)
		{
			InitializeComponent();
			categoryDataSet.Merge(dsCategory);
		}

		//登録画面に変更する情報を持ってるコンストラクタの生成
		public ItemForms(CategoryDataSet dsCategory,
						 DateTime nowDate,
						 string category,
						 string item,
						 int money,
						 string remarks)
		{
			InitializeComponent();
			//categoryDataSetの値をdsCategoryに代入する
			categoryDataSet.Merge(dsCategory);
			//setdate as currenty selected date
			monCalendar.SetDate(nowDate);
			cmbCategory.Text = category;
			txtItem.Text = item;
			mtxtMoney.Text = money.ToString();
			txtRemarks.Text = remarks;
		}

		public void ItemForms_Load(object sender, EventArgs e)
		{

		}

		
	}
}
