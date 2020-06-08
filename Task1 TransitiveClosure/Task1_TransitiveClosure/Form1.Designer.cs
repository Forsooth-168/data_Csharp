namespace Task1_TransitiveClosure
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_input_path = new System.Windows.Forms.TextBox();
            this.tb_output_path = new System.Windows.Forms.TextBox();
            this.b_save_result = new System.Windows.Forms.Button();
            this.b_browse1 = new System.Windows.Forms.Button();
            this.b_browse2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(72, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "File with graph";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(15, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Path for resulting file";
            // 
            // tb_input_path
            // 
            this.tb_input_path.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_input_path.ForeColor = System.Drawing.Color.Silver;
            this.tb_input_path.Location = new System.Drawing.Point(277, 37);
            this.tb_input_path.Name = "tb_input_path";
            this.tb_input_path.Size = new System.Drawing.Size(441, 31);
            this.tb_input_path.TabIndex = 2;
            this.tb_input_path.Text = "Type path here";
            this.tb_input_path.Click += new System.EventHandler(this.tb_input_path_Click);
            this.tb_input_path.TextChanged += new System.EventHandler(this.tb_input_path_TextChanged);
            this.tb_input_path.Leave += new System.EventHandler(this.tb_input_path_Leave);
            // 
            // tb_output_path
            // 
            this.tb_output_path.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_output_path.ForeColor = System.Drawing.Color.Silver;
            this.tb_output_path.Location = new System.Drawing.Point(277, 117);
            this.tb_output_path.Name = "tb_output_path";
            this.tb_output_path.Size = new System.Drawing.Size(441, 31);
            this.tb_output_path.TabIndex = 3;
            this.tb_output_path.Text = "Type path here";
            this.tb_output_path.Click += new System.EventHandler(this.tb_input_path_Click);
            this.tb_output_path.TextChanged += new System.EventHandler(this.tb_input_path_TextChanged);
            this.tb_output_path.Leave += new System.EventHandler(this.tb_input_path_Leave);
            // 
            // b_save_result
            // 
            this.b_save_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_save_result.Location = new System.Drawing.Point(605, 169);
            this.b_save_result.Name = "b_save_result";
            this.b_save_result.Size = new System.Drawing.Size(224, 40);
            this.b_save_result.TabIndex = 4;
            this.b_save_result.Text = "Save result";
            this.b_save_result.UseVisualStyleBackColor = true;
            this.b_save_result.Click += new System.EventHandler(this.b_save_result_Click);
            // 
            // b_browse1
            // 
            this.b_browse1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_browse1.Location = new System.Drawing.Point(725, 37);
            this.b_browse1.Name = "b_browse1";
            this.b_browse1.Size = new System.Drawing.Size(104, 34);
            this.b_browse1.TabIndex = 5;
            this.b_browse1.Text = "Browse";
            this.b_browse1.UseVisualStyleBackColor = true;
            this.b_browse1.Click += new System.EventHandler(this.b_browse1_Click);
            // 
            // b_browse2
            // 
            this.b_browse2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_browse2.Location = new System.Drawing.Point(725, 114);
            this.b_browse2.Name = "b_browse2";
            this.b_browse2.Size = new System.Drawing.Size(104, 34);
            this.b_browse2.TabIndex = 6;
            this.b_browse2.Text = "Browse";
            this.b_browse2.UseVisualStyleBackColor = true;
            this.b_browse2.Click += new System.EventHandler(this.b_browse2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 242);
            this.Controls.Add(this.b_browse2);
            this.Controls.Add(this.b_browse1);
            this.Controls.Add(this.b_save_result);
            this.Controls.Add(this.tb_output_path);
            this.Controls.Add(this.tb_input_path);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transitive Closure";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_input_path;
        private System.Windows.Forms.TextBox tb_output_path;
        private System.Windows.Forms.Button b_save_result;
        private System.Windows.Forms.Button b_browse1;
        private System.Windows.Forms.Button b_browse2;
    }
}

