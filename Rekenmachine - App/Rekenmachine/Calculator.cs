﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Globalization;
using System.Collections;

namespace Rekenmachine
{
    public partial class Calculator : Form
    {
        MathLogic doMath = new MathLogic();

        double result = 0;
        double mem = 0;
        bool newEntry = true;
        bool directOp = false;
        char operat = '+';

        string decimalSymbol = NumberFormatInfo.CurrentInfo.CurrencyDecimalSeparator;

        public Calculator()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            mem = 0;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Display.Text = Convert.ToString(mem);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            mem += Convert.ToDouble(Display.Text);
            Display.Text = "0";
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            mem -= Convert.ToDouble(Display.Text);
            Display.Text = "0";
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            result = 0;
            mem = 0;
            Expression.Text = "";
            Display.Text = "0";
            operat = '+';
            newEntry = true;
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            Display.Text = "0";
            newEntry = true;
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            if (Display.Text != "0")
            {
                Expression.Text += Display.Text + "% ";
                double percentage = doMath.Calculate(Convert.ToDouble(Display.Text), result, '%');
                Display.Text = Convert.ToString(percentage);
                if (operat == '=')
                {
                    result = Convert.ToDouble(Display.Text);
                }
                directOp = true;
            }
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            if (Display.Text != "0")
            {
                Expression.Text += "√" + Display.Text + " ";
                double squareRoot = doMath.Calculate(Convert.ToDouble(Display.Text), 0, '√');
                Display.Text = Convert.ToString(squareRoot);
                if (operat == '=')
                {
                    result = Convert.ToDouble(Display.Text);
                }
                directOp = true;
            }
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            if (Display.Text != "0")
            {
                Expression.Text += Display.Text + "² ";
                double power = doMath.Calculate(Convert.ToDouble(Display.Text), 0, '²');
                Display.Text = Convert.ToString(power);
                if (operat == '=')
                {
                    result = Convert.ToDouble(Display.Text);
                }
                directOp = true;
            }
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            if (Display.Text != "0")
            {
                Expression.Text += Display.Text + " 1/(" + Display.Text + ") ";
                double inversion = doMath.Calculate(Convert.ToDouble(Display.Text), 0, 'i');
                Display.Text = Convert.ToString(inversion);
                if (operat == '=')
                {
                    result = Convert.ToDouble(Display.Text);
                }
                directOp = true;
            }
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            if (newEntry == true)
            {
                Display.Text = "7";
            }
            else
            {
                Display.Text += "7";

            }
            newEntry = false;

        }
        private void Button12_Click(object sender, EventArgs e)
        {
            if (newEntry == true)
            {
                Display.Text = "8";
            }
            else
            {
                Display.Text += "8";

            }
            newEntry = false;
        }
        private void Button13_Click(object sender, EventArgs e)
        {
            if (newEntry == true)
            {
                Display.Text = "9";
            }
            else
            {
                Display.Text += "9";

            }
            newEntry = false;
        }
        private void Button14_Click(object sender, EventArgs e)
        {
            if (Display.Text != "0")
            {
                if (directOp == true)
                {
                    Expression.Text += " / ";
                    directOp = false;
                }
                else
                {
                    Expression.Text += Display.Text + " / ";
                }
                result = doMath.Calculate(result, Convert.ToDouble(Display.Text), operat);
                Display.Text = Convert.ToString(result);
                operat = '/';
                newEntry = true;
            }
        }
        private void Button15_Click(object sender, EventArgs e)
        {
            if (newEntry == true)
            {
                Display.Text = "4";
            }
            else
            {
                Display.Text += "4";

            }
            newEntry = false;
        }
        private void Button16_Click(object sender, EventArgs e)
        {
            if (newEntry == true)
            {
                Display.Text = "5";
            }
            else
            {
                Display.Text += "5";

            }
            newEntry = false;
        }
        private void Button17_Click(object sender, EventArgs e)
        {
            if (newEntry == true)
            {
                Display.Text = "6";
            }
            else
            {
                Display.Text += "6";

            }
            newEntry = false;
        }

