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
            
# Any assumptions and reasoning behind my API design
## Assumptions
Api designed for importing and exporting two data format. However, it is based on List Logic and Linq Methods. Easy to use with specific data format.

## Reasoning
This design is home work and its limited with data shema structer. I think company change home work logic. This scheme limits the programmer. An import and export module without limited data shema can be writen.


# Which Library Used
- System.IO -> For read and save files.
- System.Linq -> For filtering and sorting.
- System.Xml.Serialization - For working XML nodes and files.
- Microsoft.VisualStudio.TestTools.UnitTesting  -> For Unit Test


# Opinions
## Posible performance 
This design for only specific data model and samples for ZipCode on Turkey Citys. I used linq functions for filterind and sorting. We cant work with big data with that logic. If we want to work big data, then we can design a specific data model and filtering functions.

