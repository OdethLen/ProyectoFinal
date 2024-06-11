using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Documents;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Wordprocessing;
using DocumentFormat.OpenXml.Packaging;
using View = System.Windows.Forms.View;
using Document = DocumentFormat.OpenXml.Wordprocessing.Document;
using Body = DocumentFormat.OpenXml.Wordprocessing.Body;
using Paragraph = DocumentFormat.OpenXml.Wordprocessing.Paragraph;
using Run = DocumentFormat.OpenXml.Wordprocessing.Run;
using Text = DocumentFormat.OpenXml.Wordprocessing.Text;
using DocumentFormat.OpenXml.Spreadsheet;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System.Xml;
using System.Diagnostics;

namespace ProyectoFinal
{
    public partial class FrmComputer : Form
    {

        public FrmComputer()
        {
            InitializeComponent();
            lstvComputerregsiter.View = View.Details;
            lstvComputerregsiter.Columns.Add("Name", 100);
            lstvComputerregsiter.Columns.Add("Last Name", 100);
            lstvComputerregsiter.Columns.Add("Computer Number", 100);
            lstvComputerregsiter.Columns.Add("Print Number", 100);
            lstvComputerregsiter.Columns.Add("Date", 100);
            lstvComputerregsiter.Columns.Add("Total");

        }

        private void FrmComputer_Load(object sender, EventArgs e)
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


            if (cboboxComputernumber.Text == "")
            {
                ErrorProvider.SetError(cboboxComputernumber, "You must enter a computer number  ");
                cboboxComputernumber.Focus();
                return;
            }
            ErrorProvider.SetError(cboboxComputernumber, "");


            if (txtPrintNumber.Text == "")
            {
                ErrorProvider.SetError(txtPrintNumber, "You must enter an number of prints ");
                txtPrintNumber.Focus();
                return;
            }
            ErrorProvider.SetError(txtPrintNumber, "");


            

