
namespace Aplicación_Caja
{
    partial class FormLoginClientes
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelTituloClientes = new System.Windows.Forms.Label();
            this.buttonLoginClient = new System.Windows.Forms.Button();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(315, 194);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(194, 24);
            this.textBox1.TabIndex = 20;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelTituloClientes
            // 
            this.labelTituloClientes.AutoSize = true;
            this.labelTituloClientes.Font = new System.Drawing.Font("Arial Unicode MS", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTituloClientes.ForeColor = System.Drawing.Color.LimeGreen;
            this.labelTituloClientes.Location = new System.Drawing.Point(204, 100);
            this.labelTituloClientes.Name = "labelTituloClientes";
            this.labelTituloClientes.Size = new System.Drawing.Size(367, 50);
            this.labelTituloClientes.TabIndex = 19;
            this.labelTituloClientes.Text = "VALIDAR CLIENTE";
            // 
            // buttonLoginClient
            // 
            this.buttonLoginClient.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonLoginClient.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoginClient.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonLoginClient.Location = new System.Drawing.Point(300, 259);
            this.buttonLoginClient.Name = "buttonLoginClient";
            this.buttonLoginClient.Size = new System.Drawing.Size(194, 63);
            this.buttonLoginClient.TabIndex = 18;
            this.buttonLoginClient.Text = "Ingresar";
            this.buttonLoginClient.UseVisualStyleBackColor = false;
            this.buttonLoginClient.Click += new System.EventHandler(this.buttonLoginClient_Click);
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuario.Location = new System.Drawing.Point(255, 196);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(54, 18);
            this.labelUsuario.TabIndex = 15;
            this.labelUsuario.Text = "Cédula";
            // 
            // FormLoginClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelTituloClientes);
            this.Controls.Add(this.buttonLoginClient);
            this.Controls.Add(this.labelUsuario);
            this.Name = "FormLoginClientes";
            this.Text = "Login de Clientes";
            this.Load += new System.EventHandler(this.FormLoginClientes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelTituloClientes;
        private System.Windows.Forms.Button buttonLoginClient;
        private System.Windows.Forms.Label labelUsuario;
    }
}