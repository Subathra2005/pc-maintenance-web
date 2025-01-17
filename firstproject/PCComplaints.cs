using System.Data;
using System.Diagnostics;
using Oracle.ManagedDataAccess.Client;

namespace firstproject
{
    public partial class PCComplaints : Form
    {
        OracleConnection con = new OracleConnection(@"User Id=system;Password=Subathra$2005;Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=Subathra)(PORT=1521)))(CONNECT_DATA=(SERVICE_NAME=XE)));Connection Timeout=60;");

        public PCComplaints()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BindData();
        }

        private void Complaints_Click(object sender, EventArgs e)
        {

        }
        private bool ValidateFields()
        {
            // Get values from the fields
            string pcid = pcidtextBox.Text.Trim(); // TextBox for PC ID
            DateTime selectedDate = dateTimePicker.Value; // DateTimePicker for Date
            string complaints = complaintscomboBox.Text.Trim(); // ComboBox for Complaints
            string queries = queriestextBox.Text.Trim(); // TextBox for Queries
            string status = statusComboBox.Text.Trim();

            // Check if PC ID is empty
            if (string.IsNullOrEmpty(pcid))
            {
                MessageBox.Show("PC ID cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Check if Date is not selected (optional, as DateTimePicker always has a value)
            if (selectedDate == DateTime.MinValue)
            {
                MessageBox.Show("Date cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Check if both Complaints and Queries are empty
            if ((string.IsNullOrEmpty(complaints) || complaintscomboBox.SelectedIndex == -1) && (string.IsNullOrEmpty(queries) || queriestextBox.Text == "Specify other complaints, if any"))
            {
                MessageBox.Show("Either Complaints or Queries must be filled.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(status))
            {
                MessageBox.Show("Complaint status cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    "INSERT INTO complaints (pcid, complaintDate, complaints, queries) " +
                    "VALUES (:pcid, :complaintDate, :complaints, :queries)", con);

                // Add parameters with appropriate values
                cmd.Parameters.Add(new OracleParameter("pcid", pcidtextBox.Text));
                cmd.Parameters.Add(new OracleParameter("complaintDate", dateTimePicker.Value));
                cmd.Parameters.Add(new OracleParameter("complaints", complaintscomboBox.Text));
                cmd.Parameters.Add(new OracleParameter("queries", queriestextBox.Text));

                // Execute the command
                cmd.ExecuteNonQuery();

                // Show success message
                MessageBox.Show("Submitted successfully");
            }
            catch (Exception ex)
            {
                // Print error message to the console
                Console.WriteLine($"Error: {ex.Message}");

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        void BindData()
        {
            OracleCommand command = new OracleCommand("select * from complaints", con);
            OracleDataAdapter adapter = new OracleDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrWhiteSpace(pcidtextBox.Text.Trim()) ||
                    dateTimePicker.Value == DateTimePicker.MinimumDateTime ||
                    dateTimePicker.Value == default(DateTime))
                {
                    MessageBox.Show("PC ID or Date cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DateTime selectedDate = dateTimePicker.Value;
                string pcid = pcidtextBox.Text.Trim();

                con.Open();


                OracleCommand cmd = new OracleCommand(
                    "DELETE FROM complaints WHERE pcid = :pcid AND TRUNC(complaintDate) = :complaintDate", con);

                cmd.Parameters.Add(new OracleParameter("pcid", pcid));
                cmd.Parameters.Add(new OracleParameter("complaintDate", selectedDate.Date));


                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No matching record found to delete.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                MessageBox.Show("An error occurred while deleting the data. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

                con.Close();
                BindData();
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }



        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form f = new Form2();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form f = new Form1();
            f.Show();
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
                    "UPDATE complaints " +
                    "SET complaintDate = :complaintDate, " +
                    "complaints = :complaints, " +
                    "queries = :queries, " +
                    "status = :status " +
                    "WHERE pcid = :pcid", con);

                // Add parameters with appropriate values
                cmd.Parameters.Add(new OracleParameter("complaintDate", dateTimePicker.Value));
                cmd.Parameters.Add(new OracleParameter("complaints", complaintscomboBox.Text));
                cmd.Parameters.Add(new OracleParameter("queries", queriestextBox.Text));
                cmd.Parameters.Add(new OracleParameter("status", statusComboBox.Text));
                cmd.Parameters.Add(new OracleParameter("pcid", pcidtextBox.Text.Trim()));
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
            catch (OracleException ex)
            {
                // Log detailed database-related error messages
                Debug.WriteLine($"Error: {ex.Message}");
                Debug.WriteLine($"Stack Trace: {ex.StackTrace}");

                // Show a user-friendly error message
                MessageBox.Show("An error occurred while interacting with the database. Please try again.");
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

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