        private void Button18_Click(object sender, EventArgs e)
        {
            if (Display.Text != "0")
            {
                if (directOp == true)
                {
                    Expression.Text += " x ";
                    directOp = false;
                }
                else
                {
                    Expression.Text += Display.Text + " x ";
                }
                result = doMath.Calculate(result, Convert.ToDouble(Display.Text), operat);
                Display.Text = Convert.ToString(result);
                operat = '*';
                newEntry = true;
            }
        }

        private void Button19_Click(object sender, EventArgs e)
        {
            if (newEntry == true)
            {
                Display.Text = "1";
            }
            else
            {
                Display.Text += "1";

            }
            newEntry = false;
        }

        private void Button20_Click(object sender, EventArgs e)
        {
            if (newEntry == true)
            {
                Display.Text = "2";
            }
            else
            {
                Display.Text += "2";

            }
            newEntry = false;
        }
        private void Button21_Click(object sender, EventArgs e)
        {
            if (newEntry == true)
            {
                Display.Text = "3";
            }
            else
            {
                Display.Text += "3";

            }
            newEntry = false;
        }

        private void Button22_Click(object sender, EventArgs e)
        {
            if (Display.Text != "0")
            {
                if (directOp == true)
                {
                    Expression.Text += " - ";
                    directOp = false;
                }
                else
                {
                    Expression.Text += Display.Text + " - ";
                }
                result = doMath.Calculate(result, Convert.ToDouble(Display.Text), operat);
                Display.Text = Convert.ToString(result);
                operat = '-';
                newEntry = true;
            }
        }

        private void Button23_Click(object sender, EventArgs e)
        {
            char first = Display.Text[0];
            if (Display.Text != "0" && first != '-')
            {
                Display.Text = "-" + Display.Text;
            }
        }

        private void Button24_Click(object sender, EventArgs e)
        {
            if (newEntry == true)
            {
                Display.Text = "0";
            }
            else
            {
                Display.Text += "0";
                newEntry = false;
            }


        }

        private void Button25_Click(object sender, EventArgs e)
        {
            if (newEntry == false)
            {
                Expression.Text = "";
                result = doMath.Calculate(result, Convert.ToDouble(Display.Text), operat);
                Display.Text = Convert.ToString(result);
                operat = '=';
                newEntry = true;
            }

        }

        private void Button26_Click(object sender, EventArgs e)
        {
            if (Display.Text != "0")
            {
                if (directOp == true)
                {
                    Expression.Text += " + ";
                    directOp = false;
                }
                else
                {
                    Expression.Text += Display.Text + " + ";
                }
                result = doMath.Calculate(result, Convert.ToDouble(Display.Text), operat);
                Display.Text = Convert.ToString(result);
                operat = '+';
                newEntry = true;
                directOp = false;
            }
        }


        private void Button27_Click(object sender, EventArgs e)
        {
            if (Display.Text.Length > 1)
            {
                Display.Text = Display.Text.Substring(0, Display.Text.Length - 1);
            }
            else
            {
                Display.Text = "0";
            }
        }

        private void Button28_Click(object sender, EventArgs e)
        {
            if (newEntry == true)
            {
                Display.Text = "0" + decimalSymbol;
            }
            else
            {
                Display.Text += decimalSymbol;
            }
            newEntry = false;
        }

        private void Button29_Click(object sender, EventArgs e)
        {
            mem = Convert.ToInt32(Display.Text);
            Display.Text = "0";
        }

