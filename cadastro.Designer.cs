
namespace FutureJob
{
    partial class cadastro
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
            this.btnAcessar = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAcessar
            // 
            this.btnAcessar.BackColor = System.Drawing.Color.Transparent;
            this.btnAcessar.FlatAppearance.BorderSize = 0;
            this.btnAcessar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcessar.ForeColor = System.Drawing.Color.Transparent;
            this.btnAcessar.Location = new System.Drawing.Point(69, 546);
            this.btnAcessar.Name = "btnAcessar";
            this.btnAcessar.Size = new System.Drawing.Size(148, 37);
            this.btnAcessar.TabIndex = 2;
            this.btnAcessar.UseVisualStyleBackColor = true;
            this.btnAcessar.Click += new System.EventHandler(this.btnAcessar_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.ForeColor = System.Drawing.Color.Transparent;
            this.btnLogin.Location = new System.Drawing.Point(12, 28);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(61, 21);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FutureJob.Properties.Resources.Design_sem_nome__2_;
            this.ClientSize = new System.Drawing.Size(286, 607);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnAcessar);
            this.Name = "cadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "cadastro";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAcessar;
        private System.Windows.Forms.Button btnLogin;
    }
}