namespace CSharpProject
{
    partial class AddEmployee
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnNewProduct = new System.Windows.Forms.Button();
            this.BtnManagerInfo = new System.Windows.Forms.Button();
            this.BtnDashBoard = new System.Windows.Forms.Button();
            this.BtnLogout = new System.Windows.Forms.Button();
            this.BtnSalesmanInfo = new System.Windows.Forms.Button();
            this.BtnInventory = new System.Windows.Forms.Button();
            this.BtnCategory = new System.Windows.Forms.Button();
            this.BtnAddEmployee = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblSearch = new System.Windows.Forms.Label();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.DGVEmployee = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LblInitialPass = new System.Windows.Forms.Label();
            this.TxtInitialPass = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.LblSalary = new System.Windows.Forms.Label();
            this.LblRank = new System.Windows.Forms.Label();
            this.CboxRank = new System.Windows.Forms.ComboBox();
            this.BtnInsertEmployee = new System.Windows.Forms.Button();
            this.LblAddEmployee = new System.Windows.Forms.Label();
            this.LblBirthdate = new System.Windows.Forms.Label();
            this.birthdateDTP = new System.Windows.Forms.DateTimePicker();
            this.radioBtnFemale = new System.Windows.Forms.RadioButton();
            this.radioBtnMale = new System.Windows.Forms.RadioButton();
            this.LblGender = new System.Windows.Forms.Label();
            this.LblContact = new System.Windows.Forms.Label();
            this.LblName = new System.Windows.Forms.Label();
            this.txtContactNumber = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVEmployee)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BtnNewProduct);
            this.panel2.Controls.Add(this.BtnManagerInfo);
            this.panel2.Controls.Add(this.BtnDashBoard);
            this.panel2.Controls.Add(this.BtnLogout);
            this.panel2.Controls.Add(this.BtnSalesmanInfo);
            this.panel2.Controls.Add(this.BtnInventory);
            this.panel2.Controls.Add(this.BtnCategory);
            this.panel2.Controls.Add(this.BtnAddEmployee);
            this.panel2.Location = new System.Drawing.Point(12, 109);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(150, 436);
            this.panel2.TabIndex = 1;
            // 
            // BtnNewProduct
            // 
            this.BtnNewProduct.Location = new System.Drawing.Point(3, 346);
            this.BtnNewProduct.Name = "BtnNewProduct";
            this.BtnNewProduct.Size = new System.Drawing.Size(144, 33);
            this.BtnNewProduct.TabIndex = 7;
            this.BtnNewProduct.Text = "New Product";
            this.BtnNewProduct.UseVisualStyleBackColor = true;
            this.BtnNewProduct.Click += new System.EventHandler(this.BtnNewProduct_Click);
            // 
            // BtnManagerInfo
            // 
            this.BtnManagerInfo.Location = new System.Drawing.Point(3, 307);
            this.BtnManagerInfo.Name = "BtnManagerInfo";
            this.BtnManagerInfo.Size = new System.Drawing.Size(144, 33);
            this.BtnManagerInfo.TabIndex = 6;
            this.BtnManagerInfo.Text = "ManagerInfo";
            this.BtnManagerInfo.UseVisualStyleBackColor = true;
            // 
            // BtnDashBoard
            // 
            this.BtnDashBoard.Location = new System.Drawing.Point(3, 50);
            this.BtnDashBoard.Name = "BtnDashBoard";
            this.BtnDashBoard.Size = new System.Drawing.Size(144, 33);
            this.BtnDashBoard.TabIndex = 5;
            this.BtnDashBoard.Text = "Dashboard";
            this.BtnDashBoard.UseVisualStyleBackColor = true;
            // 
            // BtnLogout
            // 
            this.BtnLogout.BackColor = System.Drawing.Color.Red;
            this.BtnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogout.Location = new System.Drawing.Point(3, 400);
            this.BtnLogout.Name = "BtnLogout";
            this.BtnLogout.Size = new System.Drawing.Size(144, 33);
            this.BtnLogout.TabIndex = 4;
            this.BtnLogout.Text = "Logout";
            this.BtnLogout.UseVisualStyleBackColor = false;
            // 
            // BtnSalesmanInfo
            // 
            this.BtnSalesmanInfo.Location = new System.Drawing.Point(3, 268);
            this.BtnSalesmanInfo.Name = "BtnSalesmanInfo";
            this.BtnSalesmanInfo.Size = new System.Drawing.Size(144, 33);
            this.BtnSalesmanInfo.TabIndex = 3;
            this.BtnSalesmanInfo.Text = "SalesmanInfo ";
            this.BtnSalesmanInfo.UseVisualStyleBackColor = true;
            // 
            // BtnInventory
            // 
            this.BtnInventory.Location = new System.Drawing.Point(3, 229);
            this.BtnInventory.Name = "BtnInventory";
            this.BtnInventory.Size = new System.Drawing.Size(144, 33);
            this.BtnInventory.TabIndex = 2;
            this.BtnInventory.Text = "Inventory";
            this.BtnInventory.UseVisualStyleBackColor = true;
            this.BtnInventory.Click += new System.EventHandler(this.BtnInventory_Click);
            // 
            // BtnCategory
            // 
            this.BtnCategory.Location = new System.Drawing.Point(3, 190);
            this.BtnCategory.Name = "BtnCategory";
            this.BtnCategory.Size = new System.Drawing.Size(144, 33);
            this.BtnCategory.TabIndex = 1;
            this.BtnCategory.Text = "Category";
            this.BtnCategory.UseVisualStyleBackColor = true;
            this.BtnCategory.Click += new System.EventHandler(this.BtnCategory_Click);
            // 
            // BtnAddEmployee
            // 
            this.BtnAddEmployee.Location = new System.Drawing.Point(3, 151);
            this.BtnAddEmployee.Name = "BtnAddEmployee";
            this.BtnAddEmployee.Size = new System.Drawing.Size(144, 33);
            this.BtnAddEmployee.TabIndex = 0;
            this.BtnAddEmployee.Text = "Add Employee";
            this.BtnAddEmployee.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LblSearch);
            this.panel1.Controls.Add(this.TxtSearch);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(212, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(936, 682);
            this.panel1.TabIndex = 2;
            // 
            // LblSearch
            // 
            this.LblSearch.AutoSize = true;
            this.LblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSearch.Location = new System.Drawing.Point(334, 352);
            this.LblSearch.Name = "LblSearch";
            this.LblSearch.Size = new System.Drawing.Size(56, 16);
            this.LblSearch.TabIndex = 15;
            this.LblSearch.Text = "Search";
            // 
            // TxtSearch
            // 
            this.TxtSearch.BackColor = System.Drawing.Color.LightGray;
            this.TxtSearch.Location = new System.Drawing.Point(409, 348);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(223, 20);
            this.TxtSearch.TabIndex = 5;
            this.TxtSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.DGVEmployee);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 391);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(936, 291);
            this.panel4.TabIndex = 4;
            // 
            // DGVEmployee
            // 
            this.DGVEmployee.AllowUserToAddRows = false;
            this.DGVEmployee.AllowUserToDeleteRows = false;
            this.DGVEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.EmpGender,
            this.EmpName,
            this.Contact,
            this.Dob,
            this.Type,
            this.Salary});
            this.DGVEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVEmployee.Location = new System.Drawing.Point(0, 0);
            this.DGVEmployee.Name = "DGVEmployee";
            this.DGVEmployee.ReadOnly = true;
            this.DGVEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVEmployee.Size = new System.Drawing.Size(936, 291);
            this.DGVEmployee.TabIndex = 0;
            this.DGVEmployee.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Employee ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 85;
            // 
            // EmpGender
            // 
            this.EmpGender.DataPropertyName = "Gender";
            this.EmpGender.HeaderText = "Gender";
            this.EmpGender.Name = "EmpGender";
            this.EmpGender.ReadOnly = true;
            // 
            // EmpName
            // 
            this.EmpName.DataPropertyName = "EmpName";
            this.EmpName.HeaderText = "Name";
            this.EmpName.Name = "EmpName";
            this.EmpName.ReadOnly = true;
            this.EmpName.Width = 150;
            // 
            // Contact
            // 
            this.Contact.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Contact.DataPropertyName = "Contact";
            this.Contact.HeaderText = "Contact Number";
            this.Contact.Name = "Contact";
            this.Contact.ReadOnly = true;
            // 
            // Dob
            // 
            this.Dob.DataPropertyName = "Dob";
            this.Dob.HeaderText = "Date Of Birth";
            this.Dob.Name = "Dob";
            this.Dob.ReadOnly = true;
            this.Dob.Width = 150;
            // 
            // Type
            // 
            this.Type.DataPropertyName = "Type";
            this.Type.HeaderText = "Employee Rank";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.Width = 130;
            // 
            // Salary
            // 
            this.Salary.DataPropertyName = "Salary";
            this.Salary.HeaderText = "Salary";
            this.Salary.Name = "Salary";
            this.Salary.ReadOnly = true;
            this.Salary.Width = 130;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.LblInitialPass);
            this.panel3.Controls.Add(this.TxtInitialPass);
            this.panel3.Controls.Add(this.txtSalary);
            this.panel3.Controls.Add(this.LblSalary);
            this.panel3.Controls.Add(this.LblRank);
            this.panel3.Controls.Add(this.CboxRank);
            this.panel3.Controls.Add(this.BtnInsertEmployee);
            this.panel3.Controls.Add(this.LblAddEmployee);
            this.panel3.Controls.Add(this.LblBirthdate);
            this.panel3.Controls.Add(this.birthdateDTP);
            this.panel3.Controls.Add(this.radioBtnFemale);
            this.panel3.Controls.Add(this.radioBtnMale);
            this.panel3.Controls.Add(this.LblGender);
            this.panel3.Controls.Add(this.LblContact);
            this.panel3.Controls.Add(this.LblName);
            this.panel3.Controls.Add(this.txtContactNumber);
            this.panel3.Controls.Add(this.txtName);
            this.panel3.Location = new System.Drawing.Point(217, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(451, 315);
            this.panel3.TabIndex = 2;
            // 
            // LblInitialPass
            // 
            this.LblInitialPass.AutoSize = true;
            this.LblInitialPass.Enabled = false;
            this.LblInitialPass.Location = new System.Drawing.Point(107, 229);
            this.LblInitialPass.Name = "LblInitialPass";
            this.LblInitialPass.Size = new System.Drawing.Size(80, 13);
            this.LblInitialPass.TabIndex = 16;
            this.LblInitialPass.Text = "Initial Password";
            this.LblInitialPass.Click += new System.EventHandler(this.LblInitialPass_Click);
            // 
            // TxtInitialPass
            // 
            this.TxtInitialPass.Location = new System.Drawing.Point(228, 226);
            this.TxtInitialPass.Name = "TxtInitialPass";
            this.TxtInitialPass.Size = new System.Drawing.Size(100, 20);
            this.TxtInitialPass.TabIndex = 15;
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(228, 193);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(100, 20);
            this.txtSalary.TabIndex = 14;
            // 
            // LblSalary
            // 
            this.LblSalary.AutoSize = true;
            this.LblSalary.Location = new System.Drawing.Point(107, 196);
            this.LblSalary.Name = "LblSalary";
            this.LblSalary.Size = new System.Drawing.Size(36, 13);
            this.LblSalary.TabIndex = 13;
            this.LblSalary.Text = "Salary";
            // 
            // LblRank
            // 
            this.LblRank.AutoSize = true;
            this.LblRank.Location = new System.Drawing.Point(106, 142);
            this.LblRank.Name = "LblRank";
            this.LblRank.Size = new System.Drawing.Size(33, 13);
            this.LblRank.TabIndex = 12;
            this.LblRank.Text = "Rank";
            // 
            // CboxRank
            // 
            this.CboxRank.FormattingEnabled = true;
            this.CboxRank.Items.AddRange(new object[] {
            "Salesman",
            "Manager"});
            this.CboxRank.Location = new System.Drawing.Point(228, 139);
            this.CboxRank.Name = "CboxRank";
            this.CboxRank.Size = new System.Drawing.Size(121, 21);
            this.CboxRank.TabIndex = 11;
            this.CboxRank.SelectedIndexChanged += new System.EventHandler(this.CboxRank_SelectedIndexChanged);
            // 
            // BtnInsertEmployee
            // 
            this.BtnInsertEmployee.BackColor = System.Drawing.Color.YellowGreen;
            this.BtnInsertEmployee.Location = new System.Drawing.Point(192, 276);
            this.BtnInsertEmployee.Name = "BtnInsertEmployee";
            this.BtnInsertEmployee.Size = new System.Drawing.Size(100, 35);
            this.BtnInsertEmployee.TabIndex = 10;
            this.BtnInsertEmployee.Text = "InsertEmployee";
            this.BtnInsertEmployee.UseVisualStyleBackColor = false;
            this.BtnInsertEmployee.Click += new System.EventHandler(this.BtnInsertEmployee_Click);
            // 
            // LblAddEmployee
            // 
            this.LblAddEmployee.AutoSize = true;
            this.LblAddEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAddEmployee.Location = new System.Drawing.Point(168, 13);
            this.LblAddEmployee.Name = "LblAddEmployee";
            this.LblAddEmployee.Size = new System.Drawing.Size(124, 20);
            this.LblAddEmployee.TabIndex = 9;
            this.LblAddEmployee.Text = "Add Employee";
            // 
            // LblBirthdate
            // 
            this.LblBirthdate.AutoSize = true;
            this.LblBirthdate.Location = new System.Drawing.Point(106, 172);
            this.LblBirthdate.Name = "LblBirthdate";
            this.LblBirthdate.Size = new System.Drawing.Size(51, 13);
            this.LblBirthdate.TabIndex = 8;
            this.LblBirthdate.Text = "BirthDate";
            // 
            // birthdateDTP
            // 
            this.birthdateDTP.Location = new System.Drawing.Point(228, 166);
            this.birthdateDTP.Name = "birthdateDTP";
            this.birthdateDTP.Size = new System.Drawing.Size(200, 20);
            this.birthdateDTP.TabIndex = 7;
            this.birthdateDTP.ValueChanged += new System.EventHandler(this.birthdateDTP_ValueChanged);
            // 
            // radioBtnFemale
            // 
            this.radioBtnFemale.AutoSize = true;
            this.radioBtnFemale.Location = new System.Drawing.Point(290, 110);
            this.radioBtnFemale.Name = "radioBtnFemale";
            this.radioBtnFemale.Size = new System.Drawing.Size(59, 17);
            this.radioBtnFemale.TabIndex = 6;
            this.radioBtnFemale.TabStop = true;
            this.radioBtnFemale.Text = "Female";
            this.radioBtnFemale.UseVisualStyleBackColor = true;
            // 
            // radioBtnMale
            // 
            this.radioBtnMale.AutoSize = true;
            this.radioBtnMale.Location = new System.Drawing.Point(228, 110);
            this.radioBtnMale.Name = "radioBtnMale";
            this.radioBtnMale.Size = new System.Drawing.Size(48, 17);
            this.radioBtnMale.TabIndex = 5;
            this.radioBtnMale.TabStop = true;
            this.radioBtnMale.Text = "Male";
            this.radioBtnMale.UseVisualStyleBackColor = true;
            // 
            // LblGender
            // 
            this.LblGender.AutoSize = true;
            this.LblGender.Location = new System.Drawing.Point(106, 110);
            this.LblGender.Name = "LblGender";
            this.LblGender.Size = new System.Drawing.Size(42, 13);
            this.LblGender.TabIndex = 4;
            this.LblGender.Text = "Gender";
            // 
            // LblContact
            // 
            this.LblContact.AutoSize = true;
            this.LblContact.Location = new System.Drawing.Point(106, 80);
            this.LblContact.Name = "LblContact";
            this.LblContact.Size = new System.Drawing.Size(81, 13);
            this.LblContact.TabIndex = 3;
            this.LblContact.Text = "ContactNumber";
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(106, 54);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(35, 13);
            this.LblName.TabIndex = 2;
            this.LblName.Text = "Name";
            // 
            // txtContactNumber
            // 
            this.txtContactNumber.Location = new System.Drawing.Point(228, 77);
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.Size = new System.Drawing.Size(121, 20);
            this.txtContactNumber.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(228, 51);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(121, 20);
            this.txtName.TabIndex = 0;
            // 
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 706);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "AddEmployee";
            this.Text = "AddEmployee";
            this.Load += new System.EventHandler(this.AddEmployee_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVEmployee)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnNewProduct;
        private System.Windows.Forms.Button BtnManagerInfo;
        private System.Windows.Forms.Button BtnDashBoard;
        private System.Windows.Forms.Button BtnLogout;
        private System.Windows.Forms.Button BtnSalesmanInfo;
        private System.Windows.Forms.Button BtnInventory;
        private System.Windows.Forms.Button BtnCategory;
        private System.Windows.Forms.Button BtnAddEmployee;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label LblAddEmployee;
        private System.Windows.Forms.Label LblBirthdate;
        private System.Windows.Forms.DateTimePicker birthdateDTP;
        private System.Windows.Forms.RadioButton radioBtnFemale;
        private System.Windows.Forms.RadioButton radioBtnMale;
        private System.Windows.Forms.Label LblGender;
        private System.Windows.Forms.Label LblContact;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.TextBox txtContactNumber;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView DGVEmployee;
        private System.Windows.Forms.Button BtnInsertEmployee;
        private System.Windows.Forms.Label LblRank;
        private System.Windows.Forms.ComboBox CboxRank;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Label LblSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contact;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dob;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salary;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.Label LblSearch;
        private System.Windows.Forms.Label LblInitialPass;
        private System.Windows.Forms.TextBox TxtInitialPass;
    }
}