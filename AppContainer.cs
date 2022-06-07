using System;
using EasyTabs;
using CefSharp;
using CefSharp.WinForms;

namespace webPreglednikV2
{
    public partial class AppContainer : TitleBarTabs
    {
        public AppContainer()
        {
            InitializeComponent();
            InitChromium();

            AeroPeekEnabled = true;
            TabRenderer = new ChromeTabRenderer(this);
        }
        public ChromiumWebBrowser c;
        public void InitChromium()
        {

            Cef.Initialize(new CefSettings());

            c = new ChromiumWebBrowser("www.google.hr");
            c.AddressChanged += C_AddressChanged;
            c.TitleChanged += C_TitleChanged;
            
            CheckForIllegalCrossThreadCalls = false;

        }
        private void C_TitleChanged(object sender, TitleChangedEventArgs e)
        {
            this.Text = e.Title;
        }

        private void C_AddressChanged(object sender, AddressChangedEventArgs e)
        {
            
        }

        public override TitleBarTab CreateTab() => new TitleBarTab(this)
        {
            Content = new Form1
            {
                Text = "new tab"
            }
        };
        private void AppContainer_Load(object sender, EventArgs e)
        {


        }

    }
}
 




    
    

