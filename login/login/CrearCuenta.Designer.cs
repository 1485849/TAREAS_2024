namespace login
{
    partial class CrearCuenta
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
            this.tbNombres = new System.Windows.Forms.TextBox();
            this.tbApellidos = new System.Windows.Forms.TextBox();
            this.btGuardar = new System.Windows.Forms.Button();
            this.tbContraseña = new System.Windows.Forms.TextBox();
            this.tbCorreo = new System.Windows.Forms.TextBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelapellido = new System.Windows.Forms.Label();
            this.labelCorreo = new System.Windows.Forms.Label();
            this.labelContraseña = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbNombres
            // 
            this.tbNombres.Location = new System.Drawing.Point(45, 336);
            this.tbNombres.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbNombres.Multiline = true;
            this.tbNombres.Name = "tbNombres";
            this.tbNombres.Size = new System.Drawing.Size(368, 41);
            this.tbNombres.TabIndex = 1;
            this.tbNombres.TextChanged += new System.EventHandler(this.tbNombres_TextChanged);
            // 
            // tbApellidos
            // 
            this.tbApellidos.Location = new System.Drawing.Point(45, 419);
            this.tbApellidos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbApellidos.Multiline = true;
            this.tbApellidos.Name = "tbApellidos";
            this.tbApellidos.Size = new System.Drawing.Size(368, 41);
            this.tbApellidos.TabIndex = 2;
            this.tbApellidos.TextChanged += new System.EventHandler(this.tbApellidos_TextChanged);
            // 
            // btGuardar
            // 
            this.btGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGuardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btGuardar.Location = new System.Drawing.Point(152, 698);
            this.btGuardar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(153, 44);
            this.btGuardar.TabIndex = 3;
            this.btGuardar.Text = "GUARDAR";
            this.btGuardar.UseVisualStyleBackColor = true;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // tbContraseña
            // 
            this.tbContraseña.Location = new System.Drawing.Point(45, 587);
            this.tbContraseña.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbContraseña.Multiline = true;
            this.tbContraseña.Name = "tbContraseña";
            this.tbContraseña.Size = new System.Drawing.Size(368, 41);
            this.tbContraseña.TabIndex = 4;
            this.tbContraseña.TextChanged += new System.EventHandler(this.tbContraseña_TextChanged);
            // 
            // tbCorreo
            // 
            this.tbCorreo.Location = new System.Drawing.Point(45, 503);
            this.tbCorreo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbCorreo.Multiline = true;
            this.tbCorreo.Name = "tbCorreo";
            this.tbCorreo.Size = new System.Drawing.Size(368, 41);
            this.tbCorreo.TabIndex = 6;
            this.tbCorreo.TextChanged += new System.EventHandler(this.tbCorreo_TextChanged);
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.ForeColor = System.Drawing.Color.Black;
            this.labelNombre.Location = new System.Drawing.Point(52, 380);
            this.labelNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(112, 15);
            this.labelNombre.TabIndex = 7;
            this.labelNombre.Text = "Ingrese su Nombre";
            this.labelNombre.Click += new System.EventHandler(this.labelNombre_Click);
            // 
            // labelapellido
            // 
            this.labelapellido.AutoSize = true;
            this.labelapellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelapellido.ForeColor = System.Drawing.Color.Black;
            this.labelapellido.Location = new System.Drawing.Point(54, 468);
            this.labelapellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelapellido.Name = "labelapellido";
            this.labelapellido.Size = new System.Drawing.Size(123, 15);
            this.labelapellido.TabIndex = 8;
            this.labelapellido.Text = "Ingrese sus Apellidos";
            this.labelapellido.Click += new System.EventHandler(this.labelapellido_Click);
            // 
            // labelCorreo
            // 
            this.labelCorreo.AutoSize = true;
            this.labelCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCorreo.ForeColor = System.Drawing.Color.Black;
            this.labelCorreo.Location = new System.Drawing.Point(56, 549);
            this.labelCorreo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCorreo.Name = "labelCorreo";
            this.labelCorreo.Size = new System.Drawing.Size(104, 15);
            this.labelCorreo.TabIndex = 9;
            this.labelCorreo.Text = "Ingrese su Correo";
            this.labelCorreo.Click += new System.EventHandler(this.labelCorreo_Click);
            // 
            // labelContraseña
            // 
            this.labelContraseña.AutoSize = true;
            this.labelContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContraseña.ForeColor = System.Drawing.Color.Black;
            this.labelContraseña.Location = new System.Drawing.Point(53, 633);
            this.labelContraseña.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelContraseña.Name = "labelContraseña";
            this.labelContraseña.Size = new System.Drawing.Size(133, 15);
            this.labelContraseña.TabIndex = 10;
            this.labelContraseña.Text = "Ingrese  su Contraseña";
            this.labelContraseña.Click += new System.EventHandler(this.labelContraseña_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::login.Properties.Resources.perfil_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(97, 25);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(298, 269);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // CrearCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(473, 771);
            this.Controls.Add(this.labelContraseña);
            this.Controls.Add(this.labelCorreo);
            this.Controls.Add(this.labelapellido);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.tbCorreo);
            this.Controls.Add(this.tbContraseña);
            this.Controls.Add(this.btGuardar);
            this.Controls.Add(this.tbApellidos);
            this.Controls.Add(this.tbNombres);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "CrearCuenta";
            this.Text = "CrearCuenta";
            this.Load += new System.EventHandler(this.CrearCuenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbNombres;
        private System.Windows.Forms.TextBox tbApellidos;
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.TextBox tbContraseña;
        private System.Windows.Forms.TextBox tbCorreo;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelapellido;
        private System.Windows.Forms.Label labelCorreo;
        private System.Windows.Forms.Label labelContraseña;
    }
}