using CefSharp;
using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyTabs;

namespace webPreglednikV2
{
    public partial class Form1 : Form
    {
        protected TitleBarTabs ParentTabs
        {
            get
            {
                return (ParentForm as TitleBarTabs);
            }
        }
        public Form1()
        {
            InitializeComponent();
            InitChromium();
        }

    public ChromiumWebBrowser c;
    public void InitChromium()
        {
            if (!Cef.IsInitialized) // Check before init
            {
                CefSettings settings = new CefSettings();
                Cef.Initialize(settings);
            }

            c = new ChromiumWebBrowser("www.google.hr");
            c.AddressChanged += C_AddressChanged;
            c.TitleChanged += C_TitleChanged;
            this.panel1.Controls.Add(c);
            CheckForIllegalCrossThreadCalls = false;
            
        }

        private void C_TitleChanged(object sender, TitleChangedEventArgs e)
        {
            this.Text = e.Title;
        }

        private void C_AddressChanged(object sender, AddressChangedEventArgs e)
        {
            txtUrls.Text = e.Address.ToString();
        }

        private void chromiumWebBrowser1_LoadingStateChanged(object sender, CefSharp.LoadingStateChangedEventArgs e)
        {

        }

        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            c.Load(txtUrls.Text);
        }

        private void btnFoward_Click(object sender, EventArgs e)
        {
            c.Forward();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            c.Back();
        }

        private void btnName_Click(object sender, EventArgs e)
        {
            c.Load("www.google.hr");
           
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            c.Load(txtUrls.Text);
        }

        private void btnBook_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            c.Load(txtUrls.Text);
        }
    }
}
