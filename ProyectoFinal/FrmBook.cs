using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Spreadsheet;
using System.Runtime.CompilerServices;

namespace ProyectoFinal
{
    public partial class FrmBook : Form
    {
        Book[,] bookarray;
        int BookCount;
        public FrmBook()
        {
            InitializeComponent();
            bookarray = new Book[5, 5];
            BookCount = 0;
            lstvBookregister.View = View.Details;
            lstvBookregister.Columns.Add("Name", 100);
            lstvBookregister.Columns.Add("Last Name", 100);
            lstvBookregister.Columns.Add("Title", 100);
            lstvBookregister.Columns.Add("Author", 100);
            lstvBookregister.Columns.Add("Pubisher", 100);
            lstvBookregister.Columns.Add("Date", 100);
            lstvBookregister.Columns.Add("End Date", 100);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (txtName.Text == "")
            {
                ErrorProvider.SetError(txtName, "You must enter a Name "); //.SetError muestra el icono y mensaje de error
                txtName.Focus(); //El cursor va a aparecer en este campo (Método .Focus)
                return;
            }
            ErrorProvider.SetError(txtName, ""); //Limpia el mensaje de error

            if (txtLastName.Text == "")
            {
                ErrorProvider.SetError(txtLastName, "You must enter a Last Name ");
                txtLastName.Focus();
                return;
            }
            ErrorProvider.SetError(txtLastName, "");


            if (txtTitle.Text == "")
            {
                ErrorProvider.SetError(txtTitle, "You must enter a Title ");
                txtTitle.Focus();
                return;
            }
            ErrorProvider.SetError(txtTitle, "");


            if (txtAuthor.Text == "")
            {
                ErrorProvider.SetError(txtAuthor, "You must enter an Author ");
                txtAuthor.Focus();
                return;
            }
            ErrorProvider.SetError(txtAuthor, "");

            if (txtPublisher.Text == "")
            {
                ErrorProvider.SetError(txtPublisher, "You must enter a Publisher ");
                txtPublisher.Focus();
                return;
            }
            ErrorProvider.SetError(txtPublisher, "");


            if (dtpEndDate.Value < dtpDate.Value)
            {
                MessageBox.Show("Invalid date. ");
                dtpDate.Value = DateTime.Now;
                return;
            }

            Book book = new Book();
            book.Name = txtName.Text;
            book.Lastname = txtLastName.Text;
            book.Title = txtTitle.Text;
            book.Author = txtAuthor.Text;
            book.Publisher = txtPublisher.Text;//
            book.Date = Convert.ToDateTime(dtpDate.Text);
            book.Enddate = Convert.ToDateTime(dtpEndDate.Text);

            bookarray[BookCount, 0] = book; // BookCount representa el índice de la fila y 0 representa el índice de la columna


            BookCount++;
            if (BookCount == bookarray.GetLength(0))
            {
                MessageBox.Show("Full Arrangement");
            }


            // Después de asignar el objeto Book a la matriz, puedes agregar los detalles del libro a lstvBookregister
            ListViewItem item = new ListViewItem(book.Name);
            item.SubItems.Add(book.Lastname);
            item.SubItems.Add(book.Title);
            item.SubItems.Add(book.Author);
            item.SubItems.Add(book.Publisher);
            item.SubItems.Add(book.Date.ToShortDateString());
            item.SubItems.Add(book.Enddate.ToShortDateString());
            lstvBookregister.Items.Add(item);


            txtName.Clear();
            txtLastName.Clear();
            txtTitle.Clear();
            txtAuthor.Clear();
            txtPublisher.Clear();
            dtpDate.Value = DateTime.Now;
            dtpEndDate.Value = DateTime.Now;
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnExporttxt_Click(object sender, EventArgs e)
        {
            Exporttxt();
        }


        private void Exporttxt()
        {
            if (lstvBookregister.Items.Count == 0)
            {
                MessageBox.Show("There is no data to export.", "No data");
                return;
            }

            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "txt files |*.txt";
            dialog.Title = "Save the Text File";
            if (dialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            string filepath = dialog.FileName;
            using (StreamWriter writer = new StreamWriter(filepath))
            {
                foreach (ListViewItem item in lstvBookregister.Items)
                {
                    // Obtener los datos de cada fila del ListView
                    string name = item.SubItems[0].Text;
                    string lastName = item.SubItems[1].Text;
                    string title = item.SubItems[2].Text;
                    string author = item.SubItems[3].Text;
                    string publisher = item.SubItems[4].Text;
                    string date = item.SubItems[5].Text;
                    string endDate = item.SubItems[6].Text;

                    writer.WriteLine(string.Join(",", name, lastName, title, author, publisher, date, endDate));
                }
            }
            MessageBox.Show("Text file exported successfully :D");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu frm = new Menu();
            frm.Show();
            this.Hide();
        }

        private void btnOpentxt_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "txt files |*.txt";
            dialog.Title = "Open the Text File";
            if (dialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            string filePath = dialog.FileName;
            string[] lines = File.ReadAllLines(filePath);
            lstvBookregister.Items.Clear();
            foreach (string line in lines)
            {
                string[] elements = line.Split(','); //Divide los elementos de la linea con el uso de la coma para notar la diferencia 


                ListViewItem item = new ListViewItem(elements[0]);
                for (int i = 1; i < elements.Length; i++)
                {
                    item.SubItems.Add(elements[i]);
                }

                // Agregar el ListViewItem al ListView
                lstvBookregister.Items.Add(item);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnWord_Click(object sender, EventArgs e)
        {

        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            if (lstvBookregister.Items.Count == 0)
            {
                MessageBox.Show("There is no data to export.", "No data");
                return;
            }

            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel files |*.xlsx";
            dialog.Title = "Save the excel file";
            if (dialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            string filePath = dialog.FileName;

            using (SpreadsheetDocument spreadsheetDocument = SpreadsheetDocument.Create(filePath, SpreadsheetDocumentType.Workbook))
            {
                WorkbookPart workbookPart = spreadsheetDocument.AddWorkbookPart();
                workbookPart.Workbook = new Workbook();

                WorksheetPart worksheetPart = workbookPart.AddNewPart<WorksheetPart>();
                SheetData sheetData = new SheetData();
                worksheetPart.Worksheet = new Worksheet(sheetData);

                Sheets sheets = spreadsheetDocument.WorkbookPart.Workbook.AppendChild(new Sheets());

                Sheet sheet = new Sheet() { Id = spreadsheetDocument.WorkbookPart.GetIdOfPart(worksheetPart), SheetId = 1, Name = "Sheet1" };
                sheets.Append(sheet);

                // Writing column headers
                Row headerRow = new Row();
                foreach (ColumnHeader columnHeader in lstvBookregister.Columns)
                {
                    Cell cell = new Cell();
                    cell.DataType = CellValues.String;
                    cell.CellValue = new CellValue(columnHeader.Text);
                    headerRow.AppendChild(cell);
                }
                sheetData.AppendChild(headerRow);

                // Writing data rows
                foreach (ListViewItem item in lstvBookregister.Items)
                {
                    Row dataRow = new Row();
                    foreach (ListViewItem.ListViewSubItem subItem in item.SubItems)
                    {
                        Cell cell = new Cell();
                        cell.DataType = CellValues.String;
                        cell.CellValue = new CellValue(subItem.Text);
                        dataRow.AppendChild(cell);
                    }
                    sheetData.AppendChild(dataRow);
                }
            }

            MessageBox.Show("Excel file saved successfully  :D");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstvBookregister.SelectedItems.Count > 0)
            {
                foreach (ListViewItem selectedItem in lstvBookregister.SelectedItems)
                {
                    lstvBookregister.Items.Remove(selectedItem);
                }
            }
            else
            {
                MessageBox.Show("Please select an item to delete.");

            }
           

            
        }
    }
}
