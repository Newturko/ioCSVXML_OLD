# ioCSVXML
### ioCSVXML is a xml-csv import and exporter API for c# Projects

## Introduction
A simple .Net API written in C# for import csv or xml format and export them. The data types are based on the templates of the schema files.

## Basic Samples For Stages
### Stage 1 - Definind Filters and Sort Parameters
...
            List<FilterValue> Filters = new List<FilterValue>();
            List<SortParameter> Sorts = new List<SortParameter>();
            
            Filters.Add(new FilterValue() { FieldName = "CityName", FieldParameter = "Antalya" });
            Filters.Add(new FilterValue() { FieldName = "CityName", FieldParameter = "İzmir" });
            Filters.Add(new FilterValue() { FieldName = "CityName", FieldParameter = "Ankara" });
            Sorts.Add(new SortParameter() { FieldName = "CityName", isAscending = true });
...

### Stage 2 - Import And Export
#### Option 1 - Import Csv file and export to XML with Filtered and Sorted Values
Note: XML data type are based on the templates of the schema files.
...
            CSVtoXMLAdvanced(InputFileName, OutPutFileName, Filters, Sorts);
...

#### Option 2 - Import Csv file and export to CSV with Filtered and Sorted Values
Note: CSV data type are based on the templates of the schema files.
...
            CSVtoCSVAdvanced(InputFileName, OutPutFileName, Filters, Sorts);
...

#### Option 3 - Import XML file and export to CSV with Filtered and Sorted Values
Note: CSV data type are based on the templates of the schema files.
...
            XMLtoCSVAdvanced(InputFileName, OutPutFileName, Filters, Sorts);
...
            
#Any assumptions and reasoning behind my API design
Api designed for importing and exporting two data format. But
