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
using System.Windows.Shapes;

namespace GUI
{
    /// <summary>
    /// Логика взаимодействия для Telephones.xaml
    /// </summary>
    public partial class Telephones : Page
    {
        public Telephones()
        {
            InitializeComponent();
        }

        private void CloseBtn_OnMouseEnter(object sender, MouseEventArgs e)
        {
            Button closeBtn = (Button)sender;
            //closeBtn.Background = Brushes.Red;
            closeBtn.Opacity = 1;
        }

        private void CloseBtn_OnMouseLeave(object sender, MouseEventArgs e)
        {
            Button closeBtn = (Button)sender;
            closeBtn.Opacity = 0;
        }

        private void CloseBtn_OnClick(object sender, RoutedEventArgs e)
        {
            Window parentWindow = Window.GetWindow(this);

            Object telControl = parentWindow.FindName("TelFrame");
            Frame telFrame = null;
            if (telControl is Frame)
            {
                telFrame = (Frame)telControl;
            }

            Object Frame2Control = parentWindow.FindName("Frame2");
            Frame Frame2 = null;
            if (Frame2Control is Frame)
            {
                Frame2 = (Frame)telControl;
            }

            Object DataGridControl = parentWindow.FindName("Dgrv");
            DataGrid Dgrv = null;
            if (DataGridControl is DataGrid)
            {
                Dgrv = (DataGrid)DataGridControl;
            }




            DataGridRow selectedRow =
                        (DataGridRow)Dgrv.ItemContainerGenerator.ContainerFromIndex(App.rowNumber);
            var bc = new BrushConverter();
            /*if (Frame2.Content != null)
            {
                selectedRow.Background = (Brush) bc.ConvertFrom("#ffefefef");
                selectedRow.Foreground = Brushes.Black;
                selectedRow.BorderThickness = new Thickness(0, 0, 0, 0);
            }*/
            Dgrv.SelectedIndex = App.rowNumber;
            telFrame.Content = null;
            telFrame.Visibility = Visibility.Hidden;
        }
    }
}
