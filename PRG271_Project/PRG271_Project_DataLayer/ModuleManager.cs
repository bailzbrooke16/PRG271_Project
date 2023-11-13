using PRG271_Project_DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG271_Project_DataLayer
{
    public class ModuleManager
    {
        private string _connectionString;
        public ModuleManager(string connectionString) {
            this._connectionString = connectionString;
        }

        public List<Module> GetModules()
        {
            return new List<Module>();
        }

        public Module GetModule(int id)
        {
            return null;
        }

        public Module CreateModule(Module module)
        {
            return null;
        }

        public void DeleteModule(int id)
        {

        }

        public Module UpdateModule(int id, Module module)
        {
            return null;
        }
    }
}
