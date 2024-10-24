using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patient_and_Doctor_Management_System.Settings
{
    internal class AppSettings
    {
        public const string dataSource = @"(localDB\MSSQLLocalDB)";
        public const string ConnectionString = @"Data Source=" + dataSource + ";Initial Catalog=Doctor_and_Patient_Management_System;Integrated Security=true";

        //public const string ConnectionString = "Server=.;Database=Doctor_and_Patient_Management_System;Integrated Security=true";
    }
}
