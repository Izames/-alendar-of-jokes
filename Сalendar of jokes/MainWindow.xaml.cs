using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading;
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

namespace Сalendar_of_jokes
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Data.Text=( (DateTime.Now).ToString("MMMM yyyy"));
            FillingCalendar(Data.Text); 
        }

        private void NextMonth_Click(object sender, RoutedEventArgs e)
        {
            DateTime dateTime = DateTime.Parse(Data.Text) ;
            dateTime = dateTime.AddMonths(1);
            Data.Text = ((dateTime).ToString("MMMM yyyy"));
            FillingCalendar(Data.Text);
        }
        private void BackMonth_Click(object sender, RoutedEventArgs e)
        {
            DateTime dateTime = DateTime.Parse(Data.Text);
            dateTime = dateTime.AddMonths(-1);
            Data.Text = ((dateTime).ToString("MMMM yyyy"));
            FillingCalendar(Data.Text);
        }
        public static void FillingCalendar(string DataSelected)
        {
            (Application.Current.MainWindow as MainWindow).CalendarDays.Children.Clear();
            Day day1 = new Day();
            day1.DataOfDay.Text = "1";
            Day day2 = new Day();
            day2.DataOfDay.Text = "2";
            Day day3 = new Day();
            day3.DataOfDay.Text = "3";
            Day day4 = new Day();
            day4.DataOfDay.Text = "4";
            Day day5 = new Day();
            day5.DataOfDay.Text = "5";
            Day day6 = new Day();
            day6.DataOfDay.Text = "6";
            Day day7 = new Day();
            day7.DataOfDay.Text = "7";
            Day day8 = new Day();
            day8.DataOfDay.Text = "8";
            Day day9 = new Day();
            day9.DataOfDay.Text = "9";
            Day day10 = new Day();
            day10.DataOfDay.Text = "10";
            Day day11 = new Day();
            day11.DataOfDay.Text = "11";
            Day day12 = new Day();
            day12.DataOfDay.Text = "12";
            Day day13 = new Day();
            day13.DataOfDay.Text = "13";
            Day day14 = new Day();
            day14.DataOfDay.Text = "14";
            Day day15 = new Day();
            day15.DataOfDay.Text = "15";
            Day day16 = new Day();
            day16.DataOfDay.Text = "16";
            Day day17 = new Day();
            day17.DataOfDay.Text = "17";
            Day day18 = new Day();
            day18.DataOfDay.Text = "18";
            Day day19 = new Day();
            day19.DataOfDay.Text = "19";
            Day day20 = new Day();
            day20.DataOfDay.Text = "20";
            Day day21 = new Day();
            day21.DataOfDay.Text = "21";
            Day day22 = new Day();
            day22.DataOfDay.Text = "22";
            Day day23 = new Day();
            day23.DataOfDay.Text = "23";
            Day day24 = new Day();
            day24.DataOfDay.Text = "24";
            Day day25 = new Day();
            day25.DataOfDay.Text = "25";
            Day day26 = new Day();
            day26.DataOfDay.Text = "26";
            Day day27 = new Day();
            day27.DataOfDay.Text = "27";
            Day day28 = new Day();
            day28.DataOfDay.Text = "28";
            Day day29 = new Day();
            day29.DataOfDay.Text = "29";
            Day day30 = new Day();
            day30.DataOfDay.Text = "30";
            Day day31 = new Day();
            day31.DataOfDay.Text = "31";
            List<Day> list = new List<Day>() { day1, day2, day3, day4, day5, day6, day7, day8, day9, day10, day11, day12, day13, day14, day15, day16, day17, day18, day19, day20, day21, day22, day23, day24, day25, day26, day27, day28, day29, day30, day31 };
            
            int i;
            string ChoosedMonth = DataSelected[0].ToString() + DataSelected[1] + DataSelected[2];
            int year = Convert.ToInt32(DataSelected[DataSelected.Length - 2].ToString() + DataSelected[DataSelected.Length - 1]);
            if (ChoosedMonth == "Апр" || ChoosedMonth == "Июн" || ChoosedMonth == "Сен" || ChoosedMonth == "Ноя")
            {
                i = 30;
            }
            else if (ChoosedMonth == "Янв" || ChoosedMonth == "Мар" || ChoosedMonth == "Май" ||
                ChoosedMonth == "Июл" || ChoosedMonth == "Авг" ||
                ChoosedMonth == "Окт" || ChoosedMonth == "Дек")
            {
                i = 31;
            }
            else
            {
                if (year % 4 == 0)
                {
                    i = 29;
                }
                else
                {
                    i = 28;
                }
            }
            for (int j = 0; j < i; j++)
            {
                (Application.Current.MainWindow as MainWindow).CalendarDays.Children.Add(list[j]);
            }
        }
    }
}
