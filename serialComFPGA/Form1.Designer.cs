namespace serialComFPGA
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.textV = new System.Windows.Forms.TextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.receivedText = new System.Windows.Forms.TextBox();
            this.initButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.textX = new System.Windows.Forms.TextBox();
            this.textY = new System.Windows.Forms.TextBox();
            this.textZ = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.Second = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ButtonRight = new System.Windows.Forms.Button();
            this.ButtonLeft = new System.Windows.Forms.Button();
            this.TopRight = new System.Windows.Forms.Button();
            this.TopLeft = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Demo = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 115200;
            this.serialPort1.PortName = "COM3";
            this.serialPort1.ReadTimeout = 2;
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // textV
            // 
            this.textV.Location = new System.Drawing.Point(177, 53);
            this.textV.Name = "textV";
            this.textV.Size = new System.Drawing.Size(94, 20);
            this.textV.TabIndex = 0;
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(19, 72);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(128, 23);
            this.sendButton.TabIndex = 1;
            this.sendButton.Text = "send";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // receivedText
            // 
            this.receivedText.Location = new System.Drawing.Point(3, 43);
            this.receivedText.Multiline = true;
            this.receivedText.Name = "receivedText";
            this.receivedText.Size = new System.Drawing.Size(10, 114);
            this.receivedText.TabIndex = 2;
            this.receivedText.Visible = false;
            // 
            // initButton
            // 
            this.initButton.BackColor = System.Drawing.SystemColors.Control;
            this.initButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.initButton.ForeColor = System.Drawing.Color.Black;
            this.initButton.Location = new System.Drawing.Point(19, 43);
            this.initButton.Name = "initButton";
            this.initButton.Size = new System.Drawing.Size(128, 25);
            this.initButton.TabIndex = 3;
            this.initButton.Text = "Initialize";
            this.initButton.UseVisualStyleBackColor = false;
            this.initButton.Click += new System.EventHandler(this.initButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(19, 101);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(128, 23);
            this.closeButton.TabIndex = 4;
            this.closeButton.Text = "close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // textX
            // 
            this.textX.Location = new System.Drawing.Point(29, 51);
            this.textX.Name = "textX";
            this.textX.Size = new System.Drawing.Size(63, 20);
            this.textX.TabIndex = 5;
            // 
            // textY
            // 
            this.textY.Location = new System.Drawing.Point(29, 87);
            this.textY.Name = "textY";
            this.textY.Size = new System.Drawing.Size(63, 20);
            this.textY.TabIndex = 6;
            // 
            // textZ
            // 
            this.textZ.Location = new System.Drawing.Point(29, 121);
            this.textZ.Name = "textZ";
            this.textZ.Size = new System.Drawing.Size(63, 20);
            this.textZ.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "x";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "z";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(162, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Velocity";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(165, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 20);
            this.button1.TabIndex = 13;
            this.button1.Text = "plot";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Second
            // 
            this.Second.AutoSize = true;
            this.Second.BackColor = System.Drawing.SystemColors.Window;
            this.Second.Location = new System.Drawing.Point(702, 507);
            this.Second.Name = "Second";
            this.Second.Size = new System.Drawing.Size(44, 13);
            this.Second.TabIndex = 14;
            this.Second.Text = "Second";
            this.Second.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(12, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Round";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Position";
            this.label5.Click += new System.EventHandler(this.label5_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.textY);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textX);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textZ);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textV);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 169);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Motion";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label9.Location = new System.Drawing.Point(92, 128);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "-280<x<280 mm";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.label8.Location = new System.Drawing.Point(92, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "-200<x<200 mm";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(177, 108);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(104, 17);
            this.radioButton2.TabIndex = 21;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Relative Position";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(177, 79);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(106, 17);
            this.radioButton1.TabIndex = 20;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Absolute Position";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.closeButton);
            this.groupBox2.Controls.Add(this.sendButton);
            this.groupBox2.Controls.Add(this.initButton);
            this.groupBox2.Controls.Add(this.receivedText);
            this.groupBox2.Location = new System.Drawing.Point(594, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(172, 169);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "System Control";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(19, 133);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 24);
            this.button2.TabIndex = 6;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Communication Monitor";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // chart
            // 
            chartArea3.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart.Legends.Add(legend3);
            this.chart.Location = new System.Drawing.Point(12, 204);
            this.chart.Name = "chart";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Motor_X";
            this.chart.Series.Add(series3);
            this.chart.Size = new System.Drawing.Size(734, 300);
            this.chart.TabIndex = 19;
            this.chart.Text = "chart";
            this.chart.Click += new System.EventHandler(this.chart1_Click_1);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ButtonRight);
            this.groupBox3.Controls.Add(this.ButtonLeft);
            this.groupBox3.Controls.Add(this.TopRight);
            this.groupBox3.Controls.Add(this.TopLeft);
            this.groupBox3.Location = new System.Drawing.Point(319, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(180, 95);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Maximum Point";
            // 
            // ButtonRight
            // 
            this.ButtonRight.Location = new System.Drawing.Point(94, 56);
            this.ButtonRight.Name = "ButtonRight";
            this.ButtonRight.Size = new System.Drawing.Size(75, 23);
            this.ButtonRight.TabIndex = 3;
            this.ButtonRight.Text = "Button Right";
            this.ButtonRight.UseVisualStyleBackColor = true;
            this.ButtonRight.Click += new System.EventHandler(this.ButtonRight_Click);
            // 
            // ButtonLeft
            // 
            this.ButtonLeft.Location = new System.Drawing.Point(3, 56);
            this.ButtonLeft.Name = "ButtonLeft";
            this.ButtonLeft.Size = new System.Drawing.Size(75, 23);
            this.ButtonLeft.TabIndex = 2;
            this.ButtonLeft.Text = "Button Left";
            this.ButtonLeft.UseVisualStyleBackColor = true;
            this.ButtonLeft.Click += new System.EventHandler(this.ButtonLeft_Click);
            // 
            // TopRight
            // 
            this.TopRight.Location = new System.Drawing.Point(94, 16);
            this.TopRight.Name = "TopRight";
            this.TopRight.Size = new System.Drawing.Size(75, 23);
            this.TopRight.TabIndex = 1;
            this.TopRight.Text = "Top Right";
            this.TopRight.UseVisualStyleBackColor = true;
            this.TopRight.Click += new System.EventHandler(this.TopRight_Click);
            // 
            // TopLeft
            // 
            this.TopLeft.Location = new System.Drawing.Point(3, 16);
            this.TopLeft.Name = "TopLeft";
            this.TopLeft.Size = new System.Drawing.Size(75, 23);
            this.TopLeft.TabIndex = 0;
            this.TopLeft.Text = "Top Left";
            this.TopLeft.UseVisualStyleBackColor = true;
            this.TopLeft.Click += new System.EventHandler(this.TopLeft_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1219, 330);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 22);
            this.button3.TabIndex = 25;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Demo
            // 
            this.Demo.Location = new System.Drawing.Point(319, 120);
            this.Demo.Name = "Demo";
            this.Demo.Size = new System.Drawing.Size(103, 23);
            this.Demo.TabIndex = 26;
            this.Demo.Text = "Demo";
            this.Demo.UseVisualStyleBackColor = true;
            this.Demo.Click += new System.EventHandler(this.Demo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 566);
            this.Controls.Add(this.Demo);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Second);
            this.Name = "Form1";
            this.Text = "3 Axis robot API";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TextBox textV;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.TextBox receivedText;
        private System.Windows.Forms.Button initButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.TextBox textX;
        private System.Windows.Forms.TextBox textY;
        private System.Windows.Forms.TextBox textZ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Second;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button ButtonRight;
        private System.Windows.Forms.Button ButtonLeft;
        private System.Windows.Forms.Button TopRight;
        private System.Windows.Forms.Button TopLeft;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Demo;
    }
}

