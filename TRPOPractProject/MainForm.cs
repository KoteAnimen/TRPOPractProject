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
                tbx_MMTemperature.Text = "Мин. - " + ParametrsBox.minTemperarure.ToString() + ", Макс. - " + ParametrsBox.maxTemperarure.ToString() + ", Сред. - " + ParametrsBox.AvgTemperarure().ToString();
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
                Diagram graph = new Diagram(ParametrsBox.countDays, 50);
                try
                {
                    GraphBox.Image = graph.DrawDiagram();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка");
                }
                
            }
            else
            {
                MessageBox.Show("Невозможно построить график, так как параметры не были установлены!", "Ошибка");
                return;
            }
        }

        private void Btn_AboutUs_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ИСП-41, Филяк. \nЗадание: Построение графика для получаемых извне данных: график должен строиться постоянно, должны выводиться текущие показания, средний и прогноз (источник текущих показаний заменить ГСЧ, строящим в заданном интервале изменений за последние полгода ", "О программе");
        }
    }

    public static class ParametrsBox
    {
        public static string monthName;
        public static int countDays = 1;
        public static int minTemperarure;
        public static int maxTemperarure;
        public static List<int> temperatures;

        public static int AvgTemperarure()
        {
            int summ = 0;
            if(temperatures != null)
            {
                for (int i = 0; i < temperatures.Count; i++)
                {
                    summ += temperatures[i];
                }
            }            
            return summ / countDays;
        }
    }
}
