using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.CompilerServices;

namespace MyCal444
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int x, y;

        private void textBoxOP1_TextChanged(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(this.textBoxOP1.Text))
            {
                this.textBoxOP1.Text = ' '.ToString();
            }
            else
            {
                x = int.Parse(this.textBoxOP1.Text);
            }

        }

        private void textBoxOP2_TextChanged(object sender, EventArgs e)
        {
            //if (!(byte.Parse(this.textBoxOP2.Text) >57  && byte.Parse(this.textBoxOP2.Text) < 48))
            //{
            //    this.labelRESULT.Text = "请检查输入是否正确".ToString();
            //}
            byte[] z = System.Text.Encoding.Default.GetBytes((this.textBoxOP2.Text).ToString());
            if (string.IsNullOrWhiteSpace(this.textBoxOP2.Text))
            {
                this.textBoxOP2.Text = ' '.ToString();
            }
            else
            {
                y = int.Parse(this.textBoxOP2.Text);
            }

        }

        private void buttonADD_Click(object sender, EventArgs e)
        {
            this.buttonpre.Text = '+'.ToString();
        }

        private void buttonSUB_Click(object sender, EventArgs e)
        {
            if (int.Parse(this.textBoxOP1.Text) >= int.Parse(this.textBoxOP2.Text))
            {
                this.buttonpre.Text = '-'.ToString();
            }
            else
            {
                this.labelRESULT.Text = "请检查数据是否正确".ToString();
            }
        }

        private void buttonMUL_Click(object sender, EventArgs e)
        {
            this.buttonpre.Text = '*'.ToString();
        }

        private void buttonDIV_Click(object sender, EventArgs e)
        {
            if (int.Parse(this.textBoxOP1.Text) == 0 || this.textBoxOP1.Text == null || int.Parse(this.textBoxOP2.Text) == 0 || this.textBoxOP2.Text == null)
            {
                this.labelRESULT.Text = "请检查数据是否正确".ToString();
            }
            else
            {
                this.buttonpre.Text = '/'.ToString();
            }
        }

        private void buttonMOD_Click(object sender, EventArgs e)
        {
            if (int.Parse(this.textBoxOP1.Text) == 0 || this.textBoxOP1.Text == null || int.Parse(this.textBoxOP2.Text) == 0 || this.textBoxOP2.Text == null)
            {
                this.labelRESULT.Text = "请检查数据是否正确".ToString();
            }
            else
            {
                this.buttonpre.Text = '%'.ToString();
            }
        }

        private void buttonEQU_Click(object sender, EventArgs e)
        {
            switch (char.Parse(this.buttonpre.Text))
            {
                case '+':
                    this.labelRESULT.Text = (x + y).ToString();
                    break;
                case '-':
                    this.labelRESULT.Text = (x - y).ToString();
                    break;
                case '*':
                    this.labelRESULT.Text = (x * y).ToString();
                    break;
                case '/':
                    this.labelRESULT.Text = (x / y).ToString();
                    break;
                case '%':
                    this.labelRESULT.Text = (x % y).ToString();
                    break;
            }
    }

        private void labelRESULT_Click(object sender, EventArgs e)
        {

        }
    }
}
