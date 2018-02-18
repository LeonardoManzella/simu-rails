﻿namespace SimuRails.Views.Components.Attrs
{
    partial class EstacionAttrs
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.esperandoMinIdaField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.BindingSourceEstacion = new System.Windows.Forms.BindingSource(this.components);
            this.nombreField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.esperandoMaxIdaField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.EsMantenimientoCheck = new MaterialSkin.Controls.MaterialCheckBox();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.esperandoMaxVueltaField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.esperandoMinVueltaField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.desciendenMaxVueltaField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.desciendenMinVueltaField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialDivider4 = new MaterialSkin.Controls.MaterialDivider();
            this.materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel13 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel14 = new MaterialSkin.Controls.MaterialLabel();
            this.desciendenMaxIdaField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel15 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel16 = new MaterialSkin.Controls.MaterialLabel();
            this.desciendenMinIdaField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.ListBoxAsignados = new System.Windows.Forms.ListBox();
            this.BindingSourceIncidentesAsignados = new System.Windows.Forms.BindingSource(this.components);
            this.ButtonDesasignar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.ButtonAsignar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel17 = new MaterialSkin.Controls.MaterialLabel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.BindingSourceIncidentesDisponibles = new System.Windows.Forms.BindingSource(this.components);
            this.errorNombreLbl = new System.Windows.Forms.Label();
            this.errorSubidaIda = new System.Windows.Forms.Label();
            this.errorSubidaVuelta = new System.Windows.Forms.Label();
            this.errorBajadaIda = new System.Windows.Forms.Label();
            this.errorBajadaVuelta = new System.Windows.Forms.Label();
            this.materialLabel18 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel19 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel20 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel21 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSourceEstacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSourceIncidentesAsignados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSourceIncidentesDisponibles)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(16, 20);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(63, 19);
            this.materialLabel7.TabIndex = 37;
            this.materialLabel7.Text = "Nombre";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(16, 189);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(59, 19);
            this.materialLabel3.TabIndex = 33;
            this.materialLabel3.Text = "Mínima";
            // 
            // esperandoMinIdaField
            // 
            this.esperandoMinIdaField.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceEstacion, "PersonasEsperandoMinIda", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N0"));
            this.esperandoMinIdaField.Depth = 0;
            this.esperandoMinIdaField.Hint = "";
            this.esperandoMinIdaField.IsNumeric = false;
            this.esperandoMinIdaField.Location = new System.Drawing.Point(20, 211);
            this.esperandoMinIdaField.MaxLength = 32767;
            this.esperandoMinIdaField.MouseState = MaterialSkin.MouseState.HOVER;
            this.esperandoMinIdaField.Name = "esperandoMinIdaField";
            this.esperandoMinIdaField.PasswordChar = '\0';
            this.esperandoMinIdaField.SelectedText = "";
            this.esperandoMinIdaField.SelectionLength = 0;
            this.esperandoMinIdaField.SelectionStart = 0;
            this.esperandoMinIdaField.Size = new System.Drawing.Size(80, 23);
            this.esperandoMinIdaField.TabIndex = 2;
            this.esperandoMinIdaField.TabStop = false;
            this.esperandoMinIdaField.UseSystemPasswordChar = false;
            // 
            // BindingSourceEstacion
            // 
            this.BindingSourceEstacion.DataSource = typeof(SimuRails.Models.Estacion);
            // 
            // nombreField
            // 
            this.nombreField.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceEstacion, "Nombre", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.nombreField.Depth = 0;
            this.nombreField.Hint = "";
            this.nombreField.IsNumeric = false;
            this.nombreField.Location = new System.Drawing.Point(20, 42);
            this.nombreField.MaxLength = 32767;
            this.nombreField.MouseState = MaterialSkin.MouseState.HOVER;
            this.nombreField.Name = "nombreField";
            this.nombreField.PasswordChar = '\0';
            this.nombreField.SelectedText = "";
            this.nombreField.SelectionLength = 0;
            this.nombreField.SelectionStart = 0;
            this.nombreField.Size = new System.Drawing.Size(270, 23);
            this.nombreField.TabIndex = 0;
            this.nombreField.TabStop = false;
            this.nombreField.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(17, 110);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(308, 19);
            this.materialLabel2.TabIndex = 32;
            this.materialLabel2.Text = "Cantidad de personas esperando en el andén";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(165, 189);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(62, 19);
            this.materialLabel1.TabIndex = 39;
            this.materialLabel1.Text = "Máxima";
            // 
            // esperandoMaxIdaField
            // 
            this.esperandoMaxIdaField.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceEstacion, "PersonasEsperandoMaxIda", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N0"));
            this.esperandoMaxIdaField.Depth = 0;
            this.esperandoMaxIdaField.Hint = "";
            this.esperandoMaxIdaField.IsNumeric = false;
            this.esperandoMaxIdaField.Location = new System.Drawing.Point(169, 211);
            this.esperandoMaxIdaField.MaxLength = 32767;
            this.esperandoMaxIdaField.MouseState = MaterialSkin.MouseState.HOVER;
            this.esperandoMaxIdaField.Name = "esperandoMaxIdaField";
            this.esperandoMaxIdaField.PasswordChar = '\0';
            this.esperandoMaxIdaField.SelectedText = "";
            this.esperandoMaxIdaField.SelectionLength = 0;
            this.esperandoMaxIdaField.SelectionStart = 0;
            this.esperandoMaxIdaField.Size = new System.Drawing.Size(80, 23);
            this.esperandoMaxIdaField.TabIndex = 3;
            this.esperandoMaxIdaField.TabStop = false;
            this.esperandoMaxIdaField.UseSystemPasswordChar = false;
            // 
            // EsMantenimientoCheck
            // 
            this.EsMantenimientoCheck.AutoSize = true;
            this.EsMantenimientoCheck.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.BindingSourceEstacion, "EsEstacionDeMantenimiento", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.EsMantenimientoCheck.Depth = 0;
            this.EsMantenimientoCheck.Font = new System.Drawing.Font("Roboto", 10F);
            this.EsMantenimientoCheck.Location = new System.Drawing.Point(348, 32);
            this.EsMantenimientoCheck.Margin = new System.Windows.Forms.Padding(0);
            this.EsMantenimientoCheck.MouseLocation = new System.Drawing.Point(-1, -1);
            this.EsMantenimientoCheck.MouseState = MaterialSkin.MouseState.HOVER;
            this.EsMantenimientoCheck.Name = "EsMantenimientoCheck";
            this.EsMantenimientoCheck.Ripple = true;
            this.EsMantenimientoCheck.Size = new System.Drawing.Size(216, 30);
            this.EsMantenimientoCheck.TabIndex = 1;
            this.EsMantenimientoCheck.Text = "Es estación de mantenimiento";
            this.EsMantenimientoCheck.UseVisualStyleBackColor = true;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(18, 158);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(29, 19);
            this.materialLabel5.TabIndex = 47;
            this.materialLabel5.Text = "Ida";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(316, 158);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(52, 19);
            this.materialLabel6.TabIndex = 48;
            this.materialLabel6.Text = "Vuelta";
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(467, 189);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(62, 19);
            this.materialLabel8.TabIndex = 53;
            this.materialLabel8.Text = "Máxima";
            // 
            // esperandoMaxVueltaField
            // 
            this.esperandoMaxVueltaField.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceEstacion, "PersonasEsperandoMaxVuelta", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N0"));
            this.esperandoMaxVueltaField.Depth = 0;
            this.esperandoMaxVueltaField.Hint = "";
            this.esperandoMaxVueltaField.IsNumeric = false;
            this.esperandoMaxVueltaField.Location = new System.Drawing.Point(471, 211);
            this.esperandoMaxVueltaField.MaxLength = 32767;
            this.esperandoMaxVueltaField.MouseState = MaterialSkin.MouseState.HOVER;
            this.esperandoMaxVueltaField.Name = "esperandoMaxVueltaField";
            this.esperandoMaxVueltaField.PasswordChar = '\0';
            this.esperandoMaxVueltaField.SelectedText = "";
            this.esperandoMaxVueltaField.SelectionLength = 0;
            this.esperandoMaxVueltaField.SelectionStart = 0;
            this.esperandoMaxVueltaField.Size = new System.Drawing.Size(80, 23);
            this.esperandoMaxVueltaField.TabIndex = 5;
            this.esperandoMaxVueltaField.TabStop = false;
            this.esperandoMaxVueltaField.UseSystemPasswordChar = false;
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel9.Location = new System.Drawing.Point(316, 189);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(59, 19);
            this.materialLabel9.TabIndex = 51;
            this.materialLabel9.Text = "Mínima";
            // 
            // esperandoMinVueltaField
            // 
            this.esperandoMinVueltaField.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceEstacion, "PersonasEsperandoMinVuelta", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N0"));
            this.esperandoMinVueltaField.Depth = 0;
            this.esperandoMinVueltaField.Hint = "";
            this.esperandoMinVueltaField.IsNumeric = false;
            this.esperandoMinVueltaField.Location = new System.Drawing.Point(320, 211);
            this.esperandoMinVueltaField.MaxLength = 32767;
            this.esperandoMinVueltaField.MouseState = MaterialSkin.MouseState.HOVER;
            this.esperandoMinVueltaField.Name = "esperandoMinVueltaField";
            this.esperandoMinVueltaField.PasswordChar = '\0';
            this.esperandoMinVueltaField.SelectedText = "";
            this.esperandoMinVueltaField.SelectionLength = 0;
            this.esperandoMinVueltaField.SelectionStart = 0;
            this.esperandoMinVueltaField.Size = new System.Drawing.Size(80, 23);
            this.esperandoMinVueltaField.TabIndex = 4;
            this.esperandoMinVueltaField.TabStop = false;
            this.esperandoMinVueltaField.UseSystemPasswordChar = false;
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel10.Location = new System.Drawing.Point(1154, 189);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(62, 19);
            this.materialLabel10.TabIndex = 65;
            this.materialLabel10.Text = "Máxima";
            // 
            // desciendenMaxVueltaField
            // 
            this.desciendenMaxVueltaField.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceEstacion, "PersonasDesciendenMaxVuelta", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N0"));
            this.desciendenMaxVueltaField.Depth = 0;
            this.desciendenMaxVueltaField.Hint = "";
            this.desciendenMaxVueltaField.IsNumeric = false;
            this.desciendenMaxVueltaField.Location = new System.Drawing.Point(1158, 211);
            this.desciendenMaxVueltaField.MaxLength = 32767;
            this.desciendenMaxVueltaField.MouseState = MaterialSkin.MouseState.HOVER;
            this.desciendenMaxVueltaField.Name = "desciendenMaxVueltaField";
            this.desciendenMaxVueltaField.PasswordChar = '\0';
            this.desciendenMaxVueltaField.SelectedText = "";
            this.desciendenMaxVueltaField.SelectionLength = 0;
            this.desciendenMaxVueltaField.SelectionStart = 0;
            this.desciendenMaxVueltaField.Size = new System.Drawing.Size(80, 23);
            this.desciendenMaxVueltaField.TabIndex = 9;
            this.desciendenMaxVueltaField.TabStop = false;
            this.desciendenMaxVueltaField.UseSystemPasswordChar = false;
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel11.Location = new System.Drawing.Point(993, 189);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(59, 19);
            this.materialLabel11.TabIndex = 63;
            this.materialLabel11.Text = "Mínima";
            // 
            // desciendenMinVueltaField
            // 
            this.desciendenMinVueltaField.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceEstacion, "PersonasDesciendenMinVuelta", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N0"));
            this.desciendenMinVueltaField.Depth = 0;
            this.desciendenMinVueltaField.Hint = "";
            this.desciendenMinVueltaField.IsNumeric = false;
            this.desciendenMinVueltaField.Location = new System.Drawing.Point(997, 211);
            this.desciendenMinVueltaField.MaxLength = 32767;
            this.desciendenMinVueltaField.MouseState = MaterialSkin.MouseState.HOVER;
            this.desciendenMinVueltaField.Name = "desciendenMinVueltaField";
            this.desciendenMinVueltaField.PasswordChar = '\0';
            this.desciendenMinVueltaField.SelectedText = "";
            this.desciendenMinVueltaField.SelectionLength = 0;
            this.desciendenMinVueltaField.SelectionStart = 0;
            this.desciendenMinVueltaField.Size = new System.Drawing.Size(80, 23);
            this.desciendenMinVueltaField.TabIndex = 8;
            this.desciendenMinVueltaField.TabStop = false;
            this.desciendenMinVueltaField.UseSystemPasswordChar = false;
            // 
            // materialDivider4
            // 
            this.materialDivider4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider4.Depth = 0;
            this.materialDivider4.Location = new System.Drawing.Point(623, 92);
            this.materialDivider4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider4.Name = "materialDivider4";
            this.materialDivider4.Size = new System.Drawing.Size(2, 158);
            this.materialDivider4.TabIndex = 61;
            this.materialDivider4.Text = "materialDivider4";
            // 
            // materialLabel12
            // 
            this.materialLabel12.AutoSize = true;
            this.materialLabel12.Depth = 0;
            this.materialLabel12.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel12.Location = new System.Drawing.Point(993, 158);
            this.materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel12.Name = "materialLabel12";
            this.materialLabel12.Size = new System.Drawing.Size(52, 19);
            this.materialLabel12.TabIndex = 60;
            this.materialLabel12.Text = "Vuelta";
            // 
            // materialLabel13
            // 
            this.materialLabel13.AutoSize = true;
            this.materialLabel13.Depth = 0;
            this.materialLabel13.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel13.Location = new System.Drawing.Point(671, 158);
            this.materialLabel13.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel13.Name = "materialLabel13";
            this.materialLabel13.Size = new System.Drawing.Size(29, 19);
            this.materialLabel13.TabIndex = 59;
            this.materialLabel13.Text = "Ida";
            // 
            // materialLabel14
            // 
            this.materialLabel14.AutoSize = true;
            this.materialLabel14.Depth = 0;
            this.materialLabel14.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel14.Location = new System.Drawing.Point(831, 189);
            this.materialLabel14.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel14.Name = "materialLabel14";
            this.materialLabel14.Size = new System.Drawing.Size(62, 19);
            this.materialLabel14.TabIndex = 58;
            this.materialLabel14.Text = "Máxima";
            // 
            // desciendenMaxIdaField
            // 
            this.desciendenMaxIdaField.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceEstacion, "PersonasDesciendenMaxIda", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N0"));
            this.desciendenMaxIdaField.Depth = 0;
            this.desciendenMaxIdaField.Hint = "";
            this.desciendenMaxIdaField.IsNumeric = false;
            this.desciendenMaxIdaField.Location = new System.Drawing.Point(835, 211);
            this.desciendenMaxIdaField.MaxLength = 32767;
            this.desciendenMaxIdaField.MouseState = MaterialSkin.MouseState.HOVER;
            this.desciendenMaxIdaField.Name = "desciendenMaxIdaField";
            this.desciendenMaxIdaField.PasswordChar = '\0';
            this.desciendenMaxIdaField.SelectedText = "";
            this.desciendenMaxIdaField.SelectionLength = 0;
            this.desciendenMaxIdaField.SelectionStart = 0;
            this.desciendenMaxIdaField.Size = new System.Drawing.Size(80, 23);
            this.desciendenMaxIdaField.TabIndex = 7;
            this.desciendenMaxIdaField.TabStop = false;
            this.desciendenMaxIdaField.UseSystemPasswordChar = false;
            // 
            // materialLabel15
            // 
            this.materialLabel15.AutoSize = true;
            this.materialLabel15.Depth = 0;
            this.materialLabel15.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel15.Location = new System.Drawing.Point(671, 189);
            this.materialLabel15.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel15.Name = "materialLabel15";
            this.materialLabel15.Size = new System.Drawing.Size(59, 19);
            this.materialLabel15.TabIndex = 56;
            this.materialLabel15.Text = "Mínima";
            // 
            // materialLabel16
            // 
            this.materialLabel16.AutoSize = true;
            this.materialLabel16.Depth = 0;
            this.materialLabel16.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel16.Location = new System.Drawing.Point(671, 110);
            this.materialLabel16.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel16.Name = "materialLabel16";
            this.materialLabel16.Size = new System.Drawing.Size(331, 19);
            this.materialLabel16.TabIndex = 55;
            this.materialLabel16.Text = "Cantidad de personas que descienden del andén";
            // 
            // desciendenMinIdaField
            // 
            this.desciendenMinIdaField.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceEstacion, "PersonasDesciendenMinIda", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N0"));
            this.desciendenMinIdaField.Depth = 0;
            this.desciendenMinIdaField.Hint = "";
            this.desciendenMinIdaField.IsNumeric = false;
            this.desciendenMinIdaField.Location = new System.Drawing.Point(675, 211);
            this.desciendenMinIdaField.MaxLength = 32767;
            this.desciendenMinIdaField.MouseState = MaterialSkin.MouseState.HOVER;
            this.desciendenMinIdaField.Name = "desciendenMinIdaField";
            this.desciendenMinIdaField.PasswordChar = '\0';
            this.desciendenMinIdaField.SelectedText = "";
            this.desciendenMinIdaField.SelectionLength = 0;
            this.desciendenMinIdaField.SelectionStart = 0;
            this.desciendenMinIdaField.Size = new System.Drawing.Size(80, 23);
            this.desciendenMinIdaField.TabIndex = 6;
            this.desciendenMinIdaField.TabStop = false;
            this.desciendenMinIdaField.UseSystemPasswordChar = false;
            // 
            // ListBoxAsignados
            // 
            this.ListBoxAsignados.DataSource = this.BindingSourceIncidentesAsignados;
            this.ListBoxAsignados.DisplayMember = "Valor";
            this.ListBoxAsignados.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBoxAsignados.FormattingEnabled = true;
            this.ListBoxAsignados.ItemHeight = 18;
            this.ListBoxAsignados.Location = new System.Drawing.Point(675, 363);
            this.ListBoxAsignados.Name = "ListBoxAsignados";
            this.ListBoxAsignados.Size = new System.Drawing.Size(296, 130);
            this.ListBoxAsignados.TabIndex = 71;
            this.ListBoxAsignados.ValueMember = "Clave";
            // 
            // BindingSourceIncidentesAsignados
            // 
            this.BindingSourceIncidentesAsignados.DataSource = typeof(SimuRails.KeyValue);
            // 
            // ButtonDesasignar
            // 
            this.ButtonDesasignar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonDesasignar.Depth = 0;
            this.ButtonDesasignar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDesasignar.Icon = null;
            this.ButtonDesasignar.Location = new System.Drawing.Point(595, 438);
            this.ButtonDesasignar.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonDesasignar.Name = "ButtonDesasignar";
            this.ButtonDesasignar.Primary = true;
            this.ButtonDesasignar.Size = new System.Drawing.Size(62, 23);
            this.ButtonDesasignar.TabIndex = 67;
            this.ButtonDesasignar.Text = "<";
            this.ButtonDesasignar.UseVisualStyleBackColor = true;
            this.ButtonDesasignar.Click += new System.EventHandler(this.ButtonDesasignar_Click);
            // 
            // ButtonAsignar
            // 
            this.ButtonAsignar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonAsignar.Depth = 0;
            this.ButtonAsignar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAsignar.Icon = null;
            this.ButtonAsignar.Location = new System.Drawing.Point(595, 400);
            this.ButtonAsignar.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonAsignar.Name = "ButtonAsignar";
            this.ButtonAsignar.Primary = true;
            this.ButtonAsignar.Size = new System.Drawing.Size(62, 23);
            this.ButtonAsignar.TabIndex = 66;
            this.ButtonAsignar.Text = ">";
            this.ButtonAsignar.UseVisualStyleBackColor = true;
            this.ButtonAsignar.Click += new System.EventHandler(this.ButtonAsignar_Click);
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(671, 341);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(153, 19);
            this.materialLabel4.TabIndex = 70;
            this.materialLabel4.Text = "Incidentes Asignados";
            // 
            // materialLabel17
            // 
            this.materialLabel17.AutoSize = true;
            this.materialLabel17.Depth = 0;
            this.materialLabel17.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel17.Location = new System.Drawing.Point(276, 341);
            this.materialLabel17.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel17.Name = "materialLabel17";
            this.materialLabel17.Size = new System.Drawing.Size(161, 19);
            this.materialLabel17.TabIndex = 69;
            this.materialLabel17.Text = "Incidentes Disponibles";
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.BindingSourceIncidentesDisponibles;
            this.listBox1.DisplayMember = "Nombre";
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Location = new System.Drawing.Point(280, 363);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(296, 130);
            this.listBox1.TabIndex = 68;
            this.listBox1.ValueMember = "Id";
            // 
            // BindingSourceIncidentesDisponibles
            // 
            this.BindingSourceIncidentesDisponibles.DataSource = typeof(SimuRails.Models.Incidente);
            // 
            // errorNombreLbl
            // 
            this.errorNombreLbl.AutoSize = true;
            this.errorNombreLbl.Font = new System.Drawing.Font("Roboto Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorNombreLbl.ForeColor = System.Drawing.Color.DarkRed;
            this.errorNombreLbl.Location = new System.Drawing.Point(19, 68);
            this.errorNombreLbl.Name = "errorNombreLbl";
            this.errorNombreLbl.Size = new System.Drawing.Size(162, 14);
            this.errorNombreLbl.TabIndex = 72;
            this.errorNombreLbl.Text = "Este campo es requerido";
            this.errorNombreLbl.Visible = false;
            // 
            // errorSubidaIda
            // 
            this.errorSubidaIda.AutoSize = true;
            this.errorSubidaIda.Font = new System.Drawing.Font("Roboto Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorSubidaIda.ForeColor = System.Drawing.Color.DarkRed;
            this.errorSubidaIda.Location = new System.Drawing.Point(17, 246);
            this.errorSubidaIda.Name = "errorSubidaIda";
            this.errorSubidaIda.Size = new System.Drawing.Size(192, 14);
            this.errorSubidaIda.TabIndex = 73;
            this.errorSubidaIda.Text = "Este campo debe ser positivo";
            this.errorSubidaIda.Visible = false;
            // 
            // errorSubidaVuelta
            // 
            this.errorSubidaVuelta.AutoSize = true;
            this.errorSubidaVuelta.Font = new System.Drawing.Font("Roboto Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorSubidaVuelta.ForeColor = System.Drawing.Color.DarkRed;
            this.errorSubidaVuelta.Location = new System.Drawing.Point(317, 246);
            this.errorSubidaVuelta.Name = "errorSubidaVuelta";
            this.errorSubidaVuelta.Size = new System.Drawing.Size(192, 14);
            this.errorSubidaVuelta.TabIndex = 74;
            this.errorSubidaVuelta.Text = "Este campo debe ser positivo";
            this.errorSubidaVuelta.Visible = false;
            // 
            // errorBajadaIda
            // 
            this.errorBajadaIda.AutoSize = true;
            this.errorBajadaIda.Font = new System.Drawing.Font("Roboto Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorBajadaIda.ForeColor = System.Drawing.Color.DarkRed;
            this.errorBajadaIda.Location = new System.Drawing.Point(672, 246);
            this.errorBajadaIda.Name = "errorBajadaIda";
            this.errorBajadaIda.Size = new System.Drawing.Size(192, 14);
            this.errorBajadaIda.TabIndex = 75;
            this.errorBajadaIda.Text = "Este campo debe ser positivo";
            this.errorBajadaIda.Visible = false;
            // 
            // errorBajadaVuelta
            // 
            this.errorBajadaVuelta.AutoSize = true;
            this.errorBajadaVuelta.Font = new System.Drawing.Font("Roboto Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorBajadaVuelta.ForeColor = System.Drawing.Color.DarkRed;
            this.errorBajadaVuelta.Location = new System.Drawing.Point(994, 246);
            this.errorBajadaVuelta.Name = "errorBajadaVuelta";
            this.errorBajadaVuelta.Size = new System.Drawing.Size(192, 14);
            this.errorBajadaVuelta.TabIndex = 76;
            this.errorBajadaVuelta.Text = "Este campo debe ser positivo";
            this.errorBajadaVuelta.Visible = false;
            // 
            // materialLabel18
            // 
            this.materialLabel18.AutoSize = true;
            this.materialLabel18.Depth = 0;
            this.materialLabel18.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel18.Location = new System.Drawing.Point(115, 211);
            this.materialLabel18.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel18.Name = "materialLabel18";
            this.materialLabel18.Size = new System.Drawing.Size(29, 19);
            this.materialLabel18.TabIndex = 77;
            this.materialLabel18.Text = "<->";
            // 
            // materialLabel19
            // 
            this.materialLabel19.AutoSize = true;
            this.materialLabel19.Depth = 0;
            this.materialLabel19.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel19.Location = new System.Drawing.Point(421, 211);
            this.materialLabel19.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel19.Name = "materialLabel19";
            this.materialLabel19.Size = new System.Drawing.Size(29, 19);
            this.materialLabel19.TabIndex = 78;
            this.materialLabel19.Text = "<->";
            // 
            // materialLabel20
            // 
            this.materialLabel20.AutoSize = true;
            this.materialLabel20.Depth = 0;
            this.materialLabel20.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel20.Location = new System.Drawing.Point(779, 211);
            this.materialLabel20.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel20.Name = "materialLabel20";
            this.materialLabel20.Size = new System.Drawing.Size(29, 19);
            this.materialLabel20.TabIndex = 79;
            this.materialLabel20.Text = "<->";
            // 
            // materialLabel21
            // 
            this.materialLabel21.AutoSize = true;
            this.materialLabel21.Depth = 0;
            this.materialLabel21.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel21.Location = new System.Drawing.Point(1104, 211);
            this.materialLabel21.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel21.Name = "materialLabel21";
            this.materialLabel21.Size = new System.Drawing.Size(29, 19);
            this.materialLabel21.TabIndex = 80;
            this.materialLabel21.Text = "<->";
            // 
            // EstacionAttrs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.materialLabel21);
            this.Controls.Add(this.materialLabel20);
            this.Controls.Add(this.materialLabel19);
            this.Controls.Add(this.materialLabel18);
            this.Controls.Add(this.errorBajadaVuelta);
            this.Controls.Add(this.errorBajadaIda);
            this.Controls.Add(this.errorSubidaVuelta);
            this.Controls.Add(this.errorSubidaIda);
            this.Controls.Add(this.errorNombreLbl);
            this.Controls.Add(this.ListBoxAsignados);
            this.Controls.Add(this.ButtonDesasignar);
            this.Controls.Add(this.ButtonAsignar);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel17);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.materialLabel10);
            this.Controls.Add(this.desciendenMaxVueltaField);
            this.Controls.Add(this.materialLabel11);
            this.Controls.Add(this.desciendenMinVueltaField);
            this.Controls.Add(this.materialDivider4);
            this.Controls.Add(this.materialLabel12);
            this.Controls.Add(this.materialLabel13);
            this.Controls.Add(this.materialLabel14);
            this.Controls.Add(this.desciendenMaxIdaField);
            this.Controls.Add(this.materialLabel15);
            this.Controls.Add(this.materialLabel16);
            this.Controls.Add(this.desciendenMinIdaField);
            this.Controls.Add(this.materialLabel8);
            this.Controls.Add(this.esperandoMaxVueltaField);
            this.Controls.Add(this.materialLabel9);
            this.Controls.Add(this.esperandoMinVueltaField);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.EsMantenimientoCheck);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.esperandoMaxIdaField);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.esperandoMinIdaField);
            this.Controls.Add(this.nombreField);
            this.Name = "EstacionAttrs";
            this.Size = new System.Drawing.Size(1314, 593);
            ((System.ComponentModel.ISupportInitialize)(this.BindingSourceEstacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSourceIncidentesAsignados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSourceIncidentesDisponibles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialSingleLineTextField esperandoMinIdaField;
        private MaterialSkin.Controls.MaterialSingleLineTextField nombreField;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField esperandoMaxIdaField;
        private MaterialSkin.Controls.MaterialCheckBox EsMantenimientoCheck;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialSingleLineTextField esperandoMaxVueltaField;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialSingleLineTextField esperandoMinVueltaField;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialSingleLineTextField desciendenMaxVueltaField;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialSingleLineTextField desciendenMinVueltaField;
        private MaterialSkin.Controls.MaterialDivider materialDivider4;
        private MaterialSkin.Controls.MaterialLabel materialLabel12;
        private MaterialSkin.Controls.MaterialLabel materialLabel13;
        private MaterialSkin.Controls.MaterialLabel materialLabel14;
        private MaterialSkin.Controls.MaterialSingleLineTextField desciendenMaxIdaField;
        private MaterialSkin.Controls.MaterialLabel materialLabel15;
        private MaterialSkin.Controls.MaterialLabel materialLabel16;
        private MaterialSkin.Controls.MaterialSingleLineTextField desciendenMinIdaField;
        private System.Windows.Forms.BindingSource BindingSourceEstacion;
        private System.Windows.Forms.ListBox ListBoxAsignados;
        private MaterialSkin.Controls.MaterialRaisedButton ButtonDesasignar;
        private MaterialSkin.Controls.MaterialRaisedButton ButtonAsignar;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel17;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.BindingSource BindingSourceIncidentesDisponibles;
        private System.Windows.Forms.BindingSource BindingSourceIncidentesAsignados;
        private System.Windows.Forms.Label errorNombreLbl;
        private System.Windows.Forms.Label errorSubidaIda;
        private System.Windows.Forms.Label errorSubidaVuelta;
        private System.Windows.Forms.Label errorBajadaIda;
        private System.Windows.Forms.Label errorBajadaVuelta;
        private MaterialSkin.Controls.MaterialLabel materialLabel18;
        private MaterialSkin.Controls.MaterialLabel materialLabel19;
        private MaterialSkin.Controls.MaterialLabel materialLabel20;
        private MaterialSkin.Controls.MaterialLabel materialLabel21;
    }
}
