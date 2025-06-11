namespace ExemploAula
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
            lbllogin = new Label();
            lbluser = new Label();
            lblsenha = new Label();
            txtuser = new TextBox();
            txtsenha = new TextBox();
            btnlogin = new Button();
            SuspendLayout();
            // 
            // lbllogin
            // 
            lbllogin.AutoSize = true;
            lbllogin.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbllogin.Location = new Point(324, 42);
            lbllogin.Name = "lbllogin";
            lbllogin.Size = new Size(84, 31);
            lbllogin.TabIndex = 0;
            lbllogin.Text = "LOGIN";
            // 
            // lbluser
            // 
            lbluser.AutoSize = true;
            lbluser.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbluser.Location = new Point(188, 136);
            lbluser.Name = "lbluser";
            lbluser.Size = new Size(66, 18);
            lbluser.TabIndex = 1;
            lbluser.Text = "Usuário:";
            // 
            // lblsenha
            // 
            lblsenha.AutoSize = true;
            lblsenha.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblsenha.Location = new Point(188, 184);
            lblsenha.Name = "lblsenha";
            lblsenha.Size = new Size(57, 18);
            lblsenha.TabIndex = 2;
            lblsenha.Text = "Senha:";
            // 
            // txtuser
            // 
            txtuser.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtuser.Location = new Point(285, 133);
            txtuser.Name = "txtuser";
            txtuser.Size = new Size(163, 26);
            txtuser.TabIndex = 3;
            // 
            // txtsenha
            // 
            txtsenha.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtsenha.Location = new Point(285, 184);
            txtsenha.Name = "txtsenha";
            txtsenha.PasswordChar = '*';
            txtsenha.Size = new Size(163, 26);
            txtsenha.TabIndex = 4;
            // 
            // btnlogin
            // 
            btnlogin.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnlogin.Location = new Point(285, 340);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(163, 50);
            btnlogin.TabIndex = 5;
            btnlogin.Text = "Login";
            btnlogin.UseVisualStyleBackColor = true;
            btnlogin.Click += btnlogin_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnlogin);
            Controls.Add(txtsenha);
            Controls.Add(txtuser);
            Controls.Add(lblsenha);
            Controls.Add(lbluser);
            Controls.Add(lbllogin);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LOGIN";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbllogin;
        private Label lbluser;
        private Label lblsenha;
        private TextBox txtuser;
        private TextBox txtsenha;
        private Button btnlogin;
    }
}
