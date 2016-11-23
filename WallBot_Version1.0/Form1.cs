using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace WallBot_Version1._0
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
            webBrowser1.Visible = false;
        }
        Thread t1;
        public string token = "";
        public string user_id = "";
        public API WallBot;
        public String[] comennts = { "Nice post!", "It's best post forever!", "Delete this shit", "OK" };
        public String[] TextPosts = { "OtherPost", "CoolPost", "Post of love", "Rich Post" };
        public Random r = new Random();

        private void Form1_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://oauth.vk.com/authorize?client_id=5722498&display=popup&redirect_uri=https://oauth.vk.com/blank.html&scope=wall&response_type=token&v=5.52");
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            try
            {
                string url = webBrowser1.Url.ToString();
                string l = url.Split('#')[1];
                token = l.Split('&')[0];
                user_id = l.Split('&')[2].Split('=')[1];
                // token = l.Split('=')[1].Split('&')[0];
                Console.WriteLine("logs//");
                Console.WriteLine("//Token: " + token);
                Console.WriteLine("//ID:" + user_id);
               // MetroFramework.MetroMessageBox.Show(this, "Your token: " + token + " and your id: " + user_id);
                MessageBox.Show("Your token: " + token + " and your id: "+user_id);
                WallBot = new API(token, user_id);
            }
            catch
            {

            }
        }

        private void create_WallPost_Click(object sender, EventArgs e)
        {
            WallBot.WallPost(user_id, TextPosts[r.Next(0,4)]);
        }

        private void comment_WallPost_Click(object sender, EventArgs e)
        {
            WallBot.CommentWallPost(user_id, comennts[r.Next(0,3)], listBox1.SelectedItem.ToString().Split('%')[0]);
        }

        private void delete_WallPost_Click(object sender, EventArgs e)
        {
            WallBot.DeleteWallPost(user_id, listBox1.SelectedItem.ToString().Split('%')[0]);
        }

        private void get_WallPost_Click(object sender, EventArgs e)
        {
           
                
                string ur = WallBot.WallGet();
                StreamWriter sw = new StreamWriter("WallPosts.txt");
                listBox1.Items.Clear();
                XElement element = XElement.Parse(ur);
                List<string> ids = new List<string>();
                List<string> text = new List<string>();
                List<string> date = new List<string>();
                List<string> count_likes = new List<string>();

                foreach (XElement childElement in element.Descendants("likes"))
                {
                    count_likes.Add(childElement.Value);
                }

                foreach (XElement childElement in element.Descendants("date"))
                {
                    date.Add(childElement.Value);
                }

                foreach (XElement childElement in element.Descendants("text"))
                {
                    text.Add(childElement.Value);
                }

                foreach (XElement childElement in element.Descendants("id"))
                {
                    ids.Add(childElement.Value);
                }
                for (int i = 0; i < ids.Count; i++)
                {
                    listBox1.Items.Add(ids[i] + "%" + text[i] + " date:" + date[i] + " like: " + count_likes[i]);
                    sw.WriteLine(ids[i] + "%" + text[i] + " date:" + date[i] + " like: " + count_likes[i]);
                }
                sw.Close();
            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            WallBot.WallPost(user_id, "WallBot: AutoPostMessage");
        }

        private void start_AutoPost_Click(object sender, EventArgs e)
        {
            if (start_AutoPost.Text == "StopAutoPost")
            {
                start_AutoPost.Text = "StartAutoPost";
                timer1.Enabled = false;
            }
            else
            {
                start_AutoPost.Text = "StopAutoPost";
                timer1.Enabled = true;
                timer1.Interval = 3000 + r.Next(200, 1000);
            }
        }

        private void get_Comments_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            String s = WallBot.GetComments(user_id, listBox1.SelectedItem.ToString().Split('%')[0]);
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(s);
            XmlNodeList text = doc.GetElementsByTagName("text");
            for (int i = 0; i < text.Count; i++)
            {
                listBox2.Items.Add(text[i].InnerXml);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for(int i = 0;i < 30;i++)
            {
                listBox1.Refresh();
                i++;
                if (i == 28)
                    i = 0;
            }
        }
    }
}
