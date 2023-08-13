
namespace VirtuaConecta.Outbound.AI.Configuracoes
{
    partial class Form_Imprimir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Imprimir));
            this.TxtNrTicket = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // TxtNrTicket
            // 
            this.TxtNrTicket.Depth = 0;
            this.TxtNrTicket.Hint = "";
            this.TxtNrTicket.Location = new System.Drawing.Point(238, 149);
            this.TxtNrTicket.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtNrTicket.Name = "TxtNrTicket";
            this.TxtNrTicket.PasswordChar = '\0';
            this.TxtNrTicket.SelectedText = "";
            this.TxtNrTicket.SelectionLength = 0;
            this.TxtNrTicket.SelectionStart = 0;
            this.TxtNrTicket.Size = new System.Drawing.Size(310, 28);
            this.TxtNrTicket.TabIndex = 0;
            this.TxtNrTicket.TabStop = false;
            this.TxtNrTicket.UseSystemPasswordChar = false;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirmar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConfirmar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConfirmar.BackgroundImage")));
            this.btnConfirmar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnConfirmar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConfirmar.FlatAppearance.BorderSize = 0;
            this.btnConfirmar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConfirmar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Location = new System.Drawing.Point(497, 332);
            this.btnConfirmar.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(134, 95);
            this.btnConfirmar.TabIndex = 38;
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSair.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSair.BackgroundImage")));
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Location = new System.Drawing.Point(653, 332);
            this.btnSair.Margin = new System.Windows.Forms.Padding(4);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(134, 95);
            this.btnSair.TabIndex = 37;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.Teal;
            this.materialLabel1.Location = new System.Drawing.Point(42, 149);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(114, 24);
            this.materialLabel1.TabIndex = 39;
            this.materialLabel1.Text = "Nr do Ticket";
            // 
            // Form_Imprimir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.TxtNrTicket);
            this.Name = "Form_Imprimir";
            this.Text = "Teste de impressão";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField TxtNrTicket;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnSair;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}