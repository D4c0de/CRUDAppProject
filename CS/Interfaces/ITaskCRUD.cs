using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDAppProject.CS.Interfaces
{
    interface ITaskCRUD
    {
        void CreateTask(object t);

        void DisplayTask(object t);

        void EditTask(object t);

        void RemoveTask(object t);
        
    }
}
