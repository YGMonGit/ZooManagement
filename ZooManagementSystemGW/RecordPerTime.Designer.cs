
namespace ZooManagementSystemGW
{
    partial class RecordPerTime
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.cbx = new System.Windows.Forms.ComboBox();
            this.lbl = new System.Windows.Forms.Label();
            this.btn = new System.Windows.Forms.Button();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnr = new System.Windows.Forms.Button();
            this.btnl = new System.Windows.Forms.Button();
            this.pnl = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbx
            // 
            this.cbx.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.cbx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx.ForeColor = System.Drawing.Color.White;
            this.cbx.FormattingEnabled = true;
            this.cbx.Items.AddRange(new object[] {
            "Today",
            "All",
            "Last Month",
            "Last Year"});
            this.cbx.Location = new System.Drawing.Point(445, 29);
            this.cbx.Name = "cbx";
            this.cbx.Size = new System.Drawing.Size(233, 32);
            this.cbx.TabIndex = 0;
            // 
            // lbl
            // 
            this.lbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl.AutoSize = true;
            this.lbl.BackColor = System.Drawing.Color.Transparent;
            this.lbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbl.Location = new System.Drawing.Point(288, 28);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(154, 33);
            this.lbl.TabIndex = 43;
            this.lbl.Text = "Report For";
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
            this.btn.Location = new System.Drawing.Point(693, 27);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(95, 35);
            this.btn.TabIndex = 67;
            this.btn.Text = "GET";
            this.btn.UseVisualStyleBackColor = false;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // chart
            // 
            this.chart.Anchor = System.Windows.Forms.AnchorStyles.None;
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(182, 87);
            this.chart.Name = "chart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Sales";
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(724, 368);
            this.chart.TabIndex = 68;
            this.chart.Text = "chart1";
            // 
            // btnr
            // 
            this.btnr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnr.BackColor = System.Drawing.Color.Transparent;
            this.btnr.BackgroundImage = global::ZooManagementSystemGW.Properties.Resources.Right;
            this.btnr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnr.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnr.FlatAppearance.BorderSize = 0;
            this.btnr.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnr.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnr.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnr.Location = new System.Drawing.Point(983, 236);
            this.btnr.Name = "btnr";
            this.btnr.Size = new System.Drawing.Size(75, 70);
            this.btnr.TabIndex = 69;
            this.btnr.UseVisualStyleBackColor = false;
            this.btnr.Click += new System.EventHandler(this.btnr_Click);
            // 
            // btnl
            // 
            this.btnl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnl.BackColor = System.Drawing.Color.Transparent;
            this.btnl.BackgroundImage = global::ZooManagementSystemGW.Properties.Resources.Left;
            this.btnl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnl.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnl.FlatAppearance.BorderSize = 0;
            this.btnl.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnl.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnl.Location = new System.Drawing.Point(25, 236);
            this.btnl.Name = "btnl";
            this.btnl.Size = new System.Drawing.Size(75, 70);
            this.btnl.TabIndex = 70;
            this.btnl.UseVisualStyleBackColor = false;
            this.btnl.Click += new System.EventHandler(this.btnl_Click);
            // 
            // pnl
            // 
            this.pnl.Controls.Add(this.cbx);
            this.pnl.Controls.Add(this.btnl);
            this.pnl.Controls.Add(this.lbl);
            this.pnl.Controls.Add(this.btnr);
            this.pnl.Controls.Add(this.btn);
            this.pnl.Controls.Add(this.chart);
            this.pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl.Location = new System.Drawing.Point(0, 0);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(1100, 484);
            this.pnl.TabIndex = 71;
            // 
            // RecordPerTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(1100, 484);
            this.Controls.Add(this.pnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RecordPerTime";
            this.Text = "RecordPerTime";
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.pnl.ResumeLayout(false);
            this.pnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbx;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Button btnr;
        private System.Windows.Forms.Button btnl;
        public System.Windows.Forms.Panel pnl;
    }
}