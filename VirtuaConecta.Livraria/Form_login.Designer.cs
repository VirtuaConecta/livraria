namespace VirtuaConecta.Outbound.AI
{
    partial class Form_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLogar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.placeholderTextBox2 = new System.Windows.Forms.PlaceholderTextBox();
            this.placeholderTextBox1 = new System.Windows.Forms.PlaceholderTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(29, 36);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(507, 689);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnLogar
            // 
            this.btnLogar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogar.Location = new System.Drawing.Point(684, 513);
            this.btnLogar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogar.Name = "btnLogar";
            this.btnLogar.Size = new System.Drawing.Size(517, 39);
            this.btnLogar.TabIndex = 4;
            this.btnLogar.Text = "Logar no sistema";
            this.btnLogar.UseVisualStyleBackColor = true;
            this.btnLogar.Click += new System.EventHandler(this.btnLogar_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.White;
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.ForeColor = System.Drawing.Color.Transparent;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.Location = new System.Drawing.Point(1236, 14);
            this.btnSair.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(45, 46);
            this.btnSair.TabIndex = 5;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // placeholderTextBox2
            // 
            this.placeholderTextBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.placeholderTextBox2.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeholderTextBox2.Location = new System.Drawing.Point(684, 345);
            this.placeholderTextBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.placeholderTextBox2.Name = "placeholderTextBox2";
            this.placeholderTextBox2.PlaceholderText = "Senha";
            this.placeholderTextBox2.Size = new System.Drawing.Size(519, 34);
            this.placeholderTextBox2.TabIndex = 3;
            this.placeholderTextBox2.UseSystemPasswordChar = true;
            // 
            // placeholderTextBox1
            // 
            this.placeholderTextBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.placeholderTextBox1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeholderTextBox1.Location = new System.Drawing.Point(684, 192);
            this.placeholderTextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.placeholderTextBox1.Name = "placeholderTextBox1";
            this.placeholderTextBox1.PlaceholderText = "Login";
            this.placeholderTextBox1.Size = new System.Drawing.Size(519, 34);
            this.placeholderTextBox1.TabIndex = 2;
            // 
            // Form_login
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1311, 775);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLogar);
            this.Controls.Add(this.placeholderTextBox2);
            this.Controls.Add(this.placeholderTextBox1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_login";
            this.Load += new System.EventHandler(this.Form_login_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_login_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PlaceholderTextBox placeholderTextBox1;
        private System.Windows.Forms.PlaceholderTextBox placeholderTextBox2;
        private System.Windows.Forms.Button btnLogar;
        private System.Windows.Forms.Button btnSair;
    }
}