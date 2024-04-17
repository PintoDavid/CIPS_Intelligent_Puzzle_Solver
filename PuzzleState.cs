using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace PuzzleSolver_IA
{
    public class PuzzleState
    {
        private Form2 form2; // Referencia a Form2
        private PuzzleState ParentState;

        // Lista de botones del rompecabezas
        private List<Button> puzzleButtons;

        public PuzzleState(List<Button> puzzleButtons, Form2 form2)
        {
            this.puzzleButtons = puzzleButtons;
            this.form2 = form2; // Asigna la referencia a Form2
        }

        // Método para imprimir la matriz de texto en el TextBox de Form2
        public void PrintTextMatrix(int stepNumber, string[,] textMatrix)
        {
            int size = textMatrix.GetLength(0);

            // Agregar el número del paso al comienzo
            form2.UpdateStepsText($"Paso {stepNumber}:");

            // Iterar sobre la matriz y agregar el texto de los botones
            for (int i = 0; i < size; i++)
            {
                StringBuilder sb = new StringBuilder();
                for (int j = 0; j < size; j++)
                {
                    string buttonText = textMatrix[i, j];
                    sb.Append(buttonText == "" ? "_" : buttonText);
                    sb.Append(" ");
                }
                form2.UpdateStepsText(sb.ToString()); // Actualiza el TextBox en Form2
            }

            // Agregar un separador entre cada matriz de botones
            form2.UpdateStepsText("------------------------------------------------------------");
        }

        // Método para obtener el estado inicial del rompecabezas
        public static PuzzleState GetInitialState(List<Button> puzzleButtons, Form2 form2)
        {
            // Simplemente creamos un nuevo estado inicial con la lista de botones proporcionada
            return new PuzzleState(puzzleButtons, form2);
        }

        // Método para obtener el estado final del rompecabezas
        public static PuzzleState GetFinalState(List<Button> puzzleButtons, Form2 form2)
        {
            // Simplemente creamos un nuevo estado final con la lista de botones proporcionada
            return new PuzzleState(puzzleButtons, form2);
        }

        // Método para realizar la búsqueda utilizando el algoritmo de BFS
        public static List<PuzzleState> BFS(PuzzleState initialState)
        {
            List<PuzzleState> visited = new List<PuzzleState>();
            Queue<PuzzleState> queue = new Queue<PuzzleState>();
            queue.Enqueue(initialState);

            while (queue.Count > 0)
            {
                PuzzleState currentState = queue.Dequeue();
                visited.Add(currentState);

                // Aquí puedes agregar la lógica para encontrar el estado objetivo
                // Por ejemplo, puedes usar el método IsGoalState

                if (currentState.IsGoalState())
                {
                    // Si se encuentra el estado objetivo, puedes llamar al método PrintTextMatrix
                    // para imprimir la matriz de texto en Form2 y luego devolver el camino al estado inicial

                    string[,] currentStateMatrix = currentState.GetTextMatrix();
                    currentState.PrintTextMatrix(visited.Count, currentStateMatrix);

                    // Luego, si se encuentra el estado objetivo, puedes usar GetPathToInitialState
                    // para obtener el camino de regreso al estado inicial y devolverlo

                    return GetPathToInitialState(currentState);
                }

                foreach (PuzzleState nextState in currentState.GetPossibleMoves())
                {
                    if (!visited.Contains(nextState))
                    {
                        nextState.ParentState = currentState; // Establecer el estado padre
                        queue.Enqueue(nextState);
                    }
                }
            }

            return null; // No se encontró solución
        }

        // Método para obtener el camino de regreso al estado inicial
        private static List<PuzzleState> GetPathToInitialState(PuzzleState state)
        {
            List<PuzzleState> path = new List<PuzzleState>();
            while (state != null)
            {
                path.Insert(0, state);
                state = state.ParentState;
            }
            return path;
        }

        // Método para obtener los posibles movimientos para hacer en el puzzle
        public List<PuzzleState> GetPossibleMoves()
        {
            List<PuzzleState> possibleMoves = new List<PuzzleState>();
            // Encuentra la posición del botón vacío
            int emptyIndex = puzzleButtons.FindIndex(button => button.Text == "");
            int numRows = (int)Math.Sqrt(puzzleButtons.Count);
            int numCols = numRows; // Suponiendo que es una matriz cuadrada

            // Calcula la fila y columna del botón vacío
            int emptyRow = emptyIndex / numCols;
            int emptyCol = emptyIndex % numCols;

            // Definir direcciones de movimiento (arriba, abajo, izquierda, derecha)
            int[] dx = { 0, 0, -1, 1 };
            int[] dy = { -1, 1, 0, 0 };

            // Itera sobre las direcciones de movimiento
            for (int i = 0; i < 4; i++)
            {
                int newRow = emptyRow + dx[i];
                int newCol = emptyCol + dy[i];

                // Verifica si la nueva posición está dentro de los límites de la matriz
                if (newRow >= 0 && newRow < numRows && newCol >= 0 && newCol < numCols)
                {
                    // Calcula el índice del botón a intercambiar
                    int newIndex = newRow * numCols + newCol;

                    // Crea una copia de los botones para representar el nuevo estado
                    List<Button> newButtons = new List<Button>(puzzleButtons);

                    // Intercambia el texto de los botones
                    string tempText = newButtons[emptyIndex].Text;
                    newButtons[emptyIndex].Text = newButtons[newIndex].Text;
                    newButtons[newIndex].Text = tempText;

                    // Crea un nuevo estado y agrégalo a la lista de movimientos posibles
                    possibleMoves.Add(new PuzzleState(newButtons, form2));
                }
            }

            return possibleMoves;
        }

        // Método para obtener la representación del estado como una matriz de texto
        private string[,] GetTextMatrix()
        {
            int size = (int)Math.Sqrt(puzzleButtons.Count);
            string[,] textMatrix = new string[size, size];

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Button button = puzzleButtons[i * size + j];
                    textMatrix[i, j] = button.Text == "" ? "_" : button.Text;
                }
            }

            return textMatrix;
        }

        // Método para comparar el estado actual con el objetivo final
        public bool IsGoalState()
        {
            string[,] currentState = GetTextMatrix();
            string[,] finalState = GetFinalState(null).GetTextMatrix();

            for (int i = 0; i < currentState.GetLength(0); i++)
            {
                for (int j = 0; j < currentState.GetLength(1); j++)
                {
                    if (currentState[i, j] != finalState[i, j])
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}