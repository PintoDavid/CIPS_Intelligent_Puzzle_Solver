using System.Windows.Forms;

namespace PuzzleSolver_IA
{
    internal class Form2 : Form
    {
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.SuspendLayout();
            // 
            // Form2
            // 
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(1001, 547);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Intelligent Puzzle Solver - Lista Pasos Solucion";
            this.ResumeLayout(false);

        }
    }
}