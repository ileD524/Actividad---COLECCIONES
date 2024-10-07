namespace Actividad___COLECCIONES___Donda__Melisa_Ileana
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
            btnInsert = new Button();
            btnModify = new Button();
            btnDelete = new Button();
            btnSort = new Button();
            listBoxNumbers = new ListBox();
            txtNumber = new TextBox();
            numPosition = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)numPosition).BeginInit();
            SuspendLayout();
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(212, 59);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(75, 23);
            btnInsert.TabIndex = 0;
            btnInsert.Text = "Agregar";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnModify
            // 
            btnModify.Location = new Point(212, 165);
            btnModify.Name = "btnModify";
            btnModify.Size = new Size(75, 23);
            btnModify.TabIndex = 1;
            btnModify.Text = "Modificar";
            btnModify.UseVisualStyleBackColor = true;
            btnModify.Click += btnModify_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(212, 385);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Eliminar";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSort
            // 
            btnSort.Location = new Point(212, 274);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(75, 23);
            btnSort.TabIndex = 3;
            btnSort.Text = "Ordenar";
            btnSort.UseVisualStyleBackColor = true;
            btnSort.Click += btnSort_Click;
            // 
            // listBoxNumbers
            // 
            listBoxNumbers.FormattingEnabled = true;
            listBoxNumbers.ItemHeight = 15;
            listBoxNumbers.Location = new Point(48, 59);
            listBoxNumbers.Name = "listBoxNumbers";
            listBoxNumbers.Size = new Size(120, 349);
            listBoxNumbers.TabIndex = 4;
            // 
            // txtNumber
            // 
            txtNumber.Location = new Point(378, 183);
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(120, 23);
            txtNumber.TabIndex = 5;
            // 
            // numPosition
            // 
            numPosition.Location = new Point(378, 298);
            numPosition.Name = "numPosition";
            numPosition.Size = new Size(120, 23);
            numPosition.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(378, 165);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 7;
            label1.Text = "Número:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(378, 278);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 8;
            label2.Text = "Posición:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(numPosition);
            Controls.Add(txtNumber);
            Controls.Add(listBoxNumbers);
            Controls.Add(btnSort);
            Controls.Add(btnDelete);
            Controls.Add(btnModify);
            Controls.Add(btnInsert);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numPosition).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnInsert;
        private Button btnModify;
        private Button btnDelete;
        private Button btnSort;
        private ListBox listBoxNumbers;
        private TextBox txtNumber;
        private NumericUpDown numPosition;
        private Label label1;
        private Label label2;
    }
}
