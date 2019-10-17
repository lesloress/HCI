using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Translator.Translate;

namespace Translator
{
    public partial class thirdTr : Form
    {
        Dict dict = new Dict();
        Examples ex = new Examples();
        public thirdTr()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            inputBox.Text = "";
            output_box.Text = "";
            richTextBox1.Text = "";
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(inputBox.Text))
            {
                string input = inputBox.Text.ToLower();
                string[] output = null;
                int inpLang = 0;
                int outLang = 1;

                if (input[0]>='a' && input[0] <= 'z')
                {
                     inpLang = 0;
                     outLang = 2;
                }

                else
                {
                    inpLang = 2;
                    outLang = 0;
                }

                for (int i = 0; i < dict.words.Count; i++)
                {
                    string[][] cur = dict.words[i];
                    for (int j = 0; j < cur[inpLang].Length; j++)
                    {
                        if (input == cur[inpLang][j])
                        {
                            output = cur[outLang];
                            break;
                        }
                    }
                    if (output != null)
                    {
                        string o = "";
                        for (int k = 0; k < output.Length; k++)
                            o += "-" + output[k] + "\n";
                        //outputBox.Text = Join("-", output, " ")
                        output_box.Text = o;
                    }
                    else
                    {
                        output_box.Text = "Ничего не найдено";
                    }
                }

                for (int i = 0; i < ex.examples.Count; i++)
                {
                    if (output_box.Text == "Ничего не найдено") break;


                    string[][] cur = ex.examples[i];
                    for (int j = 0; j < cur[0].Length; j++)
                    {
                        if (input == cur[0][j])
                        {
                            output = cur[1];
                            break;
                        }
                    }
                    if (output != null)
                    {
                        string o = "";
                        for (int k = 0; k < output.Length; k++)
                            o += "-" + output[k] + "\n";
                        //outputBox.Text = Join("-", output, " ")
                        richTextBox1.Text = o;
                    }
                    
                }



            }
        }
    }
}
