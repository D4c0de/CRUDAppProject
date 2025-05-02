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
        public void Test2()
        {
            Console.WriteLine("to jest test dla klasy Exercise");
        }

        public void SaveDataToFile()
        {
            string filePath = Base_AppState.ChosenProfileFilePath;

            if (!File.Exists(filePath))
                throw new FileNotFoundException("Plik profilu nie istnieje.", filePath);

            string jsonString = File.ReadAllText(filePath);
            var jsonDoc = JsonDocument.Parse(jsonString);
            var root = jsonDoc.RootElement.Clone();

            List<JsonElement> tasks = new List<JsonElement>();
            if (root.TryGetProperty("tasks", out JsonElement existingTasks) && existingTasks.ValueKind == JsonValueKind.Array)
                tasks.AddRange(existingTasks.EnumerateArray());

            var taskObj = new
            {
                taskType = this.GetType().Name,
                title = this.Title,
                shortDescription = this.ShortDescription,
                description = this.Description,
                taskSource = this.TaskSource,
                chosenSubject = this.ChosenSubject,
                dateOfCreation = this.DateOfCreation,
                deadline = this.Deadline,
                status = this.Status,
                isCompleted = this.IsCompleted
            };

            string taskJson = JsonSerializer.Serialize(taskObj);
            tasks.Add(JsonDocument.Parse(taskJson).RootElement);

            var updatedProfile = new Dictionary<string, object>();

            foreach (var prop in root.EnumerateObject())
            {
                if (prop.Name != "tasks")
                    updatedProfile[prop.Name] = JsonSerializer.Deserialize<object>(prop.Value.GetRawText());
            }

            updatedProfile["tasks"] = tasks;

            var options = new JsonSerializerOptions { WriteIndented = true };
            string updatedJson = JsonSerializer.Serialize(updatedProfile, options);
            File.WriteAllText(filePath, updatedJson);
        }

        public void LoadDataFromFile()
        {

            if (!File.Exists(Base_AppState.ChosenProfileFilePath))
                throw new FileNotFoundException("Plik profilu nie istnieje.", Base_AppState.ChosenProfileFilePath);

            string jsonString = File.ReadAllText(Base_AppState.ChosenProfileFilePath);
            var jsonDoc = JsonDocument.Parse(jsonString);
            var root = jsonDoc.RootElement;

            if (!root.TryGetProperty("tasks", out JsonElement tasksElement) || tasksElement.ValueKind != JsonValueKind.Array)
                throw new JsonException("Brak listy zadań w pliku profilu.");

            foreach (JsonElement task in tasksElement.EnumerateArray())
            {
                if (task.TryGetProperty("title", out JsonElement title))
                {
                    Console.WriteLine($"Zadanie: {title.GetString()}");
                }
            }
        }

    }
}
