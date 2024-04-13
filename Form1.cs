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
    public partial class Pantalla_Inicial : Form
    {
        //areglos y bitmaps para subdivisiones
        private Bitmap originalImage;

        public Pantalla_Inicial()//nombre del form1
        {
            InitializeComponent();

            //propiedad de botones el inicio del programa
            BotonEliminarImagen.Visible = false;
            BotonCargarImagen.Visible = false;

            BotonGuardarSolucion.Enabled = false;
            BotonGuardarSolucion.BackColor = Color.LightGray;

            BotonResolver.Enabled = false;
            BotonResolver.BackColor = Color.LightGray;

            BotonReiniciarImagen.Enabled = false;
            BotonReiniciarImagen.BackColor = Color.LightGray;

            BotonPasosSeguir.Enabled = false;
            BotonPasosSeguir.BackColor = Color.LightGray;

            BotonGuardarSolucion.Enabled = false;
            BotonGuardarSolucion.BackColor = Color.LightGray;

            SeleccionSolucionInteligente.Enabled = false;

            //Comboboxes predeterminados
            SeleccionTipoPuzzle.SelectedIndex = 1;  //Números
            SeleccionSolucionInteligente.SelectedIndex = 0; //Profundidad
            CantidadPiezasPuzzle.SelectedIndex = 0; //3x3 piezas de subdivisión

            // Actualizar imagen antes de mezclarla en tiempo real
            CantidadPiezasPuzzle.SelectedIndexChanged += CantidadPiezasPuzzle_SelectedIndexChanged;

            //Boton para mezclar las piezas
            BotonMezclarImagen.Click += BotonMezclarImagen_Click;
    }

    private void BotonCargarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog archivo = new OpenFileDialog();
            archivo.Filter = "archivos de imágenes (*.png; *.jpg; *.jpeg) | *.png; *.jpg; *.jpeg";

            if (archivo.ShowDialog()==DialogResult.OK)
            {
                originalImage = new Bitmap(archivo.FileName);
                ImagenObjetivo.Image = originalImage;    //Objetivo imagen "original"

                //llama a la funcion para convertirla en slides en ImagenPuzzleMezcla.Image
                int divisiones = int.Parse(CantidadPiezasPuzzle.SelectedItem.ToString());
                DivisionImagenPiezas(divisiones, ImagenPuzzleMezcla);

                //como ya existe una imagen, si deja quitarla
                BotonEliminarImagen.Enabled = true;
                BotonEliminarImagen.BackColor = Color.White;
                BotonCargarImagen.Enabled = false;
                BotonCargarImagen.BackColor = Color.LightGray;

                //Estado de mezcla de imagen
                BotonMezclarImagen.Enabled = true;
                BotonMezclarImagen.BackColor = Color.White;
            }
            else BotonCargarImagen.BackColor = Color.White;
        }

        private void SeleccionTipoPuzzle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(SeleccionTipoPuzzle.SelectedItem != "Imagen")
            {
                //propiedad de botones para controlar carga de imagenes
                BotonEliminarImagen.Visible = false;
                BotonCargarImagen.Visible = false;

                //Estado de mezcla de imagen
                BotonMezclarImagen.Enabled = true;
                BotonMezclarImagen.BackColor = Color.White;

                //Elimina y resetea imagen anterior al cambiar tipo puzzle
                ImagenObjetivo.Image = null;
                ImagenPuzzleMezcla.Image = null;
            }
            else
            {
                //Elimina y resetea imagen anterior al cambiar tipo puzzle
                ImagenObjetivo.Image = null;
                ImagenPuzzleMezcla.Image = null;

                //propiedad de botones para controlar carga de imagenes
                BotonEliminarImagen.Visible = true;
                BotonCargarImagen.Visible = true;

                //si no hay una imagen cargada, no deja quitarla (obviamente)
                BotonEliminarImagen.Enabled = false;
                BotonEliminarImagen.BackColor = Color.LightGray;
                BotonCargarImagen.Enabled = true;
                BotonCargarImagen.BackColor = Color.White;

                //Estado de mezcla de imagen
                BotonMezclarImagen.Enabled = false;
                BotonMezclarImagen.BackColor = Color.LightGray;
            }
        }

        private void BotonEliminarImagen_Click(object sender, EventArgs e)
        {
            ImagenObjetivo.Image = null;
            ImagenPuzzleMezcla.Image = null;

            //como ya NO existe una imagen, deja quitarla, pero no cargarla nuevamente
            BotonEliminarImagen.Enabled = false;
            BotonEliminarImagen.BackColor = Color.LightGray;
            BotonCargarImagen.Enabled = true;
            BotonCargarImagen.BackColor = Color.White;

            //Estado de mezcla de imagen
            BotonMezclarImagen.Enabled = false;
            BotonMezclarImagen.BackColor = Color.LightGray;
        }

        private void SeleccionSolucionInteligente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SeleccionSolucionInteligente.SelectedItem == "Profundidad")
            {

            }
            if (SeleccionSolucionInteligente.SelectedItem == "Heurística")
            {

            }
            if (SeleccionSolucionInteligente.SelectedItem == "Anchura")
            {

            }
        }

        //Funciones para sibdividir la imagen
        private void DivisionImagenPiezas(int divisions, PictureBox ImagenPuzzleMezcla)
        {
            int rows = divisions;
            int columns = divisions;

            int pieceWidth = originalImage.Width / columns;
            int pieceHeight = originalImage.Height / rows;

            // Crear una imagen que contendrá todas las piezas del rompecabezas
            Bitmap combinedImage = new Bitmap(originalImage.Width, originalImage.Height);

            using (Graphics g = Graphics.FromImage(combinedImage))
            {
                // Dibujar las piezas del rompecabezas con márgenes
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        // Calcular la posición de la pieza en la imagen combinada
                        int x = j * pieceWidth;
                        int y = i * pieceHeight;

                        // Cortar la pieza del rompecabezas original
                        Rectangle cropRect = new Rectangle(j * pieceWidth, i * pieceHeight, pieceWidth, pieceHeight);
                        Bitmap piece = originalImage.Clone(cropRect, originalImage.PixelFormat);

                        // Dibujar la pieza en la imagen combinada
                        g.DrawImage(piece, x, y, pieceWidth, pieceHeight);

                        // Dibujar el borde alrededor de la pieza
                        Pen pen = new Pen(Color.Black, 2); // Puedes ajustar el color y el grosor del borde según tus necesidades
                        g.DrawRectangle(pen, new Rectangle(x, y, pieceWidth, pieceHeight));
                    }
                }

                // Rellenar la última celda con un color de fondo diferente
                Rectangle lastCellRect = new Rectangle((columns - 1) * pieceWidth, (rows - 1) * pieceHeight, pieceWidth, pieceHeight);
                using (Brush brush = new SolidBrush(Color.Gray)) // Puedes ajustar el color del fondo según tus necesidades
                {
                    g.FillRectangle(brush, lastCellRect);
                }
            }

            // Mostrar la imagen combinada en el PictureBox
            ImagenPuzzleMezcla.Image = combinedImage;
        }

        private void CantidadPiezasPuzzle_SelectedIndexChanged(object sender, EventArgs e)
        {
            int divisions = int.Parse(CantidadPiezasPuzzle.SelectedItem.ToString());
            DivisionImagenPiezas(divisions, ImagenPuzzleMezcla);
        }

        //Funciones para mezclar las piezas
        private void BotonMezclarImagen_Click(object sender, EventArgs e)
        {
            CantidadPiezasPuzzle.Enabled = false;

            BotonEliminarImagen.Enabled = false;
            BotonEliminarImagen.BackColor = Color.LightGray;

            MezclarPiezas();
        }

        private void MezclarPiezas()
        {
            
        }
    }
}
