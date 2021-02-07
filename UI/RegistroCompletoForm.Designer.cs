
namespace PrimerRegistroCompleto
{
    partial class RegistroCompletoForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroCompletoForm));
            this.idRollabel = new System.Windows.Forms.Label();
            this.fechaCreacionlabel = new System.Windows.Forms.Label();
            this.descripcionlabel = new System.Windows.Forms.Label();
            this.idRolTextBox = new System.Windows.Forms.TextBox();
            this.fechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.EditarButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.notaLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // idRollabel
            // 
            this.idRollabel.AutoSize = true;
            this.idRollabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.idRollabel.Location = new System.Drawing.Point(39, 64);
            this.idRollabel.Name = "idRollabel";
            this.idRollabel.Size = new System.Drawing.Size(53, 21);
            this.idRollabel.TabIndex = 0;
            this.idRollabel.Text = "Id Rol:";
            // 
            // fechaCreacionlabel
            // 
            this.fechaCreacionlabel.AutoSize = true;
            this.fechaCreacionlabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fechaCreacionlabel.Location = new System.Drawing.Point(39, 133);
            this.fechaCreacionlabel.Name = "fechaCreacionlabel";
            this.fechaCreacionlabel.Size = new System.Drawing.Size(136, 21);
            this.fechaCreacionlabel.TabIndex = 1;
            this.fechaCreacionlabel.Text = "Fecha de creación:";
            // 
            // descripcionlabel
            // 
            this.descripcionlabel.AutoSize = true;
            this.descripcionlabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.descripcionlabel.Location = new System.Drawing.Point(39, 204);
            this.descripcionlabel.Name = "descripcionlabel";
            this.descripcionlabel.Size = new System.Drawing.Size(94, 21);
            this.descripcionlabel.TabIndex = 2;
            this.descripcionlabel.Text = "Descripción:";
            // 
            // idRolTextBox
            // 
            this.idRolTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.idRolTextBox.Location = new System.Drawing.Point(181, 61);
            this.idRolTextBox.Name = "idRolTextBox";
            this.idRolTextBox.Size = new System.Drawing.Size(200, 29);
            this.idRolTextBox.TabIndex = 3;
            // 
            // fechaDateTimePicker
            // 
            this.fechaDateTimePicker.Location = new System.Drawing.Point(181, 133);
            this.fechaDateTimePicker.Name = "fechaDateTimePicker";
            this.fechaDateTimePicker.Size = new System.Drawing.Size(200, 23);
            this.fechaDateTimePicker.TabIndex = 4;
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.descripcionTextBox.Location = new System.Drawing.Point(181, 204);
            this.descripcionTextBox.Multiline = true;
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(200, 26);
            this.descripcionTextBox.TabIndex = 5;
            // 
            // EditarButton
            // 
            this.EditarButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EditarButton.Image = ((System.Drawing.Image)(resources.GetObject("EditarButton.Image")));
            this.EditarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.EditarButton.Location = new System.Drawing.Point(430, 121);
            this.EditarButton.Name = "EditarButton";
            this.EditarButton.Size = new System.Drawing.Size(92, 54);
            this.EditarButton.TabIndex = 7;
            this.EditarButton.Text = "Editar";
            this.EditarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.EditarButton.UseVisualStyleBackColor = true;
            this.EditarButton.Click += new System.EventHandler(this.EditarButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GuardarButton.Image = ((System.Drawing.Image)(resources.GetObject("GuardarButton.Image")));
            this.GuardarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.GuardarButton.Location = new System.Drawing.Point(430, 61);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(92, 54);
            this.GuardarButton.TabIndex = 8;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // EliminarButton
            // 
            this.EliminarButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EliminarButton.Image = ((System.Drawing.Image)(resources.GetObject("EliminarButton.Image")));
            this.EliminarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.EliminarButton.Location = new System.Drawing.Point(430, 181);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(92, 54);
            this.EliminarButton.TabIndex = 9;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // notaLabel
            // 
            this.notaLabel.AutoSize = true;
            this.notaLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.notaLabel.ForeColor = System.Drawing.Color.Red;
            this.notaLabel.Location = new System.Drawing.Point(331, 238);
            this.notaLabel.Name = "notaLabel";
            this.notaLabel.Size = new System.Drawing.Size(191, 15);
            this.notaLabel.TabIndex = 11;
            this.notaLabel.Text = "Nota: solo se puede eliminar por Id.";
            // 
            // RegistroCompletoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 337);
            this.Controls.Add(this.notaLabel);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.EditarButton);
            this.Controls.Add(this.descripcionTextBox);
            this.Controls.Add(this.fechaDateTimePicker);
            this.Controls.Add(this.idRolTextBox);
            this.Controls.Add(this.descripcionlabel);
            this.Controls.Add(this.fechaCreacionlabel);
            this.Controls.Add(this.idRollabel);
            this.Name = "RegistroCompletoForm";
            this.Text = "Registro Completo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label idRollabel;
        private System.Windows.Forms.Label fechaCreacionlabel;
        private System.Windows.Forms.Label descripcionlabel;
        private System.Windows.Forms.TextBox idRolTextBox;
        private System.Windows.Forms.DateTimePicker fechaDateTimePicker;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.Button EditarButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Label notaLabel;
    }
}

