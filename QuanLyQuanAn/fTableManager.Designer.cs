namespace QuanLyQuanAn
{
    partial class fTableManager
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informationAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonAddDishes = new System.Windows.Forms.Button();
            this.numericUpDownQuatityDish = new System.Windows.Forms.NumericUpDown();
            this.comboBoxDish = new System.Windows.Forms.ComboBox();
            this.comboBoxTypeOfDish = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.listViewBill = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonPay = new System.Windows.Forms.Button();
            this.textBoxDiscount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxChangeTable = new System.Windows.Forms.ComboBox();
            this.buttonChangeTable = new System.Windows.Forms.Button();
            this.flowLayoutPanelTable = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuatityDish)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(-1, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(816, 28);
            this.panel1.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.accountToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(816, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informationAccountToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.accountToolStripMenuItem.Text = "Account";
            this.accountToolStripMenuItem.Click += new System.EventHandler(this.accountToolStripMenuItem_Click);
            // 
            // informationAccountToolStripMenuItem
            // 
            this.informationAccountToolStripMenuItem.Name = "informationAccountToolStripMenuItem";
            this.informationAccountToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.informationAccountToolStripMenuItem.Text = "Information account";
            this.informationAccountToolStripMenuItem.Click += new System.EventHandler(this.informationAccountToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.logOutToolStripMenuItem.Text = "Log out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonAddDishes);
            this.panel2.Controls.Add(this.numericUpDownQuatityDish);
            this.panel2.Controls.Add(this.comboBoxDish);
            this.panel2.Controls.Add(this.comboBoxTypeOfDish);
            this.panel2.Location = new System.Drawing.Point(431, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(408, 67);
            this.panel2.TabIndex = 2;
            // 
            // buttonAddDishes
            // 
            this.buttonAddDishes.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonAddDishes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddDishes.Location = new System.Drawing.Point(289, 3);
            this.buttonAddDishes.Name = "buttonAddDishes";
            this.buttonAddDishes.Size = new System.Drawing.Size(116, 61);
            this.buttonAddDishes.TabIndex = 3;
            this.buttonAddDishes.Text = "Add dishes";
            this.buttonAddDishes.UseVisualStyleBackColor = false;
            this.buttonAddDishes.Click += new System.EventHandler(this.buttonAddDishes_Click);
            // 
            // numericUpDownQuatityDish
            // 
            this.numericUpDownQuatityDish.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownQuatityDish.Location = new System.Drawing.Point(225, 17);
            this.numericUpDownQuatityDish.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownQuatityDish.Name = "numericUpDownQuatityDish";
            this.numericUpDownQuatityDish.Size = new System.Drawing.Size(34, 26);
            this.numericUpDownQuatityDish.TabIndex = 2;
            this.numericUpDownQuatityDish.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // comboBoxDish
            // 
            this.comboBoxDish.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDish.FormattingEnabled = true;
            this.comboBoxDish.Location = new System.Drawing.Point(3, 35);
            this.comboBoxDish.Name = "comboBoxDish";
            this.comboBoxDish.Size = new System.Drawing.Size(216, 26);
            this.comboBoxDish.TabIndex = 1;
            this.comboBoxDish.SelectedIndexChanged += new System.EventHandler(this.comboBoxDish_SelectedIndexChanged);
            // 
            // comboBoxTypeOfDish
            // 
            this.comboBoxTypeOfDish.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTypeOfDish.FormattingEnabled = true;
            this.comboBoxTypeOfDish.Location = new System.Drawing.Point(3, 3);
            this.comboBoxTypeOfDish.Name = "comboBoxTypeOfDish";
            this.comboBoxTypeOfDish.Size = new System.Drawing.Size(216, 26);
            this.comboBoxTypeOfDish.TabIndex = 0;
            this.comboBoxTypeOfDish.SelectedIndexChanged += new System.EventHandler(this.comboBoxTypeOfDish_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.listViewBill);
            this.panel3.Location = new System.Drawing.Point(431, 110);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(405, 322);
            this.panel3.TabIndex = 3;
            // 
            // listViewBill
            // 
            this.listViewBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewBill.GridLines = true;
            this.listViewBill.HideSelection = false;
            this.listViewBill.Location = new System.Drawing.Point(0, -24);
            this.listViewBill.Name = "listViewBill";
            this.listViewBill.Size = new System.Drawing.Size(398, 343);
            this.listViewBill.TabIndex = 0;
            this.listViewBill.UseCompatibleStateImageBehavior = false;
            this.listViewBill.View = System.Windows.Forms.View.Details;
            this.listViewBill.SelectedIndexChanged += new System.EventHandler(this.listViewBill_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Count";
            this.columnHeader2.Width = 50;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Unit price";
            this.columnHeader3.Width = 90;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Amount";
            this.columnHeader4.Width = 110;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.textBoxAmount);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.buttonPay);
            this.panel4.Controls.Add(this.textBoxDiscount);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.comboBoxChangeTable);
            this.panel4.Controls.Add(this.buttonChangeTable);
            this.panel4.Location = new System.Drawing.Point(431, 438);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(402, 75);
            this.panel4.TabIndex = 4;
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Enabled = false;
            this.textBoxAmount.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAmount.ForeColor = System.Drawing.Color.Red;
            this.textBoxAmount.Location = new System.Drawing.Point(236, 41);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(100, 26);
            this.textBoxAmount.TabIndex = 6;
            this.textBoxAmount.TextChanged += new System.EventHandler(this.textBoxAmount_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(246, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Amount";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // buttonPay
            // 
            this.buttonPay.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonPay.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPay.Location = new System.Drawing.Point(342, 3);
            this.buttonPay.Name = "buttonPay";
            this.buttonPay.Size = new System.Drawing.Size(57, 69);
            this.buttonPay.TabIndex = 4;
            this.buttonPay.Text = "Pay";
            this.buttonPay.UseVisualStyleBackColor = false;
            this.buttonPay.Click += new System.EventHandler(this.buttonPay_Click);
            // 
            // textBoxDiscount
            // 
            this.textBoxDiscount.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDiscount.Location = new System.Drawing.Point(119, 41);
            this.textBoxDiscount.Name = "textBoxDiscount";
            this.textBoxDiscount.Size = new System.Drawing.Size(100, 26);
            this.textBoxDiscount.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Discount code";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBoxChangeTable
            // 
            this.comboBoxChangeTable.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxChangeTable.FormattingEnabled = true;
            this.comboBoxChangeTable.Location = new System.Drawing.Point(4, 41);
            this.comboBoxChangeTable.Name = "comboBoxChangeTable";
            this.comboBoxChangeTable.Size = new System.Drawing.Size(106, 26);
            this.comboBoxChangeTable.TabIndex = 1;
            // 
            // buttonChangeTable
            // 
            this.buttonChangeTable.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChangeTable.Location = new System.Drawing.Point(0, 3);
            this.buttonChangeTable.Name = "buttonChangeTable";
            this.buttonChangeTable.Size = new System.Drawing.Size(110, 31);
            this.buttonChangeTable.TabIndex = 0;
            this.buttonChangeTable.Text = "Change table";
            this.buttonChangeTable.UseVisualStyleBackColor = true;
            this.buttonChangeTable.Click += new System.EventHandler(this.button2_Click);
            // 
            // flowLayoutPanelTable
            // 
            this.flowLayoutPanelTable.AutoScroll = true;
            this.flowLayoutPanelTable.Location = new System.Drawing.Point(12, 37);
            this.flowLayoutPanelTable.Name = "flowLayoutPanelTable";
            this.flowLayoutPanelTable.Size = new System.Drawing.Size(413, 468);
            this.flowLayoutPanelTable.TabIndex = 0;
            // 
            // fTableManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 525);
            this.Controls.Add(this.flowLayoutPanelTable);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fTableManager";
            this.Text = "Restaurant manager";
            this.Load += new System.EventHandler(this.fTableManager_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuatityDish)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informationAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown numericUpDownQuatityDish;
        private System.Windows.Forms.ComboBox comboBoxDish;
        private System.Windows.Forms.ComboBox comboBoxTypeOfDish;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button buttonAddDishes;
        private System.Windows.Forms.Button buttonChangeTable;
        private System.Windows.Forms.ComboBox comboBoxChangeTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDiscount;
        private System.Windows.Forms.ListView listViewBill;
        private System.Windows.Forms.Button buttonPay;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelTable;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxAmount;
    }
}