
namespace TRPOPractProject
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Btn_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Btn_AboutUs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Tbtn_SelectMonth = new System.Windows.Forms.ToolStripButton();
            this.Tbtn_SetParams = new System.Windows.Forms.ToolStripButton();
            this.Tbtn_BuildGraph = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GraphBox = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbx_MonthName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbx_MMTemperature = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbx_DaysInMonth = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GraphBox)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(883, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Btn_Exit});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(136, 26);
            this.Btn_Exit.Text = "Выход";
            this.Btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Btn_AboutUs});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // Btn_AboutUs
            // 
            this.Btn_AboutUs.Name = "Btn_AboutUs";
            this.Btn_AboutUs.Size = new System.Drawing.Size(187, 26);
            this.Btn_AboutUs.Text = "О программе";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tbtn_SelectMonth,
            this.Tbtn_SetParams,
            this.Tbtn_BuildGraph});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(883, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Tbtn_SelectMonth
            // 
            this.Tbtn_SelectMonth.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Tbtn_SelectMonth.Image = global::TRPOPractProject.Properties.Resources.calendar;
            this.Tbtn_SelectMonth.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tbtn_SelectMonth.Name = "Tbtn_SelectMonth";
            this.Tbtn_SelectMonth.Size = new System.Drawing.Size(29, 24);
            this.Tbtn_SelectMonth.Text = "toolStripButton1";
            this.Tbtn_SelectMonth.ToolTipText = "Выбрать месяц";
            this.Tbtn_SelectMonth.Click += new System.EventHandler(this.Tbtn_SelectMonth_Click);
            // 
            // Tbtn_SetParams
            // 
            this.Tbtn_SetParams.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Tbtn_SetParams.Image = global::TRPOPractProject.Properties.Resources._110229_keyboard_512x512;
            this.Tbtn_SetParams.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tbtn_SetParams.Name = "Tbtn_SetParams";
            this.Tbtn_SetParams.Size = new System.Drawing.Size(29, 24);
            this.Tbtn_SetParams.Text = "toolStripButton2";
            this.Tbtn_SetParams.ToolTipText = "Ввод данных";
            this.Tbtn_SetParams.Click += new System.EventHandler(this.Tbtn_SetParams_Click);
            // 
            // Tbtn_BuildGraph
            // 
            this.Tbtn_BuildGraph.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Tbtn_BuildGraph.Image = global::TRPOPractProject.Properties.Resources._294_2949560_svg_icon_free_download_clipart;
            this.Tbtn_BuildGraph.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tbtn_BuildGraph.Name = "Tbtn_BuildGraph";
            this.Tbtn_BuildGraph.Size = new System.Drawing.Size(29, 24);
            this.Tbtn_BuildGraph.Text = "toolStripButton3";
            this.Tbtn_BuildGraph.ToolTipText = "Построить график";
            this.Tbtn_BuildGraph.Click += new System.EventHandler(this.Tbtn_BuildGraph_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.GraphBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(13, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(858, 485);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "График";
            // 
            // GraphBox
            // 
            this.GraphBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GraphBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.GraphBox.Location = new System.Drawing.Point(7, 34);
            this.GraphBox.Name = "GraphBox";
            this.GraphBox.Size = new System.Drawing.Size(845, 445);
            this.GraphBox.TabIndex = 0;
            this.GraphBox.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tbx_MonthName);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tbx_MMTemperature);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tbx_DaysInMonth);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(13, 550);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(858, 109);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Показатели";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(591, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Месяц:";
            // 
            // tbx_MonthName
            // 
            this.tbx_MonthName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbx_MonthName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbx_MonthName.Location = new System.Drawing.Point(596, 69);
            this.tbx_MonthName.Name = "tbx_MonthName";
            this.tbx_MonthName.ReadOnly = true;
            this.tbx_MonthName.Size = new System.Drawing.Size(256, 34);
            this.tbx_MonthName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(332, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Мин.,  макс. и сред. температуры:";
            // 
            // tbx_MMTemperature
            // 
            this.tbx_MMTemperature.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tbx_MMTemperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbx_MMTemperature.Location = new System.Drawing.Point(210, 69);
            this.tbx_MMTemperature.Name = "tbx_MMTemperature";
            this.tbx_MMTemperature.ReadOnly = true;
            this.tbx_MMTemperature.Size = new System.Drawing.Size(335, 34);
            this.tbx_MMTemperature.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Дней в месяце:";
            // 
            // tbx_DaysInMonth
            // 
            this.tbx_DaysInMonth.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbx_DaysInMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbx_DaysInMonth.Location = new System.Drawing.Point(7, 69);
            this.tbx_DaysInMonth.Name = "tbx_DaysInMonth";
            this.tbx_DaysInMonth.ReadOnly = true;
            this.tbx_DaysInMonth.Size = new System.Drawing.Size(153, 34);
            this.tbx_DaysInMonth.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 671);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "График температур";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GraphBox)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Btn_Exit;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Btn_AboutUs;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Tbtn_SelectMonth;
        private System.Windows.Forms.ToolStripButton Tbtn_SetParams;
        private System.Windows.Forms.ToolStripButton Tbtn_BuildGraph;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox GraphBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbx_MonthName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbx_MMTemperature;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbx_DaysInMonth;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

