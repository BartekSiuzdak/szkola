namespace zadanie
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.mySqlConnection1 = new MySqlConnector.MySqlConnection();
            this.mySqlCommand1 = new MySqlConnector.MySqlCommand();
            this.login = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.connect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label_login = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mySqlConnection1
            // 
            this.mySqlConnection1.ConnectionString = "server=localhost;uid=root;pwd=;database=baza";
            this.mySqlConnection1.ProvideClientCertificatesCallback = null;
            this.mySqlConnection1.ProvidePasswordCallback = null;
            this.mySqlConnection1.RemoteCertificateValidationCallback = null;
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CommandText = "SELECT * FROM `userdata` WHERE login=@login AND password = @password";
            this.mySqlCommand1.CommandTimeout = 30;
            this.mySqlCommand1.Connection = this.mySqlConnection1;
            this.mySqlCommand1.Transaction = null;
            this.mySqlCommand1.UpdatedRowSource = System.Data.UpdateRowSource.None;
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(247, 139);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(276, 20);
            this.login.TabIndex = 0;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(247, 211);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(276, 20);
            this.password.TabIndex = 1;
            // 
            // connect
            // 
            this.connect.Location = new System.Drawing.Point(318, 267);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(142, 32);
            this.connect.TabIndex = 2;
            this.connect.Text = "ZALOGUJ";
            this.connect.UseVisualStyleBackColor = true;
            this.connect.Click += new System.EventHandler(this.connect_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(230, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 68);
            this.label1.TabIndex = 3;
            this.label1.Text = "Zaloguj się do bazy danych";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label_login
            // 
            this.label_login.AutoSize = true;
            this.label_login.Location = new System.Drawing.Point(244, 99);
            this.label_login.Name = "label_login";
            this.label_login.Size = new System.Drawing.Size(29, 13);
            this.label_login.TabIndex = 4;
            this.label_login.Text = "login";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Location = new System.Drawing.Point(247, 177);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(34, 13);
            this.label_password.TabIndex = 5;
            this.label_password.Text = "hasło";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_login);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.connect);
            this.Controls.Add(this.password);
            this.Controls.Add(this.login);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MySqlConnector.MySqlConnection mySqlConnection1;
        private MySqlConnector.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button connect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_login;
        private System.Windows.Forms.Label label_password;
    }
}

