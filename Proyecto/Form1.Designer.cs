namespace Proyecto
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
            this.lbl = new System.Windows.Forms.Label();
            this.lbluser = new System.Windows.Forms.Label();
            this.lblpass = new System.Windows.Forms.Label();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtaccess = new System.Windows.Forms.Button();
            this.txtsqlserver = new System.Windows.Forms.Button();
            this.txtsalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(109, 28);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(141, 20);
            this.lbl.TabIndex = 0;
            this.lbl.Text = "Ingreso al Sistema";
            // 
            // lbluser
            // 
            this.lbluser.AutoSize = true;
            this.lbluser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluser.Location = new System.Drawing.Point(57, 99);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(62, 17);
            this.lbluser.TabIndex = 1;
            this.lbluser.Text = "Usuario*";
            // 
            // lblpass
            // 
            this.lblpass.AutoSize = true;
            this.lblpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpass.Location = new System.Drawing.Point(33, 148);
            this.lblpass.Name = "lblpass";
            this.lblpass.Size = new System.Drawing.Size(86, 17);
            this.lblpass.TabIndex = 2;
            this.lblpass.Text = "Contraseña*";
            // 
            // txtusuario
            // 
            this.txtusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusuario.Location = new System.Drawing.Point(135, 99);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(218, 23);
            this.txtusuario.TabIndex = 3;
            // 
            // txtpass
            // 
            this.txtpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpass.Location = new System.Drawing.Point(135, 145);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(218, 23);
            this.txtpass.TabIndex = 4;
            // 
            // txtaccess
            // 
            this.txtaccess.Location = new System.Drawing.Point(44, 204);
            this.txtaccess.Name = "txtaccess";
            this.txtaccess.Size = new System.Drawing.Size(121, 46);
            this.txtaccess.TabIndex = 5;
            this.txtaccess.Text = "Access";
            this.txtaccess.UseVisualStyleBackColor = true;
            this.txtaccess.Click += new System.EventHandler(this.Txtaccess_Click);
            // 
            // txtsqlserver
            // 
            this.txtsqlserver.Location = new System.Drawing.Point(208, 204);
            this.txtsqlserver.Name = "txtsqlserver";
            this.txtsqlserver.Size = new System.Drawing.Size(121, 46);
            this.txtsqlserver.TabIndex = 6;
            this.txtsqlserver.Text = "SQL Server";
            this.txtsqlserver.UseVisualStyleBackColor = true;
            this.txtsqlserver.Click += new System.EventHandler(this.Txtsqlserver_Click);
            // 
            // txtsalir
            // 
            this.txtsalir.Location = new System.Drawing.Point(113, 271);
            this.txtsalir.Name = "txtsalir";
            this.txtsalir.Size = new System.Drawing.Size(121, 46);
            this.txtsalir.TabIndex = 7;
            this.txtsalir.Text = "Salir";
            this.txtsalir.UseVisualStyleBackColor = true;
            this.txtsalir.Click += new System.EventHandler(this.Txtsalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 355);
            this.Controls.Add(this.txtsalir);
            this.Controls.Add(this.txtsqlserver);
            this.Controls.Add(this.txtaccess);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.lblpass);
            this.Controls.Add(this.lbluser);
            this.Controls.Add(this.lbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lbluser;
        private System.Windows.Forms.Label lblpass;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Button txtaccess;
        private System.Windows.Forms.Button txtsqlserver;
        private System.Windows.Forms.Button txtsalir;
    }
}

