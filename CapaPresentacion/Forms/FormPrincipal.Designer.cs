﻿namespace CapaPresentacion.Forms
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.MenuVertical = new System.Windows.Forms.Panel();
            this.btnempleado = new System.Windows.Forms.Button();
            this.btncompra = new System.Windows.Forms.Button();
            this.btnproveedor = new System.Windows.Forms.Button();
            this.btncliente = new System.Windows.Forms.Button();
            this.btnventa = new System.Windows.Forms.Button();
            this.btnproducto = new System.Windows.Forms.Button();
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.btnminimizar = new System.Windows.Forms.PictureBox();
            this.btncerrar = new System.Windows.Forms.PictureBox();
            this.btnmenu = new System.Windows.Forms.PictureBox();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.MenuVertical.SuspendLayout();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnmenu)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuVertical
            // 
            this.MenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(212)))), ((int)(((byte)(107)))));
            this.MenuVertical.Controls.Add(this.button1);
            this.MenuVertical.Controls.Add(this.btnempleado);
            this.MenuVertical.Controls.Add(this.btncompra);
            this.MenuVertical.Controls.Add(this.btnproveedor);
            this.MenuVertical.Controls.Add(this.btncliente);
            this.MenuVertical.Controls.Add(this.btnventa);
            this.MenuVertical.Controls.Add(this.btnproducto);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.Location = new System.Drawing.Point(0, 0);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(250, 650);
            this.MenuVertical.TabIndex = 0;
            // 
            // btnempleado
            // 
            this.btnempleado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnempleado.FlatAppearance.BorderSize = 0;
            this.btnempleado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(161)))), ((int)(((byte)(129)))));
            this.btnempleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnempleado.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnempleado.Image = ((System.Drawing.Image)(resources.GetObject("btnempleado.Image")));
            this.btnempleado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnempleado.Location = new System.Drawing.Point(0, 469);
            this.btnempleado.Name = "btnempleado";
            this.btnempleado.Size = new System.Drawing.Size(250, 40);
            this.btnempleado.TabIndex = 6;
            this.btnempleado.Text = "   Empleados";
            this.btnempleado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnempleado.UseVisualStyleBackColor = true;
            this.btnempleado.Click += new System.EventHandler(this.btnempleado_Click);
            // 
            // btncompra
            // 
            this.btncompra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncompra.FlatAppearance.BorderSize = 0;
            this.btncompra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(161)))), ((int)(((byte)(129)))));
            this.btncompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncompra.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncompra.Image = ((System.Drawing.Image)(resources.GetObject("btncompra.Image")));
            this.btncompra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncompra.Location = new System.Drawing.Point(0, 402);
            this.btncompra.Name = "btncompra";
            this.btncompra.Size = new System.Drawing.Size(250, 40);
            this.btncompra.TabIndex = 5;
            this.btncompra.Text = "   Compras";
            this.btncompra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncompra.UseVisualStyleBackColor = true;
            this.btncompra.Click += new System.EventHandler(this.btncompra_Click);
            // 
            // btnproveedor
            // 
            this.btnproveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnproveedor.FlatAppearance.BorderSize = 0;
            this.btnproveedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(161)))), ((int)(((byte)(129)))));
            this.btnproveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnproveedor.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnproveedor.Image = ((System.Drawing.Image)(resources.GetObject("btnproveedor.Image")));
            this.btnproveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnproveedor.Location = new System.Drawing.Point(0, 335);
            this.btnproveedor.Name = "btnproveedor";
            this.btnproveedor.Size = new System.Drawing.Size(250, 40);
            this.btnproveedor.TabIndex = 4;
            this.btnproveedor.Text = "   Proveedores";
            this.btnproveedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnproveedor.UseVisualStyleBackColor = true;
            this.btnproveedor.Click += new System.EventHandler(this.btnproveedor_Click);
            // 
            // btncliente
            // 
            this.btncliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncliente.FlatAppearance.BorderSize = 0;
            this.btncliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(161)))), ((int)(((byte)(129)))));
            this.btncliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncliente.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncliente.Image = ((System.Drawing.Image)(resources.GetObject("btncliente.Image")));
            this.btncliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncliente.Location = new System.Drawing.Point(0, 268);
            this.btncliente.Name = "btncliente";
            this.btncliente.Size = new System.Drawing.Size(250, 40);
            this.btncliente.TabIndex = 3;
            this.btncliente.Text = "   Clientes";
            this.btncliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncliente.UseVisualStyleBackColor = true;
            this.btncliente.Click += new System.EventHandler(this.btncliente_Click);
            // 
            // btnventa
            // 
            this.btnventa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnventa.FlatAppearance.BorderSize = 0;
            this.btnventa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(161)))), ((int)(((byte)(129)))));
            this.btnventa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnventa.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnventa.Image = ((System.Drawing.Image)(resources.GetObject("btnventa.Image")));
            this.btnventa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnventa.Location = new System.Drawing.Point(0, 201);
            this.btnventa.Name = "btnventa";
            this.btnventa.Size = new System.Drawing.Size(250, 40);
            this.btnventa.TabIndex = 2;
            this.btnventa.Text = "   Ventas";
            this.btnventa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnventa.UseVisualStyleBackColor = true;
            this.btnventa.Click += new System.EventHandler(this.btnventa_Click);
            // 
            // btnproducto
            // 
            this.btnproducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnproducto.FlatAppearance.BorderSize = 0;
            this.btnproducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(161)))), ((int)(((byte)(129)))));
            this.btnproducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnproducto.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnproducto.Image = ((System.Drawing.Image)(resources.GetObject("btnproducto.Image")));
            this.btnproducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnproducto.Location = new System.Drawing.Point(0, 134);
            this.btnproducto.Name = "btnproducto";
            this.btnproducto.Size = new System.Drawing.Size(250, 40);
            this.btnproducto.TabIndex = 1;
            this.btnproducto.Text = "   Productos";
            this.btnproducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnproducto.UseVisualStyleBackColor = true;
            this.btnproducto.Click += new System.EventHandler(this.btnproducto_Click);
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(233)))), ((int)(((byte)(238)))));
            this.BarraTitulo.Controls.Add(this.btnminimizar);
            this.BarraTitulo.Controls.Add(this.btncerrar);
            this.BarraTitulo.Controls.Add(this.btnmenu);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(250, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(1050, 50);
            this.BarraTitulo.TabIndex = 1;
            // 
            // btnminimizar
            // 
            this.btnminimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnminimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnminimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnminimizar.Image")));
            this.btnminimizar.Location = new System.Drawing.Point(982, 11);
            this.btnminimizar.Name = "btnminimizar";
            this.btnminimizar.Size = new System.Drawing.Size(25, 25);
            this.btnminimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnminimizar.TabIndex = 1;
            this.btnminimizar.TabStop = false;
            this.btnminimizar.Click += new System.EventHandler(this.btnminimizar_Click);
            // 
            // btncerrar
            // 
            this.btncerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btncerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncerrar.Image = ((System.Drawing.Image)(resources.GetObject("btncerrar.Image")));
            this.btncerrar.Location = new System.Drawing.Point(1018, 11);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(25, 25);
            this.btncerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btncerrar.TabIndex = 0;
            this.btncerrar.TabStop = false;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // btnmenu
            // 
            this.btnmenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnmenu.Image = ((System.Drawing.Image)(resources.GetObject("btnmenu.Image")));
            this.btnmenu.Location = new System.Drawing.Point(0, 7);
            this.btnmenu.Name = "btnmenu";
            this.btnmenu.Size = new System.Drawing.Size(35, 35);
            this.btnmenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnmenu.TabIndex = 0;
            this.btnmenu.TabStop = false;
            this.btnmenu.Click += new System.EventHandler(this.btnmenu_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(233)))), ((int)(((byte)(238)))));
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(250, 50);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1050, 600);
            this.panelContenedor.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(161)))), ((int)(((byte)(129)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 536);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 40);
            this.button1.TabIndex = 7;
            this.button1.Text = "   Reportes";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.ControlBox = false;
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.BarraTitulo);
            this.Controls.Add(this.MenuVertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.MenuVertical.ResumeLayout(false);
            this.BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnmenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuVertical;
        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.PictureBox btnmenu;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.PictureBox btnminimizar;
        private System.Windows.Forms.PictureBox btncerrar;
        private System.Windows.Forms.Button btnproducto;
        private System.Windows.Forms.Button btnempleado;
        private System.Windows.Forms.Button btncompra;
        private System.Windows.Forms.Button btnproveedor;
        private System.Windows.Forms.Button btncliente;
        private System.Windows.Forms.Button btnventa;
        private System.Windows.Forms.Button button1;
    }
}