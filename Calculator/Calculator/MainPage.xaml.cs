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
        
        private void BtnC_OnClicked(object sender, EventArgs e)
        {
            this.Input.Text = "";
        }

        private void BtnDivide_OnClicked(object sender, EventArgs e)
        {
            this.Input.Text += "/";
        }

        private void BtnMultiple_OnClicked(object sender, EventArgs e)
        {
            this.Input.Text += "*";
        }

        private void BtnMinus_OnClicked(object sender, EventArgs e)
        {
            this.Input.Text += "-";
        }

        private void Btn7_OnClicked(object sender, EventArgs e)
        {
            this.Input.Text += 7;
        }

        private void Btn8_OnClicked(object sender, EventArgs e)
        {
            this.Input.Text += 8;
        }

        private void Btn9_OnClicked(object sender, EventArgs e)
        {
            this.Input.Text += 9;
        }

        private void BtnPlus_OnClicked(object sender, EventArgs e)
        {
            this.Input.Text += "+";
        }

        private void Btn4_OnClicked(object sender, EventArgs e)
        {
            this.Input.Text += 4;
        }

        private void Btn5_OnClicked(object sender, EventArgs e)
        {
            this.Input.Text += 5;
        }

        private void Btn6_OnClicked(object sender, EventArgs e)
        {
            this.Input.Text += 6;
        }

        private void Btn1_OnClicked(object sender, EventArgs e)
        {
            this.Input.Text += 1;
        }

        private void Btn2_OnClicked(object sender, EventArgs e)
        {
            this.Input.Text += 2;
        }

        private void Btn3_OnClicked(object sender, EventArgs e)
        {
            this.Input.Text += 3;
        }

        private void BtnResult_OnClicked(object sender, EventArgs e)
        {
            this.Input.Text = new DataTable().Compute(this.Input.Text, null).ToString();
        }

        private void BtnDel_OnClicked(object sender, EventArgs e)
        {
            this.Input.Text = this.Input.Text.Remove(this.Input.Text.Length - 1);
        }

        private void Btn0_OnClicked(object sender, EventArgs e)
        {
            this.Input.Text += 0;
        }

        private void BtnDot_OnClicked(object sender, EventArgs e)
        {
            this.Input.Text += ".";
        }
    }
}