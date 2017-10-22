using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace treegui
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            switch (Environment.GetCommandLineArgs().Length)
            {
                case 2:
                    switch (Environment.GetCommandLineArgs()[1].ToLower())
                    {
                        case "/f":
                            flagFCheckBox.IsChecked = true;
                            break;
                        case "/a":
                            flagACheckBox.IsChecked = true;
                            break;
                        default:
                            folderPathTextBox.Text = Environment.GetCommandLineArgs()[1];
                            break;
                    }
                    break;
                case 3:
                    if (Environment.GetCommandLineArgs()[1].ToLower() == "/f" || Environment.GetCommandLineArgs()[2].ToLower() == "/f")
                    {
                        flagFCheckBox.IsChecked = true;
                    }
                    if (Environment.GetCommandLineArgs()[1].ToLower() == "/a" || Environment.GetCommandLineArgs()[2].ToLower() == "/a")
                    {
                        flagACheckBox.IsChecked = true;
                    }
                    break;
                case 4:
                    if (Environment.GetCommandLineArgs()[2].ToLower() == "/f" || Environment.GetCommandLineArgs()[3].ToLower() == "/f")
                    {
                        flagFCheckBox.IsChecked = true;
                    }
                    if (Environment.GetCommandLineArgs()[2].ToLower() == "/a" || Environment.GetCommandLineArgs()[3].ToLower() == "/a")
                    {
                        flagACheckBox.IsChecked = true;
                    }
                    break;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string exec = $"{folderPathTextBox.Text}"
                        + " "
                        + $"{(flagFCheckBox.IsChecked == true ? Flags.FlagF : Flags.FlagNullOrEmpty)}"
                        + " "
                        + $"{(flagACheckBox.IsChecked == true ? Flags.FlagA : Flags.FlagNullOrEmpty)}";


        }

        private void pathSelectionButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}