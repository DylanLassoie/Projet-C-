using Projet_C.Backend;
using Projet_C.Management;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        private DaoAdmin dao= new DaoAdmin();
        private DaoPlayer daoP= new DaoPlayer();
        private DaoVideoGame daoVG= new DaoVideoGame();
        private DaoCopy daoCP= new DaoCopy();
        public MainWindow()
        {
            InitializeComponent();
            menu_selection.SelectedIndex = 0;
            menu_selection2.SelectedIndex = 0;
        }

        private void Selector_OnSelected(object sender, RoutedEventArgs e)
        {
            var listView = (ListView)sender;
            switch (listView.SelectedIndex)
            {
                case 0:
                    grid_ad_user.Visibility = Visibility.Visible;
                    grid_ad_user_add.Visibility = Visibility.Collapsed;
                    grid_ad_user_delete.Visibility = Visibility.Collapsed;
                    grid_ad_user_modify.Visibility = Visibility.Collapsed;
                    grid_ad_video_game.Visibility = Visibility.Collapsed;
                    grid_ad_video_game_add.Visibility = Visibility.Collapsed;
                    grid_ad_video_game_delete.Visibility = Visibility.Collapsed;
                    grid_ad_video_game_modify.Visibility = Visibility.Collapsed;
                    grid_ad_user_loan.Visibility = Visibility.Collapsed;
                    ShowUserList();
                    break;
                case 1:
                    grid_ad_user.Visibility = Visibility.Collapsed;
                    grid_ad_user_add.Visibility = Visibility.Visible;
                    grid_ad_user_delete.Visibility = Visibility.Collapsed;
                    grid_ad_user_modify.Visibility = Visibility.Collapsed;
                    grid_ad_video_game.Visibility = Visibility.Collapsed;
                    grid_ad_video_game_add.Visibility = Visibility.Collapsed;
                    grid_ad_video_game_delete.Visibility = Visibility.Collapsed;
                    grid_ad_video_game_modify.Visibility = Visibility.Collapsed;
                    grid_ad_user_loan.Visibility = Visibility.Collapsed;
                    break;
                case 2:
                    grid_ad_user.Visibility = Visibility.Collapsed;
                    grid_ad_user_add.Visibility = Visibility.Collapsed;
                    grid_ad_user_delete.Visibility = Visibility.Visible;
                    grid_ad_user_modify.Visibility = Visibility.Collapsed;
                    grid_ad_video_game.Visibility = Visibility.Collapsed;
                    grid_ad_video_game_add.Visibility = Visibility.Collapsed;
                    grid_ad_video_game_delete.Visibility = Visibility.Collapsed;
                    grid_ad_video_game_modify.Visibility = Visibility.Collapsed;
                    grid_ad_user_loan.Visibility = Visibility.Collapsed;
                    break;

                case 3:
                    grid_ad_user.Visibility = Visibility.Collapsed;
                    grid_ad_user_add.Visibility = Visibility.Collapsed;
                    grid_ad_user_delete.Visibility = Visibility.Collapsed;
                    grid_ad_user_modify.Visibility = Visibility.Visible;
                    grid_ad_video_game.Visibility = Visibility.Collapsed;
                    grid_ad_video_game_add.Visibility = Visibility.Collapsed;
                    grid_ad_video_game_delete.Visibility = Visibility.Collapsed;
                    grid_ad_video_game_modify.Visibility = Visibility.Collapsed;
                    grid_ad_user_loan.Visibility = Visibility.Collapsed;
                    break;
                case 4:
                    grid_ad_user.Visibility = Visibility.Collapsed;
                    grid_ad_user_add.Visibility = Visibility.Collapsed;
                    grid_ad_user_delete.Visibility = Visibility.Collapsed;
                    grid_ad_user_modify.Visibility = Visibility.Collapsed;
                    grid_ad_video_game.Visibility = Visibility.Visible;
                    grid_ad_video_game_add.Visibility = Visibility.Collapsed;
                    grid_ad_video_game_delete.Visibility = Visibility.Collapsed;
                    grid_ad_video_game_modify.Visibility = Visibility.Collapsed;
                    grid_ad_user_loan.Visibility = Visibility.Collapsed;
                    break;
                case 5:
                    grid_ad_user.Visibility = Visibility.Collapsed;
                    grid_ad_user_add.Visibility = Visibility.Collapsed;
                    grid_ad_user_delete.Visibility = Visibility.Collapsed;
                    grid_ad_user_modify.Visibility = Visibility.Collapsed;
                    grid_ad_video_game.Visibility = Visibility.Collapsed;
                    grid_ad_video_game_add.Visibility = Visibility.Visible;
                    grid_ad_video_game_delete.Visibility = Visibility.Collapsed;
                    grid_ad_video_game_modify.Visibility = Visibility.Collapsed;
                    grid_ad_user_loan.Visibility = Visibility.Collapsed;
                    break;
                case 6:
                    grid_ad_user.Visibility = Visibility.Collapsed;
                    grid_ad_user_add.Visibility = Visibility.Collapsed;
                    grid_ad_user_delete.Visibility = Visibility.Collapsed;
                    grid_ad_user_modify.Visibility = Visibility.Collapsed;
                    grid_ad_video_game.Visibility = Visibility.Collapsed;
                    grid_ad_video_game_add.Visibility = Visibility.Collapsed;
                    grid_ad_video_game_delete.Visibility = Visibility.Visible;
                    grid_ad_video_game_modify.Visibility = Visibility.Collapsed;
                    grid_ad_user_loan.Visibility = Visibility.Collapsed;
                    break;
                case 7:
                    grid_ad_user.Visibility = Visibility.Collapsed;
                    grid_ad_user_add.Visibility = Visibility.Collapsed;
                    grid_ad_user_delete.Visibility = Visibility.Collapsed;
                    grid_ad_user_modify.Visibility = Visibility.Collapsed;
                    grid_ad_video_game.Visibility = Visibility.Collapsed;
                    grid_ad_video_game_add.Visibility = Visibility.Collapsed;
                    grid_ad_video_game_delete.Visibility = Visibility.Collapsed;
                    grid_ad_video_game_modify.Visibility = Visibility.Visible;
                    grid_ad_user_loan.Visibility = Visibility.Collapsed;
                    break;
                case 8:
                    grid_ad_user.Visibility = Visibility.Collapsed;
                    grid_ad_user_add.Visibility = Visibility.Collapsed;
                    grid_ad_user_delete.Visibility = Visibility.Collapsed;
                    grid_ad_user_modify.Visibility = Visibility.Collapsed;
                    grid_ad_video_game.Visibility = Visibility.Collapsed;
                    grid_ad_video_game_add.Visibility = Visibility.Collapsed;
                    grid_ad_video_game_delete.Visibility = Visibility.Collapsed;
                    grid_ad_video_game_modify.Visibility = Visibility.Collapsed;
                    grid_ad_user_loan.Visibility = Visibility.Visible;
                    break;
            }
        }

        private void Selector_OnSelected2(object sender, RoutedEventArgs e)
        {
            var listView = (ListView)sender;
            switch (listView.SelectedIndex)
            {
                case 0:
                    grid_pl_video_game.Visibility = Visibility.Visible;
                    grid_pl_video_game_add.Visibility = Visibility.Collapsed;
                    grid_pl_video_game_delete.Visibility = Visibility.Collapsed;
                    grid_pl_video_game_modify.Visibility = Visibility.Collapsed;
                    grid_pl_user_loan.Visibility = Visibility.Collapsed;
                    ShowUserList();
                    break;
                case 1:
                    grid_pl_video_game.Visibility = Visibility.Collapsed;
                    grid_pl_video_game_add.Visibility = Visibility.Visible;
                    grid_pl_video_game_delete.Visibility = Visibility.Collapsed;
                    grid_pl_video_game_modify.Visibility = Visibility.Collapsed;
                    grid_pl_user_loan.Visibility = Visibility.Collapsed;
                    break;
                case 2:
                    grid_pl_video_game.Visibility = Visibility.Collapsed;
                    grid_pl_video_game_add.Visibility = Visibility.Collapsed;
                    grid_pl_video_game_delete.Visibility = Visibility.Visible;
                    grid_pl_video_game_modify.Visibility = Visibility.Collapsed;
                    grid_pl_user_loan.Visibility = Visibility.Collapsed;
                    break;

                case 3:
                    grid_pl_video_game.Visibility = Visibility.Collapsed;
                    grid_pl_video_game_add.Visibility = Visibility.Collapsed;
                    grid_pl_video_game_delete.Visibility = Visibility.Collapsed;
                    grid_pl_video_game_modify.Visibility = Visibility.Visible;
                    grid_pl_user_loan.Visibility = Visibility.Collapsed;
                    break;
                case 4:
                    grid_pl_video_game.Visibility = Visibility.Collapsed;
                    grid_pl_video_game_add.Visibility = Visibility.Collapsed;
                    grid_pl_video_game_delete.Visibility = Visibility.Collapsed;
                    grid_pl_video_game_modify.Visibility = Visibility.Collapsed;
                    grid_pl_user_loan.Visibility = Visibility.Visible;
                    break;
            }
        }

        private void ShowUserList()
        {
            dg_ad_user.ItemsSource = dao.ReadAll();
            dg_ad_user_add.ItemsSource = dao.ReadAll();
            dg_ad_user_delete.ItemsSource = dao.ReadAll();
            dg_ad_user_modify.ItemsSource = dao.ReadAll();
            dg_ad_video_game.ItemsSource = daoVG.ReadAll();
            dg_ad_video_game.ItemsSource = daoVG.ReadAll();
            dg_ad_video_game.ItemsSource = daoVG.ReadAll();
            dg_ad_video_game.ItemsSource = daoVG.ReadAll();
            dg_ad_user_loan.ItemsSource = daoVG.ReadAll();
            dg_pl_video_game.ItemsSource = daoVG.ReadAll();
            dg_pl_video_game.ItemsSource = daoVG.ReadAll();
            dg_pl_video_game.ItemsSource = daoVG.ReadAll();
            dg_pl_video_game.ItemsSource = daoVG.ReadAll();
            dg_pl_user_loan.ItemsSource = daoVG.ReadAll();
        }

        private void ButtonLogin_OnClick(object sender, RoutedEventArgs e)
        {
            Admin  ad = dao.ReadByUnique(login_user.Text,login_pwd.Password);
            Player pl = daoP.ReadByUnique(login_user.Text, login_pwd.Password);
   
            if (ad==null && pl==null)
            {
                login_error_text.Visibility = Visibility.Visible;
                login_pwd.Password = string.Empty;
                return;
            }
            
            Login_ui.Visibility = Visibility.Collapsed;
            if(ad==null)
            {
                menu_selection.Visibility = Visibility.Collapsed;
            }
            if(pl==null)
            {
                menu_selection2.Visibility = Visibility.Collapsed;
            }
            

        }

        private void ButtonReg_OnClick(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
