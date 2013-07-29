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
            Cursor.Current = Cursors.WaitCursor;
            var server = new PrintServer();
            var queues = server.GetPrintQueues();
            ddlPrinters.Items.Clear();
            ddlPrinters.Items.Add("Seleccionar...");
            foreach (var queue in queues)
            {
                ddlPrinters.Items.Add(queue.Name);
            }
            ddlPrinters.SelectedIndex = 0;
            Cursor.Current = Cursors.Default;
        }

        private void btnLoadQueues_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            var jobList = String.Empty;

            var server = new PrintServer();
            var queues = server.GetPrintQueues();
            foreach (PrintQueue pq in queues)
            {
                pq.Refresh();
                PrintJobInfoCollection jobs = pq.GetPrintJobInfoCollection();
                foreach (PrintSystemJobInfo job in jobs)
                {
                    // Since the user may not be able to articulate which job is problematic,
                    // present information about each job the user has submitted.

                    jobList = jobList + "\nServer:\r\n";
                    jobList = jobList + "\n\tQueue:" + pq.Name;
                    jobList = jobList + "\n\tLocation:" + pq.Location;
                    jobList = jobList + "\n\t\tJob: " + job.JobName + " ID: " + job.JobIdentifier;

                } // end for each print job    

            }// end for each print queue
            txtStatus.Text = jobList;
            Cursor.Current = Cursors.Default;
        }
    }
}
