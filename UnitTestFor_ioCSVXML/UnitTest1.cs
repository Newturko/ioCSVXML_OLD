using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using ioCSVXML.HelperModels;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static ioCSVXML.LoadAndExport;

namespace UnitTestFor_ioCSVXML
{
    [TestClass]
    public class UnitTest1
    {
        static string test_path = Directory.GetCurrentDirectory() + "..\\..";
        static string csv_sample_input_data = test_path + "\\" + "sample_data.csv";
        static string xml_sample_input_data = test_path + "\\" + "sample_data.xml";
        static string TestCase1Data = test_path + "\\" + "TestCase1.xml";
        static string TestCase2Data = test_path + "\\" + "TestCase2.csv";
        static string TestCase3Data = test_path + "\\" + "TestCase3.csv";
        [TestMethod]
        public void TestCase1() // Generate XML output from CSV input, filtered by City name=’Antalya’ 
        {
            List<FilterValue> Filters = new List<FilterValue>();
            List<SortParameter> Sorts = new List<SortParameter>();
            Filters.Add(new FilterValue() { FieldName = "CityName", FieldParameter = "Antalya" });
            CSVtoXMLAdvanced(csv_sample_input_data, TestCase1Data, Filters, Sorts);
        }
        [TestMethod]
        public void TestCase2() // Generate CSV output from CSV input, sorted by City name ascending, then District name ascending 
        {
            List<FilterValue> Filters = new List<FilterValue>();
            List<SortParameter> Sorts = new List<SortParameter>();
            Sorts.Add(new SortParameter() { FieldName = "CityName", isAscending = true });
            Sorts.Add(new SortParameter() { FieldName = "DistrictName", isAscending = true });
            CSVtoCSVAdvanced(csv_sample_input_data, TestCase2Data, Filters, Sorts);
        }
        [TestMethod]
        public void TestCase3() // Generate CSV output from XML input, filtered by City name=’Ankara’ and sorted by Zip code descending
        {
            List<FilterValue> Filters = new List<FilterValue>();
            List<SortParameter> Sorts = new List<SortParameter>();
            Filters.Add(new FilterValue() { FieldName = "CityName", FieldParameter = "Ankara" });
            Sorts.Add(new SortParameter() { FieldName = "ZipCode", isAscending = false });
            XMLtoCSVAdvanced(xml_sample_input_data, TestCase3Data, Filters, Sorts);
        }
    }
}
