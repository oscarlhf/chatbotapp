using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace chatbotapp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Puedes agregar aquí inicializaciones si es necesario
        }

        private void txtQuestion_TextChanged(object sender, EventArgs e)
        {
            // Dejar vacío o usarlo si necesitas validaciones en tiempo real
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string question = txtQuestion.Text;
            if (!string.IsNullOrWhiteSpace(question))
            {
                SaveQuestionToDatabase(question);
                MessageBox.Show("Question saved!");
                txtQuestion.Clear();
            }
            else
            {
                MessageBox.Show("Please enter a question.");
            }
        }

        private void SaveQuestionToDatabase(string question)
        {
            string dbPath = "chatbot.db";
            string connectionString = $"Data Source={dbPath};Version=3;";

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string sql = "INSERT INTO Questions (Text, CreatedAt) VALUES (@text, @createdAt)";
                SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@text", question);
                cmd.Parameters.AddWithValue("@createdAt", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                cmd.ExecuteNonQuery();
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            ReadQuestionsFromDatabase();
        }

        private void ReadQuestionsFromDatabase()
        {
            string dbPath = "chatbot.db";
            string connectionString = $"Data Source={dbPath};Version=3;";
            string result = "";

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string sql = "SELECT Id, Text, CreatedAt FROM Questions";
                SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                SQLiteDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    result += $"ID: {reader["Id"]} - Text: {reader["Text"]} - CreatedAt: {reader["CreatedAt"]}\n";
                }
            }

            MessageBox.Show(result, "All Questions");
        }

        private void btnDeleteId_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtDeleteId.Text, out int id))
            {
                DeleteQuestionById(id);
            }
            else
            {
                MessageBox.Show("Please enter a valid numeric ID.");
            }
        }

        private void DeleteQuestionById(int id)
        {
            string dbPath = "chatbot.db";
            string connectionString = $"Data Source={dbPath};Version=3;";

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string sql = "DELETE FROM Questions WHERE Id = @id";
                SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", id);
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                    MessageBox.Show($"Question with ID {id} deleted.");
                else
                    MessageBox.Show($"No question found with ID {id}.");
            }
        }

        private void lblResponse_Click(object sender, EventArgs e)
        {

        }
    }
}
