
namespace Aplicación_Caja
{
    partial class FormMenu
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
            this.buttonCliente = new System.Windows.Forms.Button();
            this.buttonEntradaFT = new System.Windows.Forms.Button();
            this.buttonSalidaFT = new System.Windows.Forms.Button();
            this.buttonCierre = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCliente
            // 
            this.buttonCliente.Location = new System.Drawing.Point(296, 94);
            this.buttonCliente.Name = "buttonCliente";
            this.buttonCliente.Size = new System.Drawing.Size(189, 55);
            this.buttonCliente.TabIndex = 0;
            this.buttonCliente.Text = "Validar Cliente";
            this.buttonCliente.UseVisualStyleBackColor = true;
            this.buttonCliente.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonEntradaFT
            // 
            this.buttonEntradaFT.Location = new System.Drawing.Point(296, 155);
            this.buttonEntradaFT.Name = "buttonEntradaFT";
            this.buttonEntradaFT.Size = new System.Drawing.Size(189, 55);
            this.buttonEntradaFT.TabIndex = 1;
            this.buttonEntradaFT.Text = "Entrada de efectivo";
            this.buttonEntradaFT.UseVisualStyleBackColor = true;
            this.buttonEntradaFT.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonSalidaFT
            // 
            this.buttonSalidaFT.Location = new System.Drawing.Point(296, 216);
            this.buttonSalidaFT.Name = "buttonSalidaFT";
            this.buttonSalidaFT.Size = new System.Drawing.Size(189, 55);
            this.buttonSalidaFT.TabIndex = 2;
            this.buttonSalidaFT.Text = "Salida de efectivo";
            this.buttonSalidaFT.UseVisualStyleBackColor = true;
            // 
            // buttonCierre
            // 
            this.buttonCierre.Location = new System.Drawing.Point(296, 277);
            this.buttonCierre.Name = "buttonCierre";
            this.buttonCierre.Size = new System.Drawing.Size(189, 55);
            this.buttonCierre.TabIndex = 3;
            this.buttonCierre.Text = "Cierre";
            this.buttonCierre.UseVisualStyleBackColor = true;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCierre);
            this.Controls.Add(this.buttonSalidaFT);
            this.Controls.Add(this.buttonEntradaFT);
            this.Controls.Add(this.buttonCliente);
            this.Name = "FormMenu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCliente;
        private System.Windows.Forms.Button buttonEntradaFT;
        private System.Windows.Forms.Button buttonSalidaFT;
        private System.Windows.Forms.Button buttonCierre;
    }
}