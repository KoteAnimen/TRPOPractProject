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
    public partial class ParamsForm : Form
    {
        List<int> tmpr = new List<int>();
        Random rnd = new Random();
        public ParamsForm()
        {
            InitializeComponent();
            SetLimits();
        }

        void SetLimits()
        {
            switch (ValuesBox.graphType)
            {
                case GraphType.TEMPERATURE:
                    SetMinMax(-25, 25);
                    break;
                case GraphType.PRESSURE:
                    SetMinMax(0, 1000);
                    break;
                case GraphType.HUMID:
                    SetMinMax(0, 100);
                    break;
            }
        }

        void SetMinMax(int min, int max)
        {
            nud_Min.Minimum = min;
            nud_Min.Maximum = max;
            nud_Max.Minimum = min;
            nud_Max.Maximum = max;
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {                 
            this.Close();
        }

        private void Btn_SetParams_Click(object sender, EventArgs e)
        {
            if(listParams.Items.Count != 0)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Параметры не были установлены!", "Ошибка");
                return;
            }
        }

        private void Btn_Generate_Click(object sender, EventArgs e)
        {
            tmpr.Clear();
            listParams.Items.Clear();
            ValuesBox.MinValue = (int)nud_Min.Value;
            ValuesBox.MaxValue = (int)nud_Max.Value;
            if(ValuesBox.MinValue <= ValuesBox.MaxValue)
            {
                for (int i = 0; i < ValuesBox.сountDays; i++)
                {
                    int tmp = rnd.Next(ValuesBox.MinValue, ValuesBox.MaxValue);
                    tmpr.Add(tmp);
                    listParams.Items.Add(tmp);
                }
                ValuesBox.ListValues = tmpr;
            }
            else
            {
                MessageBox.Show("Максимальная температура не может быть меньше минимальной!", "Ошибка");
                return;
            }
            
        }        
    }
}
