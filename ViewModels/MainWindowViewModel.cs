using System.ComponentModel;
using System.Windows;
using Livet;
using Livet.Commands;

namespace WpfPrintReportSample.ViewModels
{
    public class MainWindowViewModel : ViewModel
    {
        public MainWindowViewModel()
        {
            if (DesignerProperties.GetIsInDesignMode(new DependencyObject()))
            {
                Text = "あいうえお";
            }
        }

        public string Text { get; set; }

        private ViewModelCommand printCommand;

        public ViewModelCommand PrintCommand
        {
            get { return this.printCommand ?? (this.printCommand = new ViewModelCommand(this.Print)); }
        }

        private void Print()
        {
            Printer.Print(this);
        }
    }
}
