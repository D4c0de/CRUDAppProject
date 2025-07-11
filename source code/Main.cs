﻿using CRUDAppProject.CS.Base;
using CRUDAppProject.CS.Side;
using CRUDAppProject.CS.Tasks;
using CRUDAppProject.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CRUDAppProject
{
    /// <summary>
    /// Klasa główna aplikacji
    /// </summary>

    class CRUDAppProject
    {
        [STAThread]
        static void Main(string[] args)
        {            
            Form_Logging screenLogging = new Form_Logging();
            screenLogging.Show();

            Application.Run();                 
        }
    }
}
