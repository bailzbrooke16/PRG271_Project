using PRG271_Project_DataLayer;
using PRG271_Project_DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG271_Project_Services
{
    public class ModuleService
    {
        private DataManager _datamanager;
        public ModuleService() {

            this._datamanager = new DataManager();

        }

        public List<Module> GetModules()
        {
            return this._datamanager.GetModules();
        }

        public Module GetModule(int id)
        {
            return this._datamanager.GetModule(id);
        }

        public Module CreateModule(Module module)
        {
            return this._datamanager.CreateModule(module);
        }

        public void DeleteModule(int id)
        {
            this._datamanager.DeleteModule(id);
        }

        public Module UpdateModule(int id, Module module)
        {
            return this._datamanager.UpdateModule(id,module);
        }
    }
}
