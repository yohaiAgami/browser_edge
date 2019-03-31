using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Browser_Eadge
{
    public partial class Form1 : Form
    {


        EventsForm eventsForm;
        public Form1()
        {
            InitializeComponent();
            webBrowser1.Settings.IsScriptNotifyAllowed = true;
            webBrowser1.Settings.IsJavaScriptEnabled = true;

            // The following events are not visible in the designer, so 
            // you must associate them with their event-handlers in code.


            // Load the user's home page.
            webBrowser1.Navigate(new Uri("https://ynet.co.il/"));

            webBrowser1.FrameContentLoading += WebBrowser1_FrameContentLoading;


            




            //Document finished Loading
            webBrowser1.DOMContentLoaded += WebBrowser1_DOMContentLoaded;

            //When starting to navigate
            webBrowser1.NavigationStarting += WebBrowser1_NavigationStarting;

            //Navigation Completed
            webBrowser1.NavigationCompleted += WebBrowser1_NavigationCompleted;


            //download file
            webBrowser1.UnviewableContentIdentified += WebBrowser1_UnviewableContentIdentified;

            webBrowser1.ContextMenuChanged += WebBrowser1_ContextMenuChanged;
            

            webBrowser1.ScriptNotify += WebBrowser1_ScriptNotify;




            eventsForm = new EventsForm();

            eventsForm.Show();
            

        }

        private void WebBrowser1_NavigationCompleted(object sender, Microsoft.Toolkit.Win32.UI.Controls.Interop.WinRT.WebViewControlNavigationCompletedEventArgs e)
        {
            eventsForm.notifyEvent("end navigation to: " + e.Uri.AbsoluteUri.ToString());
        }


        private void WebBrowser1_UnviewableContentIdentified(object sender, Microsoft.Toolkit.Win32.UI.Controls.Interop.WinRT.WebViewControlUnviewableContentIdentifiedEventArgs e)
        {

            var wc = new WebClient();




            wc.Headers.Add("Accept" , "text/html,application/xhtml+xml,application/xml, application/zip;q=0.9,*/*;q=0.8");

            wc.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/537.1 (KHTML, like Gecko)");



            var fileNameToSave = e.Uri.Segments.Last();
            saveFileDialog1.FileName = fileNameToSave;
            var fileEnding = fileNameToSave.Split('.').Last();





            

            // Set the file dialog to filter for graphics files.
            this.saveFileDialog1.Filter =
                $"File (*.{fileEnding})|*.{fileEnding}|All files (*.*)|*.*";

            var fileurl =
            e.Uri.AbsoluteUri;

            eventsForm.notifyEvent("new file download request : " + e.Uri.AbsoluteUri);

            // Allow the user to select multiple images.

            this.saveFileDialog1.Title = "Save File Location";

            this.saveFileDialog1.ShowDialog();
            var filelocation = saveFileDialog1.FileName;

            wc.DownloadFile(fileurl, filelocation);
        }

        //When starting to navigate
        private void WebBrowser1_NavigationStarting(object sender, Microsoft.Toolkit.Win32.UI.Controls.Interop.WinRT.WebViewControlNavigationStartingEventArgs e)
        {
            eventsForm.notifyEvent("start navigation to: " + e.Uri.AbsoluteUri);
            
        }


        

        private void WebBrowser1_ScriptNotify(object sender, Microsoft.Toolkit.Win32.UI.Controls.Interop.WinRT.WebViewControlScriptNotifyEventArgs e)
        {


            eventsForm.notifyEvent("called from javascript, value to show in message box : " + e.Value);
            MessageBox.Show(e.Value);
        }

        private void WebBrowser1_FrameContentLoading(object sender, Microsoft.Toolkit.Win32.UI.Controls.Interop.WinRT.WebViewControlContentLoadingEventArgs e)
        {
            string script = @"function magicNumber(return 8);";
            
        }

        private void WebBrowser1_ContextMenuChanged(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }




        private async void WebBrowser1_DOMContentLoaded(object sender, Microsoft.Toolkit.Win32.UI.Controls.Interop.WinRT.WebViewControlDOMContentLoadedEventArgs e)
        {
            eventsForm.notifyEvent("finish content loading of: " + e.Uri.AbsoluteUri.ToString());
        }



        // Selects all the text in the text box when the user clicks it. 
        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            toolStripTextBox1.SelectAll();
        }

        // Navigates to the URL in the address box when 
        // the ENTER key is pressed while the ToolStripTextBox has focus.
        private void toolStripTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Navigate(toolStripTextBox1.Text);
            }
        }

        // Navigates to the URL in the address box when 
        // the Go button is clicked.
        private void goButton_Click(object sender, EventArgs e)
        {
            Thread.Sleep(5000);
            //Navigate(toolStripTextBox1.Text);

        }

        // Navigates to the given URL if it is valid.
        private void Navigate(String address)
        {
            if (String.IsNullOrEmpty(address)) return;
            if (address.Equals("about:blank")) return;
            if (!address.StartsWith("http://") &&
                !address.StartsWith("https://"))
            {
                address = "http://" + address;
            }
            try
            {
                webBrowser1.Navigate(new Uri(address));
            }
            catch (System.UriFormatException)
            {
                return;
            }
        }

      

        // Updates the title bar with the current document title.
        private void webBrowser1_DocumentTitleChanged(object sender, EventArgs e)
        {
            this.Text = webBrowser1.DocumentTitle;
        }

        // Exits the application.
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            webBrowser1.Stop();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private async void btnCallJavaScript_Click(object sender, EventArgs e)
        {
            eventsForm.notifyEvent("called from csharp, navigate to: cnn");
            try
                {
                    string functionString = "function navigateToCnnWhenGoingToYnet(){ window.location.href = 'https://edition.cnn.com/';}";
                    await webBrowser1.InvokeScriptAsync("eval", new string[] { functionString });
                    await webBrowser1.InvokeScriptAsync("eval", new string[] { "navigateToCnnWhenGoingToYnet();" });
                }
                catch (Exception)
                {

                }

            
        }

        private async void  toolStripButton1_Click(object sender, EventArgs e)
        {
            await webBrowser1.InvokeScriptAsync("eval", new string[] { "window.external.notify(\"Hello World\")" });
        }
    }
}
