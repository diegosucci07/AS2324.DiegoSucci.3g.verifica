namespace AS2324.DiegoSucci._3g.verifica
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            dgvDati = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvDati).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(164, 23);
            button1.TabIndex = 0;
            button1.Text = "Elenco Squadre";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(182, 12);
            button2.Name = "button2";
            button2.Size = new Size(164, 23);
            button2.TabIndex = 1;
            button2.Text = "Elenco Gare";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dgvDati
            // 
            dgvDati.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDati.Location = new Point(12, 182);
            dgvDati.Name = "dgvDati";
            dgvDati.RowTemplate.Height = 25;
            dgvDati.Size = new Size(776, 265);
            dgvDati.TabIndex = 2;
            dgvDati.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvDati);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvDati).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private DataGridView dgvDati;
    }
}
