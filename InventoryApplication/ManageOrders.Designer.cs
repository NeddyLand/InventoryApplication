﻿namespace InventoryApplication
{
    partial class ManageOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageOrders));
            this.dataGridOrders = new System.Windows.Forms.DataGridView();
            this.dataGridSales = new System.Windows.Forms.DataGridView();
            this.txtSearchOrderID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeleteOrder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSales)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridOrders
            // 
            this.dataGridOrders.AllowUserToAddRows = false;
            this.dataGridOrders.AllowUserToDeleteRows = false;
            this.dataGridOrders.AllowUserToResizeColumns = false;
            this.dataGridOrders.AllowUserToResizeRows = false;
            this.dataGridOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridOrders.Location = new System.Drawing.Point(9, 60);
            this.dataGridOrders.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridOrders.MultiSelect = false;
            this.dataGridOrders.Name = "dataGridOrders";
            this.dataGridOrders.ReadOnly = true;
            this.dataGridOrders.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridOrders.RowTemplate.Height = 24;
            this.dataGridOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridOrders.Size = new System.Drawing.Size(552, 268);
            this.dataGridOrders.TabIndex = 0;
            this.dataGridOrders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridOrders_CellClick);
            // 
            // dataGridSales
            // 
            this.dataGridSales.AllowUserToAddRows = false;
            this.dataGridSales.AllowUserToDeleteRows = false;
            this.dataGridSales.AllowUserToResizeColumns = false;
            this.dataGridSales.AllowUserToResizeRows = false;
            this.dataGridSales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSales.Location = new System.Drawing.Point(580, 60);
            this.dataGridSales.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridSales.MultiSelect = false;
            this.dataGridSales.Name = "dataGridSales";
            this.dataGridSales.ReadOnly = true;
            this.dataGridSales.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridSales.RowTemplate.Height = 24;
            this.dataGridSales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridSales.Size = new System.Drawing.Size(560, 268);
            this.dataGridSales.TabIndex = 2;
            // 
            // txtSearchOrderID
            // 
            this.txtSearchOrderID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchOrderID.Location = new System.Drawing.Point(9, 30);
            this.txtSearchOrderID.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchOrderID.Name = "txtSearchOrderID";
            this.txtSearchOrderID.Size = new System.Drawing.Size(262, 26);
            this.txtSearchOrderID.TabIndex = 4;
            this.txtSearchOrderID.TextChanged += new System.EventHandler(this.txtSearchOrderID_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Поиск по ID заказа";
            // 
            // btnDeleteOrder
            // 
            this.btnDeleteOrder.ForeColor = System.Drawing.Color.Red;
            this.btnDeleteOrder.Location = new System.Drawing.Point(376, 20);
            this.btnDeleteOrder.Name = "btnDeleteOrder";
            this.btnDeleteOrder.Size = new System.Drawing.Size(185, 35);
            this.btnDeleteOrder.TabIndex = 10;
            this.btnDeleteOrder.Text = "Удалить Заказ";
            this.btnDeleteOrder.UseVisualStyleBackColor = true;
            this.btnDeleteOrder.Click += new System.EventHandler(this.btnDeleteOrder_Click);
            // 
            // ManageOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 375);
            this.Controls.Add(this.btnDeleteOrder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearchOrderID);
            this.Controls.Add(this.dataGridSales);
            this.Controls.Add(this.dataGridOrders);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ManageOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "История заказов";
            this.Load += new System.EventHandler(this.ManageOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridOrders;
        private System.Windows.Forms.DataGridView dataGridSales;
        private System.Windows.Forms.TextBox txtSearchOrderID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeleteOrder;
    }
}