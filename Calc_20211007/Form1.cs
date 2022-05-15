using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc_20211007
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btn9.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btn8.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btn7.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btn6.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btn5.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btn4.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btn3.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btn2.Text;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btn1.Text;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "")
            {
                return;
            }

            txtDisplay.Text += btn0.Text;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "" && previousSectionDisplay.Text == "")
            {
                MessageBox.Show("値を入力してください");
                return;
            }

            if (previousSectionDisplay.Text == "")
            {
                previousSectionDisplay.Text = txtDisplay.Text;
                txtDisplay.Text = "";
                opeLabel.Text = "＋";
                return;
            }

            opeLabel.Text = "＋";
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "" && previousSectionDisplay.Text == "")
            {
                MessageBox.Show("値を入力してください");
                return;
            }

            if (previousSectionDisplay.Text == "")
            {
                previousSectionDisplay.Text = txtDisplay.Text;
                txtDisplay.Text = "";
                opeLabel.Text = "-";
                return;
            }

            opeLabel.Text = "-";
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "" && previousSectionDisplay.Text == "")
            {
                MessageBox.Show("値を入力してください");
                return;
            }

            if (previousSectionDisplay.Text == "")
            {
                previousSectionDisplay.Text = txtDisplay.Text;
                txtDisplay.Text = "";
                opeLabel.Text = "×";
                return;
            }

            opeLabel.Text = "×";
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "" && previousSectionDisplay.Text == "")
            {
                MessageBox.Show("値を入力してください");
                return;
            }

            if (previousSectionDisplay.Text == "")
            {
                previousSectionDisplay.Text = txtDisplay.Text;
                txtDisplay.Text = "";
                opeLabel.Text = "÷";
                return;
            }

            opeLabel.Text = "÷";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            previousSectionDisplay.Text = "";
            txtDisplay.Text = "";
            opeLabel.Text = "";
        }
        
        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (previousSectionDisplay.Text == "" || txtDisplay.Text == "" || opeLabel.Text == "")
            {
                MessageBox.Show("値を入力してください");
                return;
            }

            calculate();
            opeLabel.Text = "";
            previousSectionDisplay.Text = "";
        }
        //現在選択されている演算子によって各種計算を行う
        private void calculate()
        {
            switch (opeLabel.Text)
            {
                case "":
                    return;
                case "＋":
                    txtDisplay.Text = Convert.ToString(Convert.ToDouble(previousSectionDisplay.Text) + Convert.ToDouble(txtDisplay.Text));
                    break;
                case "-":
                    txtDisplay.Text = Convert.ToString(Convert.ToDouble(previousSectionDisplay.Text) - Convert.ToDouble(txtDisplay.Text));
                    break;
                case "×":
                    txtDisplay.Text = Convert.ToString(Convert.ToDouble(previousSectionDisplay.Text) * Convert.ToDouble(txtDisplay.Text));
                    break;
                case "÷":
                    txtDisplay.Text = Convert.ToString(Convert.ToDouble(previousSectionDisplay.Text) / Convert.ToDouble(txtDisplay.Text));
                    break;
                default:
                    txtDisplay.Text = "予期せぬエラーが発生しました。";
                    break;
            }
        }
    }
}
