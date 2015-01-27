namespace EyeCatch.LogisticsTracker.WinRT.MvvmCross
{
    using Windows.UI.Xaml.Controls;

    using Cirrious.MvvmCross.ViewModels;
    using Cirrious.MvvmCross.WindowsCommon.Platform;
    using Cirrious.MvvmCross.WindowsCommon.Views;

    public class Setup : MvxWindowsSetup
    {
        public Setup(Frame rootFrame)
            : base(rootFrame)
        {
        }

        public Setup(IMvxWindowsFrame rootFrame)
            : base(rootFrame)
        {
        }

        protected override IMvxApplication CreateApp()
        {
            return new Core.App();
        }
    }
}
