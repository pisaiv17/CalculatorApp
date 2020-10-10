using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Data;

namespace Calculator
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// Clear the input
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnC_OnClicked(object sender, EventArgs e)
        {
            this.Input.Text = "";
        }

        /// <summary>
        /// Write divide character in input
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDivide_OnClicked(object sender, EventArgs e)
        {
            this.Input.Text += "/";
        }

        /// <summary>
        /// Write multiple character in input
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnMultiple_OnClicked(object sender, EventArgs e)
        {
            this.Input.Text += "*";
        }

        /// <summary>
        /// Write minus character in input
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnMinus_OnClicked(object sender, EventArgs e)
        {
            this.Input.Text += "-";
        }

        /// <summary>
        /// Write number 7 in input
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
         private void Btn7_OnClicked(object sender, EventArgs e)
         {
             this.Input.Text += 7;
         }
 
         /// <summary>
         /// Write number 8 in input
         /// </summary>
         /// <param name="sender"></param>
         /// <param name="e"></param>
         private void Btn8_OnClicked(object sender, EventArgs e)
         {
             this.Input.Text += 8;
         }
 
         /// <summary>
         /// Write number 9 in input
         /// </summary>
         /// <param name="sender"></param>
         /// <param name="e"></param>
         private void Btn9_OnClicked(object sender, EventArgs e)
         {
             this.Input.Text += 9;
         }
         
 
         /// <summary>
         /// Write plus character in input
         /// </summary>
         /// <param name="sender"></param>
         /// <param name="e"></param>
         private void BtnPlus_OnClicked(object sender, EventArgs e)
         {
             this.Input.Text += "+";
         }
 
         /// <summary>
         /// Write number 4 in input
         /// </summary>
         /// <param name="sender"></param>
         /// <param name="e"></param>
         private void Btn4_OnClicked(object sender, EventArgs e)
         {
             this.Input.Text += 4;
         }
 
         /// <summary>
         /// Write number 5 in input
         /// </summary>
         /// <param name="sender"></param>
         /// <param name="e"></param>
         private void Btn5_OnClicked(object sender, EventArgs e)
         {
             this.Input.Text += 5;
         }
 
         /// <summary>
         /// Write number 6 in input
         /// </summary>
         /// <param name="sender"></param>
         /// <param name="e"></param>
         private void Btn6_OnClicked(object sender, EventArgs e)
         {
             this.Input.Text += 6;
         }
 
         /// <summary>
         /// Write number 1 in input
         /// </summary>
         /// <param name="sender"></param>
         /// <param name="e"></param>
         private void Btn1_OnClicked(object sender, EventArgs e)
         {
             this.Input.Text += 1;
         }
 
         /// <summary>
         /// Write number 2 in input
         /// </summary>
         /// <param name="sender"></param>
         /// <param name="e"></param>
         private void Btn2_OnClicked(object sender, EventArgs e)
         {
             this.Input.Text += 2;
         }
 
         /// <summary>
         /// Write number 3 in input
         /// </summary>
         /// <param name="sender"></param>
         /// <param name="e"></param>
         private void Btn3_OnClicked(object sender, EventArgs e)
         {
             this.Input.Text += 3;
         }
 
         /// <summary>
         /// Write result in input
         /// </summary>
         /// <param name="sender"></param>
         /// <param name="e"></param>
         private void BtnResult_OnClicked(object sender, EventArgs e)
         {
             try
             {
                 this.Input.Text = new DataTable().Compute(this.Input.Text, null).ToString();
             }
             catch (Exception exception)
             {
                 this.Input.Text = "Chyba";
             }
         }
 
         /// <summary>
         /// Delete last character from input
         /// </summary>
         /// <param name="sender"></param>
         /// <param name="e"></param>
         private void BtnDel_OnClicked(object sender, EventArgs e)
         {
             try
             {
                 this.Input.Text = this.Input.Text.Remove(this.Input.Text.Length - 1);
             }
             catch (Exception exception)
             {
                 this.Input.Text = "";
             }
         }
 
         /// <summary>
         /// Write number 0 in input
         /// </summary>
         /// <param name="sender"></param>
         /// <param name="e"></param>
         private void Btn0_OnClicked(object sender, EventArgs e)
         {
             this.Input.Text += 0;
         }
 
         /// <summary>
         /// Write dot character in input
         /// </summary>
         /// <param name="sender"></param>
         /// <param name="e"></param>
         private void BtnDot_OnClicked(object sender, EventArgs e)
         {
             this.Input.Text += ".";
         }

         /// <summary>
         /// Write left bracket in input
         /// </summary>
         /// <param name="sender"></param>
         /// <param name="e"></param>
         private void BtnLBracket_OnClicked(object sender, EventArgs e)
         {
             this.Input.Text += "(";
         }

         /// <summary>
         /// Write right bracket in input
         /// </summary>
         /// <param name="sender"></param>
         /// <param name="e"></param>
         private void BtnRBracket_OnClicked(object sender, EventArgs e)
         {
             this.Input.Text += ")";
         }
    }
}