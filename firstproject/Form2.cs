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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace firstproject
{
    public partial class Form2 : Form
    {
        OracleConnection con = new OracleConnection(@"User Id=system;Password=Subathra$2005;Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=Subathra)(PORT=1521)))(CONNECT_DATA=(SERVICE_NAME=XE)));Connection Timeout=60;");

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            BindData();
        }
        void BindData()
        {
            OracleCommand command = new OracleCommand("select * from maintenance", con);
            OracleDataAdapter adapter = new OracleDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;

        }
        private bool ValidateFields()
        {
            // Check if any required field is empty
            if (string.IsNullOrEmpty(pcidTextBox.Text.Trim()) ||
                string.IsNullOrEmpty(presentEmpidTextBox.Text.Trim()) ||
                string.IsNullOrEmpty(PresentUserNameTextBox.Text.Trim()) ||
                string.IsNullOrEmpty(MacTextBox.Text.Trim()) ||
                string.IsNullOrEmpty(IpTextBox.Text.Trim()) ||
                string.IsNullOrEmpty(modelTextBox.Text.Trim()) || string.IsNullOrEmpty(RemarksTextBox.Text.Trim()))
            {
                MessageBox.Show("All fields are required. Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void submit_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateFields())
                {
                    return;
                }
                // Open the connection
                con.Open();

                // Prepare the SQL command
                OracleCommand cmd = new OracleCommand(
                    "INSERT INTO maintenance (pcid, presentempid, presentusername, mac,ip,model,remarks) " +
                    "VALUES (:pcserialnumber, :presentempid, :presentusername, :mac, :ip, :built, :remarks)", con);

                // Add parameters with appropriate values
                cmd.Parameters.Add(new OracleParameter("pcid", pcidTextBox.Text));
                cmd.Parameters.Add(new OracleParameter("presentempid", presentEmpidTextBox.Text));
                cmd.Parameters.Add(new OracleParameter("presentusername", PresentUserNameTextBox.Text));
                cmd.Parameters.Add(new OracleParameter("mac", MacTextBox.Text));
                cmd.Parameters.Add(new OracleParameter("ip", IpTextBox.Text));
                cmd.Parameters.Add(new OracleParameter("model", modelTextBox.Text));
                cmd.Parameters.Add(new OracleParameter("remarks", RemarksTextBox.Text));

                // Execute the command
                cmd.ExecuteNonQuery();

                // Show success message
                MessageBox.Show("Submitted successfully");
            }
            catch (Exception ex)
            {
                // Print error message to the console
                Debug.WriteLine($"Error: {ex.Message}");
                Debug.WriteLine($"Stack Trace: {ex.StackTrace}");

                // Optionally, show an error message to the user
                MessageBox.Show("An error occurred while submitting the data. Please try again.");
            }
            finally
            {
                // Always close the connection, even if an error occurs
                con.Close();
                BindData();
            }

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateFields())
                {
                    return;
                }
                // Open the connection
                con.Open();

                // Prepare the SQL command for updating the record
                OracleCommand cmd = new OracleCommand(
                    "UPDATE maintenance " +
                    "SET presentempid = :presentempid, " +
                    "presentusername = :presentusername, " +
                    "mac = :mac, " +
                    "ip = :ip, " +
                    "model = :model, " +
                    "remarks = :remarks " +
                    "WHERE pcid = :pcid", con);

                // Add parameters with appropriate values
                cmd.Parameters.Add(new OracleParameter("presentempid", presentEmpidTextBox.Text));
                cmd.Parameters.Add(new OracleParameter("presentusername", PresentUserNameTextBox.Text));
                cmd.Parameters.Add(new OracleParameter("mac", MacTextBox.Text));
                cmd.Parameters.Add(new OracleParameter("ip", IpTextBox.Text));
                cmd.Parameters.Add(new OracleParameter("model", modelTextBox.Text));
                cmd.Parameters.Add(new OracleParameter("remarks", RemarksTextBox.Text));
                cmd.Parameters.Add(new OracleParameter("pcid", pcidTextBox.Text)); // Identifies the record to update

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
                Console.WriteLine($"Error: {ex.Message}");

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

        private void button2_Click(object sender, EventArgs e)
        {
            Form f = new PCComplaints();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f = new Form1();
            f.Show();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (pcidTextBox.Text != "")
            {
                con.Open();
                OracleCommand command = new OracleCommand("Delete maintenance where PCID='" + pcidTextBox.Text + "'", con);
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
    }
}
