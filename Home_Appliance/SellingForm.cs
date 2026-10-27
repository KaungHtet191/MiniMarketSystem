using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Home_Appliance
{
    public partial class SellingForm : Form
    {
        DBConnect dBConnect = new DBConnect();
        public SellingForm()
        {
            InitializeComponent();
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
        }
        private void getTable()
        {
            string selectQuery = "SELECT ProductName,ProductPrice FROM Product";
            SqlCommand command = new SqlCommand(selectQuery, dBConnect.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            DataGridView_product.DataSource = table;
        }
        private void getSellTable()
        {
            string selectQuery = "SELECT * FROM Bill";
            SqlCommand command = new SqlCommand(selectQuery, dBConnect.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            DataGridView_sellList.DataSource = table;
        }
        private void Clear()
        {
            TextBox1_ID.Clear();
        }
        private void SellingForm_Load(object sender, EventArgs e)
        {
            label_date.Text = DateTime.Today.ToShortDateString();
            label_salesman.Text = Form1.sellerName;
            //label_time.Text = DateTime.Now.ToString();
            getTable();
            getCategory();
            getSellTable();
        }

        private void DataGridView_product_Click(object sender, EventArgs e)
        {
            TextBox_name.Text = DataGridView_product.SelectedRows[0].Cells[0].Value.ToString();
            TextBox_price.Text = DataGridView_product.SelectedRows[0].Cells[1].Value.ToString();

        }
        

        private void Button_add_Click(object sender, EventArgs e)
        {
            try
            {
                string insertQuery = "INSERT INTO Bill VALUES ('" + TextBox1_ID.Text + "','" + label_salesman.Text + "','" + label_date.Text + "'," + grandTotal.ToString() + ") ";
                SqlCommand command = new SqlCommand(insertQuery, dBConnect.GetCon());
                dBConnect.OpenCon();
                command.ExecuteNonQuery();
                MessageBox.Show("Order Added Successfully", "Order Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dBConnect.CloseCon();
                //getTable();
                getSellTable();
                UpdateProduct();

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

        private void Button_refresh_Click(object sender, EventArgs e)
        {
            getTable();
        }

        private void comboBox_category_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string selectQuery = "SELECT ProductName,ProductPrice FROM Product WHERE Category='" + comboBox_category.SelectedValue.ToString() + "'  ";
            SqlCommand command = new SqlCommand(selectQuery, dBConnect.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            DataGridView_product.DataSource = table;
        }

        private void Button_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBox1_ID.Text == "")
                {
                    MessageBox.Show("Missing Information", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string deleteQuery = "DELETE FROM Bill WHERE VoucherID='" + TextBox1_ID.Text + "' ";
                    SqlCommand command = new SqlCommand(deleteQuery, dBConnect.GetCon());
                    dBConnect.OpenCon();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Bill Deleted Successfully", "Bill Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dBConnect.CloseCon();
                    getSellTable();
                    Clear();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DataGridView_sellList_Click(object sender, EventArgs e)
        {
            TextBox1_ID.Text = DataGridView_sellList.SelectedRows[0].Cells[0].Value.ToString();
        }

        int grandTotal = 0, n = 0;

        private void Button_addOrder_Click(object sender, EventArgs e)
        {
            if (TextBox_name.Text == "" || TextBox_qty.Text == "")
            {
                MessageBox.Show("Missing Information", "Information Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int Total = Convert.ToInt32(TextBox_price.Text) * Convert.ToInt32(TextBox_qty.Text);
                DataGridViewRow addRow = new DataGridViewRow();
                addRow.CreateCells(dataGridView_order);
                addRow.Cells[0].Value = ++n;
                addRow.Cells[1].Value = TextBox_name.Text;
                addRow.Cells[2].Value = TextBox_price.Text;
                addRow.Cells[3].Value = TextBox_qty.Text;
                addRow.Cells[4].Value = Total;
                dataGridView_order.Rows.Add(addRow);
                grandTotal += Total;
                label_amount.Text = grandTotal + " $";
               

            }

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            ScannerForm scanner = new ScannerForm();
            scanner.Show();
            this.Hide();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap imagebmp = new Bitmap(dataGridView_order.Width,dataGridView_order.Height);
            dataGridView_order.DrawToBitmap(imagebmp, new Rectangle(0, 0, dataGridView_order.Width, dataGridView_order.Height));
            e.Graphics.DrawImage(imagebmp, 120, 20);

        }

        private void Button_print_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();


        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            printPreviewDialog2.Document = printDocument2;
            printPreviewDialog2.PrintPreviewControl.Zoom = 1;
            printPreviewDialog2.ShowDialog();
        }

        private void printDocument2_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap imagebmp = new Bitmap(dataGridView_order.Width, dataGridView_order.Height);
            DataGridView_sellList.DrawToBitmap(imagebmp, new Rectangle(0, 0, dataGridView_order.Width, dataGridView_order.Height));
            e.Graphics.DrawImage(imagebmp, 120, 20);
        }

        

        private void UpdateProduct()
        {
            try
            {
                int Qty, newQty, textQty;
                textQty = int.Parse(TextBox_qty.Text);
                
                    dBConnect.OpenCon();
                    string updateQuery = "SELECT * FROM Product  WHERE  ProductName='" + TextBox_name.Text + "'";
                    SqlCommand cmd = new SqlCommand(updateQuery, dBConnect.GetCon());

                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    foreach (DataRow dr in dt.Rows)
                    {
                        Qty = Convert.ToInt32(dr["Quantity"].ToString());
                        newQty = Qty - textQty;
                    if (newQty < 0)
                    {
                        MessageBox.Show("Here no products", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        string query1 = "UPDATE Product SET Quantity=" + newQty + "WHERE ProductName='" + TextBox_name.Text + "'; ";
                        SqlCommand cmd1 = new SqlCommand(query1, dBConnect.GetCon());
                        cmd1.ExecuteNonQuery();
                    }
                    }
                  
                    dBConnect.CloseCon();
                
               
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
