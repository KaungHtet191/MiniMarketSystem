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
    public partial class SellerForm : Form
    {
        DBConnect dBConnect = new DBConnect();
        public SellerForm()
        {
            InitializeComponent();
        }
        private void getTable()
        {
            string selectQuery = "SELECT * FROM Seller";
            SqlCommand command = new SqlCommand(selectQuery, dBConnect.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView_seller.DataSource = table;
        }
        private void Clear()
        {
            TextBox_id.Clear();
            TextBox_name.Clear();
            TextBox_age.Clear();
            TextBox_phone.Clear();
            TextBox_password.Clear();
        }
        private void Button_add_Click(object sender, EventArgs e)
        {
            try
            {
                string insertQuery = "INSERT INTO Seller VALUES ('" + TextBox_id.Text + "','" + TextBox_name.Text + "','" + TextBox_age.Text + "','" + TextBox_phone.Text + "','" + TextBox_password.Text + "') ";
                SqlCommand command = new SqlCommand(insertQuery, dBConnect.GetCon());
                dBConnect.OpenCon();
                command.ExecuteNonQuery();
                MessageBox.Show("Seller Added Successfully", "Seller Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dBConnect.CloseCon();
                getTable();
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SellerForm_Load(object sender, EventArgs e)
        {
            getTable();
        }

        private void Button_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBox_id.Text == "" || TextBox_name.Text == "" || TextBox_age.Text == "" || TextBox_phone.Text == "" || TextBox_password.Text=="")
                {
                    MessageBox.Show("Missing Information", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string updateQuery = "UPDATE Seller SET SellerName='" + TextBox_name.Text + "',SellerAge='" + TextBox_age.Text + "',SellerPhone='" + TextBox_phone.Text + "',SellerPassword='" + TextBox_password.Text + "'WHERE SellerID='" + TextBox_id.Text + "' ";
                    SqlCommand command = new SqlCommand(updateQuery, dBConnect.GetCon());
                    dBConnect.OpenCon();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Seller Updated Successfully", "Seller Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void dataGridView_seller_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TextBox_id.Text = dataGridView_seller.SelectedRows[0].Cells[0].Value.ToString();
            TextBox_name.Text = dataGridView_seller.SelectedRows[0].Cells[1].Value.ToString();
            TextBox_age.Text = dataGridView_seller.SelectedRows[0].Cells[2].Value.ToString();
            TextBox_phone.Text = dataGridView_seller.SelectedRows[0].Cells[3].Value.ToString();
            TextBox_password.Text = dataGridView_seller.SelectedRows[0].Cells[4].Value.ToString();
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
                    if (MessageBox.Show("Are you sure want to delete?","Delete Record",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                    {
                        string deleteQuery = "DELETE FROM Seller WHERE SellerID='" + TextBox_id.Text + "' ";
                        SqlCommand command = new SqlCommand(deleteQuery, dBConnect.GetCon());
                        dBConnect.OpenCon();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Seller Deleted Successfully", "Delete Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dBConnect.CloseCon();
                        getTable();
                        Clear();
                    }
                    
                }

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

        private void Button_product_Click(object sender, EventArgs e)
        {
            ProductForm product = new ProductForm();
            product.Show();
            this.Hide();
        }

        private void Button_category_Click(object sender, EventArgs e)
        {
            CategoryForm category = new CategoryForm();
            category.Show();
            this.Hide();
        }

    }
}
