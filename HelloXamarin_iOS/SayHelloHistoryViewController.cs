using System;
using UIKit;
using System.Collections.Generic;

namespace HelloXamarin_iOS
{
	public partial class SayHelloHistoryViewController : UITableViewController
	{
		public List<String> SayHelloHistory {
			get;
			set;
		}

		public SayHelloHistoryViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			// Perform any additional setup after loading the view, typically from a nib.

			TableView.DataSource = new DataSource (this);
		}

		class DataSource : UITableViewDataSource
		{

			private SayHelloHistoryViewController viewController;

			public DataSource (SayHelloHistoryViewController viewController)
			{
				this.viewController = viewController;
			}

			public override nint RowsInSection (UITableView tableView, nint section)
			{
				return viewController.SayHelloHistory.Count;
			}

			public override UITableViewCell GetCell (UITableView tableView, Foundation.NSIndexPath indexPath)
			{
				UITableViewCell cell = tableView.DequeueReusableCell ("historyCell");
				cell.TextLabel.Text = viewController.SayHelloHistory [indexPath.Row];
				return cell;
			}

		}

	}
}

