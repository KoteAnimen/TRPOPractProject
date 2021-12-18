using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRPOPractProject
{
    public partial class CalendarForm : Form
    {
        public CalendarForm()
        {
            InitializeComponent();

            ParametrsBox.monthName = GetMonthName(DateTime.Now.Month);
            ParametrsBox.countDays = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);
            lbl_SelectedMonth.Text = "Выбранный месяц: " + ParametrsBox.monthName;
            lbl_CountDays.Text = "Количество дней: " + ParametrsBox.countDays.ToString();
        }
        
        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            ParametrsBox.monthName = "";
            ParametrsBox.countDays = 1;
            this.Close();
        }

        private void SelectDate_ValueChanged(object sender, EventArgs e)
        {
            ParametrsBox.monthName = GetMonthName(SelectDate.Value.Month);
            ParametrsBox.countDays = DateTime.DaysInMonth(SelectDate.Value.Year, SelectDate.Value.Month);
            lbl_SelectedMonth.Text = "Выбранный месяц: " + ParametrsBox.monthName;
            lbl_CountDays.Text = "Количество дней: " + ParametrsBox.countDays.ToString();
        }
        
        private string GetMonthName(int monthNumber)
        {
            string month = "";
            switch (monthNumber)
            {
                case 1:
                    month = "Январь";
                    break;
                case 2:
                    month = "Февраль";
                    break;
                case 3:
                    month = "Март";
                    break;
                case 4:
                    month = "Апрель";
                    break;
                case 5:
                    month = "Май";
                    break;
                case 6:
                    month = "Июнь";
                    break;
                case 7:
                    month = "Июль";
                    break;
                case 8:
                    month = "Август";
                    break;
                case 9:
                    month = "Сентябрь";
                    break;
                case 10:
                    month = "Октябрь";
                    break;
                case 11:
                    month = "Ноябрь";
                    break;
                case 12:
                    month = "Декабрь";
                    break;
            }

            return month;
        }

        private void Btn_Accept_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
