using System;
using System.Collections;
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
using Common;

namespace GUI
{
    /// <summary>
    /// Логика взаимодействия для AdminSettings.xaml
    /// </summary>
    public partial class AdminSettings : Page
    {
        public AdminSettings()
        {
            InitializeComponent();
            List<User> users = new List<User>();
            users.Add(new User("", "Администратор", "", 1, 0));
            users.Add(new User("", "Директор", "", 3, 1));
            users.Add(new User("", "Ассистент", "", 1, 1));
            users.Add(new User("", "Руководитель", "", 3, 3));
            users.Add(new User("", "Менеджер 101", "", 2, 3));
            users.Add(new User("", "Менеджер 102", "", 2, 3));
            users.Add(new User("", "Менеджер 103", "", 2, 3));
            users.Add(new User("", "Руководитель", "", 1, 3));
            users.Add(new User("", "Менеджер 201", "", 2, 3));
            users.Add(new User("", "Менеджер 202", "", 2, 3));
            UsersDgrv.ItemsSource = users;
            List<AccessLevel> levels = new List<AccessLevel>();
            levels.Add(new AccessLevel(0,-1,10101));
            levels.Add(new AccessLevel(1,0,10101));
            levels.Add(new AccessLevel(2,1,01010));
            levels.Add(new AccessLevel(3,2,01011));
            levels.Add(new AccessLevel(4,3,11001));
            RightsDgrv.ItemsSource = levels;
        }

        public IEnumerable<DataGridRow> GetDataGridRows(DataGrid grid)
        {
            var itemsSource = grid.ItemsSource as IEnumerable;
            if (null == itemsSource) yield return null;
            foreach (var item in itemsSource)
            {
                var row = grid.ItemContainerGenerator.ContainerFromItem(item) as DataGridRow;
                if (null != row) yield return row;
            }
        }

        private void AnyBtnPressed(object sender, int btnLvl)
        {
            Button clickedBtn = (Button) sender;
            switch (btnLvl)
            {
                case 0:
                    UsersBtn.Background = Brushes.White;
                    ManualsBtn.Background = Brushes.White;
                    PrivaciesBtn.Background = Brushes.White;
                    break;
                case 1:
                    AddUserBtn.Background = Brushes.White;
                    ChangeUserBtn.Background = Brushes.White;
                    DeleteUserBtn.Background = Brushes.White;
                    break;
                case 2:
                    PersInfoBtn.Background = Brushes.White;
                    ColumnsBtn.Background = Brushes.White;
                    EditBtn.Background = Brushes.White;
                    MailBtn.Background = Brushes.White;
                    AgreementBtn.Background = Brushes.White;
                    LayoutBtn.Background = Brushes.White;
                    PaymentBtn.Background = Brushes.White;
                    ActBtn.Background = Brushes.White;
                    BlockBtn.Background = Brushes.White;
                    break;
                case 3:
                    NameBtn.Background = Brushes.White;
                    DepartmentBtn.Background = Brushes.White;
                    CodeBtn.Background = Brushes.White;
                    FullNameBtn.Background = Brushes.White;
                    ContactsBtn.Background = Brushes.White;
                    DateBtn.Background = Brushes.White;
                    StateBtn.Background = Brushes.White;
                    break; 
            }
            clickedBtn.Background = Brushes.Red;
        }

        private void MakeBtnsVisible()
        {
            NameBtn.Visibility = Visibility.Visible;
            DepartmentBtn.Visibility = Visibility.Visible;
            CodeBtn.Visibility = Visibility.Visible;
            FullNameBtn.Visibility = Visibility.Visible;
            ContactsBtn.Visibility = Visibility.Visible;
            DateBtn.Visibility = Visibility.Visible;
            StateBtn.Visibility = Visibility.Visible;
        }

        private void MakeBtnsInvisible()
        {
            if (NameBtn.IsVisible)
            {
                NameBtn.Visibility = Visibility.Collapsed;
                DepartmentBtn.Visibility = Visibility.Collapsed;
                CodeBtn.Visibility = Visibility.Collapsed;
                FullNameBtn.Visibility = Visibility.Collapsed;
                ContactsBtn.Visibility = Visibility.Collapsed;
                DateBtn.Visibility = Visibility.Collapsed;
                StateBtn.Visibility = Visibility.Collapsed;
            }

        }

        private void SetColumnHeaders(string first, string second, string third, string forth, string fifth,
            string sixth,
            string seventh, string eigth)
        {
            
        }

        private void UsersBtn_OnClick(object sender, RoutedEventArgs e)
        {
            AnyBtnPressed(sender,0);
        }

        private void ManualsBtn_OnClick(object sender, RoutedEventArgs e)
        {
            AnyBtnPressed(sender, 0);
        }

        private void PrivaciesBtn_OnClick(object sender, RoutedEventArgs e)
        {
            AnyBtnPressed(sender, 0);
        }

