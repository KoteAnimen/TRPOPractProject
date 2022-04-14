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
    public partial class AllValuesForm : Form
    {
        public AllValuesForm()
        {
            InitializeComponent();
            if(ValuesBox.ListValues != null)
            {
                foreach (int value in ValuesBox.ListValues)
                {
                    listValues.Items.Add(value);
                }
            }            
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
