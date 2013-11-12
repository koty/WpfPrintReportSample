using Livet;
using Livet.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfPrintReportSample.ViewModels
{
    public class MainWindowViewModel : ViewModel
    {
        public MainWindowViewModel()
        {
            Text = "あいうえお";
        }

        public string Text { get; set; }

        private ViewModelCommand printCommand;
        public ViewModelCommand PrintCommand
        {
            get
            {
                return this.printCommand ?? (this.printCommand = new ViewModelCommand(this.Print));
            }
        }

        private void Print()
        {
            Printer.Print(this);
        }
    }
}
