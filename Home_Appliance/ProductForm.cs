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
    public partial class ProductForm : Form
    {
        DBConnect dBConnect = new DBConnect();
        public ProductForm()
        {
            InitializeComponent();
        }

        private void Button_category_Click(object sender, EventArgs e)
        {
            CategoryForm category = new CategoryForm();
            category.Show();
            this.Hide();
        }
        private void getCategory()
        {
            string selectQuery = "SELECT * FROM Category";
            SqlCommand command = new SqlCommand(selectQuery, dBConnect.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            comboBox_category.DataSource = table;
            comboBox_category.ValueMember = "CategoryName";
            comboBox2_search.DataSource = table;
            comboBox2_search.ValueMember = "CategoryName";
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            getCategory();
            getTable();
            label_date.Text = DateTime.Today.ToShortDateString();
        }
        private void getTable()
        {
            string selectQuery = "SELECT * FROM Product";
            SqlCommand command = new SqlCommand(selectQuery, dBConnect.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView_product.DataSource = table;
        }
        private void Clear()
        {
            TextBox_id.Clear();
            TextBox_name.Clear(); 
            TextBox_price.Clear();
            TextBox_qty.Clear();
            comboBox_category.SelectedIndex = 0;
        }

        private void Button_add_Click(object sender, EventArgs e)
        {
            try
            {
                string insertQuery = "INSERT INTO Product VALUES ('" + TextBox_id.Text + "','" + TextBox_name.Text + "','" + TextBox_price.Text + "','" + TextBox_qty.Text + "','" + comboBox_category.Text + "','"+label_date.Text+"') ";
                SqlCommand command = new SqlCommand(insertQuery, dBConnect.GetCon());
                dBConnect.OpenCon();
                command.ExecuteNonQuery();
                MessageBox.Show("Product Added Successfully", "Add Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dBConnect.CloseCon();
                getTable();
                Clear();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void Button_update_Click(object sender, EventArgs e)
        {
           
            try
            {
                if (TextBox_id.Text == "" || TextBox_name.Text == "" || TextBox_price.Text == "" || TextBox_qty.Text == "")
                {
                    MessageBox.Show("Missing Information", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string updateQuery = "UPDATE Product SET ProductName='" + TextBox_name.Text + "',ProductPrice=" + TextBox_price.Text + ",Quantity=" + TextBox_qty.Text + ",Category='" + comboBox_category.Text + "'WHERE ProductID='" + TextBox_id.Text + "' ";
                    SqlCommand command = new SqlCommand(updateQuery, dBConnect.GetCon());
                    dBConnect.OpenCon();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Product Updated Successfully", "Update Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dBConnect.CloseCon();
                    getTable();
                    Clear();
                }
              
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView_product_Click(object sender, EventArgs e)
        {
            TextBox_id.Text = dataGridView_product.SelectedRows[0].Cells[0].Value.ToString();
            TextBox_name.Text = dataGridView_product.SelectedRows[0].Cells[1].Value.ToString();
            TextBox_price.Text= dataGridView_product.SelectedRows[0].Cells[2].Value.ToString();
            TextBox_qty.Text= dataGridView_product.SelectedRows[0].Cells[3].Value.ToString();
            comboBox_category.SelectedValue= dataGridView_product.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void Button_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBox_id.Text == "")
                {
                    MessageBox.Show("Missing Information", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string deleteQuery = "DELETE FROM Product WHERE ProductID='" + TextBox_id.Text + "' ";
                    SqlCommand command = new SqlCommand(deleteQuery, dBConnect.GetCon());
                    dBConnect.OpenCon();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Product Deleted Successfully", "Delete Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void Button_referesh_Click(object sender, EventArgs e)
        {
            getTable();
        }

        private void Button_logout_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Hide();
        }

        private void Button_seller_Click(object sender, EventArgs e)
        {
            SellerForm seller = new SellerForm();
            seller.Show();
            this.Hide();
        }

        private void comboBox2_search_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string selectQuery = "SELECT * FROM Product WHERE Category='" + comboBox2_search.SelectedValue.ToString() + "'  ";
            SqlCommand command = new SqlCommand(selectQuery, dBConnect.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView_product.DataSource = table;
        }
    }
}
