using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZooManagementSystemGW;

namespace ZooManagementSystemGW
{
    public partial class Form1 : Form
    {

        bool mouseDown;
        private Point offset;


        public string Username;

        public Form1()
        {
            InitializeComponent();
        }

        private void topPnl_MouseDown(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mouseDown = true;
        }

        private void topPnl_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown == true)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - offset.X, currentScreenPos.Y - offset.Y);
            }
        }

        private void topPnl_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            Username = username1.Text;
            Employee emp = new Employee(username1.Text, password1.Text);
            bool result = emp.CheckEmployee();
            if (result == true)
            {
                MainForm mainForm = new MainForm();
                mainForm.usern = username1.Text;
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect, check your username and password");
            }
        }
    }
}
