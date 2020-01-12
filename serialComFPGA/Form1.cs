using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace serialComFPGA
{
    public partial class Form1 : Form
    {
        
        private static string[] rxString;
        public byte[] rxData;
        public byte[] temprxData;
        public byte[] txData;
        public int xtext=0;
        public int ytext = 0;
        public int ztext = 0;
        public int vtext=0;
        public decimal[] rxD={0};
        public byte checkSum=0;
        public byte checkSumTx = 0;
        private static string[] input;
        int bytesToRead = 0;
        public byte [] testing;
        public byte[] period;
        public byte[] signal;
        public byte mode=0;
        public int time=0;
        public int speed = 0;
        public int speed1 = 0;
        public int speed2 = 0;
        public int[] plotData;
        public int[] plotData1;
        public int[] plotData2;
        int counter = 0;
        int k = 0;
        bool flagStart = false;
        int indexRemain = 0;
        string x;
        string y;
        string z;
        string v;
       
        bool flag_TL = false;
        bool flag_TR = false;
        bool flag_BL = false;
        bool flag_BR = false;
        bool flag_demo = false;
        public Form1()
        {
            
            
           InitializeComponent();        
           Console.WriteLine("console is working!");
            mode = 0x01;          
            x = textX.Text;
            y = textY.Text;
            z = textZ.Text;
            v = textV.Text;
            ytext = 0;
           // receivedText.Text = x;
           //receivedText.Text = textX.Text;
          
            plotData = new int[1000];
            plotData1 = new int[1000];
            plotData2 = new int[1000];
            Array.Clear(plotData, 0, plotData.Length);
            serialPort1.ReceivedBytesThreshold = 20;
            bytesToRead = serialPort1.ReceivedBytesThreshold;
            txData = new byte[25];
            temprxData = new byte[25];
            input = new string[3];

            period = new byte[4];
            signal = new byte[4];
            rxData = new byte[bytesToRead];
            rxString = new string[bytesToRead];
            rxD = new decimal[bytesToRead];
            speed = 0;
            this.chart.Series.Add("Motor_Y");
            this.chart.Series.Add("Motor_Z");
            this.chart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            this.chart.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            this.chart.Series[2].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            this.chart.Series["Motor_X"].Points.AddXY(0, 0);
            this.chart.Series["Motor_Y"].Points.AddXY(0, 0);
            this.chart.Series["Motor_Z"].Points.AddXY(0, 0);
            //this.chart.Series["speed"].Points.AddXY(1, 1);
            
            
            txData[0] = 0x07;
            txData[24] = 0x07;
            this.chart.Series["Motor_X"].Points.AddXY(0, 0);
            for (int i = 0; i < 1000; i++)
            {
                this.chart.Series["Motor_X"].Points.AddY(plotData[i]);
                this.chart.Series["Motor_Y"].Points.AddY(plotData[i]);
                this.chart.Series["Motor_Z"].Points.AddY(plotData[i]);
                //plotData[i] = plotData[i - 1];
                //Console.Write("plot data i ={0}\n", plotData[i]);

            }
           
            for (int i = 1; i < 24; i++)
            {
                txData[i] = 0;

            }
            for (int i = 0; i < 4; i++)
            {

                period[i] = 0 ;
            }
            
                serialPort1.ReadTimeout = 1;
               // serialPort1.WriteTimeout = 1;
                chart.ChartAreas[0].AxisX.Minimum = 0;
                chart.ChartAreas[0].AxisY.Minimum = 0;
             
            
        }


      
        

        private void sendButton_Click(object sender, EventArgs e)
        {
           
          //  receivedText.Text = textV.Text;
          //  Console.Write(" mode: {0}\n", mode);
           
            try
            {
                

                Console.Write("Send\n");

                

                if (flag_TL == true)
                {
                    txData[1] = 0x03;
                    xtext = -200;
                    ytext=2;
                    ztext = -280;
                    vtext = 8000;

                }
                else if (flag_TR == true)
                {
                    txData[1] = 0x03;
                    xtext = 0;
                    ytext=3;
                    ztext = -280;
                    vtext = 8000;

                }
                else if (flag_BR == true)
                {
                    txData[1] = 0x03;
                    xtext = 0;
                    ytext=4;
                    ztext = 0;
                    vtext = 8000;

                }
                else if (flag_BL == true)
                {
                    txData[1] = 0x03;
                    xtext = -200;
                    ytext=5;
                    ztext = 0;
                    vtext = 8000;

                }
                else if (flag_demo == true)
                {
                    txData[1] = 0x04;
                    flag_demo = false;
                }
                

                else
                {
                    txData[1] = mode;
                    xtext = int.Parse(textX.Text);
                    ytext = int.Parse(textY.Text);
                    ztext = int.Parse(textZ.Text);
                    vtext = int.Parse(textV.Text);
                }
                //if (xtext == 0)
                 //   xtext = 1;
                Console.WriteLine();
                Console.WriteLine("xtext: {0}, ytext: {1}, ztext: {2}, vtext: {3}", xtext, ytext, ztext, vtext);
                Console.WriteLine();
                xtext = (5000 * xtext) / 25; // should be float and 2.5
                ytext = (5000 * ytext) / 25; // should be float and 2.5
                ztext = (5000 * ztext) / 25; // should be float and 2.5
                Console.WriteLine("y text {0}", ytext);
              //  ztext = -1;
                txData[2] = (byte)(xtext >> 24);
                txData[3] = (byte)(xtext >> 16);
                txData[4] = (byte)(xtext >> 8);
                txData[5] = (byte)(xtext);
               
                
               
                txData[6] = (byte)(vtext >> 8);
                txData[7] = (byte)(vtext);

                txData[8] = (byte)(ytext >> 24);
                txData[9] = (byte)(ytext >> 16);
                txData[10] = (byte)(ytext >> 8);
                txData[11] = (byte)(ytext);


                txData[12] = (byte)(ztext >> 24);
                txData[13] = (byte)(ztext >> 16);
                txData[14] = (byte)(ztext >> 8);
                txData[15] = (byte)(ztext);



              // this.Invoke(new EventHandler(DisplayText));

             //  Console.Write(" hi hi x = {0} 2 = {1} 3 = {2} 4={3} 5={4}", xtext, txData[2], txData[3], txData[4], txData[5]);
            }
            catch (FormatException)
            {
                System.Diagnostics.Debug.Write("Unable to parse");
            }
            catch (OverflowException)
            {
                System.Diagnostics.Debug.Write("overflow");
            }  


                //byte.Parse(textX.Text);
                //   int data = int.Parse(textX.Text);
          
          
            receivedText.Text = txData[2].ToString();
          
            for (int i = 1; i < 23; i++)
            {
                checkSumTx ^= txData[i];
            }


           
            txData[23] = checkSumTx;
          //  textX.Text = "";
            for (int i = 0; i < 20;i++)
               
             //   Console.Write("coverted {0}", txData[i]);
            try
            {
                
                serialPort1.Write(txData, 0, 25);
                Thread.Sleep(1);

            }
            catch(InvalidOperationException)
            {
                System.Diagnostics.Debug.Write("port is closed!");
                
            }
            catch (ArgumentNullException)
            {

                System.Diagnostics.Debug.Write("Argument Null Exception!");

            }
            catch (ArgumentOutOfRangeException)
            {
                System.Diagnostics.Debug.Write("ArgumentOutOfRangeException!");

            }
            catch(ArgumentException)
            {
                System.Diagnostics.Debug.Write("ArgumentException!");

            }
            catch(TimeoutException)
            {
                System.Diagnostics.Debug.Write("TimeoutException!");

            }

            checkSumTx = 0;
            flag_TL = false;
            flag_TR = false;
            flag_BL = false;
            flag_BR = false;
            //serialPort1.Write("a");
            
            
        }

        private void initButton_Click(object sender, EventArgs e)
        {
            try
            {
        
                if (!serialPort1.IsOpen)
                {
                   receivedText.Text = serialPort1.PortName + "Ready!";

                 //  receivedText.Text = x;

                    serialPort1.Open();
                    initButton.Enabled = false;

                }
                else
                {

                    receivedText.Text = "port is not open";

                }



            }

            catch (UnauthorizedAccessException ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {

           // Console.Write(" rrrr\n");

            
            rxData = new byte[bytesToRead];

            rxD = new decimal[bytesToRead];

            try
            {
                serialPort1.Read(rxData, 0, bytesToRead);
            }
            catch (TimeoutException)
            {
                System.Diagnostics.Debug.Write("TimeoutException!");

            }

            for (int i = 0; i < bytesToRead; i++)
             {
               
                rxD[i]= Convert.ToDecimal(rxData[i]);
                
                //Console.Write(" Speed: {0}\n", rxData[i]);
             }
           // time = Convert.ToInt16(Convert.ToInt16(rxD[4])*256)+ (Convert.ToInt16(rxD[5]));
            //this.Invoke(new EventHandler(DisplayText));
                 //rxString[0] = Convert.ToString(rxData[0], 2);
                 checkSum = 0;
                 
       
                     for (int i = 2; i < 18; i++)
                     {
                         checkSum ^= rxData[i];
                     }

                 int j = 2;
                 // rxString = Encoding.ASCII.GetString(rxData);


                 
            
                if (rxData[0] == 7 && rxData[19] == 7 && rxData[18] == checkSum)
                 {

                     // this.Invoke(new EventHandler(DisplayText));
                    
                    
                     
                     speed = (Convert.ToInt32(rxData[2]) << 8) | rxData[3];
                     speed1 = (Convert.ToInt32(rxData[4]) << 8) | rxData[5];
                     speed2 = (Convert.ToInt32(rxData[6]) << 8) | rxData[7];
                   //  Console.Write("SSpeed1: {0} 2: {1}  3:{2}", speed, speed1, speed2);
                     switch (rxData[1])
                     {
                         case 1:
                             {
                                 for (int i = 0; i < 4; i++)
                                 {
                                     period[i] = rxData[j];

                                           
                                     j++;

                                 }
                                 j = 0;

                                 
                             }
                             
                             break;
                         default:
                             break;


                     }


                    
                     //rxString = serialPort1.ReadExisting();
                     //  this.BackColor = Color.Black;
                    

                     //this.Invoke(new EventHandler(plot));

                 }
               
                 else
                 {
                     serialPort1.DiscardInBuffer();
                     
                 }
                
               // this.Invoke(new EventHandler(DisplayText));
                            // this.Invoke(new EventHandler(DisplayText));
          
          
        }
        private void change_period()
        {



        }

        private void DisplayText(object s, EventArgs e)
        {

            //receivedText.AppendText(rxString[0]);
            
            //receivedText.Clear();
           
                    //receivedText.AppendText(period[i].ToString());
           // receivedText.AppendText("time:");       
            //receivedText.AppendText(rxData[2].ToString());
            //receivedText.AppendText(" ");
            //receivedText.AppendText("speed:");
            //receivedText.AppendText(rxData[4].ToString());
            //receivedText.AppendText("\n");
          for (int i = 0; i < 20;i++ )
            {
                receivedText.AppendText(rxData[i].ToString());
                receivedText.AppendText(" ");

            }
          //  receivedText.AppendText("time = ");
           // receivedText.AppendText(time.ToString());




                //receivedText.AppendText("received!\n");

                receivedText.AppendText("\n");
           
          
            
          
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            initButton.Enabled = true;
        }


        public void plot(object s, EventArgs e)
        {
            Random random = new Random();
            
            chart.ChartAreas[0].AxisX.Minimum = 0;
            chart.ChartAreas[0].AxisY.Minimum = 0;
            chart.ChartAreas[0].AxisX.Maximum = 1000;
            chart.ChartAreas[0].AxisY.Maximum = 12000;
            
           this.chart.Series["Motor_X"].Points.AddXY(0,0);
           this.chart.Series["Motor_X"].Points.AddXY(0, speed);
           this.chart.Series["Motor_X"].Points.Clear();

           this.chart.Series["Motor_Y"].Points.AddXY(0, 0);
           this.chart.Series["Motor_Y"].Points.AddXY(0, speed1);
           this.chart.Series["Motor_Y"].Points.Clear();

           this.chart.Series["Motor_Z"].Points.AddXY(0, 0);
           this.chart.Series["Motor_Z"].Points.AddXY(0, speed2);
           this.chart.Series["Motor_Z"].Points.Clear();




           // this.chart.Series.Clear();

           for (int i = 0; i <999; i++)
            {
                //this.chart.Series["speed"].Points.AddY(plotData[i]);
                plotData[i] = plotData[i+1];
                plotData1[i] = plotData1[i + 1];
                plotData2[i] = plotData2[i + 1];
                //Console.Write("plot data i ={0}\n", plotData[i]);

            }
            plotData[999] = speed;
            plotData1[999] = speed1;
            plotData2[999] = speed2;

            

            for (int i = 0; i < 1000; i++)
            {
                this.chart.Series["Motor_X"].Points.AddY(plotData[i]);
                this.chart.Series["Motor_Y"].Points.AddY(plotData1[i]);
                this.chart.Series["Motor_Z"].Points.AddY(plotData2[i]);
                //plotData[i] = plotData[i - 1];
                //Console.Write("plot data i ={0}\n", plotData[i]);

            }
            
         

            //
           
            //this.chart.AxisChange();
            

            //this.chart.Invalidate();
            //this.chart.Refresh();
            


               
            
            
            //foreach (var series in chart.Series)
            //{
            //    series.Points.Clear();
            //}
            
           // this.chart.Series.Clear();
            
            

               // this.chart.Series["speed"].Points.AddY(speed);


            
            //for (double i = 0; i <= 5; i = i + 0.01)
            //{

            //    randomNumber = random.Next(-5, 5);
            //    randomNumber = (double)randomNumber / 30.0;
            //    // this.chart1.Series["T_Curve"].Points.AddXY(i, (2 + randomNumber) * i);
            //    this.chart1.Series["T_Curve"].Points.AddXY(i, ((2) * i) + randomNumber);
            //}
            //for (double i = 5; i <= 10; i = i + 0.01)
            //{
            //    randomNumber = random.Next(-5, 5);
            //    randomNumber = (double)randomNumber / 100.0;

            //    this.chart1.Series["T_Curve"].Points.AddXY(i, 10 + randomNumber);

            //}
            //for (double i = 10; i <= 15; i = i + 0.01)
            //{
            //    randomNumber = random.Next(-5, 5);
            //    randomNumber = (double)randomNumber / 30.0;

            //    //this.chart1.Series["T_Curve"].Points.AddXY(i, 10 - ((2 + randomNumber) * (i - 10)));
            //    this.chart1.Series["T_Curve"].Points.AddXY(i, randomNumber + 10 - ((2) * (i - 10)));
            //}
        }

        public void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
        {
            //this.chart1.Series["IR Top Right"].Points.AddY(IR_t_r);


          //  this.Invoke(new EventHandler(plot));
            //**Console.WriteLine("The Elapsed event was raised at {0}", e.SignalTime);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Invoke(new EventHandler(plot));

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            //this.Invoke(new EventHandler(plot));
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)//reset
        {
            for (int i = 1; i < 19; i++)
            {
                txData[i]=0;
            }
            txData[1] = 0x02;

            for (int i = 1; i < 18; i++)
            {
                checkSumTx ^= txData[i];
            }
            Console.Write("Reset\n");


            txData[23] = checkSumTx;
            //  textX.Text = "";
            for (int i = 0; i < 20; i++)

                //   Console.Write("coverted {0}", txData[i]);
                try
                {

                    serialPort1.Write(txData, 0, 25);
                    Thread.Sleep(1);

                }
                catch (InvalidOperationException)
                {
                    System.Diagnostics.Debug.Write("port is closed!");

                }
                catch (ArgumentNullException)
                {

                    System.Diagnostics.Debug.Write("Argument Null Exception!");

                }
                catch (ArgumentOutOfRangeException)
                {
                    System.Diagnostics.Debug.Write("ArgumentOutOfRangeException!");

                }
                catch (ArgumentException)
                {
                    System.Diagnostics.Debug.Write("ArgumentException!");

                }
                catch (TimeoutException)
                {
                    System.Diagnostics.Debug.Write("TimeoutException!");

                }

            checkSumTx = 0;
            //serialPort1.Write("a");


        }

        private void AbsolutePosCheckBox_CheckedChanged(object sender, EventArgs e)
        {
                     
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            mode = 0x03;

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            mode = 0x01;
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void TopLeft_Click(object sender, EventArgs e)
        {
            flag_TL = true;
            this.Invoke(new EventHandler(sendButton_Click));
        }

        private void TopRight_Click(object sender, EventArgs e)
        {
            flag_TR = true;
            this.Invoke(new EventHandler(sendButton_Click));
        }

        private void ButtonLeft_Click(object sender, EventArgs e)
        {
            flag_BL = true;
            this.Invoke(new EventHandler(sendButton_Click));
        }

        private void ButtonRight_Click(object sender, EventArgs e)
        {
            flag_BR = true;
            this.Invoke(new EventHandler(sendButton_Click));
        }

        private void Demo_Click(object sender, EventArgs e)
        {
            flag_demo = true;
            this.Invoke(new EventHandler(sendButton_Click));
        }



      /*  private void timer1_Tick(object sender, EventArgs e)
        {
            this.Invoke(new EventHandler(plot));
        }
       */


      }
}





       
       

