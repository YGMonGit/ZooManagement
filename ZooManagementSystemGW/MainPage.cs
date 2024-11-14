using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZooManagementSystemGW.Properties;

namespace ZooManagementSystemGW
{
    public partial class MainPage : Form
    {

        bool mouseDown;
        private Point offset;

        public string usern; 

        public MainPage()
        {
            InitializeComponent();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MaxBtn_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
                MaxBtn.Image = Resources.NormalScreen;
            }
            else
            {
                WindowState = FormWindowState.Normal;
                MaxBtn.Image = Resources.FullScreen;
            }
        }

        private void MinBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pnlTop_MouseDown(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mouseDown = true;
        }

        private void pnlTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown == true)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - offset.X, currentScreenPos.Y - offset.Y);
            }
        }

        private void pnlTop_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        public class ColorTable : ProfessionalColorTable
        {
            Color hoverColor = Color.FromArgb(44, 44, 44);
            Color pressedColor = Color.FromArgb(66, 66, 66);

            public override Color MenuBorder
            {
                get { return pressedColor; }
            }

            public override Color MenuItemBorder
            {
                get { return hoverColor; }
            }

            public override Color ToolStripDropDownBackground
            {
                get { return pressedColor; }
            }

            public override Color MenuItemSelected
            {
                get { return hoverColor; }
            }

            public override Color MenuItemSelectedGradientBegin
            {
                get { return hoverColor; }
            }

            public override Color MenuItemSelectedGradientEnd
            {
                get { return hoverColor; }
            }

            public override Color MenuItemPressedGradientBegin
            {
                get { return pressedColor; }
            }

            public override Color MenuItemPressedGradientMiddle
            {
                get { return pressedColor; }
            }

            public override Color MenuItemPressedGradientEnd
            {
                get { return pressedColor; }
            }

            public override Color ImageMarginGradientEnd
            {
                get { return pressedColor; }
            }
        }

        public void MainPage_Load(object sender, EventArgs e)
        {
            menuStrip1.Renderer = new ToolStripProfessionalRenderer(new ColorTable());
            lblUserName.Text = usern;
        }

        private void insertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeInsert ei = new EmployeeInsert() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnlBd.Controls.Clear();
            this.pnlBd.Controls.Add(ei);
            ei.Show();
        }

        private void HomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.pnlBd.Controls.Clear();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeUpdate eu = new EmployeeUpdate() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnlBd.Controls.Clear();
            this.pnlBd.Controls.Add(eu);
            eu.Show();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeDelete ed = new EmployeeDelete() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnlBd.Controls.Clear();
            this.pnlBd.Controls.Add(ed);
            ed.Show();
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeSearch es = new EmployeeSearch() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnlBd.Controls.Clear();
            this.pnlBd.Controls.Add(es);
            es.Show();
        }

        private void insertToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AnimalInsert ai = new AnimalInsert() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnlBd.Controls.Clear();
            this.pnlBd.Controls.Add(ai);
            ai.Show();
        }

        private void updateToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AnimalUpdate au = new AnimalUpdate() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnlBd.Controls.Clear();
            this.pnlBd.Controls.Add(au);
            au.Show();
        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AnimalDelete ad = new AnimalDelete() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnlBd.Controls.Clear();
            this.pnlBd.Controls.Add(ad);
            ad.Show();
        }

        private void viewToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AnimalSearch av = new AnimalSearch() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnlBd.Controls.Clear();
            this.pnlBd.Controls.Add(av);
            av.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ticketingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TicketingPage ti = new TicketingPage() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnlBd.Controls.Clear();
            this.pnlBd.Controls.Add(ti);
            ti.username = lblUserName.Text;
            ti.Show();
        }

        private void rToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrisePerTimeDiff pd = new PrisePerTimeDiff() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnlBd.Controls.Clear();
            this.pnlBd.Controls.Add(pd);
            pd.Show();
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RecordPerTime rt = new RecordPerTime() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnlBd.Controls.Clear();
            this.pnlBd.Controls.Add(rt);
            rt.Show();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FoodInsert fi = new FoodInsert() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnlBd.Controls.Clear();
            this.pnlBd.Controls.Add(fi);
            fi.username = lblUserName.Text;
            fi.Show();
        }

        private void updateToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FoodUpdate fd = new FoodUpdate() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnlBd.Controls.Clear();
            this.pnlBd.Controls.Add(fd);
            fd.Show();
        }

        private void removeToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DeleteFood df = new DeleteFood() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnlBd.Controls.Clear();
            this.pnlBd.Controls.Add(df);
            df.Show();
        }
    }
}
