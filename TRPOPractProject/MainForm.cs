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
    enum GraphType
    {
        TEMPERATURE,
        PRESSURE,
        HUMID
    };

    public partial class MainForm : Form
    {
        GraphType graphType;

        public MainForm()
        {
            InitializeComponent();
            graphType = GraphType.TEMPERATURE;
        }        

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Tbtn_SetParams_Click(object sender, EventArgs e)
        {            
                ParamsForm parametrs = new ParamsForm();
                parametrs.ShowDialog();
                tbx_MMTemperature.Text = ValuesBox.AvgValue().ToString();                    
        }

        private void Tbtn_BuildGraph_Click(object sender, EventArgs e)
        {
            SizeImage size = new SizeImage(2000, 500);
            switch (graphType)
            {
                case GraphType.TEMPERATURE:
                    
                    Diagram graph = new Diagram(ValuesBox.сountDays, 25, Indent.ONES, Color.Green, 5, 20, "Дни", "t", ValuesBox.ListValues, false);
                    try
                    {
                        GraphBox.Image = graph.DrawDiagram();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка");
                    }
                    break;
                case GraphType.PRESSURE:
                    break;
                case GraphType.HUMID:
                    break;
            }
            

            //if ()
            //{


            //}
            //else
            //{
            //    MessageBox.Show("Невозможно построить график, так как параметры не были установлены!", "Ошибка");
            //    return;
            //}
        }

        private void Btn_AboutUs_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ИСП-41, Филяк. \nЗадание: Построение графика для получаемых извне данных: график должен строиться постоянно, должны выводиться текущие показания, средний и прогноз (источник текущих показаний заменить ГСЧ, строящим в заданном интервале изменений за последние полгода ", "О программе");
        }

        private void ShowAllButton_Click(object sender, EventArgs e)
        {

        }

        private void rb_TemperarureGraph_CheckedChanged(object sender, EventArgs e)
        {
            graphType = GraphType.TEMPERATURE;
        }

        private void rb_PressureGraph_CheckedChanged(object sender, EventArgs e)
        {
            graphType = GraphType.PRESSURE;
        }

        private void rb_HumidGraph_CheckedChanged(object sender, EventArgs e)
        {
            graphType = GraphType.HUMID;
        }
    }    

    public static class ValuesBox
    {
        public static int сountDays = 184;
        public static int MinValue { get; set; }
        public static int MaxValue { get; set; }
        public static List<int> ListValues { get; set; }

        public static int AvgValue()
        {
            int summ = 0;
            if (ListValues != null)
            {
                for (int i = 0; i < ListValues.Count; i++)
                {
                    summ += ListValues[i];
                }
            }
            return summ / сountDays;
        }
    }
}
