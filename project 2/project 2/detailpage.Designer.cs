namespace project_2
{
    partial class detailpage
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_count = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_inventorynumber = new System.Windows.Forms.Label();
            this.lbl_objectname = new System.Windows.Forms.Label();
            this.lbl_price = new System.Windows.Forms.Label();
            this.lbl_number = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_count, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_price, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_date, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_inventorynumber, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_objectname, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_number, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(-3, -2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(365, 99);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lbl_count
            // 
            this.lbl_count.AccessibleName = "";
            this.lbl_count.AutoSize = true;
            this.lbl_count.Location = new System.Drawing.Point(3, 0);
            this.lbl_count.Name = "lbl_count";
            this.lbl_count.Size = new System.Drawing.Size(34, 13);
            this.lbl_count.TabIndex = 0;
            this.lbl_count.Text = "count";
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Location = new System.Drawing.Point(175, 0);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(28, 13);
            this.lbl_date.TabIndex = 1;
            this.lbl_date.Text = "date";
            // 
            // lbl_inventorynumber
            // 
            this.lbl_inventorynumber.AutoSize = true;
            this.lbl_inventorynumber.Location = new System.Drawing.Point(3, 39);
            this.lbl_inventorynumber.Name = "lbl_inventorynumber";
            this.lbl_inventorynumber.Size = new System.Drawing.Size(88, 13);
            this.lbl_inventorynumber.TabIndex = 2;
            this.lbl_inventorynumber.Text = "inventory number";
            // 
            // lbl_objectname
            // 
            this.lbl_objectname.AutoSize = true;
            this.lbl_objectname.Location = new System.Drawing.Point(175, 39);
            this.lbl_objectname.Name = "lbl_objectname";
            this.lbl_objectname.Size = new System.Drawing.Size(65, 13);
            this.lbl_objectname.TabIndex = 3;
            this.lbl_objectname.Text = "object name";
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Location = new System.Drawing.Point(3, 78);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(30, 13);
            this.lbl_price.TabIndex = 4;
            this.lbl_price.Text = "price";
            // 
            // lbl_number
            // 
            this.lbl_number.AutoSize = true;
            this.lbl_number.Location = new System.Drawing.Point(175, 78);
            this.lbl_number.Name = "lbl_number";
            this.lbl_number.Size = new System.Drawing.Size(42, 13);
            this.lbl_number.TabIndex = 5;
            this.lbl_number.Text = "number";
            // 
            // detailpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "detailpage";
            this.Text = "detailpage";
            this.Load += new System.EventHandler(this.detailpage_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbl_count;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.Label lbl_inventorynumber;
        private System.Windows.Forms.Label lbl_objectname;
        private System.Windows.Forms.Label lbl_number;
    }
}