
namespace ZooManagementSystemGW
{
    partial class Dashbord
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
            this.btnI = new System.Windows.Forms.Button();
            this.btnE = new System.Windows.Forms.Button();
            this.btnP = new System.Windows.Forms.Button();
            this.btnU = new System.Windows.Forms.Button();
            this.TBB = new System.Windows.Forms.TrackBar();
            this.cprogress = new CircularProgressBar.CircularProgressBar();
            this.pnl = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.TBB)).BeginInit();
            this.pnl.SuspendLayout();
            this.SuspendLayout();
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
            this.btnI.Location = new System.Drawing.Point(616, 160);
            this.btnI.Name = "btnI";
            this.btnI.Size = new System.Drawing.Size(57, 33);
            this.btnI.TabIndex = 121;
            this.btnI.Text = "ID";
            this.btnI.UseVisualStyleBackColor = false;
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
            this.btnE.Location = new System.Drawing.Point(679, 160);
            this.btnE.Name = "btnE";
            this.btnE.Size = new System.Drawing.Size(86, 33);
            this.btnE.TabIndex = 122;
            this.btnE.Text = "Email";
            this.btnE.UseVisualStyleBackColor = false;
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
            this.btnP.Location = new System.Drawing.Point(771, 160);
            this.btnP.Name = "btnP";
            this.btnP.Size = new System.Drawing.Size(86, 33);
            this.btnP.TabIndex = 123;
            this.btnP.Text = "Phone";
            this.btnP.UseVisualStyleBackColor = false;
            // 
            // btnU
            // 
            this.btnU.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnU.BackColor = System.Drawing.Color.Transparent;
            this.btnU.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnU.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnU.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnU.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnU.ForeColor = System.Drawing.Color.White;
            this.btnU.Location = new System.Drawing.Point(863, 160);
            this.btnU.Name = "btnU";
            this.btnU.Size = new System.Drawing.Size(126, 33);
            this.btnU.TabIndex = 124;
            this.btnU.Text = "Username";
            this.btnU.UseVisualStyleBackColor = false;
            // 
            // TBB
            // 
            this.TBB.Location = new System.Drawing.Point(83, 303);
            this.TBB.Name = "TBB";
            this.TBB.Size = new System.Drawing.Size(373, 45);
            this.TBB.TabIndex = 125;
            this.TBB.Value = 9;
            this.TBB.Scroll += new System.EventHandler(this.TBB_Scroll);
            // 
            // cprogress
            // 
            this.cprogress.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.cprogress.AnimationSpeed = 500;
            this.cprogress.BackColor = System.Drawing.Color.Transparent;
            this.cprogress.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cprogress.ForeColor = System.Drawing.Color.White;
            this.cprogress.InnerColor = System.Drawing.Color.Transparent;
            this.cprogress.InnerMargin = 2;
            this.cprogress.InnerWidth = -1;
            this.cprogress.Location = new System.Drawing.Point(184, 112);
            this.cprogress.MarqueeAnimationSpeed = 2000;
            this.cprogress.Name = "cprogress";
            this.cprogress.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cprogress.OuterMargin = -25;
            this.cprogress.OuterWidth = 26;
            this.cprogress.ProgressColor = System.Drawing.Color.White;
            this.cprogress.ProgressWidth = 10;
            this.cprogress.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.cprogress.Size = new System.Drawing.Size(170, 170);
            this.cprogress.StartAngle = 270;
            this.cprogress.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cprogress.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.cprogress.SubscriptText = "";
            this.cprogress.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cprogress.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.cprogress.SuperscriptText = "";
            this.cprogress.TabIndex = 126;
            this.cprogress.Text = "90%";
            this.cprogress.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.cprogress.Value = 90;
            this.cprogress.Click += new System.EventHandler(this.circularProgressBar1_Click);
            // 
            // pnl
            // 
            this.pnl.Controls.Add(this.cprogress);
            this.pnl.Controls.Add(this.btnU);
            this.pnl.Controls.Add(this.TBB);
            this.pnl.Controls.Add(this.btnP);
            this.pnl.Controls.Add(this.btnI);
            this.pnl.Controls.Add(this.btnE);
            this.pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl.Location = new System.Drawing.Point(0, 0);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(1100, 484);
            this.pnl.TabIndex = 127;
            // 
            // Dashbord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(1100, 484);
            this.Controls.Add(this.pnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashbord";
            this.Text = "Dashbord";
            ((System.ComponentModel.ISupportInitialize)(this.TBB)).EndInit();
            this.pnl.ResumeLayout(false);
            this.pnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnI;
        private System.Windows.Forms.Button btnE;
        private System.Windows.Forms.Button btnP;
        private System.Windows.Forms.Button btnU;
        private CircularProgressBar.CircularProgressBar cprogress;
        public System.Windows.Forms.Panel pnl;
        public System.Windows.Forms.TrackBar TBB;
    }
}