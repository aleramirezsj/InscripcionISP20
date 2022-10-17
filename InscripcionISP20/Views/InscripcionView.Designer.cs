namespace Desktop.Views
{
    partial class InscripcionView
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCicloLectivo = new System.Windows.Forms.Label();
            this.cboCicloLectivo = new System.Windows.Forms.ComboBox();
            this.LblNombreAlumno = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelAlumno = new System.Windows.Forms.Panel();
            this.BtnBuscar = new FontAwesome.Sharp.IconButton();
            this.BtnSeleccionarAlumno = new System.Windows.Forms.Button();
            this.gridAlumnos = new System.Windows.Forms.DataGridView();
            this.TxtBuscarAlumno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CboAñoCarrera = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CboCarreras = new System.Windows.Forms.ComboBox();
            this.PanelMaterias = new System.Windows.Forms.Panel();
            this.BtnAgregarTodas = new FontAwesome.Sharp.IconButton();
            this.BtnBuscarMateria = new FontAwesome.Sharp.IconButton();
            this.BtnQuitar = new FontAwesome.Sharp.IconButton();
            this.BtnAgregar = new FontAwesome.Sharp.IconButton();
            this.label6 = new System.Windows.Forms.Label();
            this.GridMateriasInscriptas = new System.Windows.Forms.DataGridView();
            this.GridBuscarMateria = new System.Windows.Forms.DataGridView();
            this.TxtBuscarMateria = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PanelBotones = new System.Windows.Forms.Panel();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnVistaPrevia = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.LblStatusText = new System.Windows.Forms.ToolStripStatusLabel();
            this.ProgresBar = new System.Windows.Forms.ToolStripProgressBar();
            this.BtnQuitarTodas = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.PanelAlumno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridAlumnos)).BeginInit();
            this.PanelMaterias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridMateriasInscriptas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridBuscarMateria)).BeginInit();
            this.PanelBotones.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.lblCicloLectivo);
            this.panel1.Controls.Add(this.cboCicloLectivo);
            this.panel1.Controls.Add(this.LblNombreAlumno);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(807, 46);
            this.panel1.TabIndex = 3;
            // 
            // lblCicloLectivo
            // 
            this.lblCicloLectivo.AutoSize = true;
            this.lblCicloLectivo.Location = new System.Drawing.Point(604, 21);
            this.lblCicloLectivo.Name = "lblCicloLectivo";
            this.lblCicloLectivo.Size = new System.Drawing.Size(75, 15);
            this.lblCicloLectivo.TabIndex = 33;
            this.lblCicloLectivo.Text = "Ciclo Lectivo";
            // 
            // cboCicloLectivo
            // 
            this.cboCicloLectivo.Enabled = false;
            this.cboCicloLectivo.FormattingEnabled = true;
            this.cboCicloLectivo.Location = new System.Drawing.Point(685, 18);
            this.cboCicloLectivo.Name = "cboCicloLectivo";
            this.cboCicloLectivo.Size = new System.Drawing.Size(118, 23);
            this.cboCicloLectivo.TabIndex = 32;
            // 
            // LblNombreAlumno
            // 
            this.LblNombreAlumno.AutoSize = true;
            this.LblNombreAlumno.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblNombreAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblNombreAlumno.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblNombreAlumno.Location = new System.Drawing.Point(244, 9);
            this.LblNombreAlumno.Name = "LblNombreAlumno";
            this.LblNombreAlumno.Size = new System.Drawing.Size(88, 30);
            this.LblNombreAlumno.TabIndex = 2;
            this.LblNombreAlumno.Text = "Alumno";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inscripcion a materias:";
            // 
            // PanelAlumno
            // 
            this.PanelAlumno.Controls.Add(this.BtnBuscar);
            this.PanelAlumno.Controls.Add(this.BtnSeleccionarAlumno);
            this.PanelAlumno.Controls.Add(this.gridAlumnos);
            this.PanelAlumno.Controls.Add(this.TxtBuscarAlumno);
            this.PanelAlumno.Controls.Add(this.label2);
            this.PanelAlumno.Location = new System.Drawing.Point(12, 52);
            this.PanelAlumno.Name = "PanelAlumno";
            this.PanelAlumno.Size = new System.Drawing.Size(783, 139);
            this.PanelAlumno.TabIndex = 25;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.BtnBuscar.IconColor = System.Drawing.Color.Black;
            this.BtnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnBuscar.IconSize = 20;
            this.BtnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBuscar.Location = new System.Drawing.Point(692, 8);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(88, 23);
            this.BtnBuscar.TabIndex = 33;
            this.BtnBuscar.Text = "Buscar ";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // BtnSeleccionarAlumno
            // 
            this.BtnSeleccionarAlumno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSeleccionarAlumno.Location = new System.Drawing.Point(692, 38);
            this.BtnSeleccionarAlumno.Name = "BtnSeleccionarAlumno";
            this.BtnSeleccionarAlumno.Size = new System.Drawing.Size(88, 43);
            this.BtnSeleccionarAlumno.TabIndex = 32;
            this.BtnSeleccionarAlumno.Text = "Seleccionar";
            this.BtnSeleccionarAlumno.UseVisualStyleBackColor = true;
            this.BtnSeleccionarAlumno.Click += new System.EventHandler(this.BtnSeleccionarAlumno_Click);
            // 
            // gridAlumnos
            // 
            this.gridAlumnos.AllowUserToAddRows = false;
            this.gridAlumnos.AllowUserToDeleteRows = false;
            this.gridAlumnos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridAlumnos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAlumnos.Location = new System.Drawing.Point(17, 38);
            this.gridAlumnos.Name = "gridAlumnos";
            this.gridAlumnos.ReadOnly = true;
            this.gridAlumnos.RowHeadersVisible = false;
            this.gridAlumnos.RowTemplate.Height = 25;
            this.gridAlumnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridAlumnos.Size = new System.Drawing.Size(669, 92);
            this.gridAlumnos.TabIndex = 27;
            // 
            // TxtBuscarAlumno
            // 
            this.TxtBuscarAlumno.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtBuscarAlumno.Location = new System.Drawing.Point(107, 9);
            this.TxtBuscarAlumno.Name = "TxtBuscarAlumno";
            this.TxtBuscarAlumno.Size = new System.Drawing.Size(579, 23);
            this.TxtBuscarAlumno.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 15);
            this.label2.TabIndex = 25;
            this.label2.Text = "Buscar alumno";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(352, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 15);
            this.label4.TabIndex = 31;
            this.label4.Text = "Año carrera";
            // 
            // CboAñoCarrera
            // 
            this.CboAñoCarrera.FormattingEnabled = true;
            this.CboAñoCarrera.Location = new System.Drawing.Point(426, 8);
            this.CboAñoCarrera.Name = "CboAñoCarrera";
            this.CboAñoCarrera.Size = new System.Drawing.Size(118, 23);
            this.CboAñoCarrera.TabIndex = 30;
            this.CboAñoCarrera.SelectedValueChanged += new System.EventHandler(this.CboAñoCarrera_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 29;
            this.label3.Text = "Carreras";
            // 
            // CboCarreras
            // 
            this.CboCarreras.FormattingEnabled = true;
            this.CboCarreras.Location = new System.Drawing.Point(108, 8);
            this.CboCarreras.Name = "CboCarreras";
            this.CboCarreras.Size = new System.Drawing.Size(219, 23);
            this.CboCarreras.TabIndex = 28;
            this.CboCarreras.SelectionChangeCommitted += new System.EventHandler(this.CboCarreras_SelectionChangeCommitted);
            // 
            // PanelMaterias
            // 
            this.PanelMaterias.Controls.Add(this.BtnQuitarTodas);
            this.PanelMaterias.Controls.Add(this.BtnAgregarTodas);
            this.PanelMaterias.Controls.Add(this.BtnBuscarMateria);
            this.PanelMaterias.Controls.Add(this.BtnQuitar);
            this.PanelMaterias.Controls.Add(this.label4);
            this.PanelMaterias.Controls.Add(this.BtnAgregar);
            this.PanelMaterias.Controls.Add(this.CboAñoCarrera);
            this.PanelMaterias.Controls.Add(this.label6);
            this.PanelMaterias.Controls.Add(this.label3);
            this.PanelMaterias.Controls.Add(this.CboCarreras);
            this.PanelMaterias.Controls.Add(this.GridMateriasInscriptas);
            this.PanelMaterias.Controls.Add(this.GridBuscarMateria);
            this.PanelMaterias.Controls.Add(this.TxtBuscarMateria);
            this.PanelMaterias.Controls.Add(this.label5);
            this.PanelMaterias.Enabled = false;
            this.PanelMaterias.Location = new System.Drawing.Point(12, 197);
            this.PanelMaterias.Name = "PanelMaterias";
            this.PanelMaterias.Size = new System.Drawing.Size(783, 327);
            this.PanelMaterias.TabIndex = 26;
            // 
            // BtnAgregarTodas
            // 
            this.BtnAgregarTodas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAgregarTodas.IconChar = FontAwesome.Sharp.IconChar.CheckDouble;
            this.BtnAgregarTodas.IconColor = System.Drawing.Color.Black;
            this.BtnAgregarTodas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnAgregarTodas.IconSize = 20;
            this.BtnAgregarTodas.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAgregarTodas.Location = new System.Drawing.Point(692, 129);
            this.BtnAgregarTodas.Name = "BtnAgregarTodas";
            this.BtnAgregarTodas.Size = new System.Drawing.Size(88, 44);
            this.BtnAgregarTodas.TabIndex = 36;
            this.BtnAgregarTodas.Text = "Agregar Todas";
            this.BtnAgregarTodas.UseVisualStyleBackColor = true;
            this.BtnAgregarTodas.Click += new System.EventHandler(this.BtnAgregarTodas_Click);
            // 
            // BtnBuscarMateria
            // 
            this.BtnBuscarMateria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnBuscarMateria.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.BtnBuscarMateria.IconColor = System.Drawing.Color.Black;
            this.BtnBuscarMateria.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnBuscarMateria.IconSize = 20;
            this.BtnBuscarMateria.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBuscarMateria.Location = new System.Drawing.Point(693, 37);
            this.BtnBuscarMateria.Name = "BtnBuscarMateria";
            this.BtnBuscarMateria.Size = new System.Drawing.Size(88, 23);
            this.BtnBuscarMateria.TabIndex = 35;
            this.BtnBuscarMateria.Text = "Buscar ";
            this.BtnBuscarMateria.UseVisualStyleBackColor = true;
            this.BtnBuscarMateria.Click += new System.EventHandler(this.BtnBuscarMateria_Click);
            // 
            // BtnQuitar
            // 
            this.BtnQuitar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnQuitar.IconChar = FontAwesome.Sharp.IconChar.X;
            this.BtnQuitar.IconColor = System.Drawing.Color.Black;
            this.BtnQuitar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnQuitar.IconSize = 20;
            this.BtnQuitar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnQuitar.Location = new System.Drawing.Point(692, 216);
            this.BtnQuitar.Name = "BtnQuitar";
            this.BtnQuitar.Size = new System.Drawing.Size(88, 23);
            this.BtnQuitar.TabIndex = 34;
            this.BtnQuitar.Text = "Quitar";
            this.BtnQuitar.UseVisualStyleBackColor = true;
            this.BtnQuitar.Click += new System.EventHandler(this.BtnQuitar_Click);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAgregar.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.BtnAgregar.IconColor = System.Drawing.Color.Black;
            this.BtnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnAgregar.IconSize = 20;
            this.BtnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAgregar.Location = new System.Drawing.Point(693, 90);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(88, 23);
            this.BtnAgregar.TabIndex = 33;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 15);
            this.label6.TabIndex = 32;
            this.label6.Text = "Materias inscriptas";
            // 
            // GridMateriasInscriptas
            // 
            this.GridMateriasInscriptas.AllowUserToAddRows = false;
            this.GridMateriasInscriptas.AllowUserToDeleteRows = false;
            this.GridMateriasInscriptas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridMateriasInscriptas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridMateriasInscriptas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridMateriasInscriptas.Location = new System.Drawing.Point(17, 194);
            this.GridMateriasInscriptas.Name = "GridMateriasInscriptas";
            this.GridMateriasInscriptas.ReadOnly = true;
            this.GridMateriasInscriptas.RowHeadersVisible = false;
            this.GridMateriasInscriptas.RowTemplate.Height = 25;
            this.GridMateriasInscriptas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridMateriasInscriptas.Size = new System.Drawing.Size(669, 104);
            this.GridMateriasInscriptas.TabIndex = 31;
            // 
            // GridBuscarMateria
            // 
            this.GridBuscarMateria.AllowUserToAddRows = false;
            this.GridBuscarMateria.AllowUserToDeleteRows = false;
            this.GridBuscarMateria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridBuscarMateria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridBuscarMateria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridBuscarMateria.Location = new System.Drawing.Point(18, 66);
            this.GridBuscarMateria.Name = "GridBuscarMateria";
            this.GridBuscarMateria.ReadOnly = true;
            this.GridBuscarMateria.RowHeadersVisible = false;
            this.GridBuscarMateria.RowTemplate.Height = 25;
            this.GridBuscarMateria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridBuscarMateria.Size = new System.Drawing.Size(669, 107);
            this.GridBuscarMateria.TabIndex = 30;
            // 
            // TxtBuscarMateria
            // 
            this.TxtBuscarMateria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtBuscarMateria.Location = new System.Drawing.Point(108, 37);
            this.TxtBuscarMateria.Name = "TxtBuscarMateria";
            this.TxtBuscarMateria.Size = new System.Drawing.Size(579, 23);
            this.TxtBuscarMateria.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 15);
            this.label5.TabIndex = 28;
            this.label5.Text = "Buscar materia";
            // 
            // PanelBotones
            // 
            this.PanelBotones.Controls.Add(this.BtnCancelar);
            this.PanelBotones.Controls.Add(this.BtnVistaPrevia);
            this.PanelBotones.Enabled = false;
            this.PanelBotones.Location = new System.Drawing.Point(12, 530);
            this.PanelBotones.Name = "PanelBotones";
            this.PanelBotones.Size = new System.Drawing.Size(783, 56);
            this.PanelBotones.TabIndex = 27;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancelar.Location = new System.Drawing.Point(415, 14);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(121, 28);
            this.BtnCancelar.TabIndex = 20;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // BtnVistaPrevia
            // 
            this.BtnVistaPrevia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnVistaPrevia.Location = new System.Drawing.Point(191, 14);
            this.BtnVistaPrevia.Name = "BtnVistaPrevia";
            this.BtnVistaPrevia.Size = new System.Drawing.Size(121, 28);
            this.BtnVistaPrevia.TabIndex = 19;
            this.BtnVistaPrevia.Text = "Vista previa";
            this.BtnVistaPrevia.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LblStatusText,
            this.ProgresBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 576);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(807, 22);
            this.statusStrip1.TabIndex = 28;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // LblStatusText
            // 
            this.LblStatusText.Name = "LblStatusText";
            this.LblStatusText.Size = new System.Drawing.Size(0, 17);
            // 
            // ProgresBar
            // 
            this.ProgresBar.Name = "ProgresBar";
            this.ProgresBar.Size = new System.Drawing.Size(100, 16);
            this.ProgresBar.Visible = false;
            // 
            // BtnQuitarTodas
            // 
            this.BtnQuitarTodas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnQuitarTodas.IconChar = FontAwesome.Sharp.IconChar.X;
            this.BtnQuitarTodas.IconColor = System.Drawing.Color.Black;
            this.BtnQuitarTodas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnQuitarTodas.IconSize = 20;
            this.BtnQuitarTodas.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnQuitarTodas.Location = new System.Drawing.Point(692, 254);
            this.BtnQuitarTodas.Name = "BtnQuitarTodas";
            this.BtnQuitarTodas.Size = new System.Drawing.Size(88, 44);
            this.BtnQuitarTodas.TabIndex = 37;
            this.BtnQuitarTodas.Text = "Quitar    todas";
            this.BtnQuitarTodas.UseVisualStyleBackColor = true;
            this.BtnQuitarTodas.Click += new System.EventHandler(this.BtnQuitarTodas_Click);
            // 
            // InscripcionView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 598);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.PanelBotones);
            this.Controls.Add(this.PanelMaterias);
            this.Controls.Add(this.PanelAlumno);
            this.Controls.Add(this.panel1);
            this.Name = "InscripcionView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InscripcionView";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.PanelAlumno.ResumeLayout(false);
            this.PanelAlumno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridAlumnos)).EndInit();
            this.PanelMaterias.ResumeLayout(false);
            this.PanelMaterias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridMateriasInscriptas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridBuscarMateria)).EndInit();
            this.PanelBotones.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PanelAlumno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CboAñoCarrera;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CboCarreras;
        private System.Windows.Forms.DataGridView gridAlumnos;
        private System.Windows.Forms.TextBox TxtBuscarAlumno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel PanelMaterias;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView GridMateriasInscriptas;
        private System.Windows.Forms.DataGridView GridBuscarMateria;
        private System.Windows.Forms.TextBox TxtBuscarMateria;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel PanelBotones;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnVistaPrevia;
        private System.Windows.Forms.Label LblNombreAlumno;
        private System.Windows.Forms.Button BtnSeleccionarAlumno;
        private FontAwesome.Sharp.IconButton BtnQuitar;
        private FontAwesome.Sharp.IconButton BtnAgregar;
        private FontAwesome.Sharp.IconButton BtnBuscar;
        private FontAwesome.Sharp.IconButton BtnBuscarMateria;
        private System.Windows.Forms.Label lblCicloLectivo;
        private System.Windows.Forms.ComboBox cboCicloLectivo;
        private FontAwesome.Sharp.IconButton BtnAgregarTodas;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel LblStatusText;
        private System.Windows.Forms.ToolStripProgressBar ProgresBar;
        private FontAwesome.Sharp.IconButton BtnQuitarTodas;
    }
}