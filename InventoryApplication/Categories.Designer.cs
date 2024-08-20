namespace InventoryApplication
{
    partial class Categories
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Categories));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnClearFields = new System.Windows.Forms.Button();
            this.btnAddNewCategory = new System.Windows.Forms.Button();
            this.btnDeleteCategory = new System.Windows.Forms.Button();
            this.btnUpdateCategory = new System.Windows.Forms.Button();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCategoryID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnRefreshCategories = new System.Windows.Forms.Button();
            this.dataGridCategories = new System.Windows.Forms.DataGridView();
            this.txtCategorySearch = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCategories)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnClearFields);
            this.groupBox3.Controls.Add(this.btnAddNewCategory);
            this.groupBox3.Controls.Add(this.btnDeleteCategory);
            this.groupBox3.Controls.Add(this.btnUpdateCategory);
            this.groupBox3.Controls.Add(this.txtCategoryName);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txtCategoryID);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(411, 31);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(259, 352);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Информация о товарной группе";
            // 
            // btnClearFields
            // 
            this.btnClearFields.Location = new System.Drawing.Point(79, 157);
            this.btnClearFields.Margin = new System.Windows.Forms.Padding(2);
            this.btnClearFields.Name = "btnClearFields";
            this.btnClearFields.Size = new System.Drawing.Size(79, 22);
            this.btnClearFields.TabIndex = 8;
            this.btnClearFields.Text = "Очистить";
            this.btnClearFields.UseVisualStyleBackColor = true;
            this.btnClearFields.Click += new System.EventHandler(this.btnClearFields_Click);
            // 
            // btnAddNewCategory
            // 
            this.btnAddNewCategory.Location = new System.Drawing.Point(44, 219);
            this.btnAddNewCategory.Name = "btnAddNewCategory";
            this.btnAddNewCategory.Size = new System.Drawing.Size(164, 32);
            this.btnAddNewCategory.TabIndex = 7;
            this.btnAddNewCategory.Text = "Добавить товарную группу";
            this.btnAddNewCategory.UseVisualStyleBackColor = true;
            this.btnAddNewCategory.Click += new System.EventHandler(this.btnAddNewCategory_Click);
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.ForeColor = System.Drawing.Color.Red;
            this.btnDeleteCategory.Location = new System.Drawing.Point(44, 297);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(164, 32);
            this.btnDeleteCategory.TabIndex = 7;
            this.btnDeleteCategory.Text = "Удалить товарную группу";
            this.btnDeleteCategory.UseVisualStyleBackColor = true;
            this.btnDeleteCategory.Click += new System.EventHandler(this.btnDeleteCategory_Click);
            // 
            // btnUpdateCategory
            // 
            this.btnUpdateCategory.Location = new System.Drawing.Point(44, 258);
            this.btnUpdateCategory.Name = "btnUpdateCategory";
            this.btnUpdateCategory.Size = new System.Drawing.Size(164, 32);
            this.btnUpdateCategory.TabIndex = 6;
            this.btnUpdateCategory.Text = "Обновить товарную группу";
            this.btnUpdateCategory.UseVisualStyleBackColor = true;
            this.btnUpdateCategory.Click += new System.EventHandler(this.btnUpdateCategory_Click);
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Location = new System.Drawing.Point(44, 104);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(164, 20);
            this.txtCategoryName.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(41, 87);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Наименование";
            // 
            // txtCategoryID
            // 
            this.txtCategoryID.Location = new System.Drawing.Point(44, 59);
            this.txtCategoryID.Name = "txtCategoryID";
            this.txtCategoryID.ReadOnly = true;
            this.txtCategoryID.Size = new System.Drawing.Size(164, 20);
            this.txtCategoryID.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(41, 42);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "ID";
            // 
            // btnRefreshCategories
            // 
            this.btnRefreshCategories.Location = new System.Drawing.Point(264, 37);
            this.btnRefreshCategories.Name = "btnRefreshCategories";
            this.btnRefreshCategories.Size = new System.Drawing.Size(141, 29);
            this.btnRefreshCategories.TabIndex = 8;
            this.btnRefreshCategories.Text = "Обновить";
            this.btnRefreshCategories.UseVisualStyleBackColor = true;
            this.btnRefreshCategories.Click += new System.EventHandler(this.btnRefreshCategories_Click);
            // 
            // dataGridCategories
            // 
            this.dataGridCategories.AllowDrop = true;
            this.dataGridCategories.AllowUserToAddRows = false;
            this.dataGridCategories.AllowUserToDeleteRows = false;
            this.dataGridCategories.AllowUserToOrderColumns = true;
            this.dataGridCategories.AllowUserToResizeRows = false;
            this.dataGridCategories.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridCategories.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCategories.Location = new System.Drawing.Point(26, 72);
            this.dataGridCategories.MultiSelect = false;
            this.dataGridCategories.Name = "dataGridCategories";
            this.dataGridCategories.ReadOnly = true;
            this.dataGridCategories.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridCategories.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridCategories.Size = new System.Drawing.Size(379, 309);
            this.dataGridCategories.TabIndex = 6;
            this.dataGridCategories.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCategories_CellClick);
            // 
            // txtCategorySearch
            // 
            this.txtCategorySearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategorySearch.Location = new System.Drawing.Point(26, 37);
            this.txtCategorySearch.Name = "txtCategorySearch";
            this.txtCategorySearch.Size = new System.Drawing.Size(232, 29);
            this.txtCategorySearch.TabIndex = 9;
            this.txtCategorySearch.TextChanged += new System.EventHandler(this.txtCategorySearch_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 17);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 17);
            this.label6.TabIndex = 27;
            this.label6.Text = "Поиск";
            // 
            // Categories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 393);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCategorySearch);
            this.Controls.Add(this.btnRefreshCategories);
            this.Controls.Add(this.dataGridCategories);
            this.Controls.Add(this.groupBox3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Categories";
            this.Text = "Товарная группа";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCategories)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnDeleteCategory;
        private System.Windows.Forms.Button btnUpdateCategory;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCategoryID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnAddNewCategory;
        private System.Windows.Forms.Button btnRefreshCategories;
        private System.Windows.Forms.DataGridView dataGridCategories;
        private System.Windows.Forms.Button btnClearFields;
        private System.Windows.Forms.TextBox txtCategorySearch;
        private System.Windows.Forms.Label label6;
    }
}