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

namespace Home_Appliance
{
    public partial class CategoryForm : Form
    {
        DBConnect dBConnect = new DBConnect();
        public CategoryForm()
        {
            InitializeComponent();
        }
        private void getTable()
        {
            string selectQuery = "SELECT * FROM Category";
            SqlCommand command = new SqlCommand(selectQuery, dBConnect.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView_category.DataSource = table;
        }

        private void Button_add_Click(object sender, EventArgs e)
        {
            try
            {
                string insertQuery = "INSERT INTO Category VALUES ('" + TextBox_id.Text + "','"+TextBox_name.Text+"','"+TextBox_description.Text+"')";
                SqlCommand command = new SqlCommand(insertQuery,dBConnect.GetCon());
                dBConnect.OpenCon();
                command.ExecuteNonQuery();
                MessageBox.Show("Category Added Successfully", "Add Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dBConnect.CloseCon();
                getTable();
                Clear();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            getTable();
        }

        private void Button_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBox_id.Text==""||TextBox_name.Text==""||TextBox_description.Text=="")
                {
                    MessageBox.Show("Missing Information","Warning",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string updateQuery = "UPDATE Category SET CategoryName ='" + TextBox_name.Text + "',Description='" + TextBox_description.Text + "'WHERE  CategoryID='" + TextBox_id.Text + "' ";
                    SqlCommand command = new SqlCommand(updateQuery, dBConnect.GetCon());
                    dBConnect.OpenCon();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Category Updated Successfully", "Update Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dBConnect.CloseCon();
                    getTable();
                    Clear();
                }      
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView_category_Click(object sender, EventArgs e)
        {
            TextBox_id.Text = dataGridView_category.SelectedRows[0].Cells[0].Value.ToString();
            TextBox_name.Text = dataGridView_category.SelectedRows[0].Cells[1].Value.ToString();
            TextBox_description.Text = dataGridView_category.SelectedRows[0].Cells[2].Value.ToString();
        }
        private void Clear()
        {
            TextBox_id.Clear();
            TextBox_name.Clear();
            TextBox_description.Clear();
        }

        private void Button_delete_Click(object sender, EventArgs e)
        {
            try
            {
                string deleteQuery = "DELETE FROM Category WHERE CategoryID='"+TextBox_id.Text+"' ";
                SqlCommand command = new SqlCommand(deleteQuery, dBConnect.GetCon());
                dBConnect.OpenCon();
                command.ExecuteNonQuery();
                MessageBox.Show("Category Deleted Successfully", "Delete Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dBConnect.CloseCon();
                getTable();
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_logout_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Hide();
        }

        private void Button_product_Click_1(object sender, EventArgs e)
        {
            ProductForm product = new ProductForm();
            product.Show();
            this.Hide();
        }

        private void Button_seller_Click(object sender, EventArgs e)
        {
            SellerForm seller = new SellerForm();
            seller.Show();
            this.Hide();
        }

        private void guna2GradientCircleButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
