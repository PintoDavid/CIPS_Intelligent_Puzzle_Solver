
namespace PuzzleSolver_IA
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ventanaListaPasos = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(35, 67);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(993, 461);
            this.textBox1.TabIndex = 0;
            // 
            // ventanaListaPasos
            // 
            this.ventanaListaPasos.AutoSize = true;
            this.ventanaListaPasos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ventanaListaPasos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ventanaListaPasos.Location = new System.Drawing.Point(338, 18);
            this.ventanaListaPasos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ventanaListaPasos.Name = "ventanaListaPasos";
            this.ventanaListaPasos.Size = new System.Drawing.Size(329, 32);
            this.ventanaListaPasos.TabIndex = 9;
            this.ventanaListaPasos.Text = "Lista de pasos a seguir";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(508, 544);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(557, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "Puedes guardar la lista con el botón guardar pasos";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(1078, 591);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ventanaListaPasos);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Intelligent Puzzle Solver - Lista Pasos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label ventanaListaPasos;
        private System.Windows.Forms.Label label1;
    }
}