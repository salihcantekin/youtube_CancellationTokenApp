using CancellationTokenApp.Desktop.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CancellationTokenApp.Desktop
{
    public partial class Form1 : Form
    {
        CancellationTokenSource cts;
        CancellationToken token;

        CancellationTokenSource ctsSleep;
        CancellationToken tokenSleep;

        CancellationTokenSource ctsData;
        CancellationToken tokenData;

        public Form1()
        {
            InitializeComponent();

            cts = new CancellationTokenSource();
            token = cts.Token;

            ctsSleep = new CancellationTokenSource();
            tokenSleep = ctsSleep.Token;

            ctsData = new CancellationTokenSource();
            tokenData = ctsData.Token;
        }




        private void AddLog(string logStr)
        {
            logStr = $"[{DateTime.Now:dd.MM.yyyy HH:mm:ss}] - {logStr}";
            lbLogs.Items.Add(logStr);
            lbLogs.TopIndex = lbLogs.Items.Count - 1;
        }

        private async void btnStartApp_Click(object sender, EventArgs e)
        {
            AddLog("App Started");

            int checkTime = (int)numericCheckTime.Value;

            while (token.IsCancellationRequested)
            {
                try
                {
                    //token.ThrowIfCancellationRequested();

                    AddLog("Checking emails");
                    await CheckEmails();

                    AddLog("Waiting for the next check time");
                    await SmartSleep(checkTime);
                }
                catch (OperationCanceledException)
                {
                    break;
                }
            }

            AddLog("App shutting down");

        }

        private async Task CheckEmails()
        {
            MyDbContext db = new MyDbContext();
            await db.GetAllMails(tokenData);
            // sent emails
        }


        private async Task SmartSleep(int second)
        {
            try
            {
                await Task.Delay(second * 1000, tokenSleep);
            }
            catch (OperationCanceledException)
            {

            }
        }

        private void btnStopApp_Click(object sender, EventArgs e)
        {
            cts.Cancel();
        }

        private void btnGettingData_Click(object sender, EventArgs e)
        {
            ctsData.Cancel();
        }

        private void btnCheckNow_Click(object sender, EventArgs e)
        {
            ctsSleep.Cancel();

            ctsSleep = new CancellationTokenSource();
            tokenSleep = ctsSleep.Token;
        }
    }
}
