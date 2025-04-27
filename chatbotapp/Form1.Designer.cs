namespace chatbotapp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            btnSend = new Button();
            lblResponse = new Label();
            lblQuestion = new Label();
            txtQuestion = new TextBox();
            btnShowAll = new Button();
            txtDeleteId = new TextBox();
            btnDeleteId = new Button();
            SuspendLayout();
            // 
            // btnSend
            // 
            btnSend.Location = new Point(434, 120);
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
            lblResponse.Click += lblResponse_Click;
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
            // btnShowAll
            // 
            btnShowAll.Location = new Point(587, 160);
            btnShowAll.Name = "btnShowAll";
            btnShowAll.Size = new Size(94, 29);
            btnShowAll.TabIndex = 4;
            btnShowAll.Text = "Show all";
            btnShowAll.UseVisualStyleBackColor = true;
            btnShowAll.Click += btnShowAll_Click;
            // 
            // txtDeleteId
            // 
            txtDeleteId.Location = new Point(148, 189);
            txtDeleteId.Name = "txtDeleteId";
            txtDeleteId.Size = new Size(125, 27);
            txtDeleteId.TabIndex = 5;
           
            // 
            // btnDeleteId
            // 
            btnDeleteId.Location = new Point(434, 189);
            btnDeleteId.Name = "btnDeleteId";
            btnDeleteId.Size = new Size(94, 29);
            btnDeleteId.TabIndex = 6;
            btnDeleteId.Text = "Delete";
            btnDeleteId.UseVisualStyleBackColor = true;
            btnDeleteId.Click += btnDeleteId_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDeleteId);
            Controls.Add(txtDeleteId);
            Controls.Add(btnShowAll);
            Controls.Add(txtQuestion);
            Controls.Add(lblQuestion);
            Controls.Add(lblResponse);
            Controls.Add(btnSend);
            Name = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSend;
        private Label lblResponse;
        private Label lblQuestion;
        private TextBox txtQuestion;
        private Button btnShowAll;
        private TextBox txtDeleteId;
        private Button btnDeleteId;
    }
}
