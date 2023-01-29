using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamCode
{
    public partial class Form1 : Form
    {
        static Rootobject tmp;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            int x = 5, y = 80;
            string user = "mia.bell@mrjjones.co.uk";
            using (WebClient client = new WebClient())
            {
                var reqparm = new System.Collections.Specialized.NameValueCollection();
                reqparm.Add("email", user);
                client.Headers.Add("x-api-key", "QWJlcmRhcmVTY2hvb2w=");
                byte[] responsebytes = client.UploadValues("https://examcode.mrjjones.co.uk/app/exam", "POST", reqparm);
                string responsebody = Encoding.UTF8.GetString(responsebytes);
                tmp = JsonConvert.DeserializeObject<Rootobject>(responsebody);
            }
            label1.Text = tmp.details.Name;
            label2.Text = tmp.details.email;
            if(tmp.exams!=null)
                foreach (var item in tmp.exams)
                {
                    var color = (item.testColour is null)?String.Format("#{0:X6}", new Random().Next(0x1000000)):item.testColour;
                    UserControl ex = new examCode(item.testName, item.testCode, item.testURL, color);
                    ex.Location = new Point(x, y);
                    y += 90;
                    this.Controls.Add(ex);
                }
            this.MinimumSize = new System.Drawing.Size(this.Width, this.Height);


            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }


        public class Rootobject
        {
            public Details details { get; set; }
            public Exam[] exams { get; set; }
        }

        public class Details
        {
            public string email { get; set; }
            public string Name { get; set; }
        }

        public class Exam
        {
            public string testCode { get; set; }
            public string testURL { get; set; }
            public string testName { get; set; }
            public string testColour { get; set; }
        }

    }
}
