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
    public partial class MainForm : Form
    {

        public int value = 230;

        public string usern;
        public MainForm()
        {
            InitializeComponent();
            PnlSubMenuE.Hide();
            PnlSubMenuA.Hide();
            PnlSubMenuT.Hide();
            PnlSubMenuF.Hide();
            PnlSubMenuC.Hide();
            PnlSubMenuHolder.Hide();
            pnlUser.Hide();
            pnlMainManu.BackColor = Color.FromArgb(value, 0, 0, 0);
            pnl.BackColor = Color.FromArgb(value, 0, 0, 0);
            cprogress.ProgressColor = Color.FromArgb(150, 150, 150);
            cprogress.ForeColor = Color.FromArgb(150, 150, 150);

        }

        private void btn_Click(object sender, EventArgs e)
        {
            pnlBody.Hide();
            PnlSubMenuHolder.Hide();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            lblUserName.Text = usern;
        }

        private void btnMe_Click(object sender, EventArgs e)
        {
            PnlSubMenuE.BackColor = Color.FromArgb(value, 0, 0, 0);
            PnlSubMenuA.Hide();
            PnlSubMenuT.Hide();
            PnlSubMenuF.Hide();
            PnlSubMenuC.Hide();
            PnlSubMenuHolder.Show();
            PnlSubMenuE.Show();
            pnl.Hide();
        }

        private void btnMa_Click(object sender, EventArgs e)
        {
            PnlSubMenuA.BackColor = Color.FromArgb(value, 0, 0, 0);
            PnlSubMenuE.Hide();
            PnlSubMenuT.Hide();
            PnlSubMenuF.Hide();
            PnlSubMenuC.Hide();
            PnlSubMenuHolder.Show();
            PnlSubMenuA.Show();
            pnl.Hide();
        }

        private void btnMt_Click(object sender, EventArgs e)
        {
            PnlSubMenuT.BackColor = Color.FromArgb(value, 0, 0, 0);
            PnlSubMenuA.Hide();
            PnlSubMenuE.Hide();
            PnlSubMenuF.Hide();
            PnlSubMenuC.Hide();
            PnlSubMenuHolder.Show();
            PnlSubMenuT.Show();
            pnl.Hide();
        }

        private void btnMf_Click(object sender, EventArgs e)
        {
            PnlSubMenuF.BackColor = Color.FromArgb(value, 0, 0, 0);
            PnlSubMenuA.Hide();
            PnlSubMenuT.Hide();
            PnlSubMenuE.Hide();
            PnlSubMenuC.Hide();
            PnlSubMenuHolder.Show();
            PnlSubMenuF.Show();
            pnl.Hide();
        }

        private void btnMc_Click(object sender, EventArgs e)
        {
            PnlSubMenuC.BackColor = Color.FromArgb(value, 0, 0, 0);
            PnlSubMenuA.Hide();
            PnlSubMenuT.Hide();
            PnlSubMenuE.Hide();
            PnlSubMenuE.Hide();
            PnlSubMenuHolder.Show();
            PnlSubMenuC.Show();
            pnl.Hide();
        }

        private void btnEI_Click(object sender, EventArgs e)
        {
            EmployeeInsert ei = new EmployeeInsert() {Dock = DockStyle.Fill, TopLevel = false, TopMost = true};
            this.pnlBody.Controls.Clear();
            this.pnlBody.Show();
            this.pnlBody.Controls.Add(ei.pnl);
            ei.pnl.BackColor = Color.FromArgb(value, 0, 0, 0);
            //PnlSubMenuHolder.Hide();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEU_Click(object sender, EventArgs e)
        {
            //timer1.Start();
            //PnlSubMenuHolder.Hide();
            //this.pnlBody.Hide();
            EmployeeUpdate eu = new EmployeeUpdate() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnlBody.Controls.Clear();
            this.pnlBody.Hide();
            this.pnlBody.Controls.Add(eu.PnlP);
            eu.PnlP.BackColor = Color.FromArgb(value, 0, 0, 0);
            this.pnlBody.Show();

        }

        private void btnED_Click(object sender, EventArgs e)
        {
            //PnlSubMenuHolder.Hide();
            EmployeeDelete ed = new EmployeeDelete() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnlBody.Controls.Clear();
            this.pnlBody.Hide();
            this.pnlBody.Controls.Add(ed.pnlP);
            ed.pnlP.BackColor = Color.FromArgb(value, 0, 0, 0);
            this.pnlBody.Show();
        }

        private void btnEV_Click(object sender, EventArgs e)
        {
           // PnlSubMenuHolder.Hide();
            EmployeeSearch es = new EmployeeSearch() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnlBody.Controls.Clear();
            this.pnlBody.Hide();
            this.pnlBody.Controls.Add(es.pnlP);
            es.pnlP.BackColor = Color.FromArgb(value, 0, 0, 0);
            this.pnlBody.Show();
        }

        private void btnAI_Click(object sender, EventArgs e)
        {
            //PnlSubMenuHolder.Hide();
            AnimalInsert ai = new AnimalInsert() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnlBody.Controls.Clear();
            this.pnlBody.Hide();
            this.pnlBody.Controls.Add(ai.pnl); 
            ai.pnl.BackColor = Color.FromArgb(value, 0, 0, 0);
            this.pnlBody.Show();
            ai.txtaName.Enabled = false;
            ai.txtaName.Enabled = true;
            ai.txtaType.Enabled = false;
            ai.txtaType.Enabled = true;
            ai.txtFood.Enabled = false;
            ai.txtFood.Enabled = true;
        }

        private void btnAU_Click(object sender, EventArgs e)
        {
            //PnlSubMenuHolder.Hide();
            AnimalUpdate au = new AnimalUpdate() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnlBody.Controls.Clear();
            this.pnlBody.Hide();
            this.pnlBody.Controls.Add(au.pnl);
            au.pnl.BackColor = Color.FromArgb(value, 0, 0, 0);
            this.pnlBody.Show();
            au.txtFood.Enabled = false;
            au.txtFood.Enabled = true;
            au.txtId.Enabled = false;
            au.txtId.Enabled = true;
        }

        private void btnAD_Click(object sender, EventArgs e)
        {
            //PnlSubMenuHolder.Hide();
            AnimalDelete ad = new AnimalDelete() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnlBody.Controls.Clear();
            this.pnlBody.Hide();
            this.pnlBody.Controls.Add(ad.pnl);
            ad.pnl.BackColor = Color.FromArgb(value, 0, 0, 0);
            this.pnlBody.Show();
            ad.txtId.Enabled = false;
            ad.txtId.Enabled = true;
        }

        private void btnAV_Click(object sender, EventArgs e)
        {
            //PnlSubMenuHolder.Hide();
            AnimalSearch av = new AnimalSearch() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnlBody.Controls.Clear();
            this.pnlBody.Hide();
            this.pnlBody.Controls.Add(av.pnlP);
            av.pnlP.BackColor = Color.FromArgb(value, 0, 0, 0);
            this.pnlBody.Show();
        }

        private void btnTik_Click(object sender, EventArgs e)
        {
            //PnlSubMenuHolder.Hide();
            TicketingPage ti = new TicketingPage() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnlBody.Controls.Clear();
            this.pnlBody.Hide();
            this.pnlBody.Controls.Add(ti.pnl);
            ti.username = lblUserName.Text;
            ti.pnl.BackColor = Color.FromArgb(value, 0, 0, 0);
            this.pnlBody.Show();
            ti.txtA.Enabled = false;
            ti.txtA.Enabled = true;
        }

        private void BtnProf_Click(object sender, EventArgs e)
        {
            //PnlSubMenuHolder.Hide();
            PrisePerTimeDiff pd = new PrisePerTimeDiff() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnlBody.Controls.Clear();
            this.pnlBody.Hide();
            this.pnlBody.Controls.Add(pd.pnl);
            pd.pnl.BackColor = Color.FromArgb(value, 0, 0, 0);
            this.pnlBody.Show();
        }

        private void btnRep_Click(object sender, EventArgs e)
        {
            //PnlSubMenuHolder.Hide();
            RecordPerTime rt = new RecordPerTime() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnlBody.Controls.Clear();
            this.pnlBody.Hide();
            this.pnlBody.Controls.Add(rt.pnl);
            rt.pnl.BackColor = Color.FromArgb(value, 0, 0, 0);
            this.pnlBody.Show();
        }

        private void btnFA_Click(object sender, EventArgs e)
        {
            //PnlSubMenuHolder.Hide();
            FoodInsert fi = new FoodInsert() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnlBody.Controls.Clear();
            this.pnlBody.Hide();
            this.pnlBody.Controls.Add(fi.pnl);
            fi.username = lblUserName.Text;
            fi.pnl.BackColor = Color.FromArgb(value, 0, 0, 0);
            this.pnlBody.Show();
            fi.txtFn.Enabled = false;
            fi.txtFn.Enabled = true;
            fi.txtA.Enabled = false;
            fi.txtA.Enabled = true;
            fi.txtFpd.Enabled = false;
            fi.txtFpd.Enabled = true;
        }

        private void btnFU_Click(object sender, EventArgs e)
        {
            //PnlSubMenuHolder.Hide();
            FoodUpdate fd = new FoodUpdate() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnlBody.Controls.Clear();
            this.pnlBody.Hide();
            this.pnlBody.Controls.Add(fd.pnl);
            fd.pnl.BackColor = Color.FromArgb(value, 0, 0, 0);
            this.pnlBody.Show();
            fd.txtId.Enabled = false;
            fd.txtId.Enabled = true;
            fd.txtFn.Enabled = false;
            fd.txtFn.Enabled = true;
            fd.txtA.Enabled = false;
            fd.txtA.Enabled = true;
            fd.txtFpd.Enabled = false;
            fd.txtFpd.Enabled = true;
            fd.txtDb.Enabled = false;
            fd.txtDb.Enabled = true;
        }

        private void btnFR_Click(object sender, EventArgs e)
        {
            //PnlSubMenuHolder.Hide();
            DeleteFood df = new DeleteFood() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnlBody.Controls.Clear();
            this.pnlBody.Hide();
            this.pnlBody.Controls.Add(df.pnl);
            df.pnl.BackColor = Color.FromArgb(value, 0, 0, 0);
            this.pnlBody.Show();
            df.txtID.Enabled = false;
            df.txtID.Enabled = true;
        }

        private void btnFV_Click(object sender, EventArgs e)
        {
            FoodTableView fv = new FoodTableView() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnlBody.Controls.Clear();
            this.pnlBody.Hide();
            this.pnlBody.Controls.Add(fv.pnl);
            fv.pnl.BackColor = Color.FromArgb(value, 0, 0, 0);
            this.pnlBody.Show();
        }

        private void btnCUI_Click(object sender, EventArgs e)
        {
            CheckUpInsert ci = new CheckUpInsert() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnlBody.Controls.Clear();
            this.pnlBody.Hide();
            this.pnlBody.Controls.Add(ci.pnl);
            ci.username = lblUserName.Text;
            ci.pnl.BackColor = Color.FromArgb(value, 0, 0, 0);
            this.pnlBody.Show();
            ci.txtAT.Enabled = false;
            ci.txtAT.Enabled = true;
            ci.txtM.Enabled = false;
            ci.txtM.Enabled = true;
        }

        private void btnCUU_Click(object sender, EventArgs e)
        {
            CheckUpUpdate cu = new CheckUpUpdate() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnlBody.Controls.Clear();
            this.pnlBody.Hide();
            this.pnlBody.Controls.Add(cu.pnl);
            cu.username = lblUserName.Text;
            cu.pnl.BackColor = Color.FromArgb(value, 0, 0, 0);
            this.pnlBody.Show();
            cu.txtId.Enabled = false;
            cu.txtId.Enabled = true;
            cu.txtAT.Enabled = false;
            cu.txtAT.Enabled = true;
            cu.txtM.Enabled = false;
            cu.txtM.Enabled = true;
        }

        private void btnCUD_Click(object sender, EventArgs e)
        {
            CheckUpDelete cd = new CheckUpDelete() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnlBody.Controls.Clear();
            this.pnlBody.Hide();
            this.pnlBody.Controls.Add(cd.pnl);
            cd.pnl.BackColor = Color.FromArgb(value, 0, 0, 0);
            this.pnlBody.Show();
            cd.txtId.Enabled = false;
            cd.txtId.Enabled = true;
        }

        private void btnCUV_Click(object sender, EventArgs e)
        {
            CheckUpView cv = new CheckUpView() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnlBody.Controls.Clear();
            this.pnlBody.Hide();
            this.pnlBody.Controls.Add(cv.pnlP);
            cv.pnlP.BackColor = Color.FromArgb(value, 0, 0, 0);
            this.pnlBody.Show();
        }

        private void btnCUA_Click(object sender, EventArgs e)
        {
            MedicineForm mf = new MedicineForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnlBody.Controls.Clear();
            this.pnlBody.Hide();
            this.pnlBody.Controls.Add(mf.pnl);
            mf.pnl.BackColor = Color.FromArgb(value, 0, 0, 0);
            DataTable dt = new DataTable();
            Medicine m = new Medicine();
            dt = m.ViewMedicine();
            mf.tableView.DataSource = dt;
            this.pnlBody.Show();
            mf.txtId.Enabled = false;
            mf.txtId.Enabled = true;
            mf.txtN.Enabled = false;
            mf.txtN.Enabled = true;
            mf.txtD.Enabled = false;
            mf.txtD.Enabled = true;
        }

        private void btnUprise_Click(object sender, EventArgs e)
        {
            TicketPriceUpdate pu = new TicketPriceUpdate() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnlBody.Controls.Clear();
            this.pnlBody.Hide();
            this.pnlBody.Controls.Add(pu.pnl);
            pu.pnl.BackColor = Color.FromArgb(value, 0, 0, 0);
            this.pnlBody.Show();
        }

        private void btnLO_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.Show();
        }

        private void btnUB_Click(object sender, EventArgs e)
        {
            pnlBody.Hide();
            pnlBody.Controls.Clear();
            pnlBody.Controls.Add(pnlUser);
            PnlSubMenuHolder.Hide();
            pnlBody.Show();
            pnlUser.Show();
            pnlUser.BackColor = Color.FromArgb(value, 0, 0, 0);
            pnlBody.Show();
        }

        private void btnDash_Click(object sender, EventArgs e)
        {
            PnlSubMenuHolder.Hide();
            pnlBody.Controls.Clear();
            pnlBody.Hide();
            pnlBody.Controls.Add(pnl);
            pnl.BackColor = Color.FromArgb(value, 0, 0, 0);
            pnl.Show();
            pnlBody.Show();
        }

        private void btnDLeft_Click(object sender, EventArgs e)
        {
            if (pnlProgress.Width > 150)
                pnlProgress.Width = 150;
            else if (pnlProgress.Width > 100)
                pnlProgress.Width = 100;
            else
                pnlProgress.Width = 60;

            if ((pnlProgress.Width / 2) >= 30)
            {
                cprogress.Value = pnlProgress.Width / 2;
                cprogress.Text = (pnlProgress.Width / 2).ToString() + "%";
                value = (cprogress.Value * 255) / 100;
                this.pnl.BackColor = Color.FromArgb(value, 0, 0, 0);
                this.pnlMainManu.BackColor = Color.FromArgb(value, 0, 0, 0);
            }

            if (cprogress.Value == 30 || cprogress.Value == 90)
            {
                cprogress.ProgressColor = Color.FromArgb(150, 150, 150);
                cprogress.ForeColor = Color.FromArgb(150, 150, 150);
            }
            else
            {
                cprogress.ProgressColor = Color.White;
                cprogress.ForeColor = Color.White;
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if ((pnlProgress.Width - 10) >= 60)
                pnlProgress.Width -= 10;
            else
                pnlProgress.Width = 60;

            if ((pnlProgress.Width / 2) >= 30)
            {
                cprogress.Value = pnlProgress.Width / 2;
                cprogress.Text = (pnlProgress.Width / 2).ToString() + "%";
                value = (cprogress.Value * 255) / 100;
                this.pnl.BackColor = Color.FromArgb(value, 0, 0, 0);
                this.pnlMainManu.BackColor = Color.FromArgb(value, 0, 0, 0);
            }

            if (cprogress.Value == 30 || cprogress.Value == 90)
            {
                cprogress.ProgressColor = Color.FromArgb(150, 150, 150);
                cprogress.ForeColor = Color.FromArgb(150, 150, 150);
            }
            else
            {
                cprogress.ProgressColor = Color.White;
                cprogress.ForeColor = Color.White;
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if ((pnlProgress.Width + 10) <= 180)
                pnlProgress.Width += 10;
            else
                pnlProgress.Width = 180;

            if ((pnlProgress.Width / 2) <= 90)
            {
                cprogress.Value = pnlProgress.Width / 2;
                cprogress.Text = (pnlProgress.Width / 2).ToString() + "%";
                value = (cprogress.Value * 255) / 100;
                this.pnl.BackColor = Color.FromArgb(value, 0, 0, 0);
                this.pnlMainManu.BackColor = Color.FromArgb(value, 0, 0, 0);
            }

            if (cprogress.Value == 30 || cprogress.Value == 90)
            {
                cprogress.ProgressColor = Color.FromArgb(150, 150, 150);
                cprogress.ForeColor = Color.FromArgb(150, 150, 150);
            }
            else
            {
                cprogress.ProgressColor = Color.White;
                cprogress.ForeColor = Color.White;
            }
        }

        private void btnDright_Click(object sender, EventArgs e)
        {
            if (pnlProgress.Width < 100)
                pnlProgress.Width = 100;
            else if (pnlProgress.Width < 150)
                pnlProgress.Width = 150;
            else
                pnlProgress.Width = 180;

            if ((pnlProgress.Width / 2) <= 90)
            {
                cprogress.Value = pnlProgress.Width / 2;
                cprogress.Text = (pnlProgress.Width / 2).ToString() + "%";
                value = (cprogress.Value * 255) / 100;
                this.pnl.BackColor = Color.FromArgb(value, 0, 0, 0);
                this.pnlMainManu.BackColor = Color.FromArgb(value, 0, 0, 0);
            }

            if(cprogress.Value == 30 || cprogress.Value == 90)
            {
                cprogress.ProgressColor = Color.FromArgb(150, 150, 150);
                cprogress.ForeColor = Color.FromArgb(150, 150, 150);
            }
            else
            {
                cprogress.ProgressColor = Color.White;
                cprogress.ForeColor = Color.White;
            }
        }
    }
}
