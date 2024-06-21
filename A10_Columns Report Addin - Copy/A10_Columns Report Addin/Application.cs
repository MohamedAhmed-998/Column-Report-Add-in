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
using System.Windows.Media.Imaging;
using System.Drawing;
using System.Xml.Linq;
using System.Reflection;

namespace generalsolution
{
   
        public class Application : IExternalApplication
        {
            public Result OnStartup(UIControlledApplication application)
            {
            application.CreateRibbonTab("KAITECH-BD-R06");
            var panel = application.CreateRibbonPanel("KAITECH-BD-R06","Structure");
            var pushdata = new PushButtonData("fth-addin", "Columns Report", Assembly.GetExecutingAssembly().Location, "generalsolution.revit_addin");
            var bitimage = new BitmapImage(new Uri("pack://application:,,,/generalsolution;component/download-icon-microsoft+excel-1331135715061110002_32.ico"));
            pushdata.LargeImage = bitimage;
            panel.AddItem(pushdata);          
            return Result.Succeeded;
            }
            public Result OnShutdown(UIControlledApplication application)
            {
                return Result.Succeeded;
                
            }

           
        
    }
}
