using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Coders
{
    public partial class Form1 : Form
    {
        VigenerCoder v = new VigenerCoder();
        HaffmanTree h = new HaffmanTree();
        public Form1()
        {
            InitializeComponent();
        }
        private void Encode_Click(object sender, EventArgs e)
        {
            
            string s;
            if (Standart.Checked)
            {
                if (KeyVigTextBox.Text.Length > 0)
                {
                    s = TextForCoderVig.Text;
                    TextForCoderVig.Text = v.Encode(s, KeyVigTextBox.Text);
                    ShowNotifyText("Кодирование по методу Виженера было завершено!:)");
                }
                else { MessageBox.Show("Введите ключ"); }
            }
            else if(Pseudo.Checked)
            {
                s = TextForCoderVig.Text;
                TextForCoderVig.Text = v.Encode(s, v.Generate_Pseudorandom_Key(s.Length, 20));
                ShowNotifyText("Кодирование по методу Виженера было завершено!:)");
            }
            else { MessageBox.Show("Выберите способ!"); }
        }

        private void Decode_Click(object sender, EventArgs e)
        {
            string s;
            if(Standart.Checked)
            {
                if (KeyVigTextBox.Text.Length > 0)
                {
                    s = TextForCoderVig.Text;
                    TextForCoderVig.Text = v.Decode(s, KeyVigTextBox.Text);
                    ShowNotifyText("Декодирование по методу Виженера было завершено!:)");
                }
                else { MessageBox.Show("Введите ключ"); }
            }
            else if (Pseudo.Checked)
            {
                s = TextForCoderVig.Text;
                TextForCoderVig.Text = v.Decode(s, v.Generate_Pseudorandom_Key(s.Length, 20));
                ShowNotifyText("Декодирование по методу Виженера было завершено!:)");
            }
            else { MessageBox.Show("Выберите способ!"); }
        }

        private void Standart_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if(rb == Standart)
            {
                KeyVigTextBox.Enabled = true;
            }
            else if(rb == Pseudo)
            {
                KeyVigTextBox.Enabled = false;
            }
        }

        private void ShowNotifyText(string text,int tip = 1000)
        {
            NotifyCoder.BalloonTipText = text;
            NotifyCoder.ShowBalloonTip(tip);
        }

        private void EncodeHaf_Click(object sender, EventArgs e)
        {
            BitArray encoded = h.Encode(TextForCoderHaf.Text);
            TextForCoderHaf.Text = "";
            foreach(bool bit in encoded)
            {
                TextForCoderHaf.Text += (bit ? 1 : 0).ToString();
            }
            ShowNotifyText("Кодирование по методу Хаффмана было завершено!:)");
        }

        private void DecodeHaf_Click(object sender, EventArgs e)
        {
            BitArray encoded;
            List <bool> bits = new List<bool>();
            foreach(char bit in TextForCoderHaf.Text)
            {
                if (bit == '1')
                {
                    bits.Add(true);
                }
                else if(bit == '0')
                {
                    bits.Add(false);
                }
                else { MessageBox.Show("Неверный код"); return; }
            }
            encoded = new BitArray(bits.ToArray());
            TextForCoderHaf.Text = h.Decode(encoded);
            ShowNotifyText("Декодирование по методу Хаффмана было завершено!:)");
        }
    }
}
