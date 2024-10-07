using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Actividad___COLECCIONES___Donda__Melisa_Ileana
{
    public partial class Form1 : Form
    {
        private List<int> numbers;

        public Form1()
        {
            InitializeComponent();
            numbers = new List<int>(); // Inicializamos la lista
        }


        private void UpdateListBox()
        {
            listBoxNumbers.Items.Clear(); // Limpiamos el ListBox
            foreach (var num in numbers)
            {
                listBoxNumbers.Items.Add(num); // Agregamos cada número a la lista
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtNumber.Text, out int number))
            {
                int position = (int)numPosition.Value;

                // Aseguramos que la posición esté dentro de los límites de la lista
                if (position >= 0 && position <= numbers.Count)
                {
                    numbers.Insert(position, number); // Insertamos el número en la posición deseada
                    UpdateListBox();
                    txtNumber.Clear();
                }
                else
                {
                    MessageBox.Show("La posición es inválida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            numbers.Sort(); // Ordenamos la lista de menor a mayor
            UpdateListBox();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int position = (int)numPosition.Value;

            // Verificamos que la posición esté dentro de los límites de la lista
            if (position >= 0 && position < numbers.Count)
            {
                numbers.RemoveAt(position); // Eliminamos el número en la posición deseada
                UpdateListBox();
            }
            else
            {
                MessageBox.Show("La posición es inválida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtNumber.Text, out int number))
            {
                int position = (int)numPosition.Value;

                // Verificamos que la posición esté dentro de los límites de la lista
                if (position >= 0 && position < numbers.Count)
                {
                    numbers[position] = number; // Modificamos el número en la posición deseada
                    UpdateListBox();
                    txtNumber.Clear();
                }
                else
                {
                    MessageBox.Show("La posición es inválida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
