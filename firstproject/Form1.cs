using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace firstproject
{
    public partial class Form1 : Form
    {
        OracleConnection con = new OracleConnection(@"User Id=system;Password=Subathra$2005;Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=Subathra)(PORT=1521)))(CONNECT_DATA=(SERVICE_NAME=XE)));Connection Timeout=60;");

        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate input
                DateTime selectedDate = dateTimePicker1.Value;
                if (string.IsNullOrWhiteSpace(textBox1.Text) || selectedDate == DateTime.MinValue)
                {
                    MessageBox.Show("No fields should be empty");
                    return;
                }
                String pcId = textBox1.Text;
                // Create the command with parameterized query
                OracleCommand command = new OracleCommand("SELECT * FROM PC_History WHERE PCID = :pcId", con);
                command.Parameters.Add(new OracleParameter("pcId", pcId));

                // Execute the query
                OracleDataAdapter adapter = new OracleDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                // Bind the result to the DataGridView
                dataGridView1.DataSource = dt;

                // Check if data is returned
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No records found for the given PC ID");
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
        void BindData()
        {
            OracleCommand command = new OracleCommand("select * from PC_History", con);
            OracleDataAdapter sd = new OracleDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            BindData();
        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                OracleCommand command = new OracleCommand(
                "INSERT INTO PC_History (PCID, MODEL, IP_ADDRESS, MAC_ADDRESS, FORMER_USER_NAME, NEW_USER_NAME, LAST_USED_DATE) " +
                "VALUES (:pcid, :model, :ip_address, :mac_address, :former_user_name, :new_user_name, :last_used_date)", con);

                // Add parameters
                command.Parameters.Add(new OracleParameter("pcid", textBox1.Text)); // PC_ID
                command.Parameters.Add(new OracleParameter("model", textBox2.Text)); // MODEL
                command.Parameters.Add(new OracleParameter("ip_address", textBox3.Text)); // IP_ADDRESS
                command.Parameters.Add(new OracleParameter("mac_address", textBox4.Text)); // MAC_ADDRESS
                command.Parameters.Add(new OracleParameter("former_user_name", textBox8.Text)); // FORMER_USER_NAME
                command.Parameters.Add(new OracleParameter("new_user_name", textBox6.Text)); // NEW_USER_NAME
                command.Parameters.Add(new OracleParameter("last_used_date", dateTimePicker1.Value)); // LAST_USED_DATE


                command.ExecuteNonQuery();
                MessageBox.Show("Successfully Inserted");
                BindData();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                MessageBox.Show("Enter A Valid Data");
            }
            finally
            {
                con.Close();
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                con.Open();
                OracleCommand command = new OracleCommand("Delete PC_History where PCID='" + textBox1.Text + "'", con);
                command.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfully Deleted");
                BindData();
            }
            else
            {
                MessageBox.Show("Enter A Valid PC ID");
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            foreach (System.Windows.Forms.Control control in this.Controls)
            {
                if (control is System.Windows.Forms.TextBox textBox)
                {
                    textBox.Clear(); // Clear text in TextBox
                }
                else if (control is System.Windows.Forms.ComboBox comboBox)
                {
                    comboBox.SelectedIndex = -1; // Reset ComboBox selection
                }
                else if (control is System.Windows.Forms.CheckBox checkBox)
                {
                    checkBox.Checked = false; // Uncheck CheckBox
                }
                else if (control is System.Windows.Forms.RadioButton radioButton)
                {
                    radioButton.Checked = false; // Uncheck RadioButton
                }
                else if (control is System.Windows.Forms.DataGridView dataGridView)
                {
                    dataGridView.DataSource = null; // Clear DataGridView content
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f = new Form2();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form f = new PCComplaints();
            f.Show();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime selectedDate = dateTimePicker1.Value;
                String pcid = textBox1.Text;

                if (string.IsNullOrWhiteSpace(textBox1.Text) || selectedDate == DateTime.MinValue)
                { 
                    return;
                }
                // Open the connection
                con.Open();

                // Prepare the SQL command for updating the record
                OracleCommand cmd = new OracleCommand(
                    "UPDATE PC_History " +
                    "SET former_user_name = :former_user_name, " +
                    "last_used_date = :last_used_date " +
                    "WHERE pcid = :pcid", con);

                // Add parameters with appropriate values
                cmd.Parameters.Add(new OracleParameter("former_user_name", textBox8.Text)); // FORMER_USER_NAME
                cmd.Parameters.Add(new OracleParameter("last_used_date", dateTimePicker1.Value)); // LAST_USED_DATE
                cmd.Parameters.Add(new OracleParameter("pcid", pcid));

                // Identifies the record to update

                // Execute the command
                int rowsAffected = cmd.ExecuteNonQuery();

                // Check if any rows were updated
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Record updated successfully");
                }
                else
                {
                    MessageBox.Show("No record found with the specified PC Serial Number.");
                }
            }
            catch (Exception ex)
            {
                // Print error message to the console
                Debug.WriteLine($"Error: {ex.Message}");
                Debug.WriteLine($"Stack Trace: {ex.StackTrace}");

                // Optionally, show an error message to the user
                MessageBox.Show("An error occurred while updating the data. Please try again.");
            }
            finally
            {
                // Always close the connection, even if an error occurs
                con.Close();
                BindData();
            }
        }
    }
}
