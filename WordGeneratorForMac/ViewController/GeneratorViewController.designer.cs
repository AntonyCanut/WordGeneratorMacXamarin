// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace WordGeneratorForMac
{
	[Register ("GeneratorViewController")]
	partial class GeneratorViewController
	{
		[Outlet]
		AppKit.NSButton GenerateButton { get; set; }

		[Outlet]
		AppKit.NSTextField ResultField { get; set; }

		[Outlet]
		AppKit.NSTextField WordField { get; set; }

		[Action ("Copy_Clicked:")]
		partial void Copy_Clicked (Foundation.NSObject sender);

		[Action ("GenerateButton_Clicked:")]
		partial void GenerateButton_Clicked (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (GenerateButton != null) {
				GenerateButton.Dispose ();
				GenerateButton = null;
			}

			if (ResultField != null) {
				ResultField.Dispose ();
				ResultField = null;
			}

			if (WordField != null) {
				WordField.Dispose ();
				WordField = null;
			}
		}
	}
}
