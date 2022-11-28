namespace DEINT_Ej10_Jardineria
{
    partial class FormGama
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
            this.label8 = new System.Windows.Forms.Label();
            this.cbGama = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescrTexto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescrHtml = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtImagen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(373, 29);
            this.label8.TabIndex = 16;
            this.label8.Text = "GAMA";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbGama
            // 
            this.cbGama.FormattingEnabled = true;
            this.cbGama.Location = new System.Drawing.Point(106, 41);
            this.cbGama.Name = "cbGama";
            this.cbGama.Size = new System.Drawing.Size(279, 21);
            this.cbGama.TabIndex = 18;
            this.cbGama.SelectedIndexChanged += new System.EventHandler(this.cbGama_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Gama";
            // 
            // txtDescrTexto
            // 
            this.txtDescrTexto.Enabled = false;
            this.txtDescrTexto.Location = new System.Drawing.Point(106, 68);
            this.txtDescrTexto.Name = "txtDescrTexto";
            this.txtDescrTexto.Size = new System.Drawing.Size(279, 20);
            this.txtDescrTexto.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Descripcion texto";
            // 
            // txtDescrHtml
            // 
            this.txtDescrHtml.Enabled = false;
            this.txtDescrHtml.Location = new System.Drawing.Point(106, 94);
            this.txtDescrHtml.Name = "txtDescrHtml";
            this.txtDescrHtml.Size = new System.Drawing.Size(279, 20);
            this.txtDescrHtml.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Descripcion html";
            // 
            // txtImagen
            // 
            this.txtImagen.Enabled = false;
            this.txtImagen.Location = new System.Drawing.Point(106, 120);
            this.txtImagen.Name = "txtImagen";
            this.txtImagen.Size = new System.Drawing.Size(279, 20);
            this.txtImagen.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Imagen";
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(310, 146);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 27;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // FormGama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 181);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.txtImagen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDescrHtml);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDescrTexto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbGama);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Name = "FormGama";
            this.Text = "FormGama";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbGama;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescrTexto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescrHtml;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtImagen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBorrar;
    }
}