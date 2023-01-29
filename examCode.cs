using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamCode
{
    public partial class examCode : UserControl
    {
        string name;
        string username;
        string url;
        string backColor;
        public examCode(string test, string uName, string u, string backColour = null)
        {
            InitializeComponent();
            name = test;
            username = uName;
            url = u;
            backColor = backColour;
        }

        private void examCode_Load(object sender, EventArgs e)
        {
            label2.Text = name;
            this.BackColor = System.Drawing.ColorTranslator.FromHtml(backColor);
            panel1.BackColor = Color.White;
            textBox1.Text = username;
            textBox1.ReadOnly = true;
            textBox1.BorderStyle = 0;
            textBox1.BackColor = Color.White;
            textBox1.TabStop = false;

            label1.Text = url;
            label1.BorderStyle = 0;
            label1.BackColor = Color.White;
            label1.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Underline);
            label1.ForeColor = Color.Blue;
            label1.TabStop = false;


        }

        private void button1_Click(object sender, EventArgs e)
        {

            Clipboard.SetDataObject(textBox1.Text);
        }

        private bool IsHttpURL(string url)
        {
            return
                ((!string.IsNullOrWhiteSpace(url)) &&
                (url.ToLower().StartsWith("http")));
        }

        private void label1_Click(object sender, EventArgs e)
        {

            if (IsHttpURL(label1.Text)) Process.Start(label1.Text);
        }
    }
}
