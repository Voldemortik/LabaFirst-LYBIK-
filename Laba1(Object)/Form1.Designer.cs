namespace Laba1_Object_
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chSimulation = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.bUp = new System.Windows.Forms.Button();
            this.dDown = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.bStart = new System.Windows.Forms.Button();
            this.bStop = new System.Windows.Forms.Button();
            this.bSpeedUp = new System.Windows.Forms.Button();
            this.tmSimulation = new System.Windows.Forms.Timer(this.components);
            this.lblInput = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.chSimulation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // chSimulation
            // 
            chartArea1.Name = "ChartArea1";
            this.chSimulation.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chSimulation.Legends.Add(legend1);
            this.chSimulation.Location = new System.Drawing.Point(123, 226);
            this.chSimulation.Margin = new System.Windows.Forms.Padding(4);
            this.chSimulation.Name = "chSimulation";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chSimulation.Series.Add(series1);
            this.chSimulation.Size = new System.Drawing.Size(881, 388);
            this.chSimulation.TabIndex = 1;
            this.chSimulation.Text = "chart1";
            this.chSimulation.Click += new System.EventHandler(this.ChSimulation_Click);
            // 
            // bUp
            // 
            this.bUp.Location = new System.Drawing.Point(135, 48);
            this.bUp.Margin = new System.Windows.Forms.Padding(4);
            this.bUp.Name = "bUp";
            this.bUp.Size = new System.Drawing.Size(100, 28);
            this.bUp.TabIndex = 2;
            this.bUp.Text = "+";
            this.bUp.UseVisualStyleBackColor = true;
            this.bUp.Click += new System.EventHandler(this.bUp_Click);
            // 
            // dDown
            // 
            this.dDown.Location = new System.Drawing.Point(243, 48);
            this.dDown.Margin = new System.Windows.Forms.Padding(4);
            this.dDown.Name = "dDown";
            this.dDown.Size = new System.Drawing.Size(100, 28);
            this.dDown.TabIndex = 3;
            this.dDown.Text = "-";
            this.dDown.UseVisualStyleBackColor = true;
            this.dDown.Click += new System.EventHandler(this.dDown_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(729, 127);
            this.lblResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(48, 17);
            this.lblResult.TabIndex = 4;
            this.lblResult.Text = "Result";
            // 
            // bStart
            // 
            this.bStart.Location = new System.Drawing.Point(15, 15);
            this.bStart.Margin = new System.Windows.Forms.Padding(4);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(100, 28);
            this.bStart.TabIndex = 5;
            this.bStart.Text = "Start";
            this.bStart.UseVisualStyleBackColor = true;
            this.bStart.Click += new System.EventHandler(this.bStart_Click);
            // 
            // bStop
            // 
            this.bStop.Location = new System.Drawing.Point(15, 50);
            this.bStop.Margin = new System.Windows.Forms.Padding(4);
            this.bStop.Name = "bStop";
            this.bStop.Size = new System.Drawing.Size(100, 28);
            this.bStop.TabIndex = 6;
            this.bStop.Text = "Stop";
            this.bStop.UseVisualStyleBackColor = true;
            this.bStop.Click += new System.EventHandler(this.bStop_Click);
            // 
            // bSpeedUp
            // 
            this.bSpeedUp.Location = new System.Drawing.Point(15, 86);
            this.bSpeedUp.Margin = new System.Windows.Forms.Padding(4);
            this.bSpeedUp.Name = "bSpeedUp";
            this.bSpeedUp.Size = new System.Drawing.Size(100, 28);
            this.bSpeedUp.TabIndex = 7;
            this.bSpeedUp.Text = "x10";
            this.bSpeedUp.UseVisualStyleBackColor = true;
            this.bSpeedUp.Click += new System.EventHandler(this.bSpeedUp_Click);
            // 
            // tmSimulation
            // 
            this.tmSimulation.Tick += new System.EventHandler(this.tmSimulation_Tick);
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(291, 127);
            this.lblInput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(39, 17);
            this.lblInput.TabIndex = 8;
            this.lblInput.Text = "Input";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Laba1_Object_.Properties.Resources.System;
            this.pictureBox1.Location = new System.Drawing.Point(123, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(881, 219);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 629);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.bSpeedUp);
            this.Controls.Add(this.bStop);
            this.Controls.Add(this.bStart);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.dDown);
            this.Controls.Add(this.bUp);
            this.Controls.Add(this.chSimulation);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chSimulation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chSimulation;
        private System.Windows.Forms.Button bUp;
        private System.Windows.Forms.Button dDown;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button bStart;
        private System.Windows.Forms.Button bStop;
        private System.Windows.Forms.Button bSpeedUp;
        private System.Windows.Forms.Timer tmSimulation;
        private System.Windows.Forms.Label lblInput;
    }
}

