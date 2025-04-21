namespace chatbotapp;
    using System.Data.SQLite;

    

    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
        SaveQuestionToDatabase(txtQuestion.Text);

        {
            string input = txtQuestion.Text.ToLower();

                // Simple predefined responses
                if (input.Contains("hello"))
                {
                    lblResponse.Text = "Hello! How can I assist you?";
                }
                else if (input.Contains("price"))
                {
                    lblResponse.Text = "You can check our prices on the website.";
                }
                else
                {
                    lblResponse.Text = "I'm sorry, I didn't understand that.";
                }
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

    private void txtQuestion_TextChanged(object sender, EventArgs e)
        {

        }
    }

