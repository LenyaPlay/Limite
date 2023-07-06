using Limite.Commands;
using Limite.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Channels;
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

namespace Limite.Views
{
    /// <summary>
    /// Interaction logic for MainSideBar.xaml
    /// </summary>
    public partial class MainSideBar : UserControl
    {
        public static readonly DependencyProperty OpenPageCommandProperty =
    DependencyProperty.Register("OpenPageCommand", typeof(ICommand), typeof(MainSideBar), new PropertyMetadata(null));

        public static readonly DependencyProperty ThemesProperty =
                DependencyProperty.Register("Themes", typeof(ObservableCollection<ThemeViewModel>), typeof(MainSideBar), new PropertyMetadata(new ObservableCollection<ThemeViewModel>()));

        public static readonly DependencyProperty SelectedThemeProperty =
    DependencyProperty.Register("SelectedTheme", typeof(ThemeViewModel), typeof(MainSideBar), new PropertyMetadata(null));

        public ICommand OpenPageCommand
        {
            get { return (ICommand)GetValue(OpenPageCommandProperty); }
            set { SetValue(OpenPageCommandProperty, value); }
        }

        public ObservableCollection<ThemeViewModel> Themes
        {
            get { return (ObservableCollection<ThemeViewModel>)GetValue(ThemesProperty); }
            set { SetValue(ThemesProperty, value); }
        }

        public ThemeViewModel SelectedTheme
        {
            get { return (ThemeViewModel)GetValue(SelectedThemeProperty); }
            set { SetValue(SelectedThemeProperty, value); }
        }

        public MainSideBar()
        {
            InitializeComponent();
            
        }

        private void ListView_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void ThemeChanged(object sender, SelectionChangedEventArgs e)
        {            
            ResourceDictionary dict = new ResourceDictionary();
            ThemeViewModel themeViewModel = ((sender as ComboBox).SelectedItem as ThemeViewModel);
            dict.Source = new Uri( SelectedTheme.Uri, UriKind.Relative);
            Application.Current.Resources.MergedDictionaries.Clear();
            Application.Current.Resources.MergedDictionaries.Add(dict);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            return;
        }
    }
}
