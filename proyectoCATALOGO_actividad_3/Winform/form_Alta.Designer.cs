﻿namespace Winform
{
  partial class form_Alta
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
            this.components = new System.ComponentModel.Container();
            this.label_Nombre = new System.Windows.Forms.Label();
            this.label_Descripcion = new System.Windows.Forms.Label();
            this.lb_Marca = new System.Windows.Forms.Label();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.txt_Descripcion = new System.Windows.Forms.TextBox();
            this.combob_Marca = new System.Windows.Forms.ComboBox();
            this.label_Codigo = new System.Windows.Forms.Label();
            this.txt_Codigo = new System.Windows.Forms.TextBox();
            this.txt_Precio = new System.Windows.Forms.TextBox();
            this.label_Precio = new System.Windows.Forms.Label();
            this.label_Categoria = new System.Windows.Forms.Label();
            this.combob_Categoria = new System.Windows.Forms.ComboBox();
            this.btAceptar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Nombre
            // 
            this.label_Nombre.AutoSize = true;
            this.label_Nombre.Location = new System.Drawing.Point(30, 44);
            this.label_Nombre.Name = "label_Nombre";
            this.label_Nombre.Size = new System.Drawing.Size(44, 13);
            this.label_Nombre.TabIndex = 0;
            this.label_Nombre.Text = "Nombre";
            // 
            // label_Descripcion
            // 
            this.label_Descripcion.AutoSize = true;
            this.label_Descripcion.Location = new System.Drawing.Point(30, 76);
            this.label_Descripcion.Name = "label_Descripcion";
            this.label_Descripcion.Size = new System.Drawing.Size(63, 13);
            this.label_Descripcion.TabIndex = 1;
            this.label_Descripcion.Text = "Descripcion";
            // 
            // lb_Marca
            // 
            this.lb_Marca.AutoSize = true;
            this.lb_Marca.Location = new System.Drawing.Point(30, 143);
            this.lb_Marca.Name = "lb_Marca";
            this.lb_Marca.Size = new System.Drawing.Size(37, 13);
            this.lb_Marca.TabIndex = 2;
            this.lb_Marca.Text = "Marca";
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(99, 41);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(136, 20);
            this.txt_Nombre.TabIndex = 3;
            // 
            // txt_Descripcion
            // 
            this.txt_Descripcion.Location = new System.Drawing.Point(99, 76);
            this.txt_Descripcion.Name = "txt_Descripcion";
            this.txt_Descripcion.Size = new System.Drawing.Size(319, 20);
            this.txt_Descripcion.TabIndex = 4;
            // 
            // combob_Marca
            // 
            this.combob_Marca.FormattingEnabled = true;
            this.combob_Marca.Location = new System.Drawing.Point(99, 140);
            this.combob_Marca.Name = "combob_Marca";
            this.combob_Marca.Size = new System.Drawing.Size(136, 21);
            this.combob_Marca.TabIndex = 5;
            // 
            // label_Codigo
            // 
            this.label_Codigo.AutoSize = true;
            this.label_Codigo.Location = new System.Drawing.Point(30, 13);
            this.label_Codigo.Name = "label_Codigo";
            this.label_Codigo.Size = new System.Drawing.Size(40, 13);
            this.label_Codigo.TabIndex = 6;
            this.label_Codigo.Text = "Codigo";
            // 
            // txt_Codigo
            // 
            this.txt_Codigo.Location = new System.Drawing.Point(99, 8);
            this.txt_Codigo.Name = "txt_Codigo";
            this.txt_Codigo.Size = new System.Drawing.Size(100, 20);
            this.txt_Codigo.TabIndex = 7;
            // 
            // txt_Precio
            // 
            this.txt_Precio.Location = new System.Drawing.Point(99, 107);
            this.txt_Precio.Name = "txt_Precio";
            this.txt_Precio.Size = new System.Drawing.Size(100, 20);
            this.txt_Precio.TabIndex = 8;
            // 
            // label_Precio
            // 
            this.label_Precio.AutoSize = true;
            this.label_Precio.Location = new System.Drawing.Point(30, 112);
            this.label_Precio.Name = "label_Precio";
            this.label_Precio.Size = new System.Drawing.Size(37, 13);
            this.label_Precio.TabIndex = 9;
            this.label_Precio.Text = "Precio";
            // 
            // label_Categoria
            // 
            this.label_Categoria.AutoSize = true;
            this.label_Categoria.Location = new System.Drawing.Point(30, 180);
            this.label_Categoria.Name = "label_Categoria";
            this.label_Categoria.Size = new System.Drawing.Size(52, 13);
            this.label_Categoria.TabIndex = 10;
            this.label_Categoria.Text = "Categoria";
            // 
            // combob_Categoria
            // 
            this.combob_Categoria.FormattingEnabled = true;
            this.combob_Categoria.Location = new System.Drawing.Point(99, 174);
            this.combob_Categoria.Name = "combob_Categoria";
            this.combob_Categoria.Size = new System.Drawing.Size(136, 21);
            this.combob_Categoria.TabIndex = 11;
            // 
            // btAceptar
            // 
            this.btAceptar.Location = new System.Drawing.Point(72, 228);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(89, 27);
            this.btAceptar.TabIndex = 12;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            this.btAceptar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btAceptar_MouseMove);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(238, 228);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(89, 27);
            this.btCancelar.TabIndex = 13;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btCancelar_MouseMove);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // form_Alta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 290);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.combob_Categoria);
            this.Controls.Add(this.label_Categoria);
            this.Controls.Add(this.label_Precio);
            this.Controls.Add(this.txt_Precio);
            this.Controls.Add(this.txt_Codigo);
            this.Controls.Add(this.label_Codigo);
            this.Controls.Add(this.combob_Marca);
            this.Controls.Add(this.txt_Descripcion);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.lb_Marca);
            this.Controls.Add(this.label_Descripcion);
            this.Controls.Add(this.label_Nombre);
            this.Name = "form_Alta";
            this.Text = "Alta de Arcticulos";
            this.Load += new System.EventHandler(this.form_Alta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label_Nombre;
    private System.Windows.Forms.Label label_Descripcion;
    private System.Windows.Forms.Label lb_Marca;
    private System.Windows.Forms.TextBox txt_Nombre;
    private System.Windows.Forms.TextBox txt_Descripcion;
    private System.Windows.Forms.ComboBox combob_Marca;
    private System.Windows.Forms.Label label_Codigo;
    private System.Windows.Forms.TextBox txt_Codigo;
    private System.Windows.Forms.TextBox txt_Precio;
    private System.Windows.Forms.Label label_Precio;
    private System.Windows.Forms.Label label_Categoria;
    private System.Windows.Forms.ComboBox combob_Categoria;
        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}