using Calculadora.controller;
using Calculadora.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        CalculatorControler cal = new CalculatorControler();
        RemuveCaracter re = new RemuveCaracter();
        List<char> li = new List<char>() { '+', '-', '*', '/' };
        private String num = "0";
        private String operate = "";

        
        public Form1()
        {
            InitializeComponent(); 
        }

        //close
        private void BTNClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //minimized
        private void BTNminimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        //num1
        private void button1_Click(object sender, EventArgs e)
        {
            cleanCero();
            num = "1";
            LBLnumber.Text += num.ToString();
        }
        //num2
        private void button2_Click(object sender, EventArgs e)
        {
            cleanCero();
            num = "2";
            LBLnumber.Text += num.ToString();
        }
        //3
        private void button3_Click(object sender, EventArgs e)
        {
            cleanCero();
            num = "3";
            LBLnumber.Text += num.ToString();
        }
        //4
        private void button4_Click(object sender, EventArgs e)
        {
            cleanCero();
            num = "4";
            LBLnumber.Text += num.ToString();
        }
        //5
        private void button5_Click(object sender, EventArgs e)
        {
            cleanCero();
            num = "5";
            LBLnumber.Text += num.ToString();
        }
        //6
        private void button6_Click(object sender, EventArgs e)
        {
            cleanCero();
            num = "6";
            LBLnumber.Text += num.ToString();
        }
        //7
        private void button7_Click(object sender, EventArgs e)
        {
            cleanCero();
            num = "7";
            LBLnumber.Text += num.ToString();
        }
        //8
        private void button8_Click(object sender, EventArgs e)
        {
            cleanCero();
            num = "8";
            LBLnumber.Text += num.ToString();
        }
        //9
        private void button9_Click(object sender, EventArgs e)
        {
            cleanCero();
            num = "9";
            LBLnumber.Text += num.ToString();
        }
        //num0
        private void button11_Click(object sender, EventArgs e)
        {
            cleanCero();
            num = "0";
            LBLnumber.Text += num.ToString();
        }

        //clean
        private void BTNclean_Click(object sender, EventArgs e)
        {
            num = "0";
            LBLnumber.Text = num.ToString();
            LBLnumero2.Text = num.ToString();
        }


        //add
        private void button13_Click(object sender, EventArgs e)
        {
            LBLnumero2.Text = LBLnumber.Text +" + ";
            LBLnumber.Text = "0";
            num = "0";
            operate = "+";
        }

        //subtraction 
        private void button14_Click(object sender, EventArgs e)
        {
            LBLnumero2.Text = LBLnumber.Text + " - ";
            LBLnumber.Text = "0";
            num = "0";
            operate = "-";
        }

        //multiply
        private void button15_Click(object sender, EventArgs e)
        {
            LBLnumero2.Text = LBLnumber.Text + " * ";
            LBLnumber.Text = "0";
            num = "0";
            operate = "*";
        }

        //division
        private void button16_Click(object sender, EventArgs e)
        {
            LBLnumero2.Text = LBLnumber.Text + " / ";
            LBLnumber.Text = "0";
            num = "0";
            operate = "/";
        }

        //clean num 0
        private void cleanCero() 
        {
            if (LBLnumber.Text == "0") 
            {
                LBLnumber.Text = "";
            }
        }

        //answer
        private void button17_Click(object sender, EventArgs e)
        {
            try
            {
                float num2 = (float)Convert.ToDouble(re.filter(LBLnumero2.Text, li));
                float num1 = (float)Convert.ToDouble(LBLnumber.Text);
                LBLnumero2.Text += LBLnumber.Text;
                LBLnumber.Text = "" + cal.operation(operate, num1, num2);
            }
            catch (Exception)
            {
                LBLnumber.Text = "error capa 8";
            }
        }

        //point
        private void button12_Click(object sender, EventArgs e)
        {
            bool b = true;
            foreach (char i in LBLnumber.Text) 
            {
                if (i == '.') { b = false;}
            }
            if (b) { LBLnumber.Text += "."; }
        }
    }
}
