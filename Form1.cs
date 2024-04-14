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

        // Variables para mantener el estado del espacio vacío
        private int emptyButtonRow = -1;
        private int emptyButtonColumn = -1;

        private Button botonSeleccionado = null;
        private Point botonSeleccionadoPos; // Almacena las coordenadas del primer botón seleccionado

        //===============================================================================================
        //Contenido que se vera al iniciar la apliacion
        //===============================================================================================
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

            // Llama al método para mostrar la matriz de botones con números y fondo gris al iniciar el programa
            MostrarMatrizBotones();

            //Boton para mezclar las piezas
            BotonMezclarImagen.Click += BotonMezclarImagen_Click;

            // Suscribirse al evento Load del formulario
            this.Load += Pantalla_Inicial_Load;

    }

        //===============================================================================================
        //Ya que es predeterminado el tipo puzzle nuemrico, pues se carga de primero su matriz
        //===============================================================================================
        private void Pantalla_Inicial_Load(object sender, EventArgs e)
        {
            // Llamar al método para mostrar la matriz de botones al iniciar el programa
            MostrarMatrizBotones();
        }

        //===============================================================================================
        //Cambios de comboboxes utilizados
        //===============================================================================================

        //Combobox para cambiar cantidad de piezas de la matriz de botones
        private void CantidadPiezasPuzzle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SeleccionTipoPuzzle.SelectedItem == "Imagen")
            {
                CargarImagenEnPanelPuzzleContainer(originalImage);
            }
            else
            {
                MostrarMatrizBotones();
            }
        }

        //Combobox para cambiar el tipo de puzzle
        private void SeleccionTipoPuzzle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SeleccionTipoPuzzle.SelectedItem != "Imagen")
            {
                // Eliminar controles anteriores (en caso de que los haya)
                panelPuzzleContainer.Controls.Clear();
                panelSolucionPuzzle.Controls.Clear();

                // Ocultar botones para cargar y eliminar imagen
                BotonEliminarImagen.Visible = false;
                BotonCargarImagen.Visible = false;

                // Habilitar el botón de mezclar imagen
                BotonMezclarImagen.Enabled = true;
                BotonMezclarImagen.BackColor = Color.White;

                // Eliminar la imagen del panelSolucionPuzzle
                panelSolucionPuzzle.BackgroundImage = null;
                panelSolucionPuzzle.Controls.Clear();

                // Habilitar el puzzle actualmente seleccionado
                CantidadPiezasPuzzle.Enabled = true;

                // Mostrar matriz de botones en el panelPuzzleContainer
                MostrarMatrizBotones();
            }
            else
            {
                // Eliminar controles anteriores (en caso de que los haya)
                panelPuzzleContainer.Controls.Clear();
                panelSolucionPuzzle.Controls.Clear();

                // Mostrar botones para cargar y eliminar imagen
                BotonEliminarImagen.Visible = true;
                BotonCargarImagen.Visible = true;

                // Deshabilitar el botón de mezclar imagen
                BotonMezclarImagen.Enabled = false;
                BotonMezclarImagen.BackColor = Color.LightGray;

                // Reiniciar la imagen del panelSolucionPuzzle
                panelSolucionPuzzle.BackgroundImage = null;
                panelSolucionPuzzle.Controls.Clear();

                // Deshabilitar el puzzle actualmente seleccionado
                CantidadPiezasPuzzle.Enabled = false;

                BotonEliminarImagen.Enabled = false;
                BotonEliminarImagen.BackColor = Color.LightGray;
            }
        }

        //===============================================================================================
        //Funciones para asignar contenido a botones para puzzle
        //===============================================================================================

        //Puzzle imagen
        //Funcion para mostrar la matriz de botones cuando puzzle es imagen
        private void CargarImagenEnPanelPuzzleContainer(Bitmap image)
        {
            // Eliminar controles anteriores (en caso de que los haya)
            panelPuzzleContainer.Controls.Clear();
            panelSolucionPuzzle.Controls.Clear(); // Limpiar el panel de solución

            if (CantidadPiezasPuzzle.SelectedItem != null)
            {
                int divisions = int.Parse(CantidadPiezasPuzzle.SelectedItem.ToString());

                int buttonSize = panelPuzzleContainer.Width / divisions;

                int count = 1;
                for (int i = 0; i < divisions; i++)
                {
                    for (int j = 0; j < divisions; j++)
                    {
                        // Calcular la posición de cada botón
                        int x = j * buttonSize;
                        int y = i * buttonSize;

                        // Verificar si es el último botón
                        if (count < divisions * divisions)
                        {
                            // Crear un botón con el número correspondiente y agregarlo al panelPuzzleContainer
                            Button button = new Button();
                            button.Width = buttonSize;
                            button.Height = buttonSize;
                            button.Location = new Point(x, y);
                            button.BackgroundImage = originalImage;
                            button.BackgroundImageLayout = ImageLayout.Stretch;
                            button.FlatStyle = FlatStyle.Flat;
                            button.FlatAppearance.BorderSize = 0;
                            button.BackColor = Color.Gray;

                            // Agregar el botón al panelPuzzleContainer
                            panelPuzzleContainer.Controls.Add(button);

                            count++;
                        }
                    }
                }

                // Tomar una captura de pantalla del panelPuzzleContainer
                Bitmap puzzleImage = new Bitmap(panelPuzzleContainer.Width, panelPuzzleContainer.Height);
                panelPuzzleContainer.DrawToBitmap(puzzleImage, new Rectangle(0, 0, panelPuzzleContainer.Width, panelPuzzleContainer.Height));

                // Crear un PictureBox para mostrar la imagen del puzzle en el panelSolucionPuzzle
                PictureBox pictureBox = new PictureBox();
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Width = panelSolucionPuzzle.Width;
                pictureBox.Height = panelSolucionPuzzle.Height;
                pictureBox.Image = originalImage;

                // Agregar el PictureBox al panelSolucionPuzzle
                panelSolucionPuzzle.Controls.Add(pictureBox);
            }
            // Establecer el color de fondo del panel
            panelPuzzleContainer.BackColor = Color.LightGray;
            panelSolucionPuzzle.BackColor = Color.LightGray; // Establecer el color de fondo del panel de solución
        }

        //Puzzle numeros
        //Funcion para mostrar la matriz de botones cuando puzzle es Numeros
        private void MostrarMatrizBotones()
        {
            // Eliminar controles anteriores (en caso de que los haya)
            panelPuzzleContainer.Controls.Clear();
            panelSolucionPuzzle.Controls.Clear(); // Limpiar el panel de solución

            if (CantidadPiezasPuzzle.SelectedItem != null)
            {
                int divisions = int.Parse(CantidadPiezasPuzzle.SelectedItem.ToString());
                int buttonSize = panelPuzzleContainer.Width / divisions;
                int count = 1;

                for (int i = 0; i < divisions; i++)
                {
                    for (int j = 0; j < divisions; j++)
                    {
                        // Calcular la posición de cada botón
                        int x = j * buttonSize;
                        int y = i * buttonSize;

                        // Crear un botón y asignarle un nombre
                        Button button = new Button();
                        button.Width = buttonSize;
                        button.Height = buttonSize;
                        button.Location = new Point(x, y);
                        button.Font = new Font("Arial", buttonSize / 4);
                        button.FlatStyle = FlatStyle.Flat;
                        button.FlatAppearance.BorderSize = 1;
                        button.BackColor = Color.Gray;

                        // Asignar un nombre al botón
                        button.Name = "button" + count.ToString();

                        // Verificar si es el último botón
                        if (count < divisions * divisions)
                        {
                            button.Text = count.ToString();
                            count++;
                        }
                        else
                        {
                            button.Name = "button" + (divisions*divisions);
                        }

                        // Suscribir el botón al evento de clic
                        button.Click += BotonMatriz_Click;

                        // Agregar el botón al panelPuzzleContainer
                        panelPuzzleContainer.Controls.Add(button);
                    }
                }

                // Tomar una captura de pantalla del panelPuzzleContainer
                Bitmap puzzleImage = new Bitmap(panelPuzzleContainer.Width, panelPuzzleContainer.Height);
                panelPuzzleContainer.DrawToBitmap(puzzleImage, new Rectangle(0, 0, panelPuzzleContainer.Width, panelPuzzleContainer.Height));

                // Crear un PictureBox para mostrar la imagen del puzzle en el panelSolucionPuzzle
                PictureBox pictureBox = new PictureBox();
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Width = panelSolucionPuzzle.Width;
                pictureBox.Height = panelSolucionPuzzle.Height;
                pictureBox.Image = puzzleImage;

                // Agregar el PictureBox al panelSolucionPuzzle
                panelSolucionPuzzle.Controls.Add(pictureBox);
            }
            MezclarBotones();
        }
        private void BotonMatriz_Click(object sender, EventArgs e)
        {
            Button botonClickeado = sender as Button;

            // Si el botón clickeado es el mismo que ya está seleccionado, deseleccionarlo
            if (botonSeleccionado == botonClickeado)
            {
                botonClickeado.BackColor = Color.Gray;
                botonSeleccionado = null;
                return;
            }

            // Si el botón clickeado es un botón numerado (button1 hasta buttonN^2-1), permitir selección y deselección
            if (botonClickeado.Text != "")
            {
                if (botonSeleccionado != null)
                {
                    botonSeleccionado.BackColor = Color.Gray;
                }
                botonSeleccionado = botonClickeado;
                botonSeleccionado.BackColor = Color.Blue;
            }
            else // Si el botón clickeado es el botón vacío (sin texto)
            {
                if (botonSeleccionado != null)
                {
                    // Obtener las coordenadas del botón clickeado y del botón seleccionado
                    Point posBotonClickeado = botonClickeado.Location;
                    Point posBotonSeleccionado = botonSeleccionado.Location;

                    // Verificar si el botón vacío está adyacente al botón seleccionado
                    //Se intentó intercambiar la posición de los botones como lo hace mezclarbotones, pero no funcionaba con el click
                    if (EsAdyacente(posBotonSeleccionado, posBotonClickeado))
                    {
                        // Intercambiar el texto/label y el nombre de los botones
                        string tempText = botonClickeado.Text;
                        botonClickeado.Text = botonSeleccionado.Text;
                        botonSeleccionado.Text = tempText;

                        string tempName = botonClickeado.Name;
                        botonClickeado.Name = botonSeleccionado.Name;
                        botonSeleccionado.Name = tempName;

                        // Deseleccionar el botón seleccionado
                        botonSeleccionado.BackColor = Color.Gray;
                        botonSeleccionado = null;
                    }
                }
            }
        }

        // Función para verificar si dos puntos están adyacentes (en horizontal o vertical)
        private bool EsAdyacente(Point punto1, Point punto2)
        {
            int distanciaX = Math.Abs(punto1.X - punto2.X);
            int distanciaY = Math.Abs(punto1.Y - punto2.Y);

            // Verificar si la distancia en X o en Y es igual a la longitud/altura de un botón
            return (distanciaX == botonSeleccionado.Width && distanciaY == 0) || (distanciaY == botonSeleccionado.Height && distanciaX == 0);
        }

        //Funcion mezcla de la matriz de botones
        private void MezclarBotones()
        {
            Random rnd = new Random();

            // Obtener la lista de botones en el panelPuzzleContainer
            List<Button> buttons = panelPuzzleContainer.Controls.OfType<Button>().ToList();

            // Mezclar los botones aleatoriamente
            for (int i = 0; i < buttons.Count; i++)
            {
                int randomIndex = rnd.Next(i, buttons.Count);
                // Intercambiar los botones en las posiciones i y randomIndex
                Point tempLocation = buttons[i].Location;
                buttons[i].Location = buttons[randomIndex].Location;
                buttons[randomIndex].Location = tempLocation;
            }
        }

        //===============================================================================================
        //Funciones botones de interfaz
        //===============================================================================================

        //Boton para resetear o reiniciar los parametros para volver a mezclar la imagen
        private void BotonReiniciarImagen_Click(object sender, EventArgs e)
        {
            CantidadPiezasPuzzle.Enabled = true;

            BotonEliminarImagen.Enabled = true;
            BotonEliminarImagen.BackColor = Color.White;

            BotonReiniciarImagen.Enabled = false;
            BotonReiniciarImagen.BackColor = Color.LightGray;

            BotonResolver.Enabled = false;
            BotonResolver.BackColor = Color.LightGray;

            SeleccionSolucionInteligente.Enabled = false;
        }

        //Boton para cargar imagen cuando tipo puzzle es imagen
        private void BotonCargarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog archivo = new OpenFileDialog();
            archivo.Filter = "archivos de imágenes (*.png; *.jpg; *.jpeg) | *.png; *.jpg; *.jpeg";

            if (archivo.ShowDialog() == DialogResult.OK)
            {
                originalImage = new Bitmap(archivo.FileName);

                // Llamar a la función para cargar la imagen en el panelPuzzleContainer
                CargarImagenEnPanelPuzzleContainer(originalImage);

                // Como ya existe una imagen, permite eliminarla y desactiva el botón de cargar
                BotonEliminarImagen.Enabled = true;
                BotonEliminarImagen.BackColor = Color.White;
                BotonCargarImagen.Enabled = false;
                BotonCargarImagen.BackColor = Color.LightGray;

                // Estado de mezcla de imagen
                BotonMezclarImagen.Enabled = true;
                BotonMezclarImagen.BackColor = Color.White;

                CantidadPiezasPuzzle.Enabled = true;
                SeleccionTipoPuzzle.Enabled = false;
            }
            else
            {
                CantidadPiezasPuzzle.Enabled = false;
                BotonCargarImagen.BackColor = Color.White;

                SeleccionTipoPuzzle.Enabled = true;
            }
        }

        //Boton para elimar imagen cuando tipo puzzle es imagen
        private void BotonEliminarImagen_Click(object sender, EventArgs e)
        {
            // Eliminar la imagen del panelSolucionPuzzle
            panelSolucionPuzzle.BackgroundImage = null;
            panelSolucionPuzzle.Controls.Clear();

            // Eliminar la matriz de botones en panelPuzzleContainer
            panelPuzzleContainer.Controls.Clear();

            // Habilitar el tipo puzzle para seleccionar nuevamente
            SeleccionTipoPuzzle.Enabled = true;
            CantidadPiezasPuzzle.Enabled = false;

            // Mostrar botón de cargar imagen y ocultar botón de eliminar imagen
            BotonEliminarImagen.Enabled = false;
            BotonEliminarImagen.BackColor = Color.LightGray;
            BotonCargarImagen.Enabled = true;
            BotonCargarImagen.BackColor = Color.White;
        }

        //Boton para mezclar la matriz de botones
        private void BotonMezclarImagen_Click(object sender, EventArgs e)
        {
            CantidadPiezasPuzzle.Enabled = false;

            BotonEliminarImagen.Enabled = false;
            BotonEliminarImagen.BackColor = Color.LightGray;

            BotonReiniciarImagen.Enabled = true;
            BotonReiniciarImagen.BackColor = Color.White;

            BotonResolver.Enabled = true;
            BotonResolver.BackColor = Color.White;

            SeleccionSolucionInteligente.Enabled = true;

            if (SeleccionTipoPuzzle.SelectedItem == "Imagen")
            {
                int divisions = int.Parse(CantidadPiezasPuzzle.SelectedItem.ToString());
                List<Button> buttons = panelPuzzleContainer.Controls.OfType<Button>().ToList();
            }
            else
            {
                MostrarMatrizBotones();
                MezclarBotones();
            }
        }

        //Que metodo va a realizar para resolverlo - Depende del combobox SeleccionSolucionInteligente
        private void BotonResolver_Click(object sender, EventArgs e)
        {
            if (SeleccionSolucionInteligente.SelectedItem == "Profundidad")
            {

            }
            if (SeleccionSolucionInteligente.SelectedItem == "Anchura")
            {

            }
        }
    }
}
