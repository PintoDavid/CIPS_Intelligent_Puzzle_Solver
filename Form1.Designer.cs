
namespace PuzzleSolver_IA
{
    partial class Pantalla_Inicial
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pantalla_Inicial));
            this.NombreTipoSolucion = new System.Windows.Forms.Label();
            this.SeleccionSolucionInteligente = new System.Windows.Forms.ComboBox();
            this.BotonResolver = new System.Windows.Forms.Button();
            this.BotonCargarImagen = new System.Windows.Forms.Button();
            this.BotonPasosSeguir = new System.Windows.Forms.Button();
            this.NombreTipoPuzzle = new System.Windows.Forms.Label();
            this.SeleccionTipoPuzzle = new System.Windows.Forms.ComboBox();
            this.TextoCantidadMovimientos = new System.Windows.Forms.Label();
            this.BotonIniciarTerminarPuzzle = new System.Windows.Forms.Button();
            this.BotonMezclarImagen = new System.Windows.Forms.Button();
            this.BotonGuardarSolucion = new System.Windows.Forms.Button();
            this.GrupoContenidoPuzzle = new System.Windows.Forms.GroupBox();
            this.panelPuzzleContainer = new System.Windows.Forms.Panel();
            this.GrupoContenidoImagenObjetivo = new System.Windows.Forms.GroupBox();
            this.panelSolucionPuzzle = new System.Windows.Forms.Panel();
            this.BotonEliminarImagen = new System.Windows.Forms.Button();
            this.CantidadPiezasPuzzle = new System.Windows.Forms.ComboBox();
            this.TextoCantidadPiezas = new System.Windows.Forms.Label();
            this.TextoCantidadNodos = new System.Windows.Forms.Label();
            this.TextoTiempoIA = new System.Windows.Forms.Label();
            this.TextoVariableTiempo = new System.Windows.Forms.Label();
            this.GrupoTipoPuzzle = new System.Windows.Forms.GroupBox();
            this.grupoInicioPuzzle = new System.Windows.Forms.GroupBox();
            this.botonReiniciarPuzzle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TextoBotonSeleccionado = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.GrupoContenidoPuzzle.SuspendLayout();
            this.GrupoContenidoImagenObjetivo.SuspendLayout();
            this.GrupoTipoPuzzle.SuspendLayout();
            this.grupoInicioPuzzle.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // NombreTipoSolucion
            // 
            this.NombreTipoSolucion.AutoSize = true;
            this.NombreTipoSolucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreTipoSolucion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.NombreTipoSolucion.Location = new System.Drawing.Point(8, 59);
            this.NombreTipoSolucion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NombreTipoSolucion.Name = "NombreTipoSolucion";
            this.NombreTipoSolucion.Size = new System.Drawing.Size(241, 25);
            this.NombreTipoSolucion.TabIndex = 2;
            this.NombreTipoSolucion.Text = "Selección tipo solución:";
            // 
            // SeleccionSolucionInteligente
            // 
            this.SeleccionSolucionInteligente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SeleccionSolucionInteligente.FormattingEnabled = true;
            this.SeleccionSolucionInteligente.IntegralHeight = false;
            this.SeleccionSolucionInteligente.Items.AddRange(new object[] {
            "Profundidad",
            "Heurística",
            "Anchura"});
            this.SeleccionSolucionInteligente.Location = new System.Drawing.Point(280, 55);
            this.SeleccionSolucionInteligente.Margin = new System.Windows.Forms.Padding(4);
            this.SeleccionSolucionInteligente.Name = "SeleccionSolucionInteligente";
            this.SeleccionSolucionInteligente.Size = new System.Drawing.Size(176, 33);
            this.SeleccionSolucionInteligente.TabIndex = 3;
            // 
            // BotonResolver
            // 
            this.BotonResolver.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BotonResolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonResolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonResolver.Location = new System.Drawing.Point(163, 95);
            this.BotonResolver.Margin = new System.Windows.Forms.Padding(4);
            this.BotonResolver.Name = "BotonResolver";
            this.BotonResolver.Size = new System.Drawing.Size(157, 36);
            this.BotonResolver.TabIndex = 4;
            this.BotonResolver.Text = "Resolver";
            this.BotonResolver.UseVisualStyleBackColor = false;
            this.BotonResolver.Click += new System.EventHandler(this.BotonResolver_Click);
            // 
            // BotonCargarImagen
            // 
            this.BotonCargarImagen.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BotonCargarImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonCargarImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonCargarImagen.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BotonCargarImagen.Location = new System.Drawing.Point(464, 30);
            this.BotonCargarImagen.Margin = new System.Windows.Forms.Padding(4);
            this.BotonCargarImagen.Name = "BotonCargarImagen";
            this.BotonCargarImagen.Size = new System.Drawing.Size(115, 36);
            this.BotonCargarImagen.TabIndex = 6;
            this.BotonCargarImagen.Text = "Cargar";
            this.BotonCargarImagen.UseVisualStyleBackColor = false;
            this.BotonCargarImagen.Click += new System.EventHandler(this.BotonCargarImagen_Click);
            // 
            // BotonPasosSeguir
            // 
            this.BotonPasosSeguir.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BotonPasosSeguir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonPasosSeguir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonPasosSeguir.Location = new System.Drawing.Point(29, 31);
            this.BotonPasosSeguir.Margin = new System.Windows.Forms.Padding(4);
            this.BotonPasosSeguir.Name = "BotonPasosSeguir";
            this.BotonPasosSeguir.Size = new System.Drawing.Size(192, 36);
            this.BotonPasosSeguir.TabIndex = 7;
            this.BotonPasosSeguir.Text = "Ver pasos";
            this.BotonPasosSeguir.UseVisualStyleBackColor = false;
            // 
            // NombreTipoPuzzle
            // 
            this.NombreTipoPuzzle.AutoSize = true;
            this.NombreTipoPuzzle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreTipoPuzzle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.NombreTipoPuzzle.Location = new System.Drawing.Point(15, 34);
            this.NombreTipoPuzzle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NombreTipoPuzzle.Name = "NombreTipoPuzzle";
            this.NombreTipoPuzzle.Size = new System.Drawing.Size(247, 25);
            this.NombreTipoPuzzle.TabIndex = 8;
            this.NombreTipoPuzzle.Text = "Selección tipo de puzzle";
            // 
            // SeleccionTipoPuzzle
            // 
            this.SeleccionTipoPuzzle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SeleccionTipoPuzzle.FormattingEnabled = true;
            this.SeleccionTipoPuzzle.IntegralHeight = false;
            this.SeleccionTipoPuzzle.Items.AddRange(new object[] {
            "Imagen",
            "Números"});
            this.SeleccionTipoPuzzle.Location = new System.Drawing.Point(305, 31);
            this.SeleccionTipoPuzzle.Margin = new System.Windows.Forms.Padding(4);
            this.SeleccionTipoPuzzle.Name = "SeleccionTipoPuzzle";
            this.SeleccionTipoPuzzle.Size = new System.Drawing.Size(144, 33);
            this.SeleccionTipoPuzzle.TabIndex = 9;
            this.SeleccionTipoPuzzle.SelectedIndexChanged += new System.EventHandler(this.SeleccionTipoPuzzle_SelectedIndexChanged);
            // 
            // TextoCantidadMovimientos
            // 
            this.TextoCantidadMovimientos.AutoSize = true;
            this.TextoCantidadMovimientos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextoCantidadMovimientos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TextoCantidadMovimientos.Location = new System.Drawing.Point(11, 52);
            this.TextoCantidadMovimientos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TextoCantidadMovimientos.Name = "TextoCantidadMovimientos";
            this.TextoCantidadMovimientos.Size = new System.Drawing.Size(238, 25);
            this.TextoCantidadMovimientos.TabIndex = 10;
            this.TextoCantidadMovimientos.Text = "Movimientos realizados: 0";
            // 
            // BotonIniciarTerminarPuzzle
            // 
            this.BotonIniciarTerminarPuzzle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BotonIniciarTerminarPuzzle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonIniciarTerminarPuzzle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonIniciarTerminarPuzzle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BotonIniciarTerminarPuzzle.Location = new System.Drawing.Point(458, 25);
            this.BotonIniciarTerminarPuzzle.Margin = new System.Windows.Forms.Padding(4);
            this.BotonIniciarTerminarPuzzle.Name = "BotonIniciarTerminarPuzzle";
            this.BotonIniciarTerminarPuzzle.Size = new System.Drawing.Size(123, 68);
            this.BotonIniciarTerminarPuzzle.TabIndex = 12;
            this.BotonIniciarTerminarPuzzle.Text = "Iniciar\r\npuzzle";
            this.BotonIniciarTerminarPuzzle.UseVisualStyleBackColor = false;
            this.BotonIniciarTerminarPuzzle.Click += new System.EventHandler(this.BotonIniciarTerminarPuzzle_Click);
            // 
            // BotonMezclarImagen
            // 
            this.BotonMezclarImagen.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BotonMezclarImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonMezclarImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonMezclarImagen.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BotonMezclarImagen.Location = new System.Drawing.Point(334, 25);
            this.BotonMezclarImagen.Margin = new System.Windows.Forms.Padding(4);
            this.BotonMezclarImagen.Name = "BotonMezclarImagen";
            this.BotonMezclarImagen.Size = new System.Drawing.Size(116, 68);
            this.BotonMezclarImagen.TabIndex = 13;
            this.BotonMezclarImagen.Text = "Mezclar\r\npuzzle";
            this.BotonMezclarImagen.UseVisualStyleBackColor = false;
            this.BotonMezclarImagen.Click += new System.EventHandler(this.BotonMezclarImagen_Click);
            // 
            // BotonGuardarSolucion
            // 
            this.BotonGuardarSolucion.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BotonGuardarSolucion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonGuardarSolucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonGuardarSolucion.Location = new System.Drawing.Point(249, 31);
            this.BotonGuardarSolucion.Margin = new System.Windows.Forms.Padding(4);
            this.BotonGuardarSolucion.Name = "BotonGuardarSolucion";
            this.BotonGuardarSolucion.Size = new System.Drawing.Size(193, 36);
            this.BotonGuardarSolucion.TabIndex = 14;
            this.BotonGuardarSolucion.Text = "Guardar pasos";
            this.BotonGuardarSolucion.UseVisualStyleBackColor = false;
            // 
            // GrupoContenidoPuzzle
            // 
            this.GrupoContenidoPuzzle.Controls.Add(this.panelPuzzleContainer);
            this.GrupoContenidoPuzzle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrupoContenidoPuzzle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GrupoContenidoPuzzle.Location = new System.Drawing.Point(363, 262);
            this.GrupoContenidoPuzzle.Margin = new System.Windows.Forms.Padding(4);
            this.GrupoContenidoPuzzle.Name = "GrupoContenidoPuzzle";
            this.GrupoContenidoPuzzle.Padding = new System.Windows.Forms.Padding(4);
            this.GrupoContenidoPuzzle.Size = new System.Drawing.Size(429, 430);
            this.GrupoContenidoPuzzle.TabIndex = 15;
            this.GrupoContenidoPuzzle.TabStop = false;
            this.GrupoContenidoPuzzle.Text = "Puzzle a resolver";
            // 
            // panelPuzzleContainer
            // 
            this.panelPuzzleContainer.Location = new System.Drawing.Point(15, 34);
            this.panelPuzzleContainer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelPuzzleContainer.Name = "panelPuzzleContainer";
            this.panelPuzzleContainer.Size = new System.Drawing.Size(400, 369);
            this.panelPuzzleContainer.TabIndex = 0;
            // 
            // GrupoContenidoImagenObjetivo
            // 
            this.GrupoContenidoImagenObjetivo.Controls.Add(this.panelSolucionPuzzle);
            this.GrupoContenidoImagenObjetivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrupoContenidoImagenObjetivo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GrupoContenidoImagenObjetivo.Location = new System.Drawing.Point(797, 262);
            this.GrupoContenidoImagenObjetivo.Margin = new System.Windows.Forms.Padding(4);
            this.GrupoContenidoImagenObjetivo.Name = "GrupoContenidoImagenObjetivo";
            this.GrupoContenidoImagenObjetivo.Padding = new System.Windows.Forms.Padding(4);
            this.GrupoContenidoImagenObjetivo.Size = new System.Drawing.Size(429, 430);
            this.GrupoContenidoImagenObjetivo.TabIndex = 16;
            this.GrupoContenidoImagenObjetivo.TabStop = false;
            this.GrupoContenidoImagenObjetivo.Text = "Objetivo";
            // 
            // panelSolucionPuzzle
            // 
            this.panelSolucionPuzzle.Location = new System.Drawing.Point(13, 34);
            this.panelSolucionPuzzle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelSolucionPuzzle.Name = "panelSolucionPuzzle";
            this.panelSolucionPuzzle.Size = new System.Drawing.Size(400, 369);
            this.panelSolucionPuzzle.TabIndex = 1;
            // 
            // BotonEliminarImagen
            // 
            this.BotonEliminarImagen.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BotonEliminarImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonEliminarImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonEliminarImagen.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BotonEliminarImagen.Location = new System.Drawing.Point(587, 30);
            this.BotonEliminarImagen.Margin = new System.Windows.Forms.Padding(4);
            this.BotonEliminarImagen.Name = "BotonEliminarImagen";
            this.BotonEliminarImagen.Size = new System.Drawing.Size(109, 36);
            this.BotonEliminarImagen.TabIndex = 17;
            this.BotonEliminarImagen.Text = "Quitar";
            this.BotonEliminarImagen.UseVisualStyleBackColor = false;
            this.BotonEliminarImagen.Click += new System.EventHandler(this.BotonEliminarImagen_Click);
            // 
            // CantidadPiezasPuzzle
            // 
            this.CantidadPiezasPuzzle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CantidadPiezasPuzzle.FormattingEnabled = true;
            this.CantidadPiezasPuzzle.IntegralHeight = false;
            this.CantidadPiezasPuzzle.Items.AddRange(new object[] {
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.CantidadPiezasPuzzle.Location = new System.Drawing.Point(304, 69);
            this.CantidadPiezasPuzzle.Margin = new System.Windows.Forms.Padding(4);
            this.CantidadPiezasPuzzle.Name = "CantidadPiezasPuzzle";
            this.CantidadPiezasPuzzle.Size = new System.Drawing.Size(145, 33);
            this.CantidadPiezasPuzzle.TabIndex = 18;
            // 
            // TextoCantidadPiezas
            // 
            this.TextoCantidadPiezas.AutoSize = true;
            this.TextoCantidadPiezas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextoCantidadPiezas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TextoCantidadPiezas.Location = new System.Drawing.Point(15, 73);
            this.TextoCantidadPiezas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TextoCantidadPiezas.Name = "TextoCantidadPiezas";
            this.TextoCantidadPiezas.Size = new System.Drawing.Size(253, 25);
            this.TextoCantidadPiezas.TabIndex = 19;
            this.TextoCantidadPiezas.Text = "Selección tamaño puzzle";
            // 
            // TextoCantidadNodos
            // 
            this.TextoCantidadNodos.AutoSize = true;
            this.TextoCantidadNodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextoCantidadNodos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TextoCantidadNodos.Location = new System.Drawing.Point(11, 76);
            this.TextoCantidadNodos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TextoCantidadNodos.Name = "TextoCantidadNodos";
            this.TextoCantidadNodos.Size = new System.Drawing.Size(170, 25);
            this.TextoCantidadNodos.TabIndex = 20;
            this.TextoCantidadNodos.Text = "Nodos del árbol: 0";
            // 
            // TextoTiempoIA
            // 
            this.TextoTiempoIA.AutoSize = true;
            this.TextoTiempoIA.BackColor = System.Drawing.Color.Transparent;
            this.TextoTiempoIA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextoTiempoIA.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TextoTiempoIA.Location = new System.Drawing.Point(11, 27);
            this.TextoTiempoIA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TextoTiempoIA.Name = "TextoTiempoIA";
            this.TextoTiempoIA.Size = new System.Drawing.Size(185, 25);
            this.TextoTiempoIA.TabIndex = 21;
            this.TextoTiempoIA.Text = "Tiempo en resolver:";
            // 
            // TextoVariableTiempo
            // 
            this.TextoVariableTiempo.AutoSize = true;
            this.TextoVariableTiempo.BackColor = System.Drawing.Color.Transparent;
            this.TextoVariableTiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextoVariableTiempo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TextoVariableTiempo.Location = new System.Drawing.Point(202, 27);
            this.TextoVariableTiempo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TextoVariableTiempo.Name = "TextoVariableTiempo";
            this.TextoVariableTiempo.Size = new System.Drawing.Size(90, 25);
            this.TextoVariableTiempo.TabIndex = 22;
            this.TextoVariableTiempo.Text = "00:00:00";
            // 
            // GrupoTipoPuzzle
            // 
            this.GrupoTipoPuzzle.Controls.Add(this.SeleccionTipoPuzzle);
            this.GrupoTipoPuzzle.Controls.Add(this.NombreTipoPuzzle);
            this.GrupoTipoPuzzle.Controls.Add(this.CantidadPiezasPuzzle);
            this.GrupoTipoPuzzle.Controls.Add(this.TextoCantidadPiezas);
            this.GrupoTipoPuzzle.Controls.Add(this.BotonEliminarImagen);
            this.GrupoTipoPuzzle.Controls.Add(this.BotonCargarImagen);
            this.GrupoTipoPuzzle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrupoTipoPuzzle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GrupoTipoPuzzle.Location = new System.Drawing.Point(16, 7);
            this.GrupoTipoPuzzle.Margin = new System.Windows.Forms.Padding(4);
            this.GrupoTipoPuzzle.Name = "GrupoTipoPuzzle";
            this.GrupoTipoPuzzle.Padding = new System.Windows.Forms.Padding(4);
            this.GrupoTipoPuzzle.Size = new System.Drawing.Size(717, 117);
            this.GrupoTipoPuzzle.TabIndex = 17;
            this.GrupoTipoPuzzle.TabStop = false;
            this.GrupoTipoPuzzle.Text = "1. Configura tu puzzle";
            // 
            // grupoInicioPuzzle
            // 
            this.grupoInicioPuzzle.Controls.Add(this.botonReiniciarPuzzle);
            this.grupoInicioPuzzle.Controls.Add(this.label1);
            this.grupoInicioPuzzle.Controls.Add(this.BotonIniciarTerminarPuzzle);
            this.grupoInicioPuzzle.Controls.Add(this.BotonMezclarImagen);
            this.grupoInicioPuzzle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grupoInicioPuzzle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grupoInicioPuzzle.Location = new System.Drawing.Point(15, 132);
            this.grupoInicioPuzzle.Margin = new System.Windows.Forms.Padding(4);
            this.grupoInicioPuzzle.Name = "grupoInicioPuzzle";
            this.grupoInicioPuzzle.Padding = new System.Windows.Forms.Padding(4);
            this.grupoInicioPuzzle.Size = new System.Drawing.Size(719, 123);
            this.grupoInicioPuzzle.TabIndex = 17;
            this.grupoInicioPuzzle.TabStop = false;
            this.grupoInicioPuzzle.Text = "2. Iniciar Puzzle";
            // 
            // botonReiniciarPuzzle
            // 
            this.botonReiniciarPuzzle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.botonReiniciarPuzzle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonReiniciarPuzzle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonReiniciarPuzzle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.botonReiniciarPuzzle.Location = new System.Drawing.Point(588, 26);
            this.botonReiniciarPuzzle.Margin = new System.Windows.Forms.Padding(4);
            this.botonReiniciarPuzzle.Name = "botonReiniciarPuzzle";
            this.botonReiniciarPuzzle.Size = new System.Drawing.Size(123, 68);
            this.botonReiniciarPuzzle.TabIndex = 21;
            this.botonReiniciarPuzzle.Text = "Reiniciar\r\npuzzle";
            this.botonReiniciarPuzzle.UseVisualStyleBackColor = false;
            this.botonReiniciarPuzzle.Click += new System.EventHandler(this.botonReiniciarPuzzle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(11, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 80);
            this.label1.TabIndex = 20;
            this.label1.Text = "Puedes volver a mezclar las piezas\r\nsi gustas, o iniciar el puzzle.\r\nDetén el puz" +
    "zle si quieres usar la\r\nsolución inteligente o cambiar el puzzle";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.NombreTipoSolucion);
            this.groupBox1.Controls.Add(this.SeleccionSolucionInteligente);
            this.groupBox1.Controls.Add(this.BotonResolver);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(741, 7);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(485, 146);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "3. (Opcional) Solución inteligente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(56, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(333, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Inicio automático de juego + pasos a seguir";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BotonPasosSeguir);
            this.groupBox2.Controls.Add(this.BotonGuardarSolucion);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(744, 158);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(483, 97);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "4. Lista de pasos a seguir";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TextoCantidadNodos);
            this.groupBox3.Controls.Add(this.TextoCantidadMovimientos);
            this.groupBox3.Controls.Add(this.TextoTiempoIA);
            this.groupBox3.Controls.Add(this.TextoVariableTiempo);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox3.Location = new System.Drawing.Point(16, 603);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(339, 112);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Información de juego";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox4.Location = new System.Drawing.Point(16, 262);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(339, 334);
            this.groupBox4.TabIndex = 23;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "¿Cómo jugar?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(8, 27);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(284, 300);
            this.label3.TabIndex = 20;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // TextoBotonSeleccionado
            // 
            this.TextoBotonSeleccionado.AutoSize = true;
            this.TextoBotonSeleccionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextoBotonSeleccionado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TextoBotonSeleccionado.Location = new System.Drawing.Point(377, 696);
            this.TextoBotonSeleccionado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TextoBotonSeleccionado.Name = "TextoBotonSeleccionado";
            this.TextoBotonSeleccionado.Size = new System.Drawing.Size(189, 25);
            this.TextoBotonSeleccionado.TabIndex = 23;
            this.TextoBotonSeleccionado.Text = "Botón seleccionado:";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            // 
            // Pantalla_Inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(1241, 731);
            this.Controls.Add(this.TextoBotonSeleccionado);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grupoInicioPuzzle);
            this.Controls.Add(this.GrupoTipoPuzzle);
            this.Controls.Add(this.GrupoContenidoImagenObjetivo);
            this.Controls.Add(this.GrupoContenidoPuzzle);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Pantalla_Inicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Intelligent Puzzle Solver";
            this.GrupoContenidoPuzzle.ResumeLayout(false);
            this.GrupoContenidoImagenObjetivo.ResumeLayout(false);
            this.GrupoTipoPuzzle.ResumeLayout(false);
            this.GrupoTipoPuzzle.PerformLayout();
            this.grupoInicioPuzzle.ResumeLayout(false);
            this.grupoInicioPuzzle.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label NombreTipoSolucion;
        private System.Windows.Forms.ComboBox SeleccionSolucionInteligente;
        private System.Windows.Forms.Button BotonResolver;
        private System.Windows.Forms.Button BotonCargarImagen;
        private System.Windows.Forms.Button BotonPasosSeguir;
        private System.Windows.Forms.Label NombreTipoPuzzle;
        private System.Windows.Forms.ComboBox SeleccionTipoPuzzle;
        private System.Windows.Forms.Label TextoCantidadMovimientos;
        private System.Windows.Forms.Button BotonIniciarTerminarPuzzle;
        private System.Windows.Forms.Button BotonMezclarImagen;
        private System.Windows.Forms.Button BotonGuardarSolucion;
        private System.Windows.Forms.GroupBox GrupoContenidoPuzzle;
        private System.Windows.Forms.GroupBox GrupoContenidoImagenObjetivo;
        private System.Windows.Forms.Button BotonEliminarImagen;
        private System.Windows.Forms.ComboBox CantidadPiezasPuzzle;
        private System.Windows.Forms.Label TextoCantidadPiezas;
        private System.Windows.Forms.Label TextoCantidadNodos;
        private System.Windows.Forms.Label TextoTiempoIA;
        private System.Windows.Forms.Label TextoVariableTiempo;
        private System.Windows.Forms.Panel panelPuzzleContainer;
        private System.Windows.Forms.Panel panelSolucionPuzzle;
        private System.Windows.Forms.GroupBox GrupoTipoPuzzle;
        private System.Windows.Forms.GroupBox grupoInicioPuzzle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label TextoBotonSeleccionado;
        private System.Windows.Forms.Button botonReiniciarPuzzle;
        private System.Windows.Forms.Timer timer;
    }
}

