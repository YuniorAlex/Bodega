namespace CapaPresentacion.Forms
{
    partial class FormVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVenta));
            this.btncerrar = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewventa = new System.Windows.Forms.DataGridView();
            this.nroitem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codproducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomproducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.udm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precund = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.basecalculada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.igv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtserie = new System.Windows.Forms.TextBox();
            this.txtnrocorrelativo = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtcliente = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.comboBoxdnicliente = new System.Windows.Forms.ComboBox();
            this.btnproductos = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btnborrar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnbuscarcliente = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxmoneda = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxcomprobante = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewventa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnbuscarcliente)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btncerrar
            // 
            this.btncerrar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btncerrar.AutoSize = true;
            this.btncerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncerrar.Location = new System.Drawing.Point(1031, 2);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(18, 18);
            this.btncerrar.TabIndex = 15;
            this.btncerrar.Text = "X";
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(395, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ventas";
            // 
            // dataGridViewventa
            // 
            this.dataGridViewventa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewventa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewventa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nroitem,
            this.codproducto,
            this.nomproducto,
            this.udm,
            this.cantidad,
            this.precund,
            this.basecalculada,
            this.igv,
            this.importe});
            this.dataGridViewventa.Location = new System.Drawing.Point(27, 259);
            this.dataGridViewventa.Name = "dataGridViewventa";
            this.dataGridViewventa.Size = new System.Drawing.Size(996, 288);
            this.dataGridViewventa.TabIndex = 31;
            // 
            // nroitem
            // 
            this.nroitem.HeaderText = "Numero Item";
            this.nroitem.Name = "nroitem";
            // 
            // codproducto
            // 
            this.codproducto.HeaderText = "Cod Producto";
            this.codproducto.Name = "codproducto";
            // 
            // nomproducto
            // 
            this.nomproducto.HeaderText = "Nombre Producto";
            this.nomproducto.Name = "nomproducto";
            // 
            // udm
            // 
            this.udm.HeaderText = "UDM";
            this.udm.Name = "udm";
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            // 
            // precund
            // 
            this.precund.HeaderText = "Precio Unitario";
            this.precund.Name = "precund";
            // 
            // basecalculada
            // 
            this.basecalculada.HeaderText = "Base Calculada";
            this.basecalculada.Name = "basecalculada";
            // 
            // igv
            // 
            this.igv.HeaderText = "IGV";
            this.igv.Name = "igv";
            // 
            // importe
            // 
            this.importe.HeaderText = "Importe";
            this.importe.Name = "importe";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 18);
            this.label1.TabIndex = 43;
            this.label1.Text = "Serie :";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 18);
            this.label7.TabIndex = 48;
            this.label7.Text = "Total Neto :";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 18);
            this.label8.TabIndex = 49;
            this.label8.Text = "Nro Correlativo :";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(27, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 18);
            this.label12.TabIndex = 53;
            this.label12.Text = "Sub Total :";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(75, 52);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 18);
            this.label13.TabIndex = 54;
            this.label13.Text = "IGV :";
            // 
            // txtserie
            // 
            this.txtserie.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtserie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(245)))), ((int)(((byte)(222)))));
            this.txtserie.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtserie.Location = new System.Drawing.Point(157, 23);
            this.txtserie.Name = "txtserie";
            this.txtserie.Size = new System.Drawing.Size(160, 23);
            this.txtserie.TabIndex = 1;
            this.txtserie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtnrocorrelativo
            // 
            this.txtnrocorrelativo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtnrocorrelativo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(245)))), ((int)(((byte)(222)))));
            this.txtnrocorrelativo.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnrocorrelativo.Location = new System.Drawing.Point(157, 52);
            this.txtnrocorrelativo.Name = "txtnrocorrelativo";
            this.txtnrocorrelativo.Size = new System.Drawing.Size(160, 23);
            this.txtnrocorrelativo.TabIndex = 2;
            this.txtnrocorrelativo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Enabled = false;
            this.textBox4.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(126, 28);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(133, 18);
            this.textBox4.TabIndex = 59;
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(17, 19);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(112, 18);
            this.label15.TabIndex = 66;
            this.label15.Text = "Dni Cliente :";
            // 
            // txtcliente
            // 
            this.txtcliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtcliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(245)))), ((int)(((byte)(222)))));
            this.txtcliente.Enabled = false;
            this.txtcliente.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcliente.Location = new System.Drawing.Point(131, 46);
            this.txtcliente.Name = "txtcliente";
            this.txtcliente.Size = new System.Drawing.Size(457, 23);
            this.txtcliente.TabIndex = 69;
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(49, 48);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(80, 18);
            this.label16.TabIndex = 68;
            this.label16.Text = "Cliente :";
            // 
            // textBox10
            // 
            this.textBox10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox10.Enabled = false;
            this.textBox10.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox10.Location = new System.Drawing.Point(126, 52);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(133, 18);
            this.textBox10.TabIndex = 72;
            this.textBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox12
            // 
            this.textBox12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox12.Enabled = false;
            this.textBox12.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox12.Location = new System.Drawing.Point(126, 106);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(133, 39);
            this.textBox12.TabIndex = 73;
            this.textBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // comboBoxdnicliente
            // 
            this.comboBoxdnicliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxdnicliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(245)))), ((int)(((byte)(222)))));
            this.comboBoxdnicliente.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxdnicliente.FormattingEnabled = true;
            this.comboBoxdnicliente.Location = new System.Drawing.Point(131, 17);
            this.comboBoxdnicliente.Name = "comboBoxdnicliente";
            this.comboBoxdnicliente.Size = new System.Drawing.Size(160, 23);
            this.comboBoxdnicliente.TabIndex = 6;
            // 
            // btnproductos
            // 
            this.btnproductos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnproductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(212)))), ((int)(((byte)(107)))));
            this.btnproductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnproductos.FlatAppearance.BorderSize = 0;
            this.btnproductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(161)))), ((int)(((byte)(129)))));
            this.btnproductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnproductos.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnproductos.Image = ((System.Drawing.Image)(resources.GetObject("btnproductos.Image")));
            this.btnproductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnproductos.Location = new System.Drawing.Point(765, 214);
            this.btnproductos.Name = "btnproductos";
            this.btnproductos.Size = new System.Drawing.Size(200, 30);
            this.btnproductos.TabIndex = 5;
            this.btnproductos.Text = "   Productos";
            this.btnproductos.UseVisualStyleBackColor = false;
            this.btnproductos.Click += new System.EventHandler(this.btnproductos_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnguardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(212)))), ((int)(((byte)(107)))));
            this.btnguardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnguardar.FlatAppearance.BorderSize = 0;
            this.btnguardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(161)))), ((int)(((byte)(129)))));
            this.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguardar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardar.Image = ((System.Drawing.Image)(resources.GetObject("btnguardar.Image")));
            this.btnguardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnguardar.Location = new System.Drawing.Point(217, 558);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(130, 30);
            this.btnguardar.TabIndex = 9;
            this.btnguardar.Text = "   Guardar";
            this.btnguardar.UseVisualStyleBackColor = false;
            // 
            // btnborrar
            // 
            this.btnborrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnborrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(212)))), ((int)(((byte)(107)))));
            this.btnborrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnborrar.FlatAppearance.BorderSize = 0;
            this.btnborrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(161)))), ((int)(((byte)(129)))));
            this.btnborrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnborrar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnborrar.Image = ((System.Drawing.Image)(resources.GetObject("btnborrar.Image")));
            this.btnborrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnborrar.Location = new System.Drawing.Point(434, 558);
            this.btnborrar.Name = "btnborrar";
            this.btnborrar.Size = new System.Drawing.Size(130, 30);
            this.btnborrar.TabIndex = 10;
            this.btnborrar.Text = "   Borrar";
            this.btnborrar.UseVisualStyleBackColor = false;
            // 
            // btneliminar
            // 
            this.btneliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btneliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(212)))), ((int)(((byte)(107)))));
            this.btneliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btneliminar.FlatAppearance.BorderSize = 0;
            this.btneliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(161)))), ((int)(((byte)(129)))));
            this.btneliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneliminar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminar.Image = ((System.Drawing.Image)(resources.GetObject("btneliminar.Image")));
            this.btneliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btneliminar.Location = new System.Drawing.Point(651, 558);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(130, 30);
            this.btneliminar.TabIndex = 11;
            this.btneliminar.Text = "   Eliminar";
            this.btneliminar.UseVisualStyleBackColor = false;
            // 
            // btnbuscarcliente
            // 
            this.btnbuscarcliente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnbuscarcliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbuscarcliente.Image = ((System.Drawing.Image)(resources.GetObject("btnbuscarcliente.Image")));
            this.btnbuscarcliente.Location = new System.Drawing.Point(303, 16);
            this.btnbuscarcliente.Name = "btnbuscarcliente";
            this.btnbuscarcliente.Size = new System.Drawing.Size(24, 24);
            this.btnbuscarcliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnbuscarcliente.TabIndex = 82;
            this.btnbuscarcliente.TabStop = false;
            this.btnbuscarcliente.Click += new System.EventHandler(this.btnbuscarcliente_Click);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(43, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 18);
            this.label9.TabIndex = 84;
            this.label9.Text = "Importe :";
            // 
            // textBox3
            // 
            this.textBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Enabled = false;
            this.textBox3.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(126, 76);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(133, 18);
            this.textBox3.TabIndex = 93;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBoxmoneda);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtserie);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.comboBoxcomprobante);
            this.groupBox2.Controls.Add(this.txtnrocorrelativo);
            this.groupBox2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(39, 34);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(606, 89);
            this.groupBox2.TabIndex = 95;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Agregar Productos";
            // 
            // comboBoxmoneda
            // 
            this.comboBoxmoneda.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxmoneda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(245)))), ((int)(((byte)(222)))));
            this.comboBoxmoneda.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxmoneda.FormattingEnabled = true;
            this.comboBoxmoneda.Location = new System.Drawing.Point(436, 52);
            this.comboBoxmoneda.Name = "comboBoxmoneda";
            this.comboBoxmoneda.Size = new System.Drawing.Size(160, 23);
            this.comboBoxmoneda.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(322, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 18);
            this.label3.TabIndex = 84;
            this.label3.Text = "Comprobante :";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(362, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 18);
            this.label4.TabIndex = 98;
            this.label4.Text = "Moneda :";
            // 
            // comboBoxcomprobante
            // 
            this.comboBoxcomprobante.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxcomprobante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(245)))), ((int)(((byte)(222)))));
            this.comboBoxcomprobante.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxcomprobante.FormattingEnabled = true;
            this.comboBoxcomprobante.Location = new System.Drawing.Point(436, 23);
            this.comboBoxcomprobante.Name = "comboBoxcomprobante";
            this.comboBoxcomprobante.Size = new System.Drawing.Size(160, 23);
            this.comboBoxcomprobante.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtcliente);
            this.groupBox3.Controls.Add(this.comboBoxdnicliente);
            this.groupBox3.Controls.Add(this.btnbuscarcliente);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(39, 140);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(606, 80);
            this.groupBox3.TabIndex = 96;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos del Cliente";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox10);
            this.groupBox1.Controls.Add(this.textBox12);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(721, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(281, 164);
            this.groupBox1.TabIndex = 99;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Venta";
            // 
            // FormVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(233)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(1050, 600);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.btnborrar);
            this.Controls.Add(this.btnproductos);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.dataGridViewventa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btncerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormVenta";
            this.Load += new System.EventHandler(this.FormVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewventa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnbuscarcliente)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label btncerrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewventa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtserie;
        private System.Windows.Forms.TextBox txtnrocorrelativo;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtcliente;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.ComboBox comboBoxdnicliente;
        private System.Windows.Forms.Button btnproductos;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btnborrar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.PictureBox btnbuscarcliente;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroitem;
        private System.Windows.Forms.DataGridViewTextBoxColumn codproducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomproducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn udm;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn precund;
        private System.Windows.Forms.DataGridViewTextBoxColumn basecalculada;
        private System.Windows.Forms.DataGridViewTextBoxColumn igv;
        private System.Windows.Forms.DataGridViewTextBoxColumn importe;
        private System.Windows.Forms.ComboBox comboBoxcomprobante;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxmoneda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}