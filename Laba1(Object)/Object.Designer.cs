namespace Laba1_Object_
{
    partial class Object
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Object));
            this.bStop = new System.Windows.Forms.Button();
            this.bStart = new System.Windows.Forms.Button();
            this.chSimulation1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.lblInput1 = new System.Windows.Forms.Label();
            this.lblResult1 = new System.Windows.Forms.Label();
            this.tmSimulation = new System.Windows.Forms.Timer(this.components);
            this.bReset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bSpeedUp = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.lblResult2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chSimulation1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // bStop
            // 
            this.bStop.Location = new System.Drawing.Point(12, 50);
            this.bStop.Margin = new System.Windows.Forms.Padding(4);
            this.bStop.Name = "bStop";
            this.bStop.Size = new System.Drawing.Size(100, 28);
            this.bStop.TabIndex = 15;
            this.bStop.Text = "Stop";
            this.bStop.UseVisualStyleBackColor = true;
            this.bStop.Click += new System.EventHandler(this.bStop_Click);
            // 
            // bStart
            // 
            this.bStart.Location = new System.Drawing.Point(12, 13);
            this.bStart.Margin = new System.Windows.Forms.Padding(4);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(100, 28);
            this.bStart.TabIndex = 14;
            this.bStart.Text = "Start";
            this.bStart.UseVisualStyleBackColor = true;
            this.bStart.Click += new System.EventHandler(this.bStart_Click);
            // 
            // chSimulation1
            // 
            chartArea1.Name = "ChartArea1";
            this.chSimulation1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chSimulation1.Legends.Add(legend1);
            this.chSimulation1.Location = new System.Drawing.Point(109, 266);
            this.chSimulation1.Margin = new System.Windows.Forms.Padding(4);
            this.chSimulation1.Name = "chSimulation1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "WaterLvL";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Conc";
            this.chSimulation1.Series.Add(series1);
            this.chSimulation1.Series.Add(series2);
            this.chSimulation1.Size = new System.Drawing.Size(942, 377);
            this.chSimulation1.TabIndex = 10;
            this.chSimulation1.Text = "chart1";
           // this.chSimulation1.Click += new System.EventHandler(this.ChSimulation_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(452, 18);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 28);
            this.button1.TabIndex = 19;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(395, 15);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(49, 28);
            this.button2.TabIndex = 20;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(617, 151);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(49, 28);
            this.button3.TabIndex = 22;
            this.button3.Text = "-";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(710, 151);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(61, 28);
            this.button4.TabIndex = 21;
            this.button4.Text = "+";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // lblInput1
            // 
            this.lblInput1.AutoSize = true;
            this.lblInput1.Location = new System.Drawing.Point(554, 97);
            this.lblInput1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInput1.Name = "lblInput1";
            this.lblInput1.Size = new System.Drawing.Size(39, 17);
            this.lblInput1.TabIndex = 26;
            this.lblInput1.Text = "Input";
           // this.lblInput1.Click += new System.EventHandler(this.LblInput1_Click);
            // 
            // lblResult1
            // 
            this.lblResult1.AutoSize = true;
            this.lblResult1.Location = new System.Drawing.Point(486, 201);
            this.lblResult1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResult1.Name = "lblResult1";
            this.lblResult1.Size = new System.Drawing.Size(48, 17);
            this.lblResult1.TabIndex = 25;
            this.lblResult1.Text = "Result";
          //  this.lblResult1.Click += new System.EventHandler(this.LblResult_Click);
            // 
            // tmSimulation
            // 
            this.tmSimulation.Tick += new System.EventHandler(this.tmSimulation_Tick);
            // 
            // bReset
            // 
            this.bReset.Location = new System.Drawing.Point(12, 122);
            this.bReset.Margin = new System.Windows.Forms.Padding(4);
            this.bReset.Name = "bReset";
            this.bReset.Size = new System.Drawing.Size(100, 28);
            this.bReset.TabIndex = 29;
            this.bReset.Text = "Reset";
            this.bReset.UseVisualStyleBackColor = true;
            this.bReset.Click += new System.EventHandler(this.bReset_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(716, 216);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 30;
            this.label1.Text = "Xout";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(447, -3);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 17);
            this.label2.TabIndex = 31;
            this.label2.Text = "Xin";
            // 
            // bSpeedUp
            // 
            this.bSpeedUp.Location = new System.Drawing.Point(12, 86);
            this.bSpeedUp.Margin = new System.Windows.Forms.Padding(4);
            this.bSpeedUp.Name = "bSpeedUp";
            this.bSpeedUp.Size = new System.Drawing.Size(100, 28);
            this.bSpeedUp.TabIndex = 16;
            this.bSpeedUp.Text = "x10";
            this.bSpeedUp.UseVisualStyleBackColor = true;
            this.bSpeedUp.Click += new System.EventHandler(this.bSpeedUp_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(109, -1);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(942, 260);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 35;
            this.pictureBox3.TabStop = false;
           // this.pictureBox3.Click += new System.EventHandler(this.PictureBox3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(674, -3);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 17);
            this.label4.TabIndex = 36;
            this.label4.Text = "Xin";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(710, 13);
            this.button7.Margin = new System.Windows.Forms.Padding(4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(61, 28);
            this.button7.TabIndex = 37;
            this.button7.Text = "+";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(617, 13);
            this.button8.Margin = new System.Windows.Forms.Padding(4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(49, 28);
            this.button8.TabIndex = 38;
            this.button8.Text = "-";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.Button8_Click);
            // 
            // lblResult2
            // 
            this.lblResult2.AutoSize = true;
            this.lblResult2.Location = new System.Drawing.Point(580, 201);
            this.lblResult2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResult2.Name = "lblResult2";
            this.lblResult2.Size = new System.Drawing.Size(48, 17);
            this.lblResult2.TabIndex = 40;
            this.lblResult2.Text = "Result";
           // this.lblResult2.Click += new System.EventHandler(this.LblResult2_Click);
            // 
            // Object
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1514, 659);
            this.Controls.Add(this.lblResult2);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bReset);
            this.Controls.Add(this.lblInput1);
            this.Controls.Add(this.lblResult1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bSpeedUp);
            this.Controls.Add(this.bStop);
            this.Controls.Add(this.bStart);
            this.Controls.Add(this.chSimulation1);
            this.Controls.Add(this.pictureBox3);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Object";
            this.Text = "Object";
            ((System.ComponentModel.ISupportInitialize)(this.chSimulation1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bStop;
        private System.Windows.Forms.Button bStart;
        private System.Windows.Forms.DataVisualization.Charting.Chart chSimulation1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label lblInput1;
        private System.Windows.Forms.Label lblResult1;
        private System.Windows.Forms.Timer tmSimulation;
        private System.Windows.Forms.Button bReset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bSpeedUp;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label lblResult2;
    }
}