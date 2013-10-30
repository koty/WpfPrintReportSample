using Livet;
using WpfPrintReportSample.ViewModels;
using WpfPrintReportSample.Views;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace WpfPrintReportSample
{
    /// <summary>
    /// App.xaml の相互作用ロジック
    /// </summary>
    public partial class App : Application
    {
        protected void Application_Startup(object sender, StartupEventArgs e)
        {
            DispatcherHelper.UIDispatcher = Dispatcher;

            var vm = new MainWindowViewModel();
            var window = new MainWindow();
            window.DataContext = vm;
            window.Show();
        }
    }
}
