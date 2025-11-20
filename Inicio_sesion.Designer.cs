namespace REDEMPLEO
{
    partial class Inicio_sesion
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_CORREO_ = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_CONTRA_ = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_iniciarSesion_ = new REDEMPLEO.Controles.Bordes_Boton();
            this.btn_registra_ = new REDEMPLEO.Controles.Bordes_Boton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(176, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Iniciar Sesión";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contraseña";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(94, 359);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "¿No tienes una cuenta?";
            // 
            // txt_CORREO_
            // 
            this.txt_CORREO_.BorderRadius = 15;
            this.txt_CORREO_.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_CORREO_.DefaultText = "";
            this.txt_CORREO_.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_CORREO_.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_CORREO_.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_CORREO_.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_CORREO_.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_CORREO_.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_CORREO_.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_CORREO_.Location = new System.Drawing.Point(48, 135);
            this.txt_CORREO_.Name = "txt_CORREO_";
            this.txt_CORREO_.PlaceholderText = "Email";
            this.txt_CORREO_.SelectedText = "";
            this.txt_CORREO_.Size = new System.Drawing.Size(200, 36);
            this.txt_CORREO_.TabIndex = 8;
            // 
            // txt_CONTRA_
            // 
            this.txt_CONTRA_.BorderRadius = 15;
            this.txt_CONTRA_.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_CONTRA_.DefaultText = "";
            this.txt_CONTRA_.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_CONTRA_.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_CONTRA_.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_CONTRA_.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_CONTRA_.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_CONTRA_.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_CONTRA_.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_CONTRA_.Location = new System.Drawing.Point(48, 220);
            this.txt_CONTRA_.Name = "txt_CONTRA_";
            this.txt_CONTRA_.PlaceholderText = "Contraseña";
            this.txt_CONTRA_.SelectedText = "";
            this.txt_CONTRA_.Size = new System.Drawing.Size(200, 36);
            this.txt_CONTRA_.TabIndex = 9;
            // 
            // btn_iniciarSesion_
            // 
            this.btn_iniciarSesion_.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_iniciarSesion_.BackgroundColor = System.Drawing.SystemColors.HotTrack;
            this.btn_iniciarSesion_.BorderColor1 = System.Drawing.Color.PaleVioletRed;
            this.btn_iniciarSesion_.BorderRadius = 40;
            this.btn_iniciarSesion_.BorderSize = 0;
            this.btn_iniciarSesion_.FlatAppearance.BorderSize = 0;
            this.btn_iniciarSesion_.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_iniciarSesion_.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_iniciarSesion_.ForeColor = System.Drawing.Color.White;
            this.btn_iniciarSesion_.Location = new System.Drawing.Point(181, 273);
            this.btn_iniciarSesion_.Name = "btn_iniciarSesion_";
            this.btn_iniciarSesion_.Size = new System.Drawing.Size(150, 40);
            this.btn_iniciarSesion_.TabIndex = 10;
            this.btn_iniciarSesion_.Text = "Iniciar Sesión";
            this.btn_iniciarSesion_.TextColor = System.Drawing.Color.White;
            this.btn_iniciarSesion_.UseVisualStyleBackColor = false;
            this.btn_iniciarSesion_.Click += new System.EventHandler(this.btn_iniciarSesion__Click);
            // 
            // btn_registra_
            // 
            this.btn_registra_.BackColor = System.Drawing.SystemColors.Control;
            this.btn_registra_.BackgroundColor = System.Drawing.SystemColors.Control;
            this.btn_registra_.BorderColor1 = System.Drawing.Color.PaleVioletRed;
            this.btn_registra_.BorderRadius = 40;
            this.btn_registra_.BorderSize = 0;
            this.btn_registra_.FlatAppearance.BorderSize = 0;
            this.btn_registra_.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_registra_.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_registra_.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_registra_.Location = new System.Drawing.Point(262, 348);
            this.btn_registra_.Name = "btn_registra_";
            this.btn_registra_.Size = new System.Drawing.Size(150, 40);
            this.btn_registra_.TabIndex = 11;
            this.btn_registra_.Text = "Regístrate aquí";
            this.btn_registra_.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_registra_.UseVisualStyleBackColor = false;
            this.btn_registra_.Click += new System.EventHandler(this.btn_registra__Click);
            // 
            // Inicio_sesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 426);
            this.Controls.Add(this.btn_registra_);
            this.Controls.Add(this.btn_iniciarSesion_);
            this.Controls.Add(this.txt_CONTRA_);
            this.Controls.Add(this.txt_CORREO_);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Inicio_sesion";
            this.Text = "Inicio_sesion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txt_CORREO_;
        private Guna.UI2.WinForms.Guna2TextBox txt_CONTRA_;
        private Controles.Bordes_Boton btn_iniciarSesion_;
        private Controles.Bordes_Boton btn_registra_;
    }
}