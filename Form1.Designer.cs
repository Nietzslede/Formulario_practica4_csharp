namespace Formulario_practica4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LbNombre = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.LbApellidos = new System.Windows.Forms.Label();
            this.LbTelefono = new System.Windows.Forms.Label();
            this.LbEstatura = new System.Windows.Forms.Label();
            this.LbEdad = new System.Windows.Forms.Label();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnBorrar = new System.Windows.Forms.Button();
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.TxtTelefono = new System.Windows.Forms.TextBox();
            this.TxtEstatura = new System.Windows.Forms.TextBox();
            this.TxtEdad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.GruopGenero = new System.Windows.Forms.GroupBox();
            this.RadioBFemenino = new System.Windows.Forms.RadioButton();
            this.RadioBMasculino = new System.Windows.Forms.RadioButton();
            this.BtnFinalizar = new System.Windows.Forms.Button();
            this.GruopGenero.SuspendLayout();
            this.SuspendLayout();
            // 
            // LbNombre
            // 
            this.LbNombre.AutoSize = true;
            this.LbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbNombre.Location = new System.Drawing.Point(143, 98);
            this.LbNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbNombre.Name = "LbNombre";
            this.LbNombre.Size = new System.Drawing.Size(64, 17);
            this.LbNombre.TabIndex = 0;
            this.LbNombre.Text = "Nombre";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(224, 96);
            this.TxtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(132, 22);
            this.TxtNombre.TabIndex = 1;
            // 
            // LbApellidos
            // 
            this.LbApellidos.AutoSize = true;
            this.LbApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbApellidos.Location = new System.Drawing.Point(133, 160);
            this.LbApellidos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbApellidos.Name = "LbApellidos";
            this.LbApellidos.Size = new System.Drawing.Size(74, 17);
            this.LbApellidos.TabIndex = 2;
            this.LbApellidos.Text = "Apellidos";
            // 
            // LbTelefono
            // 
            this.LbTelefono.AutoSize = true;
            this.LbTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTelefono.Location = new System.Drawing.Point(135, 231);
            this.LbTelefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbTelefono.Name = "LbTelefono";
            this.LbTelefono.Size = new System.Drawing.Size(72, 17);
            this.LbTelefono.TabIndex = 3;
            this.LbTelefono.Text = "Telefono";
            // 
            // LbEstatura
            // 
            this.LbEstatura.AutoSize = true;
            this.LbEstatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbEstatura.Location = new System.Drawing.Point(138, 302);
            this.LbEstatura.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbEstatura.Name = "LbEstatura";
            this.LbEstatura.Size = new System.Drawing.Size(69, 17);
            this.LbEstatura.TabIndex = 4;
            this.LbEstatura.Text = "Estatura";
            // 
            // LbEdad
            // 
            this.LbEdad.AutoSize = true;
            this.LbEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbEdad.Location = new System.Drawing.Point(143, 368);
            this.LbEdad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbEdad.Name = "LbEdad";
            this.LbEdad.Size = new System.Drawing.Size(45, 17);
            this.LbEdad.TabIndex = 5;
            this.LbEdad.Text = "Edad";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.Lime;
            this.BtnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.Location = new System.Drawing.Point(122, 555);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(115, 42);
            this.BtnGuardar.TabIndex = 6;
            this.BtnGuardar.Text = "GUARDAR";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            // 
            // BtnBorrar
            // 
            this.BtnBorrar.BackColor = System.Drawing.Color.Red;
            this.BtnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBorrar.Location = new System.Drawing.Point(280, 555);
            this.BtnBorrar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnBorrar.Name = "BtnBorrar";
            this.BtnBorrar.Size = new System.Drawing.Size(115, 42);
            this.BtnBorrar.TabIndex = 7;
            this.BtnBorrar.Text = "BORRAR";
            this.BtnBorrar.UseVisualStyleBackColor = false;
            // 
            // TxtApellido
            // 
            this.TxtApellido.Location = new System.Drawing.Point(224, 158);
            this.TxtApellido.Margin = new System.Windows.Forms.Padding(4);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(132, 22);
            this.TxtApellido.TabIndex = 8;
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Location = new System.Drawing.Point(224, 229);
            this.TxtTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(132, 22);
            this.TxtTelefono.TabIndex = 9;
            // 
            // TxtEstatura
            // 
            this.TxtEstatura.Location = new System.Drawing.Point(224, 297);
            this.TxtEstatura.Margin = new System.Windows.Forms.Padding(4);
            this.TxtEstatura.Name = "TxtEstatura";
            this.TxtEstatura.Size = new System.Drawing.Size(132, 22);
            this.TxtEstatura.TabIndex = 10;
            // 
            // TxtEdad
            // 
            this.TxtEdad.Location = new System.Drawing.Point(224, 363);
            this.TxtEdad.Margin = new System.Windows.Forms.Padding(4);
            this.TxtEdad.Name = "TxtEdad";
            this.TxtEdad.Size = new System.Drawing.Size(132, 22);
            this.TxtEdad.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(141, 25);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(233, 27);
            this.label6.TabIndex = 12;
            this.label6.Text = "Registro UNACH 2025";
            // 
            // GruopGenero
            // 
            this.GruopGenero.Controls.Add(this.RadioBFemenino);
            this.GruopGenero.Controls.Add(this.RadioBMasculino);
            this.GruopGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GruopGenero.Location = new System.Drawing.Point(112, 424);
            this.GruopGenero.Margin = new System.Windows.Forms.Padding(4);
            this.GruopGenero.Name = "GruopGenero";
            this.GruopGenero.Padding = new System.Windows.Forms.Padding(4);
            this.GruopGenero.Size = new System.Drawing.Size(300, 101);
            this.GruopGenero.TabIndex = 13;
            this.GruopGenero.TabStop = false;
            this.GruopGenero.Text = "Genero";
            // 
            // RadioBFemenino
            // 
            this.RadioBFemenino.AutoSize = true;
            this.RadioBFemenino.Location = new System.Drawing.Point(184, 52);
            this.RadioBFemenino.Margin = new System.Windows.Forms.Padding(4);
            this.RadioBFemenino.Name = "RadioBFemenino";
            this.RadioBFemenino.Size = new System.Drawing.Size(99, 21);
            this.RadioBFemenino.TabIndex = 1;
            this.RadioBFemenino.TabStop = true;
            this.RadioBFemenino.Text = "Femenino";
            this.RadioBFemenino.UseVisualStyleBackColor = true;
            // 
            // RadioBMasculino
            // 
            this.RadioBMasculino.AutoSize = true;
            this.RadioBMasculino.Location = new System.Drawing.Point(24, 52);
            this.RadioBMasculino.Margin = new System.Windows.Forms.Padding(4);
            this.RadioBMasculino.Name = "RadioBMasculino";
            this.RadioBMasculino.Size = new System.Drawing.Size(101, 21);
            this.RadioBMasculino.TabIndex = 0;
            this.RadioBMasculino.TabStop = true;
            this.RadioBMasculino.Text = "Masculino";
            this.RadioBMasculino.UseVisualStyleBackColor = true;
            // 
            // BtnFinalizar
            // 
            this.BtnFinalizar.BackColor = System.Drawing.Color.Orange;
            this.BtnFinalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFinalizar.Location = new System.Drawing.Point(402, 639);
            this.BtnFinalizar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnFinalizar.Name = "BtnFinalizar";
            this.BtnFinalizar.Size = new System.Drawing.Size(113, 28);
            this.BtnFinalizar.TabIndex = 14;
            this.BtnFinalizar.Text = "FINALIZAR";
            this.BtnFinalizar.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(528, 680);
            this.Controls.Add(this.BtnFinalizar);
            this.Controls.Add(this.GruopGenero);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtEdad);
            this.Controls.Add(this.TxtEstatura);
            this.Controls.Add(this.TxtTelefono);
            this.Controls.Add(this.TxtApellido);
            this.Controls.Add(this.BtnBorrar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.LbEdad);
            this.Controls.Add(this.LbEstatura);
            this.Controls.Add(this.LbTelefono);
            this.Controls.Add(this.LbApellidos);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.LbNombre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Formulario de Registro ";
            this.GruopGenero.ResumeLayout(false);
            this.GruopGenero.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbNombre;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Label LbApellidos;
        private System.Windows.Forms.Label LbTelefono;
        private System.Windows.Forms.Label LbEstatura;
        private System.Windows.Forms.Label LbEdad;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnBorrar;
        private System.Windows.Forms.TextBox TxtApellido;
        private System.Windows.Forms.TextBox TxtTelefono;
        private System.Windows.Forms.TextBox TxtEstatura;
        private System.Windows.Forms.TextBox TxtEdad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox GruopGenero;
        private System.Windows.Forms.RadioButton RadioBFemenino;
        private System.Windows.Forms.RadioButton RadioBMasculino;
        private System.Windows.Forms.Button BtnFinalizar;
    }
}