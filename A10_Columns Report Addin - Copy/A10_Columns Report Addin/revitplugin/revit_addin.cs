using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.ApplicationServices;
using System.Runtime.Remoting.Messaging;
using System.Diagnostics.CodeAnalysis;
using Autodesk.Revit.DB.Visual;
using Autodesk.Revit.DB.Plumbing;
using System.Windows.Shapes;
using Line = Autodesk.Revit.DB.Line;
using Autodesk.Revit.DB.Structure.StructuralSections;
using System.Security.Cryptography;
using Autodesk.Revit.DB.Structure;
using Autodesk.Revit.DB.Mechanical;
using System.Windows.Documents;
using System.Windows.Controls;
using Grid = Autodesk.Revit.DB.Grid;
using System.Security.AccessControl;
using OfficeOpenXml;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace generalsolution
{


    [Transaction(TransactionMode.Manual)]
    public class revit_addin : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            #region generalmethod
            UIApplication uiapp = commandData.Application;
            Autodesk.Revit.ApplicationServices.Application app = commandData.Application.Application;
            UIDocument uidoc = commandData.Application.ActiveUIDocument;
            Document doc = commandData.Application.ActiveUIDocument.Document;
            method m = new method(doc);

            #endregion

            TransactionGroup tg = new TransactionGroup(doc, "tg");
            tg.Start();
            columns_report colr = new columns_report(doc, uidoc, m);
            colr.ShowDialog();
            tg.Assimilate();
            return Result.Succeeded;

        }

    }
        }
    


      

