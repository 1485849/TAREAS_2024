namespace login
{
    partial class IniciarSesion
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbIngreseUsuario = new System.Windows.Forms.TextBox();
            this.tbIngreseContraseña = new System.Windows.Forms.TextBox();
            this.labelIngreseUsuario = new System.Windows.Forms.Label();
            this.labelIngreseContraseña = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::login.Properties.Resources.perfil_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(54, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(355, 241);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tbIngreseUsuario
            // 
            this.tbIngreseUsuario.Location = new System.Drawing.Point(71, 313);
            this.tbIngreseUsuario.Multiline = true;
            this.tbIngreseUsuario.Name = "tbIngreseUsuario";
            this.tbIngreseUsuario.Size = new System.Drawing.Size(319, 41);
            this.tbIngreseUsuario.TabIndex = 1;
            // 
            // tbIngreseContraseña
            // 
            this.tbIngreseContraseña.Location = new System.Drawing.Point(71, 394);
            this.tbIngreseContraseña.Multiline = true;
            this.tbIngreseContraseña.Name = "tbIngreseContraseña";
            this.tbIngreseContraseña.Size = new System.Drawing.Size(319, 41);
            this.tbIngreseContraseña.TabIndex = 3;
            // 
            // labelIngreseUsuario
            // 
            this.labelIngreseUsuario.AutoSize = true;
            this.labelIngreseUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIngreseUsuario.Location = new System.Drawing.Point(79, 357);
            this.labelIngreseUsuario.Name = "labelIngreseUsuario";
            this.labelIngreseUsuario.Size = new System.Drawing.Size(128, 15);
            this.labelIngreseUsuario.TabIndex = 4;
            this.labelIngreseUsuario.Text = "Ingrese su Usuario";
            // 
            // labelIngreseContraseña
            // 
            this.labelIngreseContraseña.AutoSize = true;
            this.labelIngreseContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIngreseContraseña.Location = new System.Drawing.Point(73, 447);
            this.labelIngreseContraseña.Name = "labelIngreseContraseña";
            this.labelIngreseContraseña.Size = new System.Drawing.Size(132, 15);
            this.labelIngreseContraseña.TabIndex = 5;
            this.labelIngreseContraseña.Text = "Ingrese Contraseña";
            // 
            // btnIngresar
            // 
            this.btnIngresar.Font = new System.Drawing.Font("Ravie", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.Location = new System.Drawing.Point(164, 499);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(118, 46);
            this.btnIngresar.TabIndex = 6;
            this.btnIngresar.Text = "Iniciar Sesion";
            this.btnIngresar.UseVisualStyleBackColor = true;
            // 
            // IniciarSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(461, 684);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.labelIngreseContraseña);
            this.Controls.Add(this.labelIngreseUsuario);
            this.Controls.Add(this.tbIngreseContraseña);
            this.Controls.Add(this.tbIngreseUsuario);
            this.Controls.Add(this.pictureBox1);
            this.Name = "IniciarSesion";
            this.Text = "IniciarSesion";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbIngreseUsuario;
        private System.Windows.Forms.TextBox tbIngreseContraseña;
        private System.Windows.Forms.Label labelIngreseUsuario;
        private System.Windows.Forms.Label labelIngreseContraseña;
        private System.Windows.Forms.Button btnIngresar;
    }
}