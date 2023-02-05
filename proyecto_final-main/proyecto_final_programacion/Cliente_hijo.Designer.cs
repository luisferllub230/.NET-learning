
namespace proyecto_final_programacion
{
    partial class Cliente_hijo
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel_superior = new System.Windows.Forms.Panel();
            this.label_titulo = new System.Windows.Forms.Label();
            this.BTN_cerrar = new System.Windows.Forms.Button();
            this.label_timer = new System.Windows.Forms.Label();
            this.textBox_cedula = new System.Windows.Forms.MaskedTextBox();
            this.textBox_celular = new System.Windows.Forms.MaskedTextBox();
            this.textBox_telefono = new System.Windows.Forms.MaskedTextBox();
            this.horaActual = new System.Windows.Forms.Label();
            this.BTN_buscar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox_buscar = new System.Windows.Forms.TextBox();
            this.label_sexo = new System.Windows.Forms.Label();
            this.BTN_guardar = new System.Windows.Forms.Button();
            this.label_Celular = new System.Windows.Forms.Label();
            this.radioButton_femenino = new System.Windows.Forms.RadioButton();
            this.radioButton_masculino = new System.Windows.Forms.RadioButton();
            this.BTN_eliminar = new System.Windows.Forms.Button();
            this.BTN_editar = new System.Windows.Forms.Button();
            this.BTN_nuevo = new System.Windows.Forms.Button();
            this.label_Tcliente = new System.Windows.Forms.Label();
            this.comboBoxTcliente = new System.Windows.Forms.ComboBox();
            this.label_cedula = new System.Windows.Forms.Label();
            this.textBox_direccion = new System.Windows.Forms.TextBox();
            this.label_direccion = new System.Windows.Forms.Label();
            this.label_telefono = new System.Windows.Forms.Label();
            this.textBox_edad = new System.Windows.Forms.TextBox();
            this.label_edad = new System.Windows.Forms.Label();
            this.textBox_apellido = new System.Windows.Forms.TextBox();
            this.label_apellido = new System.Windows.Forms.Label();
            this.textBox_nombre = new System.Windows.Forms.TextBox();
            this.label_nombre = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel_superior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_superior
            // 
            this.panel_superior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panel_superior.Controls.Add(this.label_titulo);
            this.panel_superior.Controls.Add(this.BTN_cerrar);
            this.panel_superior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_superior.Location = new System.Drawing.Point(0, 0);
            this.panel_superior.Name = "panel_superior";
            this.panel_superior.Size = new System.Drawing.Size(1034, 47);
            this.panel_superior.TabIndex = 0;
            // 
            // label_titulo
            // 
            this.label_titulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_titulo.AutoSize = true;
            this.label_titulo.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label_titulo.Location = new System.Drawing.Point(370, 14);
            this.label_titulo.Name = "label_titulo";
            this.label_titulo.Size = new System.Drawing.Size(188, 21);
            this.label_titulo.TabIndex = 0;
            this.label_titulo.Text = "Registro de Clientes ";
            // 
            // BTN_cerrar
            // 
            this.BTN_cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_cerrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BTN_cerrar.FlatAppearance.BorderSize = 0;
            this.BTN_cerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BTN_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_cerrar.Image = global::proyecto_final_programacion.Properties.Resources.imagenCerrar1;
            this.BTN_cerrar.Location = new System.Drawing.Point(993, 3);
            this.BTN_cerrar.Name = "BTN_cerrar";
            this.BTN_cerrar.Size = new System.Drawing.Size(29, 32);
            this.BTN_cerrar.TabIndex = 17;
            this.BTN_cerrar.UseVisualStyleBackColor = true;
            this.BTN_cerrar.Click += new System.EventHandler(this.BTN_cerrar_Click);
            // 
            // label_timer
            // 
            this.label_timer.AutoSize = true;
            this.label_timer.Location = new System.Drawing.Point(426, 93);
            this.label_timer.Name = "label_timer";
            this.label_timer.Size = new System.Drawing.Size(13, 13);
            this.label_timer.TabIndex = 55;
            this.label_timer.Text = "0";
            // 
            // textBox_cedula
            // 
            this.textBox_cedula.Location = new System.Drawing.Point(30, 243);
            this.textBox_cedula.Mask = "000 - 0000000 - 0";
            this.textBox_cedula.Name = "textBox_cedula";
            this.textBox_cedula.Size = new System.Drawing.Size(252, 20);
            this.textBox_cedula.TabIndex = 3;
            this.textBox_cedula.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.textBox_cedula_MaskInputRejected);
            // 
            // textBox_celular
            // 
            this.textBox_celular.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_celular.Location = new System.Drawing.Point(624, 163);
            this.textBox_celular.Mask = "(999) 000-0000";
            this.textBox_celular.Name = "textBox_celular";
            this.textBox_celular.Size = new System.Drawing.Size(159, 20);
            this.textBox_celular.TabIndex = 5;
            // 
            // textBox_telefono
            // 
            this.textBox_telefono.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_telefono.Location = new System.Drawing.Point(624, 228);
            this.textBox_telefono.Mask = "(999) 000-0000";
            this.textBox_telefono.Name = "textBox_telefono";
            this.textBox_telefono.Size = new System.Drawing.Size(159, 20);
            this.textBox_telefono.TabIndex = 6;
            // 
            // horaActual
            // 
            this.horaActual.AutoSize = true;
            this.horaActual.Location = new System.Drawing.Point(343, 93);
            this.horaActual.Name = "horaActual";
            this.horaActual.Size = new System.Drawing.Size(66, 13);
            this.horaActual.TabIndex = 54;
            this.horaActual.Text = "paraElTime1";
            this.horaActual.Visible = false;
            // 
            // BTN_buscar
            // 
            this.BTN_buscar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BTN_buscar.BackColor = System.Drawing.Color.White;
            this.BTN_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_buscar.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_buscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.BTN_buscar.Location = new System.Drawing.Point(899, 688);
            this.BTN_buscar.Name = "BTN_buscar";
            this.BTN_buscar.Size = new System.Drawing.Size(98, 34);
            this.BTN_buscar.TabIndex = 16;
            this.BTN_buscar.Text = "BUSCAR";
            this.BTN_buscar.UseVisualStyleBackColor = false;
            this.BTN_buscar.Click += new System.EventHandler(this.BTN_buscar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(103, 436);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(814, 189);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.textBox_buscar);
            this.panel1.Location = new System.Drawing.Point(624, 688);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(269, 34);
            this.panel1.TabIndex = 0;
            // 
            // textBox_buscar
            // 
            this.textBox_buscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_buscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_buscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox_buscar.Location = new System.Drawing.Point(3, 11);
            this.textBox_buscar.Name = "textBox_buscar";
            this.textBox_buscar.Size = new System.Drawing.Size(263, 13);
            this.textBox_buscar.TabIndex = 15;
            this.textBox_buscar.TextChanged += new System.EventHandler(this.textBox_buscar_TextChanged);
            // 
            // label_sexo
            // 
            this.label_sexo.AutoSize = true;
            this.label_sexo.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_sexo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.label_sexo.Location = new System.Drawing.Point(26, 287);
            this.label_sexo.Name = "label_sexo";
            this.label_sexo.Size = new System.Drawing.Size(58, 24);
            this.label_sexo.TabIndex = 0;
            this.label_sexo.Text = "Sexo:";
            // 
            // BTN_guardar
            // 
            this.BTN_guardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BTN_guardar.BackColor = System.Drawing.Color.White;
            this.BTN_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_guardar.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_guardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.BTN_guardar.Location = new System.Drawing.Point(12, 688);
            this.BTN_guardar.Name = "BTN_guardar";
            this.BTN_guardar.Size = new System.Drawing.Size(102, 34);
            this.BTN_guardar.TabIndex = 11;
            this.BTN_guardar.Text = "GUARDAR";
            this.toolTip1.SetToolTip(this.BTN_guardar, "click para guardar ");
            this.BTN_guardar.UseVisualStyleBackColor = false;
            this.BTN_guardar.Click += new System.EventHandler(this.BTN_guardar_Click_1);
            // 
            // label_Celular
            // 
            this.label_Celular.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Celular.AutoSize = true;
            this.label_Celular.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Celular.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.label_Celular.Location = new System.Drawing.Point(623, 132);
            this.label_Celular.Name = "label_Celular";
            this.label_Celular.Size = new System.Drawing.Size(85, 24);
            this.label_Celular.TabIndex = 0;
            this.label_Celular.Text = "Celular:";
            // 
            // radioButton_femenino
            // 
            this.radioButton_femenino.AutoSize = true;
            this.radioButton_femenino.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_femenino.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.radioButton_femenino.Location = new System.Drawing.Point(207, 290);
            this.radioButton_femenino.Name = "radioButton_femenino";
            this.radioButton_femenino.Size = new System.Drawing.Size(94, 21);
            this.radioButton_femenino.TabIndex = 8;
            this.radioButton_femenino.TabStop = true;
            this.radioButton_femenino.Text = "FEMENINO";
            this.radioButton_femenino.UseVisualStyleBackColor = true;
            // 
            // radioButton_masculino
            // 
            this.radioButton_masculino.AutoSize = true;
            this.radioButton_masculino.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_masculino.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.radioButton_masculino.Location = new System.Drawing.Point(90, 290);
            this.radioButton_masculino.Name = "radioButton_masculino";
            this.radioButton_masculino.Size = new System.Drawing.Size(111, 22);
            this.radioButton_masculino.TabIndex = 7;
            this.radioButton_masculino.TabStop = true;
            this.radioButton_masculino.Text = "MASCULINO";
            this.radioButton_masculino.UseVisualStyleBackColor = true;
            // 
            // BTN_eliminar
            // 
            this.BTN_eliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BTN_eliminar.BackColor = System.Drawing.Color.White;
            this.BTN_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_eliminar.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_eliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.BTN_eliminar.Location = new System.Drawing.Point(385, 688);
            this.BTN_eliminar.Name = "BTN_eliminar";
            this.BTN_eliminar.Size = new System.Drawing.Size(98, 34);
            this.BTN_eliminar.TabIndex = 14;
            this.BTN_eliminar.Text = "ELIMINAR";
            this.BTN_eliminar.UseVisualStyleBackColor = false;
            this.BTN_eliminar.Click += new System.EventHandler(this.BTN_eliminar_Click);
            // 
            // BTN_editar
            // 
            this.BTN_editar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BTN_editar.BackColor = System.Drawing.Color.White;
            this.BTN_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_editar.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_editar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.BTN_editar.Location = new System.Drawing.Point(261, 688);
            this.BTN_editar.Name = "BTN_editar";
            this.BTN_editar.Size = new System.Drawing.Size(102, 34);
            this.BTN_editar.TabIndex = 13;
            this.BTN_editar.Text = "EDITAR";
            this.BTN_editar.UseVisualStyleBackColor = false;
            this.BTN_editar.Click += new System.EventHandler(this.BTN_editar_Click);
            // 
            // BTN_nuevo
            // 
            this.BTN_nuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BTN_nuevo.BackColor = System.Drawing.Color.White;
            this.BTN_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_nuevo.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_nuevo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.BTN_nuevo.Location = new System.Drawing.Point(138, 688);
            this.BTN_nuevo.Name = "BTN_nuevo";
            this.BTN_nuevo.Size = new System.Drawing.Size(102, 34);
            this.BTN_nuevo.TabIndex = 12;
            this.BTN_nuevo.Text = "NUEVO";
            this.BTN_nuevo.UseVisualStyleBackColor = false;
            this.BTN_nuevo.Click += new System.EventHandler(this.BTN_nuevo_Click);
            // 
            // label_Tcliente
            // 
            this.label_Tcliente.AutoSize = true;
            this.label_Tcliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_Tcliente.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Tcliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.label_Tcliente.Location = new System.Drawing.Point(370, 290);
            this.label_Tcliente.Name = "label_Tcliente";
            this.label_Tcliente.Size = new System.Drawing.Size(158, 24);
            this.label_Tcliente.TabIndex = 0;
            this.label_Tcliente.Text = "Tipo de Cliente:";
            // 
            // comboBoxTcliente
            // 
            this.comboBoxTcliente.DisplayMember = "3";
            this.comboBoxTcliente.FormattingEnabled = true;
            this.comboBoxTcliente.Items.AddRange(new object[] {
            "Frecuente",
            "Casual",
            "Nuevo"});
            this.comboBoxTcliente.Location = new System.Drawing.Point(374, 329);
            this.comboBoxTcliente.Name = "comboBoxTcliente";
            this.comboBoxTcliente.Size = new System.Drawing.Size(252, 21);
            this.comboBoxTcliente.TabIndex = 9;
            this.comboBoxTcliente.Text = "Frecuente/Casual/Nuevo";
            // 
            // label_cedula
            // 
            this.label_cedula.AutoSize = true;
            this.label_cedula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_cedula.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cedula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.label_cedula.Location = new System.Drawing.Point(26, 201);
            this.label_cedula.Name = "label_cedula";
            this.label_cedula.Size = new System.Drawing.Size(79, 24);
            this.label_cedula.TabIndex = 0;
            this.label_cedula.Text = "Cedula:";
            // 
            // textBox_direccion
            // 
            this.textBox_direccion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_direccion.BackColor = System.Drawing.Color.White;
            this.textBox_direccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_direccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox_direccion.Location = new System.Drawing.Point(30, 392);
            this.textBox_direccion.MaxLength = 50;
            this.textBox_direccion.Multiline = true;
            this.textBox_direccion.Name = "textBox_direccion";
            this.textBox_direccion.Size = new System.Drawing.Size(528, 17);
            this.textBox_direccion.TabIndex = 10;
            // 
            // label_direccion
            // 
            this.label_direccion.AutoSize = true;
            this.label_direccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_direccion.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_direccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.label_direccion.Location = new System.Drawing.Point(26, 350);
            this.label_direccion.Name = "label_direccion";
            this.label_direccion.Size = new System.Drawing.Size(106, 24);
            this.label_direccion.TabIndex = 0;
            this.label_direccion.Text = "Direccion:";
            // 
            // label_telefono
            // 
            this.label_telefono.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_telefono.AutoSize = true;
            this.label_telefono.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_telefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.label_telefono.Location = new System.Drawing.Point(623, 201);
            this.label_telefono.Name = "label_telefono";
            this.label_telefono.Size = new System.Drawing.Size(96, 24);
            this.label_telefono.TabIndex = 0;
            this.label_telefono.Text = "Telefono:";
            // 
            // textBox_edad
            // 
            this.textBox_edad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_edad.BackColor = System.Drawing.Color.White;
            this.textBox_edad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_edad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox_edad.Location = new System.Drawing.Point(627, 112);
            this.textBox_edad.MaxLength = 3;
            this.textBox_edad.Name = "textBox_edad";
            this.textBox_edad.Size = new System.Drawing.Size(92, 13);
            this.textBox_edad.TabIndex = 4;
            this.textBox_edad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_edad_KeyPress);
            // 
            // label_edad
            // 
            this.label_edad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_edad.AutoSize = true;
            this.label_edad.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_edad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.label_edad.Location = new System.Drawing.Point(623, 85);
            this.label_edad.Name = "label_edad";
            this.label_edad.Size = new System.Drawing.Size(59, 24);
            this.label_edad.TabIndex = 0;
            this.label_edad.Text = "Edad";
            // 
            // textBox_apellido
            // 
            this.textBox_apellido.BackColor = System.Drawing.Color.White;
            this.textBox_apellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_apellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox_apellido.Location = new System.Drawing.Point(30, 166);
            this.textBox_apellido.MaxLength = 30;
            this.textBox_apellido.Name = "textBox_apellido";
            this.textBox_apellido.Size = new System.Drawing.Size(252, 13);
            this.textBox_apellido.TabIndex = 2;
            this.textBox_apellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_apellido_KeyPress);
            // 
            // label_apellido
            // 
            this.label_apellido.AutoSize = true;
            this.label_apellido.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_apellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.label_apellido.Location = new System.Drawing.Point(26, 132);
            this.label_apellido.Name = "label_apellido";
            this.label_apellido.Size = new System.Drawing.Size(96, 24);
            this.label_apellido.TabIndex = 0;
            this.label_apellido.Text = "Apellido:";
            // 
            // textBox_nombre
            // 
            this.textBox_nombre.BackColor = System.Drawing.Color.White;
            this.textBox_nombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_nombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox_nombre.Location = new System.Drawing.Point(30, 112);
            this.textBox_nombre.MaxLength = 30;
            this.textBox_nombre.Name = "textBox_nombre";
            this.textBox_nombre.Size = new System.Drawing.Size(252, 13);
            this.textBox_nombre.TabIndex = 1;
            this.textBox_nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_nombre_KeyPress);
            // 
            // label_nombre
            // 
            this.label_nombre.AutoSize = true;
            this.label_nombre.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.label_nombre.Location = new System.Drawing.Point(26, 85);
            this.label_nombre.Name = "label_nombre";
            this.label_nombre.Size = new System.Drawing.Size(88, 24);
            this.label_nombre.TabIndex = 0;
            this.label_nombre.Text = "Nombre:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Cliente_hijo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1034, 740);
            this.Controls.Add(this.label_cedula);
            this.Controls.Add(this.horaActual);
            this.Controls.Add(this.textBox_cedula);
            this.Controls.Add(this.label_timer);
            this.Controls.Add(this.textBox_apellido);
            this.Controls.Add(this.label_sexo);
            this.Controls.Add(this.label_apellido);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox_nombre);
            this.Controls.Add(this.radioButton_masculino);
            this.Controls.Add(this.label_nombre);
            this.Controls.Add(this.radioButton_femenino);
            this.Controls.Add(this.BTN_guardar);
            this.Controls.Add(this.BTN_buscar);
            this.Controls.Add(this.label_Tcliente);
            this.Controls.Add(this.panel_superior);
            this.Controls.Add(this.comboBoxTcliente);
            this.Controls.Add(this.label_direccion);
            this.Controls.Add(this.textBox_telefono);
            this.Controls.Add(this.BTN_eliminar);
            this.Controls.Add(this.textBox_direccion);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BTN_editar);
            this.Controls.Add(this.textBox_celular);
            this.Controls.Add(this.BTN_nuevo);
            this.Controls.Add(this.textBox_edad);
            this.Controls.Add(this.label_edad);
            this.Controls.Add(this.label_Celular);
            this.Controls.Add(this.label_telefono);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Cliente_hijo";
            this.Text = "Cliente_hijo";
            this.Load += new System.EventHandler(this.Cliente_hijo_Load_1);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Cliente_hijo_KeyDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Cliente_hijo_MouseMove);
            this.panel_superior.ResumeLayout(false);
            this.panel_superior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_superior;
        private System.Windows.Forms.Button BTN_cerrar;
        private System.Windows.Forms.Label label_titulo;
        private System.Windows.Forms.Label label_nombre;
        private System.Windows.Forms.TextBox textBox_nombre;
        private System.Windows.Forms.TextBox textBox_apellido;
        private System.Windows.Forms.Label label_apellido;
        private System.Windows.Forms.Label label_telefono;
        private System.Windows.Forms.TextBox textBox_edad;
        private System.Windows.Forms.Label label_edad;
        private System.Windows.Forms.TextBox textBox_direccion;
        private System.Windows.Forms.Label label_direccion;
        private System.Windows.Forms.Label label_cedula;
        private System.Windows.Forms.ComboBox comboBoxTcliente;
        private System.Windows.Forms.Label label_Tcliente;
        private System.Windows.Forms.RadioButton radioButton_femenino;
        private System.Windows.Forms.RadioButton radioButton_masculino;
        private System.Windows.Forms.Button BTN_eliminar;
        private System.Windows.Forms.Button BTN_editar;
        private System.Windows.Forms.Button BTN_nuevo;
        private System.Windows.Forms.Label label_Celular;
        private System.Windows.Forms.Button BTN_guardar;
        private System.Windows.Forms.Label label_sexo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox_buscar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BTN_buscar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label horaActual;
        private System.Windows.Forms.MaskedTextBox textBox_telefono;
        private System.Windows.Forms.MaskedTextBox textBox_celular;
        private System.Windows.Forms.MaskedTextBox textBox_cedula;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label_timer;
        private System.Windows.Forms.Timer timer2;
    }
}