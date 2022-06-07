using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyTabs;

namespace webPreglednikV2
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // promjena bzvz 

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            AppContainer container = new AppContainer();

            container.Tabs.Add
                (
                new TitleBarTab(container)
                {
                    Content = new Form1
                    {
                        Text = "new tab"
                       
                    }
                }
            );

            container.SelectedTabIndex = 0;

            TitleBarTabsApplicationContext applicationcontext = new TitleBarTabsApplicationContext();
            applicationcontext.Start(container);
            Application.Run(applicationcontext);
        }
    }
}
