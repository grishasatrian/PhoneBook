namespace Contact
{
    partial class PhoneBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhoneBook));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.del_btn = new System.Windows.Forms.Button();
            this.name_label = new System.Windows.Forms.Label();
            this.input_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.input_email = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.input_phone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.input_address = new System.Windows.Forms.TextBox();
            this.add_btn = new System.Windows.Forms.Button();
            this.edit_btn = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.errorProviderEmail = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderPhone = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPhone)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(508, 223);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // del_btn
            // 
            this.del_btn.Location = new System.Drawing.Point(712, 132);
            this.del_btn.Name = "del_btn";
            this.del_btn.Size = new System.Drawing.Size(60, 42);
            this.del_btn.TabIndex = 1;
            this.del_btn.Text = "Delete";
            this.del_btn.UseVisualStyleBackColor = true;
            this.del_btn.Click += new System.EventHandler(this.del_btn_Click);
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Location = new System.Drawing.Point(536, 15);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(35, 13);
            this.name_label.TabIndex = 2;
            this.name_label.Text = "Name";
            // 
            // input_name
            // 
            this.input_name.Location = new System.Drawing.Point(577, 12);
            this.input_name.MaxLength = 40;
            this.input_name.Name = "input_name";
            this.input_name.Size = new System.Drawing.Size(195, 20);
            this.input_name.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(536, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Email";
            // 
            // input_email
            // 
            this.input_email.Location = new System.Drawing.Point(577, 38);
            this.input_email.MaxLength = 50;
            this.input_email.Name = "input_email";
            this.input_email.Size = new System.Drawing.Size(195, 20);
            this.input_email.TabIndex = 3;
            this.input_email.TextChanged += new System.EventHandler(this.input_email_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(532, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Phone";
            // 
            // input_phone
            // 
            this.input_phone.Location = new System.Drawing.Point(577, 64);
            this.input_phone.MaxLength = 20;
            this.input_phone.Name = "input_phone";
            this.input_phone.Size = new System.Drawing.Size(195, 20);
            this.input_phone.TabIndex = 3;
            this.input_phone.TextChanged += new System.EventHandler(this.input_phone_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(526, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Address";
            // 
            // input_address
            // 
            this.input_address.Location = new System.Drawing.Point(577, 90);
            this.input_address.MaxLength = 200;
            this.input_address.Name = "input_address";
            this.input_address.Size = new System.Drawing.Size(195, 20);
            this.input_address.TabIndex = 3;
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(577, 132);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(60, 42);
            this.add_btn.TabIndex = 4;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // edit_btn
            // 
            this.edit_btn.Location = new System.Drawing.Point(646, 132);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(60, 42);
            this.edit_btn.TabIndex = 4;
            this.edit_btn.Text = "Edit";
            this.edit_btn.UseVisualStyleBackColor = true;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(578, 195);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(195, 40);
            this.exit.TabIndex = 5;
            this.exit.Text = "E&XIT";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // errorProviderEmail
            // 
            this.errorProviderEmail.ContainerControl = this;
            // 
            // errorProviderPhone
            // 
            this.errorProviderPhone.ContainerControl = this;
            // 
            // PhoneBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(793, 249);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.edit_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.input_address);
            this.Controls.Add(this.input_email);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.input_phone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.input_name);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.del_btn);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(809, 288);
            this.MinimumSize = new System.Drawing.Size(809, 288);
            this.Name = "PhoneBook";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Phone Book";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPhone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button del_btn;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.TextBox input_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox input_email;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox input_phone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox input_address;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.ErrorProvider errorProviderEmail;
        private System.Windows.Forms.ErrorProvider errorProviderPhone;
    }
}

