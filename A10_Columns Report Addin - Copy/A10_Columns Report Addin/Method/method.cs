using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using generalsolution.Addin;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generalsolution
{
    public class method
    {
        private Document doc;
        public method(Document document)
        {
           doc= document;
        }
        public void Showdialogbox(IEnumerable list)
        {
            dialogbox box = new dialogbox(list);
            box.ShowDialog();

        }
        public void showtask(string name)
        {
        }


    }
}
