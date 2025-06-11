namespace ExemploAula
{
    partial class frmmenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            mnuprograma = new MenuStrip();
            loginToolStripMenuItem = new ToolStripMenuItem();
            loginToolStripMenuItem1 = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            deslogarToolStripMenuItem = new ToolStripMenuItem();
            fecharToolStripMenuItem = new ToolStripMenuItem();
            mnuprograma.SuspendLayout();
            SuspendLayout();
            // 
            // mnuprograma
            // 
            mnuprograma.Items.AddRange(new ToolStripItem[] { loginToolStripMenuItem, sairToolStripMenuItem });
            mnuprograma.Location = new Point(0, 0);
            mnuprograma.Name = "mnuprograma";
            mnuprograma.Size = new Size(800, 24);
            mnuprograma.TabIndex = 0;
            mnuprograma.Text = "menuStrip1";
            mnuprograma.ItemClicked += mnuprograma_ItemClicked;
            // 
            // loginToolStripMenuItem
            // 
            loginToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { loginToolStripMenuItem1 });
            loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            loginToolStripMenuItem.Size = new Size(76, 20);
            loginToolStripMenuItem.Text = "Programas";
            loginToolStripMenuItem.Click += loginToolStripMenuItem_Click;
            // 
            // loginToolStripMenuItem1
            // 
            loginToolStripMenuItem1.Name = "loginToolStripMenuItem1";
            loginToolStripMenuItem1.Size = new Size(104, 22);
            loginToolStripMenuItem1.Text = "Login";
            loginToolStripMenuItem1.Click += loginToolStripMenuItem1_Click;
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { deslogarToolStripMenuItem, fecharToolStripMenuItem });
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(38, 20);
            sairToolStripMenuItem.Text = "Sair";
            // 
            // deslogarToolStripMenuItem
            // 
            deslogarToolStripMenuItem.Name = "deslogarToolStripMenuItem";
            deslogarToolStripMenuItem.Size = new Size(180, 22);
            deslogarToolStripMenuItem.Text = "Deslogar";
            deslogarToolStripMenuItem.Click += deslogarToolStripMenuItem_Click;
            // 
            // fecharToolStripMenuItem
            // 
            fecharToolStripMenuItem.Name = "fecharToolStripMenuItem";
            fecharToolStripMenuItem.Size = new Size(180, 22);
            fecharToolStripMenuItem.Text = "Fechar";
            fecharToolStripMenuItem.Click += fecharToolStripMenuItem_Click;
            // 
            // frmmenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(mnuprograma);
            MainMenuStrip = mnuprograma;
            Name = "frmmenu";
            Text = "Menu";
            mnuprograma.ResumeLayout(false);
            mnuprograma.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mnuprograma;
        private ToolStripMenuItem loginToolStripMenuItem;
        private ToolStripMenuItem loginToolStripMenuItem1;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem deslogarToolStripMenuItem;
        private ToolStripMenuItem fecharToolStripMenuItem;
    }
}