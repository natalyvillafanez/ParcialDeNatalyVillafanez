
namespace ParcialDeNatalyVillafanez.WindowsForms
{
    partial class frmIngreso
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.semiejeMayorTextBox = new System.Windows.Forms.TextBox();
            this.semiejeMenorTextBox = new System.Windows.Forms.TextBox();
            this.TipoDeTrazoComboBox = new System.Windows.Forms.ComboBox();
            this.OkButton = new System.Windows.Forms.Button();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "INGRESE DATOS DE LA ELIPSE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Semieje Mayor: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Semieje Menor: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tipo de trazo: ";
            // 
            // semiejeMayorTextBox
            // 
            this.semiejeMayorTextBox.Location = new System.Drawing.Point(127, 57);
            this.semiejeMayorTextBox.Name = "semiejeMayorTextBox";
            this.semiejeMayorTextBox.Size = new System.Drawing.Size(121, 20);
            this.semiejeMayorTextBox.TabIndex = 4;
            // 
            // semiejeMenorTextBox
            // 
            this.semiejeMenorTextBox.Location = new System.Drawing.Point(127, 92);
            this.semiejeMenorTextBox.Name = "semiejeMenorTextBox";
            this.semiejeMenorTextBox.Size = new System.Drawing.Size(121, 20);
            this.semiejeMenorTextBox.TabIndex = 5;
            // 
            // TipoDeTrazoComboBox
            // 
            this.TipoDeTrazoComboBox.FormattingEnabled = true;
            this.TipoDeTrazoComboBox.Location = new System.Drawing.Point(127, 125);
            this.TipoDeTrazoComboBox.Name = "TipoDeTrazoComboBox";
            this.TipoDeTrazoComboBox.Size = new System.Drawing.Size(121, 21);
            this.TipoDeTrazoComboBox.TabIndex = 6;
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(40, 178);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 30);
            this.OkButton.TabIndex = 7;
            this.OkButton.Text = "Ok";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // CancelarButton
            // 
            this.CancelarButton.Location = new System.Drawing.Point(161, 178);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(75, 30);
            this.CancelarButton.TabIndex = 8;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.UseVisualStyleBackColor = true;
            this.CancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmIngreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 243);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.TipoDeTrazoComboBox);
            this.Controls.Add(this.semiejeMenorTextBox);
            this.Controls.Add(this.semiejeMayorTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmIngreso";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox semiejeMayorTextBox;
        private System.Windows.Forms.TextBox semiejeMenorTextBox;
        private System.Windows.Forms.ComboBox TipoDeTrazoComboBox;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button CancelarButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

