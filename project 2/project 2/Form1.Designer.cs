namespace project_2
{
    partial class Form1
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
            this.lbl_number = new System.Windows.Forms.Label();
            this.lbl_objectname = new System.Windows.Forms.Label();
            this.lbl_inventory = new System.Windows.Forms.Label();
            this.lbl_count = new System.Windows.Forms.Label();
            this.lbl_price = new System.Windows.Forms.Label();
            this.dt_registereddate = new System.Windows.Forms.DateTimePicker();
            this.lbl_date = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.txt_nummber = new System.Windows.Forms.TextBox();
            this.txt_inventorynumber = new System.Windows.Forms.TextBox();
            this.txt_objectname = new System.Windows.Forms.TextBox();
            this.txt_count = new System.Windows.Forms.TextBox();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_number
            // 
            this.lbl_number.AutoSize = true;
            this.lbl_number.Location = new System.Drawing.Point(114, 28);
            this.lbl_number.Name = "lbl_number";
            this.lbl_number.Size = new System.Drawing.Size(42, 13);
            this.lbl_number.TabIndex = 0;
            this.lbl_number.Text = "number";
            // 
            // lbl_objectname
            // 
            this.lbl_objectname.AutoSize = true;
            this.lbl_objectname.Location = new System.Drawing.Point(102, 103);
            this.lbl_objectname.Name = "lbl_objectname";
            this.lbl_objectname.Size = new System.Drawing.Size(65, 13);
            this.lbl_objectname.TabIndex = 1;
            this.lbl_objectname.Text = "object name";
            // 
            // lbl_inventory
            // 
            this.lbl_inventory.AutoSize = true;
            this.lbl_inventory.Location = new System.Drawing.Point(480, 28);
            this.lbl_inventory.Name = "lbl_inventory";
            this.lbl_inventory.Size = new System.Drawing.Size(88, 13);
            this.lbl_inventory.TabIndex = 2;
            this.lbl_inventory.Text = "inventory number";
            // 
            // lbl_count
            // 
            this.lbl_count.AutoSize = true;
            this.lbl_count.Location = new System.Drawing.Point(114, 193);
            this.lbl_count.Name = "lbl_count";
            this.lbl_count.Size = new System.Drawing.Size(34, 13);
            this.lbl_count.TabIndex = 3;
            this.lbl_count.Text = "count";
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Location = new System.Drawing.Point(406, 193);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(30, 13);
            this.lbl_price.TabIndex = 4;
            this.lbl_price.Text = "price";
            // 
            // dt_registereddate
            // 
            this.dt_registereddate.Location = new System.Drawing.Point(241, 54);
            this.dt_registereddate.Name = "dt_registereddate";
            this.dt_registereddate.Size = new System.Drawing.Size(200, 20);
            this.dt_registereddate.TabIndex = 5;
            this.dt_registereddate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Location = new System.Drawing.Point(304, 27);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(28, 13);
            this.lbl_date.TabIndex = 6;
            this.lbl_date.Text = "date";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(241, 303);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 7;
            this.btn_add.Text = "add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(456, 303);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 8;
            this.btn_cancel.Text = "cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // txt_nummber
            // 
            this.txt_nummber.Location = new System.Drawing.Point(105, 57);
            this.txt_nummber.Name = "txt_nummber";
            this.txt_nummber.Size = new System.Drawing.Size(100, 20);
            this.txt_nummber.TabIndex = 9;
            // 
            // txt_inventorynumber
            // 
            this.txt_inventorynumber.Location = new System.Drawing.Point(483, 54);
            this.txt_inventorynumber.Name = "txt_inventorynumber";
            this.txt_inventorynumber.Size = new System.Drawing.Size(100, 20);
            this.txt_inventorynumber.TabIndex = 10;
            // 
            // txt_objectname
            // 
            this.txt_objectname.Location = new System.Drawing.Point(105, 141);
            this.txt_objectname.Name = "txt_objectname";
            this.txt_objectname.Size = new System.Drawing.Size(100, 20);
            this.txt_objectname.TabIndex = 11;
            // 
            // txt_count
            // 
            this.txt_count.Location = new System.Drawing.Point(105, 220);
            this.txt_count.Name = "txt_count";
            this.txt_count.Size = new System.Drawing.Size(100, 20);
            this.txt_count.TabIndex = 12;
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(456, 220);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(100, 20);
            this.txt_price.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.txt_count);
            this.Controls.Add(this.txt_objectname);
            this.Controls.Add(this.txt_inventorynumber);
            this.Controls.Add(this.txt_nummber);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.dt_registereddate);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.lbl_count);
            this.Controls.Add(this.lbl_inventory);
            this.Controls.Add(this.lbl_objectname);
            this.Controls.Add(this.lbl_number);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_number;
        private System.Windows.Forms.Label lbl_objectname;
        private System.Windows.Forms.Label lbl_inventory;
        private System.Windows.Forms.Label lbl_count;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.DateTimePicker dt_registereddate;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.TextBox txt_nummber;
        private System.Windows.Forms.TextBox txt_inventorynumber;
        private System.Windows.Forms.TextBox txt_objectname;
        private System.Windows.Forms.TextBox txt_count;
        private System.Windows.Forms.TextBox txt_price;
    }
}

