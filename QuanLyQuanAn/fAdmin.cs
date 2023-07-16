using CrystalDecisions.CrystalReports.Engine;
using QuanLyQuanAn.DAO;
using QuanLyQuanAn.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanAn
{
    public partial class fAdmin : Form
    {
        public fAdmin()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void fAdmin_Load(object sender, EventArgs e)
        {
            LoadListBill();
            LoadListFood();
            LoadAccount();
            loadListCategory();
            loadListTable();
            addFoodBinding();
            addCategoryBinding();
            addTableBinding();
            addAccountBinding();
            LoadCategoryIntoComboBox();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelUsername_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabControlAdmin_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPageCatagory_Click(object sender, EventArgs e)
        {

        }

        private void panel19_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void buttonAccountResetPassword_Click(object sender, EventArgs e)
        {
            DataTable kt = DataProvider.Instance.ExcuteQuery("select * from account where username = N'" + textBoxAccountUsername.Text.ToString()+"'");
            if(kt.Rows.Count == 1)
            {
                DataProvider.Instance.ExcuteQuery("update account set password = N'12345' where username = N'" + textBoxAccountUsername.Text.ToString()+"'");
                MessageBox.Show("Reset password thành công!\nPassword mới là: 12345", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Reset password thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void dataGridViewAccount_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabReport_Click(object sender, EventArgs e)
        {

        }

        private void buttonSearchBill_Click(object sender, EventArgs e)
        {
            
            if (textBoxMonth.Text.ToString() != "" && textBoxYear.Text.ToString() != "")
            {
                int month = Convert.ToInt32(textBoxMonth.Text.ToString());
                int year = Convert.ToInt32(textBoxYear.Text.ToString());
                CrystalReportBillinMonth crt = new CrystalReportBillinMonth();
                crt.SetDataSource(DataProvider.Instance.ExcuteQuery("exec USP_GetBillInMonth @month , @year", new object[] { month, year }));
                crystalReportViewer1.ReportSource = crt;
                crystalReportViewer1.Refresh();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void buttonStatistic_Click(object sender, EventArgs e)
        {
            LoadListBill();
        }
        private void LoadListBill()
        {
            DateTime d1 = DateTime.Parse(dateTimePickerStart.Text.ToString());
            DateTime d2 = DateTime.Parse(dateTimePickerEnd.Text.ToString());
            DataTable dt = BillDAO.Instance.ShowBillRevune(d1, d2);
            dataGridViewRevenue.DataSource = dt;
            dataGridViewRevenue.Refresh();
        }

        private void buttonView_Click(object sender, EventArgs e)
        {
            LoadListFood();
        }
        private void LoadListFood()
        {
            dataGridViewDish.DataSource = FoodDAO.Instance.GetListFood();
            dataGridViewDish.Refresh();
        }
        public void addFoodBinding()
        {
            textBoxNameDish.DataBindings.Add(new Binding("Text", dataGridViewDish.DataSource, "Name"));
            textBoxID.DataBindings.Add(new Binding("Text", dataGridViewDish.DataSource, "ID"));
            comboBoxCategory.DataBindings.Add(new Binding("Text", dataGridViewDish.DataSource, "Category"));
            numericUpDownPrice.DataBindings.Add(new Binding("Value", dataGridViewDish.DataSource, "Price"));
        }
        private void addCategoryBinding()
        {
            textBoxIDCatagory.DataBindings.Add(new Binding("Text", dataGridViewCategory.DataSource, "id"));
            textBoxNameCatagory.DataBindings.Add(new Binding("Text", dataGridViewCategory.DataSource, "name"));
        }
        private void LoadCategoryIntoComboBox()
        {
            comboBoxCategory.DataSource = FoodCategoryDAO.Instance.GetListCategory();
            comboBoxCategory.DisplayMember = "Name";
        }

        private void dataGridViewDish_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (textBoxSearch.Text.ToString() == "")
            {
                MessageBox.Show("Ô tìm kiếm không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                dataGridViewDish.DataSource = FoodDAO.Instance.GetListFoodByName(textBoxSearch.Text.ToString());
                dataGridViewDish.Refresh();
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddFood();
            this.Refresh();

        }
        private void AddFood()
        {
            if (textBoxNameDish.Text.ToString() != "" && comboBoxCategory.SelectedItem.ToString() != "")
            {
                string name = textBoxNameDish.Text.ToString();
                int type = ((FoodCategory)comboBoxCategory.SelectedItem).Id;
                int price = Convert.ToInt32(numericUpDownPrice.Value);
                int i = FoodDAO.Instance.AddFood(name, type, price);
                if (i > 0)
                {
                    MessageBox.Show("Thêm món ăn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridViewDish.Refresh();
                }
                else
                {
                    MessageBox.Show("Thêm món ăn thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DeleteFood();
            this.Refresh();
        }
        private void DeleteFood()
        {
            int i = FoodDAO.Instance.DeleteFood(Convert.ToInt32(textBoxID.Text.ToString()));
            if (i > 0)
            {
                MessageBox.Show("Xóa món ăn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Xóa món ăn thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dataGridViewDish.Refresh();

        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            EditFood();
            this.Refresh();
        }
        private void EditFood()
        {
            int id = int.Parse(textBoxID.Text.ToString());
            string name = textBoxNameDish.Text.ToString();
            int type = (comboBoxCategory.SelectedItem as FoodCategory).Id;
            int price = int.Parse(numericUpDownPrice.Value.ToString());
            int i = FoodDAO.Instance.EditFood(id, name, type, price);
            if (i > 0)
            {
                MessageBox.Show("Chỉnh sửa món ăn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Chỉnh sửa món ăn thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void buttonViewCatagory_Click(object sender, EventArgs e)
        {
            loadListCategory();
            this.Refresh();
        }
        private void loadListCategory()
        {
            dataGridViewCategory.DataSource = FoodCategoryDAO.Instance.GetListCategory();
            dataGridViewCategory.Refresh();
        }

        private void buttonDeleteCatagory_Click(object sender, EventArgs e)
        {
            DeleteCategory();
            this.Refresh();
        }
        private void DeleteCategory()
        {
            int id = Convert.ToInt32(textBoxIDCatagory.Text.ToString());
            int i = FoodCategoryDAO.Instance.deleteFoodCategory(id);
            if (i > 0)
            {
                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Xóa thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void buttonAddCatagory_Click(object sender, EventArgs e)
        {
            AddCategory();
            this.Refresh();
        }
        private void AddCategory()
        {
            int i = FoodCategoryDAO.Instance.addFoodCategory(textBoxNameCatagory.Text.ToString());
            if (i > 0)
            {
                MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Thêm thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void buttonEditCatagory_Click(object sender, EventArgs e)
        {
            EditCategory();
            this.Refresh();
        }
        private void EditCategory()
        {
            int i = FoodCategoryDAO.Instance.editFoodCategory(int.Parse(textBoxIDCatagory.Text.ToString()), textBoxNameCatagory.Text.ToString());
            if (i > 0)
            {
                MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Sửa thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void dataGridViewDinnerTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void loadListTable()
        {
            dataGridViewDinnerTable.DataSource = TableDAO.Instance.LoadListTable();
            dataGridViewDinnerTable.Refresh();
        }

        private void buttonTableDinnerView_Click(object sender, EventArgs e)
        {
            loadListTable();
            this.Refresh();
            dataGridViewDinnerTable.Refresh();

        }
        private void addTableBinding()
        {
            textBoxDinnerTableId.DataBindings.Add(new Binding("Text", dataGridViewDinnerTable.DataSource, "Id"));
            textBoxDinnerTableName.DataBindings.Add(new Binding("Text", dataGridViewDinnerTable.DataSource, "Name"));
            comboBoxDinnerTableStatus.DataBindings.Add(new Binding("Text", dataGridViewDinnerTable.DataSource, "Status"));

        }

        private void buttonDinnerTableAdd_Click(object sender, EventArgs e)
        {
            int i = TableDAO.Instance.addTable(textBoxDinnerTableName.Text.ToString());
            if (i > 0)
            {
                MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Thêm thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            dataGridViewDinnerTable.Refresh();

        }

        private void buttonDinnerTableEdit_Click(object sender, EventArgs e)
        {
            EditTable();
            this.Refresh();
        }
        private void EditTable()
        {
            int i = TableDAO.Instance.editTable(int.Parse(textBoxDinnerTableId.Text.ToString()), textBoxDinnerTableName.Text.ToString());
            if (i > 0)
            {
                MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Sửa thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            dataGridViewDinnerTable.Refresh();
        }

        private void buttonDinnertableDelete_Click(object sender, EventArgs e)
        {
            DeleteTable();
            this.Refresh();
        }
        private void DeleteTable()
        {
            int i = TableDAO.Instance.deleteTable(int.Parse(textBoxDinnerTableId.Text.ToString()));
            if (i > 0)
            {
                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Xóa thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            dataGridViewDinnerTable.Refresh();

        }

        private void buttonAccountView_Click(object sender, EventArgs e)
        {
            LoadAccount();
        }
        private void LoadAccount()
        {

            dataGridViewAccount.DataSource = DataProvider.Instance.ExcuteQuery("select username, displayname, type from account");
            dataGridViewAccount.Refresh();
        }
        private void addAccountBinding()
        {
            textBoxAccountUsername.DataBindings.Add(new Binding("Text", dataGridViewAccount.DataSource, "UserName"));
            textBoxAccountDisplayName.DataBindings.Add(new Binding("Text", dataGridViewAccount.DataSource, "DisplayName"));
            comboBoxAccountType.DataBindings.Add(new Binding("Text", dataGridViewAccount.DataSource, "Type"));
        }

        private void buttonAccountDelete_Click(object sender, EventArgs e)
        {
            DeleteAccount();
            this.Refresh();
        }
        private void DeleteAccount()
        {
            int i = AccountDAO.Instance.deleteAccount(textBoxAccountUsername.Text.ToString());
            if (i > 0)
            {
                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Xóa thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            dataGridViewAccount.Refresh();
        }

        private void buttonAccountAdd_Click(object sender, EventArgs e)
        {
            AddAccount();
            this.Refresh();
        }
        private void AddAccount()
        {
            int i = AccountDAO.Instance.addAccount(textBoxAccountUsername.Text.ToString(), textBoxAccountDisplayName.Text.ToString(), int.Parse(comboBoxAccountType.Text.ToString()));
            if (i > 0)
            {
                MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Thêm thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dataGridViewAccount.Refresh();

        }

        private void buttonAccountEdit_Click(object sender, EventArgs e)
        {
            EditAccount();
            this.Refresh();
        }
        private void EditAccount()
        {
            int i = AccountDAO.Instance.editAccount(textBoxAccountUsername.Text.ToString(), textBoxAccountDisplayName.Text.ToString(), int.Parse(comboBoxAccountType.Text.ToString()));
            if (i > 0)
            {
                MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Sửa thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            dataGridViewAccount.Refresh();
        }

        private void textBoxMonth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Không cho phép ký tự này được nhập vào TextBox
            }
        }

        private void textBoxYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Không cho phép ký tự này được nhập vào TextBox
            }
        }
    }
}
