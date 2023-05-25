using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace A_proyecto_blue_2
{
    public partial class Caja : Form
    {
        private int total = 0;
        private int rowIndexToEdit = -1; // Variable para almacenar el índice de la fila a editar
        Random Codigo = new Random();
        private Timer timer;
        public Caja()
        {
            InitializeComponent();

            //Para crear codigos random.
            int valor = 0;
            valor = Convert.ToInt32(Codigo.Next(0, 999));
            txtCodigo.Text = valor.ToString();

            // Asignar el evento KeyDown a cada TextBox
            txtCodigo.KeyDown += Caja_KeyDown;
            txtNombre.KeyDown += Caja_KeyDown;
            txtPxU.KeyDown += Caja_KeyDown;
            txtCantidad.KeyDown += Caja_KeyDown;
        }
        private void aGREGARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Agregar_Producto();
        }
        private void eLIMINARPRODUCTOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EliminarProducto();
        }
        private void eDITARPRODUCTOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditarProducto();
        }
        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EliminarTodo();
        }
        private void btnGenerarCodigo_Click(object sender, EventArgs e)
        {
            GenerarCodigo();
        }
        private void btnPrecio_Click(object sender, EventArgs e)
        {
            GenerarPrecio();
        }
        private void BtnCantidad_Click(object sender, EventArgs e)
        {
            GenerarCantidad();
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }
        private void btnPagar_Click(object sender, EventArgs e)
        {
            Pagar();
        }
        private void gUARDADLISTAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GuardadLista();
        }
        public void Agregar_Producto()
        {
            Producto producto = new Producto(int.Parse(txtCodigo.Text), txtNombre.Text, double.Parse(txtPxU.Text), int.Parse(txtCantidad.Text));

            // AGREGA UN RENGLON NUEVO A LA DATA GRIDVIEW.
            int n = dataGridView1.Rows.Add();

            // VARIABLES PARA MULTIPLICAR CANTIDAD POR PRECIO X UNIDAD.
            int a = 0, b = 0;
            a = ((int)producto.Cantidad * (int)producto.PxU);
            b = a;

            // DataGridView Para Que Se Muestre.

            // AGREGA EL CODIGO A LA COLUMNA 0.
            dataGridView1.Rows[n].Cells[0].Value = producto.Codigo;
            // AGREGA EL NOMBRE DEL PRODUCTO A LA COLUMNA 1
            dataGridView1.Rows[n].Cells[1].Value = producto.Nombre;
            // AGREGA EL PRECIO DE PRODUCTO POR UNIDAD A LA COLUMNA 2
            dataGridView1.Rows[n].Cells[2].Value = producto.PxU;
            // AGREGA LA CANTIDAD DE PRODUCTOS EN LA COLUMNA 3.
            dataGridView1.Rows[n].Cells[3].Value = producto.Cantidad;
            // AGREGA LA MULTIPLICACION DE PRODUCTO POR UNIDAD POR CANTIDAD EN LA COLUMNA 5
            dataGridView1.Rows[n].Cells[4].Value = b;
            //CREA SONIDO DE OXXO DE UN SISTEMA CUANDO AGREGAS UN PRODUCTO.
            Console.Beep();
            //PARA BORRAR LOS TEXTBOX.
            txtCodigo.Clear();
            txtNombre.Clear();
            txtPxU.Clear();
            txtCantidad.Clear();

            // SUMAR LA COLUMNA 5
            int SumaProducto = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                int valorCelda = Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value);
                SumaProducto += valorCelda;
            }

            // Mostrar la suma en una etiqueta (Label) llamada lblSuma
            label5.Text = SumaProducto.ToString();

            //Para crear codigos random.
            int valor = 0;
            valor = Convert.ToInt32(Codigo.Next(0, 999));
            txtCodigo.Text = valor.ToString();
        }
        public void EliminarProducto()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Obtener el índice de la fila seleccionada
                int rowIndex = dataGridView1.SelectedRows[0].Index;

                // Obtener el valor de la columna 5 (b) de la fila seleccionada
                int precio = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells[4].Value);

                // Restar el precio al total
                int sumaActual = int.Parse(label5.Text);
                int nuevaSuma = sumaActual - precio;

                // Actualizar el valor de la etiqueta (Label) label5
                label5.Text = nuevaSuma.ToString();

                // Eliminar la fila seleccionada
                dataGridView1.Rows.RemoveAt(rowIndex);
            }
        }
        private void EditarProducto()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Obtener el índice de la fila seleccionada
                int rowIndex = dataGridView1.SelectedRows[0].Index;

                // Guardar el índice de la fila seleccionada para editar
                rowIndexToEdit = rowIndex;

                // Obtener los valores de la fila seleccionada
                int codigo = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells[0].Value);  // Obtener el valor de la columna "Código" de la fila seleccionada y convertirlo a entero
                string nombre = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();  // Obtener el valor de la columna "Nombre" de la fila seleccionada y convertirlo a cadena
                double precio = Convert.ToDouble(dataGridView1.Rows[rowIndex].Cells[2].Value);  // Obtener el valor de la columna "Precio" de la fila seleccionada y convertirlo a double
                int cantidad = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells[3].Value);  // Obtener el valor de la columna "Cantidad" de la fila seleccionada y convertirlo a entero

                // Mostrar los valores en los TextBox para editar
                txtCodigo.Text = codigo.ToString();  // Asignar el valor de "codigo" al TextBox txtCodigo
                txtNombre.Text = nombre;  // Asignar el valor de "nombre" al TextBox txtNombre
                txtPxU.Text = precio.ToString();  // Asignar el valor de "precio" al TextBox txtPxU
                txtCantidad.Text = cantidad.ToString();  // Asignar el valor de "cantidad" al TextBox txtCantidad

                // Eliminar la fila seleccionada
                dataGridView1.Rows.RemoveAt(rowIndex);  // Eliminar la fila seleccionada del DataGridView
            }
        }
        private void EliminarTodo()
        {
            //para borrar toda la lista.
            dataGridView1.Rows.Clear();
        }
        private void GenerarCodigo()
        {
            //Para crear codigos random.
            int valor = 0;
            valor = Convert.ToInt32(Codigo.Next(0, 999));
            txtCodigo.Text = valor.ToString();
        }
        private void GenerarPrecio()
        {
            //PARA GENERAR UN PRECIO RANDOM.
            int valor = 0;
            valor = Convert.ToInt32(Codigo.Next(0, 100));
            txtPxU.Text = valor.ToString();
        }
        private void GenerarCantidad()
        {
            //PARA GEERAR UN PRENCIO RANDOM.
            int valor = 0;
            valor = Convert.ToInt32(Codigo.Next(1, 10));
            txtCantidad.Text = valor.ToString();
        }
        private void Pagar()
        {
            // Variable para almacenar el monto del pago
            int pago = 0;

            // Verificar si el valor ingresado en el TextBox puede ser convertido a un entero
            if (int.TryParse(txtPago.Text, out pago))
            {
                // Obtener el valor total de la etiqueta (Label) label5 y convertirlo a entero
                int total = int.Parse(label5.Text);

                // Calcular el cambio restando el pago total al monto del pago realizado
                int cambio = pago - total;

                // Mostrar un MessageBox con el total, el pago y el cambio
                MessageBox.Show($"Total: {total}\nPago: {pago}\nCambio: {cambio}");

                // Eliminar todas las filas del DataGridView
                dataGridView1.Rows.Clear();

                // Emitir un sonido de beep
                Console.Beep();

                //para borrar toda la lista.
                dataGridView1.Rows.Clear();

                //Borra la etigueta de totoal.
                label5.Text = "Total : $0.0";

                //Borrar el texbox.
                txtPago.Clear();
            }
            else
            {
                // Mostrar un MessageBox indicando que se debe ingresar un valor válido para el pago
                MessageBox.Show("Ingrese un valor válido para el pago.");
            }
        }
        private void Buscar()
        {
            string codigoBuscado = txtBuscarCodigo.Text;  // Obtener el código buscado desde el TextBox txtBuscarCodigo
            bool encontrado = false;  // Variable para indicar si se encontró el producto

            foreach (DataGridViewRow row in dataGridView1.Rows)  // Iterar a través de todas las filas del DataGridView
            {
                if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == codigoBuscado)
                {
                    // Si el valor de la celda en la columna 0 no es nulo y coincide con el código buscado
                    dataGridView1.CurrentCell = row.Cells[0];  // Establecer la celda actual en la celda encontrada
                    encontrado = true;  // Indicar que se encontró el producto
                    txtBuscarCodigo.Clear();  // Borrar el contenido del TextBox txtBuscarCodigo
                    break;  // Salir del bucle foreach
                }
                if (row.Cells[0].Value != null && row.Cells[1].Value.ToString() == codigoBuscado)
                {
                    // Si el valor de la celda en la columna 0 no es nulo y coincide con el nombre buscado
                    dataGridView1.CurrentCell = row.Cells[1];  // Establecer la celda actual en la celda encontrada
                    encontrado = true;  // Indicar que se encontró el producto
                    txtBuscarCodigo.Clear();  // Borrar el contenido del TextBox txtBuscarCodigo
                    break;  // Salir del bucle foreach
                }
            }

            if (!encontrado)
            {
                // Si no se encontró el producto
                MessageBox.Show("Producto no encontrado, Ingrese (Código o Nombre)", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);  // Mostrar un mensaje indicando que el producto no fue encontrado
            }
        }
        private void GuardadLista()
        {
            // Crear el diálogo de guardar archivo
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt";
            saveFileDialog.Title = "Guardar archivo de texto";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Abrir el archivo seleccionado
                    using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName))
                    {
                        // Escribir los datos de la DataGridView en el archivo
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            if (!row.IsNewRow)
                            {
                                // Obtener los valores de las celdas y escribirlos en el archivo
                                string codigo = row.Cells[0].Value.ToString();
                                string nombre = row.Cells[1].Value.ToString();
                                string pxu = row.Cells[2].Value.ToString();
                                string cantidad = row.Cells[3].Value.ToString();
                                string total = row.Cells[4].Value.ToString();

                                sw.WriteLine($"{codigo},{nombre},{pxu},{cantidad},{total}");
                            }
                        }
                    }

                    MessageBox.Show("Datos guardados correctamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar el archivo: " + ex.Message);
                }
            }
        }
        private void Caja_KeyDown(object sender, KeyEventArgs e)
        {
            // Verificar si se presionó la tecla Enter
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Evitar que el TextBox reciba la tecla Enter

                Control nextControl = GetNextControl((Control)sender, true);

                if (nextControl != null)
                {
                    nextControl.Focus(); // Establecer el enfoque en el siguiente control
                }
            }
        }

        private void aBRIRLALISTAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Crear el diálogo de abrir archivo
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt";
            openFileDialog.Title = "Abrir archivo de texto";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Obtener la ruta completa del archivo seleccionado
                    string filePath = openFileDialog.FileName;

                    // Leer todas las líneas del archivo de texto
                    string[] lines = File.ReadAllLines(filePath);

                    // Limpiar la DataGridView antes de cargar los nuevos datos
                    dataGridView1.Rows.Clear();

                    // Recorrer cada línea del archivo y agregar los datos a la DataGridView
                    foreach (string line in lines)
                    {
                        // Dividir la línea en partes utilizando la coma como separador
                        string[] parts = line.Split(',');

                        // Agregar una nueva fila a la DataGridView
                        int rowIndex = dataGridView1.Rows.Add();

                        // Asignar los valores a cada celda de la fila
                        dataGridView1.Rows[rowIndex].Cells[0].Value = parts[0]; // Código
                        dataGridView1.Rows[rowIndex].Cells[1].Value = parts[1]; // Nombre
                        dataGridView1.Rows[rowIndex].Cells[2].Value = parts[2]; // Precio por unidad
                        dataGridView1.Rows[rowIndex].Cells[3].Value = parts[3]; // Cantidad
                        dataGridView1.Rows[rowIndex].Cells[4].Value = parts[4]; // Total
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al abrir el archivo: " + ex.Message);
                }
            }
        }
        
    }
}
