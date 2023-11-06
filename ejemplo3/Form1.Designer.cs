namespace ejemplo3
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lwElementos = new System.Windows.Forms.ListView();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFechanacimiento = new System.Windows.Forms.DateTimePicker();
            this.ckbChocolate = new System.Windows.Forms.CheckBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.rbtWizard = new System.Windows.Forms.RadioButton();
            this.rbtMuggle = new System.Windows.Forms.RadioButton();
            this.rbtSquibs = new System.Windows.Forms.RadioButton();
            this.gbxTipo = new System.Windows.Forms.GroupBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.cbxColorfavorito = new System.Windows.Forms.ComboBox();
            this.lblNumerofavorito = new System.Windows.Forms.Label();
            this.numNumerofavorito = new System.Windows.Forms.NumericUpDown();
            this.btnVerperfil = new System.Windows.Forms.Button();
            this.gbxTipo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNumerofavorito)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombre.Location = new System.Drawing.Point(251, 81);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(297, 26);
            this.txtNombre.TabIndex = 0;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.Location = new System.Drawing.Point(417, 637);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(131, 34);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lwElementos
            // 
            this.lwElementos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lwElementos.HideSelection = false;
            this.lwElementos.Location = new System.Drawing.Point(67, 488);
            this.lwElementos.Name = "lwElementos";
            this.lwElementos.Size = new System.Drawing.Size(293, 183);
            this.lwElementos.TabIndex = 8;
            this.lwElementos.UseCompatibleStateImageBehavior = false;
            this.lwElementos.View = System.Windows.Forms.View.List;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(159, 84);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(69, 20);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(67, 137);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(161, 20);
            this.lblFecha.TabIndex = 4;
            this.lblFecha.Text = "Fecha de nacimiento:";
            // 
            // dtpFechanacimiento
            // 
            this.dtpFechanacimiento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFechanacimiento.Location = new System.Drawing.Point(251, 132);
            this.dtpFechanacimiento.Name = "dtpFechanacimiento";
            this.dtpFechanacimiento.Size = new System.Drawing.Size(297, 26);
            this.dtpFechanacimiento.TabIndex = 1;
            // 
            // ckbChocolate
            // 
            this.ckbChocolate.AutoSize = true;
            this.ckbChocolate.Location = new System.Drawing.Point(251, 178);
            this.ckbChocolate.Name = "ckbChocolate";
            this.ckbChocolate.Size = new System.Drawing.Size(191, 24);
            this.ckbChocolate.TabIndex = 2;
            this.ckbChocolate.Text = "te gusta el chocolate?";
            this.ckbChocolate.UseVisualStyleBackColor = true;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(266, 46);
            this.lblTitulo.TabIndex = 7;
            this.lblTitulo.Text = "Perfil persona";
            // 
            // rbtWizard
            // 
            this.rbtWizard.AutoSize = true;
            this.rbtWizard.Checked = true;
            this.rbtWizard.Location = new System.Drawing.Point(42, 43);
            this.rbtWizard.Name = "rbtWizard";
            this.rbtWizard.Size = new System.Drawing.Size(83, 24);
            this.rbtWizard.TabIndex = 0;
            this.rbtWizard.TabStop = true;
            this.rbtWizard.Text = "Wizard";
            this.rbtWizard.UseVisualStyleBackColor = true;
            // 
            // rbtMuggle
            // 
            this.rbtMuggle.AutoSize = true;
            this.rbtMuggle.Location = new System.Drawing.Point(190, 43);
            this.rbtMuggle.Name = "rbtMuggle";
            this.rbtMuggle.Size = new System.Drawing.Size(86, 24);
            this.rbtMuggle.TabIndex = 9;
            this.rbtMuggle.Text = "Muggle";
            this.rbtMuggle.UseVisualStyleBackColor = true;
            // 
            // rbtSquibs
            // 
            this.rbtSquibs.AutoSize = true;
            this.rbtSquibs.Location = new System.Drawing.Point(351, 43);
            this.rbtSquibs.Name = "rbtSquibs";
            this.rbtSquibs.Size = new System.Drawing.Size(83, 24);
            this.rbtSquibs.TabIndex = 10;
            this.rbtSquibs.Text = "Squibs";
            this.rbtSquibs.UseVisualStyleBackColor = true;
            // 
            // gbxTipo
            // 
            this.gbxTipo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbxTipo.Controls.Add(this.rbtSquibs);
            this.gbxTipo.Controls.Add(this.rbtWizard);
            this.gbxTipo.Controls.Add(this.rbtMuggle);
            this.gbxTipo.Location = new System.Drawing.Point(71, 218);
            this.gbxTipo.Name = "gbxTipo";
            this.gbxTipo.Size = new System.Drawing.Size(477, 100);
            this.gbxTipo.TabIndex = 11;
            this.gbxTipo.TabStop = false;
            this.gbxTipo.Text = "Tipo";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(69, 340);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(106, 20);
            this.lblColor.TabIndex = 12;
            this.lblColor.Text = "Color favorito:";
            // 
            // cbxColorfavorito
            // 
            this.cbxColorfavorito.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxColorfavorito.FormattingEnabled = true;
            this.cbxColorfavorito.Location = new System.Drawing.Point(196, 332);
            this.cbxColorfavorito.Name = "cbxColorfavorito";
            this.cbxColorfavorito.Size = new System.Drawing.Size(352, 28);
            this.cbxColorfavorito.TabIndex = 3;
            // 
            // lblNumerofavorito
            // 
            this.lblNumerofavorito.AutoSize = true;
            this.lblNumerofavorito.Location = new System.Drawing.Point(69, 379);
            this.lblNumerofavorito.Name = "lblNumerofavorito";
            this.lblNumerofavorito.Size = new System.Drawing.Size(125, 20);
            this.lblNumerofavorito.TabIndex = 14;
            this.lblNumerofavorito.Text = "Número favorito;";
            // 
            // numNumerofavorito
            // 
            this.numNumerofavorito.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numNumerofavorito.Location = new System.Drawing.Point(196, 372);
            this.numNumerofavorito.Name = "numNumerofavorito";
            this.numNumerofavorito.Size = new System.Drawing.Size(352, 26);
            this.numNumerofavorito.TabIndex = 4;
            // 
            // btnVerperfil
            // 
            this.btnVerperfil.Location = new System.Drawing.Point(67, 431);
            this.btnVerperfil.Name = "btnVerperfil";
            this.btnVerperfil.Size = new System.Drawing.Size(131, 34);
            this.btnVerperfil.TabIndex = 7;
            this.btnVerperfil.Text = "Ver PERFIL";
            this.btnVerperfil.UseVisualStyleBackColor = true;
            this.btnVerperfil.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 783);
            this.Controls.Add(this.btnVerperfil);
            this.Controls.Add(this.numNumerofavorito);
            this.Controls.Add(this.lblNumerofavorito);
            this.Controls.Add(this.cbxColorfavorito);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.gbxTipo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.ckbChocolate);
            this.Controls.Add(this.dtpFechanacimiento);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lwElementos);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtNombre);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(632, 839);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Perfil persona";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxTipo.ResumeLayout(false);
            this.gbxTipo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNumerofavorito)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListView lwElementos;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFechanacimiento;
        private System.Windows.Forms.CheckBox ckbChocolate;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.RadioButton rbtWizard;
        private System.Windows.Forms.RadioButton rbtMuggle;
        private System.Windows.Forms.RadioButton rbtSquibs;
        private System.Windows.Forms.GroupBox gbxTipo;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.ComboBox cbxColorfavorito;
        private System.Windows.Forms.Label lblNumerofavorito;
        private System.Windows.Forms.NumericUpDown numNumerofavorito;
        private System.Windows.Forms.Button btnVerperfil;
    }
}

