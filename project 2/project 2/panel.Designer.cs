namespace project_2
{
    partial class panel
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_red = new System.Windows.Forms.Button();
            this.btn_yellow = new System.Windows.Forms.Button();
            this.btn_green = new System.Windows.Forms.Button();
            this.pnl_highlight = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_red);
            this.panel1.Controls.Add(this.btn_yellow);
            this.panel1.Controls.Add(this.btn_green);
            this.panel1.Controls.Add(this.pnl_highlight);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(172, 357);
            this.panel1.TabIndex = 0;
            // 
            // btn_red
            // 
            this.btn_red.Location = new System.Drawing.Point(58, 266);
            this.btn_red.Name = "btn_red";
            this.btn_red.Size = new System.Drawing.Size(75, 23);
            this.btn_red.TabIndex = 6;
            this.btn_red.Text = "Red";
            this.btn_red.UseVisualStyleBackColor = true;
            this.btn_red.Click += new System.EventHandler(this.btn_red_Click);
            // 
            // btn_yellow
            // 
            this.btn_yellow.Location = new System.Drawing.Point(58, 147);
            this.btn_yellow.Name = "btn_yellow";
            this.btn_yellow.Size = new System.Drawing.Size(75, 23);
            this.btn_yellow.TabIndex = 5;
            this.btn_yellow.Text = "Yellow";
            this.btn_yellow.UseVisualStyleBackColor = true;
            this.btn_yellow.Click += new System.EventHandler(this.btn_yellow_Click);
            // 
            // btn_green
            // 
            this.btn_green.Location = new System.Drawing.Point(58, 30);
            this.btn_green.Name = "btn_green";
            this.btn_green.Size = new System.Drawing.Size(75, 23);
            this.btn_green.TabIndex = 4;
            this.btn_green.Text = "Green";
            this.btn_green.UseVisualStyleBackColor = true;
            this.btn_green.Click += new System.EventHandler(this.btn_green_Click);
            // 
            // pnl_highlight
            // 
            this.pnl_highlight.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnl_highlight.Location = new System.Drawing.Point(12, 43);
            this.pnl_highlight.Name = "pnl_highlight";
            this.pnl_highlight.Size = new System.Drawing.Size(28, 10);
            this.pnl_highlight.TabIndex = 3;
            this.pnl_highlight.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint_1);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(178, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(610, 357);
            this.flowLayoutPanel1.TabIndex = 1;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 357);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "panel";
            this.Text = "panel";
            this.Load += new System.EventHandler(this.panel_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnl_highlight;
        private System.Windows.Forms.Button btn_green;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btn_red;
        private System.Windows.Forms.Button btn_yellow;
    }
}