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
            this.components = new System.ComponentModel.Container();
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.chk_avail = new System.Windows.Forms.CheckBox();
            this.chk_option = new System.Windows.Forms.CheckedListBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb_cbe = new System.Windows.Forms.RadioButton();
            this.rb_telebirr = new System.Windows.Forms.RadioButton();
            this.btn_logout = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_searchnum = new System.Windows.Forms.Button();
            this.txt_num = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.lbl_price.Location = new System.Drawing.Point(480, 193);
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(589, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(337, 174);
            this.dataGridView1.TabIndex = 14;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // chk_avail
            // 
            this.chk_avail.AutoSize = true;
            this.chk_avail.Location = new System.Drawing.Point(711, 204);
            this.chk_avail.Name = "chk_avail";
            this.chk_avail.Size = new System.Drawing.Size(72, 17);
            this.chk_avail.TabIndex = 15;
            this.chk_avail.Text = "availabilty";
            this.chk_avail.UseVisualStyleBackColor = true;
            // 
            // chk_option
            // 
            this.chk_option.FormattingEnabled = true;
            this.chk_option.Items.AddRange(new object[] {
            "isavailable",
            "delivery"});
            this.chk_option.Location = new System.Drawing.Point(307, 103);
            this.chk_option.Name = "chk_option";
            this.chk_option.Size = new System.Drawing.Size(120, 94);
            this.chk_option.TabIndex = 16;
            this.chk_option.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 21);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 17);
            this.radioButton1.TabIndex = 17;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 40);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(85, 17);
            this.radioButton2.TabIndex = 18;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Location = new System.Drawing.Point(789, 183);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(137, 88);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "delivery";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb_cbe);
            this.groupBox2.Controls.Add(this.rb_telebirr);
            this.groupBox2.Location = new System.Drawing.Point(640, 260);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(127, 92);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "payment ";
            // 
            // rb_cbe
            // 
            this.rb_cbe.AutoSize = true;
            this.rb_cbe.Location = new System.Drawing.Point(17, 43);
            this.rb_cbe.Name = "rb_cbe";
            this.rb_cbe.Size = new System.Drawing.Size(43, 17);
            this.rb_cbe.TabIndex = 1;
            this.rb_cbe.TabStop = true;
            this.rb_cbe.Text = "cbe";
            this.rb_cbe.UseVisualStyleBackColor = true;
            // 
            // rb_telebirr
            // 
            this.rb_telebirr.AutoSize = true;
            this.rb_telebirr.Location = new System.Drawing.Point(17, 20);
            this.rb_telebirr.Name = "rb_telebirr";
            this.rb_telebirr.Size = new System.Drawing.Size(56, 17);
            this.rb_telebirr.TabIndex = 0;
            this.rb_telebirr.TabStop = true;
            this.rb_telebirr.Text = "telebirr";
            this.rb_telebirr.UseVisualStyleBackColor = true;
            // 
            // btn_logout
            // 
            this.btn_logout.Location = new System.Drawing.Point(352, 372);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(75, 23);
            this.btn_logout.TabIndex = 21;
            this.btn_logout.Text = "logout";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(117, 303);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 22;
            this.btn_search.Text = "search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(12, 302);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(100, 20);
            this.txt_search.TabIndex = 23;
            // 
            // btn_searchnum
            // 
            this.btn_searchnum.Location = new System.Drawing.Point(118, 344);
            this.btn_searchnum.Name = "btn_searchnum";
            this.btn_searchnum.Size = new System.Drawing.Size(75, 23);
            this.btn_searchnum.TabIndex = 24;
            this.btn_searchnum.Text = "searchbynum";
            this.btn_searchnum.UseVisualStyleBackColor = true;
            this.btn_searchnum.Click += new System.EventHandler(this.btn_searchnum_Click);
            // 
            // txt_num
            // 
            this.txt_num.Location = new System.Drawing.Point(12, 347);
            this.txt_num.Name = "txt_num";
            this.txt_num.Size = new System.Drawing.Size(100, 20);
            this.txt_num.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 450);
            this.Controls.Add(this.txt_num);
            this.Controls.Add(this.btn_searchnum);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chk_option);
            this.Controls.Add(this.chk_avail);
            this.Controls.Add(this.dataGridView1);
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
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.CheckBox chk_avail;
        private System.Windows.Forms.CheckedListBox chk_option;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton rb_cbe;
        private System.Windows.Forms.RadioButton rb_telebirr;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.TextBox txt_num;
        private System.Windows.Forms.Button btn_searchnum;
    }
}

