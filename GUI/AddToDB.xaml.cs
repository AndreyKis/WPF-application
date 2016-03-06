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

namespace GUI
{
    /// <summary>
    /// Логика взаимодействия для AddToDB.xaml
    /// </summary>
    public partial class AddToDB : UserControl
    {
        public AddToDB()
        {
            InitializeComponent();
            
        }

        private void CloseBtn_OnMouseEnter(object sender, MouseEventArgs e)
        {
            Button closeBtn = (Button)sender;
            closeBtn.Background = Brushes.Cyan;
            closeBtn.Opacity = 1;
        }

        private void CloseBtn_OnClick(object sender, RoutedEventArgs e)
        {
            Window parentWindow = Window.GetWindow(this);
            Object addToDBControl = parentWindow.FindName("AddToDbFrame");
            Frame addToDBFrame = null;
            if (addToDBControl is Frame)
            {
                addToDBFrame = (Frame)addToDBControl;
            }
            addToDBFrame.Content = null;
            addToDBFrame.Visibility = Visibility.Hidden;
        }

        private void CloseBtn_OnMouseLeave(object sender, MouseEventArgs e)
        {
            Button closeBtn = (Button)sender;
            closeBtn.Opacity = 0;
        }
    }
}
