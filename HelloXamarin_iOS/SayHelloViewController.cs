using System;

using UIKit;
using System.Collections.Generic;

namespace HelloXamarin_iOS
{
	public partial class SayHelloViewController : UIViewController
	{
		private List<String> sayHelloHistory = new List<String> ();

		public SayHelloViewController (IntPtr handle) : base (handle)
		{
		}

		partial void SayHelloButton_TouchUpInside (UIButton sender)
		{
			SayHelloLabel.Text = "Hello " + SayHelloTo.Text;

			sayHelloHistory.Add (SayHelloLabel.Text);
		}

		public override void PrepareForSegue (UIStoryboardSegue segue, Foundation.NSObject sender)
		{
			base.PrepareForSegue (segue, sender);

			var controller = segue.DestinationViewController as SayHelloHistoryViewController;
			controller.SayHelloHistory = sayHelloHistory;
		}

	}
}

