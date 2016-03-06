using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Threading;
using Common;
using AccessToClientsDB;
using Calendar = System.Windows.Controls.Calendar;

namespace GUI
{
    /// <summary>
    ///     Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //AccessToClientsDB.AccessToClientsDB dataBase = new AccessToClientsDB.AccessToClientsDB();
        private readonly DispatcherTimer Timer;
        //public int rowNumber;
        public List<Company> AllCompanies;
        private Company CurrCompany;


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            SetCalElemEnabled(false);

                if (ActualWidth < 700)
            {
                AvatarBorder.Visibility = Visibility.Collapsed;
                Avatar.Visibility = Visibility.Collapsed;
            }
        }  
        // поток  
        public MainWindow()
        {
            
            InitializeComponent();
            //AllCompanies = dataBase.GetAllCompanies()

            //Example of Filling DGRV
            List<Company> list = new List<Company>();
            List<Contact> list1 = new List<Contact>();
            Contact contact1 = new Contact(221, 1, "+7 (495) 231-24-52 общий", 1, 0);
            Contact contact2 = new Contact(221, 1, "+7 (495) 231-24-52 приемная", 1, 0);
            Contact contact3 = new Contact(221, 1, "+7 (495) 231-24-52 Николай", 1, 0);
            list1.Add(contact1);
            list1.Add(contact2);
            list1.Add(contact3);
            list.Add(new Company(223, "Технабсервис", "Петров\nАлександр\nНиколаевич", Convert.ToDateTime("21.02.2012"), "", list1));
            list.Add(new Company(224, "Технабсервис", "Петров\nАлександр\nНиколаевич", Convert.ToDateTime("21.02.2012"), "", list1));
            list.Add(new Company(225, "Технабсервис", "Петров\nАлександр\nНиколаевич", Convert.ToDateTime("21.02.2012"), "", list1));
            list.Add(new Company(226, "Технабсервис", "Петров\nАлександр\nНиколаевич", Convert.ToDateTime("21.02.2012"), "", list1));
            list.Add(new Company(227, "Технабсервис", "Петров\nАлександр\nНиколаевич", Convert.ToDateTime("21.02.2012"), "", list1));
            list.Add(new Company(228, "Технабсервис", "Петров\nАлександр\nНиколаевич", Convert.ToDateTime("21.02.2012"), "", list1));
            list.Add(new Company(229, "Технабсервис", "Петров\nАлександр\nНиколаевич", Convert.ToDateTime("21.02.2012"), "", list1));
            list.Add(new Company(230, "Технабсервис", "Петров\nАлександр\nНиколаевич", Convert.ToDateTime("21.02.2012"), "", list1));
            list.Add(new Company(231, "Технабсервис", "Петров\nАлександр\nНиколаевич", Convert.ToDateTime("21.02.2012"), "", list1));
            list.Add(new Company(232, "Технабсервис", "Петров\nАлександр\nНиколаевич", Convert.ToDateTime("21.02.2012"), "", list1));
            list.Add(new Company(233, "Технабсервис", "Петров\nАлександр\nНиколаевич", Convert.ToDateTime("21.02.2012"), "", list1));
            list.Add(new Company(234, "Технабсервис", "Петров\nАлександр\nНиколаевич", Convert.ToDateTime("21.02.2012"), "", list1));
            list.Add(new Company(235, "Технабсервис", "Петров\nАлександр\nНиколаевич", Convert.ToDateTime("21.02.2012"), "", list1));
            list.Add(new Company(236, "Технабсервис", "Петров\nАлександр\nНиколаевич", Convert.ToDateTime("21.02.2012"), "", list1));
            list.Add(new Company(237, "Технабсервис", "Петров\nАлександр\nНиколаевич", Convert.ToDateTime("21.02.2012"), "", list1));
            list.Add(new Company(238, "Технабсервис", "Петров\nАлександр\nНиколаевич", Convert.ToDateTime("21.02.2012"), "", list1));
            list.Add(new Company(239, "Технабсервис", "Петров\nАлександр\nНиколаевич", Convert.ToDateTime("21.02.2012"), "", list1));
            list.Add(new Company(240, "Технабсервис", "Петров\nАлександр\nНиколаевич", Convert.ToDateTime("21.02.2012"), "", list1));
            list.Add(new Company(241, "Технабсервис", "Петров\nАлександр\nНиколаевич", Convert.ToDateTime("21.02.2012"), "", list1));

            Dgrv.ItemsSource = list;
            //Dgrv.ItemsSource = AllCompanies;


            //Creating timeField
            Timer = new DispatcherTimer();
            Timer.Interval = TimeSpan.FromSeconds(1.0);
            Timer.Start();
            Timer.Tick += delegate
            {
                var datetime = DateTime.Now;
                TimeTextBlock.Text = datetime.ToString("HH mm");
            };
            var face = new Typeface("Arial");
            var fase = new FamilyTypeface();
            var someFormattedText = new FormattedText("Hello", CultureInfo.CurrentCulture,
                FlowDirection.LeftToRight, face, 12, Brushes.AliceBlue);

            TimeTextBlock.FontSize = 38;
            TimeTextBlock.VerticalAlignment = VerticalAlignment.Center;
            TimeTextBlock.HorizontalAlignment = HorizontalAlignment.Center;
            TimeTextBlock.FontFamily = new FontFamily("Comic Sans MS");


            TextBlock text = new TextBlock()
            {
                Name = "myText",
                Text = "This is my cool Pic"
            };
            
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
        
        public static T FindParent<T>(DependencyObject child)
           where T : DependencyObject
        {
            // Confirm parent is valid.  
            if (child == null) return null;

            T foundParent = null;


                var parent = VisualTreeHelper.GetParent(child);// GetChild(parent, i);
                // If the child is not of the request child type child 
                T parentType = parent as T;
                if (parentType == null)
                {
                    // recursively drill down the tree 
                    foundParent = FindParent<T>(child);

                    // If the child is found, break so we do not overwrite the found child.  
                }
                else
                {
                    // child element found. 
                    foundParent = (T)parent;
                }
            return foundParent;
        }

        

        private void AddToDB_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < Dgrv.Items.Count; i++)
            {
                DataGridRow row = (DataGridRow)Dgrv.ItemContainerGenerator.ContainerFromIndex(i);

                if (row.IsSelected)
                {
                    Button KBtn = FindChild<Button>(row, "KBtn");
                    if (KBtn != null)
                    {
                        Point relativePoint = KBtn.TransformToAncestor(Application.Current.MainWindow)
                              .Transform(new Point(0, 0));
                        MessageBox.Show(relativePoint.ToString());
                    }
                }
            }

            if (AddToDbFrame.NavigationService.Content != null)
                AddToDbFrame.NavigationService.Content = null;
                
            else if (Frame2.NavigationService.Content == null && TelFrame.NavigationService.Content == null)
            {
                AddToDbFrame.NavigationService.Navigate(new Uri("AddToDB.xaml", UriKind.Relative));
                AddToDbFrame.Visibility = Visibility.Visible;
            }         
        }

        private void PrepLetterBtn_OnClick(object sender, RoutedEventArgs e)
        {
            //if (Dgrv.SelectedIndex == App.rowNumber)
            //{
            //    SetFrameContent(350, 268, "CreateLetter", Frame2, sender);
            //    //rowNumber = Dgrv.SelectedIndex;
            //}
            SetFrameContentAndPos(350, 268, "CreateLetter", Frame2, sender);
        }
        private void DButton_OnClick(object sender, RoutedEventArgs e)
        {
            //if (Dgrv.SelectedIndex == App.rowNumber)
            //{
            //    SetFrameContent(480, 345, "PrepareAgreement", Frame2, sender);
            //}
            SetFrameContentAndPos(480, 345, "PrepareAgreement", Frame2, sender);
        }

        private void PaymentCntrlBtn_OnClick(object sender, RoutedEventArgs e)
        {
            //if (Dgrv.SelectedIndex == App.rowNumber)
            //{
            //    //rowNumber = globCurrSelectedRowIndex;
            //    SetFrameContent(220, 115, "PaymentControl", Frame2, sender);
            //}
            SetFrameContentAndPos(220, 115, "PaymentControl", Frame2, sender);

        }

        private void SendBtn_OnClick(object sender, RoutedEventArgs e)
        {
            //if (Dgrv.SelectedIndex == App.rowNumber)
            //{
            //    //rowNumber = globCurrSelectedRowIndex;
            //    SetFrameContent(400, 368, "SendButton", Frame2, sender);
            //}
            SetFrameContentAndPos(400, 368, "SendButton", Frame2, sender);
        }

        private void LayoutBtn_OnClick(object sender, RoutedEventArgs e)
        {
            //if (Dgrv.SelectedIndex == App.rowNumber)
            //{
            //    //rowNumber = globCurrSelectedRowIndex;
            //    SetFrameContent(430, 420, "CreateLayout", Frame2, sender);
            //}
            SetFrameContentAndPos(430, 420, "CreateLayout", Frame2, sender);
        }

        private void ActBtn_OnClick(object sender, RoutedEventArgs e)
        {
            /*if (Dgrv.SelectedIndex == App.rowNumber)
            {
                //rowNumber = globCurrSelectedRowIndex;
                SetFrameContent(402, 315, "Act", Frame2, sender);
            }*/
            SetFrameContentAndPos(402, 315, "Act", Frame2, sender);
        }

        private int onFrameBtnClickIndex = -2;

 
        private void TelBtn_OnMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            //if (Dgrv.SelectedIndex == App.rowNumber)
            //{
            //    DataGridRow selectedRow =
            //        (DataGridRow) Dgrv.ItemContainerGenerator.ContainerFromIndex(Dgrv.SelectedIndex);
            //    DataGridRow ficsatedRow =
            //        (DataGridRow) Dgrv.ItemContainerGenerator.ContainerFromIndex(App.rowNumber);
            //    var bc = new BrushConverter();
            //    if (TelFrame.Content == null)
            //    {
            //        onFrameBtnClickIndex = Dgrv.SelectedIndex;


            //        Window currWindow = Application.Current.MainWindow;
            //        double winHeight = SystemParameters.PrimaryScreenHeight;


            //        Point selectedRowPoint =
            //            selectedRow.TransformToAncestor(currWindow).Transform(new Point(0, 0));
            //        Point dataGridPoint =
            //            Dgrv.TransformToAncestor(currWindow).Transform(new Point(0, 0));
            //        Point dgrvScrollPoint =
            //            DgrvScroll.TransformToAncestor(currWindow).Transform(new Point(0, 0));

            //        Double dgrvScrollY = DgrvScroll.VerticalOffset;

            //        Thickness tmpMargin = TelFrame.Margin;
            //        tmpMargin.Top = dataGridPoint.Y + selectedRowPoint.Y - dgrvScrollPoint.Y + dgrvScrollY - 164;
            //        TelFrame.Margin = tmpMargin;

            //        if (selectedRowPoint.Y + selectedRow.ActualHeight + TelFrame.Height - 70 > winHeight)
            //            //TelFrame.TransformToAncestor(currWindow).Transform(new Point(0, 0)).Y + TelFrame.Height >= winHeight)
            //        {
            //            tmpMargin.Top = dataGridPoint.Y + selectedRowPoint.Y - dgrvScrollPoint.Y + dgrvScrollY +
            //                            selectedRow.ActualHeight - TelFrame.Height - 164;
            //            TelFrame.Margin = tmpMargin;
            //        }

            //        selectedRow.Background = Brushes.LightGray;
            //        selectedRow.BorderThickness = new Thickness(0, 1, 0, 1);
            //        selectedRow.BorderBrush = Brushes.Blue;

            //        App.rowNumber = Dgrv.SelectedIndex;
            //        SetFrameContent(228, 258, "Telephones", TelFrame, sender);

            //    }
            //}
            SetFrameContentAndPos(228,233,"Telephones", TelFrame, sender);
        }

        private void SetFrameContentAndPos(int width, int height, String contentName, Frame Frame, object sender)
        {
            //SetFrameContent(width, height, contentName, Frame, sender);
            if (Dgrv.SelectedIndex == App.rowNumber)
            {
                DataGridRow selectedRow =
                    (DataGridRow) Dgrv.ItemContainerGenerator.ContainerFromIndex(Dgrv.SelectedIndex);
                DataGridRow ficsatedRow =
                    (DataGridRow) Dgrv.ItemContainerGenerator.ContainerFromIndex(App.rowNumber);
                var bc = new BrushConverter();
                if (Frame.Content == null)
                {
                    onFrameBtnClickIndex = Dgrv.SelectedIndex;


                    Window currWindow = Application.Current.MainWindow;
                    double winHeight = SystemParameters.PrimaryScreenHeight;


                    Point selectedRowPoint =
                        selectedRow.TransformToAncestor(currWindow).Transform(new Point(0, 0));
                    Point dataGridPoint =
                        Dgrv.TransformToAncestor(currWindow).Transform(new Point(0, 0));
                    Point dgrvScrollPoint =
                        DgrvScroll.TransformToAncestor(currWindow).Transform(new Point(0, 0));

                    Double dgrvScrollY = DgrvScroll.VerticalOffset;

                    Thickness tmpMargin = Frame.Margin;
                    tmpMargin.Top = dataGridPoint.Y + selectedRowPoint.Y - dgrvScrollPoint.Y + dgrvScrollY - 164;
                    Frame.Margin = tmpMargin;

                    if (selectedRowPoint.Y + selectedRow.ActualHeight + Frame.Height - 30 > winHeight)
                        //TelFrame.TransformToAncestor(currWindow).Transform(new Point(0, 0)).Y + TelFrame.Height >= winHeight)
                    {
                        tmpMargin.Top = dataGridPoint.Y + selectedRowPoint.Y - dgrvScrollPoint.Y + dgrvScrollY +
                                        selectedRow.ActualHeight - Frame.Height - 164;
                        Frame.Margin = tmpMargin;
                    }

                    selectedRow.Background = Brushes.LightGray;
                    selectedRow.BorderThickness = new Thickness(0, 2, 0, 2);
                    selectedRow.BorderBrush = Brushes.Blue;

                    //double x = Frame2.TransformToAncestor(currWindow).Transform(new Point(0, 0)).X;
                    //double y = Frame2.TransformToAncestor(currWindow).Transform(new Point(0, 0)).Y;
                    //MessageBox.Show(x + " + " + y);
                    App.rowNumber = Dgrv.SelectedIndex;
                    //SetFrameContent(width, height, contentName, Frame, sender);

                }
                SetFrameContent(width, height, contentName, Frame, sender);
            }
        }

        private void SetFrameContent(int width, int height, String contentName, Frame Frame, object sender)
        {
            //DataGridRow pressedBtnRow = FindParent<DataGridRow>(pressedBtn);
            Button pressedBtn = (Button)sender;


            if (Frame.NavigationService.Content != null && Frame.NavigationService.CurrentSource != null)
            {
                if (Frame.NavigationService.CurrentSource.Equals(new Uri(contentName + ".xaml", UriKind.Relative)) &&
                    Dgrv.SelectedIndex == App.rowNumber)
                {
                    Frame.NavigationService.Content = null;
                    Frame.BorderThickness = new Thickness(0);
                    ((Button)sender).BorderThickness = new Thickness(1);
                    ((Button)sender).BorderBrush = Brushes.Gray;
                    Frame.Visibility = Visibility.Hidden;

                }
                Dgrv.SelectedIndex = App.rowNumber;
            }
            else
            {
                if (width != -1 && height != -1)
                {
                    Frame.Width = width;
                    Frame.Height = height;
                }
                Frame.BorderThickness = new Thickness(2);
                Frame.NavigationService.Navigate(new Uri(contentName + ".xaml", UriKind.Relative));
                App.rowNumber = Dgrv.SelectedIndex;
                Frame.Visibility = Visibility.Visible;
                ((Button)sender).BorderThickness = new Thickness(2);
                ((Button)sender).BorderBrush = Brushes.Blue;
            }
        }

        

        private void DgrvScroll_OnScrollChanged(object sender, ScrollChangedEventArgs e)
        {
                var scrollViewer = (ScrollViewer) sender;
                Double dgrvScrollY = scrollViewer.VerticalOffset;
                //Tmp.Text = dgrvScrollY.ToString();
                if (dgrvScrollY < 0)
                    dgrvScrollY = 0;

                if (dgrvScrollY != 0)
                {
                    if (Dgrv.SelectedIndex != -1)
                    {
                        SetPosOnScrollChanged(TelFrame, dgrvScrollY);
                        SetPosOnScrollChanged(Frame2, dgrvScrollY);
                    }
                }
        }

        private void SetPosOnScrollChanged(Frame frame, Double dgrvScrollY)
        {
            DataGridRow selectedRow =
                        (DataGridRow)Dgrv.ItemContainerGenerator.ContainerFromIndex(Dgrv.SelectedIndex);

            Window currWindow = Application.Current.MainWindow;
            double winHeight = SystemParameters.PrimaryScreenHeight;



            Point selectedRowPoint =
                selectedRow.TransformToAncestor(currWindow).Transform(new Point(0, 0));
            Point dataGridPoint =
                Dgrv.TransformToAncestor(currWindow).Transform(new Point(0, 0));
            Point dgrvScrollPoint =
                DgrvScroll.TransformToAncestor(currWindow).Transform(new Point(0, 0));
            /*Tmp.Text = dataGridPoint.Y.ToString();
            Tmp2.Text = dgrvScrollPoint.Y.ToString();
            Tmp3.Text = selectedRowPoint.Y.ToString();
            Tmp4.Text = dgrvScrollY.ToString();*/

            
            Thickness tmpMargin = frame.Margin;
            tmpMargin.Top = (int)dataGridPoint.Y + (int)selectedRowPoint.Y - (int)dgrvScrollPoint.Y + (int)dgrvScrollY - 164;
            frame.Margin = tmpMargin;


            if (selectedRowPoint.Y + selectedRow.ActualHeight + frame.Height - 30 > winHeight)
            //TelFrame.TransformToAncestor(currWindow).Transform(new Point(0, 0)).Y + TelFrame.Height >= winHeight)
            {
                tmpMargin.Top = dataGridPoint.Y + selectedRowPoint.Y - dgrvScrollPoint.Y + dgrvScrollY +
                                selectedRow.ActualHeight - frame.Height - 164;
                frame.Margin = tmpMargin;
            }



        }

        private void Dgrv_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int prevRowIndex = 0;

            try
            {
                prevRowIndex = GetRowIDByContract((Company) e.RemovedItems[0]);
            }
            catch (Exception c)
            {}
            int newRowIndex = GetRowIDByContract((Company)e.AddedItems[0]);
            CurrCompany = (Company) e.AddedItems[0];

            DataGridRow ficsatedRow =
                        (DataGridRow)Dgrv.ItemContainerGenerator.ContainerFromIndex(App.rowNumber);
            DataGridRow selectedRow =
                        (DataGridRow)Dgrv.ItemContainerGenerator.ContainerFromIndex(Dgrv.SelectedIndex);
            DataGridRow prevRow =
                        (DataGridRow)Dgrv.ItemContainerGenerator.ContainerFromIndex(prevRowIndex);
            DataGridRow newRow =
                        (DataGridRow)Dgrv.ItemContainerGenerator.ContainerFromIndex(newRowIndex);

            //DataGridColumn btnsColumn = Dgrv.Columns.Single(c => c.Header == "BtnsColumn");
            var bc = new BrushConverter();

            if (TelFrame.Content != null || Frame2.Content != null)
            {
                if (newRowIndex != App.rowNumber)
                {
                    newRow.Background = (Brush) bc.ConvertFrom("#ffefefef");
                    newRow.Foreground = Brushes.Black;
                    newRow.BorderThickness = new Thickness(0, 0, 0, 0);
                }
            }
            else
            {

                newRow.Background = Brushes.LightGray;
                newRow.BorderBrush = Brushes.Blue;
                newRow.BorderThickness = new Thickness(0, 2, 0, 2);
                if (prevRowIndex != Dgrv.SelectedIndex)
                {

                    prevRow.Background = (Brush) bc.ConvertFrom("#ffefefef");
                    prevRow.Foreground = Brushes.Black;
                    prevRow.BorderThickness = new Thickness(0, 0, 0, 0);
                }
                
                App.rowNumber = Dgrv.SelectedIndex;
            }
        }

        private int GetRowIDByContract(Company company)
        {
            int rowID = 0;
            DataGridRow rowWithContract = null;
            TextBlock id = new TextBlock();
            id.Text = company.ID.ToString();
            var rows = GetDataGridRows(Dgrv);
            foreach (DataGridRow currRow in rows)
            {
                if (currRow.Item.Equals(company))
                    rowID = currRow.GetIndex();
            }
            return rowID;
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

        private void ApplCloseBtn_OnClick(object sender, RoutedEventArgs e)
        {
            MessageBoxResult correctorRes = MessageBox.Show("Вы уверены, что хотите закрыть приложение?",
                "Закрыть приложение", MessageBoxButton.YesNo);
            if (correctorRes == MessageBoxResult.Yes)
            {
                Close();
            }
        }

        private void AdminSettings_OnClick(object sender, RoutedEventArgs e)
        {
            SetFrameContent(-1,-1,"AdminSettings", AdminSettingsFrame,sender);
        }


        private void SetCalElemEnabled(bool s)
        {
            CustomCalendar.CalDGRV.IsEnabled = s;
            //CustomCalendar.IdCallTxtBx.IsEnabled = s;
            CustomCalendar.IdCallTxtBxBrdr.IsEnabled = s;
            CustomCalendar.IdCallTxtBxBrdr.Margin = new Thickness(4, -10, 2, 20);
            CustomCalendar.Thumb1.Margin = new Thickness(4, -10, 2, 20);
            CustomCalendar.IdMeetingTxtBxBrdr.IsEnabled = s;
            CustomCalendar.IdMeetingTxtBxBrdr.Margin = new Thickness(2, -10, 4, 20);
            CustomCalendar.Thumb2.Margin = new Thickness(2, -10, 4, 20);
            if (s)
            {
                CustomCalendar.IdCallTxtBxBrdr.Visibility = Visibility.Visible;
                CustomCalendar.IdMeetingTxtBxBrdr.Visibility = Visibility.Visible;
            }
            CustomCalendar.Thumb1.IsEnabled = s;
            CustomCalendar.Thumb2.IsEnabled = s;
        }

        private void Dgrv_OnPreviewMouseWheel(object sender, MouseWheelEventArgs e)
        {
            DgrvScroll.ScrollToVerticalOffset(DgrvScroll.VerticalOffset - e.Delta);

        }

        private void SetDateBtn_OnMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            //CustomCalendar.MeetingsAmount
            CustomCalendar.BorderBrush = Brushes.Yellow;
            CustomCalendar.BorderThickness = new Thickness(6);
            SetCalElemEnabled(true);
            CustomCalendar.IdCallTxtBx.Text = CurrCompany.ID.ToString();
            CustomCalendar.IdMeetingTxtBx.Text = CurrCompany.ID.ToString();
        }
    }
}