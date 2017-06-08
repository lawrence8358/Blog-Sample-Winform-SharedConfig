using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration;

namespace 需要App組態檔
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //直接讀取
            label1.Text = ConfigurationManager.ConnectionStrings["Test4"].ToString();
            label2.Text = ConfigurationManager.AppSettings["Test2"].ToString();
            label3.Text = ConfigurationManager.AppSettings["Test3"].ToString();
          
        }
    }
}