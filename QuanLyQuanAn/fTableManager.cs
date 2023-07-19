using QuanLyQuanAn.DAO;
using QuanLyQuanAn.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanAn
{
    public partial class fTableManager : Form
    {
        public string user;
        public fTableManager(string username)
        {
            InitializeComponent();
            user = username;
        }

        private void fTableManager_Load(object sender, EventArgs e)
        {
            Load_Table();
            loadCatagory();
        }
        void Load_Table()
        {

            flowLayoutPanelTable.Controls.Clear();
            List<Table> tableList = TableDAO.Instance.LoadListTable();
            foreach (Table item in tableList)
            {
                Button btn = new Button()
                {
                    Height = TableDAO.tableHeight,
                    Width = TableDAO.tableWidth,
                    Text = item.Name + Environment.NewLine + item.Status,

                };
                btn.Click += btn_Click;
                btn.Tag = item;
                if (item.Status.ToString().Equals("Trống"))
                {
                    btn.BackColor = Color.GreenYellow;
                }
                else
                {
                    btn.BackColor = Color.Red;
                }
                flowLayoutPanelTable.Controls.Add(btn);
            }
        }
        void ShowBill(int id)
        {
            listViewBill.Items.Clear();
            textBoxAmount.Text = "";
            if(BillDAO.Instance.GetIdBill(id) != -1)
            {
                int amount = 0;
                DataTable tb = DataProvider.Instance.ExcuteQuery("select f.name as N'Name',bi.count as N'Count', f.price as N'Price', f.price*bi.count as N'Amount' from dbo.Bill as b, dbo.BillInfor as bi, dbo.Food as f\r\nwhere b.status = 0 and bi.idBill = b.id and bi.idFood = f.id and b.id = " + BillDAO.Instance.GetIdBill(id));
                foreach(DataRow item in tb.Rows)
                {
                    ListViewItem lsvItem = new ListViewItem(item["Name"].ToString());
                    lsvItem.SubItems.Add(item["Count"].ToString());
                    lsvItem.SubItems.Add(item["Price"].ToString());
                    lsvItem.SubItems.Add(item["Amount"].ToString());
                    amount += Convert.ToInt32(item["Amount"].ToString());
                    listViewBill.Items.Add(lsvItem);

                }
                textBoxAmount.Text = amount.ToString() + " đ";
            }
        }
        void btn_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as Table).Id;
            listViewBill.Tag = (sender as Button).Tag;
            ShowBill(tableID);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Close();
            fLogin f = new fLogin();
            f.Show();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int i = int.Parse(AccountDAO.Instance.GetTypeAccount(user).ToString());
            if (i != 1)
            {
                MessageBox.Show("Chức năng chỉ dành cho Admin","Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                fAdmin f = new fAdmin();
                this.Hide();
                f.ShowDialog();
                this.Show();
                Load_Table();
            }
            

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
        private void loadCatagory()
        {
            comboBoxTypeOfDish.DataSource = FoodCategoryDAO.Instance.GetListCategory();
            comboBoxTypeOfDish.DisplayMember = "name";
        }
        private void loadFoodListByCategory(int categoryID)
        {
            comboBoxDish.DataSource = FoodDAO.Instance.GetListFoodByID(categoryID);
            comboBoxDish.DisplayMember = "name";
        }

        private void comboBoxTypeOfDish_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            ComboBox cb = sender as ComboBox;
            if(cb.SelectedItem == null)
            {
                return;
            }
            FoodCategory fc = cb.SelectedItem as FoodCategory;
            id = fc.Id;
            loadFoodListByCategory(id);

        }

        private void comboBoxDish_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void buttonAddDishes_Click(object sender, EventArgs e)
        {
            Table table = listViewBill.Tag as Table;
            int idFood = (comboBoxDish.SelectedItem as Food).Id;
            int count = (int)numericUpDownQuatityDish.Value;
            int idBill = Convert.ToInt32(BillDAO.Instance.GetIdBill(table.Id).ToString());
            if(idBill == -1)
            {
                BillDAO.Instance.InsertBill(table.Id);
                BillInforDAO.Instance.InsertBillInfor(BillDAO.Instance.GetMaxIdBill(), idFood, count);
                DataProvider.Instance.ExcuteNonQuery("update TableFood set TableFood.status = N'Có người' from TableFood tf inner join Bill b on tf.id = b.idTable and b.status = 0");

            }
            else
            {
                BillInforDAO.Instance.InsertBillInfor(idBill, idFood, count);
            }
            ShowBill(table.Id);
            Load_Table();

        }

        private void buttonPay_Click(object sender, EventArgs e)
        {
            Table table = listViewBill.Tag as Table;
            int idBill = BillDAO.Instance.GetIdBill(table.Id);
            textBoxAmount.Text = textBoxAmount.Text.ToString().Substring(0,textBoxAmount.Text.ToString().Length - 1);
            int total = int.Parse(textBoxAmount.Text.ToString());
            if (MessageBox.Show("Bạn có chắc muốn thanh toán không","Thông báo",MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                BillDAO.Instance.checkOut(idBill,table.Id,total);
                int total1 = Convert.ToInt32(DataProvider.Instance.ExcutScalar(@"select sum(f.price*bi.count) from BillInfor as bi, Food as f, Bill as b where bi.idBill = b.id and bi.idFood = f.id and b.id = " + idBill));
                DataProvider.Instance.ExcuteNonQuery("update bill set Total = " + total1 +" where id = "+idBill);
                Load_Table();
                ShowBill(table.Id);

            }
        }

        private void textBoxAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void listViewBill_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void accountToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void informationAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fInformationAccount f = new fInformationAccount(user);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
