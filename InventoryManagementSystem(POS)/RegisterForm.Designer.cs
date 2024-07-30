namespace InventoryManagementSystem_POS_
{
    partial class RegisterForm
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
            this.close = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.register_showpassword = new System.Windows.Forms.CheckBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.register_cpassword = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.register_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.signup_button = new System.Windows.Forms.Button();
            this.register_password = new System.Windows.Forms.TextBox();
            this.register_username = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.Red;
            this.close.ForeColor = System.Drawing.Color.White;
            this.close.Location = new System.Drawing.Point(866, 19);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(71, 38);
            this.close.TabIndex = 3;
            this.close.Text = "X";
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.register_showpassword);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.register_cpassword);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.register_label);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.signup_button);
            this.panel1.Controls.Add(this.register_password);
            this.panel1.Controls.Add(this.register_username);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(143, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(634, 514);
            this.panel1.TabIndex = 2;
            // 
            // register_showpassword
            // 
            this.register_showpassword.AutoSize = true;
            this.register_showpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_showpassword.Location = new System.Drawing.Point(314, 344);
            this.register_showpassword.Name = "register_showpassword";
            this.register_showpassword.Size = new System.Drawing.Size(238, 29);
            this.register_showpassword.TabIndex = 10;
            this.register_showpassword.Text = "SHOW PASSWORD";
            this.register_showpassword.UseVisualStyleBackColor = true;
            this.register_showpassword.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::InventoryManagementSystem_POS_.Properties.Resources.icons8_password_24;
            this.pictureBox3.Location = new System.Drawing.Point(114, 287);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(44, 44);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // register_cpassword
            // 
            this.register_cpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_cpassword.Location = new System.Drawing.Point(164, 287);
            this.register_cpassword.Name = "register_cpassword";
            this.register_cpassword.Size = new System.Drawing.Size(388, 44);
            this.register_cpassword.TabIndex = 8;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::InventoryManagementSystem_POS_.Properties.Resources.icons8_password_24;
            this.pictureBox2.Location = new System.Drawing.Point(114, 227);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(44, 44);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::InventoryManagementSystem_POS_.Properties.Resources.icons8_user_30;
            this.pictureBox1.Location = new System.Drawing.Point(114, 167);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // register_label
            // 
            this.register_label.AutoSize = true;
            this.register_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.register_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.register_label.ForeColor = System.Drawing.Color.DodgerBlue;
            this.register_label.Location = new System.Drawing.Point(372, 455);
            this.register_label.Name = "register_label";
            this.register_label.Size = new System.Drawing.Size(129, 20);
            this.register_label.TabIndex = 5;
            this.register_label.Text = "- SIGN-IN HERE";
            this.register_label.Click += new System.EventHandler(this.register_label_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 455);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "ALREADY HAVE AN ACCOUNT?";
            // 
            // signup_button
            // 
            this.signup_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.signup_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_button.ForeColor = System.Drawing.Color.White;
            this.signup_button.Location = new System.Drawing.Point(114, 379);
            this.signup_button.Name = "signup_button";
            this.signup_button.Size = new System.Drawing.Size(444, 53);
            this.signup_button.TabIndex = 3;
            this.signup_button.Text = "SIGN UP";
            this.signup_button.UseVisualStyleBackColor = false;
            this.signup_button.Click += new System.EventHandler(this.signup_button_Click);
            // 
            // register_password
            // 
            this.register_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_password.Location = new System.Drawing.Point(164, 227);
            this.register_password.Name = "register_password";
            this.register_password.Size = new System.Drawing.Size(388, 44);
            this.register_password.TabIndex = 2;
            // 
            // register_username
            // 
            this.register_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_username.Location = new System.Drawing.Point(164, 167);
            this.register_username.Name = "register_username";
            this.register_username.Size = new System.Drawing.Size(388, 44);
            this.register_username.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(225, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "REGISTER ACCOUNT";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(958, 674);
            this.Controls.Add(this.close);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox register_cpassword;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label register_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button signup_button;
        private System.Windows.Forms.TextBox register_password;
        private System.Windows.Forms.TextBox register_username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox register_showpassword;
    }
}