        private void AddUserBtn_OnClick(object sender, RoutedEventArgs e)
        {
            AnyBtnPressed(sender, 1);
        }

        private void ChangeUserBtn_OnClick(object sender, RoutedEventArgs e)
        {
            AnyBtnPressed(sender, 1);
        }

        private void DeleteUserBtn_OnClick(object sender, RoutedEventArgs e)
        {
            AnyBtnPressed(sender, 1);
        }

        private void PersInfoBtn_OnClick(object sender, RoutedEventArgs e)
        {
            AnyBtnPressed(sender, 2);
            MakeBtnsInvisible();
        }
        private void ColumnsBtn_OnClick(object sender, RoutedEventArgs e)
        {
            AnyBtnPressed(sender, 2);
            MakeBtnsVisible();

        }

        private void EditBtn_OnClick(object sender, RoutedEventArgs e)
        {
            AnyBtnPressed(sender, 2);
            MakeBtnsInvisible();
        }

        private void MailBtn_OnClick(object sender, RoutedEventArgs e)
        {
            AnyBtnPressed(sender, 2);
            MakeBtnsInvisible();
        }

        private void AgreementBtn_OnClick(object sender, RoutedEventArgs e)
        {
            AnyBtnPressed(sender, 2);
            MakeBtnsInvisible();
        }

        private void LayoutBtn_OnClick(object sender, RoutedEventArgs e)
        {
            AnyBtnPressed(sender, 2);
            MakeBtnsInvisible();
        }

        private void PaymentBtn_OnClick(object sender, RoutedEventArgs e)
        {
            AnyBtnPressed(sender, 2);
            MakeBtnsInvisible();
        }

        private void ActBtn_OnClick(object sender, RoutedEventArgs e)
        {
            AnyBtnPressed(sender, 2);
            MakeBtnsInvisible();
        }

        private void BlockBtn_OnClick(object sender, RoutedEventArgs e)
        {
            AnyBtnPressed(sender, 2);
            MakeBtnsInvisible();
        }

        private void NameBtn_OnClick(object sender, RoutedEventArgs e)
        {
            AnyBtnPressed(sender, 3);
        }

        private void DepartmentBtn_OnClick(object sender, RoutedEventArgs e)
        {
            AnyBtnPressed(sender, 3);
        }

        private void CodeBtn_OnClick(object sender, RoutedEventArgs e)
        {
            AnyBtnPressed(sender, 3);
        }

        private void FullNameBtn_OnClick(object sender, RoutedEventArgs e)
        {
            AnyBtnPressed(sender, 3);
        }

        private void ContactsBtn_OnClick(object sender, RoutedEventArgs e)
        {
            AnyBtnPressed(sender, 3);
        }

        private void DateBtn_OnClick(object sender, RoutedEventArgs e)
        {
            AnyBtnPressed(sender, 3);
        }

        private void StateBtn_OnClick(object sender, RoutedEventArgs e)
        {
            AnyBtnPressed(sender, 3);
        }

        private void ChooseUserBtn_OnClick(object sender, RoutedEventArgs e)
        {
            var rows = GetDataGridRows(UsersDgrv);
            foreach (DataGridRow currRow in rows)
            {
                FrameworkElement elmtTest = UsersDgrv.Columns[0].GetCellContent(currRow);
                Button tmpBtn =  FindChild<Button>(elmtTest, "ChooseUserBtn");
                //Button tmpBtn = (Button) currRow.FindName("ChooseUserBtn");
                if (tmpBtn.Background.Equals(Brushes.Red))
                {
                    tmpBtn.Background = Brushes.White;
                }
            }
            Button clickedButton = (Button) sender;
            clickedButton.Background = Brushes.Red;
        }

        public static T FindChild<T>(DependencyObject parent, string childName)
           where T : DependencyObject
        {
            // Confirm parent is valid.  
            if (parent == null) return null;

            T foundChild = null;

            int childrenCount = VisualTreeHelper.GetChildrenCount(parent);
            for (int i = 0; i < childrenCount; i++)
            {
                var child = VisualTreeHelper.GetChild(parent, i);
                // If the child is not of the request child type child 
                T childType = child as T;
                if (childType == null)
                {
                    // recursively drill down the tree 
                    foundChild = FindChild<T>(child, childName);

                    // If the child is found, break so we do not overwrite the found child.  
                    if (foundChild != null) break;
                }
                else if (!string.IsNullOrEmpty(childName))
                {
                    var frameworkElement = child as FrameworkElement;
                    // If the child's name is set for search 
                    if (frameworkElement != null && frameworkElement.Name == childName)
                    {
                        // if the child's name is of the request name 
                        foundChild = (T)child;
                        break;
                    }
                }
                else
                {
                    // child element found. 
                    foundChild = (T)child;
                    break;
                }
            }
            return foundChild;
        }
    }
}
