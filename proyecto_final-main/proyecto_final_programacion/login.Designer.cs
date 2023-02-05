
namespace proyecto_final_programacion
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.TBL_usuario = new System.Windows.Forms.TextBox();
            this.TBX_password = new System.Windows.Forms.TextBox();
            this.BTN_inciar = new System.Windows.Forms.Button();
            this.BTN_cancelar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.imagen_logo = new System.Windows.Forms.PictureBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.TituloDelLogin = new System.Windows.Forms.Label();
            this.BTN_cerrar_login = new System.Windows.Forms.Button();
            this.BTN_minimizar_login = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagen_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // TBL_usuario
            // 
            this.TBL_usuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBL_usuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.TBL_usuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBL_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBL_usuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.TBL_usuario.Location = new System.Drawing.Point(258, 143);
            this.TBL_usuario.Name = "TBL_usuario";
            this.TBL_usuario.Size = new System.Drawing.Size(449, 19);
            this.TBL_usuario.TabIndex = 2;
            this.TBL_usuario.Text = "USUARIO";
            this.TBL_usuario.Enter += new System.EventHandler(this.textBox1_Enter);
            this.TBL_usuario.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // TBX_password
            // 
            this.TBX_password.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBX_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.TBX_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBX_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBX_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.TBX_password.Location = new System.Drawing.Point(258, 226);
            this.TBX_password.MaxLength = 30;
            this.TBX_password.Name = "TBX_password";
            this.TBX_password.Size = new System.Drawing.Size(449, 19);
            this.TBX_password.TabIndex = 3;
            this.TBX_password.Tag = "";
            this.TBX_password.Text = "PASSWORD";
            this.TBX_password.Enter += new System.EventHandler(this.textBox2_Enter);
            this.TBX_password.Leave += new System.EventHandler(this.textBox2_Leave);
            // 
            // BTN_inciar
            // 
            this.BTN_inciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BTN_inciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_inciar.FlatAppearance.BorderSize = 0;
            this.BTN_inciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_inciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_inciar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BTN_inciar.Location = new System.Drawing.Point(258, 300);
            this.BTN_inciar.Name = "BTN_inciar";
            this.BTN_inciar.Size = new System.Drawing.Size(166, 34);
            this.BTN_inciar.TabIndex = 4;
            this.BTN_inciar.Text = "INICIAR";
            this.BTN_inciar.UseVisualStyleBackColor = false;
            this.BTN_inciar.Click += new System.EventHandler(this.button1_Click);
            // 
            // BTN_cancelar
            // 
            this.BTN_cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BTN_cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_cancelar.FlatAppearance.BorderSize = 0;
            this.BTN_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_cancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BTN_cancelar.Location = new System.Drawing.Point(541, 300);
            this.BTN_cancelar.Name = "BTN_cancelar";
            this.BTN_cancelar.Size = new System.Drawing.Size(166, 34);
            this.BTN_cancelar.TabIndex = 1;
            this.BTN_cancelar.Text = "CANCELAR";
            this.BTN_cancelar.UseVisualStyleBackColor = false;
            this.BTN_cancelar.Click += new System.EventHandler(this.BTN_cancelar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.imagen_logo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(205, 394);
            this.panel1.TabIndex = 18;
            // 
            // imagen_logo
            // 
            this.imagen_logo.Image = ((System.Drawing.Image)(resources.GetObject("imagen_logo.Image")));
            this.imagen_logo.Location = new System.Drawing.Point(12, 122);
            this.imagen_logo.Name = "imagen_logo";
            this.imagen_logo.Size = new System.Drawing.Size(182, 123);
            this.imagen_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagen_logo.TabIndex = 0;
            this.imagen_logo.TabStop = false;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(781, 394);
            this.shapeContainer1.TabIndex = 19;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.Color.Silver;
            this.lineShape2.Enabled = false;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 257;
            this.lineShape2.X2 = 703;
            this.lineShape2.Y1 = 252;
            this.lineShape2.Y2 = 252;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.Silver;
            this.lineShape1.Enabled = false;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 257;
            this.lineShape1.X2 = 703;
            this.lineShape1.Y1 = 169;
            this.lineShape1.Y2 = 169;
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.SystemColors.MenuHighlight;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Plum;
            this.linkLabel1.Location = new System.Drawing.Point(418, 354);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(145, 14);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "No recuerdas la password?";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TituloDelLogin
            // 
            this.TituloDelLogin.AutoSize = true;
            this.TituloDelLogin.Font = new System.Drawing.Font("Modern No. 20", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloDelLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.TituloDelLogin.Location = new System.Drawing.Point(424, 9);
            this.TituloDelLogin.Name = "TituloDelLogin";
            this.TituloDelLogin.Size = new System.Drawing.Size(129, 36);
            this.TituloDelLogin.TabIndex = 0;
            this.TituloDelLogin.Text = "LOGIN";
            this.TituloDelLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BTN_cerrar_login
            // 
            this.BTN_cerrar_login.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_cerrar_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_cerrar_login.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BTN_cerrar_login.FlatAppearance.BorderSize = 0;
            this.BTN_cerrar_login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BTN_cerrar_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_cerrar_login.Image = global::proyecto_final_programacion.Properties.Resources.imagenCerrar1;
            this.BTN_cerrar_login.Location = new System.Drawing.Point(749, 3);
            this.BTN_cerrar_login.Name = "BTN_cerrar_login";
            this.BTN_cerrar_login.Size = new System.Drawing.Size(29, 32);
            this.BTN_cerrar_login.TabIndex = 7;
            this.BTN_cerrar_login.UseVisualStyleBackColor = true;
            this.BTN_cerrar_login.Click += new System.EventHandler(this.BTN_cerrar_login_Click);
            // 
            // BTN_minimizar_login
            // 
            this.BTN_minimizar_login.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_minimizar_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_minimizar_login.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BTN_minimizar_login.FlatAppearance.BorderSize = 0;
            this.BTN_minimizar_login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BTN_minimizar_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_minimizar_login.Image = global::proyecto_final_programacion.Properties.Resources.imagenMinimizar;
            this.BTN_minimizar_login.Location = new System.Drawing.Point(714, 3);
            this.BTN_minimizar_login.Name = "BTN_minimizar_login";
            this.BTN_minimizar_login.Size = new System.Drawing.Size(29, 32);
            this.BTN_minimizar_login.TabIndex = 6;
            this.BTN_minimizar_login.UseVisualStyleBackColor = true;
            this.BTN_minimizar_login.Click += new System.EventHandler(this.BTN_minimizar_login_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(225, 354);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "0";
            this.label1.Visible = false;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(781, 394);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTN_minimizar_login);
            this.Controls.Add(this.BTN_cerrar_login);
            this.Controls.Add(this.TituloDelLogin);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BTN_cancelar);
            this.Controls.Add(this.BTN_inciar);
            this.Controls.Add(this.TBX_password);
            this.Controls.Add(this.TBL_usuario);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "login";
            this.Opacity = 0.98D;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio de sesion";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.login_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.login_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.login_MouseUp);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imagen_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TBL_usuario;
        private System.Windows.Forms.TextBox TBX_password;
        private System.Windows.Forms.Button BTN_inciar;
        private System.Windows.Forms.Button BTN_cancelar;
        private System.Windows.Forms.Panel panel1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox imagen_logo;
        private System.Windows.Forms.Label TituloDelLogin;
        private System.Windows.Forms.Button BTN_cerrar_login;
        private System.Windows.Forms.Button BTN_minimizar_login;
        private System.Windows.Forms.Label label1;
    }
}

