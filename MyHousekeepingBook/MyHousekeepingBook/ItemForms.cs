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
