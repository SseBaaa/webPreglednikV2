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

namespace webPreglednikV2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitChromium();
        }
        public ChromiumWebBrowser c;

        public void InitChromium()
        {
            Cef.Initialize(new CefSettings());

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

        private void btnBack_Click(object sender, EventArgs e)
        {
            c.Back();
        }

        private void btnFow_Click(object sender, EventArgs e)
        {
            c.Forward();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            c.Load(txtUrls.Text);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fowardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            c.Forward();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            c.Back();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            c.Load(txtUrlss.Text);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            c.Back();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            c.Forward();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
