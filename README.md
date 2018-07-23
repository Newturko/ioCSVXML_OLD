# ioCSVXML
###ioCSVXML is a xml-csv import and exporter API for c# Projects

##Introduction
A simple .Net API written in C# for import csv or xml format and export them. The data types are based on the templates of the schema files.

##Basic Usage Samples
###Test Case 1
...
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
...

