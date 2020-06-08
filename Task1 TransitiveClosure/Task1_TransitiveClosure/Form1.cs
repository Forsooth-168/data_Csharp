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

namespace Task1_TransitiveClosure
{
    public partial class Form1 : Form
    {
        private string file_with_graph;
        private string folder_for_saving;

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

        private void b_save_result_Click(object sender, EventArgs e)
        {
            //Проверка, введены ли пути и корректны ли они
            if (tb_input_path.TextLength == 0) return;
            if (!File.Exists(file_with_graph)) return;
            if (!Directory.Exists(folder_for_saving)) return;
            
            readMatrixFromFile(file_with_graph);
        }
    }
}
