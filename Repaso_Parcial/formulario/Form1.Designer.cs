﻿namespace formulario
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPunto1 = new System.Windows.Forms.Button();
            this.btnPunto2 = new System.Windows.Forms.Button();
            this.btnPunto3 = new System.Windows.Forms.Button();
            this.btnPunto4 = new System.Windows.Forms.Button();
            this.btnPunto5 = new System.Windows.Forms.Button();
            this.rtbTextoSalida = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnPunto1
            // 
            this.btnPunto1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnPunto1.Location = new System.Drawing.Point(47, 36);
            this.btnPunto1.Name = "btnPunto1";
            this.btnPunto1.Size = new System.Drawing.Size(142, 53);
            this.btnPunto1.TabIndex = 0;
            this.btnPunto1.Text = "Punto 1";
            this.btnPunto1.UseVisualStyleBackColor = true;
            this.btnPunto1.Click += new System.EventHandler(this.btnPunto1_Click);
            // 
            // btnPunto2
            // 
            this.btnPunto2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnPunto2.Location = new System.Drawing.Point(47, 95);
            this.btnPunto2.Name = "btnPunto2";
            this.btnPunto2.Size = new System.Drawing.Size(142, 53);
            this.btnPunto2.TabIndex = 1;
            this.btnPunto2.Text = "Punto 2";
            this.btnPunto2.UseVisualStyleBackColor = true;
            this.btnPunto2.Click += new System.EventHandler(this.btnPunto2_Click);
            // 
            // btnPunto3
            // 
            this.btnPunto3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnPunto3.Location = new System.Drawing.Point(47, 154);
            this.btnPunto3.Name = "btnPunto3";
            this.btnPunto3.Size = new System.Drawing.Size(142, 53);
            this.btnPunto3.TabIndex = 2;
            this.btnPunto3.Text = "Punto 3";
            this.btnPunto3.UseVisualStyleBackColor = true;
            this.btnPunto3.Click += new System.EventHandler(this.btnPunto3_Click);
            // 
            // btnPunto4
            // 
            this.btnPunto4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnPunto4.Location = new System.Drawing.Point(47, 213);
            this.btnPunto4.Name = "btnPunto4";
            this.btnPunto4.Size = new System.Drawing.Size(142, 53);
            this.btnPunto4.TabIndex = 3;
            this.btnPunto4.Text = "Punto 4";
            this.btnPunto4.UseVisualStyleBackColor = true;
            this.btnPunto4.Click += new System.EventHandler(this.btnPunto4_Click);
            // 
            // btnPunto5
            // 
            this.btnPunto5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnPunto5.Location = new System.Drawing.Point(47, 272);
            this.btnPunto5.Name = "btnPunto5";
            this.btnPunto5.Size = new System.Drawing.Size(142, 53);
            this.btnPunto5.TabIndex = 4;
            this.btnPunto5.Text = "Punto 5";
            this.btnPunto5.UseVisualStyleBackColor = true;
            this.btnPunto5.Click += new System.EventHandler(this.btnPunto5_Click);
            // 
            // rtbTextoSalida
            // 
            this.rtbTextoSalida.Location = new System.Drawing.Point(231, 36);
            this.rtbTextoSalida.Name = "rtbTextoSalida";
            this.rtbTextoSalida.Size = new System.Drawing.Size(364, 300);
            this.rtbTextoSalida.TabIndex = 5;
            this.rtbTextoSalida.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 348);
            this.Controls.Add(this.rtbTextoSalida);
            this.Controls.Add(this.btnPunto5);
            this.Controls.Add(this.btnPunto4);
            this.Controls.Add(this.btnPunto3);
            this.Controls.Add(this.btnPunto2);
            this.Controls.Add(this.btnPunto1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPunto1;
        private System.Windows.Forms.Button btnPunto2;
        private System.Windows.Forms.Button btnPunto3;
        private System.Windows.Forms.Button btnPunto4;
        private System.Windows.Forms.Button btnPunto5;
        private System.Windows.Forms.RichTextBox rtbTextoSalida;
    }
}

