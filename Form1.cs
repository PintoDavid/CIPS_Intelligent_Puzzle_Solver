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

        //Boton para intercambio de información de la matriz de botones
        private Button botonSeleccionado = null;

        // Variable para controlar si la función BotonMatriz_Click está activa o no
        private bool permitirClickBotonMatriz = false;

        // Variable para llevar el seguimiento del tiempo transcurrido
        private TimeSpan tiempoTranscurrido = TimeSpan.Zero;

        // Variable para indicar si el temporizador está activo o pausado
        private bool temporizadorActivo = false;

        //Contador de movimientos
        private int cantidadMovimientos = 0;

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

            BotonPasosSeguir.Enabled = false;
            BotonPasosSeguir.BackColor = Color.LightGray;

            BotonGuardarSolucion.Enabled = false;
            BotonGuardarSolucion.BackColor = Color.LightGray;

            botonReiniciarPuzzle.Enabled = false;
            botonReiniciarPuzzle.BackColor = Color.LightGray;

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

            // Suscribir el evento Tick del temporizador al manejador de eventos timer_Tick
            timer.Tick += timer_Tick;

            // Ajustar las propiedades del temporizador
            timer.Interval = 1000;
            timer.Enabled = false;
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

                BotonIniciarTerminarPuzzle.Enabled = false;
                BotonIniciarTerminarPuzzle.BackColor = Color.LightGray;
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

                        // Crear un botón y asignarle un nombre
                        Button button = new Button();
                        button.Width = buttonSize;
                        button.Height = buttonSize;
                        button.Location = new Point(x, y);
                        button.Font = new Font("Arial", buttonSize / 4);
                        button.ForeColor = Color.Black;
                        button.FlatStyle = FlatStyle.Flat;
                        button.FlatAppearance.BorderSize = 1;

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
                            button.Name = "button" + (divisions * divisions);
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
                        button.ForeColor = Color.Black;
                        button.FlatStyle = FlatStyle.Flat;
                        button.FlatAppearance.BorderSize = 1;
                        button.BackColor = Color.BlanchedAlmond;

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

        //Funcion click interactivo del puzzle - intercambia label y nombre de boton para facilitar y optimizar resultados
        private void BotonMatriz_Click(object sender, EventArgs e)
        {
            Button botonClickeado = sender as Button;

            // Verificar si permitirClickBotonMatriz está activo
            if (permitirClickBotonMatriz)
            {
                // Si el botón clickeado es el mismo que ya está seleccionado, deseleccionarlo
                if (botonSeleccionado == botonClickeado)
                {
                    botonClickeado.BackColor = Color.BlanchedAlmond;
                    botonSeleccionado = null;
                    return;
                }

                // Si el botón clickeado es un botón numerado (button1 hasta buttonN^2-1), permitir selección y deselección
                if (botonClickeado.Text != "")
                {
                    if (botonSeleccionado != null)
                    {
                        botonSeleccionado.BackColor = Color.BlanchedAlmond;
                    }
                    botonSeleccionado = botonClickeado;
                    botonSeleccionado.BackColor = Color.Blue;
                    TextoBotonSeleccionado.Text = "Botón seleccionado: " + botonSeleccionado.Name;
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

                            // Incrementar el contador de movimientos
                            cantidadMovimientos++;

                            // Actualizar el texto del Label con el nuevo valor del contador
                            TextoCantidadMovimientos.Text = "Movimientos realizados: " + cantidadMovimientos.ToString();

                            // Deseleccionar el botón seleccionado
                            botonSeleccionado.BackColor = Color.BlanchedAlmond;
                            botonSeleccionado = null;
                        }
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

        //Funcion mezcla de la matriz de botones - la posicion de los botones
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

        //Funcion que verifica la solución del puzzle según la posición original de los botones más no por contenido


        //===============================================================================================
        //Funciones información de juego
        //===============================================================================================

        //Funciónes para contador de tiempo
        // Manejador del evento Tick del temporizador
        private void timer_Tick(object sender, EventArgs e)
        {
            tiempoTranscurrido = tiempoTranscurrido.Add(TimeSpan.FromSeconds(1));

            // Actualizar el Label con el tiempo transcurrido
            TextoVariableTiempo.Text = tiempoTranscurrido.ToString(@"hh\:mm\:ss");
        }

        // Función para iniciar o detener el temporizador
        private void IniciarDetenerTemporizador()
        {
            temporizadorActivo = !temporizadorActivo;

            if (temporizadorActivo)
            {
                timer.Start(); // Iniciar el temporizador
            }
            else
            {
                timer.Stop(); // Detener el temporizador
            }
        }

        //===============================================================================================
        //Funciones botones de interfaz
        //===============================================================================================

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

                BotonIniciarTerminarPuzzle.Enabled = true;
                BotonIniciarTerminarPuzzle.BackColor = Color.White;
            }
            else
            {
                CantidadPiezasPuzzle.Enabled = false;
                BotonCargarImagen.BackColor = Color.White;

                SeleccionTipoPuzzle.Enabled = true;

                BotonIniciarTerminarPuzzle.Enabled = false;
                BotonIniciarTerminarPuzzle.BackColor = Color.LightGray;
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

        //Boton para iniciar o pausar el puzzle
        private void BotonIniciarTerminarPuzzle_Click(object sender, EventArgs e)
        {
            //Cuando el boton inicia la partida
            if (BotonIniciarTerminarPuzzle.Text == "Pausar puzzle")
            {
                BotonIniciarTerminarPuzzle.Text = "Iniciar puzzle";

                permitirClickBotonMatriz = false;

                BotonResolver.Enabled = true;
                BotonResolver.BackColor = Color.White;

                SeleccionSolucionInteligente.Enabled = true;
                SeleccionTipoPuzzle.Enabled = true;
                CantidadPiezasPuzzle.Enabled = true;

                BotonCargarImagen.Enabled = true;
                BotonCargarImagen.BackColor = Color.White;
                BotonEliminarImagen.Enabled = true;
                BotonEliminarImagen.BackColor = Color.White;

                BotonPasosSeguir.Enabled = false;
                BotonPasosSeguir.BackColor = Color.LightGray;
                BotonGuardarSolucion.Enabled = false;
                BotonGuardarSolucion.BackColor = Color.LightGray;

                botonReiniciarPuzzle.Enabled = false;
                botonReiniciarPuzzle.BackColor = Color.LightGray;
            }
            else
            {
                //cuando el boton detiene la partida
                BotonIniciarTerminarPuzzle.Text = "Pausar puzzle";

                permitirClickBotonMatriz = true;

                BotonResolver.Enabled = false;
                BotonResolver.BackColor = Color.LightGray;

                SeleccionSolucionInteligente.Enabled = false;
                SeleccionTipoPuzzle.Enabled = false;
                CantidadPiezasPuzzle.Enabled = false;

                BotonCargarImagen.Enabled = false;
                BotonCargarImagen.BackColor = Color.LightGray;
                BotonEliminarImagen.Enabled = false;
                BotonEliminarImagen.BackColor = Color.LightGray;

                BotonPasosSeguir.Enabled = false;
                BotonPasosSeguir.BackColor = Color.LightGray;
                BotonGuardarSolucion.Enabled = false;
                BotonGuardarSolucion.BackColor = Color.LightGray;

                botonReiniciarPuzzle.Enabled = true;
                botonReiniciarPuzzle.BackColor = Color.White;
            }
            IniciarDetenerTemporizador(); // Iniciar o detener el temporizador

            BotonMezclarImagen.Enabled = false;
            BotonMezclarImagen.BackColor = Color.LightGray;
        }

        //Boton para reinicar el puzzle y activar la opcion para volver a mezclar la imagen
        private void botonReiniciarPuzzle_Click(object sender, EventArgs e)
        {
            //Reinicia el contador
            cantidadMovimientos = 0;
            TextoCantidadMovimientos.Text = "Movimientos realizados: " + cantidadMovimientos.ToString();

            BotonIniciarTerminarPuzzle.PerformClick();

            // Reinicia el tiempo
            tiempoTranscurrido = TimeSpan.Zero;

            // Actualiza el Label con el tiempo transcurrido reiniciado a 0
            TextoVariableTiempo.Text = tiempoTranscurrido.ToString(@"hh\:mm\:ss");

            //Habilita de nuevo la posibilidad para mezclar el puzzle
            BotonMezclarImagen.Enabled = true;
            BotonMezclarImagen.BackColor = Color.White;
        }
    }
}
