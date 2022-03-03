
namespace WinFormsApp1_tarea_14
{
    partial class Form1
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
            this.bttn_mostrar = new System.Windows.Forms.Button();
            this.txtBx_salida = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bttn_mostrar
            // 
            this.bttn_mostrar.Location = new System.Drawing.Point(39, 37);
            this.bttn_mostrar.Name = "bttn_mostrar";
            this.bttn_mostrar.Size = new System.Drawing.Size(413, 29);
            this.bttn_mostrar.TabIndex = 0;
            this.bttn_mostrar.Text = "Mostrar animales: Perro, gato, canario";
            this.bttn_mostrar.UseVisualStyleBackColor = true;
            this.bttn_mostrar.Click += new System.EventHandler(this.bttn_mostrar_Click);
            // 
            // txtBx_salida
            // 
            this.txtBx_salida.Location = new System.Drawing.Point(39, 72);
            this.txtBx_salida.Multiline = true;
            this.txtBx_salida.Name = "txtBx_salida";
            this.txtBx_salida.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBx_salida.Size = new System.Drawing.Size(413, 252);
            this.txtBx_salida.TabIndex = 1;
            this.txtBx_salida.WordWrap = false;
            this.txtBx_salida.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBx_salida_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 450);
            this.Controls.Add(this.txtBx_salida);
            this.Controls.Add(this.bttn_mostrar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttn_mostrar;
        private System.Windows.Forms.TextBox txtBx_salida;
    }
}

