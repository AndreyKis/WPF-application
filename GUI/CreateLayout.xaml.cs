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
    /// Логика взаимодействия для CreateLayout.xaml
    /// </summary>
    public partial class CreateLayout : Page
    {
        public CreateLayout()
        {
            InitializeComponent();
            
        }


        private void UploadText_OnClick(object sender, RoutedEventArgs e)
        {
            MessageBoxResult journRes = MessageBox.Show("Нужен журналист?", "Загрузка текста", MessageBoxButton.YesNo);
            if (journRes == MessageBoxResult.Yes)
            {
                MessageBox.Show("Нажмите \"Отправить\" журналисту");
                CloseFrames(TransName, CorrectName, MakeUpName);
                JournName.BorderThickness = new Thickness(2);
                JournName.Visibility = Visibility.Visible;
            }
            else
            {
                if (MessageBox.Show("Нужен переводчик?", "Загрузка текста", MessageBoxButton.YesNo) ==
                    MessageBoxResult.Yes)
                {
                    MessageBox.Show("Нажмите \"Отправить\" переводчику");
                    CloseFrames(JournName, CorrectName, MakeUpName);
                    TransName.BorderThickness = new Thickness(2);
                    TransName.Visibility = Visibility.Visible;
                }
                else
                {
                    MessageBox.Show("Нажмите \"Отправить\" верстальщику");
                    CloseFrames(JournName, CorrectName, TransName);
                    MakeUpName.BorderThickness = new Thickness(2);
                    MakeUpName.Visibility = Visibility.Visible;
                }
            }
        }

        private void UploadLayout_OnClick(object sender, RoutedEventArgs e)
        {
            MessageBoxResult correctorRes = MessageBox.Show("Нужен верстальщик?", "Загрузка макета", MessageBoxButton.YesNo);
            if (correctorRes == MessageBoxResult.Yes)
            {
                MessageBox.Show("Нажмите \"Отправить\" верстальщику?");
                CloseFrames(JournName, TransName, MakeUpName);
                MakeUpName.BorderThickness = new Thickness(2);
                MakeUpName.Visibility = Visibility.Visible;
            }
            else
            {
                MessageBox.Show("Макет загружен");
            }
        }

        private void UploadPhoto_OnClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Фото загружено");
        }

        private void CloseFrames(Frame frame1, Frame frame2, Frame frame3)
        {
            if (frame1.Visibility == Visibility.Visible)
            {
                frame1.Visibility = Visibility.Hidden;
                frame1.BorderThickness = new Thickness(0);
            }
            if (frame2.Visibility == Visibility.Visible)
            {
                frame2.Visibility = Visibility.Hidden;
                frame2.BorderThickness = new Thickness(0);
            }
            if (frame3.Visibility == Visibility.Visible)
            {
                frame3.Visibility = Visibility.Hidden;
                frame3.BorderThickness = new Thickness(0);
            }
        }
    }
}
