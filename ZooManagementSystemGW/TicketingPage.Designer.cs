
namespace ZooManagementSystemGW
{
    partial class TicketingPage
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
            this.lbl0 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.e1 = new System.Windows.Forms.Panel();
            this.lbl1 = new System.Windows.Forms.Label();
            this.btnP = new System.Windows.Forms.Button();
            this.cbxTT = new System.Windows.Forms.ComboBox();
            this.txtA = new ZBobb.AlphaBlendTextBox();
            this.pnl = new System.Windows.Forms.Panel();
            this.pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl0
            // 
            this.lbl0.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl0.AutoSize = true;
            this.lbl0.BackColor = System.Drawing.Color.Transparent;
            this.lbl0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl0.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl0.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbl0.Location = new System.Drawing.Point(467, 126);
            this.lbl0.Name = "lbl0";
            this.lbl0.Size = new System.Drawing.Size(177, 42);
            this.lbl0.TabIndex = 84;
            this.lbl0.Text = "Ticketing";
            // 
            // lbl2
            // 
            this.lbl2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl2.AutoSize = true;
            this.lbl2.BackColor = System.Drawing.Color.Transparent;
            this.lbl2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbl2.Location = new System.Drawing.Point(298, 220);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(140, 29);
            this.lbl2.TabIndex = 105;
            this.lbl2.Text = "Ticket Type";
            // 
            // e1
            // 
            this.e1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.e1.BackColor = System.Drawing.Color.Snow;
            this.e1.Location = new System.Drawing.Point(441, 209);
            this.e1.Name = "e1";
            this.e1.Size = new System.Drawing.Size(347, 1);
            this.e1.TabIndex = 104;
            // 
            // lbl1
            // 
            this.lbl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.Transparent;
            this.lbl1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbl1.Location = new System.Drawing.Point(344, 184);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(94, 29);
            this.lbl1.TabIndex = 103;
            this.lbl1.Text = "Amount";
            // 
            // btnP
            // 
            this.btnP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnP.BackColor = System.Drawing.Color.Transparent;
            this.btnP.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnP.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnP.ForeColor = System.Drawing.Color.White;
            this.btnP.Location = new System.Drawing.Point(702, 284);
            this.btnP.Name = "btnP";
            this.btnP.Size = new System.Drawing.Size(86, 33);
            this.btnP.TabIndex = 124;
            this.btnP.Text = "Print";
            this.btnP.UseVisualStyleBackColor = false;
            this.btnP.Click += new System.EventHandler(this.btnP_Click);
            // 
            // cbxTT
            // 
            this.cbxTT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxTT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.cbxTT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTT.ForeColor = System.Drawing.Color.White;
            this.cbxTT.FormattingEnabled = true;
            this.cbxTT.Items.AddRange(new object[] {
            "Local Adult",
            "Local Child",
            "Foreigner Adult",
            "Foreigner Child"});
            this.cbxTT.Location = new System.Drawing.Point(441, 224);
            this.cbxTT.Name = "cbxTT";
            this.cbxTT.Size = new System.Drawing.Size(237, 28);
            this.cbxTT.TabIndex = 125;
            // 
            // txtA
            // 
            this.txtA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtA.BackAlpha = 0;
            this.txtA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtA.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtA.ForeColor = System.Drawing.Color.White;
            this.txtA.Location = new System.Drawing.Point(447, 180);
            this.txtA.Name = "txtA";
            this.txtA.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtA.Size = new System.Drawing.Size(341, 28);
            this.txtA.TabIndex = 142;
            // 
            // pnl
            // 
            this.pnl.Controls.Add(this.lbl0);
            this.pnl.Controls.Add(this.txtA);
            this.pnl.Controls.Add(this.lbl1);
            this.pnl.Controls.Add(this.cbxTT);
            this.pnl.Controls.Add(this.e1);
            this.pnl.Controls.Add(this.btnP);
            this.pnl.Controls.Add(this.lbl2);
            this.pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl.Location = new System.Drawing.Point(0, 0);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(1100, 484);
            this.pnl.TabIndex = 143;
            // 
            // TicketingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(1100, 484);
            this.Controls.Add(this.pnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TicketingPage";
            this.Text = "TicketingPage";
            this.pnl.ResumeLayout(false);
            this.pnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl0;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Panel e1;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btnP;
        private System.Windows.Forms.ComboBox cbxTT;
        public System.Windows.Forms.Panel pnl;
        public ZBobb.AlphaBlendTextBox txtA;
    }
}