using CRUDAppProject.CS.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDAppProject.CS.Interfaces
{
    interface ITaskCRUD
    {
        void CreateTask(Base_Task task);

        void DisplayTask(Base_Task task);

        void EditTask(Base_Task task);

        void RemoveTask(Base_Task task);
        
    }
}
