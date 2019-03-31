using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Browser_Eadge
{
    public partial class EventsForm : Form
    {
        public EventsForm()
        {
            InitializeComponent();
        }


        public void notifyEvent(string eventText) {

            richTextBox1.AppendText(eventText + "\n");
        }
    }
}
