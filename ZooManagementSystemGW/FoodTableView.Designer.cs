
namespace ZooManagementSystemGW
{
    partial class FoodTableView
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
            this.lbl0 = new System.Windows.Forms.Label();
            this.pnlP = new System.Windows.Forms.Panel();
            this.igroup = new System.Windows.Forms.GroupBox();
            this.txtId = new ZBobb.AlphaBlendTextBox();
            this.e13 = new System.Windows.Forms.Panel();
            this.fgroup = new System.Windows.Forms.GroupBox();
            this.txtFpd = new ZBobb.AlphaBlendTextBox();
            this.e11 = new System.Windows.Forms.Panel();
            this.agroup = new System.Windows.Forms.GroupBox();
            this.txtA = new ZBobb.AlphaBlendTextBox();
            this.e10 = new System.Windows.Forms.Panel();
            this.ngroup = new System.Windows.Forms.GroupBox();
            this.txtFn = new ZBobb.AlphaBlendTextBox();
            this.e9 = new System.Windows.Forms.Panel();
            this.btnN = new System.Windows.Forms.Button();
            this.btnI = new System.Windows.Forms.Button();
            this.btnFpd = new System.Windows.Forms.Button();
            this.btnA = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableView)).BeginInit();
            this.pnlP.SuspendLayout();
            this.igroup.SuspendLayout();
            this.fgroup.SuspendLayout();
            this.agroup.SuspendLayout();
            this.ngroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl
            // 
            this.pnl.Controls.Add(this.tableView);
            this.pnl.Controls.Add(this.lbl0);
            this.pnl.Controls.Add(this.pnlP);
            this.pnl.Controls.Add(this.btnN);
            this.pnl.Controls.Add(this.btnI);
            this.pnl.Controls.Add(this.btnFpd);
            this.pnl.Controls.Add(this.btnA);
            this.pnl.Controls.Add(this.lbl1);
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
            this.tableView.Location = new System.Drawing.Point(0, 201);
            this.tableView.Name = "tableView";
            this.tableView.Size = new System.Drawing.Size(1100, 283);
            this.tableView.TabIndex = 136;
            // 
            // lbl0
            // 
            this.lbl0.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl0.AutoSize = true;
            this.lbl0.BackColor = System.Drawing.Color.Transparent;
            this.lbl0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl0.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl0.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbl0.Location = new System.Drawing.Point(395, 9);
            this.lbl0.Name = "lbl0";
            this.lbl0.Size = new System.Drawing.Size(314, 42);
            this.lbl0.TabIndex = 129;
            this.lbl0.Text = "Food Table View";
            // 
            // pnlP
            // 
            this.pnlP.BackColor = System.Drawing.Color.Transparent;
            this.pnlP.Controls.Add(this.igroup);
            this.pnlP.Controls.Add(this.fgroup);
            this.pnlP.Controls.Add(this.agroup);
            this.pnlP.Controls.Add(this.ngroup);
            this.pnlP.Location = new System.Drawing.Point(362, 100);
            this.pnlP.Name = "pnlP";
            this.pnlP.Size = new System.Drawing.Size(496, 59);
            this.pnlP.TabIndex = 135;
            // 
            // igroup
            // 
            this.igroup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.igroup.Controls.Add(this.txtId);
            this.igroup.Controls.Add(this.e13);
            this.igroup.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.igroup.Location = new System.Drawing.Point(42, -105);
            this.igroup.Name = "igroup";
            this.igroup.Size = new System.Drawing.Size(417, 55);
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
            this.txtId.Location = new System.Drawing.Point(83, 15);
            this.txtId.Name = "txtId";
            this.txtId.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtId.Size = new System.Drawing.Size(299, 28);
            this.txtId.TabIndex = 140;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            // 
            // e13
            // 
            this.e13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.e13.BackColor = System.Drawing.SystemColors.ControlLight;
            this.e13.Location = new System.Drawing.Point(76, 44);
            this.e13.Name = "e13";
            this.e13.Size = new System.Drawing.Size(304, 1);
            this.e13.TabIndex = 115;
            // 
            // fgroup
            // 
            this.fgroup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fgroup.Controls.Add(this.txtFpd);
            this.fgroup.Controls.Add(this.e11);
            this.fgroup.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.fgroup.Location = new System.Drawing.Point(41, 107);
            this.fgroup.Name = "fgroup";
            this.fgroup.Size = new System.Drawing.Size(417, 55);
            this.fgroup.TabIndex = 116;
            this.fgroup.TabStop = false;
            this.fgroup.Text = "Frequncy Per Day";
            // 
            // txtFpd
            // 
            this.txtFpd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFpd.BackAlpha = 0;
            this.txtFpd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtFpd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFpd.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFpd.ForeColor = System.Drawing.Color.White;
            this.txtFpd.Location = new System.Drawing.Point(83, 15);
            this.txtFpd.Name = "txtFpd";
            this.txtFpd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtFpd.Size = new System.Drawing.Size(299, 28);
            this.txtFpd.TabIndex = 142;
            this.txtFpd.TextChanged += new System.EventHandler(this.txtFpd_TextChanged);
            // 
            // e11
            // 
            this.e11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.e11.BackColor = System.Drawing.SystemColors.ControlLight;
            this.e11.Location = new System.Drawing.Point(76, 44);
            this.e11.Name = "e11";
            this.e11.Size = new System.Drawing.Size(304, 1);
            this.e11.TabIndex = 115;
            // 
            // agroup
            // 
            this.agroup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.agroup.Controls.Add(this.txtA);
            this.agroup.Controls.Add(this.e10);
            this.agroup.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.agroup.Location = new System.Drawing.Point(43, 35);
            this.agroup.Name = "agroup";
            this.agroup.Size = new System.Drawing.Size(417, 55);
            this.agroup.TabIndex = 115;
            this.agroup.TabStop = false;
            this.agroup.Text = "Amount";
            // 
            // txtA
            // 
            this.txtA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtA.BackAlpha = 0;
            this.txtA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtA.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtA.ForeColor = System.Drawing.Color.White;
            this.txtA.Location = new System.Drawing.Point(81, 15);
            this.txtA.Name = "txtA";
            this.txtA.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtA.Size = new System.Drawing.Size(299, 28);
            this.txtA.TabIndex = 141;
            this.txtA.TextChanged += new System.EventHandler(this.txtA_TextChanged);
            // 
            // e10
            // 
            this.e10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.e10.BackColor = System.Drawing.SystemColors.ControlLight;
            this.e10.Location = new System.Drawing.Point(76, 44);
            this.e10.Name = "e10";
            this.e10.Size = new System.Drawing.Size(304, 1);
            this.e10.TabIndex = 115;
            // 
            // ngroup
            // 
            this.ngroup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ngroup.Controls.Add(this.txtFn);
            this.ngroup.Controls.Add(this.e9);
            this.ngroup.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ngroup.Location = new System.Drawing.Point(41, -44);
            this.ngroup.Name = "ngroup";
            this.ngroup.Size = new System.Drawing.Size(417, 55);
            this.ngroup.TabIndex = 114;
            this.ngroup.TabStop = false;
            this.ngroup.Text = "Food Name";
            // 
            // txtFn
            // 
            this.txtFn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFn.BackAlpha = 0;
            this.txtFn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtFn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFn.ForeColor = System.Drawing.Color.White;
            this.txtFn.Location = new System.Drawing.Point(83, 15);
            this.txtFn.Name = "txtFn";
            this.txtFn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtFn.Size = new System.Drawing.Size(299, 28);
            this.txtFn.TabIndex = 141;
            this.txtFn.TextChanged += new System.EventHandler(this.txtFn_TextChanged);
            // 
            // e9
            // 
            this.e9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.e9.BackColor = System.Drawing.SystemColors.ControlLight;
            this.e9.Location = new System.Drawing.Point(76, 44);
            this.e9.Name = "e9";
            this.e9.Size = new System.Drawing.Size(304, 1);
            this.e9.TabIndex = 115;
            // 
            // btnN
            // 
            this.btnN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnN.BackColor = System.Drawing.Color.Transparent;
            this.btnN.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnN.ForeColor = System.Drawing.Color.White;
            this.btnN.Location = new System.Drawing.Point(427, 62);
            this.btnN.Name = "btnN";
            this.btnN.Size = new System.Drawing.Size(129, 33);
            this.btnN.TabIndex = 130;
            this.btnN.Text = "Food Name";
            this.btnN.UseVisualStyleBackColor = false;
            this.btnN.Click += new System.EventHandler(this.btnN_Click);
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
            this.btnI.Location = new System.Drawing.Point(364, 62);
            this.btnI.Name = "btnI";
            this.btnI.Size = new System.Drawing.Size(57, 33);
            this.btnI.TabIndex = 134;
            this.btnI.Text = "ID";
            this.btnI.UseVisualStyleBackColor = false;
            this.btnI.Click += new System.EventHandler(this.btnI_Click);
            // 
            // btnFpd
            // 
            this.btnFpd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFpd.BackColor = System.Drawing.Color.Transparent;
            this.btnFpd.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFpd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFpd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnFpd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFpd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFpd.ForeColor = System.Drawing.Color.White;
            this.btnFpd.Location = new System.Drawing.Point(659, 62);
            this.btnFpd.Name = "btnFpd";
            this.btnFpd.Size = new System.Drawing.Size(197, 33);
            this.btnFpd.TabIndex = 131;
            this.btnFpd.Text = "Frequency Per Day";
            this.btnFpd.UseVisualStyleBackColor = false;
            this.btnFpd.Click += new System.EventHandler(this.btnFpd_Click);
            // 
            // btnA
            // 
            this.btnA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnA.BackColor = System.Drawing.Color.Transparent;
            this.btnA.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnA.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnA.ForeColor = System.Drawing.Color.White;
            this.btnA.Location = new System.Drawing.Point(562, 62);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(91, 33);
            this.btnA.TabIndex = 132;
            this.btnA.Text = "Amount";
            this.btnA.UseVisualStyleBackColor = false;
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
            // 
            // lbl1
            // 
            this.lbl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.Transparent;
            this.lbl1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbl1.Location = new System.Drawing.Point(163, 54);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(171, 42);
            this.lbl1.TabIndex = 133;
            this.lbl1.Text = "View By:";
            // 
            // FoodTableView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(1100, 484);
            this.Controls.Add(this.pnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FoodTableView";
            this.Text = "FoodTableView";
            this.pnl.ResumeLayout(false);
            this.pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableView)).EndInit();
            this.pnlP.ResumeLayout(false);
            this.igroup.ResumeLayout(false);
            this.igroup.PerformLayout();
            this.fgroup.ResumeLayout(false);
            this.fgroup.PerformLayout();
            this.agroup.ResumeLayout(false);
            this.agroup.PerformLayout();
            this.ngroup.ResumeLayout(false);
            this.ngroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel pnl;
        private System.Windows.Forms.Label lbl0;
        private System.Windows.Forms.Panel pnlP;
        private System.Windows.Forms.GroupBox igroup;
        private ZBobb.AlphaBlendTextBox txtId;
        private System.Windows.Forms.Panel e13;
        private System.Windows.Forms.GroupBox fgroup;
        private ZBobb.AlphaBlendTextBox txtFpd;
        private System.Windows.Forms.Panel e11;
        private System.Windows.Forms.GroupBox agroup;
        private ZBobb.AlphaBlendTextBox txtA;
        private System.Windows.Forms.Panel e10;
        private System.Windows.Forms.GroupBox ngroup;
        private ZBobb.AlphaBlendTextBox txtFn;
        private System.Windows.Forms.Panel e9;
        private System.Windows.Forms.Button btnN;
        private System.Windows.Forms.Button btnI;
        private System.Windows.Forms.Button btnFpd;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.DataGridView tableView;
    }
}