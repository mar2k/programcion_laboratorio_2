namespace Central_Telefónica
{
    partial class FrmMenu
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
            this.btnGenerarLlamada = new System.Windows.Forms.Button();
            this.btnFacturaciónTotal = new System.Windows.Forms.Button();
            this.btnFacturaciónLocal = new System.Windows.Forms.Button();
            this.btnFacturaciónProvincial = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGenerarLlamada
            // 
            this.btnGenerarLlamada.Location = new System.Drawing.Point(12, 12);
            this.btnGenerarLlamada.Name = "btnGenerarLlamada";
            this.btnGenerarLlamada.Size = new System.Drawing.Size(200, 50);
            this.btnGenerarLlamada.TabIndex = 0;
            this.btnGenerarLlamada.Text = "Generar Llamada";
            this.btnGenerarLlamada.UseVisualStyleBackColor = true;
            this.btnGenerarLlamada.Click += new System.EventHandler(this.btnGenerarLlamada_Click);
            // 
            // btnFacturaciónTotal
            // 
            this.btnFacturaciónTotal.Location = new System.Drawing.Point(12, 68);
            this.btnFacturaciónTotal.Name = "btnFacturaciónTotal";
            this.btnFacturaciónTotal.Size = new System.Drawing.Size(200, 50);
            this.btnFacturaciónTotal.TabIndex = 1;
            this.btnFacturaciónTotal.Text = "Facturación Total";
            this.btnFacturaciónTotal.UseVisualStyleBackColor = true;
            this.btnFacturaciónTotal.Click += new System.EventHandler(this.btnFacturaciónTotal_Click);
            // 
            // btnFacturaciónLocal
            // 
            this.btnFacturaciónLocal.Location = new System.Drawing.Point(12, 124);
            this.btnFacturaciónLocal.Name = "btnFacturaciónLocal";
            this.btnFacturaciónLocal.Size = new System.Drawing.Size(200, 50);
            this.btnFacturaciónLocal.TabIndex = 2;
            this.btnFacturaciónLocal.Text = "Facturación Local";
            this.btnFacturaciónLocal.UseVisualStyleBackColor = true;
            this.btnFacturaciónLocal.Click += new System.EventHandler(this.btnFacturaciónLocal_Click);
            // 
            // btnFacturaciónProvincial
            // 
            this.btnFacturaciónProvincial.Location = new System.Drawing.Point(12, 180);
            this.btnFacturaciónProvincial.Name = "btnFacturaciónProvincial";
            this.btnFacturaciónProvincial.Size = new System.Drawing.Size(200, 50);
            this.btnFacturaciónProvincial.TabIndex = 3;
            this.btnFacturaciónProvincial.Text = "Facturación Provincial";
            this.btnFacturaciónProvincial.UseVisualStyleBackColor = true;
            this.btnFacturaciónProvincial.Click += new System.EventHandler(this.btnFacturaciónProvincial_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(12, 236);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(200, 50);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 292);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnFacturaciónProvincial);
            this.Controls.Add(this.btnFacturaciónLocal);
            this.Controls.Add(this.btnFacturaciónTotal);
            this.Controls.Add(this.btnGenerarLlamada);
            this.Name = "FrmMenu";
            this.Text = "Central Telefónica";
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGenerarLlamada;
        private System.Windows.Forms.Button btnFacturaciónTotal;
        private System.Windows.Forms.Button btnFacturaciónLocal;
        private System.Windows.Forms.Button btnFacturaciónProvincial;
        private System.Windows.Forms.Button btnSalir;
    }
}

