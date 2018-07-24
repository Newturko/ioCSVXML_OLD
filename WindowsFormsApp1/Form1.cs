using ioCSVXML.HelperModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using static ioCSVXML.LoadAndExport;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OpenFileDialog SourceDialog = new OpenFileDialog();
        SaveFileDialog DestinationDialog = new SaveFileDialog();

        private void Form1_Load(object sender, EventArgs e)
        {
            Console.WriteLine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SourceDialog.Filter = "Csv files (With Comma) (*.csv)|*.csv";
            SourceDialog.Title = "Select an appropriate csv for testing...";
            DestinationDialog.Filter = "XML file (*.xml)|*.xml";
            DestinationDialog.Title = "Please set destination XML filename...";

            SourceDialog.ShowDialog();
            string InputFileName = SourceDialog.FileName;

            DestinationDialog.ShowDialog();
            string OutPutFileName = DestinationDialog.FileName;

            List<FilterValue> Filters = new List<FilterValue>();
            List<SortParameter> Sorts = new List<SortParameter>();
            Filters.Add(new FilterValue() { FieldName = "CityName", FieldParameter = "Antalya" });

            CSVtoXMLAdvanced(InputFileName, OutPutFileName, Filters, Sorts);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SourceDialog.Filter = "Csv files (With Comma) (*.csv)|*.csv";
            SourceDialog.Title = "Select an appropriate CSV for testing...";
            DestinationDialog.Filter = "Csv files (With Comma) (*.csv)|*.csv";
            DestinationDialog.Title = "Please set destination CSV filename...";

            SourceDialog.ShowDialog();
            string InputFileName = SourceDialog.FileName;

            DestinationDialog.ShowDialog();
            string OutPutFileName = DestinationDialog.FileName;

            List<FilterValue> Filters = new List<FilterValue>();
            List<SortParameter> Sorts = new List<SortParameter>();
            Sorts.Add(new SortParameter() { FieldName = "CityName", isAscending = true });
            Sorts.Add(new SortParameter() { FieldName = "DistrictName", isAscending = true });
            CSVtoCSVAdvanced(InputFileName, OutPutFileName, Filters, Sorts);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SourceDialog.Filter = "XML file (*.xml)|*.xml";
            SourceDialog.Title = "Select an appropriate XML file for testing...";
            DestinationDialog.Filter = "Csv files (With Comma) (*.csv)|*.csv";
            DestinationDialog.Title = "Please set destination CSV filename...";

            SourceDialog.ShowDialog();
            string InputFileName = SourceDialog.FileName;

            DestinationDialog.ShowDialog();
            string OutPutFileName = DestinationDialog.FileName;

            List<FilterValue> Filters = new List<FilterValue>();
            List<SortParameter> Sorts = new List<SortParameter>();
            Filters.Add(new FilterValue() { FieldName = "CityName", FieldParameter = "Ankara" });
            Sorts.Add(new SortParameter() { FieldName = "ZipCode", isAscending = false });
            XMLtoCSVAdvanced(InputFileName, OutPutFileName, Filters, Sorts);
        }
    }
}
