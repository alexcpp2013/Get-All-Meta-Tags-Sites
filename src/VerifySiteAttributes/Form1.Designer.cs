namespace VerifySiteAttributes
{
    partial class Form1
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
            this.btNUnit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSites = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rtbReport = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bClose = new System.Windows.Forms.Button();
            this.ofdSites = new System.Windows.Forms.OpenFileDialog();
            this.ofdAttributes = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btNUnit);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbSites);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(791, 104);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Файлы с данными";
            // 
            // btNUnit
            // 
            this.btNUnit.Location = new System.Drawing.Point(710, 57);
            this.btNUnit.Name = "btNUnit";
            this.btNUnit.Size = new System.Drawing.Size(75, 23);
            this.btNUnit.TabIndex = 17;
            this.btNUnit.Text = "Загрузить";
            this.btNUnit.UseVisualStyleBackColor = true;
            this.btNUnit.Click += new System.EventHandler(this.btNUnit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Введите имя файла с сайтами";
            // 
            // tbSites
            // 
            this.tbSites.Location = new System.Drawing.Point(15, 60);
            this.tbSites.Name = "tbSites";
            this.tbSites.ReadOnly = true;
            this.tbSites.Size = new System.Drawing.Size(644, 20);
            this.tbSites.TabIndex = 18;
            this.tbSites.Text = "sites.xml";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Controls.Add(this.panel3);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 104);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(791, 556);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Обработка данных";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(630, 76);
            this.progressBar1.MarqueeAnimationSpeed = 25;
            this.progressBar1.Maximum = 25;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(155, 23);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 4;
            this.progressBar1.UseWaitCursor = true;
            this.progressBar1.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.rtbReport);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(3, 106);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(785, 447);
            this.panel3.TabIndex = 3;
            // 
            // rtbReport
            // 
            this.rtbReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbReport.Location = new System.Drawing.Point(0, 0);
            this.rtbReport.Name = "rtbReport";
            this.rtbReport.ReadOnly = true;
            this.rtbReport.Size = new System.Drawing.Size(781, 443);
            this.rtbReport.TabIndex = 0;
            this.rtbReport.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Отчет";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Старт";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.bClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 675);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(791, 30);
            this.panel1.TabIndex = 2;
            // 
            // bClose
            // 
            this.bClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.bClose.Location = new System.Drawing.Point(712, 0);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(75, 26);
            this.bClose.TabIndex = 0;
            this.bClose.Text = "Выход";
            this.bClose.UseVisualStyleBackColor = true;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // ofdSites
            // 
            this.ofdSites.FileName = "openFileDialog1";
            this.ofdSites.Filter = "xml файл (*.xml) | *.xml";
            // 
            // ofdAttributes
            // 
            this.ofdAttributes.FileName = "openFileDialog1";
            this.ofdAttributes.Filter = "xml файл (*.xml) | *.xml";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bClose;
            this.ClientSize = new System.Drawing.Size(791, 705);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поиск Мэта-Тегов Сайтов";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bClose;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btNUnit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSites;
        private System.Windows.Forms.OpenFileDialog ofdSites;
        private System.Windows.Forms.OpenFileDialog ofdAttributes;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RichTextBox rtbReport;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

