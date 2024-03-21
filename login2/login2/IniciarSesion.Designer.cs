namespace login2
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
            this.btnIngresar = new System.Windows.Forms.Button();
            this.labelIngreseContraseña = new System.Windows.Forms.Label();
            this.labelIngreseUsuario = new System.Windows.Forms.Label();
            this.tbIngreseContraseña = new System.Windows.Forms.TextBox();
            this.tbIngreseUsuario = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIngresar
            // 
            this.btnIngresar.Font = new System.Drawing.Font("Ravie", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.Location = new System.Drawing.Point(140, 477);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(118, 46);
            this.btnIngresar.TabIndex = 12;
            this.btnIngresar.Text = "Iniciar Sesion";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // labelIngreseContraseña
            // 
            this.labelIngreseContraseña.AutoSize = true;
            this.labelIngreseContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIngreseContraseña.Location = new System.Drawing.Point(46, 412);
            this.labelIngreseContraseña.Name = "labelIngreseContraseña";
            this.labelIngreseContraseña.Size = new System.Drawing.Size(132, 15);
            this.labelIngreseContraseña.TabIndex = 11;
            this.labelIngreseContraseña.Text = "Ingrese Contraseña";
            // 
            // labelIngreseUsuario
            // 
            this.labelIngreseUsuario.AutoSize = true;
            this.labelIngreseUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIngreseUsuario.Location = new System.Drawing.Point(50, 331);
            this.labelIngreseUsuario.Name = "labelIngreseUsuario";
            this.labelIngreseUsuario.Size = new System.Drawing.Size(128, 15);
            this.labelIngreseUsuario.TabIndex = 10;
            this.labelIngreseUsuario.Text = "Ingrese su Usuario";
            // 
            // tbIngreseContraseña
            // 
            this.tbIngreseContraseña.Location = new System.Drawing.Point(42, 368);
            this.tbIngreseContraseña.Multiline = true;
            this.tbIngreseContraseña.Name = "tbIngreseContraseña";
            this.tbIngreseContraseña.Size = new System.Drawing.Size(319, 41);
            this.tbIngreseContraseña.TabIndex = 9;
            this.tbIngreseContraseña.TextChanged += new System.EventHandler(this.tbIngreseContraseña_TextChanged);
            // 
            // tbIngreseUsuario
            // 
            this.tbIngreseUsuario.Location = new System.Drawing.Point(42, 287);
            this.tbIngreseUsuario.Multiline = true;
            this.tbIngreseUsuario.Name = "tbIngreseUsuario";
            this.tbIngreseUsuario.Size = new System.Drawing.Size(319, 41);
            this.tbIngreseUsuario.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::login2.Properties.Resources.perfil_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(29, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(355, 241);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 546);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Al registrase, aceptas nuestras condiciones de ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 570);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = " uso y Politica de privacidad";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(241, 440);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(129, 13);
            this.linkLabel2.TabIndex = 27;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "¿olvidaste tu contraseña?";
            // 
            // IniciarSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(418, 638);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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

        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Label labelIngreseContraseña;
        private System.Windows.Forms.Label labelIngreseUsuario;
        private System.Windows.Forms.TextBox tbIngreseContraseña;
        private System.Windows.Forms.TextBox tbIngreseUsuario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel2;
    }
}