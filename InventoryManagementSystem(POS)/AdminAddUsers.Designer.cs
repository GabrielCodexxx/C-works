namespace InventoryManagementSystem_POS_
{
    partial class AdminAddUsers
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.addUsers_clearBtn = new System.Windows.Forms.Button();
            this.addUsers_removeBtn = new System.Windows.Forms.Button();
            this.addUsers_updateBtn = new System.Windows.Forms.Button();
            this.addUsers_addBtn = new System.Windows.Forms.Button();
            this.addUsers_status = new System.Windows.Forms.ComboBox();
            this.addUsers_role = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addUsers_password = new System.Windows.Forms.TextBox();
            this.addUsers_username = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.addUsers_clearBtn);
            this.panel1.Controls.Add(this.addUsers_removeBtn);
            this.panel1.Controls.Add(this.addUsers_updateBtn);
            this.panel1.Controls.Add(this.addUsers_addBtn);
            this.panel1.Controls.Add(this.addUsers_status);
            this.panel1.Controls.Add(this.addUsers_role);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.addUsers_password);
            this.panel1.Controls.Add(this.addUsers_username);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(383, 802);
            this.panel1.TabIndex = 0;
            // 
            // addUsers_clearBtn
            // 
            this.addUsers_clearBtn.BackColor = System.Drawing.Color.Silver;
            this.addUsers_clearBtn.Location = new System.Drawing.Point(196, 581);
            this.addUsers_clearBtn.Name = "addUsers_clearBtn";
            this.addUsers_clearBtn.Size = new System.Drawing.Size(150, 69);
            this.addUsers_clearBtn.TabIndex = 11;
            this.addUsers_clearBtn.Text = "CLEAR";
            this.addUsers_clearBtn.UseVisualStyleBackColor = false;
            this.addUsers_clearBtn.Click += new System.EventHandler(this.addUsers_clearBtn_Click);
            // 
            // addUsers_removeBtn
            // 
            this.addUsers_removeBtn.BackColor = System.Drawing.Color.Silver;
            this.addUsers_removeBtn.Location = new System.Drawing.Point(32, 581);
            this.addUsers_removeBtn.Name = "addUsers_removeBtn";
            this.addUsers_removeBtn.Size = new System.Drawing.Size(150, 69);
            this.addUsers_removeBtn.TabIndex = 10;
            this.addUsers_removeBtn.Text = "REMOVE";
            this.addUsers_removeBtn.UseVisualStyleBackColor = false;
            this.addUsers_removeBtn.Click += new System.EventHandler(this.addUsers_removeBtn_Click);
            // 
            // addUsers_updateBtn
            // 
            this.addUsers_updateBtn.BackColor = System.Drawing.Color.Silver;
            this.addUsers_updateBtn.Location = new System.Drawing.Point(196, 485);
            this.addUsers_updateBtn.Name = "addUsers_updateBtn";
            this.addUsers_updateBtn.Size = new System.Drawing.Size(150, 69);
            this.addUsers_updateBtn.TabIndex = 9;
            this.addUsers_updateBtn.Text = "UPDATE";
            this.addUsers_updateBtn.UseVisualStyleBackColor = false;
            this.addUsers_updateBtn.Click += new System.EventHandler(this.addUsers_updateBtn_Click);
            // 
            // addUsers_addBtn
            // 
            this.addUsers_addBtn.BackColor = System.Drawing.Color.Silver;
            this.addUsers_addBtn.Location = new System.Drawing.Point(32, 485);
            this.addUsers_addBtn.Name = "addUsers_addBtn";
            this.addUsers_addBtn.Size = new System.Drawing.Size(150, 69);
            this.addUsers_addBtn.TabIndex = 8;
            this.addUsers_addBtn.Text = "ADD";
            this.addUsers_addBtn.UseVisualStyleBackColor = false;
            this.addUsers_addBtn.Click += new System.EventHandler(this.addUsers_addBtn_Click);
            // 
            // addUsers_status
            // 
            this.addUsers_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addUsers_status.FormattingEnabled = true;
            this.addUsers_status.Items.AddRange(new object[] {
            "ACTIVE",
            "INACTIVE",
            "APPROVAL"});
            this.addUsers_status.Location = new System.Drawing.Point(32, 413);
            this.addUsers_status.Name = "addUsers_status";
            this.addUsers_status.Size = new System.Drawing.Size(314, 33);
            this.addUsers_status.TabIndex = 7;
            // 
            // addUsers_role
            // 
            this.addUsers_role.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addUsers_role.FormattingEnabled = true;
            this.addUsers_role.Items.AddRange(new object[] {
            "Admin",
            "Cashier"});
            this.addUsers_role.Location = new System.Drawing.Point(32, 324);
            this.addUsers_role.Name = "addUsers_role";
            this.addUsers_role.Size = new System.Drawing.Size(314, 33);
            this.addUsers_role.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 375);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "STATUS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "ROLE";
            // 
            // addUsers_password
            // 
            this.addUsers_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addUsers_password.Location = new System.Drawing.Point(32, 214);
            this.addUsers_password.Name = "addUsers_password";
            this.addUsers_password.Size = new System.Drawing.Size(314, 30);
            this.addUsers_password.TabIndex = 3;
            // 
            // addUsers_username
            // 
            this.addUsers_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addUsers_username.Location = new System.Drawing.Point(32, 133);
            this.addUsers_username.Name = "addUsers_username";
            this.addUsers_username.Size = new System.Drawing.Size(314, 30);
            this.addUsers_username.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "PASSWORD";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "USERNAME";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(399, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "ALL USER\'S DATA";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(396, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1016, 751);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // AdminAddUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Name = "AdminAddUsers";
            this.Size = new System.Drawing.Size(1424, 802);
            this.Load += new System.EventHandler(this.AdminAddUsers_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addUsers_clearBtn;
        private System.Windows.Forms.Button addUsers_removeBtn;
        private System.Windows.Forms.Button addUsers_updateBtn;
        private System.Windows.Forms.Button addUsers_addBtn;
        private System.Windows.Forms.ComboBox addUsers_status;
        private System.Windows.Forms.ComboBox addUsers_role;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox addUsers_password;
        private System.Windows.Forms.TextBox addUsers_username;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
