using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration;

namespace 不需要App組態檔
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(Application.StartupPath + "\\需要App組態檔.exe");
            //讀取ConnectionStrings內資料
            label1.Text = config.ConnectionStrings.ConnectionStrings["Test4"].ToString();
            //讀取AppSettings內資料
            label2.Text = config.AppSettings.Settings["Test2"].Value;
            label3.Text = config.AppSettings.Settings["Test3"].Value; 
        }
    }
}