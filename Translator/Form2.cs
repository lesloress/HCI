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
    public partial class secondTr : Form
    {
        Dict dict = new Dict();
        
        public secondTr()
        {
            InitializeComponent();
            inputLang.SelectedItem = inputLang.Items[0];
            outputLang.SelectedItem = outputLang.Items[2];
        }

        private void secondTr_Shown(object sender, EventArgs e)
        {
            inputLang.SelectedIndex = 0;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(inputBox.Text))
            {
                string input = inputBox.Text.ToLower();
                string[] output = null;
                int inpLang = 1;
                int outLang = 1;
                switch (inputLang.GetItemText(inputLang.SelectedItem))
                {
                    case "английский":
                        inpLang = 0;
                        break;
                    case "немецкий":
                        inpLang = 1;
                        break;
                    case "русский":
                        inpLang = 2;
                        break;
                }
                switch (outputLang.GetItemText(outputLang.SelectedItem))
                {
                    case "английский":
                        outLang = 0;
                        break;
                    case "немецкий":
                        outLang = 1;
                        break;
                    case "русский":
                        outLang = 2;
                        break;
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
                        outputBox.Text = o;
                    }
                    else
                    {
                        outputBox.Text = "Ничего не найдено";
                    }
                }
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            inputBox.Text = "";
        }
    }
}
