using CRUDAppProject.CS.Base;
using CRUDAppProject.CS.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CRUDAppProject.CS.Managers
{
    /// <summary>
    /// Klasa finalna _Task_Manager_ - służy do zarządzania zadaniami z różnych kategorii
    /// </summary>

    internal sealed class _Task_Manager_
    {
        /// <summary>
        /// Wyświetlanie zadań w postaci kafelków na panelu Panel_TaskCardsPanel pionowo jeden po drugim
        /// </summary>
        /// <param name="Panel_TaskCardsPanel">Panel na którym mają zostać wyświetlone kafelki - właściwie jest to panel Panel_TaskCardsPanel w formie LoggedIn</param>

        static public void DisplayTasksOnLoggedInScreen(Panel Panel_TaskCardsPanel)
        {
            Base_AppState.CardCount = 0;

            string json = File.ReadAllText(Base_AppState.ChosenProfileFilePath);

            var options = new JsonSerializerOptions
            {
                Converters = { new TaskConverter() },
                PropertyNameCaseInsensitive = true
            };

            var document = JsonSerializer.Deserialize<RootObject>(json, options);

            foreach (var task in document.Tasks)
            {
                task.ShowTaskCard(Panel_TaskCardsPanel);
            }
        }
    }
}
