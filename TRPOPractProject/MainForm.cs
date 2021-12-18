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
    public partial class MainForm : Form
    {               

        public MainForm()
        {
            InitializeComponent();
        }

        private void Tbtn_SelectMonth_Click(object sender, EventArgs e)
        {
            CalendarForm calendar = new CalendarForm();
            calendar.ShowDialog();
            tbx_DaysInMonth.Text = ParametrsBox.countDays.ToString();
            tbx_MonthName.Text = ParametrsBox.monthName;
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Tbtn_SetParams_Click(object sender, EventArgs e)
        {
            if(ParametrsBox.monthName != "" && ParametrsBox.countDays != 1)
            {
                ParamsForm parametrs = new ParamsForm();
                parametrs.ShowDialog();
            }
            else
            {
                MessageBox.Show("Не установлен месяц!", "Ошибка");
                return;
            }
                     
        }

        private void Tbtn_BuildGraph_Click(object sender, EventArgs e)
        {
            if (ParametrsBox.monthName != "" && ParametrsBox.countDays != 1)
            {

            }
            else
            {
                MessageBox.Show("Невозможно построить график, так как параметры не были установлены!", "Ошибка");
                return;
            }
        }
    }

    public static class ParametrsBox
    {
        public static string monthName;
        public static int countDays = 1;
        public static int minTemperarure;
        public static int maxTemperarure;
        public static int[] temperatures;

        public static int AvgTemperarure()
        {
            int summ = 0;
            for (int i = 0; i < temperatures.Length; i++)
            {
                summ += temperatures[i];
            }
            return summ / countDays;
        }
    }
}
