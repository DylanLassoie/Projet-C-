using Projet_C.Management;
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

namespace Projet_C
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            menu_selection.SelectedIndex = 0;
        }

        private void Selector_OnSelected(object sender, RoutedEventArgs e)
        {
            var listView = (ListView)sender;
            switch (listView.SelectedIndex)
            {
                case 0:
                    grid_user.Visibility = Visibility.Visible;
                    grid_video_game.Visibility = Visibility.Collapsed;
                    grid_user_loan.Visibility = Visibility.Collapsed;
                    ShowUserList();
                    break;
                case 1:
                    grid_user.Visibility = Visibility.Collapsed;
                    grid_video_game.Visibility = Visibility.Visible;
                    grid_user_loan.Visibility = Visibility.Collapsed;
                    break;
                case 2:
                    grid_user.Visibility = Visibility.Collapsed;
                    grid_video_game.Visibility = Visibility.Collapsed;
                    grid_user_loan.Visibility = Visibility.Visible;
                    break;
            }
        }

        private void ShowUserList()
        {
            dg_user.ItemsSource = Dao.GetUsers();
        }

        private void ButtonLogin_OnClick(object sender, RoutedEventArgs e)
        {
            string pwd = Dao.GetPwdByUserName(login_user.Text);
            if (login_pwd.Password != pwd)
            {
                login_error_text.Visibility = Visibility.Visible;
                login_pwd.Password = string.Empty;
                return;
            }

            Login_ui.Visibility = Visibility.Collapsed;

        }

        private void ButtonReg_OnClick(object sender, RoutedEventArgs e)
        {

        }
    }
}
