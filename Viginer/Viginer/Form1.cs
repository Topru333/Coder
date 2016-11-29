using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coders
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Encode_Click(object sender, EventArgs e)
        {
            Coder c = new Coder();
            string s;
            if (Standart.Checked)
            {
                if (KeyTextBox.Text.Length > 0)
                {
                    s = TextForCoderVig.Text;
                    TextForCoderVig.Text = c.Encode(s, KeyTextBox.Text);
                    ShowNotifyText("Кодирование по методу Виженера было завершено!:)");
                }
                else { MessageBox.Show("Введите ключ"); }
            }
            else if(Pseudo.Checked)
            {
                s = TextForCoderVig.Text;
                TextForCoderVig.Text = c.Encode(s, c.Generate_Pseudorandom_Key(s.Length, 20));
                ShowNotifyText("Кодирование по методу Виженера было завершено!:)");
            }
            else { MessageBox.Show("Выберите способ!"); }
        }

        private void Decode_Click(object sender, EventArgs e)
        {
            Coder c = new Coder();
            string s;
            if(Standart.Checked)
            {
                if (KeyTextBox.Text.Length > 0)
                {
                    s = TextForCoderVig.Text;
                    TextForCoderVig.Text = c.Decode(s, KeyTextBox.Text);
                    ShowNotifyText("Декодирование по методу Виженера было завершено!:)");
                }
                else { MessageBox.Show("Введите ключ"); }
            }
            else if (Pseudo.Checked)
            {
                s = TextForCoderVig.Text;
                TextForCoderVig.Text = c.Decode(s, c.Generate_Pseudorandom_Key(s.Length, 20));
                ShowNotifyText("Декодирование по методу Виженера было завершено!:)");
            }
            else { MessageBox.Show("Выберите способ!"); }
        }

        private void Standart_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if(rb == Standart)
            {
                KeyTextBox.Enabled = true;
            }
            else if(rb == Pseudo)
            {
                KeyTextBox.Enabled = false;
            }
        }

        private void ShowNotifyText(string text,int tip = 1000)
        {
            NotifyCoder.BalloonTipText = text;
            NotifyCoder.ShowBalloonTip(tip);
        }

        
    }
}
