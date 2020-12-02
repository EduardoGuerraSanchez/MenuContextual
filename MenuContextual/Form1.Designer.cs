namespace MenuContextual
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.alcachofaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boton = new System.Windows.Forms.Button();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.clickToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grandeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pequeñoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fondoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.letraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alcachofaToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(97, 26);
            // 
            // alcachofaToolStripMenuItem
            // 
            this.alcachofaToolStripMenuItem.Name = "alcachofaToolStripMenuItem";
            this.alcachofaToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.alcachofaToolStripMenuItem.Text = "Salir";
            // 
            // boton
            // 
            this.boton.ContextMenuStrip = this.contextMenuStrip2;
            this.boton.Location = new System.Drawing.Point(306, 155);
            this.boton.Name = "boton";
            this.boton.Size = new System.Drawing.Size(105, 53);
            this.boton.TabIndex = 1;
            this.boton.Text = "Mi Botón";
            this.boton.UseVisualStyleBackColor = true;
            this.boton.Click += new System.EventHandler(this.boton_Click);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clickToolStripMenuItem,
            this.colorToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(117, 48);
            // 
            // clickToolStripMenuItem
            // 
            this.clickToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.grandeToolStripMenuItem,
            this.pequeñoToolStripMenuItem});
            this.clickToolStripMenuItem.Name = "clickToolStripMenuItem";
            this.clickToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.clickToolStripMenuItem.Text = "Tamaño";
            // 
            // grandeToolStripMenuItem
            // 
            this.grandeToolStripMenuItem.Name = "grandeToolStripMenuItem";
            this.grandeToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.grandeToolStripMenuItem.Text = "Grande";
            this.grandeToolStripMenuItem.Click += new System.EventHandler(this.grandeToolStripMenuItem_Click);
            // 
            // pequeñoToolStripMenuItem
            // 
            this.pequeñoToolStripMenuItem.Name = "pequeñoToolStripMenuItem";
            this.pequeñoToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.pequeñoToolStripMenuItem.Text = "Pequeño";
            this.pequeñoToolStripMenuItem.Click += new System.EventHandler(this.pequeñoToolStripMenuItem_Click);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fondoToolStripMenuItem,
            this.letraToolStripMenuItem});
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.colorToolStripMenuItem.Text = "Color";
            // 
            // fondoToolStripMenuItem
            // 
            this.fondoToolStripMenuItem.Name = "fondoToolStripMenuItem";
            this.fondoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fondoToolStripMenuItem.Text = "Fondo";
            this.fondoToolStripMenuItem.Click += new System.EventHandler(this.fondoToolStripMenuItem_Click);
            // 
            // letraToolStripMenuItem
            // 
            this.letraToolStripMenuItem.Name = "letraToolStripMenuItem";
            this.letraToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.letraToolStripMenuItem.Text = "Letra";
            this.letraToolStripMenuItem.Click += new System.EventHandler(this.letraToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.boton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem alcachofaToolStripMenuItem;
        private System.Windows.Forms.Button boton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem clickToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grandeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pequeñoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fondoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem letraToolStripMenuItem;
    }
}

