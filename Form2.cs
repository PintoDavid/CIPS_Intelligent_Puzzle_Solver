using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuzzleSolver_IA
{
    public partial class Form2 : Form
    {
        private object textBoxPasos;

        public Form2()
        {
            InitializeComponent();
        }
        public void MostrarMatriz(string[,] matriz)
        {
            StringBuilder sb = new StringBuilder();
            int rows = matriz.GetLength(0);
            int cols = matriz.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    sb.Append(matriz[i, j]);
                    if (j < cols - 1)
                        sb.Append(" ");
                }
                if (i < rows - 1)
                    sb.AppendLine();
            }

            textBox1.Text = sb.ToString();
        }
    }
}