            try
            {
                Computer computer = new Computer(Convert.ToString(txtName.Text), Convert.ToString(txtLastName.Text), Convert.ToDateTime(dtpDate.Text), Convert.ToUInt16(cboboxComputernumber.Text), Convert.ToInt16(txtPrintNumber.Text));
                computer.Name = txtName.Text;
                computer.Lastname = txtLastName.Text;
                computer.Computernumber = Convert.ToInt16(cboboxComputernumber.Text);
                computer.Print_number = Convert.ToInt16(txtPrintNumber.Text);
                computer.Date = Convert.ToDateTime(dtpDate.Text);

                ListViewItem item = new ListViewItem(computer.Name);
                item.SubItems.Add(computer.Lastname);
                item.SubItems.Add(computer.Computernumber.ToString());
                item.SubItems.Add(computer.Print_number.ToString());
                item.SubItems.Add(computer.Date.ToShortDateString());
                item.SubItems.Add(computer.Gettotal(computer.Cost, computer.Print_number).ToString());
                lstvComputerregsiter.Items.Add(item);
                lblTotal.Text = "TOTAL: " + Math.Round(computer.Gettotal(computer.Cost, computer.Print_number), 2).ToString();

                txtName.Clear();
                txtLastName.Clear();
                txtPrintNumber.Clear();
                dtpDate.Value = DateTime.Now;


            }
            catch (Exception)
            {
                MessageBox.Show("Enter data in a correct format");
                return;

            }

        }



        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu frm = new Menu();
            frm.Show();
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnExporttxt_Click(object sender, EventArgs e)
        {
            if (lstvComputerregsiter.Items.Count == 0)
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
                foreach (ListViewItem item in lstvComputerregsiter.Items)
                {
                    // Obtener los datos de cada fila del ListView
                    string name = item.SubItems[0].Text;
                    string lastName = item.SubItems[1].Text;
                    string computernumber = item.SubItems[2].Text;
                    string printnumber = item.SubItems[3].Text;
                    string date = item.SubItems[4].Text;
                    string total = item.SubItems[5].Text;


                    writer.WriteLine(string.Join(",", name, lastName, computernumber, printnumber, date, total));
                }
            }
            MessageBox.Show("Text file exported successfully :D");
        }

        private void btnWord_Click(object sender, EventArgs e)
        {
            if (lstvComputerregsiter.Items.Count == 0)
            {
                MessageBox.Show("There is no data to export.", "No data");
                return;
            }

            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Word Documents|*.docx";
            dialog.Title = "Save the Word File";

            if (dialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            string FilePath = dialog.FileName;
            using (WordprocessingDocument wordDocument = WordprocessingDocument.Create(FilePath, WordprocessingDocumentType.Document))
            {

                MainDocumentPart mainPart = wordDocument.AddMainDocumentPart();
                mainPart.Document = new Document();
                Body body = mainPart.Document.AppendChild(new Body());


                foreach (ListViewItem item in lstvComputerregsiter.Items)
                {
                    string name = item.SubItems[0].Text;
                    string lastName = item.SubItems[1].Text;
                    string computernumber = item.SubItems[2].Text;
                    string printnumber = item.SubItems[3].Text;
                    string date = item.SubItems[4].Text;
                    string total = item.SubItems[5].Text;

                    // Crear un nuevo párrafo para cada conjunto de datos
                    Paragraph paragraph = new Paragraph();
                    Run run = new Run();
                    run.AppendChild(new Text(" Name: " + name + lastName + " Computer Number: " + computernumber + " Print Number: " + printnumber + " Date: " + date + " Total :" + total));
                    paragraph.Append(run);


                    body.Append(paragraph);
                }


            }

            MessageBox.Show("Word file exported successfully :D");

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
            string[] lines = File.ReadAllLines(filePath);// Se lee el contenido del archivo y se almacena en un array de strings, donde cada elemento es una línea del archivo

            lstvComputerregsiter.Items.Clear();

            foreach (string line in lines)
            {
                string[] elements = line.Split(',');  // Se divide la línea en elementos utilizando la coma como separador

                ListViewItem item = new ListViewItem(elements[0]);
                for (int i = 1; i < elements.Length; i++) //Empieza por el uno por que el primer renglon corresponde a los encabezados  
                {
                    item.SubItems.Add(elements[i]);
                }

                // Agregar el ListViewItem al ListView
                lstvComputerregsiter.Items.Add(item);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstvComputerregsiter.SelectedItems.Count > 0)
            {
                foreach (ListViewItem selectedItem in lstvComputerregsiter.SelectedItems)
                {
                    lstvComputerregsiter.Items.Remove(selectedItem);
                }
            }
            else
            {
                MessageBox.Show("Please select an item to delete.");
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            if (lstvComputerregsiter.Items.Count == 0)
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
                foreach (ColumnHeader columnHeader in lstvComputerregsiter.Columns)
                {
                    Cell cell = new Cell();
                    cell.DataType = CellValues.String;
                    cell.CellValue = new CellValue(columnHeader.Text);
                    headerRow.AppendChild(cell);
                }
                sheetData.AppendChild(headerRow);

                // Writing data rows
                foreach (ListViewItem item in lstvComputerregsiter.Items)
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
        }

        private void btnXml_Click(object sender, EventArgs e)
        {

            if (lstvComputerregsiter.Items.Count == 0)
            {
                MessageBox.Show("There is no data to export.", "No data");
                return;
            }

            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Xml Document|*.xml";
            dialog.Title = "Save the xml File";

            if (dialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            string filePath = dialog.FileName;

            using (XmlWriter writer = XmlWriter.Create(filePath))
            {
                writer.WriteStartElement("Tickets");

                foreach (ListViewItem item in lstvComputerregsiter.Items)
                {
                    writer.WriteStartElement("Ticket");
                    writer.WriteElementString("LibraryName", "GREEN LIBRARY");
                    writer.WriteElementString("NumberOfCopies", item.SubItems[3].Text);
                    writer.WriteElementString("Total", item.SubItems[5].Text);
                    writer.WriteEndElement();
                }
                writer.WriteEndElement();
            }

            MessageBox.Show("XML file exported successfully :D");
           
        }






    }
}
