using AppKit;
using Foundation;

namespace WordGeneratorForMac
{
    [Register("AppDelegate")]
    public partial class AppDelegate : NSApplicationDelegate
    {
        public AppDelegate()
        {
        }

        public override void DidFinishLaunching(NSNotification notification)
        {
            // Insert code here to initialize your application
        }

        public override void WillTerminate(NSNotification notification)
        {
            // Insert code here to tear down your application
        }

        partial void NewFileMenu_Clicked(NSObject sender)
        {
            //todo: Make a messenger
        }
    }
}
