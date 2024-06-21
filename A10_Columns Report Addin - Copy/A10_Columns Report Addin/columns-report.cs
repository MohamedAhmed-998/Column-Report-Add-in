using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.ApplicationServices;
using OfficeOpenXml;
using System.IO;
using Autodesk.Revit.DB.Structure;
using Autodesk.Revit.DB.Mechanical;
using System.Windows.Documents;
using System.Text.Json.Serialization;
using System.Windows.Controls;
using System.Windows.Media;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Engineering;

namespace generalsolution
{

    public partial class columns_report : System.Windows.Forms.Form
    {
        #region private parameters
        Document doc;
        UIDocument uidoc;
        method m;
       public ExcelPackage excelPackage_form;
        public ExcelWorksheet worksheet_form ;


        #endregion
        public columns_report(Document doucment, UIDocument uidoucment, method gm)
        {
            InitializeComponent();
            doc = doucment;
            uidoc = uidoucment;
            m = gm;
        }
        public void Browsing_Click(object sender, EventArgs e)
        {
            var x = folderBrowserDialog1.ShowDialog();
            textBox1.Text = folderBrowserDialog1.SelectedPath.ToString();
        }
        public void exporting_Click(object sender, EventArgs e)
        {
            using (ExcelPackage excelPackage = new ExcelPackage())
            {

                excelPackage.Workbook.Properties.Author = "VDWWD";
                excelPackage.Workbook.Properties.Title = "Title of Document";
                excelPackage.Workbook.Properties.Subject = "EPPlus demo export data";
                excelPackage.Workbook.Properties.Created = DateTime.Now;

                //data 
                //var elems = new Element().GetElements();
                var columns = new FilteredElementCollector(doc).OfClass(typeof(FamilyInstance)).Where(p => p.Category.Name == "Structural Columns").Select(q => q as FamilyInstance).ToList();
                //Create the WorkSheet
                ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Sheet 1");

                //You could also use [line, column] notation:
                worksheet.Cells[1, 1].Value = "Family";
                worksheet.Cells[1, 2].Value = "Type";
                worksheet.Cells[1, 3].Value = "ID";
                worksheet.Cells[1, 4].Value = "Easting (m)";
                worksheet.Cells[1, 5].Value = "Northing (m)";
                worksheet.Cells[1, 6].Value = "Base Level";
                worksheet.Cells[1, 7].Value = "Base Offset (m)";
                worksheet.Cells[1, 8].Value = "Top Level";
                worksheet.Cells[1, 9].Value = "Top Offset (m)";
                worksheet.Cells[1, 10].Value = "Height (m)";
                worksheet.Cells[1, 11].Value = "Volume (m^3)";
                Transaction t1 = new Transaction(doc, "t1");
                {
                    var vb = columns.Select(p => ((p.Symbol) as FamilySymbol).FamilyName);
                    t1.Start();
                    int countrow = 2;
                    int y = 0;
                    foreach (var ele in columns)
                    {
                        for (int i = 0; i <= 11; i++)
                        {
                            if (i == 0)
                            {
                                worksheet.Cells[countrow, i + 1].Value = ((ele.Symbol) as FamilySymbol).FamilyName;
                            }
                            if (i == 1)
                            {
                                worksheet.Cells[countrow, i + 1].Value = (ele.Name);
                            }
                            if (i == 2)
                            {
                                worksheet.Cells[countrow, i + 1].Value = (ele.Id);
                            }
                            if (i == 3)
                            {
                                var location = ele.Location;
                                var easting = (location as LocationPoint).Point.X;
                                worksheet.Cells[countrow, i + 1].Value = (UnitUtils.ConvertFromInternalUnits(easting, DisplayUnitType.DUT_METERS));
                            }
                            if (i == 4)
                            {
                                var location = ele.Location;
                                var northing = (location as LocationPoint).Point.Y;
                                worksheet.Cells[countrow, i + 1].Value = (UnitUtils.ConvertFromInternalUnits(northing, DisplayUnitType.DUT_METERS));
                            }
                            if (i == 5)
                            {
                                var yy = ele.ParametersMap.get_Item("Base Level").AsValueString();
                                worksheet.Cells[countrow, i + 1].Value = (yy);
                            }
                            if (i == 6)
                            {
                                var xx = ele.ParametersMap.get_Item("Base Offset").AsDouble();
                                worksheet.Cells[countrow, i + 1].Value = (xx);
                            }
                            if (i == 7)
                            {
                                var yy1 = ele.ParametersMap.get_Item("Top Level").AsValueString();
                                worksheet.Cells[countrow, i + 1].Value = (yy1);
                            }
                            if (i == 8)
                            {
                                var xx1 = ele.ParametersMap.get_Item("Top Offset").AsDouble();
                                worksheet.Cells[countrow, i + 1].Value = (xx1);
                            }
                            if (i == 9)
                            {
                                worksheet.Cells[countrow, i + 1].Value = (ele.Name);

                            }
                            if (i == 10)
                            {
                                var vol = ele.ParametersMap.get_Item("Volume").AsDouble();
                                worksheet.Cells[countrow, i + 1].Value = (UnitUtils.ConvertFromInternalUnits(vol, DisplayUnitType.DUT_CUBIC_METERS));
                            }
                            worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();
                            worksheet.Cells[worksheet.Dimension.Address].EntireRow.Height = 20;
                        }
                        countrow++;
                    }
                    Transaction tfile = new Transaction(doc, "tfile");
                    {
                        //Save your file
                        var rvtname = doc.Title;
                        var dat = DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss XM");
                        string path = folderBrowserDialog1.SelectedPath.ToString();
                        var filename = $"{rvtname}-Columns Report [{dat}].xlsx";
                        string newpath = System.IO.Path.Combine(path, filename);
                        FileInfo fil = new FileInfo(newpath);
                        if (exporting != null)
                        {
                            //if (colr.exporting.Click() != null)
                            //{

                            //}
                            excelPackage.SaveAs(fil);
                            System.Diagnostics.Process.Start(newpath);
                            //fil.Open(FileMode.OpenOrCreate);

                        }
                    }

                    t1.Commit();
                }
            }
        }

        private void closing_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var link = "www.linkedin.com/in/mohamed-ahmed-fathy-beblawy-6485a2133\r\n\r\n";
            System.Diagnostics.Process.Start(link);
        }

        private void columns_report_Load(object sender, EventArgs e)
        {

        }
    }
}
