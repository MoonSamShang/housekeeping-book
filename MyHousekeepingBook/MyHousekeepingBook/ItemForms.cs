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
	}
}
