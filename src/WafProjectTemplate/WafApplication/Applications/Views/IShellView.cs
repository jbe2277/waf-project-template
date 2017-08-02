using System.Waf.Applications;

namespace $safeprojectname$.Applications.Views
{
    internal interface IShellView : IView
    {
        void Show();

        void Close();
    }
}
