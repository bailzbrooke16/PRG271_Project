using PRG271_Project_DataLayer;
using PRG271_Project_DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PRG271_Project_Services
{
    
    public class LinkingService
    {
        private DataManager _dataManager;
        public LinkingService()
        {
            _dataManager = new DataManager();
        }

        public List<Module> GetActiveModules(int? studentID)
        {
            List<Module> modules = this._dataManager.GetModules();
            List<Link> links = this._dataManager.GetLinks();
            List<Link> studentsModules = links.Where(x => x.StudentID == studentID).ToList();
            List<Module> finalList = new List<Module>();

            foreach (Module module in modules)
            {
                if (studentsModules.FirstOrDefault(x => x.ModuleID == module.Code) != null)
                {
                    finalList.Add(module);
                }
            }
            return finalList;
        }

        public List<Module> GetUnActiveModules(int? studentID)
        {
            List<Module> modules = this._dataManager.GetModules();
            List<Link> links = this._dataManager.GetLinks();
            List<Link> studentsModules = links.Where(x => x.StudentID == studentID).ToList();
            List<Module> finalList = new List<Module>();

            foreach (Module module in modules)
            {
                if(studentsModules.FirstOrDefault(x => x.ModuleID == module.Code) == null)
                {
                    finalList.Add(module);
                }
            }
            return finalList;

        }

        public void AddModuleLink(int? StudentID , int? ModuleID)
        {
            this._dataManager.CreateLink(StudentID, ModuleID);
        }

        public void RemoveModuleLink(int? StudentID , int? ModuleID)
        {
            this._dataManager.DeleteLink(StudentID, ModuleID); 
        }
    }
}
