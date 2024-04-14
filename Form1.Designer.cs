
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
            this.NombreTipoSolucion = new System.Windows.Forms.Label();
            this.SeleccionSolucionInteligente = new System.Windows.Forms.ComboBox();
            this.BotonResolver = new System.Windows.Forms.Button();
            this.BotonCargarImagen = new System.Windows.Forms.Button();
            this.BotonPasosSeguir = new System.Windows.Forms.Button();
            this.NombreTipoPuzzle = new System.Windows.Forms.Label();
            this.SeleccionTipoPuzzle = new System.Windows.Forms.ComboBox();
            this.TextoCantidadMovimientos = new System.Windows.Forms.Label();
            this.BotonReiniciarImagen = new System.Windows.Forms.Button();
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
            this.TextoVariableTimeIA = new System.Windows.Forms.Label();
            this.GrupoContenidoPuzzle.SuspendLayout();
            this.GrupoContenidoImagenObjetivo.SuspendLayout();
            this.SuspendLayout();
            // 
            // NombreTipoSolucion
            // 
            this.NombreTipoSolucion.AutoSize = true;
            this.NombreTipoSolucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreTipoSolucion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NombreTipoSolucion.Location = new System.Drawing.Point(507, 448);
            this.NombreTipoSolucion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NombreTipoSolucion.Name = "NombreTipoSolucion";
            this.NombreTipoSolucion.Size = new System.Drawing.Size(227, 31);
            this.NombreTipoSolucion.TabIndex = 2;
            this.NombreTipoSolucion.Text = "Tipo de solución";
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
            this.SeleccionSolucionInteligente.Location = new System.Drawing.Point(502, 487);
            this.SeleccionSolucionInteligente.Margin = new System.Windows.Forms.Padding(4);
            this.SeleccionSolucionInteligente.Name = "SeleccionSolucionInteligente";
            this.SeleccionSolucionInteligente.Size = new System.Drawing.Size(135, 24);
            this.SeleccionSolucionInteligente.TabIndex = 3;
            // 
            // BotonResolver
            // 
            this.BotonResolver.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BotonResolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonResolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonResolver.Location = new System.Drawing.Point(645, 483);
            this.BotonResolver.Margin = new System.Windows.Forms.Padding(4);
            this.BotonResolver.Name = "BotonResolver";
            this.BotonResolver.Size = new System.Drawing.Size(120, 36);
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
            this.BotonCargarImagen.Location = new System.Drawing.Point(494, 378);
            this.BotonCargarImagen.Margin = new System.Windows.Forms.Padding(4);
            this.BotonCargarImagen.Name = "BotonCargarImagen";
            this.BotonCargarImagen.Size = new System.Drawing.Size(114, 36);
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
            this.BotonPasosSeguir.Location = new System.Drawing.Point(16, 516);
            this.BotonPasosSeguir.Margin = new System.Windows.Forms.Padding(4);
            this.BotonPasosSeguir.Name = "BotonPasosSeguir";
            this.BotonPasosSeguir.Size = new System.Drawing.Size(193, 36);
            this.BotonPasosSeguir.TabIndex = 7;
            this.BotonPasosSeguir.Text = "Lista de pasos";
            this.BotonPasosSeguir.UseVisualStyleBackColor = false;
            // 
            // NombreTipoPuzzle
            // 
            this.NombreTipoPuzzle.AutoSize = true;
            this.NombreTipoPuzzle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreTipoPuzzle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NombreTipoPuzzle.Location = new System.Drawing.Point(473, 308);
            this.NombreTipoPuzzle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NombreTipoPuzzle.Name = "NombreTipoPuzzle";
            this.NombreTipoPuzzle.Size = new System.Drawing.Size(124, 25);
            this.NombreTipoPuzzle.TabIndex = 8;
            this.NombreTipoPuzzle.Text = "Tipo puzzle";
            // 
            // SeleccionTipoPuzzle
            // 
            this.SeleccionTipoPuzzle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SeleccionTipoPuzzle.FormattingEnabled = true;
            this.SeleccionTipoPuzzle.IntegralHeight = false;
            this.SeleccionTipoPuzzle.Items.AddRange(new object[] {
            "Imagen",
            "Números"});
            this.SeleccionTipoPuzzle.Location = new System.Drawing.Point(478, 337);
            this.SeleccionTipoPuzzle.Margin = new System.Windows.Forms.Padding(4);
            this.SeleccionTipoPuzzle.Name = "SeleccionTipoPuzzle";
            this.SeleccionTipoPuzzle.Size = new System.Drawing.Size(114, 24);
            this.SeleccionTipoPuzzle.TabIndex = 9;
            this.SeleccionTipoPuzzle.SelectedIndexChanged += new System.EventHandler(this.SeleccionTipoPuzzle_SelectedIndexChanged);
            // 
            // TextoCantidadMovimientos
            // 
            this.TextoCantidadMovimientos.AutoSize = true;
            this.TextoCantidadMovimientos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextoCantidadMovimientos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TextoCantidadMovimientos.Location = new System.Drawing.Point(248, 486);
            this.TextoCantidadMovimientos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TextoCantidadMovimientos.Name = "TextoCantidadMovimientos";
            this.TextoCantidadMovimientos.Size = new System.Drawing.Size(144, 25);
            this.TextoCantidadMovimientos.TabIndex = 10;
            this.TextoCantidadMovimientos.Text = "Movimientos: 0";
            // 
            // BotonReiniciarImagen
            // 
            this.BotonReiniciarImagen.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BotonReiniciarImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonReiniciarImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonReiniciarImagen.Location = new System.Drawing.Point(244, 417);
            this.BotonReiniciarImagen.Margin = new System.Windows.Forms.Padding(4);
            this.BotonReiniciarImagen.Name = "BotonReiniciarImagen";
            this.BotonReiniciarImagen.Size = new System.Drawing.Size(193, 36);
            this.BotonReiniciarImagen.TabIndex = 12;
            this.BotonReiniciarImagen.Text = "Cambiar tamaño";
            this.BotonReiniciarImagen.UseVisualStyleBackColor = false;
            this.BotonReiniciarImagen.Click += new System.EventHandler(this.BotonReiniciarImagen_Click);
            // 
            // BotonMezclarImagen
            // 
            this.BotonMezclarImagen.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BotonMezclarImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonMezclarImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonMezclarImagen.Location = new System.Drawing.Point(16, 417);
            this.BotonMezclarImagen.Margin = new System.Windows.Forms.Padding(4);
            this.BotonMezclarImagen.Name = "BotonMezclarImagen";
            this.BotonMezclarImagen.Size = new System.Drawing.Size(208, 36);
            this.BotonMezclarImagen.TabIndex = 13;
            this.BotonMezclarImagen.Text = "Mezclar de nuevo";
            this.BotonMezclarImagen.UseVisualStyleBackColor = false;
            this.BotonMezclarImagen.Click += new System.EventHandler(this.BotonMezclarImagen_Click);
            // 
            // BotonGuardarSolucion
            // 
            this.BotonGuardarSolucion.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BotonGuardarSolucion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonGuardarSolucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonGuardarSolucion.Location = new System.Drawing.Point(244, 516);
            this.BotonGuardarSolucion.Margin = new System.Windows.Forms.Padding(4);
            this.BotonGuardarSolucion.Name = "BotonGuardarSolucion";
            this.BotonGuardarSolucion.Size = new System.Drawing.Size(193, 36);
            this.BotonGuardarSolucion.TabIndex = 14;
            this.BotonGuardarSolucion.Text = "Guardar Solución";
            this.BotonGuardarSolucion.UseVisualStyleBackColor = false;
            // 
            // GrupoContenidoPuzzle
            // 
            this.GrupoContenidoPuzzle.Controls.Add(this.panelPuzzleContainer);
            this.GrupoContenidoPuzzle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrupoContenidoPuzzle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.GrupoContenidoPuzzle.Location = new System.Drawing.Point(16, 15);
            this.GrupoContenidoPuzzle.Margin = new System.Windows.Forms.Padding(4);
            this.GrupoContenidoPuzzle.Name = "GrupoContenidoPuzzle";
            this.GrupoContenidoPuzzle.Padding = new System.Windows.Forms.Padding(4);
            this.GrupoContenidoPuzzle.Size = new System.Drawing.Size(427, 394);
            this.GrupoContenidoPuzzle.TabIndex = 15;
            this.GrupoContenidoPuzzle.TabStop = false;
            this.GrupoContenidoPuzzle.Text = "Imagen Insertada";
            // 
            // panelPuzzleContainer
            // 
            this.panelPuzzleContainer.Location = new System.Drawing.Point(36, 30);
            this.panelPuzzleContainer.Name = "panelPuzzleContainer";
            this.panelPuzzleContainer.Size = new System.Drawing.Size(350, 350);
            this.panelPuzzleContainer.TabIndex = 0;
            // 
            // GrupoContenidoImagenObjetivo
            // 
            this.GrupoContenidoImagenObjetivo.Controls.Add(this.panelSolucionPuzzle);
            this.GrupoContenidoImagenObjetivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrupoContenidoImagenObjetivo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.GrupoContenidoImagenObjetivo.Location = new System.Drawing.Point(473, 26);
            this.GrupoContenidoImagenObjetivo.Margin = new System.Windows.Forms.Padding(4);
            this.GrupoContenidoImagenObjetivo.Name = "GrupoContenidoImagenObjetivo";
            this.GrupoContenidoImagenObjetivo.Padding = new System.Windows.Forms.Padding(4);
            this.GrupoContenidoImagenObjetivo.Size = new System.Drawing.Size(288, 272);
            this.GrupoContenidoImagenObjetivo.TabIndex = 16;
            this.GrupoContenidoImagenObjetivo.TabStop = false;
            this.GrupoContenidoImagenObjetivo.Text = "Objetivo";
            // 
            // panelSolucionPuzzle
            // 
            this.panelSolucionPuzzle.Location = new System.Drawing.Point(21, 25);
            this.panelSolucionPuzzle.Name = "panelSolucionPuzzle";
            this.panelSolucionPuzzle.Size = new System.Drawing.Size(240, 240);
            this.panelSolucionPuzzle.TabIndex = 1;
            // 
            // BotonEliminarImagen
            // 
            this.BotonEliminarImagen.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BotonEliminarImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonEliminarImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonEliminarImagen.Location = new System.Drawing.Point(616, 378);
            this.BotonEliminarImagen.Margin = new System.Windows.Forms.Padding(4);
            this.BotonEliminarImagen.Name = "BotonEliminarImagen";
            this.BotonEliminarImagen.Size = new System.Drawing.Size(110, 36);
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
            this.CantidadPiezasPuzzle.Location = new System.Drawing.Point(633, 337);
            this.CantidadPiezasPuzzle.Margin = new System.Windows.Forms.Padding(4);
            this.CantidadPiezasPuzzle.Name = "CantidadPiezasPuzzle";
            this.CantidadPiezasPuzzle.Size = new System.Drawing.Size(110, 24);
            this.CantidadPiezasPuzzle.TabIndex = 18;
            // 
            // TextoCantidadPiezas
            // 
            this.TextoCantidadPiezas.AutoSize = true;
            this.TextoCantidadPiezas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextoCantidadPiezas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TextoCantidadPiezas.Location = new System.Drawing.Point(605, 308);
            this.TextoCantidadPiezas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TextoCantidadPiezas.Name = "TextoCantidadPiezas";
            this.TextoCantidadPiezas.Size = new System.Drawing.Size(160, 25);
            this.TextoCantidadPiezas.TabIndex = 19;
            this.TextoCantidadPiezas.Text = "Tamaño puzzle";
            // 
            // TextoCantidadNodos
            // 
            this.TextoCantidadNodos.AutoSize = true;
            this.TextoCantidadNodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextoCantidadNodos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TextoCantidadNodos.Location = new System.Drawing.Point(584, 523);
            this.TextoCantidadNodos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TextoCantidadNodos.Name = "TextoCantidadNodos";
            this.TextoCantidadNodos.Size = new System.Drawing.Size(91, 25);
            this.TextoCantidadNodos.TabIndex = 20;
            this.TextoCantidadNodos.Text = "Nodos: 0";
            // 
            // TextoTiempoIA
            // 
            this.TextoTiempoIA.AutoSize = true;
            this.TextoTiempoIA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextoTiempoIA.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TextoTiempoIA.Location = new System.Drawing.Point(11, 486);
            this.TextoTiempoIA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TextoTiempoIA.Name = "TextoTiempoIA";
            this.TextoTiempoIA.Size = new System.Drawing.Size(84, 25);
            this.TextoTiempoIA.TabIndex = 21;
            this.TextoTiempoIA.Text = "Tiempo:";
            // 
            // TextoVariableTimeIA
            // 
            this.TextoVariableTimeIA.AutoSize = true;
            this.TextoVariableTimeIA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextoVariableTimeIA.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TextoVariableTimeIA.Location = new System.Drawing.Point(92, 486);
            this.TextoVariableTimeIA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TextoVariableTimeIA.Name = "TextoVariableTimeIA";
            this.TextoVariableTimeIA.Size = new System.Drawing.Size(79, 25);
            this.TextoVariableTimeIA.TabIndex = 22;
            this.TextoVariableTimeIA.Text = "0:00:00";
            // 
            // Pantalla_Inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(788, 570);
            this.Controls.Add(this.TextoVariableTimeIA);
            this.Controls.Add(this.TextoTiempoIA);
            this.Controls.Add(this.TextoCantidadNodos);
            this.Controls.Add(this.TextoCantidadPiezas);
            this.Controls.Add(this.CantidadPiezasPuzzle);
            this.Controls.Add(this.BotonEliminarImagen);
            this.Controls.Add(this.GrupoContenidoImagenObjetivo);
            this.Controls.Add(this.GrupoContenidoPuzzle);
            this.Controls.Add(this.BotonGuardarSolucion);
            this.Controls.Add(this.BotonMezclarImagen);
            this.Controls.Add(this.BotonReiniciarImagen);
            this.Controls.Add(this.TextoCantidadMovimientos);
            this.Controls.Add(this.SeleccionTipoPuzzle);
            this.Controls.Add(this.NombreTipoPuzzle);
            this.Controls.Add(this.BotonPasosSeguir);
            this.Controls.Add(this.BotonCargarImagen);
            this.Controls.Add(this.BotonResolver);
            this.Controls.Add(this.SeleccionSolucionInteligente);
            this.Controls.Add(this.NombreTipoSolucion);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Pantalla_Inicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Intelligent Puzzle Solver";
            this.GrupoContenidoPuzzle.ResumeLayout(false);
            this.GrupoContenidoImagenObjetivo.ResumeLayout(false);
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
        private System.Windows.Forms.Button BotonReiniciarImagen;
        private System.Windows.Forms.Button BotonMezclarImagen;
        private System.Windows.Forms.Button BotonGuardarSolucion;
        private System.Windows.Forms.GroupBox GrupoContenidoPuzzle;
        private System.Windows.Forms.GroupBox GrupoContenidoImagenObjetivo;
        private System.Windows.Forms.Button BotonEliminarImagen;
        private System.Windows.Forms.ComboBox CantidadPiezasPuzzle;
        private System.Windows.Forms.Label TextoCantidadPiezas;
        private System.Windows.Forms.Label TextoCantidadNodos;
        private System.Windows.Forms.Label TextoTiempoIA;
        private System.Windows.Forms.Label TextoVariableTimeIA;
        private System.Windows.Forms.Panel panelPuzzleContainer;
        private System.Windows.Forms.Panel panelSolucionPuzzle;
    }
}

