using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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
    /// Логика взаимодействия для CustomCalendar.xaml
    /// </summary>
    public partial class CustomCalendar : UserControl
    {
        public CustomCalendar()
        {
            InitializeComponent();
            SelectedDateTxtBx.Text = DateTime.Now.ToShortDateString();
            IDs[] id = FillIDs();   
            CalDGRV.ItemsSource = id;
            Cal.BorderThickness = new Thickness(0,0,0,0);
            String s = "10";
            
            /*foreach (DataGridCellInfo cellInfo in CalDGRV.Items)
            {
                //cellInfo.Column.CellStyle.Setters.Add(new Setter(new DependencyProperty(), cellInfo));
                //DataGridCell gridCell = TryToFindGridCell(CalDGRV, cellInfo);

            }*/
            //Cal.FontSize = 20;
        }

        static DataGridCell TryToFindGridCell(DataGrid grid, DataGridCellInfo cellInfo)
        {
            DataGridCell result = null;
            DataGridRow row = (DataGridRow)grid.ItemContainerGenerator.ContainerFromItem(cellInfo.Item);
            if (row != null)
            {
                int columnIndex = grid.Columns.IndexOf(cellInfo.Column);
                if (columnIndex > -1)
                {
                    DataGridCellsPresenter presenter = GetVisualChild<DataGridCellsPresenter>(row);
                    result = presenter.ItemContainerGenerator.ContainerFromIndex(columnIndex) as DataGridCell;
                }
            }
            return result;
        }

        static T GetVisualChild<T>(Visual parent) where T : Visual
        {
            T child = default(T);
            int numVisuals = VisualTreeHelper.GetChildrenCount(parent);
            for (int i = 0; i < numVisuals; i++)
            {
                Visual v = (Visual)VisualTreeHelper.GetChild(parent, i);
                child = v as T;
                if (child == null)
                {
                    child = GetVisualChild<T>(v);
                }
                if (child != null)
                {
                    break;
                }
            }
            return child;
        }

        public void Cal_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedDate = "";
            var calendar = sender as Calendar;

            // ... See if a date is selected.
            if (calendar.SelectedDate.HasValue)
            {
                // ... Display SelectedDate in Title.
                var date = calendar.SelectedDate.Value;
                selectedDate = date.ToShortDateString();
                SelectedDateTxtBx.Text = selectedDate;
                //f.Text = "dsfsdfs";
            }
        }

        private IDs[] FillIDs()
        {
            var id = new IDs[68];
            for (var i = 0; i < 68; i++)
            {
                var z = new Random(i);
                id[i] = new IDs(i % 4 == 0 ? doublelettered(Convert.ToString((i + 1) / 4 + 7)) : "",
                    i % 4 == 0 ? "00" : i % 4 == 1 ? "15" : i % 4 == 2 ? "30" : "45",
                    "12345",
                    Convert.ToString(z.Next() % 1000),
                    Convert.ToString(z.Next() % 1000),
                    "Orange",
                    "DodgerBlue",
                    "DodgerBlue");
            }

            return id;
        }
        private string doublelettered(string txt)
        {
            return txt.Length == 1 ? "0" + txt : txt;
        }

        private void TodayBtn_OnClick(object sender, RoutedEventArgs e)
        {
            Cal.SelectedDate = DateTime.Now;
            Cal.DisplayDate = DateTime.Now;
        }

        private void IdCallTxtBx_OnDragLeave(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
            {
                e.Effects = DragDropEffects.All;
                // = System.Windows.Forms.DragDropEffects.All;
            } 
        }

        private void Thumb1_DragDelta(object sender, DragDeltaEventArgs e)
        {
            SetThumbsPosition(sender, e, Thumb1);
        }

        private void Thumb1_DragStarted(object sender, DragStartedEventArgs e)
        {
            Thumb1.DataContext = IdCallTxtBxBrdr;
        }

        private void Thumb1_DragCompleted(object sender, DragCompletedEventArgs e)
        {
            BorderThickness = new Thickness(3);
            BorderBrush = Brushes.DodgerBlue;
            SetCalElemEnabled(false);
        }
        private void Thumb2_DragDelta(object sender, DragDeltaEventArgs e)
        {
            SetThumbsPosition(sender, e, Thumb2);
        }

        private void Thumb2_DragStarted(object sender, DragStartedEventArgs e)
        {
            Thumb2.DataContext = IdMeetingTxtBxBrdr;
        }

        private void Thumb2_DragCompleted(object sender, DragCompletedEventArgs e)
        {
            BorderThickness = new Thickness(3);
            BorderBrush = Brushes.DodgerBlue;
            SetCalElemEnabled(false);
            
        }

        private void SetThumbsPosition(object sender, DragDeltaEventArgs e, Thumb thumb)
        {
            (thumb.DataContext as Border).Margin = new Thickness((thumb.DataContext as Border).Margin.Left + e.HorizontalChange,
                (thumb.DataContext as Border).Margin.Top + e.VerticalChange,
                (thumb.DataContext as Border).Margin.Right - e.HorizontalChange,
                (thumb.DataContext as Border).Margin.Bottom - e.VerticalChange);


            thumb.Margin = new Thickness(thumb.Margin.Left + e.HorizontalChange,
                thumb.Margin.Top + e.VerticalChange, thumb.Margin.Right - e.HorizontalChange,
                thumb.Margin.Bottom - e.VerticalChange);
        }

        private void SetCalElemEnabled(bool s)
        {
            CalDGRV.IsEnabled = s;
            //CustomCalendar.IdCallTxtBx.IsEnabled = s;
            IdCallTxtBxBrdr.IsEnabled = s;
            IdMeetingTxtBxBrdr.IsEnabled = s;
            if (!s)
            {
                IdCallTxtBxBrdr.Visibility = Visibility.Hidden;
                IdMeetingTxtBxBrdr.Visibility = Visibility.Hidden;
            }
            Thumb1.IsEnabled = s;
            Thumb2.IsEnabled = s;
        }

        private void CalDGRV_OnPreviewMouseWheel(object sender, MouseWheelEventArgs e)
        {
            CalDgrvScroll.ScrollToVerticalOffset(CalDgrvScroll.VerticalOffset - e.Delta);
        }
    }
}
