using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Home_Appliance
{
    public partial class Form1 : Form
    {
        DBConnect dBConnect = new DBConnect();
        public static string sellerName;
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_MouseEnter(object sender, EventArgs e)
        {
            label_clear.ForeColor = Color.Red;
        }

        private void label_clear_MouseLeave(object sender, EventArgs e)
        {
            label_clear.ForeColor = Color.DeepPink;
        }

        private void Button_login_Click(object sender, EventArgs e)
        {
            if (TextBox_username.Text == "" || TextBox_password.Text == "")
            {
                MessageBox.Show("Please enter Username and Password", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (comboBox_role.SelectedIndex > -1)
                {
                    if (comboBox_role.SelectedItem.ToString() == "OWNER(Admin)")
                    {
                        if ((TextBox_username.Text == "Zaw Latt" || TextBox_username.Text == "Kay Zin Theint" ) && TextBox_password.Text == "123")
                        {
                            ProductForm product = new ProductForm();
                            product.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Sure or not you are a owner", "Wrong Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        string selectQuery = "SELECT * FROM  Seller WHERE SellerName= '" + TextBox_username.Text + "' AND SellerPassword='" + TextBox_password.Text + "' ";

                        SqlDataAdapter adapter = new SqlDataAdapter(selectQuery, dBConnect.GetCon());
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        if (table.Rows.Count > 0)
                        {
                            sellerName = TextBox_username.Text;
                            SellingForm selling = new SellingForm();
                            selling.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Wrong Username od Password", "Wrong Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please choose your position", "Wrong Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void label_clear_Click(object sender, EventArgs e)
        {
            TextBox_username.Clear();
            TextBox_password.Clear();
        }
     
    }
    
}
