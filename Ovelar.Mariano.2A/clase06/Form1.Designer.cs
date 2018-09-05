namespace clase06
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.administrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tintaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.plumaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tintaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.plumaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administrarToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(369, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administrarToolStripMenuItem,
            this.tintaToolStripMenuItem,
            this.plumaToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(137, 70);
            // 
            // administrarToolStripMenuItem
            // 
            this.administrarToolStripMenuItem.Name = "administrarToolStripMenuItem";
            this.administrarToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.administrarToolStripMenuItem.Text = "Administrar";
            // 
            // tintaToolStripMenuItem
            // 
            this.tintaToolStripMenuItem.Name = "tintaToolStripMenuItem";
            this.tintaToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.tintaToolStripMenuItem.Text = "Tinta";
            // 
            // plumaToolStripMenuItem
            // 
            this.plumaToolStripMenuItem.Name = "plumaToolStripMenuItem";
            this.plumaToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.plumaToolStripMenuItem.Text = "Pluma";
            // 
            // administrarToolStripMenuItem1
            // 
            this.administrarToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tintaToolStripMenuItem1,
            this.plumaToolStripMenuItem1});
            this.administrarToolStripMenuItem1.Name = "administrarToolStripMenuItem1";
            this.administrarToolStripMenuItem1.Size = new System.Drawing.Size(81, 20);
            this.administrarToolStripMenuItem1.Text = "Administrar";
            // 
            // tintaToolStripMenuItem1
            // 
            this.tintaToolStripMenuItem1.Name = "tintaToolStripMenuItem1";
            this.tintaToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.tintaToolStripMenuItem1.Text = "Tinta";
            this.tintaToolStripMenuItem1.Click += new System.EventHandler(this.tintaToolStripMenuItem1_Click);
            // 
            // plumaToolStripMenuItem1
            // 
            this.plumaToolStripMenuItem1.Name = "plumaToolStripMenuItem1";
            this.plumaToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.plumaToolStripMenuItem1.Text = "Pluma";
            this.plumaToolStripMenuItem1.Click += new System.EventHandler(this.plumaToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 170);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem administrarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tintaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem plumaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem administrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tintaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem plumaToolStripMenuItem;
    }
}

