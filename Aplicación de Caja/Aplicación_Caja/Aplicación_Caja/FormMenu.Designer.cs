﻿
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
            this.buttonCierre = new System.Windows.Forms.Button();
            this.salidaFT = new System.Windows.Forms.Button();
            this.entradaFT = new System.Windows.Forms.Button();
            this.labelAdmin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCliente
            // 
            this.buttonCliente.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonCliente.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonCliente.Location = new System.Drawing.Point(148, 174);
            this.buttonCliente.Name = "buttonCliente";
            this.buttonCliente.Size = new System.Drawing.Size(189, 55);
            this.buttonCliente.TabIndex = 0;
            this.buttonCliente.Text = "Validar Cliente";
            this.buttonCliente.UseVisualStyleBackColor = false;
            this.buttonCliente.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonCierre
            // 
            this.buttonCierre.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonCierre.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCierre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonCierre.Location = new System.Drawing.Point(148, 265);
            this.buttonCierre.Name = "buttonCierre";
            this.buttonCierre.Size = new System.Drawing.Size(189, 55);
            this.buttonCierre.TabIndex = 3;
            this.buttonCierre.Text = "Cierre";
            this.buttonCierre.UseVisualStyleBackColor = false;
            this.buttonCierre.Click += new System.EventHandler(this.buttonCierre_Click);
            // 
            // salidaFT
            // 
            this.salidaFT.BackColor = System.Drawing.Color.LimeGreen;
            this.salidaFT.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salidaFT.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.salidaFT.Location = new System.Drawing.Point(432, 265);
            this.salidaFT.Name = "salidaFT";
            this.salidaFT.Size = new System.Drawing.Size(189, 55);
            this.salidaFT.TabIndex = 5;
            this.salidaFT.Text = "Salida de Efectivo";
            this.salidaFT.UseVisualStyleBackColor = false;
            // 
            // entradaFT
            // 
            this.entradaFT.BackColor = System.Drawing.Color.LimeGreen;
            this.entradaFT.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entradaFT.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.entradaFT.Location = new System.Drawing.Point(432, 174);
            this.entradaFT.Name = "entradaFT";
            this.entradaFT.Size = new System.Drawing.Size(189, 55);
            this.entradaFT.TabIndex = 4;
            this.entradaFT.Text = "Entrada de Efectivo";
            this.entradaFT.UseVisualStyleBackColor = false;
            // 
            // labelAdmin
            // 
            this.labelAdmin.AutoSize = true;
            this.labelAdmin.Font = new System.Drawing.Font("Arial Unicode MS", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdmin.ForeColor = System.Drawing.Color.LimeGreen;
            this.labelAdmin.Location = new System.Drawing.Point(220, 76);
            this.labelAdmin.Name = "labelAdmin";
            this.labelAdmin.Size = new System.Drawing.Size(350, 50);
            this.labelAdmin.TabIndex = 13;
            this.labelAdmin.Text = "ADMINISTRADOR";
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelAdmin);
            this.Controls.Add(this.salidaFT);
            this.Controls.Add(this.entradaFT);
            this.Controls.Add(this.buttonCierre);
            this.Controls.Add(this.buttonCliente);
            this.Name = "FormMenu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCliente;
        private System.Windows.Forms.Button buttonCierre;
        private System.Windows.Forms.Button salidaFT;
        private System.Windows.Forms.Button entradaFT;
        private System.Windows.Forms.Label labelAdmin;
    }
}