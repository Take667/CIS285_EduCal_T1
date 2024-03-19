using Magnum.FileSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace EduCaldraft2
{
    internal class File
    {


/// Save to the application's directory


        public string FileName { get; set; }
        public string FileExtension { get; set; }
        = string.Empty;
        public File() { }

        public static void SaveToFile(SaveFileDialog saveFileDialog) { }

        string fileName = $"Calendar_{year}.txt";
        private static object year;
        private static object month;
        private static object day;


        
    }
}


    









