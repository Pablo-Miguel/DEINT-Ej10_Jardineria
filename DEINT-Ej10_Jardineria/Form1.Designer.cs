namespace DEINT_Ej10_Jardineria
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAnadirProducto = new System.Windows.Forms.Button();
            this.btnEliminarGama = new System.Windows.Forms.Button();
            this.btnPedidosEntregados = new System.Windows.Forms.Button();
            this.btnPrecioMasCaroBarato = new System.Windows.Forms.Button();
            this.btnClientesQueNoPagan = new System.Windows.Forms.Button();
            this.btnEmpleadosDeUnJefe = new System.Windows.Forms.Button();
            this.dgJardineria = new System.Windows.Forms.DataGridView();
            this.btnMostrarProd = new System.Windows.Forms.Button();
            this.btnGama = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgJardineria)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAnadirProducto
            // 
            this.btnAnadirProducto.Location = new System.Drawing.Point(12, 12);
            this.btnAnadirProducto.Name = "btnAnadirProducto";
            this.btnAnadirProducto.Size = new System.Drawing.Size(125, 57);
            this.btnAnadirProducto.TabIndex = 0;
            this.btnAnadirProducto.Text = "Añadir producto";
            this.btnAnadirProducto.UseVisualStyleBackColor = true;
            this.btnAnadirProducto.Click += new System.EventHandler(this.btnAnadirProducto_Click);
            // 
            // btnEliminarGama
            // 
            this.btnEliminarGama.Location = new System.Drawing.Point(12, 89);
            this.btnEliminarGama.Name = "btnEliminarGama";
            this.btnEliminarGama.Size = new System.Drawing.Size(125, 57);
            this.btnEliminarGama.TabIndex = 1;
            this.btnEliminarGama.Text = "Eliminar gama";
            this.btnEliminarGama.UseVisualStyleBackColor = true;
            this.btnEliminarGama.Click += new System.EventHandler(this.btnEliminarGama_Click);
            // 
            // btnPedidosEntregados
            // 
            this.btnPedidosEntregados.Location = new System.Drawing.Point(12, 168);
            this.btnPedidosEntregados.Name = "btnPedidosEntregados";
            this.btnPedidosEntregados.Size = new System.Drawing.Size(208, 57);
            this.btnPedidosEntregados.TabIndex = 2;
            this.btnPedidosEntregados.Text = "Consultar pedidos entregados";
            this.btnPedidosEntregados.UseVisualStyleBackColor = true;
            this.btnPedidosEntregados.Click += new System.EventHandler(this.btnPedidosEntregados_Click);
            // 
            // btnPrecioMasCaroBarato
            // 
            this.btnPrecioMasCaroBarato.Location = new System.Drawing.Point(12, 402);
            this.btnPrecioMasCaroBarato.Name = "btnPrecioMasCaroBarato";
            this.btnPrecioMasCaroBarato.Size = new System.Drawing.Size(208, 57);
            this.btnPrecioMasCaroBarato.TabIndex = 5;
            this.btnPrecioMasCaroBarato.Text = "Consultar el precio del producto más caro y más barato";
            this.btnPrecioMasCaroBarato.UseVisualStyleBackColor = true;
            this.btnPrecioMasCaroBarato.Click += new System.EventHandler(this.btnPrecioMasCaroBarato_Click);
            // 
            // btnClientesQueNoPagan
            // 
            this.btnClientesQueNoPagan.Location = new System.Drawing.Point(12, 323);
            this.btnClientesQueNoPagan.Name = "btnClientesQueNoPagan";
            this.btnClientesQueNoPagan.Size = new System.Drawing.Size(208, 57);
            this.btnClientesQueNoPagan.TabIndex = 4;
            this.btnClientesQueNoPagan.Text = "Consultar clientes que no pagan";
            this.btnClientesQueNoPagan.UseVisualStyleBackColor = true;
            this.btnClientesQueNoPagan.Click += new System.EventHandler(this.btnClientesQueNoPagan_Click);
            // 
            // btnEmpleadosDeUnJefe
            // 
            this.btnEmpleadosDeUnJefe.Location = new System.Drawing.Point(12, 246);
            this.btnEmpleadosDeUnJefe.Name = "btnEmpleadosDeUnJefe";
            this.btnEmpleadosDeUnJefe.Size = new System.Drawing.Size(208, 57);
            this.btnEmpleadosDeUnJefe.TabIndex = 3;
            this.btnEmpleadosDeUnJefe.Text = "Consultar empleados de un jefe determinado";
            this.btnEmpleadosDeUnJefe.UseVisualStyleBackColor = true;
            this.btnEmpleadosDeUnJefe.Click += new System.EventHandler(this.btnEmpleadosDeUnJefe_Click);
            // 
            // dgJardineria
            // 
            this.dgJardineria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgJardineria.Location = new System.Drawing.Point(226, 12);
            this.dgJardineria.Name = "dgJardineria";
            this.dgJardineria.Size = new System.Drawing.Size(640, 449);
            this.dgJardineria.TabIndex = 6;
            // 
            // btnMostrarProd
            // 
            this.btnMostrarProd.Location = new System.Drawing.Point(143, 12);
            this.btnMostrarProd.Name = "btnMostrarProd";
            this.btnMostrarProd.Size = new System.Drawing.Size(77, 57);
            this.btnMostrarProd.TabIndex = 7;
            this.btnMostrarProd.Text = "Mostrar productos";
            this.btnMostrarProd.UseVisualStyleBackColor = true;
            this.btnMostrarProd.Click += new System.EventHandler(this.btnMostrarProd_Click);
            // 
            // btnGama
            // 
            this.btnGama.Location = new System.Drawing.Point(143, 89);
            this.btnGama.Name = "btnGama";
            this.btnGama.Size = new System.Drawing.Size(77, 57);
            this.btnGama.TabIndex = 8;
            this.btnGama.Text = "Mostrar gamas";
            this.btnGama.UseVisualStyleBackColor = true;
            this.btnGama.Click += new System.EventHandler(this.btnGama_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 473);
            this.Controls.Add(this.btnGama);
            this.Controls.Add(this.btnMostrarProd);
            this.Controls.Add(this.dgJardineria);
            this.Controls.Add(this.btnPrecioMasCaroBarato);
            this.Controls.Add(this.btnClientesQueNoPagan);
            this.Controls.Add(this.btnEmpleadosDeUnJefe);
            this.Controls.Add(this.btnPedidosEntregados);
            this.Controls.Add(this.btnEliminarGama);
            this.Controls.Add(this.btnAnadirProducto);
            this.Name = "Form1";
            this.Text = "Jardineria";
            ((System.ComponentModel.ISupportInitialize)(this.dgJardineria)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAnadirProducto;
        private System.Windows.Forms.Button btnEliminarGama;
        private System.Windows.Forms.Button btnPedidosEntregados;
        private System.Windows.Forms.Button btnPrecioMasCaroBarato;
        private System.Windows.Forms.Button btnClientesQueNoPagan;
        private System.Windows.Forms.Button btnEmpleadosDeUnJefe;
        private System.Windows.Forms.DataGridView dgJardineria;
        private System.Windows.Forms.Button btnMostrarProd;
        private System.Windows.Forms.Button btnGama;
    }
}

