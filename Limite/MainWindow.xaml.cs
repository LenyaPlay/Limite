using Limite.Commands;
using Limite.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Limite
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MainContentViewModel mainContentViewModel = new MainContentViewModel();
        public MainWindow()
        {
            InitializeComponent();
            DataContext = mainContentViewModel;
            mainContentViewModel.OpenPageCommand = new RelayCommand((obj) =>
            {
                Uri resource = new Uri(obj.ToString(), UriKind.RelativeOrAbsolute);
                mainContentViewModel.Content = Application.LoadComponent(resource);
            });
        }
    }
}
