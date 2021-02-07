
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroCompletoForm));
            this.idLabel = new System.Windows.Forms.Label();
            this.aliasLabel = new System.Windows.Forms.Label();
            this.nombresLabel = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nombresTextBox = new System.Windows.Forms.TextBox();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.aliasTextBox = new System.Windows.Forms.TextBox();
            this.confirmarTextBox = new System.Windows.Forms.TextBox();
            this.claveTextBox = new System.Windows.Forms.TextBox();
            this.confirmarLabel = new System.Windows.Forms.Label();
            this.claveLabel = new System.Windows.Forms.Label();
            this.rolComboBox = new System.Windows.Forms.ComboBox();
            this.rolLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.activoCheckBox = new System.Windows.Forms.CheckBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.costolabel = new System.Windows.Forms.Label();
            this.costoTextBox = new System.Windows.Forms.TextBox();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.idLabel.Location = new System.Drawing.Point(12, 41);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(21, 15);
            this.idLabel.TabIndex = 0;
            this.idLabel.Text = "ID:";
            this.idLabel.Click += new System.EventHandler(this.idRollabel_Click);
            // 
            // aliasLabel
            // 
            this.aliasLabel.AutoSize = true;
            this.aliasLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.aliasLabel.Location = new System.Drawing.Point(12, 80);
            this.aliasLabel.Name = "aliasLabel";
            this.aliasLabel.Size = new System.Drawing.Size(35, 15);
            this.aliasLabel.TabIndex = 1;
            this.aliasLabel.Text = "Alias:";
            // 
            // nombresLabel
            // 
            this.nombresLabel.AutoSize = true;
            this.nombresLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nombresLabel.Location = new System.Drawing.Point(12, 131);
            this.nombresLabel.Name = "nombresLabel";
            this.nombresLabel.Size = new System.Drawing.Size(59, 15);
            this.nombresLabel.TabIndex = 2;
            this.nombresLabel.Text = "Nombres:";
            this.nombresLabel.Click += new System.EventHandler(this.descripcionlabel_Click);
            // 
            // idTextBox
            // 
            this.idTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.idTextBox.Location = new System.Drawing.Point(92, 33);
            this.idTextBox.Multiline = true;
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(120, 23);
            this.idTextBox.TabIndex = 3;
            // 
            // nombresTextBox
            // 
            this.nombresTextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nombresTextBox.Location = new System.Drawing.Point(92, 124);
            this.nombresTextBox.Multiline = true;
            this.nombresTextBox.Name = "nombresTextBox";
            this.nombresTextBox.Size = new System.Drawing.Size(291, 23);
            this.nombresTextBox.TabIndex = 5;
            // 
            // GuardarButton
            // 
            this.GuardarButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GuardarButton.Image = ((System.Drawing.Image)(resources.GetObject("GuardarButton.Image")));
            this.GuardarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.GuardarButton.Location = new System.Drawing.Point(313, 218);
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
            this.EliminarButton.Location = new System.Drawing.Point(431, 218);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(92, 54);
            this.EliminarButton.TabIndex = 9;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // aliasTextBox
            // 
            this.aliasTextBox.Location = new System.Drawing.Point(92, 77);
            this.aliasTextBox.Name = "aliasTextBox";
            this.aliasTextBox.Size = new System.Drawing.Size(200, 23);
            this.aliasTextBox.TabIndex = 12;
            // 
            // confirmarTextBox
            // 
            this.confirmarTextBox.Location = new System.Drawing.Point(358, 176);
            this.confirmarTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.confirmarTextBox.Name = "confirmarTextBox";
            this.confirmarTextBox.PasswordChar = '*';
            this.confirmarTextBox.Size = new System.Drawing.Size(110, 23);
            this.confirmarTextBox.TabIndex = 47;
            // 
            // claveTextBox
            // 
            this.claveTextBox.Location = new System.Drawing.Point(92, 173);
            this.claveTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.claveTextBox.Name = "claveTextBox";
            this.claveTextBox.PasswordChar = '*';
            this.claveTextBox.Size = new System.Drawing.Size(152, 23);
            this.claveTextBox.TabIndex = 46;
            // 
            // confirmarLabel
            // 
            this.confirmarLabel.AutoSize = true;
            this.confirmarLabel.Location = new System.Drawing.Point(259, 179);
            this.confirmarLabel.Name = "confirmarLabel";
            this.confirmarLabel.Size = new System.Drawing.Size(93, 15);
            this.confirmarLabel.TabIndex = 45;
            this.confirmarLabel.Text = "Confirmar Clave";
            // 
            // claveLabel
            // 
            this.claveLabel.AutoSize = true;
            this.claveLabel.Location = new System.Drawing.Point(12, 176);
            this.claveLabel.Name = "claveLabel";
            this.claveLabel.Size = new System.Drawing.Size(36, 15);
            this.claveLabel.TabIndex = 44;
            this.claveLabel.Text = "Clave";
            // 
            // rolComboBox
            // 
            this.rolComboBox.FormattingEnabled = true;
            this.rolComboBox.Location = new System.Drawing.Point(548, 88);
            this.rolComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rolComboBox.Name = "rolComboBox";
            this.rolComboBox.Size = new System.Drawing.Size(133, 23);
            this.rolComboBox.TabIndex = 55;
            // 
            // rolLabel
            // 
            this.rolLabel.AutoSize = true;
            this.rolLabel.Location = new System.Drawing.Point(518, 91);
            this.rolLabel.Name = "rolLabel";
            this.rolLabel.Size = new System.Drawing.Size(24, 15);
            this.rolLabel.TabIndex = 54;
            this.rolLabel.Text = "Rol";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(431, 126);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(250, 23);
            this.emailTextBox.TabIndex = 53;
            // 
            // activoCheckBox
            // 
            this.activoCheckBox.AutoSize = true;
            this.activoCheckBox.Location = new System.Drawing.Point(621, 56);
            this.activoCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.activoCheckBox.Name = "activoCheckBox";
            this.activoCheckBox.Size = new System.Drawing.Size(60, 19);
            this.activoCheckBox.TabIndex = 52;
            this.activoCheckBox.Text = "Activo";
            this.activoCheckBox.UseVisualStyleBackColor = true;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(389, 129);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(36, 15);
            this.emailLabel.TabIndex = 51;
            this.emailLabel.Text = "Email";
            // 
            // costolabel
            // 
            this.costolabel.AutoSize = true;
            this.costolabel.Location = new System.Drawing.Point(485, 179);
            this.costolabel.Name = "costolabel";
            this.costolabel.Size = new System.Drawing.Size(76, 15);
            this.costolabel.TabIndex = 56;
            this.costolabel.Text = "Costo x Hora";
            // 
            // costoTextBox
            // 
            this.costoTextBox.Location = new System.Drawing.Point(567, 176);
            this.costoTextBox.Name = "costoTextBox";
            this.costoTextBox.Size = new System.Drawing.Size(114, 23);
            this.costoTextBox.TabIndex = 57;
            // 
            // NuevoButton
            // 
            this.NuevoButton.Image = ((System.Drawing.Image)(resources.GetObject("NuevoButton.Image")));
            this.NuevoButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.NuevoButton.Location = new System.Drawing.Point(200, 218);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(92, 54);
            this.NuevoButton.TabIndex = 58;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // BuscarButton
            // 
            this.BuscarButton.Image = ((System.Drawing.Image)(resources.GetObject("BuscarButton.Image")));
            this.BuscarButton.Location = new System.Drawing.Point(218, 28);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(41, 40);
            this.BuscarButton.TabIndex = 59;
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // RegistroCompletoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 294);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.costoTextBox);
            this.Controls.Add(this.costolabel);
            this.Controls.Add(this.rolComboBox);
            this.Controls.Add(this.rolLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.activoCheckBox);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.confirmarTextBox);
            this.Controls.Add(this.claveTextBox);
            this.Controls.Add(this.confirmarLabel);
            this.Controls.Add(this.claveLabel);
            this.Controls.Add(this.aliasTextBox);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.nombresTextBox);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.nombresLabel);
            this.Controls.Add(this.aliasLabel);
            this.Controls.Add(this.idLabel);
            this.Name = "RegistroCompletoForm";
            this.Text = "Registro Completo";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label aliasLabel;
        private System.Windows.Forms.Label nombresLabel;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nombresTextBox;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.TextBox aliasTextBox;
        private System.Windows.Forms.TextBox confirmarTextBox;
        private System.Windows.Forms.TextBox claveTextBox;
        private System.Windows.Forms.Label confirmarLabel;
        private System.Windows.Forms.Label claveLabel;
        private System.Windows.Forms.ComboBox rolComboBox;
        private System.Windows.Forms.Label rolLabel;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.CheckBox activoCheckBox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label costolabel;
        private System.Windows.Forms.TextBox costoTextBox;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

