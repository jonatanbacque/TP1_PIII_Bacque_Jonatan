namespace TP1
{
    partial class Personas
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNacimiento = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblEdadCalculada = new System.Windows.Forms.Label();
            this.grpboxGenero = new System.Windows.Forms.GroupBox();
            this.rdbuttonFemenino = new System.Windows.Forms.RadioButton();
            this.rdbuttonMasculino = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.grpboxGenero.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(87, 28);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(87, 53);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "Apellido";
            // 
            // lblNacimiento
            // 
            this.lblNacimiento.AutoSize = true;
            this.lblNacimiento.Location = new System.Drawing.Point(23, 78);
            this.lblNacimiento.Name = "lblNacimiento";
            this.lblNacimiento.Size = new System.Drawing.Size(108, 13);
            this.lblNacimiento.TabIndex = 2;
            this.lblNacimiento.Text = "Fecha de Nacimiento";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(144, 24);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(144, 49);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(200, 20);
            this.txtApellido.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(144, 74);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 5;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(99, 102);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(32, 13);
            this.lblEdad.TabIndex = 6;
            this.lblEdad.Text = "Edad";
            // 
            // lblEdadCalculada
            // 
            this.lblEdadCalculada.AutoSize = true;
            this.lblEdadCalculada.Location = new System.Drawing.Point(144, 102);
            this.lblEdadCalculada.Name = "lblEdadCalculada";
            this.lblEdadCalculada.Size = new System.Drawing.Size(142, 13);
            this.lblEdadCalculada.TabIndex = 7;
            this.lblEdadCalculada.Text = "Elija su fecha de nacimiento.";
            // 
            // grpboxGenero
            // 
            this.grpboxGenero.Controls.Add(this.radioButton1);
            this.grpboxGenero.Controls.Add(this.rdbuttonFemenino);
            this.grpboxGenero.Controls.Add(this.rdbuttonMasculino);
            this.grpboxGenero.Location = new System.Drawing.Point(32, 132);
            this.grpboxGenero.Name = "grpboxGenero";
            this.grpboxGenero.Size = new System.Drawing.Size(373, 54);
            this.grpboxGenero.TabIndex = 8;
            this.grpboxGenero.TabStop = false;
            this.grpboxGenero.Text = "Sexo";
            // 
            // rdbuttonFemenino
            // 
            this.rdbuttonFemenino.AutoSize = true;
            this.rdbuttonFemenino.Location = new System.Drawing.Point(149, 19);
            this.rdbuttonFemenino.Name = "rdbuttonFemenino";
            this.rdbuttonFemenino.Size = new System.Drawing.Size(71, 17);
            this.rdbuttonFemenino.TabIndex = 1;
            this.rdbuttonFemenino.TabStop = true;
            this.rdbuttonFemenino.Text = "Femenino";
            this.rdbuttonFemenino.UseVisualStyleBackColor = true;
            // 
            // rdbuttonMasculino
            // 
            this.rdbuttonMasculino.AutoSize = true;
            this.rdbuttonMasculino.Checked = true;
            this.rdbuttonMasculino.Location = new System.Drawing.Point(14, 20);
            this.rdbuttonMasculino.Name = "rdbuttonMasculino";
            this.rdbuttonMasculino.Size = new System.Drawing.Size(73, 17);
            this.rdbuttonMasculino.TabIndex = 0;
            this.rdbuttonMasculino.TabStop = true;
            this.rdbuttonMasculino.Text = "Masculino";
            this.rdbuttonMasculino.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(282, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(45, 17);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Otro";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // Personas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 462);
            this.Controls.Add(this.grpboxGenero);
            this.Controls.Add(this.lblEdadCalculada);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNacimiento);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Name = "Personas";
            this.Text = "Personas";
            this.grpboxGenero.ResumeLayout(false);
            this.grpboxGenero.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNacimiento;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblEdadCalculada;
        private System.Windows.Forms.GroupBox grpboxGenero;
        private System.Windows.Forms.RadioButton rdbuttonMasculino;
        private System.Windows.Forms.RadioButton rdbuttonFemenino;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}