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
            SuspendLayout();
            // 
            // lbllogin
            // 
            lbllogin.AutoSize = true;
            lbllogin.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbllogin.Location = new Point(325, 54);
            lbllogin.Name = "lbllogin";
            lbllogin.Size = new Size(59, 23);
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
            txtuser.Location = new Point(414, 136);
            txtuser.Name = "txtuser";
            txtuser.Size = new Size(100, 26);
            txtuser.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtuser);
            Controls.Add(lblsenha);
            Controls.Add(lbluser);
            Controls.Add(lbllogin);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbllogin;
        private Label lbluser;
        private Label lblsenha;
        private TextBox txtuser;
    }
}
