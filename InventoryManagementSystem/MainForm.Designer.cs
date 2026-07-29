namespace InventoryManagementSystem
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvInventory = new DataGridView();
            grpProductInfo = new GroupBox();
            btnClear = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            nudPrice = new NumericUpDown();
            nudQuantity = new NumericUpDown();
            cmbCategory = new ComboBox();
            txtName = new TextBox();
            txtSku = new TextBox();
            lblPrice = new Label();
            lblQuantity = new Label();
            lblCategory = new Label();
            lblName = new Label();
            lblSku = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvInventory).BeginInit();
            grpProductInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
            SuspendLayout();
            // 
            // dgvInventory
            // 
            dgvInventory.AllowUserToAddRows = false;
            dgvInventory.AllowUserToDeleteRows = false;
            dgvInventory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInventory.Location = new Point(20, 20);
            dgvInventory.MultiSelect = false;
            dgvInventory.Name = "dgvInventory";
            dgvInventory.ReadOnly = true;
            dgvInventory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInventory.Size = new Size(760, 620);
            dgvInventory.TabIndex = 0;
            dgvInventory.CellContentClick += dgvInventory_CellContentClick;
            // 
            // grpProductInfo
            // 
            grpProductInfo.Controls.Add(btnClear);
            grpProductInfo.Controls.Add(btnDelete);
            grpProductInfo.Controls.Add(btnUpdate);
            grpProductInfo.Controls.Add(btnAdd);
            grpProductInfo.Controls.Add(nudPrice);
            grpProductInfo.Controls.Add(nudQuantity);
            grpProductInfo.Controls.Add(cmbCategory);
            grpProductInfo.Controls.Add(txtName);
            grpProductInfo.Controls.Add(txtSku);
            grpProductInfo.Controls.Add(lblPrice);
            grpProductInfo.Controls.Add(lblQuantity);
            grpProductInfo.Controls.Add(lblCategory);
            grpProductInfo.Controls.Add(lblName);
            grpProductInfo.Controls.Add(lblSku);
            grpProductInfo.Location = new Point(800, 20);
            grpProductInfo.Name = "grpProductInfo";
            grpProductInfo.Size = new Size(360, 430);
            grpProductInfo.TabIndex = 1;
            grpProductInfo.TabStop = false;
            grpProductInfo.Text = "Product Information";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(163, 323);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 13;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += this.btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(163, 294);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(163, 265);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(163, 236);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // nudPrice
            // 
            nudPrice.DecimalPlaces = 2;
            nudPrice.Increment = new decimal(new int[] { 25, 0, 0, 131072 });
            nudPrice.Location = new Point(143, 192);
            nudPrice.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudPrice.Name = "nudPrice";
            nudPrice.Size = new Size(120, 23);
            nudPrice.TabIndex = 9;
            // 
            // nudQuantity
            // 
            nudQuantity.Location = new Point(143, 151);
            nudQuantity.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new Size(120, 23);
            nudQuantity.TabIndex = 8;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(142, 112);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(121, 23);
            cmbCategory.TabIndex = 7;
            // 
            // txtName
            // 
            txtName.Location = new Point(142, 73);
            txtName.Name = "txtName";
            txtName.Size = new Size(121, 23);
            txtName.TabIndex = 6;
            // 
            // txtSku
            // 
            txtSku.Location = new Point(142, 34);
            txtSku.Name = "txtSku";
            txtSku.Size = new Size(121, 23);
            txtSku.TabIndex = 5;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(52, 194);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(61, 15);
            lblPrice.TabIndex = 4;
            lblPrice.Text = "Unit Price:";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(57, 153);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(56, 15);
            lblQuantity.TabIndex = 3;
            lblQuantity.Text = "Quantity:";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(55, 115);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(58, 15);
            lblCategory.TabIndex = 2;
            lblCategory.Text = "Category:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(26, 76);
            lblName.Name = "lblName";
            lblName.Size = new Size(87, 15);
            lblName.TabIndex = 1;
            lblName.Text = "Product Name:";
            // 
            // lblSku
            // 
            lblSku.AutoSize = true;
            lblSku.Location = new Point(82, 42);
            lblSku.Name = "lblSku";
            lblSku.Size = new Size(31, 15);
            lblSku.TabIndex = 0;
            lblSku.Text = "SKU:";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 661);
            Controls.Add(grpProductInfo);
            Controls.Add(dgvInventory);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inventory Management System";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvInventory).EndInit();
            grpProductInfo.ResumeLayout(false);
            grpProductInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvInventory;
        private GroupBox grpProductInfo;
        private NumericUpDown nudPrice;
        private NumericUpDown nudQuantity;
        private ComboBox cmbCategory;
        private TextBox txtName;
        private TextBox txtSku;
        private Label lblPrice;
        private Label lblQuantity;
        private Label lblCategory;
        private Label lblName;
        private Label lblSku;
        private Button btnClear;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
    }
}
