using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hope
{
    public partial class frmStatus : Form
    {
        public frmStatus()
        {
            InitializeComponent();
        }

        private void frmStatus_Load(object sender, EventArgs e)
        {
            Properties.Settings settings = new Properties.Settings();
            btnCreate.Enabled = !settings.IsCreatDataBase;
            btnSalveFile.Enabled = settings.IsCreatDataBase;
            btnLoad.Enabled = settings.IsCreatDataBase;
            dateTimePicker1.Value = settings.DateCreatDataBase;
            settings = null;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo info = new System.Diagnostics.ProcessStartInfo();
            info.UseShellExecute = false;
            info.RedirectStandardOutput = true;
            info.RedirectStandardError = true;
            info.CreateNoWindow = true;
            info.FileName = "SqlLocalDB.exe";
            info.Arguments = "Info";
            info.LoadUserProfile = true;
            
          System.Diagnostics.Process o= System.Diagnostics.Process.Start(info);
            o.WaitForExit(1000);
            System.IO.StreamReader streamReader = o.StandardOutput;
           string result= streamReader.ReadToEnd();
        }

        private string CreateDBOffice = "CREATE DATABASE Office";
        private string CreateDBPos = "CREATE DATABASE Pos";
    }
}