        // MouseOver button color change
        private void Button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.SteelBlue;
        }

        private void Button2_MouseHover(object sender, EventArgs e)
        {
            button2.BackColor = Color.SteelBlue;
        }

        private void Button3_MouseHover(object sender, EventArgs e)
        {
            button3.BackColor = Color.SteelBlue;
        }

        private void Button4_MouseHover(object sender, EventArgs e)
        {
            button4.BackColor = Color.SteelBlue;
        }

        private void Button5_MouseHover(object sender, EventArgs e)
        {
            button5.BackColor = Color.SteelBlue;
        }

        private void Button6_MouseHover(object sender, EventArgs e)
        {
            button6.BackColor = Color.SteelBlue;
        }

        private void Button7_MouseHover(object sender, EventArgs e)
        {
            button7.BackColor = Color.SteelBlue;
        }

        private void Button8_MouseHover(object sender, EventArgs e)
        {
            button8.BackColor = Color.SteelBlue;
        }

        private void Button9_MouseHover(object sender, EventArgs e)
        {
            button9.BackColor = Color.SteelBlue;
        }

        private void Button10_MouseHover(object sender, EventArgs e)
        {
            button10.BackColor = Color.SteelBlue;
        }

        private void Button11_MouseHover(object sender, EventArgs e)
        {
            button11.BackColor = Color.SteelBlue;
        }

        private void Button12_MouseHover(object sender, EventArgs e)
        {
            button12.BackColor = Color.SteelBlue;
        }

        private void Button13_MouseHover(object sender, EventArgs e)
        {
            button13.BackColor = Color.SteelBlue;
        }

        private void Button14_MouseHover(object sender, EventArgs e)
        {
            button14.BackColor = Color.SteelBlue;
        }

        private void Button15_MouseHover(object sender, EventArgs e)
        {
            button15.BackColor = Color.SteelBlue;
        }

        private void Button16_MouseHover(object sender, EventArgs e)
        {
            button16.BackColor = Color.SteelBlue;
        }

        private void Button17_MouseHover(object sender, EventArgs e)
        {
            button17.BackColor = Color.SteelBlue;
        }

        private void Button18_MouseHover(object sender, EventArgs e)
        {
            button18.BackColor = Color.SteelBlue;
        }

        private void Button19_MouseHover(object sender, EventArgs e)
        {
            button19.BackColor = Color.SteelBlue;
        }

        private void Button20_MouseHover(object sender, EventArgs e)
        {
            button20.BackColor = Color.SteelBlue;
        }

        private void Button21_MouseHover(object sender, EventArgs e)
        {
            button21.BackColor = Color.SteelBlue;
        }

        private void Button22_MouseHover(object sender, EventArgs e)
        {
            button22.BackColor = Color.SteelBlue;
        }

        private void Button23_MouseHover(object sender, EventArgs e)
        {
            button23.BackColor = Color.SteelBlue;
        }

        private void Button24_MouseHover(object sender, EventArgs e)
        {
            button24.BackColor = Color.SteelBlue;
        }

        private void Button25_MouseHover(object sender, EventArgs e)
        {
            button25.BackColor = Color.SteelBlue;
        }

        private void Button26_MouseHover(object sender, EventArgs e)
        {
            button26.BackColor = Color.SteelBlue;
        }
        private void Button27_MouseHover(object sender, EventArgs e)
        {
            button27.BackColor = Color.SteelBlue;
        }

        private void Button28_MouseHover(object sender, EventArgs e)
        {
            button28.BackColor = Color.SteelBlue;
        }

        private void Button29_MouseHover(object sender, EventArgs e)
        {

        }

        private void Button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.LightGray;
        }

        private void Button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.LightGray;
        }

        private void Button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Color.LightGray;
        }

        private void Button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackColor = Color.LightGray;
        }

        private void Button5_MouseLeave(object sender, EventArgs e)
        {
            button5.BackColor = Color.LightGray;
        }

        private void Button6_MouseLeave(object sender, EventArgs e)
        {
            button6.BackColor = Color.LightGray;
        }

        private void Button7_MouseLeave(object sender, EventArgs e)
        {
            button7.BackColor = Color.LightGray;
        }

        private void Button8_MouseLeave(object sender, EventArgs e)
        {
            button8.BackColor = Color.LightGray;
        }

        private void Button9_MouseLeave(object sender, EventArgs e)
        {
            button9.BackColor = Color.LightGray;
        }

        private void Button10_MouseLeave(object sender, EventArgs e)
        {
            button10.BackColor = Color.LightGray;
        }

        private void Button11_MouseLeave(object sender, EventArgs e)
        {
            button11.BackColor = Color.LightGray;
        }

        private void Button12_MouseLeave(object sender, EventArgs e)
        {
            button12.BackColor = Color.LightGray;
        }

        private void Button13_MouseLeave(object sender, EventArgs e)
        {
            button13.BackColor = Color.LightGray;
        }

        private void Button14_MouseLeave(object sender, EventArgs e)
        {
            button14.BackColor = Color.LightGray;
        }

        private void Button15_MouseLeave(object sender, EventArgs e)
        {
            button15.BackColor = Color.LightGray;
        }

        private void Button16_MouseLeave(object sender, EventArgs e)
        {
            button16.BackColor = Color.LightGray;
        }

        private void Button17_MouseLeave(object sender, EventArgs e)
        {
            button17.BackColor = Color.LightGray;
        }

        private void Button18_MouseLeave(object sender, EventArgs e)
        {
            button18.BackColor = Color.LightGray;
        }

        private void Button19_MouseLeave(object sender, EventArgs e)
        {
            button19.BackColor = Color.LightGray;
        }

        private void Button20_MouseLeave(object sender, EventArgs e)
        {
            button20.BackColor = Color.LightGray;
        }

        private void Button21_MouseLeave(object sender, EventArgs e)
        {
            button21.BackColor = Color.LightGray;
        }

        private void Button22_MouseLeave(object sender, EventArgs e)
        {
            button22.BackColor = Color.LightGray;
        }

        private void Button23_MouseLeave(object sender, EventArgs e)
        {
            button23.BackColor = Color.LightGray;
        }

        private void Button24_MouseLeave(object sender, EventArgs e)
        {
            button24.BackColor = Color.LightGray;
        }

        private void Button25_MouseLeave(object sender, EventArgs e)
        {
            button25.BackColor = Color.LightGray;
        }

        private void Button26_MouseLeave(object sender, EventArgs e)
        {
            button26.BackColor = Color.LightGray;
        }

        private void Button27_MouseLeave(object sender, EventArgs e)
        {
            button27.BackColor = Color.LightGray;
        }

        private void Button28_MouseLeave(object sender, EventArgs e)
        {
            button28.BackColor = Color.LightGray;
        }

        private void Button29_MouseLeave(object sender, EventArgs e)
        {
            button28.BackColor = Color.LightGray;
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void Calculator_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case (char)37: //%
                    button7.PerformClick();
                    break;
                case (char)42: //*
                    button18.PerformClick();
                    break;
                case (char)43: //+
                    button26.PerformClick();
                    break;
                case (char)45: //-
                    button22.PerformClick();
                    break;
                case (char)48: //0
                    button24.PerformClick();
                    break;
                case (char)49: //1
                    button19.PerformClick();
                    break;
                case (char)50: //2
                    button20.PerformClick();
                    break;
                case (char)51: //3
                    button21.PerformClick();
                    break;
                case (char)52: //4
                    button15.PerformClick();
                    break;
                case (char)53: //5
                    button16.PerformClick();
                    break;
                case (char)54: //6
                    button17.PerformClick();
                    break;
                case (char)55: //7
                    button11.PerformClick();
                    break;
                case (char)56: //8
                    button12.PerformClick();
                    break;
                case (char)57: //9
                    button13.PerformClick();
                    break;
                case (char)61: //=
                    button25.PerformClick();
                    break;
            }
        }
    }
}
