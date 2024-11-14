
namespace ZooManagementSystemGW
{
    partial class DeleteFood
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
            this.btn = new System.Windows.Forms.Button();
            this.e1 = new System.Windows.Forms.Panel();
            this.lblFn = new System.Windows.Forms.Label();
            this.lbl0 = new System.Windows.Forms.Label();
            this.txtID = new ZBobb.AlphaBlendTextBox();
            this.pnl = new System.Windows.Forms.Panel();
            this.pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn
            // 
            this.btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn.BackColor = System.Drawing.Color.Transparent;
            this.btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn.Location = new System.Drawing.Point(689, 268);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(110, 35);
            this.btn.TabIndex = 99;
            this.btn.Text = "DELETE";
            this.btn.UseVisualStyleBackColor = false;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // e1
            // 
            this.e1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.e1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.e1.Location = new System.Drawing.Point(452, 249);
            this.e1.Name = "e1";
            this.e1.Size = new System.Drawing.Size(347, 1);
            this.e1.TabIndex = 91;
            // 
            // lblFn
            // 
            this.lblFn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFn.AutoSize = true;
            this.lblFn.BackColor = System.Drawing.Color.Transparent;
            this.lblFn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblFn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblFn.Location = new System.Drawing.Point(350, 224);
            this.lblFn.Name = "lblFn";
            this.lblFn.Size = new System.Drawing.Size(99, 29);
            this.lblFn.TabIndex = 90;
            this.lblFn.Text = "Food ID";
            // 
            // lbl0
            // 
            this.lbl0.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl0.AutoSize = true;
            this.lbl0.BackColor = System.Drawing.Color.Transparent;
            this.lbl0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl0.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl0.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbl0.Location = new System.Drawing.Point(465, 160);
            this.lbl0.Name = "lbl0";
            this.lbl0.Size = new System.Drawing.Size(233, 42);
            this.lbl0.TabIndex = 89;
            this.lbl0.Text = "Food Delete";
            // 
            // txtID
            // 
            this.txtID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtID.BackAlpha = 0;
            this.txtID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.ForeColor = System.Drawing.Color.White;
            this.txtID.Location = new System.Drawing.Point(457, 220);
            this.txtID.Name = "txtID";
            this.txtID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtID.Size = new System.Drawing.Size(342, 28);
            this.txtID.TabIndex = 146;
            // 
            // pnl
            // 
            this.pnl.Controls.Add(this.txtID);
            this.pnl.Controls.Add(this.lbl0);
            this.pnl.Controls.Add(this.btn);
            this.pnl.Controls.Add(this.lblFn);
            this.pnl.Controls.Add(this.e1);
            this.pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl.Location = new System.Drawing.Point(0, 0);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(1100, 484);
            this.pnl.TabIndex = 147;
            // 
            // DeleteFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(1100, 484);
            this.Controls.Add(this.pnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeleteFood";
            this.Text = "DeleteFood";
            this.pnl.ResumeLayout(false);
            this.pnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Panel e1;
        private System.Windows.Forms.Label lblFn;
        private System.Windows.Forms.Label lbl0;
        public ZBobb.AlphaBlendTextBox txtID;
        public System.Windows.Forms.Panel pnl;
    }
}