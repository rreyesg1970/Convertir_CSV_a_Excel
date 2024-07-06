using System.Data;
using System.Diagnostics;
using ClosedXML.Excel;

namespace Convertir_CSV_a_Excel
{
    public partial class Form1 : Form
    {
        private string archivoCSV;
        private string directorioCSV;
        private string rutaCompletaCSV;

        private string archivoExcel;
        private string directorioExcel;
        private string rutaCompletaExcel;

        DataTable dataTable;

        public Form1()
        {
            InitializeComponent();
        }


        #region Eventos
        private void BtnAbrirCSV_Click(object sender, EventArgs e)
        {
            AbrirArchivoCSV();
        }

        private void BtnConvertirExcel_Click(object sender, EventArgs e)
        {
            // Lee el archivo CSV y carga los datos en un DataTable
            dataTable = CargarCsvEnDataTable(rutaCompletaCSV);

            CrearArchivoExcel();
        }

        private void BtnMostarArchivo_Click(object sender, EventArgs e)
        {
            MostrarCarpetaArchivos();
        }

        private void BtnLimpiarDatos_Click(object sender, EventArgs e)
        {
            LimpiarDatos();
        }
        #endregion Eventos






        #region Métodos

        private void AbrirArchivoCSV()
        {
            if (Ofd.ShowDialog() == DialogResult.OK)
            {
                rutaCompletaCSV = Ofd.FileName;
                TxtRutaCSV.Text = rutaCompletaCSV;
                archivoCSV = Ofd.SafeFileName;
                archivoCSV = Path.GetFileNameWithoutExtension(archivoCSV);
                directorioCSV = Path.GetDirectoryName(rutaCompletaCSV);

                archivoExcel = archivoCSV + ".xlsx";
                directorioExcel = directorioCSV;
                rutaCompletaExcel = Path.Combine(directorioExcel, archivoExcel);
            }
        }


        private DataTable CargarCsvEnDataTable(string rutaCSV)
        {
            var dataTable = new DataTable();

            using (var reader = new StreamReader(rutaCSV))
            {
                string[] headers = reader.ReadLine().Split(';');

                foreach (string header in headers)
                {
                    dataTable.Columns.Add(header);
                }
                dataTable.Columns.Add();

                while (!reader.EndOfStream)
                {
                    string[] fields = reader.ReadLine().Split(';');
                    dataTable.Rows.Add(fields);
                }
            }
            return dataTable;
        }

        private void CrearArchivoExcel()
        {
            // Crea un nuevo archivo de Excel y añade el DataTable
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add(dataTable, "Hoja1");

                // Cambia el tipo de datos de una columna específica a texto
                CambiarTipoColumnaATexto(worksheet, 18); // Aquí se asume que la columna 1 es la que deseas cambiar

                DgvExcel.DataSource = dataTable;

                workbook.SaveAs(rutaCompletaExcel);
            }
        }


        private void CambiarTipoColumnaATexto(IXLWorksheet worksheet, int columnNumber)
        {
            // Establece el formato de la columna como texto
            var column = worksheet.Column(columnNumber);
            column.Style.NumberFormat.Format = "@";

            // Convierte cada celda de la columna a texto explícitamente
            foreach (var cell in column.CellsUsed())
            {
                cell.Value = cell.GetString();
            }
        }

        private void MostrarCarpetaArchivos()
        {
            Process.Start(new ProcessStartInfo()
            {
                FileName = rutaCompletaExcel,
                UseShellExecute = true,
                Verb = "open"
            });
        }


        private void LimpiarDatos()
        {
            archivoCSV = string.Empty;
            directorioCSV = string.Empty;
            rutaCompletaCSV = string.Empty;
            archivoExcel = string.Empty;
            directorioExcel = string.Empty; ;
            rutaCompletaExcel = string.Empty;

            DgvExcel.DataSource = null;
        }
        #endregion Métodos


       
    }
}
