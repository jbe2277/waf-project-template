using System.ComponentModel.Composition;
using System.Windows;
using $safeprojectname$.Applications.Views;

namespace $safeprojectname$.Presentation.Views
{
    [Export(typeof(IShellView))]
    public partial class ShellWindow : Window, IShellView
    {
        public ShellWindow()
        {
            InitializeComponent();
        }
    }
}
