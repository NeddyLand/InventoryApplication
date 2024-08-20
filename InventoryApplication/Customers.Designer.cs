namespace InventoryApplication
{
    partial class Customers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customers));
            this.dataGridCustomers = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnClearFields = new System.Windows.Forms.Button();
            this.txtCustomerBalance = new System.Windows.Forms.TextBox();
            this.btnCreateNewCustomer = new System.Windows.Forms.Button();
            this.label29 = new System.Windows.Forms.Label();
            this.txtCustomerAddress = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtCustomerCity = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.txtCustomerEmail = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.btnDeleteCustomer = new System.Windows.Forms.Button();
            this.btnUpdateCustomer = new System.Windows.Forms.Button();
            this.txtCustomerPhone = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtCustomerLastName = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txtCustomerFirstName = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.txtCustomerSearch = new System.Windows.Forms.TextBox();
            this.btnRefreshCustomers = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCustomers)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridCustomers
            // 
            this.dataGridCustomers.AllowUserToAddRows = false;
            this.dataGridCustomers.AllowUserToDeleteRows = false;
            this.dataGridCustomers.AllowUserToResizeRows = false;
            this.dataGridCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridCustomers.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCustomers.Location = new System.Drawing.Point(10, 65);
            this.dataGridCustomers.MultiSelect = false;
            this.dataGridCustomers.Name = "dataGridCustomers";
            this.dataGridCustomers.ReadOnly = true;
            this.dataGridCustomers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridCustomers.Size = new System.Drawing.Size(655, 544);
            this.dataGridCustomers.TabIndex = 8;
            this.dataGridCustomers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCustomers_CellClick);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Transparent;
            this.groupBox5.Controls.Add(this.btnClearFields);
            this.groupBox5.Controls.Add(this.txtCustomerBalance);
            this.groupBox5.Controls.Add(this.btnCreateNewCustomer);
            this.groupBox5.Controls.Add(this.label29);
            this.groupBox5.Controls.Add(this.txtCustomerAddress);
            this.groupBox5.Controls.Add(this.label21);
            this.groupBox5.Controls.Add(this.txtCustomerCity);
            this.groupBox5.Controls.Add(this.label26);
            this.groupBox5.Controls.Add(this.txtCustomerEmail);
            this.groupBox5.Controls.Add(this.label27);
            this.groupBox5.Controls.Add(this.btnDeleteCustomer);
            this.groupBox5.Controls.Add(this.btnUpdateCustomer);
            this.groupBox5.Controls.Add(this.txtCustomerPhone);
            this.groupBox5.Controls.Add(this.label22);
            this.groupBox5.Controls.Add(this.txtCustomerLastName);
            this.groupBox5.Controls.Add(this.label23);
            this.groupBox5.Controls.Add(this.txtCustomerFirstName);
            this.groupBox5.Controls.Add(this.label24);
            this.groupBox5.Controls.Add(this.txtCustomerID);
            this.groupBox5.Controls.Add(this.label25);
            this.groupBox5.Location = new System.Drawing.Point(670, 11);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(359, 600);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Информация о клиенте";
            // 
            // btnClearFields
            // 
            this.btnClearFields.Location = new System.Drawing.Point(122, 393);
            this.btnClearFields.Margin = new System.Windows.Forms.Padding(2);
            this.btnClearFields.Name = "btnClearFields";
            this.btnClearFields.Size = new System.Drawing.Size(102, 32);
            this.btnClearFields.TabIndex = 33;
            this.btnClearFields.Text = "Очистка";
            this.btnClearFields.UseVisualStyleBackColor = true;
            this.btnClearFields.Click += new System.EventHandler(this.btnClearFields_Click);
            // 
            // txtCustomerBalance
            // 
            this.txtCustomerBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerBalance.Location = new System.Drawing.Point(43, 355);
            this.txtCustomerBalance.Name = "txtCustomerBalance";
            this.txtCustomerBalance.Size = new System.Drawing.Size(273, 22);
            this.txtCustomerBalance.TabIndex = 32;
            // 
            // btnCreateNewCustomer
            // 
            this.btnCreateNewCustomer.Location = new System.Drawing.Point(43, 446);
            this.btnCreateNewCustomer.Name = "btnCreateNewCustomer";
            this.btnCreateNewCustomer.Size = new System.Drawing.Size(272, 41);
            this.btnCreateNewCustomer.TabIndex = 16;
            this.btnCreateNewCustomer.Text = "Создать нового клиента";
            this.btnCreateNewCustomer.UseVisualStyleBackColor = true;
            this.btnCreateNewCustomer.Click += new System.EventHandler(this.btnCreateNewCustomer_Click);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(40, 336);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(55, 16);
            this.label29.TabIndex = 31;
            this.label29.Text = "Баланс";
            // 
            // txtCustomerAddress
            // 
            this.txtCustomerAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerAddress.Location = new System.Drawing.Point(43, 310);
            this.txtCustomerAddress.Name = "txtCustomerAddress";
            this.txtCustomerAddress.Size = new System.Drawing.Size(273, 22);
            this.txtCustomerAddress.TabIndex = 30;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(40, 292);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(47, 16);
            this.label21.TabIndex = 29;
            this.label21.Text = "Адрес";
            // 
            // txtCustomerCity
            // 
            this.txtCustomerCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerCity.Location = new System.Drawing.Point(43, 266);
            this.txtCustomerCity.Name = "txtCustomerCity";
            this.txtCustomerCity.Size = new System.Drawing.Size(273, 22);
            this.txtCustomerCity.TabIndex = 28;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(40, 248);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(46, 16);
            this.label26.TabIndex = 27;
            this.label26.Text = "Город";
            // 
            // txtCustomerEmail
            // 
            this.txtCustomerEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerEmail.Location = new System.Drawing.Point(43, 223);
            this.txtCustomerEmail.Name = "txtCustomerEmail";
            this.txtCustomerEmail.Size = new System.Drawing.Size(273, 22);
            this.txtCustomerEmail.TabIndex = 26;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(40, 203);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(41, 16);
            this.label27.TabIndex = 25;
            this.label27.Text = "Email";
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.ForeColor = System.Drawing.Color.Red;
            this.btnDeleteCustomer.Location = new System.Drawing.Point(43, 540);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(272, 41);
            this.btnDeleteCustomer.TabIndex = 24;
            this.btnDeleteCustomer.Text = "Удалить клиента";
            this.btnDeleteCustomer.UseVisualStyleBackColor = true;
            this.btnDeleteCustomer.Click += new System.EventHandler(this.btnDeleteCustomer_Click);
            // 
            // btnUpdateCustomer
            // 
            this.btnUpdateCustomer.Location = new System.Drawing.Point(43, 493);
            this.btnUpdateCustomer.Name = "btnUpdateCustomer";
            this.btnUpdateCustomer.Size = new System.Drawing.Size(272, 41);
            this.btnUpdateCustomer.TabIndex = 15;
            this.btnUpdateCustomer.Text = "Обновить информацию о клиенте";
            this.btnUpdateCustomer.UseVisualStyleBackColor = true;
            this.btnUpdateCustomer.Click += new System.EventHandler(this.btnUpdateCustomer_Click);
            // 
            // txtCustomerPhone
            // 
            this.txtCustomerPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerPhone.Location = new System.Drawing.Point(43, 178);
            this.txtCustomerPhone.Name = "txtCustomerPhone";
            this.txtCustomerPhone.Size = new System.Drawing.Size(273, 22);
            this.txtCustomerPhone.TabIndex = 23;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(40, 159);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(67, 16);
            this.label22.TabIndex = 22;
            this.label22.Text = "Телефон";
            // 
            // txtCustomerLastName
            // 
            this.txtCustomerLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerLastName.Location = new System.Drawing.Point(43, 133);
            this.txtCustomerLastName.Name = "txtCustomerLastName";
            this.txtCustomerLastName.Size = new System.Drawing.Size(273, 22);
            this.txtCustomerLastName.TabIndex = 21;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(40, 115);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(73, 16);
            this.label23.TabIndex = 20;
            this.label23.Text = "Фалимия";
            // 
            // txtCustomerFirstName
            // 
            this.txtCustomerFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerFirstName.Location = new System.Drawing.Point(43, 89);
            this.txtCustomerFirstName.Name = "txtCustomerFirstName";
            this.txtCustomerFirstName.Size = new System.Drawing.Size(273, 22);
            this.txtCustomerFirstName.TabIndex = 19;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(40, 70);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(36, 16);
            this.label24.TabIndex = 18;
            this.label24.Text = "Имя";
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerID.Location = new System.Drawing.Point(43, 42);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.ReadOnly = true;
            this.txtCustomerID.Size = new System.Drawing.Size(273, 22);
            this.txtCustomerID.TabIndex = 17;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(40, 24);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(20, 16);
            this.label25.TabIndex = 16;
            this.label25.Text = "ID";
            // 
            // txtCustomerSearch
            // 
            this.txtCustomerSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerSearch.Location = new System.Drawing.Point(10, 31);
            this.txtCustomerSearch.Name = "txtCustomerSearch";
            this.txtCustomerSearch.Size = new System.Drawing.Size(531, 29);
            this.txtCustomerSearch.TabIndex = 17;
            this.txtCustomerSearch.TextChanged += new System.EventHandler(this.txtCustomerSearch_TextChanged);
            // 
            // btnRefreshCustomers
            // 
            this.btnRefreshCustomers.Location = new System.Drawing.Point(547, 31);
            this.btnRefreshCustomers.Name = "btnRefreshCustomers";
            this.btnRefreshCustomers.Size = new System.Drawing.Size(117, 29);
            this.btnRefreshCustomers.TabIndex = 18;
            this.btnRefreshCustomers.Text = "Обновить";
            this.btnRefreshCustomers.UseVisualStyleBackColor = true;
            this.btnRefreshCustomers.Click += new System.EventHandler(this.btnRefreshCustomers_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 11);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 17);
            this.label6.TabIndex = 27;
            this.label6.Text = "Поиск по Фамилии";
            // 
            // Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 621);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnRefreshCustomers);
            this.Controls.Add(this.txtCustomerSearch);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.dataGridCustomers);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Customers";
            this.Text = "Клиенты";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCustomers)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridCustomers;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtCustomerBalance;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox txtCustomerAddress;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtCustomerCity;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtCustomerEmail;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Button btnDeleteCustomer;
        private System.Windows.Forms.Button btnUpdateCustomer;
        private System.Windows.Forms.TextBox txtCustomerPhone;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtCustomerLastName;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtCustomerFirstName;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Button btnCreateNewCustomer;
        private System.Windows.Forms.TextBox txtCustomerSearch;
        private System.Windows.Forms.Button btnRefreshCustomers;
        private System.Windows.Forms.Button btnClearFields;
        private System.Windows.Forms.Label label6;
    }
}