namespace InventoryManagementSystem_POS_
{
    partial class AdminAddCategories
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
            this.addCategories_clearBtn = new System.Windows.Forms.Button();
            this.addCategories_removeBtn = new System.Windows.Forms.Button();
            this.addCategories_updateBtn = new System.Windows.Forms.Button();
            this.addCategories_addBtn = new System.Windows.Forms.Button();
            this.addCategories_category = new System.Windows.Forms.TextBox();
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
            this.panel1.Controls.Add(this.addCategories_clearBtn);
            this.panel1.Controls.Add(this.addCategories_removeBtn);
            this.panel1.Controls.Add(this.addCategories_updateBtn);
            this.panel1.Controls.Add(this.addCategories_addBtn);
            this.panel1.Controls.Add(this.addCategories_category);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(7, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(383, 802);
            this.panel1.TabIndex = 14;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // addCategories_clearBtn
            // 
            this.addCategories_clearBtn.BackColor = System.Drawing.Color.Silver;
            this.addCategories_clearBtn.Location = new System.Drawing.Point(196, 301);
            this.addCategories_clearBtn.Name = "addCategories_clearBtn";
            this.addCategories_clearBtn.Size = new System.Drawing.Size(150, 69);
            this.addCategories_clearBtn.TabIndex = 11;
            this.addCategories_clearBtn.Text = "CLEAR";
            this.addCategories_clearBtn.UseVisualStyleBackColor = false;
            this.addCategories_clearBtn.Click += new System.EventHandler(this.addCategories_clearBtn_Click);
            // 
            // addCategories_removeBtn
            // 
            this.addCategories_removeBtn.BackColor = System.Drawing.Color.Silver;
            this.addCategories_removeBtn.Location = new System.Drawing.Point(32, 301);
            this.addCategories_removeBtn.Name = "addCategories_removeBtn";
            this.addCategories_removeBtn.Size = new System.Drawing.Size(150, 69);
            this.addCategories_removeBtn.TabIndex = 10;
            this.addCategories_removeBtn.Text = "REMOVE";
            this.addCategories_removeBtn.UseVisualStyleBackColor = false;
            this.addCategories_removeBtn.Click += new System.EventHandler(this.addCategories_removeBtn_Click);
            // 
            // addCategories_updateBtn
            // 
            this.addCategories_updateBtn.BackColor = System.Drawing.Color.Silver;
            this.addCategories_updateBtn.Location = new System.Drawing.Point(196, 205);
            this.addCategories_updateBtn.Name = "addCategories_updateBtn";
            this.addCategories_updateBtn.Size = new System.Drawing.Size(150, 69);
            this.addCategories_updateBtn.TabIndex = 9;
            this.addCategories_updateBtn.Text = "UPDATE";
            this.addCategories_updateBtn.UseVisualStyleBackColor = false;
            this.addCategories_updateBtn.Click += new System.EventHandler(this.addCategories_updateBtn_Click);
            // 
            // addCategories_addBtn
            // 
            this.addCategories_addBtn.BackColor = System.Drawing.Color.Silver;
            this.addCategories_addBtn.Location = new System.Drawing.Point(32, 205);
            this.addCategories_addBtn.Name = "addCategories_addBtn";
            this.addCategories_addBtn.Size = new System.Drawing.Size(150, 69);
            this.addCategories_addBtn.TabIndex = 8;
            this.addCategories_addBtn.Text = "ADD";
            this.addCategories_addBtn.UseVisualStyleBackColor = false;
            this.addCategories_addBtn.Click += new System.EventHandler(this.addCategories_addBtn_Click);
            // 
            // addCategories_category
            // 
            this.addCategories_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCategories_category.Location = new System.Drawing.Point(32, 133);
            this.addCategories_category.Name = "addCategories_category";
            this.addCategories_category.Size = new System.Drawing.Size(314, 30);
            this.addCategories_category.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "CATEGORY";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(404, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "ALL CATEGORIES";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(401, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1016, 751);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // AdminAddCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Name = "AdminAddCategories";
            this.Size = new System.Drawing.Size(1424, 802);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button addCategories_clearBtn;
        private System.Windows.Forms.Button addCategories_removeBtn;
        private System.Windows.Forms.Button addCategories_updateBtn;
        private System.Windows.Forms.Button addCategories_addBtn;
        private System.Windows.Forms.TextBox addCategories_category;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
