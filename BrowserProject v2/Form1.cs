using CefSharp;
using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrowserProject_v1
{
    public partial class Form1 : Form
    {
        string i;
        void repeat()
        {
         //   i = Convert.ToString(webBrowser1.Url);
        //    tb.Text = i;
     //   webBrowser1.Dock = DockStyle.Fill;

        }
        public Form1()
        {
            InitializeComponent();
        //    webBrowser1.ScriptErrorsSuppressed=true;
            repeat();

        }
        ChromiumWebBrowser browser;
        private void Form1_Load(object sender, EventArgs e)
        {
            
           tb.Text = Convert.ToString("https://duckduckgo.com/");
            browser = new ChromiumWebBrowser("https://duckduckgo.com/");
            browser.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(browser);
            repeat();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            browser.Back();
            repeat();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           browser.Forward();
            repeat();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            browser.Reload();
            browser.Refresh();
            repeat();
        }

        private void button4_Click(object sender, EventArgs e)
        {
  
        browser.Load(Convert.ToString(tb.Text));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            browser.Load("https://duckduckgo.com/");
            repeat();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Browser was created by Digital Serpant.\n\nBrowser Project is a light-weight browser that does not keep any data of any kind","About",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {             
                string r;
                browser.Load(Convert.ToString(tb.Text));
                r = Convert.ToString(tb.Text);
                tb.Text = r;
                repeat();
            }
        }
    }
}
