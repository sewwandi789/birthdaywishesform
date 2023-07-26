using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace wpapp
{
    public partial class Form1 : Form
    {
        int  tickCount = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void lblmethod() 
        {

            label2.Visible = true;
            label4.Visible = true;
            label3.Visible = true;
            label7.Visible = true;
            label6.Visible = true;
            label5.Visible = true;
            label9.Visible = true;
            label8.Visible = true;
            label10.Visible = true;
            label11.Visible = true;
            label12.Visible = true;
            label13.Visible = true;
            label14.Visible = true;
        
        }
        private void lblmethoddntshow()
        {

            label2.Visible = false;
            label4.Visible = false;
            label3.Visible = false;
            label7.Visible = false;
            label6.Visible = false;
            label5.Visible = false;
            label9.Visible = false;
            label8.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            label14.Visible = false;

        }
        private void blinkingMethod() 
        {
         
            tickCount++;             

            if (tickCount % 10 == 0) // Execute a specific action every 10 ticks (10 seconds).
            {
                lblmethod(); label4.Visible = false; label13.Visible = false;
                
            }
            if (tickCount % 10 == 1) // Execute a specific action every 10 ticks (10 seconds).
            {
                lblmethod();label4.Visible = false;label14.Visible = false;
            }
            if (tickCount % 10 == 2) // Execute a specific action every 10 ticks (10 seconds).
            {
                lblmethod();label3.Visible = false;
            }
            if (tickCount % 10 == 3) // Execute a specific action every 10 ticks (10 seconds).
            {
                lblmethod();label7.Visible = false;              
            }
            if (tickCount % 10 == 4) // Execute a specific action every 10 ticks (10 seconds).
            {
                lblmethod();label6.Visible = false;               
            }
            if (tickCount % 10 == 5) // Execute a specific action every 10 ticks (10 seconds).
            {
                lblmethod();label12.Visible = false;
            }
            if (tickCount % 10 == 6) // Execute a specific action every 10 ticks (10 seconds).
            {
                lblmethod();label9.Visible = false;     
            }
            if (tickCount % 10 == 7) // Execute a specific action every 10 ticks (10 seconds).
            {
                lblmethod();label8.Visible = false;                
            }
            if (tickCount % 10 == 8) // Execute a specific action every 10 ticks (10 seconds).
            {
                lblmethod();label10.Visible = false;                
            }
            if (tickCount % 10 == 9) // Execute a specific action every 10 ticks (10 seconds).
            {
                lblmethod();label11.Visible = false;               
            }
          
         }     
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 100; // Initial interval set to 1 second (1000 milliseconds).
            timer1.Start();
            timer1.Tick += timer1_Tick;
            lblmethoddntshow();

            string bdstatus = "";
            DateTime date = DateTime.Now;

           // if (date == "") { }
            string sql = "";

            //timer2.Interval = 500; // Initial interval set to 0.5 second (1000 milliseconds).
            //timer1.Start();
            //timer2.Tick += timer2_Tick; 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            blinkingMethod();
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}
