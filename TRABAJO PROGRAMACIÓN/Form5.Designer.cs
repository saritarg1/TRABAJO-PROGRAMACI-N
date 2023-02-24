
namespace TRABAJO_PROGRAMACIÓN
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.lblNombreProfesional = new System.Windows.Forms.Label();
            this.lblFechaPrescripcion = new System.Windows.Forms.Label();
            this.lblNumeroOrden = new System.Windows.Forms.Label();
            this.lblVigenciaPrescipción = new System.Windows.Forms.Label();
            this.lblCantidadTotal = new System.Windows.Forms.Label();
            this.lblPeriodoDuracion = new System.Windows.Forms.Label();
            this.lblFormaFarmaceutica = new System.Windows.Forms.Label();
            this.lblNombreMedicamento = new System.Windows.Forms.Label();
            this.lblTipoMedicamentos = new System.Windows.Forms.Label();
            this.txtNombreProfesional = new System.Windows.Forms.TextBox();
            this.dtpFechaPrescripcion = new System.Windows.Forms.DateTimePicker();
            this.txtNumeroOrden = new System.Windows.Forms.TextBox();
            this.txtCantidadTotal = new System.Windows.Forms.TextBox();
            this.txtPeriodoDuracion = new System.Windows.Forms.TextBox();
            this.txtNombreMedicamento = new System.Windows.Forms.TextBox();
            this.dtpVigenciaPrescripcion = new System.Windows.Forms.DateTimePicker();
            this.cboTipoMedicamentos = new System.Windows.Forms.ComboBox();
            this.cboFormaFarmaceutica = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblViaAdministracion = new System.Windows.Forms.Label();
            this.cboViaAdministracion = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnConfirmarRegistro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombreProfesional
            // 
            this.lblNombreProfesional.AutoSize = true;
            this.lblNombreProfesional.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreProfesional.Location = new System.Drawing.Point(11, 29);
            this.lblNombreProfesional.Name = "lblNombreProfesional";
            this.lblNombreProfesional.Size = new System.Drawing.Size(398, 19);
            this.lblNombreProfesional.TabIndex = 2;
            this.lblNombreProfesional.Text = "Nombre del Profesional de Salud que prescribe";
            // 
            // lblFechaPrescripcion
            // 
            this.lblFechaPrescripcion.AutoSize = true;
            this.lblFechaPrescripcion.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaPrescripcion.Location = new System.Drawing.Point(11, 59);
            this.lblFechaPrescripcion.Name = "lblFechaPrescripcion";
            this.lblFechaPrescripcion.Size = new System.Drawing.Size(193, 19);
            this.lblFechaPrescripcion.TabIndex = 3;
            this.lblFechaPrescripcion.Text = "Fecha de Prescripción";
            // 
            // lblNumeroOrden
            // 
            this.lblNumeroOrden.AutoSize = true;
            this.lblNumeroOrden.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroOrden.Location = new System.Drawing.Point(11, 92);
            this.lblNumeroOrden.Name = "lblNumeroOrden";
            this.lblNumeroOrden.Size = new System.Drawing.Size(158, 19);
            this.lblNumeroOrden.TabIndex = 4;
            this.lblNumeroOrden.Text = "Numero de Orden";
            // 
            // lblVigenciaPrescipción
            // 
            this.lblVigenciaPrescipción.AutoSize = true;
            this.lblVigenciaPrescipción.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVigenciaPrescipción.Location = new System.Drawing.Point(11, 336);
            this.lblVigenciaPrescipción.Name = "lblVigenciaPrescipción";
            this.lblVigenciaPrescipción.Size = new System.Drawing.Size(236, 19);
            this.lblVigenciaPrescipción.TabIndex = 7;
            this.lblVigenciaPrescipción.Text = "Vigencia de la Prescripción";
            // 
            // lblCantidadTotal
            // 
            this.lblCantidadTotal.AutoSize = true;
            this.lblCantidadTotal.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadTotal.Location = new System.Drawing.Point(11, 294);
            this.lblCantidadTotal.Name = "lblCantidadTotal";
            this.lblCantidadTotal.Size = new System.Drawing.Size(360, 19);
            this.lblCantidadTotal.TabIndex = 8;
            this.lblCantidadTotal.Text = "Cantidad Total de Unidades Farmacéuticas";
            // 
            // lblPeriodoDuracion
            // 
            this.lblPeriodoDuracion.AutoSize = true;
            this.lblPeriodoDuracion.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeriodoDuracion.Location = new System.Drawing.Point(11, 216);
            this.lblPeriodoDuracion.Name = "lblPeriodoDuracion";
            this.lblPeriodoDuracion.Size = new System.Drawing.Size(308, 19);
            this.lblPeriodoDuracion.TabIndex = 9;
            this.lblPeriodoDuracion.Text = "Periodo de Duración del Tratamiento";
            // 
            // lblFormaFarmaceutica
            // 
            this.lblFormaFarmaceutica.AutoSize = true;
            this.lblFormaFarmaceutica.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormaFarmaceutica.Location = new System.Drawing.Point(11, 185);
            this.lblFormaFarmaceutica.Name = "lblFormaFarmaceutica";
            this.lblFormaFarmaceutica.Size = new System.Drawing.Size(178, 19);
            this.lblFormaFarmaceutica.TabIndex = 10;
            this.lblFormaFarmaceutica.Text = "Forma Farmacéutica";
            this.lblFormaFarmaceutica.Click += new System.EventHandler(this.label7_Click);
            // 
            // lblNombreMedicamento
            // 
            this.lblNombreMedicamento.AutoSize = true;
            this.lblNombreMedicamento.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreMedicamento.Location = new System.Drawing.Point(11, 155);
            this.lblNombreMedicamento.Name = "lblNombreMedicamento";
            this.lblNombreMedicamento.Size = new System.Drawing.Size(227, 19);
            this.lblNombreMedicamento.TabIndex = 11;
            this.lblNombreMedicamento.Text = "Nombre del Medicamento";
            // 
            // lblTipoMedicamentos
            // 
            this.lblTipoMedicamentos.AutoSize = true;
            this.lblTipoMedicamentos.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoMedicamentos.Location = new System.Drawing.Point(11, 122);
            this.lblTipoMedicamentos.Name = "lblTipoMedicamentos";
            this.lblTipoMedicamentos.Size = new System.Drawing.Size(197, 19);
            this.lblTipoMedicamentos.TabIndex = 12;
            this.lblTipoMedicamentos.Text = "Tipo de Medicamentos";
            // 
            // txtNombreProfesional
            // 
            this.txtNombreProfesional.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreProfesional.Location = new System.Drawing.Point(460, 28);
            this.txtNombreProfesional.Name = "txtNombreProfesional";
            this.txtNombreProfesional.ShortcutsEnabled = false;
            this.txtNombreProfesional.Size = new System.Drawing.Size(606, 26);
            this.txtNombreProfesional.TabIndex = 13;
            this.txtNombreProfesional.TextChanged += new System.EventHandler(this.txtNombreProfesional_TextChanged);
            this.txtNombreProfesional.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreProfesional_KeyPress);
            // 
            // dtpFechaPrescripcion
            // 
            this.dtpFechaPrescripcion.CalendarFont = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaPrescripcion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaPrescripcion.Location = new System.Drawing.Point(460, 59);
            this.dtpFechaPrescripcion.Name = "dtpFechaPrescripcion";
            this.dtpFechaPrescripcion.Size = new System.Drawing.Size(270, 22);
            this.dtpFechaPrescripcion.TabIndex = 18;
            // 
            // txtNumeroOrden
            // 
            this.txtNumeroOrden.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroOrden.Location = new System.Drawing.Point(460, 86);
            this.txtNumeroOrden.Name = "txtNumeroOrden";
            this.txtNumeroOrden.ShortcutsEnabled = false;
            this.txtNumeroOrden.Size = new System.Drawing.Size(606, 26);
            this.txtNumeroOrden.TabIndex = 19;
            this.txtNumeroOrden.TextChanged += new System.EventHandler(this.txtNumeroOrden_TextChanged);
            this.txtNumeroOrden.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroOrden_KeyPress);
            // 
            // txtCantidadTotal
            // 
            this.txtCantidadTotal.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadTotal.Location = new System.Drawing.Point(460, 290);
            this.txtCantidadTotal.Name = "txtCantidadTotal";
            this.txtCantidadTotal.ShortcutsEnabled = false;
            this.txtCantidadTotal.Size = new System.Drawing.Size(606, 26);
            this.txtCantidadTotal.TabIndex = 22;
            this.txtCantidadTotal.TextChanged += new System.EventHandler(this.txtCantidadTotal_TextChanged);
            this.txtCantidadTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidadTotal_KeyPress);
            // 
            // txtPeriodoDuracion
            // 
            this.txtPeriodoDuracion.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeriodoDuracion.Location = new System.Drawing.Point(460, 215);
            this.txtPeriodoDuracion.Name = "txtPeriodoDuracion";
            this.txtPeriodoDuracion.ShortcutsEnabled = false;
            this.txtPeriodoDuracion.Size = new System.Drawing.Size(606, 26);
            this.txtPeriodoDuracion.TabIndex = 23;
            this.txtPeriodoDuracion.TextChanged += new System.EventHandler(this.txtPeriodoDuracion_TextChanged);
            this.txtPeriodoDuracion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPeriodoDuracion_KeyPress);
            // 
            // txtNombreMedicamento
            // 
            this.txtNombreMedicamento.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreMedicamento.Location = new System.Drawing.Point(460, 151);
            this.txtNombreMedicamento.Name = "txtNombreMedicamento";
            this.txtNombreMedicamento.ShortcutsEnabled = false;
            this.txtNombreMedicamento.Size = new System.Drawing.Size(606, 26);
            this.txtNombreMedicamento.TabIndex = 24;
            this.txtNombreMedicamento.TextChanged += new System.EventHandler(this.txtNombreMedicamento_TextChanged);
            this.txtNombreMedicamento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreMedicamento_KeyPress);
            // 
            // dtpVigenciaPrescripcion
            // 
            this.dtpVigenciaPrescripcion.CalendarFont = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpVigenciaPrescripcion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVigenciaPrescripcion.Location = new System.Drawing.Point(460, 334);
            this.dtpVigenciaPrescripcion.Name = "dtpVigenciaPrescripcion";
            this.dtpVigenciaPrescripcion.Size = new System.Drawing.Size(270, 22);
            this.dtpVigenciaPrescripcion.TabIndex = 25;
            // 
            // cboTipoMedicamentos
            // 
            this.cboTipoMedicamentos.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipoMedicamentos.FormattingEnabled = true;
            this.cboTipoMedicamentos.Items.AddRange(new object[] {
            "Excipientes",
            "Analgésicos",
            "Antiinflamatorios",
            "Antipiréticos",
            "Laxantes y antidiarreicos",
            "Antiinfecciosos",
            "Antitusivos y mucolíticos"});
            this.cboTipoMedicamentos.Location = new System.Drawing.Point(460, 122);
            this.cboTipoMedicamentos.Name = "cboTipoMedicamentos";
            this.cboTipoMedicamentos.Size = new System.Drawing.Size(606, 28);
            this.cboTipoMedicamentos.TabIndex = 26;
            this.cboTipoMedicamentos.SelectedIndexChanged += new System.EventHandler(this.cboTipoMedicamentos_SelectedIndexChanged);
            // 
            // cboFormaFarmaceutica
            // 
            this.cboFormaFarmaceutica.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFormaFarmaceutica.FormattingEnabled = true;
            this.cboFormaFarmaceutica.Items.AddRange(new object[] {
            "Comprimidos",
            "Grageas",
            "Cápsulas",
            "Polvos",
            "Píldoras ",
            "Supositorios"});
            this.cboFormaFarmaceutica.Location = new System.Drawing.Point(460, 182);
            this.cboFormaFarmaceutica.Name = "cboFormaFarmaceutica";
            this.cboFormaFarmaceutica.Size = new System.Drawing.Size(606, 28);
            this.cboFormaFarmaceutica.TabIndex = 27;
            this.cboFormaFarmaceutica.SelectedIndexChanged += new System.EventHandler(this.cboFormaFarmaceutica_SelectedIndexChanged);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.LightBlue;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(131, 425);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(154, 42);
            this.btnGuardar.TabIndex = 34;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.LightBlue;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(444, 458);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(154, 42);
            this.btnCancelar.TabIndex = 35;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.PowderBlue;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(689, 450);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(429, 57);
            this.button2.TabIndex = 36;
            this.button2.Text = "REGRESAR AL MENÚ PRINCIPAL";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblViaAdministracion
            // 
            this.lblViaAdministracion.AutoSize = true;
            this.lblViaAdministracion.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViaAdministracion.Location = new System.Drawing.Point(11, 254);
            this.lblViaAdministracion.Name = "lblViaAdministracion";
            this.lblViaAdministracion.Size = new System.Drawing.Size(179, 19);
            this.lblViaAdministracion.TabIndex = 37;
            this.lblViaAdministracion.Text = "Vía de Aministración";
            // 
            // cboViaAdministracion
            // 
            this.cboViaAdministracion.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboViaAdministracion.FormattingEnabled = true;
            this.cboViaAdministracion.Items.AddRange(new object[] {
            "Vía sublingual y oral",
            "vía bucal",
            "Vía rectal",
            "Vía vaginal",
            "Vía ótica",
            "Vía nasal",
            "Vía cutánea",
            "Vía transdérmica"});
            this.cboViaAdministracion.Location = new System.Drawing.Point(460, 251);
            this.cboViaAdministracion.Name = "cboViaAdministracion";
            this.cboViaAdministracion.Size = new System.Drawing.Size(606, 28);
            this.cboViaAdministracion.TabIndex = 38;
            this.cboViaAdministracion.SelectedIndexChanged += new System.EventHandler(this.cboViaAdministracion_SelectedIndexChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnConfirmarRegistro
            // 
            this.btnConfirmarRegistro.BackColor = System.Drawing.Color.LightBlue;
            this.btnConfirmarRegistro.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmarRegistro.Location = new System.Drawing.Point(98, 473);
            this.btnConfirmarRegistro.Name = "btnConfirmarRegistro";
            this.btnConfirmarRegistro.Size = new System.Drawing.Size(208, 42);
            this.btnConfirmarRegistro.TabIndex = 39;
            this.btnConfirmarRegistro.Text = "CONFIRMAR REGISTRO";
            this.btnConfirmarRegistro.UseVisualStyleBackColor = false;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1151, 554);
            this.Controls.Add(this.btnConfirmarRegistro);
            this.Controls.Add(this.cboViaAdministracion);
            this.Controls.Add(this.lblViaAdministracion);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cboFormaFarmaceutica);
            this.Controls.Add(this.cboTipoMedicamentos);
            this.Controls.Add(this.dtpVigenciaPrescripcion);
            this.Controls.Add(this.txtNombreMedicamento);
            this.Controls.Add(this.txtPeriodoDuracion);
            this.Controls.Add(this.txtCantidadTotal);
            this.Controls.Add(this.txtNumeroOrden);
            this.Controls.Add(this.dtpFechaPrescripcion);
            this.Controls.Add(this.txtNombreProfesional);
            this.Controls.Add(this.lblTipoMedicamentos);
            this.Controls.Add(this.lblNombreMedicamento);
            this.Controls.Add(this.lblFormaFarmaceutica);
            this.Controls.Add(this.lblPeriodoDuracion);
            this.Controls.Add(this.lblCantidadTotal);
            this.Controls.Add(this.lblVigenciaPrescipción);
            this.Controls.Add(this.lblNumeroOrden);
            this.Controls.Add(this.lblFechaPrescripcion);
            this.Controls.Add(this.lblNombreProfesional);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form5";
            this.Text = "Medicamentos";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNombreProfesional;
        private System.Windows.Forms.Label lblFechaPrescripcion;
        private System.Windows.Forms.Label lblNumeroOrden;
        private System.Windows.Forms.Label lblVigenciaPrescipción;
        private System.Windows.Forms.Label lblCantidadTotal;
        private System.Windows.Forms.Label lblPeriodoDuracion;
        private System.Windows.Forms.Label lblFormaFarmaceutica;
        private System.Windows.Forms.Label lblNombreMedicamento;
        private System.Windows.Forms.Label lblTipoMedicamentos;
        private System.Windows.Forms.TextBox txtNombreProfesional;
        private System.Windows.Forms.DateTimePicker dtpFechaPrescripcion;
        private System.Windows.Forms.TextBox txtNumeroOrden;
        private System.Windows.Forms.TextBox txtCantidadTotal;
        private System.Windows.Forms.TextBox txtPeriodoDuracion;
        private System.Windows.Forms.TextBox txtNombreMedicamento;
        private System.Windows.Forms.DateTimePicker dtpVigenciaPrescripcion;
        private System.Windows.Forms.ComboBox cboTipoMedicamentos;
        private System.Windows.Forms.ComboBox cboFormaFarmaceutica;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblViaAdministracion;
        private System.Windows.Forms.ComboBox cboViaAdministracion;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnConfirmarRegistro;
    }
}