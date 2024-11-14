
namespace ZooManagementSystemGW
{
    partial class CheckUpView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnl = new System.Windows.Forms.Panel();
            this.tableView = new System.Windows.Forms.DataGridView();
            this.pnlP = new System.Windows.Forms.Panel();
            this.lbl0 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.igroup = new System.Windows.Forms.GroupBox();
            this.txtId = new ZBobb.AlphaBlendTextBox();
            this.e13 = new System.Windows.Forms.Panel();
            this.egroup = new System.Windows.Forms.GroupBox();
            this.txtE = new ZBobb.AlphaBlendTextBox();
            this.e10 = new System.Windows.Forms.Panel();
            this.tgroup = new System.Windows.Forms.GroupBox();
            this.txtTT = new ZBobb.AlphaBlendTextBox();
            this.e9 = new System.Windows.Forms.Panel();
            this.btnT = new System.Windows.Forms.Button();
            this.btnI = new System.Windows.Forms.Button();
            this.btnE = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableView)).BeginInit();
            this.pnlP.SuspendLayout();
            this.panel1.SuspendLayout();
            this.igroup.SuspendLayout();
            this.egroup.SuspendLayout();
            this.tgroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl
            // 
            this.pnl.Controls.Add(this.pnlP);
            this.pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl.Location = new System.Drawing.Point(0, 0);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(1100, 484);
            this.pnl.TabIndex = 0;
            // 
            // tableView
            // 
            this.tableView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.tableView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableView.Location = new System.Drawing.Point(0, 214);
            this.tableView.Name = "tableView";
            this.tableView.Size = new System.Drawing.Size(1100, 270);
            this.tableView.TabIndex = 126;
            // 
            // pnlP
            // 
            this.pnlP.Controls.Add(this.lbl0);
            this.pnlP.Controls.Add(this.tableView);
            this.pnlP.Controls.Add(this.panel1);
            this.pnlP.Controls.Add(this.btnT);
            this.pnlP.Controls.Add(this.btnI);
            this.pnlP.Controls.Add(this.btnE);
            this.pnlP.Controls.Add(this.lbl1);
            this.pnlP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlP.Location = new System.Drawing.Point(0, 0);
            this.pnlP.Name = "pnlP";
            this.pnlP.Size = new System.Drawing.Size(1100, 484);
            this.pnlP.TabIndex = 130;
            // 
            // lbl0
            // 
            this.lbl0.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl0.AutoSize = true;
            this.lbl0.BackColor = System.Drawing.Color.Transparent;
            this.lbl0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl0.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl0.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbl0.Location = new System.Drawing.Point(396, 17);
            this.lbl0.Name = "lbl0";
            this.lbl0.Size = new System.Drawing.Size(287, 42);
            this.lbl0.TabIndex = 84;
            this.lbl0.Text = "Check Up View";
            this.lbl0.Click += new System.EventHandler(this.lbl0_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.igroup);
            this.panel1.Controls.Add(this.egroup);
            this.panel1.Controls.Add(this.tgroup);
            this.panel1.Location = new System.Drawing.Point(378, 109);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(382, 69);
            this.panel1.TabIndex = 128;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // igroup
            // 
            this.igroup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.igroup.Controls.Add(this.txtId);
            this.igroup.Controls.Add(this.e13);
            this.igroup.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.igroup.Location = new System.Drawing.Point(22, -59);
            this.igroup.Name = "igroup";
            this.igroup.Size = new System.Drawing.Size(335, 55);
            this.igroup.TabIndex = 123;
            this.igroup.TabStop = false;
            this.igroup.Text = "ID";
            // 
            // txtId
            // 
            this.txtId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtId.BackAlpha = 0;
            this.txtId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.ForeColor = System.Drawing.Color.White;
            this.txtId.Location = new System.Drawing.Point(60, 15);
            this.txtId.Name = "txtId";
            this.txtId.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtId.Size = new System.Drawing.Size(244, 28);
            this.txtId.TabIndex = 140;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            // 
            // e13
            // 
            this.e13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.e13.BackColor = System.Drawing.SystemColors.ControlLight;
            this.e13.Location = new System.Drawing.Point(53, 44);
            this.e13.Name = "e13";
            this.e13.Size = new System.Drawing.Size(249, 1);
            this.e13.TabIndex = 115;
            // 
            // egroup
            // 
            this.egroup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.egroup.Controls.Add(this.txtE);
            this.egroup.Controls.Add(this.e10);
            this.egroup.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.egroup.Location = new System.Drawing.Point(24, 81);
            this.egroup.Name = "egroup";
            this.egroup.Size = new System.Drawing.Size(335, 55);
            this.egroup.TabIndex = 115;
            this.egroup.TabStop = false;
            this.egroup.Text = "Employee";
            // 
            // txtE
            // 
            this.txtE.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtE.BackAlpha = 0;
            this.txtE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtE.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtE.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtE.ForeColor = System.Drawing.Color.White;
            this.txtE.Location = new System.Drawing.Point(58, 15);
            this.txtE.Name = "txtE";
            this.txtE.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtE.Size = new System.Drawing.Size(244, 28);
            this.txtE.TabIndex = 141;
            this.txtE.TextChanged += new System.EventHandler(this.txtE_TextChanged);
            // 
            // e10
            // 
            this.e10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.e10.BackColor = System.Drawing.SystemColors.ControlLight;
            this.e10.Location = new System.Drawing.Point(53, 44);
            this.e10.Name = "e10";
            this.e10.Size = new System.Drawing.Size(249, 1);
            this.e10.TabIndex = 115;
            // 
            // tgroup
            // 
            this.tgroup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tgroup.Controls.Add(this.txtTT);
            this.tgroup.Controls.Add(this.e9);
            this.tgroup.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tgroup.Location = new System.Drawing.Point(22, 2);
            this.tgroup.Name = "tgroup";
            this.tgroup.Size = new System.Drawing.Size(335, 55);
            this.tgroup.TabIndex = 114;
            this.tgroup.TabStop = false;
            this.tgroup.Text = "Treatment Type";
            // 
            // txtTT
            // 
            this.txtTT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTT.BackAlpha = 0;
            this.txtTT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtTT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTT.ForeColor = System.Drawing.Color.White;
            this.txtTT.Location = new System.Drawing.Point(60, 15);
            this.txtTT.Name = "txtTT";
            this.txtTT.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTT.Size = new System.Drawing.Size(244, 28);
            this.txtTT.TabIndex = 141;
            this.txtTT.TextChanged += new System.EventHandler(this.txtTT_TextChanged);
            // 
            // e9
            // 
            this.e9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.e9.BackColor = System.Drawing.SystemColors.ControlLight;
            this.e9.Location = new System.Drawing.Point(53, 44);
            this.e9.Name = "e9";
            this.e9.Size = new System.Drawing.Size(249, 1);
            this.e9.TabIndex = 115;
            // 
            // btnT
            // 
            this.btnT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnT.BackColor = System.Drawing.Color.Transparent;
            this.btnT.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnT.ForeColor = System.Drawing.Color.White;
            this.btnT.Location = new System.Drawing.Point(462, 70);
            this.btnT.Name = "btnT";
            this.btnT.Size = new System.Drawing.Size(162, 33);
            this.btnT.TabIndex = 121;
            this.btnT.Text = "Treatment Type";
            this.btnT.UseVisualStyleBackColor = false;
            this.btnT.Click += new System.EventHandler(this.btnT_Click);
            // 
            // btnI
            // 
            this.btnI.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnI.BackColor = System.Drawing.Color.Transparent;
            this.btnI.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnI.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnI.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnI.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnI.ForeColor = System.Drawing.Color.White;
            this.btnI.Location = new System.Drawing.Point(399, 70);
            this.btnI.Name = "btnI";
            this.btnI.Size = new System.Drawing.Size(57, 33);
            this.btnI.TabIndex = 127;
            this.btnI.Text = "ID";
            this.btnI.UseVisualStyleBackColor = false;
            this.btnI.Click += new System.EventHandler(this.btnI_Click);
            // 
            // btnE
            // 
            this.btnE.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnE.BackColor = System.Drawing.Color.Transparent;
            this.btnE.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnE.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnE.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnE.ForeColor = System.Drawing.Color.White;
            this.btnE.Location = new System.Drawing.Point(630, 70);
            this.btnE.Name = "btnE";
            this.btnE.Size = new System.Drawing.Size(106, 33);
            this.btnE.TabIndex = 123;
            this.btnE.Text = "Employee";
            this.btnE.UseVisualStyleBackColor = false;
            this.btnE.Click += new System.EventHandler(this.btnE_Click);
            // 
            // lbl1
            // 
            this.lbl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.Transparent;
            this.lbl1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbl1.Location = new System.Drawing.Point(181, 62);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(171, 42);
            this.lbl1.TabIndex = 124;
            this.lbl1.Text = "View By:";
            this.lbl1.Click += new System.EventHandler(this.lbl1_Click);
            // 
            // CheckUpView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(1100, 484);
            this.Controls.Add(this.pnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CheckUpView";
            this.Text = "CheckUpView";
            this.pnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tableView)).EndInit();
            this.pnlP.ResumeLayout(false);
            this.pnlP.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.igroup.ResumeLayout(false);
            this.igroup.PerformLayout();
            this.egroup.ResumeLayout(false);
            this.egroup.PerformLayout();
            this.tgroup.ResumeLayout(false);
            this.tgroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel pnl;
        public System.Windows.Forms.Panel pnlP;
        private System.Windows.Forms.Label lbl0;
        private System.Windows.Forms.DataGridView tableView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox igroup;
        private ZBobb.AlphaBlendTextBox txtId;
        private System.Windows.Forms.Panel e13;
        private System.Windows.Forms.GroupBox egroup;
        private ZBobb.AlphaBlendTextBox txtE;
        private System.Windows.Forms.Panel e10;
        private System.Windows.Forms.GroupBox tgroup;
        private ZBobb.AlphaBlendTextBox txtTT;
        private System.Windows.Forms.Panel e9;
        private System.Windows.Forms.Button btnT;
        private System.Windows.Forms.Button btnI;
        private System.Windows.Forms.Button btnE;
        private System.Windows.Forms.Label lbl1;
    }
}