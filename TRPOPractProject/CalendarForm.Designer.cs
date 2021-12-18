
namespace TRPOPractProject
{
    partial class CalendarForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SelectDate = new System.Windows.Forms.DateTimePicker();
            this.lbl_SelectedMonth = new System.Windows.Forms.Label();
            this.Btn_Accept = new System.Windows.Forms.Button();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_CountDays = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SelectDate
            // 
            this.SelectDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.SelectDate.Location = new System.Drawing.Point(3, 3);
            this.SelectDate.Name = "SelectDate";
            this.SelectDate.Size = new System.Drawing.Size(397, 29);
            this.SelectDate.TabIndex = 0;
            this.SelectDate.ValueChanged += new System.EventHandler(this.SelectDate_ValueChanged);
            // 
            // lbl_SelectedMonth
            // 
            this.lbl_SelectedMonth.AutoSize = true;
            this.lbl_SelectedMonth.Location = new System.Drawing.Point(5, 38);
            this.lbl_SelectedMonth.Name = "lbl_SelectedMonth";
            this.lbl_SelectedMonth.Size = new System.Drawing.Size(178, 24);
            this.lbl_SelectedMonth.TabIndex = 1;
            this.lbl_SelectedMonth.Text = "Выбранный месяц:";
            this.lbl_SelectedMonth.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Btn_Accept
            // 
            this.Btn_Accept.Location = new System.Drawing.Point(12, 117);
            this.Btn_Accept.Name = "Btn_Accept";
            this.Btn_Accept.Size = new System.Drawing.Size(183, 43);
            this.Btn_Accept.TabIndex = 3;
            this.Btn_Accept.Text = "Принять";
            this.Btn_Accept.UseVisualStyleBackColor = true;
            this.Btn_Accept.Click += new System.EventHandler(this.Btn_Accept_Click);
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Location = new System.Drawing.Point(238, 117);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(183, 43);
            this.Btn_Cancel.TabIndex = 4;
            this.Btn_Cancel.Text = "Отмена";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.lbl_CountDays);
            this.panel1.Controls.Add(this.SelectDate);
            this.panel1.Controls.Add(this.lbl_SelectedMonth);
            this.panel1.Location = new System.Drawing.Point(12, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(409, 109);
            this.panel1.TabIndex = 5;
            // 
            // lbl_CountDays
            // 
            this.lbl_CountDays.AutoSize = true;
            this.lbl_CountDays.Location = new System.Drawing.Point(5, 76);
            this.lbl_CountDays.Name = "lbl_CountDays";
            this.lbl_CountDays.Size = new System.Drawing.Size(172, 24);
            this.lbl_CountDays.TabIndex = 2;
            this.lbl_CountDays.Text = "Количество дней:";
            this.lbl_CountDays.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // CalendarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 172);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.Btn_Accept);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximumSize = new System.Drawing.Size(2000, 2000);
            this.Name = "CalendarForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выбрать месяц";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker SelectDate;
        private System.Windows.Forms.Label lbl_SelectedMonth;
        private System.Windows.Forms.Button Btn_Accept;
        private System.Windows.Forms.Button Btn_Cancel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_CountDays;
    }
}