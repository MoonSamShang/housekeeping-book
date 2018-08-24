using System;
using System.Windows.Forms;

namespace MyHousekeepingBook
{
    //登録及び修正画面のクラス
    public partial class ItemForms : Form
	{
        //登録画面の分類にCategoryDataSetを引き数として渡す
        public ItemForms(CategoryDataSet dsCategory)
		{
            //登録画面の初期か
            InitializeComponent();
            categoryDataSet.Merge(dsCategory);
		}

        //コンストラクタオーバーロード
        //データ変更する際に、登録画面に前回入力したデータを引き数として渡す
        public ItemForms(CategoryDataSet dsCategory,
						DateTime oldDate,
						string oldCatagory,
						string oldItem,
						string oldMoney,
						string oldRemarks)			
		{
			InitializeComponent();
			categoryDataSet.Merge(dsCategory);
			monCalendar.SetDate(oldDate);
			cmbCategory.Text = oldCatagory;
			txtItem.Text = oldItem;
			mtxtMoney.Text = oldMoney;
			txtRemarks.Text = oldRemarks;

		}
	}
}
