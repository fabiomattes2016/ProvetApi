namespace Provet.Presentation.UI
{
    partial class frmSobre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSobre));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnLogin = new Button();
            label6 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.stethoscope;
            pictureBox1.Location = new Point(12, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(172, 156);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("JetBrains Mono SemiBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(190, 13);
            label1.Name = "label1";
            label1.Size = new Size(532, 27);
            label1.TabIndex = 1;
            label1.Text = "ProVET - Gestão de Clínicas Veterinárias";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(190, 42);
            label2.Name = "label2";
            label2.Size = new Size(91, 16);
            label2.TabIndex = 2;
            label2.Text = "Versão: 1.0b";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(190, 58);
            label3.Name = "label3";
            label3.Size = new Size(287, 16);
            label3.TabIndex = 3;
            label3.Text = "Desenvolvido e mantido por: Fábio Mattes";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(190, 74);
            label4.Name = "label4";
            label4.Size = new Size(238, 16);
            label4.TabIndex = 4;
            label4.Text = "E-mail: fabiomattes2007@gmail.com";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(190, 90);
            label5.Name = "label5";
            label5.Size = new Size(245, 16);
            label5.TabIndex = 5;
            label5.Text = "Telefone/Whatsapp: (43) 99930-2633";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(64, 64, 64);
            btnLogin.ForeColor = SystemColors.Control;
            btnLogin.Location = new Point(633, 157);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(93, 32);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Fechar";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("JetBrains Mono SemiBold", 8.999999F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(190, 117);
            label6.Name = "label6";
            label6.Size = new Size(245, 16);
            label6.TabIndex = 7;
            label6.Text = "Licenciado para: Empresa de Testes";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("JetBrains Mono SemiBold", 8.999999F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(190, 133);
            label7.Name = "label7";
            label7.Size = new Size(217, 16);
            label7.TabIndex = 8;
            label7.Text = "Licença válida até: 10/01/2025";
            // 
            // frmSobre
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(738, 198);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(btnLogin);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Font = new Font("JetBrains Mono", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmSobre";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sobre o Sistema";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnLogin;
        private Label label6;
        private Label label7;
    }
}