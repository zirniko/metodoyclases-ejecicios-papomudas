
namespace MetodosYclasesEjercicio1
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
            this.lblnum1 = new System.Windows.Forms.Label();
            this.lblnum2 = new System.Windows.Forms.Label();
            this.txtnum1 = new System.Windows.Forms.TextBox();
            this.txtnum2 = new System.Windows.Forms.TextBox();
            this.Btnsumar = new System.Windows.Forms.Button();
            this.Btnmultiplicar = new System.Windows.Forms.Button();
            this.BtnRestar = new System.Windows.Forms.Button();
            this.BtnDivicion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblnum1
            // 
            this.lblnum1.AutoSize = true;
            this.lblnum1.Location = new System.Drawing.Point(85, 88);
            this.lblnum1.Name = "lblnum1";
            this.lblnum1.Size = new System.Drawing.Size(89, 13);
            this.lblnum1.TabIndex = 0;
            this.lblnum1.Text = "Ingrese numero 1";
            // 
            // lblnum2
            // 
            this.lblnum2.AutoSize = true;
            this.lblnum2.Location = new System.Drawing.Point(85, 134);
            this.lblnum2.Name = "lblnum2";
            this.lblnum2.Size = new System.Drawing.Size(89, 13);
            this.lblnum2.TabIndex = 1;
            this.lblnum2.Text = "Ingrese numero 2";
            // 
            // txtnum1
            // 
            this.txtnum1.Location = new System.Drawing.Point(235, 85);
            this.txtnum1.Name = "txtnum1";
            this.txtnum1.Size = new System.Drawing.Size(140, 20);
            this.txtnum1.TabIndex = 2;
            // 
            // txtnum2
            // 
            this.txtnum2.Location = new System.Drawing.Point(235, 127);
            this.txtnum2.Name = "txtnum2";
            this.txtnum2.Size = new System.Drawing.Size(140, 20);
            this.txtnum2.TabIndex = 3;
            // 
            // Btnsumar
            // 
            this.Btnsumar.Location = new System.Drawing.Point(69, 168);
            this.Btnsumar.Name = "Btnsumar";
            this.Btnsumar.Size = new System.Drawing.Size(105, 29);
            this.Btnsumar.TabIndex = 4;
            this.Btnsumar.Text = "Sumar";
            this.Btnsumar.UseVisualStyleBackColor = true;
            this.Btnsumar.Click += new System.EventHandler(this.Btnsumar_Click);
            // 
            // Btnmultiplicar
            // 
            this.Btnmultiplicar.Location = new System.Drawing.Point(180, 168);
            this.Btnmultiplicar.Name = "Btnmultiplicar";
            this.Btnmultiplicar.Size = new System.Drawing.Size(105, 29);
            this.Btnmultiplicar.TabIndex = 5;
            this.Btnmultiplicar.Text = "Multiplicar";
            this.Btnmultiplicar.UseVisualStyleBackColor = true;
            this.Btnmultiplicar.Click += new System.EventHandler(this.Btnmultiplicar_Click);
            // 
            // BtnRestar
            // 
            this.BtnRestar.Location = new System.Drawing.Point(291, 168);
            this.BtnRestar.Name = "BtnRestar";
            this.BtnRestar.Size = new System.Drawing.Size(105, 29);
            this.BtnRestar.TabIndex = 6;
            this.BtnRestar.Text = "Restar";
            this.BtnRestar.UseVisualStyleBackColor = true;
            this.BtnRestar.Click += new System.EventHandler(this.BtnRestar_Click);
            // 
            // BtnDivicion
            // 
            this.BtnDivicion.Location = new System.Drawing.Point(416, 168);
            this.BtnDivicion.Name = "BtnDivicion";
            this.BtnDivicion.Size = new System.Drawing.Size(105, 29);
            this.BtnDivicion.TabIndex = 7;
            this.BtnDivicion.Text = "Divicion";
            this.BtnDivicion.UseVisualStyleBackColor = true;
            this.BtnDivicion.Click += new System.EventHandler(this.BtnDivicion_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(542, 270);
            this.Controls.Add(this.BtnDivicion);
            this.Controls.Add(this.BtnRestar);
            this.Controls.Add(this.Btnmultiplicar);
            this.Controls.Add(this.Btnsumar);
            this.Controls.Add(this.txtnum2);
            this.Controls.Add(this.txtnum1);
            this.Controls.Add(this.lblnum2);
            this.Controls.Add(this.lblnum1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnum1;
        private System.Windows.Forms.Label lblnum2;
        private System.Windows.Forms.TextBox txtnum1;
        private System.Windows.Forms.TextBox txtnum2;
        private System.Windows.Forms.Button Btnsumar;
        private System.Windows.Forms.Button Btnmultiplicar;
        private System.Windows.Forms.Button BtnRestar;
        private System.Windows.Forms.Button BtnDivicion;
    }
}

