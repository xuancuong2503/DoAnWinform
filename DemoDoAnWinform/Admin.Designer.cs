namespace DemoDoAnWinform
{
    partial class Admin
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
            this.tcAmin = new System.Windows.Forms.TabControl();
            this.tpBill = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnViewBill = new System.Windows.Forms.Button();
            this.dtpkToDate = new System.Windows.Forms.DateTimePicker();
            this.dtpkFromDate = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvBill = new System.Windows.Forms.DataGridView();
            this.tpFood = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtFoodName = new System.Windows.Forms.TextBox();
            this.btnSearchFood = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.nmFoodPrice = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.cbFoodCategory = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSearchFoodName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFoodID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnShowFood = new System.Windows.Forms.Button();
            this.btnEditSua = new System.Windows.Forms.Button();
            this.btnDeleteXoa = new System.Windows.Forms.Button();
            this.btnAddFood = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvFood = new System.Windows.Forms.DataGridView();
            this.tbFoodCategory = new System.Windows.Forms.TabPage();
            this.panel10 = new System.Windows.Forms.Panel();
            this.txtDanhMuc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFoodCatogeryID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.dgrCategory = new System.Windows.Forms.DataGridView();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnShowCategory = new System.Windows.Forms.Button();
            this.btnEditCategory = new System.Windows.Forms.Button();
            this.btnDeleteCategory = new System.Windows.Forms.Button();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.tpMonChinh = new System.Windows.Forms.TabPage();
            this.panel12 = new System.Windows.Forms.Panel();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMainFood = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.dgrMainFood = new System.Windows.Forms.DataGridView();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnShowMainFood = new System.Windows.Forms.Button();
            this.btnEditMainFood = new System.Windows.Forms.Button();
            this.btnDeleteMainFood = new System.Windows.Forms.Button();
            this.btnAddMainFood = new System.Windows.Forms.Button();
            this.tpAdmin = new System.Windows.Forms.TabPage();
            this.panel16 = new System.Windows.Forms.Panel();
            this.dgrAccount = new System.Windows.Forms.DataGridView();
            this.panel14 = new System.Windows.Forms.Panel();
            this.btnResetPassword = new System.Windows.Forms.Button();
            this.cbAccountName = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.panel15 = new System.Windows.Forms.Panel();
            this.btnShowAccount = new System.Windows.Forms.Button();
            this.btnEditAccount = new System.Windows.Forms.Button();
            this.btnDeleteAccount = new System.Windows.Forms.Button();
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.tcAmin.SuspendLayout();
            this.tpBill.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).BeginInit();
            this.tpFood.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmFoodPrice)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFood)).BeginInit();
            this.tbFoodCategory.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrCategory)).BeginInit();
            this.panel7.SuspendLayout();
            this.tpMonChinh.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrMainFood)).BeginInit();
            this.panel9.SuspendLayout();
            this.tpAdmin.SuspendLayout();
            this.panel16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrAccount)).BeginInit();
            this.panel14.SuspendLayout();
            this.panel15.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcAmin
            // 
            this.tcAmin.Controls.Add(this.tpBill);
            this.tcAmin.Controls.Add(this.tpFood);
            this.tcAmin.Controls.Add(this.tbFoodCategory);
            this.tcAmin.Controls.Add(this.tpMonChinh);
            this.tcAmin.Controls.Add(this.tpAdmin);
            this.tcAmin.Location = new System.Drawing.Point(12, 12);
            this.tcAmin.Name = "tcAmin";
            this.tcAmin.SelectedIndex = 0;
            this.tcAmin.Size = new System.Drawing.Size(742, 439);
            this.tcAmin.TabIndex = 0;
            // 
            // tpBill
            // 
            this.tpBill.Controls.Add(this.panel2);
            this.tpBill.Controls.Add(this.panel1);
            this.tpBill.Location = new System.Drawing.Point(4, 25);
            this.tpBill.Name = "tpBill";
            this.tpBill.Padding = new System.Windows.Forms.Padding(3);
            this.tpBill.Size = new System.Drawing.Size(734, 410);
            this.tpBill.TabIndex = 0;
            this.tpBill.Text = "Doanh Thu";
            this.tpBill.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnViewBill);
            this.panel2.Controls.Add(this.dtpkToDate);
            this.panel2.Controls.Add(this.dtpkFromDate);
            this.panel2.Location = new System.Drawing.Point(7, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(692, 27);
            this.panel2.TabIndex = 1;
            // 
            // btnViewBill
            // 
            this.btnViewBill.Location = new System.Drawing.Point(308, 2);
            this.btnViewBill.Name = "btnViewBill";
            this.btnViewBill.Size = new System.Drawing.Size(75, 23);
            this.btnViewBill.TabIndex = 2;
            this.btnViewBill.Text = "Thống Kê";
            this.btnViewBill.UseVisualStyleBackColor = true;
            // 
            // dtpkToDate
            // 
            this.dtpkToDate.Location = new System.Drawing.Point(488, 0);
            this.dtpkToDate.Name = "dtpkToDate";
            this.dtpkToDate.Size = new System.Drawing.Size(200, 22);
            this.dtpkToDate.TabIndex = 1;
            // 
            // dtpkFromDate
            // 
            this.dtpkFromDate.Location = new System.Drawing.Point(0, 0);
            this.dtpkFromDate.Name = "dtpkFromDate";
            this.dtpkFromDate.Size = new System.Drawing.Size(200, 22);
            this.dtpkFromDate.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvBill);
            this.panel1.Location = new System.Drawing.Point(5, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(695, 345);
            this.panel1.TabIndex = 0;
            // 
            // dgvBill
            // 
            this.dgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBill.Location = new System.Drawing.Point(5, 6);
            this.dgvBill.Name = "dgvBill";
            this.dgvBill.RowHeadersWidth = 51;
            this.dgvBill.RowTemplate.Height = 24;
            this.dgvBill.Size = new System.Drawing.Size(688, 334);
            this.dgvBill.TabIndex = 0;
            // 
            // tpFood
            // 
            this.tpFood.Controls.Add(this.panel6);
            this.tpFood.Controls.Add(this.panel5);
            this.tpFood.Controls.Add(this.panel4);
            this.tpFood.Controls.Add(this.panel3);
            this.tpFood.Location = new System.Drawing.Point(4, 25);
            this.tpFood.Name = "tpFood";
            this.tpFood.Padding = new System.Windows.Forms.Padding(3);
            this.tpFood.Size = new System.Drawing.Size(734, 410);
            this.tpFood.TabIndex = 1;
            this.tpFood.Text = "Thức Ăn";
            this.tpFood.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txtFoodName);
            this.panel6.Controls.Add(this.btnSearchFood);
            this.panel6.Location = new System.Drawing.Point(375, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(325, 56);
            this.panel6.TabIndex = 3;
            // 
            // txtFoodName
            // 
            this.txtFoodName.Location = new System.Drawing.Point(6, 17);
            this.txtFoodName.Name = "txtFoodName";
            this.txtFoodName.Size = new System.Drawing.Size(241, 22);
            this.txtFoodName.TabIndex = 1;
            // 
            // btnSearchFood
            // 
            this.btnSearchFood.Location = new System.Drawing.Point(248, 0);
            this.btnSearchFood.Name = "btnSearchFood";
            this.btnSearchFood.Size = new System.Drawing.Size(75, 56);
            this.btnSearchFood.TabIndex = 0;
            this.btnSearchFood.Text = "Tìm Kiếm";
            this.btnSearchFood.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.nmFoodPrice);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.cbFoodCategory);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.txtSearchFoodName);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.txtFoodID);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Location = new System.Drawing.Point(375, 60);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(325, 323);
            this.panel5.TabIndex = 2;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // nmFoodPrice
            // 
            this.nmFoodPrice.Location = new System.Drawing.Point(105, 149);
            this.nmFoodPrice.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nmFoodPrice.Name = "nmFoodPrice";
            this.nmFoodPrice.Size = new System.Drawing.Size(215, 22);
            this.nmFoodPrice.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Giá";
            // 
            // cbFoodCategory
            // 
            this.cbFoodCategory.FormattingEnabled = true;
            this.cbFoodCategory.Location = new System.Drawing.Point(105, 107);
            this.cbFoodCategory.Name = "cbFoodCategory";
            this.cbFoodCategory.Size = new System.Drawing.Size(215, 24);
            this.cbFoodCategory.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(2, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Danh Mục";
            // 
            // txtSearchFoodName
            // 
            this.txtSearchFoodName.Location = new System.Drawing.Point(105, 67);
            this.txtSearchFoodName.Name = "txtSearchFoodName";
            this.txtSearchFoodName.Size = new System.Drawing.Size(215, 22);
            this.txtSearchFoodName.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên Món";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtFoodID
            // 
            this.txtFoodID.Location = new System.Drawing.Point(105, 19);
            this.txtFoodID.Name = "txtFoodID";
            this.txtFoodID.ReadOnly = true;
            this.txtFoodID.Size = new System.Drawing.Size(215, 22);
            this.txtFoodID.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnShowFood);
            this.panel4.Controls.Add(this.btnEditSua);
            this.panel4.Controls.Add(this.btnDeleteXoa);
            this.panel4.Controls.Add(this.btnAddFood);
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(372, 56);
            this.panel4.TabIndex = 1;
            // 
            // btnShowFood
            // 
            this.btnShowFood.Location = new System.Drawing.Point(296, 0);
            this.btnShowFood.Name = "btnShowFood";
            this.btnShowFood.Size = new System.Drawing.Size(75, 56);
            this.btnShowFood.TabIndex = 0;
            this.btnShowFood.Text = "Xem";
            this.btnShowFood.UseVisualStyleBackColor = true;
            // 
            // btnEditSua
            // 
            this.btnEditSua.Location = new System.Drawing.Point(205, 0);
            this.btnEditSua.Name = "btnEditSua";
            this.btnEditSua.Size = new System.Drawing.Size(75, 56);
            this.btnEditSua.TabIndex = 0;
            this.btnEditSua.Text = "Sửa";
            this.btnEditSua.UseVisualStyleBackColor = true;
            // 
            // btnDeleteXoa
            // 
            this.btnDeleteXoa.Location = new System.Drawing.Point(102, 0);
            this.btnDeleteXoa.Name = "btnDeleteXoa";
            this.btnDeleteXoa.Size = new System.Drawing.Size(75, 56);
            this.btnDeleteXoa.TabIndex = 0;
            this.btnDeleteXoa.Text = "Xóa";
            this.btnDeleteXoa.UseVisualStyleBackColor = true;
            // 
            // btnAddFood
            // 
            this.btnAddFood.Location = new System.Drawing.Point(3, 0);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(75, 56);
            this.btnAddFood.TabIndex = 0;
            this.btnAddFood.Text = "Thêm";
            this.btnAddFood.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvFood);
            this.panel3.Location = new System.Drawing.Point(2, 60);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(374, 324);
            this.panel3.TabIndex = 0;
            // 
            // dgvFood
            // 
            this.dgvFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFood.Location = new System.Drawing.Point(3, 3);
            this.dgvFood.Name = "dgvFood";
            this.dgvFood.RowHeadersWidth = 51;
            this.dgvFood.RowTemplate.Height = 24;
            this.dgvFood.Size = new System.Drawing.Size(369, 320);
            this.dgvFood.TabIndex = 0;
            // 
            // tbFoodCategory
            // 
            this.tbFoodCategory.Controls.Add(this.panel10);
            this.tbFoodCategory.Controls.Add(this.panel8);
            this.tbFoodCategory.Controls.Add(this.panel7);
            this.tbFoodCategory.Location = new System.Drawing.Point(4, 25);
            this.tbFoodCategory.Name = "tbFoodCategory";
            this.tbFoodCategory.Padding = new System.Windows.Forms.Padding(3);
            this.tbFoodCategory.Size = new System.Drawing.Size(734, 410);
            this.tbFoodCategory.TabIndex = 2;
            this.tbFoodCategory.Text = "Danh Mục";
            this.tbFoodCategory.UseVisualStyleBackColor = true;
            this.tbFoodCategory.Click += new System.EventHandler(this.tbFoodCategory_Click);
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.txtDanhMuc);
            this.panel10.Controls.Add(this.label7);
            this.panel10.Controls.Add(this.txtFoodCatogeryID);
            this.panel10.Controls.Add(this.label8);
            this.panel10.Location = new System.Drawing.Point(387, 70);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(341, 323);
            this.panel10.TabIndex = 5;
            // 
            // txtDanhMuc
            // 
            this.txtDanhMuc.Location = new System.Drawing.Point(155, 67);
            this.txtDanhMuc.Name = "txtDanhMuc";
            this.txtDanhMuc.Size = new System.Drawing.Size(165, 22);
            this.txtDanhMuc.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(2, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 24);
            this.label7.TabIndex = 4;
            this.label7.Text = "Tên Danh Mục";
            // 
            // txtFoodCatogeryID
            // 
            this.txtFoodCatogeryID.Location = new System.Drawing.Point(155, 19);
            this.txtFoodCatogeryID.Name = "txtFoodCatogeryID";
            this.txtFoodCatogeryID.ReadOnly = true;
            this.txtFoodCatogeryID.Size = new System.Drawing.Size(165, 22);
            this.txtFoodCatogeryID.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(5, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 24);
            this.label8.TabIndex = 2;
            this.label8.Text = "ID";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.dgrCategory);
            this.panel8.Location = new System.Drawing.Point(9, 65);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(374, 324);
            this.panel8.TabIndex = 3;
            // 
            // dgrCategory
            // 
            this.dgrCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrCategory.Location = new System.Drawing.Point(3, 5);
            this.dgrCategory.Name = "dgrCategory";
            this.dgrCategory.RowHeadersWidth = 51;
            this.dgrCategory.RowTemplate.Height = 24;
            this.dgrCategory.Size = new System.Drawing.Size(369, 318);
            this.dgrCategory.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnShowCategory);
            this.panel7.Controls.Add(this.btnEditCategory);
            this.panel7.Controls.Add(this.btnDeleteCategory);
            this.panel7.Controls.Add(this.btnAddCategory);
            this.panel7.Location = new System.Drawing.Point(6, 6);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(372, 56);
            this.panel7.TabIndex = 2;
            // 
            // btnShowCategory
            // 
            this.btnShowCategory.Location = new System.Drawing.Point(296, 0);
            this.btnShowCategory.Name = "btnShowCategory";
            this.btnShowCategory.Size = new System.Drawing.Size(75, 56);
            this.btnShowCategory.TabIndex = 0;
            this.btnShowCategory.Text = "Xem";
            this.btnShowCategory.UseVisualStyleBackColor = true;
            // 
            // btnEditCategory
            // 
            this.btnEditCategory.Location = new System.Drawing.Point(205, 0);
            this.btnEditCategory.Name = "btnEditCategory";
            this.btnEditCategory.Size = new System.Drawing.Size(75, 56);
            this.btnEditCategory.TabIndex = 0;
            this.btnEditCategory.Text = "Sửa";
            this.btnEditCategory.UseVisualStyleBackColor = true;
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.Location = new System.Drawing.Point(102, 0);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(75, 56);
            this.btnDeleteCategory.TabIndex = 0;
            this.btnDeleteCategory.Text = "Xóa";
            this.btnDeleteCategory.UseVisualStyleBackColor = true;
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Location = new System.Drawing.Point(3, 0);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(75, 56);
            this.btnAddCategory.TabIndex = 0;
            this.btnAddCategory.Text = "Thêm";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            // 
            // tpMonChinh
            // 
            this.tpMonChinh.Controls.Add(this.panel12);
            this.tpMonChinh.Controls.Add(this.panel11);
            this.tpMonChinh.Controls.Add(this.panel9);
            this.tpMonChinh.Location = new System.Drawing.Point(4, 25);
            this.tpMonChinh.Name = "tpMonChinh";
            this.tpMonChinh.Padding = new System.Windows.Forms.Padding(3);
            this.tpMonChinh.Size = new System.Drawing.Size(734, 410);
            this.tpMonChinh.TabIndex = 3;
            this.tpMonChinh.Text = "Món Chính";
            this.tpMonChinh.UseVisualStyleBackColor = true;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.cbStatus);
            this.panel12.Controls.Add(this.label9);
            this.panel12.Controls.Add(this.txtMainFood);
            this.panel12.Controls.Add(this.label5);
            this.panel12.Controls.Add(this.textBox2);
            this.panel12.Controls.Add(this.label6);
            this.panel12.Location = new System.Drawing.Point(387, 84);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(341, 323);
            this.panel12.TabIndex = 6;
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(155, 143);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(158, 24);
            this.cbStatus.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(5, 142);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 24);
            this.label9.TabIndex = 6;
            this.label9.Text = "Trạng Thái";
            // 
            // txtMainFood
            // 
            this.txtMainFood.Location = new System.Drawing.Point(155, 67);
            this.txtMainFood.Name = "txtMainFood";
            this.txtMainFood.Size = new System.Drawing.Size(165, 22);
            this.txtMainFood.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(2, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Hot Deal";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(155, 19);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(165, 22);
            this.textBox2.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(5, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 24);
            this.label6.TabIndex = 2;
            this.label6.Text = "ID";
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.dgrMainFood);
            this.panel11.Location = new System.Drawing.Point(3, 86);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(374, 324);
            this.panel11.TabIndex = 4;
            // 
            // dgrMainFood
            // 
            this.dgrMainFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrMainFood.Location = new System.Drawing.Point(3, 3);
            this.dgrMainFood.Name = "dgrMainFood";
            this.dgrMainFood.RowHeadersWidth = 51;
            this.dgrMainFood.RowTemplate.Height = 24;
            this.dgrMainFood.Size = new System.Drawing.Size(369, 320);
            this.dgrMainFood.TabIndex = 0;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.btnShowMainFood);
            this.panel9.Controls.Add(this.btnEditMainFood);
            this.panel9.Controls.Add(this.btnDeleteMainFood);
            this.panel9.Controls.Add(this.btnAddMainFood);
            this.panel9.Location = new System.Drawing.Point(3, 24);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(372, 56);
            this.panel9.TabIndex = 3;
            // 
            // btnShowMainFood
            // 
            this.btnShowMainFood.Location = new System.Drawing.Point(296, 0);
            this.btnShowMainFood.Name = "btnShowMainFood";
            this.btnShowMainFood.Size = new System.Drawing.Size(75, 56);
            this.btnShowMainFood.TabIndex = 0;
            this.btnShowMainFood.Text = "Xem";
            this.btnShowMainFood.UseVisualStyleBackColor = true;
            // 
            // btnEditMainFood
            // 
            this.btnEditMainFood.Location = new System.Drawing.Point(205, 0);
            this.btnEditMainFood.Name = "btnEditMainFood";
            this.btnEditMainFood.Size = new System.Drawing.Size(75, 56);
            this.btnEditMainFood.TabIndex = 0;
            this.btnEditMainFood.Text = "Sửa";
            this.btnEditMainFood.UseVisualStyleBackColor = true;
            // 
            // btnDeleteMainFood
            // 
            this.btnDeleteMainFood.Location = new System.Drawing.Point(102, 0);
            this.btnDeleteMainFood.Name = "btnDeleteMainFood";
            this.btnDeleteMainFood.Size = new System.Drawing.Size(75, 56);
            this.btnDeleteMainFood.TabIndex = 0;
            this.btnDeleteMainFood.Text = "Xóa";
            this.btnDeleteMainFood.UseVisualStyleBackColor = true;
            // 
            // btnAddMainFood
            // 
            this.btnAddMainFood.Location = new System.Drawing.Point(3, 0);
            this.btnAddMainFood.Name = "btnAddMainFood";
            this.btnAddMainFood.Size = new System.Drawing.Size(75, 56);
            this.btnAddMainFood.TabIndex = 0;
            this.btnAddMainFood.Text = "Thêm";
            this.btnAddMainFood.UseVisualStyleBackColor = true;
            // 
            // tpAdmin
            // 
            this.tpAdmin.Controls.Add(this.panel16);
            this.tpAdmin.Controls.Add(this.panel14);
            this.tpAdmin.Controls.Add(this.panel15);
            this.tpAdmin.Location = new System.Drawing.Point(4, 25);
            this.tpAdmin.Name = "tpAdmin";
            this.tpAdmin.Padding = new System.Windows.Forms.Padding(3);
            this.tpAdmin.Size = new System.Drawing.Size(734, 410);
            this.tpAdmin.TabIndex = 4;
            this.tpAdmin.Text = "Tài Khoản";
            this.tpAdmin.UseVisualStyleBackColor = true;
            // 
            // panel16
            // 
            this.panel16.Controls.Add(this.dgrAccount);
            this.panel16.Location = new System.Drawing.Point(16, 77);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(374, 324);
            this.panel16.TabIndex = 7;
            // 
            // dgrAccount
            // 
            this.dgrAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrAccount.Location = new System.Drawing.Point(3, 3);
            this.dgrAccount.Name = "dgrAccount";
            this.dgrAccount.RowHeadersWidth = 51;
            this.dgrAccount.RowTemplate.Height = 24;
            this.dgrAccount.Size = new System.Drawing.Size(369, 320);
            this.dgrAccount.TabIndex = 0;
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.btnResetPassword);
            this.panel14.Controls.Add(this.cbAccountName);
            this.panel14.Controls.Add(this.label11);
            this.panel14.Controls.Add(this.txtDisplay);
            this.panel14.Controls.Add(this.label12);
            this.panel14.Controls.Add(this.txtUserName);
            this.panel14.Controls.Add(this.label13);
            this.panel14.Location = new System.Drawing.Point(391, 72);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(325, 323);
            this.panel14.TabIndex = 5;
            // 
            // btnResetPassword
            // 
            this.btnResetPassword.Location = new System.Drawing.Point(245, 157);
            this.btnResetPassword.Name = "btnResetPassword";
            this.btnResetPassword.Size = new System.Drawing.Size(75, 56);
            this.btnResetPassword.TabIndex = 0;
            this.btnResetPassword.Text = "Đặt Lại ";
            this.btnResetPassword.UseVisualStyleBackColor = true;
            this.btnResetPassword.Click += new System.EventHandler(this.btnShowAccount_Click);
            // 
            // cbAccountName
            // 
            this.cbAccountName.FormattingEnabled = true;
            this.cbAccountName.Location = new System.Drawing.Point(159, 107);
            this.cbAccountName.Name = "cbAccountName";
            this.cbAccountName.Size = new System.Drawing.Size(161, 24);
            this.cbAccountName.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(2, 109);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(152, 24);
            this.label11.TabIndex = 6;
            this.label11.Text = "Loại Tài Khoản";
            // 
            // txtDisplay
            // 
            this.txtDisplay.Location = new System.Drawing.Point(159, 67);
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(161, 22);
            this.txtDisplay.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(2, 64);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(130, 24);
            this.label12.TabIndex = 4;
            this.label12.Text = "Tên Hiển Thị";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(159, 19);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.ReadOnly = true;
            this.txtUserName.Size = new System.Drawing.Size(161, 22);
            this.txtUserName.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(5, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(148, 24);
            this.label13.TabIndex = 2;
            this.label13.Text = "Tên Tài Khoản";
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.btnShowAccount);
            this.panel15.Controls.Add(this.btnEditAccount);
            this.panel15.Controls.Add(this.btnDeleteAccount);
            this.panel15.Controls.Add(this.btnAddAccount);
            this.panel15.Location = new System.Drawing.Point(19, 15);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(372, 56);
            this.panel15.TabIndex = 4;
            // 
            // btnShowAccount
            // 
            this.btnShowAccount.Location = new System.Drawing.Point(296, 0);
            this.btnShowAccount.Name = "btnShowAccount";
            this.btnShowAccount.Size = new System.Drawing.Size(75, 56);
            this.btnShowAccount.TabIndex = 0;
            this.btnShowAccount.Text = "Xem";
            this.btnShowAccount.UseVisualStyleBackColor = true;
            this.btnShowAccount.Click += new System.EventHandler(this.btnShowAccount_Click);
            // 
            // btnEditAccount
            // 
            this.btnEditAccount.Location = new System.Drawing.Point(205, 0);
            this.btnEditAccount.Name = "btnEditAccount";
            this.btnEditAccount.Size = new System.Drawing.Size(75, 56);
            this.btnEditAccount.TabIndex = 0;
            this.btnEditAccount.Text = "Sửa";
            this.btnEditAccount.UseVisualStyleBackColor = true;
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.Location = new System.Drawing.Point(102, 0);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(75, 56);
            this.btnDeleteAccount.TabIndex = 0;
            this.btnDeleteAccount.Text = "Xóa";
            this.btnDeleteAccount.UseVisualStyleBackColor = true;
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.Location = new System.Drawing.Point(3, 0);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(75, 56);
            this.btnAddAccount.TabIndex = 0;
            this.btnAddAccount.Text = "Thêm";
            this.btnAddAccount.UseVisualStyleBackColor = true;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 495);
            this.Controls.Add(this.tcAmin);
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý";
            this.tcAmin.ResumeLayout(false);
            this.tpBill.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).EndInit();
            this.tpFood.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmFoodPrice)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFood)).EndInit();
            this.tbFoodCategory.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrCategory)).EndInit();
            this.panel7.ResumeLayout(false);
            this.tpMonChinh.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrMainFood)).EndInit();
            this.panel9.ResumeLayout(false);
            this.tpAdmin.ResumeLayout(false);
            this.panel16.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrAccount)).EndInit();
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.panel15.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcAmin;
        private System.Windows.Forms.TabPage tpBill;
        private System.Windows.Forms.TabPage tpFood;
        private System.Windows.Forms.TabPage tbFoodCategory;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvBill;
        private System.Windows.Forms.TabPage tpMonChinh;
        private System.Windows.Forms.TabPage tpAdmin;
        private System.Windows.Forms.Button btnViewBill;
        private System.Windows.Forms.DateTimePicker dtpkToDate;
        private System.Windows.Forms.DateTimePicker dtpkFromDate;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvFood;
        private System.Windows.Forms.TextBox txtFoodName;
        private System.Windows.Forms.Button btnSearchFood;
        private System.Windows.Forms.Button btnShowFood;
        private System.Windows.Forms.Button btnEditSua;
        private System.Windows.Forms.Button btnDeleteXoa;
        private System.Windows.Forms.Button btnAddFood;
        private System.Windows.Forms.TextBox txtFoodID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchFoodName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nmFoodPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbFoodCategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.TextBox txtDanhMuc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFoodCatogeryID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.DataGridView dgrCategory;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnShowCategory;
        private System.Windows.Forms.Button btnEditCategory;
        private System.Windows.Forms.Button btnDeleteCategory;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btnShowMainFood;
        private System.Windows.Forms.Button btnEditMainFood;
        private System.Windows.Forms.Button btnDeleteMainFood;
        private System.Windows.Forms.Button btnAddMainFood;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMainFood;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.DataGridView dgrMainFood;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.DataGridView dgrAccount;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.ComboBox cbAccountName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Button btnShowAccount;
        private System.Windows.Forms.Button btnEditAccount;
        private System.Windows.Forms.Button btnDeleteAccount;
        private System.Windows.Forms.Button btnAddAccount;
        private System.Windows.Forms.Button btnResetPassword;
    }
}