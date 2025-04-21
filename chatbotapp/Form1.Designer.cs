namespace chatbotapp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSend = new Button();
            lblResponse = new Label();
            lblQuestion = new Label();
            txtQuestion = new TextBox();
            SuspendLayout();
            // 
            // btnSend
            // 
            btnSend.Location = new Point(434, 121);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(94, 29);
            btnSend.TabIndex = 0;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // lblResponse
            // 
            lblResponse.AutoSize = true;
            lblResponse.Location = new Point(341, 254);
            lblResponse.Name = "lblResponse";
            lblResponse.Size = new Size(0, 20);
            lblResponse.TabIndex = 1;
            // 
            // lblQuestion
            // 
            lblQuestion.AutoSize = true;
            lblQuestion.Location = new Point(341, 254);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(0, 20);
            lblQuestion.TabIndex = 2;
            // 
            // txtQuestion
            // 
            txtQuestion.Location = new Point(148, 121);
            txtQuestion.Name = "txtQuestion";
            txtQuestion.Size = new Size(125, 27);
            txtQuestion.TabIndex = 3;
            txtQuestion.TextChanged += txtQuestion_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtQuestion);
            Controls.Add(lblQuestion);
            Controls.Add(lblResponse);
            Controls.Add(btnSend);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSend;
        private Label lblResponse;
        private Label lblQuestion;
        private TextBox txtQuestion;
    }
}
