using System;
using System.Windows.Forms;

namespace Calculadorastack
{
    partial class Form1
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
            this.B7 = new System.Windows.Forms.Button();
            this.B8 = new System.Windows.Forms.Button();
            this.B9 = new System.Windows.Forms.Button();
            this.B4 = new System.Windows.Forms.Button();
            this.B5 = new System.Windows.Forms.Button();
            this.B6 = new System.Windows.Forms.Button();
            this.B1 = new System.Windows.Forms.Button();
            this.B2 = new System.Windows.Forms.Button();
            this.B3 = new System.Windows.Forms.Button();
            this.Bmas = new System.Windows.Forms.Button();
            this.B0 = new System.Windows.Forms.Button();
            this.Bpor = new System.Windows.Forms.Button();
            this.bmenos = new System.Windows.Forms.Button();
            this.Breciduo = new System.Windows.Forms.Button();
            this.Bdivicion = new System.Windows.Forms.Button();
            this.Bigual = new System.Windows.Forms.Button();
            this.txtdatos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtprocedimiento = new System.Windows.Forms.TextBox();
            this.Bborra1 = new System.Windows.Forms.Button();
            this.Btodo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // B7
            // 
            this.B7.Font = new System.Drawing.Font("OCR A Extended", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B7.Location = new System.Drawing.Point(24, 21);
            this.B7.Name = "B7";
            this.B7.Size = new System.Drawing.Size(43, 37);
            this.B7.TabIndex = 0;
            this.B7.Text = "7";
            this.B7.UseVisualStyleBackColor = true;
            this.B7.Click += new System.EventHandler(this.B7_Click);
            // 
            // B8
            // 
            this.B8.Font = new System.Drawing.Font("OCR A Extended", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B8.Location = new System.Drawing.Point(73, 21);
            this.B8.Name = "B8";
            this.B8.Size = new System.Drawing.Size(43, 37);
            this.B8.TabIndex = 1;
            this.B8.Text = "8";
            this.B8.UseVisualStyleBackColor = true;
            this.B8.Click += new System.EventHandler(this.B8_Click);
            // 
            // B9
            // 
            this.B9.Font = new System.Drawing.Font("OCR A Extended", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B9.Location = new System.Drawing.Point(122, 21);
            this.B9.Name = "B9";
            this.B9.Size = new System.Drawing.Size(43, 37);
            this.B9.TabIndex = 2;
            this.B9.Text = "9";
            this.B9.UseVisualStyleBackColor = true;
            this.B9.Click += new System.EventHandler(this.B9_Click);
            // 
            // B4
            // 
            this.B4.Font = new System.Drawing.Font("OCR A Extended", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B4.Location = new System.Drawing.Point(24, 64);
            this.B4.Name = "B4";
            this.B4.Size = new System.Drawing.Size(43, 37);
            this.B4.TabIndex = 3;
            this.B4.Text = "4";
            this.B4.UseVisualStyleBackColor = true;
            this.B4.Click += new System.EventHandler(this.B4_Click);
            // 
            // B5
            // 
            this.B5.Font = new System.Drawing.Font("OCR A Extended", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B5.Location = new System.Drawing.Point(73, 64);
            this.B5.Name = "B5";
            this.B5.Size = new System.Drawing.Size(43, 37);
            this.B5.TabIndex = 4;
            this.B5.Text = "5";
            this.B5.UseVisualStyleBackColor = true;
            this.B5.Click += new System.EventHandler(this.B5_Click);
            // 
            // B6
            // 
            this.B6.Font = new System.Drawing.Font("OCR A Extended", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B6.Location = new System.Drawing.Point(122, 64);
            this.B6.Name = "B6";
            this.B6.Size = new System.Drawing.Size(43, 37);
            this.B6.TabIndex = 5;
            this.B6.Text = "6";
            this.B6.UseVisualStyleBackColor = true;
            this.B6.Click += new System.EventHandler(this.B6_Click);
            // 
            // B1
            // 
            this.B1.Font = new System.Drawing.Font("OCR A Extended", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B1.Location = new System.Drawing.Point(24, 107);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(43, 37);
            this.B1.TabIndex = 6;
            this.B1.Text = "1";
            this.B1.UseVisualStyleBackColor = true;
            this.B1.Click += new System.EventHandler(this.B1_Click);
            // 
            // B2
            // 
            this.B2.Font = new System.Drawing.Font("OCR A Extended", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B2.Location = new System.Drawing.Point(73, 107);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(43, 37);
            this.B2.TabIndex = 7;
            this.B2.Text = "2";
            this.B2.UseVisualStyleBackColor = true;
            this.B2.Click += new System.EventHandler(this.B2_Click);
            // 
            // B3
            // 
            this.B3.Font = new System.Drawing.Font("OCR A Extended", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B3.Location = new System.Drawing.Point(122, 107);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(43, 37);
            this.B3.TabIndex = 8;
            this.B3.Text = "3";
            this.B3.UseVisualStyleBackColor = true;
            this.B3.Click += new System.EventHandler(this.B3_Click);
            // 
            // Bmas
            // 
            this.Bmas.Font = new System.Drawing.Font("OCR A Extended", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bmas.Location = new System.Drawing.Point(24, 150);
            this.Bmas.Name = "Bmas";
            this.Bmas.Size = new System.Drawing.Size(43, 37);
            this.Bmas.TabIndex = 9;
            this.Bmas.Text = "+";
            this.Bmas.UseVisualStyleBackColor = true;
            this.Bmas.Click += new System.EventHandler(this.Bmas_Click);
            // 
            // B0
            // 
            this.B0.Font = new System.Drawing.Font("OCR A Extended", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B0.Location = new System.Drawing.Point(73, 150);
            this.B0.Name = "B0";
            this.B0.Size = new System.Drawing.Size(43, 37);
            this.B0.TabIndex = 10;
            this.B0.Text = "0";
            this.B0.UseVisualStyleBackColor = true;
            this.B0.Click += new System.EventHandler(this.B0_Click);
            // 
            // Bpor
            // 
            this.Bpor.Font = new System.Drawing.Font("OCR A Extended", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bpor.Location = new System.Drawing.Point(122, 150);
            this.Bpor.Name = "Bpor";
            this.Bpor.Size = new System.Drawing.Size(43, 37);
            this.Bpor.TabIndex = 11;
            this.Bpor.Text = "*";
            this.Bpor.UseVisualStyleBackColor = true;
            this.Bpor.Click += new System.EventHandler(this.Bpor_Click);
            // 
            // bmenos
            // 
            this.bmenos.Font = new System.Drawing.Font("OCR A Extended", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bmenos.Location = new System.Drawing.Point(24, 193);
            this.bmenos.Name = "bmenos";
            this.bmenos.Size = new System.Drawing.Size(43, 37);
            this.bmenos.TabIndex = 12;
            this.bmenos.Text = "-";
            this.bmenos.UseVisualStyleBackColor = true;
            this.bmenos.Click += new System.EventHandler(this.bmenos_Click);
            // 
            // Breciduo
            // 
            this.Breciduo.Font = new System.Drawing.Font("OCR A Extended", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Breciduo.Location = new System.Drawing.Point(73, 193);
            this.Breciduo.Name = "Breciduo";
            this.Breciduo.Size = new System.Drawing.Size(43, 37);
            this.Breciduo.TabIndex = 13;
            this.Breciduo.Text = "%";
            this.Breciduo.UseVisualStyleBackColor = true;
            this.Breciduo.Click += new System.EventHandler(this.Breciduo_Click);
            // 
            // Bdivicion
            // 
            this.Bdivicion.Font = new System.Drawing.Font("OCR A Extended", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bdivicion.Location = new System.Drawing.Point(122, 193);
            this.Bdivicion.Name = "Bdivicion";
            this.Bdivicion.Size = new System.Drawing.Size(43, 37);
            this.Bdivicion.TabIndex = 14;
            this.Bdivicion.Text = "/";
            this.Bdivicion.UseVisualStyleBackColor = true;
            this.Bdivicion.Click += new System.EventHandler(this.Bdivicion_Click);
            // 
            // Bigual
            // 
            this.Bigual.Font = new System.Drawing.Font("OCR A Extended", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bigual.Location = new System.Drawing.Point(24, 236);
            this.Bigual.Name = "Bigual";
            this.Bigual.Size = new System.Drawing.Size(43, 37);
            this.Bigual.TabIndex = 15;
            this.Bigual.Text = "=";
            this.Bigual.UseVisualStyleBackColor = true;
            this.Bigual.Click += new System.EventHandler(this.Bigual_Click);
            // 
            // txtdatos
            // 
            this.txtdatos.Location = new System.Drawing.Point(171, 21);
            this.txtdatos.Multiline = true;
            this.txtdatos.Name = "txtdatos";
            this.txtdatos.Size = new System.Drawing.Size(253, 37);
            this.txtdatos.TabIndex = 16;
            this.txtdatos.TextChanged += new System.EventHandler(this.txtdatos_TextChanged);
            this.txtdatos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdatos_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("OCR A Extended", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(195, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Procedimiento";
            // 
            // txtprocedimiento
            // 
            this.txtprocedimiento.Location = new System.Drawing.Point(171, 125);
            this.txtprocedimiento.Multiline = true;
            this.txtprocedimiento.Name = "txtprocedimiento";
            this.txtprocedimiento.Size = new System.Drawing.Size(253, 148);
            this.txtprocedimiento.TabIndex = 18;
            this.txtprocedimiento.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Bborra1
            // 
            this.Bborra1.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bborra1.Location = new System.Drawing.Point(73, 236);
            this.Bborra1.Name = "Bborra1";
            this.Bborra1.Size = new System.Drawing.Size(43, 37);
            this.Bborra1.TabIndex = 20;
            this.Bborra1.Text = "CE";
            this.Bborra1.UseVisualStyleBackColor = true;
            this.Bborra1.Click += new System.EventHandler(this.Bborra1_Click);
            // 
            // Btodo
            // 
            this.Btodo.Font = new System.Drawing.Font("OCR A Extended", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btodo.Location = new System.Drawing.Point(122, 236);
            this.Btodo.Name = "Btodo";
            this.Btodo.Size = new System.Drawing.Size(43, 37);
            this.Btodo.TabIndex = 21;
            this.Btodo.Text = "x";
            this.Btodo.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(445, 296);
            this.Controls.Add(this.Btodo);
            this.Controls.Add(this.Bborra1);
            this.Controls.Add(this.txtprocedimiento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtdatos);
            this.Controls.Add(this.Bigual);
            this.Controls.Add(this.Bdivicion);
            this.Controls.Add(this.Breciduo);
            this.Controls.Add(this.bmenos);
            this.Controls.Add(this.Bpor);
            this.Controls.Add(this.B0);
            this.Controls.Add(this.Bmas);
            this.Controls.Add(this.B3);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.B6);
            this.Controls.Add(this.B5);
            this.Controls.Add(this.B4);
            this.Controls.Add(this.B9);
            this.Controls.Add(this.B8);
            this.Controls.Add(this.B7);
            this.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.MaximumSize = new System.Drawing.Size(461, 335);
            this.MinimumSize = new System.Drawing.Size(461, 335);
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Bborra1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Bmenos_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BDivicion_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BReciduo_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BPor_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void B00_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BMas_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void B03_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void B02_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void B01_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void txtdatos_KeyPress(object sender, KeyPressEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button B7;
        private System.Windows.Forms.Button B8;
        private System.Windows.Forms.Button B9;
        private System.Windows.Forms.Button B4;
        private System.Windows.Forms.Button B5;
        private System.Windows.Forms.Button B6;
        private System.Windows.Forms.Button B1;
        private System.Windows.Forms.Button B2;
        private System.Windows.Forms.Button B3;
        private System.Windows.Forms.Button Bmas;
        private System.Windows.Forms.Button B0;
        private System.Windows.Forms.Button Bpor;
        private System.Windows.Forms.Button bmenos;
        private System.Windows.Forms.Button Breciduo;
        private System.Windows.Forms.Button Bdivicion;
        private System.Windows.Forms.Button Bigual;
        private System.Windows.Forms.TextBox txtdatos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtprocedimiento;
        private System.Windows.Forms.Button Bborra1;
        private System.Windows.Forms.Button Btodo;
    }
}

