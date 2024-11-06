using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Notepad_Application.Repositories;

namespace Notepad_Application
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var user = new UserManager();

            user.InitiateRepository();
            user.DisplayOptions();
        }
    }
}
