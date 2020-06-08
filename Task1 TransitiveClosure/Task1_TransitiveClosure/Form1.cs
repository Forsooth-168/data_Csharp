using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;

namespace Task1_TransitiveClosure
{
    public partial class Form1 : Form
    {
        private string file_with_graph;

        public Form1()
        {
            InitializeComponent();
        }

        private void tb_input_path_TextChanged(object sender, EventArgs e)
        {
            TextBox text_box = (TextBox)sender;
            if (text_box.Text.Contains("Type path here"))
                text_box.ForeColor = Color.Silver;
            else
                text_box.ForeColor = Color.Black;
        }

        private void tb_input_path_Click(object sender, EventArgs e)
        {
            TextBox text_box = (TextBox)sender;
            if (text_box.Text.Contains("Type path here"))
                text_box.Text = "";
            text_box.ForeColor = Color.Black;
        }

        private void tb_input_path_Leave(object sender, EventArgs e)
        {
            TextBox text_box = (TextBox)sender;
            if (text_box.Text.Length == 0 || text_box.Text.Contains("Type path here"))
            {
                text_box.ForeColor = Color.Silver;
                text_box.Text = "Type path here";
            }
            else
            {
                text_box.ForeColor = Color.Black;
            }
        }

        //Диалоговое окно для поиска файла с графом
        private void b_browse1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open_file_dialog = new OpenFileDialog();
            open_file_dialog.DefaultExt = "*.txt";
            open_file_dialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (open_file_dialog.ShowDialog() == DialogResult.OK && open_file_dialog.FileName.Length > 0)
            {
                file_with_graph = open_file_dialog.FileName;
                tb_input_path.Text = file_with_graph;
            }
        }

        //Поиск пути для папки, в которой будем сохранять результат
        private void b_browse2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder_dialog = new FolderBrowserDialog();
            if (folder_dialog.ShowDialog() == DialogResult.OK)
            {
                folder_for_saving = folder_dialog.SelectedPath;
                tb_output_path.Text = folder_for_saving;
            }
        }

        //Чтение матрицы из файла
        private int[,] readMatrixFromFile(string file_name)
        {
            try
            {
                string[] matrix_lines = File.ReadAllLines(file_name);

                int[,] matrix = new int[matrix_lines.Length, matrix_lines.Length];

                //Заполняем матрицу
                for (int i = 0; i < matrix_lines.Length; ++i)
                {
                    string[] cur_row = matrix_lines[i].Split(new char[] { ' ' });
                    for (int j = 0; j < matrix_lines.Length; ++j)
                    {
                        try
                        {
                            matrix[i, j] = Int32.Parse(cur_row[j]);
                        }
                        catch (InvalidCastException ex)
                        {
                            MessageBox.Show(ex.Message);
                            throw;
                        }
                    }
                }

                return matrix;
            }
            catch(FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        //Функция, определяющая, существует ли путь из вершины с индексом v1  в 
        //вершину с индексом v2, исходя из матрицы смежности matrix
        private bool wayExists(int[,] matrix, int v1, int v2)
        { 
            
        }

        //Построение транзитивного замыкания на основе матрицы смежности matrix
        private int[,] buildTransititveClosure(int[,] matrix)
        {
            int n = (int)Math.Sqrt(matrix.Length); //Размер матрицы
            int[,] trans_closure = new int[n, n];//Результирующая матрица

            //Для каждой пары вершин выясняем, существует ли путь
            for (int i = 0; i < n; ++i)
                for (int j = 0; j < n; ++j)
                    if (i == j || matrix[i, j] == 1 || wayExists(matrix, i, j))
                        trans_closure[i, j] = 1;
                    else
                        trans_closure[i, j] = 0;

            return trans_closure;

        }

        private void b_save_result_Click(object sender, EventArgs e)
        {
            //Проверка корректности введенного пути
            if (tb_input_path.TextLength == 0)
            {
                MessageBox.Show("Enter the path to the file with graph.");
                return;
            }
            if (!File.Exists(file_with_graph))
            {
                MessageBox.Show("Enter correct path to the file with graph.");
                return;
            }

            //Матрица смежности графа
            try
            {
                int[,] matrix = readMatrixFromFile(file_with_graph);


                //Проверяем, содержит ли матрица что-то кроме 0 и 1
                int n = (int)Math.Sqrt(matrix.Length); //Размер матрицы
                for (int i = 0; i < n; ++i)
                    for (int j = 0; j < n; ++j)
                        if (matrix[i, j] != 0 && matrix[i, j] != 1)
                        {
                            MessageBox.Show("Adjacency matrix is not correct. It is impossible" +
                                " to build transitive closure.");
                            return;
                        }

                //Строим матрицу смежности транзитивного замыкания
                int[,] trans_closure = buildTransititveClosure(matrix);

                //Записываем транзитивное замыкание в файл
                writeMatrixToFile(trans_closure);
            }
            catch(InvalidCastException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            catch(FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
    }
}
