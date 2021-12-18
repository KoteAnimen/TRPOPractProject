
namespace TRPOPractProject
{
    partial class ParamsForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Btn_Generate = new System.Windows.Forms.Button();
            this.nud_Max = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nud_Min = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listParams = new System.Windows.Forms.ListBox();
            this.Btn_SetParams = new System.Windows.Forms.Button();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Min)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Btn_Generate);
            this.groupBox1.Controls.Add(this.nud_Max);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nud_Min);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(196, 220);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры";
            // 
            // Btn_Generate
            // 
            this.Btn_Generate.Location = new System.Drawing.Point(10, 165);
            this.Btn_Generate.Name = "Btn_Generate";
            this.Btn_Generate.Size = new System.Drawing.Size(180, 44);
            this.Btn_Generate.TabIndex = 4;
            this.Btn_Generate.Text = "Сгенерировать";
            this.Btn_Generate.UseVisualStyleBackColor = true;
            this.Btn_Generate.Click += new System.EventHandler(this.Btn_Generate_Click);
            // 
            // nud_Max
            // 
            this.nud_Max.Location = new System.Drawing.Point(10, 129);
            this.nud_Max.Name = "nud_Max";
            this.nud_Max.Size = new System.Drawing.Size(180, 29);
            this.nud_Max.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Макс. температура";
            // 
            // nud_Min
            // 
            this.nud_Min.Location = new System.Drawing.Point(10, 69);
            this.nud_Min.Name = "nud_Min";
            this.nud_Min.Size = new System.Drawing.Size(180, 29);
            this.nud_Min.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Мин. температура";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listParams);
            this.groupBox2.Location = new System.Drawing.Point(215, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(300, 220);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Сгенерированные параметры";
            // 
            // listParams
            // 
            this.listParams.FormattingEnabled = true;
            this.listParams.ItemHeight = 24;
            this.listParams.Location = new System.Drawing.Point(7, 42);
            this.listParams.Name = "listParams";
            this.listParams.Size = new System.Drawing.Size(287, 172);
            this.listParams.TabIndex = 0;
            // 
            // Btn_SetParams
            // 
            this.Btn_SetParams.Location = new System.Drawing.Point(12, 239);
            this.Btn_SetParams.Name = "Btn_SetParams";
            this.Btn_SetParams.Size = new System.Drawing.Size(233, 49);
            this.Btn_SetParams.TabIndex = 2;
            this.Btn_SetParams.Text = "Установить параметры";
            this.Btn_SetParams.UseVisualStyleBackColor = true;
            this.Btn_SetParams.Click += new System.EventHandler(this.Btn_SetParams_Click);
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Location = new System.Drawing.Point(282, 239);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(233, 49);
            this.Btn_Cancel.TabIndex = 3;
            this.Btn_Cancel.Text = "Отмена";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // ParamsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 299);
            this.ControlBox = false;
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.Btn_SetParams);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ParamsForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Установить параметры";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Min)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Btn_Generate;
        private System.Windows.Forms.NumericUpDown nud_Max;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nud_Min;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listParams;
        private System.Windows.Forms.Button Btn_SetParams;
        private System.Windows.Forms.Button Btn_Cancel;
    }
}