using CRUDAppProject.CS.Base;
using CRUDAppProject.CS.Interfaces;
using CRUDAppProject.Forms.Logged_in_forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CRUDAppProject.CS.Tasks
{
    /// <summary>
    /// Klasa dziedzicząca po klasie abstrakcyjnej Base_Task - określa zadania z kategorii Ćwiczenia
    /// </summary>

    internal class Task_Exercise : Base_Task, ITaskCRUD, ISerialize
    {
        /// <summary>
        /// Określa źródło zadania, np konkretne ćwiczenia z określonego przedziału stron w podręczniku
        /// </summary>

        private string _taskSource;
        public string TaskSource
        {
            get { return this._taskSource; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value) && !string.IsNullOrEmpty(value))
                {
                    value = value.Trim();
                    this._taskSource = value;
                }

                else
                    throw new ArgumentException("Źródło zadania nie może być puste!", "ExerciseSourceNullOrEmpty");

            }
        }

        public override void TaskCreator()
        {
            Form_CreateExercise Screen_ExerciseCreator = new Form_CreateExercise();
            Screen_ExerciseCreator.Show();          
        }

        public override void TaskDisplayer()
        {

        }

        public override void TaskEditor()
        {

        }

        public override void TaskRemover()
        {

        }

        public void CreateTask(Base_Task task)
        {
            if (task is Task_Exercise exerciseTask)
            {
                exerciseTask.SaveDataToFile();
                MessageBox.Show("Zadanie zostało stworzone i zapisane pomyślnie.", "Tworzenie zadania", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }

            else
                throw new ArgumentException("FATAL: konflikt typów zadań", "FATALTaskTypeConflict");
            
        }

        public void DisplayTask(Base_Task task)
        {
            
        }

        public void EditTask(Base_Task task)
        {

        }

        public void RemoveTask(Base_Task task)
        {

        }

        public void SaveDataToFile()
        {
            var profile = new
            {
                title = this.Title,
                description = this.Description,
                chosenSubject = this.ChosenSubject,
                dateOfCreation = this.DateOfCreation,
                deadline = this.Deadline,
                status = this.Status,
                isCompleted = this.IsCompleted
            };

            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            };
                        
            string jsonString = JsonSerializer.Serialize(profile, options);
            File.AppendAllText(Base_AppState.ChosenProfileFilePath, jsonString);
            Console.WriteLine(jsonString);           
        }

        public void LoadDataFromFile()
        {

        }

    }
}
