
namespace TRABAJO_PROGRAMACIÓN
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.button1 = new System.Windows.Forms.Button();
            this.lblPrimerNombre = new System.Windows.Forms.Label();
            this.txtPrimerNombre = new System.Windows.Forms.TextBox();
            this.lblSegundoNombre = new System.Windows.Forms.Label();
            this.txtSegundoNombre = new System.Windows.Forms.TextBox();
            this.lblPrimerApellido = new System.Windows.Forms.Label();
            this.txtPrimerApellido = new System.Windows.Forms.TextBox();
            this.lblSegundoApellido = new System.Windows.Forms.Label();
            this.txtSegundoApellido = new System.Windows.Forms.TextBox();
            this.lblTipoIdentificacion = new System.Windows.Forms.Label();
            this.cboTipoDocumento = new System.Windows.Forms.ComboBox();
            this.lblNumeroIdentificacion = new System.Windows.Forms.Label();
            this.txtNumeroIdentificacion = new System.Windows.Forms.TextBox();
            this.lblGenero = new System.Windows.Forms.Label();
            this.rdbFemenino = new System.Windows.Forms.RadioButton();
            this.rdbMasculino = new System.Windows.Forms.RadioButton();
            this.lblFechaDeNacimiento = new System.Windows.Forms.Label();
            this.dtpFechaDeNacimiento = new System.Windows.Forms.DateTimePicker();
            this.lblDireccionDeResidencia = new System.Windows.Forms.Label();
            this.txtDireccionDeResidencia = new System.Windows.Forms.TextBox();
            this.lblTelefonoContacto = new System.Windows.Forms.Label();
            this.txtTelefonoContacto = new System.Windows.Forms.TextBox();
            this.lblNivelEscolaridad = new System.Windows.Forms.Label();
            this.cboNivelEscolaridad = new System.Windows.Forms.ComboBox();
            this.lblEPS = new System.Windows.Forms.Label();
            this.txtEPS = new System.Windows.Forms.TextBox();
            this.lblRegimen = new System.Windows.Forms.Label();
            this.rdbContributivo = new System.Windows.Forms.RadioButton();
            this.rdbSubsidiado = new System.Windows.Forms.RadioButton();
            this.lblCorreoElectrónico = new System.Windows.Forms.Label();
            this.txtCorreoElectronico = new System.Windows.Forms.TextBox();
            this.lblContactoEnCasoDeEmergencia = new System.Windows.Forms.Label();
            this.txtContactoEnCasoDeEmergencia = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PowderBlue;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(748, 773);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(429, 57);
            this.button1.TabIndex = 0;
            this.button1.Text = "REGRESAR AL MENÚ PRINCIPAL";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblPrimerNombre
            // 
            this.lblPrimerNombre.AutoSize = true;
            this.lblPrimerNombre.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrimerNombre.Location = new System.Drawing.Point(82, 24);
            this.lblPrimerNombre.Name = "lblPrimerNombre";
            this.lblPrimerNombre.Size = new System.Drawing.Size(132, 19);
            this.lblPrimerNombre.TabIndex = 1;
            this.lblPrimerNombre.Text = "Primer Nombre";
            // 
            // txtPrimerNombre
            // 
            this.txtPrimerNombre.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrimerNombre.Location = new System.Drawing.Point(273, 21);
            this.txtPrimerNombre.Name = "txtPrimerNombre";
            this.txtPrimerNombre.ShortcutsEnabled = false;
            this.txtPrimerNombre.Size = new System.Drawing.Size(606, 26);
            this.txtPrimerNombre.TabIndex = 2;
            this.txtPrimerNombre.TextChanged += new System.EventHandler(this.txtPrimerNombre_TextChanged);
            this.txtPrimerNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrimerNombre_KeyPress);
            // 
            // lblSegundoNombre
            // 
            this.lblSegundoNombre.AutoSize = true;
            this.lblSegundoNombre.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSegundoNombre.Location = new System.Drawing.Point(82, 66);
            this.lblSegundoNombre.Name = "lblSegundoNombre";
            this.lblSegundoNombre.Size = new System.Drawing.Size(154, 19);
            this.lblSegundoNombre.TabIndex = 3;
            this.lblSegundoNombre.Text = "Segundo Nombre";
            this.lblSegundoNombre.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtSegundoNombre
            // 
            this.txtSegundoNombre.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSegundoNombre.Location = new System.Drawing.Point(273, 66);
            this.txtSegundoNombre.Name = "txtSegundoNombre";
            this.txtSegundoNombre.ShortcutsEnabled = false;
            this.txtSegundoNombre.Size = new System.Drawing.Size(606, 26);
            this.txtSegundoNombre.TabIndex = 4;
            this.txtSegundoNombre.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.txtSegundoNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSegundoNombre_KeyPress);
            // 
            // lblPrimerApellido
            // 
            this.lblPrimerApellido.AutoSize = true;
            this.lblPrimerApellido.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrimerApellido.Location = new System.Drawing.Point(82, 122);
            this.lblPrimerApellido.Name = "lblPrimerApellido";
            this.lblPrimerApellido.Size = new System.Drawing.Size(134, 19);
            this.lblPrimerApellido.TabIndex = 5;
            this.lblPrimerApellido.Text = "Primer Apellido";
            // 
            // txtPrimerApellido
            // 
            this.txtPrimerApellido.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrimerApellido.Location = new System.Drawing.Point(273, 119);
            this.txtPrimerApellido.Name = "txtPrimerApellido";
            this.txtPrimerApellido.ShortcutsEnabled = false;
            this.txtPrimerApellido.Size = new System.Drawing.Size(606, 26);
            this.txtPrimerApellido.TabIndex = 6;
            this.txtPrimerApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrimerApellido_KeyPress);
            // 
            // lblSegundoApellido
            // 
            this.lblSegundoApellido.AutoSize = true;
            this.lblSegundoApellido.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSegundoApellido.Location = new System.Drawing.Point(82, 177);
            this.lblSegundoApellido.Name = "lblSegundoApellido";
            this.lblSegundoApellido.Size = new System.Drawing.Size(156, 19);
            this.lblSegundoApellido.TabIndex = 7;
            this.lblSegundoApellido.Text = "Segundo Apellido";
            // 
            // txtSegundoApellido
            // 
            this.txtSegundoApellido.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSegundoApellido.Location = new System.Drawing.Point(273, 177);
            this.txtSegundoApellido.Name = "txtSegundoApellido";
            this.txtSegundoApellido.ShortcutsEnabled = false;
            this.txtSegundoApellido.Size = new System.Drawing.Size(606, 26);
            this.txtSegundoApellido.TabIndex = 8;
            this.txtSegundoApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSegundoApellido_KeyPress);
            // 
            // lblTipoIdentificacion
            // 
            this.lblTipoIdentificacion.AutoSize = true;
            this.lblTipoIdentificacion.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoIdentificacion.Location = new System.Drawing.Point(82, 233);
            this.lblTipoIdentificacion.Name = "lblTipoIdentificacion";
            this.lblTipoIdentificacion.Size = new System.Drawing.Size(159, 19);
            this.lblTipoIdentificacion.TabIndex = 9;
            this.lblTipoIdentificacion.Text = "Tipo Identificación";
            // 
            // cboTipoDocumento
            // 
            this.cboTipoDocumento.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipoDocumento.FormattingEnabled = true;
            this.cboTipoDocumento.Location = new System.Drawing.Point(273, 230);
            this.cboTipoDocumento.Name = "cboTipoDocumento";
            this.cboTipoDocumento.Size = new System.Drawing.Size(606, 28);
            this.cboTipoDocumento.TabIndex = 10;
            this.cboTipoDocumento.SelectedIndexChanged += new System.EventHandler(this.cboTipoDocumento_SelectedIndexChanged);
            // 
            // lblNumeroIdentificacion
            // 
            this.lblNumeroIdentificacion.AutoSize = true;
            this.lblNumeroIdentificacion.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroIdentificacion.Location = new System.Drawing.Point(82, 282);
            this.lblNumeroIdentificacion.Name = "lblNumeroIdentificacion";
            this.lblNumeroIdentificacion.Size = new System.Drawing.Size(219, 19);
            this.lblNumeroIdentificacion.TabIndex = 11;
            this.lblNumeroIdentificacion.Text = "Número de Identificación";
            // 
            // txtNumeroIdentificacion
            // 
            this.txtNumeroIdentificacion.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroIdentificacion.Location = new System.Drawing.Point(337, 279);
            this.txtNumeroIdentificacion.Name = "txtNumeroIdentificacion";
            this.txtNumeroIdentificacion.ShortcutsEnabled = false;
            this.txtNumeroIdentificacion.Size = new System.Drawing.Size(542, 26);
            this.txtNumeroIdentificacion.TabIndex = 12;
            this.txtNumeroIdentificacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroIdentificacion_KeyPress);
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenero.Location = new System.Drawing.Point(82, 328);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(71, 19);
            this.lblGenero.TabIndex = 13;
            this.lblGenero.Text = "Género";
            // 
            // rdbFemenino
            // 
            this.rdbFemenino.AutoSize = true;
            this.rdbFemenino.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbFemenino.Location = new System.Drawing.Point(198, 329);
            this.rdbFemenino.Name = "rdbFemenino";
            this.rdbFemenino.Size = new System.Drawing.Size(101, 24);
            this.rdbFemenino.TabIndex = 14;
            this.rdbFemenino.TabStop = true;
            this.rdbFemenino.Text = "Femenino";
            this.rdbFemenino.UseVisualStyleBackColor = true;
            // 
            // rdbMasculino
            // 
            this.rdbMasculino.AutoSize = true;
            this.rdbMasculino.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMasculino.Location = new System.Drawing.Point(337, 329);
            this.rdbMasculino.Name = "rdbMasculino";
            this.rdbMasculino.Size = new System.Drawing.Size(105, 24);
            this.rdbMasculino.TabIndex = 15;
            this.rdbMasculino.TabStop = true;
            this.rdbMasculino.Text = "Masculino";
            this.rdbMasculino.UseVisualStyleBackColor = true;
            // 
            // lblFechaDeNacimiento
            // 
            this.lblFechaDeNacimiento.AutoSize = true;
            this.lblFechaDeNacimiento.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaDeNacimiento.Location = new System.Drawing.Point(82, 380);
            this.lblFechaDeNacimiento.Name = "lblFechaDeNacimiento";
            this.lblFechaDeNacimiento.Size = new System.Drawing.Size(187, 19);
            this.lblFechaDeNacimiento.TabIndex = 16;
            this.lblFechaDeNacimiento.Text = "Fecha de Nacimiento";
            // 
            // dtpFechaDeNacimiento
            // 
            this.dtpFechaDeNacimiento.CalendarFont = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaDeNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDeNacimiento.Location = new System.Drawing.Point(286, 380);
            this.dtpFechaDeNacimiento.Name = "dtpFechaDeNacimiento";
            this.dtpFechaDeNacimiento.Size = new System.Drawing.Size(200, 22);
            this.dtpFechaDeNacimiento.TabIndex = 17;
            // 
            // lblDireccionDeResidencia
            // 
            this.lblDireccionDeResidencia.AutoSize = true;
            this.lblDireccionDeResidencia.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccionDeResidencia.Location = new System.Drawing.Point(82, 430);
            this.lblDireccionDeResidencia.Name = "lblDireccionDeResidencia";
            this.lblDireccionDeResidencia.Size = new System.Drawing.Size(211, 19);
            this.lblDireccionDeResidencia.TabIndex = 18;
            this.lblDireccionDeResidencia.Text = "Dirección de Residencia";
            // 
            // txtDireccionDeResidencia
            // 
            this.txtDireccionDeResidencia.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccionDeResidencia.Location = new System.Drawing.Point(337, 427);
            this.txtDireccionDeResidencia.Name = "txtDireccionDeResidencia";
            this.txtDireccionDeResidencia.ShortcutsEnabled = false;
            this.txtDireccionDeResidencia.Size = new System.Drawing.Size(547, 26);
            this.txtDireccionDeResidencia.TabIndex = 19;
            // 
            // lblTelefonoContacto
            // 
            this.lblTelefonoContacto.AutoSize = true;
            this.lblTelefonoContacto.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefonoContacto.Location = new System.Drawing.Point(82, 479);
            this.lblTelefonoContacto.Name = "lblTelefonoContacto";
            this.lblTelefonoContacto.Size = new System.Drawing.Size(159, 19);
            this.lblTelefonoContacto.TabIndex = 20;
            this.lblTelefonoContacto.Text = "Teléfono Contacto";
            // 
            // txtTelefonoContacto
            // 
            this.txtTelefonoContacto.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefonoContacto.Location = new System.Drawing.Point(273, 479);
            this.txtTelefonoContacto.Name = "txtTelefonoContacto";
            this.txtTelefonoContacto.ShortcutsEnabled = false;
            this.txtTelefonoContacto.Size = new System.Drawing.Size(606, 26);
            this.txtTelefonoContacto.TabIndex = 21;
            this.txtTelefonoContacto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textTelefonoContacto_KeyPress);
            // 
            // lblNivelEscolaridad
            // 
            this.lblNivelEscolaridad.AutoSize = true;
            this.lblNivelEscolaridad.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNivelEscolaridad.Location = new System.Drawing.Point(84, 529);
            this.lblNivelEscolaridad.Name = "lblNivelEscolaridad";
            this.lblNivelEscolaridad.Size = new System.Drawing.Size(152, 19);
            this.lblNivelEscolaridad.TabIndex = 22;
            this.lblNivelEscolaridad.Text = "Nivel Escolaridad";
            // 
            // cboNivelEscolaridad
            // 
            this.cboNivelEscolaridad.FormattingEnabled = true;
            this.cboNivelEscolaridad.Location = new System.Drawing.Point(273, 529);
            this.cboNivelEscolaridad.Name = "cboNivelEscolaridad";
            this.cboNivelEscolaridad.Size = new System.Drawing.Size(606, 24);
            this.cboNivelEscolaridad.TabIndex = 23;
            // 
            // lblEPS
            // 
            this.lblEPS.AutoSize = true;
            this.lblEPS.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEPS.Location = new System.Drawing.Point(84, 576);
            this.lblEPS.Name = "lblEPS";
            this.lblEPS.Size = new System.Drawing.Size(37, 19);
            this.lblEPS.TabIndex = 24;
            this.lblEPS.Text = "EPS";
            // 
            // txtEPS
            // 
            this.txtEPS.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEPS.Location = new System.Drawing.Point(273, 576);
            this.txtEPS.Name = "txtEPS";
            this.txtEPS.ShortcutsEnabled = false;
            this.txtEPS.Size = new System.Drawing.Size(606, 26);
            this.txtEPS.TabIndex = 25;
            this.txtEPS.TextChanged += new System.EventHandler(this.textEPS_TextChanged);
            this.txtEPS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textEPS_KeyPress);
            // 
            // lblRegimen
            // 
            this.lblRegimen.AutoSize = true;
            this.lblRegimen.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegimen.Location = new System.Drawing.Point(84, 618);
            this.lblRegimen.Name = "lblRegimen";
            this.lblRegimen.Size = new System.Drawing.Size(82, 19);
            this.lblRegimen.TabIndex = 26;
            this.lblRegimen.Text = "Régimen";
            // 
            // rdbContributivo
            // 
            this.rdbContributivo.AutoSize = true;
            this.rdbContributivo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbContributivo.Location = new System.Drawing.Point(198, 619);
            this.rdbContributivo.Name = "rdbContributivo";
            this.rdbContributivo.Size = new System.Drawing.Size(121, 24);
            this.rdbContributivo.TabIndex = 27;
            this.rdbContributivo.TabStop = true;
            this.rdbContributivo.Text = "Contributivo";
            this.rdbContributivo.UseVisualStyleBackColor = true;
            // 
            // rdbSubsidiado
            // 
            this.rdbSubsidiado.AutoSize = true;
            this.rdbSubsidiado.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbSubsidiado.Location = new System.Drawing.Point(337, 619);
            this.rdbSubsidiado.Name = "rdbSubsidiado";
            this.rdbSubsidiado.Size = new System.Drawing.Size(108, 24);
            this.rdbSubsidiado.TabIndex = 28;
            this.rdbSubsidiado.TabStop = true;
            this.rdbSubsidiado.Text = "Subsidiado";
            this.rdbSubsidiado.UseVisualStyleBackColor = true;
            // 
            // lblCorreoElectrónico
            // 
            this.lblCorreoElectrónico.AutoSize = true;
            this.lblCorreoElectrónico.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreoElectrónico.Location = new System.Drawing.Point(84, 666);
            this.lblCorreoElectrónico.Name = "lblCorreoElectrónico";
            this.lblCorreoElectrónico.Size = new System.Drawing.Size(161, 19);
            this.lblCorreoElectrónico.TabIndex = 29;
            this.lblCorreoElectrónico.Text = "Correo Electrónico";
            // 
            // txtCorreoElectronico
            // 
            this.txtCorreoElectronico.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreoElectronico.Location = new System.Drawing.Point(273, 659);
            this.txtCorreoElectronico.Name = "txtCorreoElectronico";
            this.txtCorreoElectronico.ShortcutsEnabled = false;
            this.txtCorreoElectronico.Size = new System.Drawing.Size(606, 26);
            this.txtCorreoElectronico.TabIndex = 30;
            // 
            // lblContactoEnCasoDeEmergencia
            // 
            this.lblContactoEnCasoDeEmergencia.AutoSize = true;
            this.lblContactoEnCasoDeEmergencia.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactoEnCasoDeEmergencia.Location = new System.Drawing.Point(86, 705);
            this.lblContactoEnCasoDeEmergencia.Name = "lblContactoEnCasoDeEmergencia";
            this.lblContactoEnCasoDeEmergencia.Size = new System.Drawing.Size(289, 19);
            this.lblContactoEnCasoDeEmergencia.TabIndex = 31;
            this.lblContactoEnCasoDeEmergencia.Text = "Contacto en caso de emergencia";
            // 
            // txtContactoEnCasoDeEmergencia
            // 
            this.txtContactoEnCasoDeEmergencia.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactoEnCasoDeEmergencia.Location = new System.Drawing.Point(381, 705);
            this.txtContactoEnCasoDeEmergencia.Name = "txtContactoEnCasoDeEmergencia";
            this.txtContactoEnCasoDeEmergencia.ShortcutsEnabled = false;
            this.txtContactoEnCasoDeEmergencia.Size = new System.Drawing.Size(498, 26);
            this.txtContactoEnCasoDeEmergencia.TabIndex = 32;
            this.txtContactoEnCasoDeEmergencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContactoEnCasoDeEmergencia_KeyPress);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.LightBlue;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(256, 780);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(154, 42);
            this.btnGuardar.TabIndex = 33;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.LightBlue;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(486, 780);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(154, 42);
            this.btnCancelar.TabIndex = 34;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1216, 865);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtContactoEnCasoDeEmergencia);
            this.Controls.Add(this.lblContactoEnCasoDeEmergencia);
            this.Controls.Add(this.txtCorreoElectronico);
            this.Controls.Add(this.lblCorreoElectrónico);
            this.Controls.Add(this.rdbSubsidiado);
            this.Controls.Add(this.rdbContributivo);
            this.Controls.Add(this.lblRegimen);
            this.Controls.Add(this.txtEPS);
            this.Controls.Add(this.lblEPS);
            this.Controls.Add(this.cboNivelEscolaridad);
            this.Controls.Add(this.lblNivelEscolaridad);
            this.Controls.Add(this.txtTelefonoContacto);
            this.Controls.Add(this.lblTelefonoContacto);
            this.Controls.Add(this.txtDireccionDeResidencia);
            this.Controls.Add(this.lblDireccionDeResidencia);
            this.Controls.Add(this.dtpFechaDeNacimiento);
            this.Controls.Add(this.lblFechaDeNacimiento);
            this.Controls.Add(this.rdbMasculino);
            this.Controls.Add(this.rdbFemenino);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.txtNumeroIdentificacion);
            this.Controls.Add(this.lblNumeroIdentificacion);
            this.Controls.Add(this.cboTipoDocumento);
            this.Controls.Add(this.lblTipoIdentificacion);
            this.Controls.Add(this.txtSegundoApellido);
            this.Controls.Add(this.lblSegundoApellido);
            this.Controls.Add(this.txtPrimerApellido);
            this.Controls.Add(this.lblPrimerApellido);
            this.Controls.Add(this.txtSegundoNombre);
            this.Controls.Add(this.lblSegundoNombre);
            this.Controls.Add(this.txtPrimerNombre);
            this.Controls.Add(this.lblPrimerNombre);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form3";
            this.Text = "Datos Personales";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblPrimerNombre;
        private System.Windows.Forms.TextBox txtPrimerNombre;
        private System.Windows.Forms.Label lblSegundoNombre;
        private System.Windows.Forms.TextBox txtSegundoNombre;
        private System.Windows.Forms.Label lblPrimerApellido;
        private System.Windows.Forms.TextBox txtPrimerApellido;
        private System.Windows.Forms.Label lblSegundoApellido;
        private System.Windows.Forms.TextBox txtSegundoApellido;
        private System.Windows.Forms.Label lblTipoIdentificacion;
        private System.Windows.Forms.ComboBox cboTipoDocumento;
        private System.Windows.Forms.Label lblNumeroIdentificacion;
        private System.Windows.Forms.TextBox txtNumeroIdentificacion;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.RadioButton rdbFemenino;
        private System.Windows.Forms.RadioButton rdbMasculino;
        private System.Windows.Forms.Label lblFechaDeNacimiento;
        private System.Windows.Forms.DateTimePicker dtpFechaDeNacimiento;
        private System.Windows.Forms.Label lblDireccionDeResidencia;
        private System.Windows.Forms.TextBox txtDireccionDeResidencia;
        private System.Windows.Forms.Label lblTelefonoContacto;
        private System.Windows.Forms.TextBox txtTelefonoContacto;
        private System.Windows.Forms.Label lblNivelEscolaridad;
        private System.Windows.Forms.ComboBox cboNivelEscolaridad;
        private System.Windows.Forms.Label lblEPS;
        private System.Windows.Forms.TextBox txtEPS;
        private System.Windows.Forms.Label lblRegimen;
        private System.Windows.Forms.RadioButton rdbContributivo;
        private System.Windows.Forms.RadioButton rdbSubsidiado;
        private System.Windows.Forms.Label lblCorreoElectrónico;
        private System.Windows.Forms.TextBox txtCorreoElectronico;
        private System.Windows.Forms.Label lblContactoEnCasoDeEmergencia;
        private System.Windows.Forms.TextBox txtContactoEnCasoDeEmergencia;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}