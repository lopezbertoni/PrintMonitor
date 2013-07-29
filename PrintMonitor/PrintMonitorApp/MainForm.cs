using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Printing;

namespace PrintMonitorApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnLoadPrinters_Click(object sender, EventArgs e)
        {
            var server = new PrintServer();
            var queues = server.GetPrintQueues();
            ddlPrinters.Items.Clear();
            ddlPrinters.Items.Add("Seleccionar...");
            foreach (var queue in queues)
            {
                ddlPrinters.Items.Add(queue.Name);
            }
            ddlPrinters.SelectedIndex = 0;
        }
    }
}
