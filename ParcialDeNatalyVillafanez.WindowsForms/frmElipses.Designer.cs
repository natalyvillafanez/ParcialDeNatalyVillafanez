
namespace ParcialDeNatalyVillafanez.WindowsForms
{
    partial class frmElipses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmElipses));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.NuevoToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.GuardadToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ElipsesDataGridView = new System.Windows.Forms.DataGridView();
            this.colSemiejeMayor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSemiejeMenor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPerimetro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colArea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.CantidadTextBox = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ElipsesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NuevoToolStripButton,
            this.GuardadToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(681, 38);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // NuevoToolStripButton
            // 
            this.NuevoToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("NuevoToolStripButton.Image")));
            this.NuevoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NuevoToolStripButton.Name = "NuevoToolStripButton";
            this.NuevoToolStripButton.Size = new System.Drawing.Size(46, 35);
            this.NuevoToolStripButton.Text = "Nuevo";
            this.NuevoToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.NuevoToolStripButton.Click += new System.EventHandler(this.NuevoToolStripButton_Click);
            // 
            // GuardadToolStripButton
            // 
            this.GuardadToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("GuardadToolStripButton.Image")));
            this.GuardadToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.GuardadToolStripButton.Name = "GuardadToolStripButton";
            this.GuardadToolStripButton.Size = new System.Drawing.Size(53, 35);
            this.GuardadToolStripButton.Text = "Guardar";
            this.GuardadToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.GuardadToolStripButton.Click += new System.EventHandler(this.GuardadToolStripButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CantidadTextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 254);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(681, 47);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ElipsesDataGridView);
            this.panel2.Location = new System.Drawing.Point(0, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(681, 216);
            this.panel2.TabIndex = 2;
            // 
            // ElipsesDataGridView
            // 
            this.ElipsesDataGridView.AllowUserToAddRows = false;
            this.ElipsesDataGridView.AllowUserToDeleteRows = false;
            this.ElipsesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ElipsesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSemiejeMayor,
            this.colSemiejeMenor,
            this.colPerimetro,
            this.colArea});
            this.ElipsesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ElipsesDataGridView.Location = new System.Drawing.Point(0, 0);
            this.ElipsesDataGridView.Name = "ElipsesDataGridView";
            this.ElipsesDataGridView.ReadOnly = true;
            this.ElipsesDataGridView.Size = new System.Drawing.Size(681, 216);
            this.ElipsesDataGridView.TabIndex = 0;
            // 
            // colSemiejeMayor
            // 
            this.colSemiejeMayor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSemiejeMayor.HeaderText = "Semieje Mayor";
            this.colSemiejeMayor.Name = "colSemiejeMayor";
            this.colSemiejeMayor.ReadOnly = true;
            // 
            // colSemiejeMenor
            // 
            this.colSemiejeMenor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSemiejeMenor.HeaderText = "Semieje Menor";
            this.colSemiejeMenor.Name = "colSemiejeMenor";
            this.colSemiejeMenor.ReadOnly = true;
            // 
            // colPerimetro
            // 
            this.colPerimetro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPerimetro.HeaderText = "Perimetro";
            this.colPerimetro.Name = "colPerimetro";
            this.colPerimetro.ReadOnly = true;
            // 
            // colArea
            // 
            this.colArea.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colArea.HeaderText = "Area";
            this.colArea.Name = "colArea";
            this.colArea.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(212, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantidad de Elipses: ";
            // 
            // CantidadTextBox
            // 
            this.CantidadTextBox.Location = new System.Drawing.Point(314, 13);
            this.CantidadTextBox.Name = "CantidadTextBox";
            this.CantidadTextBox.Size = new System.Drawing.Size(26, 20);
            this.CantidadTextBox.TabIndex = 1;
            this.CantidadTextBox.Text = "0";
            this.CantidadTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmElipses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 303);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmElipses";
            this.Text = "frmElipses";
            this.Load += new System.EventHandler(this.frmElipses_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ElipsesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton NuevoToolStripButton;
        private System.Windows.Forms.ToolStripButton GuardadToolStripButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView ElipsesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSemiejeMayor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSemiejeMenor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPerimetro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colArea;
        private System.Windows.Forms.TextBox CantidadTextBox;
        private System.Windows.Forms.Label label1;
    }
}