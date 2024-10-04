namespace Calificaciones
{
    partial class Materias
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
            this.listViewMaterias = new System.Windows.Forms.ListView();
            this.columnHeaderNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCodigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAgregarMateria = new System.Windows.Forms.Button();
            this.btnEliminarMateria = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewMaterias
            // 
            this.listViewMaterias.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
    this.columnHeaderNombre,
    this.columnHeaderCodigo});
            this.listViewMaterias.Location = new System.Drawing.Point(12, 12);
            this.listViewMaterias.Name = "listViewMaterias";
            this.listViewMaterias.Size = new System.Drawing.Size(360, 150);
            this.listViewMaterias.TabIndex = 0;
            this.listViewMaterias.UseCompatibleStateImageBehavior = false;
            this.listViewMaterias.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderNombre
            // 
            this.columnHeaderNombre.Text = "Nombre";
            this.columnHeaderNombre.Width = 180;
            // 
            // columnHeaderCodigo
            // 
            this.columnHeaderCodigo.Text = "Código";
            this.columnHeaderCodigo.Width = 180;
            // 
            // btnAgregarMateria
            // 
            this.btnAgregarMateria.Location = new System.Drawing.Point(380, 12);
            this.btnAgregarMateria.Name = "btnAgregarMateria";
            this.btnAgregarMateria.Size = new System.Drawing.Size(90, 30);
            this.btnAgregarMateria.TabIndex = 1;
            this.btnAgregarMateria.Text = "Agregar";
            this.btnAgregarMateria.UseVisualStyleBackColor = true;
            this.btnAgregarMateria.Click += new System.EventHandler(this.BtnAgregarMateria_Click);
            // 
            // btnEliminarMateria
            // 
            this.btnEliminarMateria.Location = new System.Drawing.Point(380, 52);
            this.btnEliminarMateria.Name = "btnEliminarMateria";
            this.btnEliminarMateria.Size = new System.Drawing.Size(90, 30);
            this.btnEliminarMateria.TabIndex = 2;
            this.btnEliminarMateria.Text = "Eliminar";
            this.btnEliminarMateria.UseVisualStyleBackColor = true;
            this.btnEliminarMateria.Click += new System.EventHandler(this.BtnEliminarMateria_Click);
            // 
            // Materias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 174);
            this.Controls.Add(this.btnEliminarMateria);
            this.Controls.Add(this.btnAgregarMateria);
            this.Controls.Add(this.listViewMaterias);
            this.Name = "Materias";
            this.Text = "Materias";
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ListView listViewMaterias;
        private System.Windows.Forms.ColumnHeader columnHeaderNombre;
        private System.Windows.Forms.ColumnHeader columnHeaderCodigo;
        private System.Windows.Forms.Button btnAgregarMateria;
        private System.Windows.Forms.Button btnEliminarMateria;
