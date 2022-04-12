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
    public enum GraphType
    {
        TEMPERATURE,
        PRESSURE,
        HUMID
    };

    public partial class MainForm : Form
    {        

        public MainForm()
        {
            InitializeComponent();
            ValuesBox.graphType = GraphType.TEMPERATURE;
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
            switch (ValuesBox.graphType)
            {
                case GraphType.TEMPERATURE:                    
                    Diagram graphT = new Diagram(ValuesBox.сountDays, 25, Indent.ONES, Color.Green, 5, 20, "Дни", "t", ValuesBox.ListValues, false);
                    try
                    {
                        GraphBox.Image = graphT.DrawDiagram();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка");
                    }
                    break;
                case GraphType.PRESSURE:
                    Diagram graphP = new Diagram(ValuesBox.сountDays, 10, Indent.HUNDREDS, Color.Red, 20, 100, "Дни", "мм рт. ст", ValuesBox.ListValues, true);
                    try
                    {
                        GraphBox.Image = graphP.DrawDiagram();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка");
                    }
                    break;
                case GraphType.HUMID:
                    Diagram graphH = new Diagram(ValuesBox.сountDays, 10, Indent.TENS, Color.Blue, 20, 100, "Дни", "Влажность %", ValuesBox.ListValues, true);
                    try
                    {
                        GraphBox.Image = graphH.DrawDiagram();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка");
                    }
                    break;                    
            }            
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
            ValuesBox.graphType = GraphType.TEMPERATURE;
        }

        private void rb_PressureGraph_CheckedChanged(object sender, EventArgs e)
        {
            ValuesBox.graphType = GraphType.PRESSURE;
        }

        private void rb_HumidGraph_CheckedChanged(object sender, EventArgs e)
        {
            ValuesBox.graphType = GraphType.HUMID;
        }
    }    

    public static class ValuesBox
    {
        public static GraphType graphType;

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
