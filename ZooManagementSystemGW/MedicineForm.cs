using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZooManagementSystemGW
{
    public partial class MedicineForm : Form
    {
        public MedicineForm()
        {
            InitializeComponent();
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            string expireDate;
            expireDate = cbxY.Text + '-' + cbxM.Text + '-' + cbxD.Text;

            Medicine m = new Medicine(txtN.Text, txtD.Text, expireDate);
            m.InsertMedicine();
            txtId.Clear();
            txtN.Clear();
            txtD.Clear();
            cbxY.Text = "Year";
            cbxM.Text = "Month";
            cbxD.Text = "Day";
        }

        private void btnU_Click(object sender, EventArgs e)
        {
            string expireDate;
            expireDate = cbxY.Text + '-' + cbxM.Text + '-' + cbxD.Text;

            Medicine m = new Medicine(txtId.Text, txtN.Text, txtD.Text, expireDate);
            m.UpdateMedicine();
            txtId.Clear();
            txtN.Clear();
            txtD.Clear();
            cbxY.Text = "Year";
            cbxM.Text = "Month";
            cbxD.Text = "Day";
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            Medicine m = new Medicine(txtId.Text);
            m.DeleteMedicine();
            txtId.Clear();
            txtN.Clear();
            txtD.Clear();
            cbxY.Text = "Year";
            cbxM.Text = "Month";
            cbxD.Text = "Day";
        }
    }
}
