// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace HelloXamarin_iOS
{
	[Register ("ViewController")]
	partial class SayHelloViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton SayHelloButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel SayHelloLabel { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField SayHelloTo { get; set; }

		[Action ("HistoryBarButtonItem_Activated:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void HistoryBarButtonItem_Activated (UIBarButtonItem sender);

		[Action ("SayHelloButton_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void SayHelloButton_TouchUpInside (UIButton sender);

		void ReleaseDesignerOutlets ()
		{
			if (SayHelloButton != null) {
				SayHelloButton.Dispose ();
				SayHelloButton = null;
			}
			if (SayHelloLabel != null) {
				SayHelloLabel.Dispose ();
				SayHelloLabel = null;
			}
			if (SayHelloTo != null) {
				SayHelloTo.Dispose ();
				SayHelloTo = null;
			}
		}
	}
}
