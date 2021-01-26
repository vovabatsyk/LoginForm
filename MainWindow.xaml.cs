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

namespace LoginForm
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CloseButton_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void MinButton_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void toolbar_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void LogoContainer_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(SettingsBtn.Visibility == Visibility.Hidden)
            {
                SettingsBtn.Visibility = Visibility.Visible;
                LanguageBtn.Visibility = Visibility.Hidden;
            }
            else
            {
                SettingsBtn.Visibility = Visibility.Hidden;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (LanguageBtn.Visibility == Visibility.Hidden)
            {
                LanguageBtn.Visibility = Visibility.Visible;
                SettingsBtn.Visibility = Visibility.Hidden;
            }
            else
            {
                LanguageBtn.Visibility = Visibility.Hidden;
            }
        }

        private void BtnLanguageClick(object sender, RoutedEventArgs e)
        {
            LanguageBtn.Visibility = Visibility.Hidden;
        }

        private void BtnSettingClick(object sender, RoutedEventArgs e)
        {
            SettingsBtn.Visibility = Visibility.Hidden;

        }

        private void OnPasswordChanged(object sender, RoutedEventArgs e)
        {
            WaterMark.Visibility = TextBoxPassword.Password.Length > 0 ? Visibility.Hidden : Visibility.Visible;
        }
    }
}
