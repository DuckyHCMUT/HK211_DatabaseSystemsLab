﻿namespace WindowsFormsAss2
{
    partial class Form1
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.LoginPage = new System.Windows.Forms.TabPage();
            this.suppliers = new System.Windows.Forms.TabPage();
            this.addSupplier = new System.Windows.Forms.TabPage();
            this.categoryList = new System.Windows.Forms.TabPage();
            this.report = new System.Windows.Forms.TabPage();
            this.username = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.text_user = new System.Windows.Forms.TextBox();
            this.text_password = new System.Windows.Forms.TextBox();
            this.label_appname = new System.Windows.Forms.Label();
            this.label_current = new System.Windows.Forms.Label();
            this.label_status = new System.Windows.Forms.Label();
            this.data_supplier = new System.Windows.Forms.DataGridView();
            this.search_by_name = new System.Windows.Forms.Label();
            this.search_by_code = new System.Windows.Forms.Label();
            this.box_search_by_code = new System.Windows.Forms.TextBox();
            this.box_search_by_name = new System.Windows.Forms.TextBox();
            this.supplier_info = new System.Windows.Forms.Label();
            this.data_supply = new System.Windows.Forms.DataGridView();
            this.supply_info = new System.Windows.Forms.Label();
            this.patSearchButton = new System.Windows.Forms.Button();
            this.add_supplier_name = new System.Windows.Forms.Label();
            this.add_supplier_bank = new System.Windows.Forms.Label();
            this.add_supplier_tax_code = new System.Windows.Forms.Label();
            this.add_supplier_address = new System.Windows.Forms.Label();
            this.add_text_name = new System.Windows.Forms.TextBox();
            this.add_text_addr = new System.Windows.Forms.TextBox();
            this.add_text_code = new System.Windows.Forms.TextBox();
            this.add_text_acc = new System.Windows.Forms.TextBox();
            this.label_search = new System.Windows.Forms.Label();
            this.label_add = new System.Windows.Forms.Label();
            this.label_category_list = new System.Windows.Forms.Label();
            this.data_category = new System.Windows.Forms.DataGridView();
            this.label_supplier_code = new System.Windows.Forms.Label();
            this.supplier_code_box = new System.Windows.Forms.TextBox();
            this.supplier_find = new System.Windows.Forms.Button();
            this.label_report = new System.Windows.Forms.Label();
            this.data_report = new System.Windows.Forms.DataGridView();
            this.report_find = new System.Windows.Forms.Button();
            this.text_report = new System.Windows.Forms.TextBox();
            this.label_customer_code = new System.Windows.Forms.Label();
            this.report_preview = new System.Windows.Forms.Label();
            this.report_print = new System.Windows.Forms.RichTextBox();
            this.tabControl1.SuspendLayout();
            this.LoginPage.SuspendLayout();
            this.suppliers.SuspendLayout();
            this.addSupplier.SuspendLayout();
            this.categoryList.SuspendLayout();
            this.report.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_supplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_supply)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_category)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_report)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.LoginPage);
            this.tabControl1.Controls.Add(this.suppliers);
            this.tabControl1.Controls.Add(this.addSupplier);
            this.tabControl1.Controls.Add(this.categoryList);
            this.tabControl1.Controls.Add(this.report);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(991, 473);
            this.tabControl1.TabIndex = 1;
            // 
            // LoginPage
            // 
            this.LoginPage.Controls.Add(this.label_status);
            this.LoginPage.Controls.Add(this.label_current);
            this.LoginPage.Controls.Add(this.label_appname);
            this.LoginPage.Controls.Add(this.text_password);
            this.LoginPage.Controls.Add(this.text_user);
            this.LoginPage.Controls.Add(this.logout);
            this.LoginPage.Controls.Add(this.login);
            this.LoginPage.Controls.Add(this.password);
            this.LoginPage.Controls.Add(this.username);
            this.LoginPage.Location = new System.Drawing.Point(4, 25);
            this.LoginPage.Name = "LoginPage";
            this.LoginPage.Padding = new System.Windows.Forms.Padding(3);
            this.LoginPage.Size = new System.Drawing.Size(983, 444);
            this.LoginPage.TabIndex = 0;
            this.LoginPage.Text = "Login Page";
            this.LoginPage.UseVisualStyleBackColor = true;
            // 
            // suppliers
            // 
            this.suppliers.Controls.Add(this.label_search);
            this.suppliers.Controls.Add(this.patSearchButton);
            this.suppliers.Controls.Add(this.supply_info);
            this.suppliers.Controls.Add(this.data_supply);
            this.suppliers.Controls.Add(this.supplier_info);
            this.suppliers.Controls.Add(this.box_search_by_name);
            this.suppliers.Controls.Add(this.box_search_by_code);
            this.suppliers.Controls.Add(this.search_by_code);
            this.suppliers.Controls.Add(this.search_by_name);
            this.suppliers.Controls.Add(this.data_supplier);
            this.suppliers.Location = new System.Drawing.Point(4, 25);
            this.suppliers.Name = "suppliers";
            this.suppliers.Padding = new System.Windows.Forms.Padding(3);
            this.suppliers.Size = new System.Drawing.Size(983, 444);
            this.suppliers.TabIndex = 1;
            this.suppliers.Text = "Suppliers";
            this.suppliers.UseVisualStyleBackColor = true;
            // 
            // addSupplier
            // 
            this.addSupplier.Controls.Add(this.label_add);
            this.addSupplier.Controls.Add(this.add_text_acc);
            this.addSupplier.Controls.Add(this.add_text_code);
            this.addSupplier.Controls.Add(this.add_text_addr);
            this.addSupplier.Controls.Add(this.add_text_name);
            this.addSupplier.Controls.Add(this.add_supplier_address);
            this.addSupplier.Controls.Add(this.add_supplier_tax_code);
            this.addSupplier.Controls.Add(this.add_supplier_bank);
            this.addSupplier.Controls.Add(this.add_supplier_name);
            this.addSupplier.Location = new System.Drawing.Point(4, 25);
            this.addSupplier.Name = "addSupplier";
            this.addSupplier.Padding = new System.Windows.Forms.Padding(3);
            this.addSupplier.Size = new System.Drawing.Size(983, 444);
            this.addSupplier.TabIndex = 2;
            this.addSupplier.Text = "Add Supplier";
            this.addSupplier.UseVisualStyleBackColor = true;
            // 
            // categoryList
            // 
            this.categoryList.Controls.Add(this.supplier_find);
            this.categoryList.Controls.Add(this.supplier_code_box);
            this.categoryList.Controls.Add(this.label_supplier_code);
            this.categoryList.Controls.Add(this.data_category);
            this.categoryList.Controls.Add(this.label_category_list);
            this.categoryList.Location = new System.Drawing.Point(4, 25);
            this.categoryList.Name = "categoryList";
            this.categoryList.Padding = new System.Windows.Forms.Padding(3);
            this.categoryList.Size = new System.Drawing.Size(983, 444);
            this.categoryList.TabIndex = 3;
            this.categoryList.Text = "Category List";
            this.categoryList.UseVisualStyleBackColor = true;
            // 
            // report
            // 
            this.report.Controls.Add(this.report_print);
            this.report.Controls.Add(this.report_preview);
            this.report.Controls.Add(this.report_find);
            this.report.Controls.Add(this.text_report);
            this.report.Controls.Add(this.label_customer_code);
            this.report.Controls.Add(this.data_report);
            this.report.Controls.Add(this.label_report);
            this.report.Location = new System.Drawing.Point(4, 25);
            this.report.Name = "report";
            this.report.Padding = new System.Windows.Forms.Padding(3);
            this.report.Size = new System.Drawing.Size(983, 444);
            this.report.TabIndex = 4;
            this.report.Text = "Report";
            this.report.UseVisualStyleBackColor = true;
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Location = new System.Drawing.Point(34, 27);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(73, 17);
            this.username.TabIndex = 0;
            this.username.Text = "Username";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(34, 99);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(69, 17);
            this.password.TabIndex = 1;
            this.password.Text = "Password";
            this.password.Click += new System.EventHandler(this.label1_Click);
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(37, 240);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(75, 33);
            this.login.TabIndex = 2;
            this.login.Text = "Login";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // logout
            // 
            this.logout.Location = new System.Drawing.Point(204, 240);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(75, 33);
            this.logout.TabIndex = 3;
            this.logout.Text = "Logout";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // text_user
            // 
            this.text_user.Location = new System.Drawing.Point(141, 27);
            this.text_user.Name = "text_user";
            this.text_user.Size = new System.Drawing.Size(138, 22);
            this.text_user.TabIndex = 4;
            // 
            // text_password
            // 
            this.text_password.Location = new System.Drawing.Point(141, 96);
            this.text_password.Name = "text_password";
            this.text_password.Size = new System.Drawing.Size(138, 22);
            this.text_password.TabIndex = 5;
            // 
            // label_appname
            // 
            this.label_appname.AutoSize = true;
            this.label_appname.Font = new System.Drawing.Font("Times New Roman", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_appname.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label_appname.Location = new System.Drawing.Point(380, 27);
            this.label_appname.Name = "label_appname";
            this.label_appname.Size = new System.Drawing.Size(403, 162);
            this.label_appname.TabIndex = 6;
            this.label_appname.Text = "FABRIC AGENCY\r\nMANAGEMENT\r\nAPPLICATION";
            this.label_appname.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label_current
            // 
            this.label_current.AutoSize = true;
            this.label_current.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_current.Location = new System.Drawing.Point(384, 292);
            this.label_current.Name = "label_current";
            this.label_current.Size = new System.Drawing.Size(121, 29);
            this.label_current.TabIndex = 7;
            this.label_current.Text = "Currently: ";
            this.label_current.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_status.Location = new System.Drawing.Point(511, 292);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(203, 29);
            this.label_status.TabIndex = 8;
            this.label_status.Text = "NOT LOGGED IN";
            this.label_status.Click += new System.EventHandler(this.label_status_Click);
            // 
            // data_supplier
            // 
            this.data_supplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_supplier.Location = new System.Drawing.Point(6, 164);
            this.data_supplier.Name = "data_supplier";
            this.data_supplier.RowHeadersWidth = 51;
            this.data_supplier.RowTemplate.Height = 24;
            this.data_supplier.Size = new System.Drawing.Size(443, 274);
            this.data_supplier.TabIndex = 0;
            // 
            // search_by_name
            // 
            this.search_by_name.AutoSize = true;
            this.search_by_name.Location = new System.Drawing.Point(20, 31);
            this.search_by_name.Name = "search_by_name";
            this.search_by_name.Size = new System.Drawing.Size(113, 17);
            this.search_by_name.TabIndex = 1;
            this.search_by_name.Text = "Search by Name";
            // 
            // search_by_code
            // 
            this.search_by_code.AutoSize = true;
            this.search_by_code.Location = new System.Drawing.Point(20, 75);
            this.search_by_code.Name = "search_by_code";
            this.search_by_code.Size = new System.Drawing.Size(109, 17);
            this.search_by_code.TabIndex = 2;
            this.search_by_code.Text = "Search by Code";
            // 
            // box_search_by_code
            // 
            this.box_search_by_code.Location = new System.Drawing.Point(157, 72);
            this.box_search_by_code.Name = "box_search_by_code";
            this.box_search_by_code.Size = new System.Drawing.Size(202, 22);
            this.box_search_by_code.TabIndex = 5;
            // 
            // box_search_by_name
            // 
            this.box_search_by_name.Location = new System.Drawing.Point(157, 28);
            this.box_search_by_name.Name = "box_search_by_name";
            this.box_search_by_name.Size = new System.Drawing.Size(202, 22);
            this.box_search_by_name.TabIndex = 6;
            // 
            // supplier_info
            // 
            this.supplier_info.AutoSize = true;
            this.supplier_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.supplier_info.Location = new System.Drawing.Point(153, 137);
            this.supplier_info.Name = "supplier_info";
            this.supplier_info.Size = new System.Drawing.Size(128, 24);
            this.supplier_info.TabIndex = 13;
            this.supplier_info.Text = "Supplier\'s info";
            // 
            // data_supply
            // 
            this.data_supply.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_supply.Location = new System.Drawing.Point(534, 164);
            this.data_supply.Name = "data_supply";
            this.data_supply.RowHeadersWidth = 51;
            this.data_supply.RowTemplate.Height = 24;
            this.data_supply.Size = new System.Drawing.Size(443, 274);
            this.data_supply.TabIndex = 14;
            // 
            // supply_info
            // 
            this.supply_info.AutoSize = true;
            this.supply_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.supply_info.Location = new System.Drawing.Point(705, 137);
            this.supply_info.Name = "supply_info";
            this.supply_info.Size = new System.Drawing.Size(68, 24);
            this.supply_info.TabIndex = 15;
            this.supply_info.Text = "Supply";
            // 
            // patSearchButton
            // 
            this.patSearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.2F);
            this.patSearchButton.Location = new System.Drawing.Point(391, 28);
            this.patSearchButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.patSearchButton.Name = "patSearchButton";
            this.patSearchButton.Size = new System.Drawing.Size(110, 64);
            this.patSearchButton.TabIndex = 16;
            this.patSearchButton.Text = "SEARCH";
            this.patSearchButton.UseVisualStyleBackColor = true;
            // 
            // add_supplier_name
            // 
            this.add_supplier_name.AutoSize = true;
            this.add_supplier_name.Location = new System.Drawing.Point(7, 80);
            this.add_supplier_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.add_supplier_name.Name = "add_supplier_name";
            this.add_supplier_name.Size = new System.Drawing.Size(101, 17);
            this.add_supplier_name.TabIndex = 1;
            this.add_supplier_name.Text = "Supplier Name";
            // 
            // add_supplier_bank
            // 
            this.add_supplier_bank.AutoSize = true;
            this.add_supplier_bank.Location = new System.Drawing.Point(7, 298);
            this.add_supplier_bank.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.add_supplier_bank.Name = "add_supplier_bank";
            this.add_supplier_bank.Size = new System.Drawing.Size(95, 17);
            this.add_supplier_bank.TabIndex = 3;
            this.add_supplier_bank.Text = "Bank Account";
            // 
            // add_supplier_tax_code
            // 
            this.add_supplier_tax_code.AutoSize = true;
            this.add_supplier_tax_code.Location = new System.Drawing.Point(7, 241);
            this.add_supplier_tax_code.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.add_supplier_tax_code.Name = "add_supplier_tax_code";
            this.add_supplier_tax_code.Size = new System.Drawing.Size(68, 17);
            this.add_supplier_tax_code.TabIndex = 4;
            this.add_supplier_tax_code.Text = "Tax Code";
            // 
            // add_supplier_address
            // 
            this.add_supplier_address.AutoSize = true;
            this.add_supplier_address.Location = new System.Drawing.Point(7, 137);
            this.add_supplier_address.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.add_supplier_address.Name = "add_supplier_address";
            this.add_supplier_address.Size = new System.Drawing.Size(116, 17);
            this.add_supplier_address.TabIndex = 5;
            this.add_supplier_address.Text = "Supplier Address";
            this.add_supplier_address.Click += new System.EventHandler(this.label4_Click);
            // 
            // add_text_name
            // 
            this.add_text_name.Location = new System.Drawing.Point(132, 77);
            this.add_text_name.Margin = new System.Windows.Forms.Padding(4);
            this.add_text_name.Name = "add_text_name";
            this.add_text_name.Size = new System.Drawing.Size(485, 22);
            this.add_text_name.TabIndex = 6;
            // 
            // add_text_addr
            // 
            this.add_text_addr.Location = new System.Drawing.Point(131, 134);
            this.add_text_addr.Margin = new System.Windows.Forms.Padding(4);
            this.add_text_addr.Multiline = true;
            this.add_text_addr.Name = "add_text_addr";
            this.add_text_addr.Size = new System.Drawing.Size(486, 73);
            this.add_text_addr.TabIndex = 7;
            // 
            // add_text_code
            // 
            this.add_text_code.Location = new System.Drawing.Point(131, 238);
            this.add_text_code.Margin = new System.Windows.Forms.Padding(4);
            this.add_text_code.Name = "add_text_code";
            this.add_text_code.Size = new System.Drawing.Size(485, 22);
            this.add_text_code.TabIndex = 8;
            // 
            // add_text_acc
            // 
            this.add_text_acc.Location = new System.Drawing.Point(131, 295);
            this.add_text_acc.Margin = new System.Windows.Forms.Padding(4);
            this.add_text_acc.Name = "add_text_acc";
            this.add_text_acc.Size = new System.Drawing.Size(485, 22);
            this.add_text_acc.TabIndex = 9;
            this.add_text_acc.TextChanged += new System.EventHandler(this.textBox2_TextChanged_2);
            // 
            // label_search
            // 
            this.label_search.AutoSize = true;
            this.label_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_search.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label_search.Location = new System.Drawing.Point(528, 31);
            this.label_search.Name = "label_search";
            this.label_search.Size = new System.Drawing.Size(290, 64);
            this.label_search.TabIndex = 17;
            this.label_search.Text = "Search for\r\nSupplier and Supply";
            this.label_search.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // label_add
            // 
            this.label_add.AutoSize = true;
            this.label_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_add.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label_add.Location = new System.Drawing.Point(393, 17);
            this.label_add.Name = "label_add";
            this.label_add.Size = new System.Drawing.Size(191, 32);
            this.label_add.TabIndex = 18;
            this.label_add.Text = "Add Supplier";
            // 
            // label_category_list
            // 
            this.label_category_list.AutoSize = true;
            this.label_category_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_category_list.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label_category_list.Location = new System.Drawing.Point(317, 16);
            this.label_category_list.Name = "label_category_list";
            this.label_category_list.Size = new System.Drawing.Size(338, 32);
            this.label_category_list.TabIndex = 19;
            this.label_category_list.Text = "Suppliers\' Category List";
            // 
            // data_category
            // 
            this.data_category.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_category.Location = new System.Drawing.Point(6, 147);
            this.data_category.Name = "data_category";
            this.data_category.RowHeadersWidth = 51;
            this.data_category.RowTemplate.Height = 24;
            this.data_category.Size = new System.Drawing.Size(971, 274);
            this.data_category.TabIndex = 20;
            // 
            // label_supplier_code
            // 
            this.label_supplier_code.AutoSize = true;
            this.label_supplier_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_supplier_code.ForeColor = System.Drawing.Color.Navy;
            this.label_supplier_code.Location = new System.Drawing.Point(6, 72);
            this.label_supplier_code.Name = "label_supplier_code";
            this.label_supplier_code.Size = new System.Drawing.Size(262, 24);
            this.label_supplier_code.TabIndex = 21;
            this.label_supplier_code.Text = "Enter the code of suppliers";
            this.label_supplier_code.Click += new System.EventHandler(this.searchingPatientInstructionLabel_Quang_Click);
            // 
            // supplier_code_box
            // 
            this.supplier_code_box.Location = new System.Drawing.Point(10, 99);
            this.supplier_code_box.Name = "supplier_code_box";
            this.supplier_code_box.Size = new System.Drawing.Size(258, 22);
            this.supplier_code_box.TabIndex = 22;
            // 
            // supplier_find
            // 
            this.supplier_find.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplier_find.Location = new System.Drawing.Point(323, 72);
            this.supplier_find.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.supplier_find.Name = "supplier_find";
            this.supplier_find.Size = new System.Drawing.Size(131, 49);
            this.supplier_find.TabIndex = 23;
            this.supplier_find.Text = "Find";
            this.supplier_find.UseVisualStyleBackColor = true;
            // 
            // label_report
            // 
            this.label_report.AutoSize = true;
            this.label_report.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_report.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label_report.Location = new System.Drawing.Point(379, 18);
            this.label_report.Name = "label_report";
            this.label_report.Size = new System.Drawing.Size(212, 32);
            this.label_report.TabIndex = 20;
            this.label_report.Text = "Order\'s Report";
            // 
            // data_report
            // 
            this.data_report.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_report.Location = new System.Drawing.Point(19, 135);
            this.data_report.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.data_report.Name = "data_report";
            this.data_report.RowHeadersWidth = 51;
            this.data_report.RowTemplate.Height = 24;
            this.data_report.Size = new System.Drawing.Size(420, 290);
            this.data_report.TabIndex = 21;
            // 
            // report_find
            // 
            this.report_find.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.report_find.Location = new System.Drawing.Point(308, 71);
            this.report_find.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.report_find.Name = "report_find";
            this.report_find.Size = new System.Drawing.Size(131, 49);
            this.report_find.TabIndex = 26;
            this.report_find.Text = "Find";
            this.report_find.UseVisualStyleBackColor = true;
            // 
            // text_report
            // 
            this.text_report.Location = new System.Drawing.Point(19, 98);
            this.text_report.Name = "text_report";
            this.text_report.Size = new System.Drawing.Size(258, 22);
            this.text_report.TabIndex = 25;
            // 
            // label_customer_code
            // 
            this.label_customer_code.AutoSize = true;
            this.label_customer_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_customer_code.ForeColor = System.Drawing.Color.Navy;
            this.label_customer_code.Location = new System.Drawing.Point(15, 71);
            this.label_customer_code.Name = "label_customer_code";
            this.label_customer_code.Size = new System.Drawing.Size(263, 24);
            this.label_customer_code.TabIndex = 24;
            this.label_customer_code.Text = "Enter the code of customer";
            // 
            // report_preview
            // 
            this.report_preview.AutoSize = true;
            this.report_preview.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.report_preview.ForeColor = System.Drawing.Color.Navy;
            this.report_preview.Location = new System.Drawing.Point(531, 71);
            this.report_preview.Name = "report_preview";
            this.report_preview.Size = new System.Drawing.Size(157, 24);
            this.report_preview.TabIndex = 27;
            this.report_preview.Text = "Report preview:";
            // 
            // report_print
            // 
            this.report_print.Location = new System.Drawing.Point(535, 135);
            this.report_print.Name = "report_print";
            this.report_print.Size = new System.Drawing.Size(442, 290);
            this.report_print.TabIndex = 28;
            this.report_print.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 497);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.LoginPage.ResumeLayout(false);
            this.LoginPage.PerformLayout();
            this.suppliers.ResumeLayout(false);
            this.suppliers.PerformLayout();
            this.addSupplier.ResumeLayout(false);
            this.addSupplier.PerformLayout();
            this.categoryList.ResumeLayout(false);
            this.categoryList.PerformLayout();
            this.report.ResumeLayout(false);
            this.report.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_supplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_supply)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_category)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_report)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage LoginPage;
        private System.Windows.Forms.TabPage suppliers;
        private System.Windows.Forms.TabPage addSupplier;
        private System.Windows.Forms.TabPage categoryList;
        private System.Windows.Forms.TabPage report;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.TextBox text_password;
        private System.Windows.Forms.TextBox text_user;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Label label_appname;
        private System.Windows.Forms.Label label_current;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.Button patSearchButton;
        private System.Windows.Forms.Label supply_info;
        private System.Windows.Forms.DataGridView data_supply;
        private System.Windows.Forms.Label supplier_info;
        private System.Windows.Forms.TextBox box_search_by_name;
        private System.Windows.Forms.TextBox box_search_by_code;
        private System.Windows.Forms.Label search_by_code;
        private System.Windows.Forms.Label search_by_name;
        private System.Windows.Forms.DataGridView data_supplier;
        private System.Windows.Forms.Label add_supplier_address;
        private System.Windows.Forms.Label add_supplier_tax_code;
        private System.Windows.Forms.Label add_supplier_bank;
        private System.Windows.Forms.Label add_supplier_name;
        private System.Windows.Forms.TextBox add_text_acc;
        private System.Windows.Forms.TextBox add_text_code;
        private System.Windows.Forms.TextBox add_text_addr;
        private System.Windows.Forms.TextBox add_text_name;
        private System.Windows.Forms.Label label_search;
        private System.Windows.Forms.Label label_add;
        private System.Windows.Forms.DataGridView data_category;
        private System.Windows.Forms.Label label_category_list;
        private System.Windows.Forms.Label label_supplier_code;
        private System.Windows.Forms.TextBox supplier_code_box;
        private System.Windows.Forms.Button supplier_find;
        private System.Windows.Forms.RichTextBox report_print;
        private System.Windows.Forms.Label report_preview;
        private System.Windows.Forms.Button report_find;
        private System.Windows.Forms.TextBox text_report;
        private System.Windows.Forms.Label label_customer_code;
        private System.Windows.Forms.DataGridView data_report;
        private System.Windows.Forms.Label label_report;
    }
}

