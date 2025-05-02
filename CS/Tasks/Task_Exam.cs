using CRUDAppProject.CS.Base;
using CRUDAppProject.CS.Interfaces;
using CRUDAppProject.Forms.Logged_in_forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CRUDAppProject.CS.Tasks
{
    /// <summary>
    /// Klasa dziedzicząca po klasie abstrakcyjnej Base_Task - określa zadania z kategorii Egzamin
    /// </summary>

    internal class Task_Exam : Base_Task, ITaskCRUD, ISerialize
    {
        /// <summary>
        /// Zakres materiału konieczny do przyswojenia aby zaliczyć egzamin
        /// </summary>

        private string _materialScope;
        public string MaterialScope
        {
            get { return this._materialScope; }
            set 
            {                
                if (!string.IsNullOrWhiteSpace(value) && !string.IsNullOrEmpty(value))
                {
                    value = value.Trim();
                    this._materialScope = value;
                }

                else
                    throw new ArgumentException("Zakres materiału nie może być pusty!", "ExamMaterialScopeNullOrEmpty");

            }
        }


        /// <summary>
        /// Pozwala dodać kolejny punkt do listy rzeczy, które należy przyswoić
        /// </summary>

        public static void AddMaterialToScope()
        {

        }


        /// <summary>
        /// Pozwala usunąć punkt z listy rzeczy, które należy przyswoić
        /// </summary>

        public static void RemoveMaterialFromScope()
        {

        }

        public override void TaskCreator()
        {
            Form_CreateExam Screen_ExamCreator = new Form_CreateExam();
            Screen_ExamCreator.Show();
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
            if (task is Task_Exam examTask)
            {
                examTask.SaveDataToFile();
                MessageBox.Show("Egzamin został stworzony i zapisany pomyślnie.", "Tworzenie egzaminu", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
            string filePath = Base_AppState.ChosenProfileFilePath;

            if (!File.Exists(filePath))
                throw new FileNotFoundException("Plik profilu nie istnieje.", filePath);

            string jsonString = File.ReadAllText(filePath);
            var jsonDoc = JsonDocument.Parse(jsonString);
            var root = jsonDoc.RootElement.Clone();

            List<JsonElement> taskExams = new List<JsonElement>();
            if (root.TryGetProperty("taskExams", out JsonElement existingExams) && existingExams.ValueKind == JsonValueKind.Array)
                taskExams.AddRange(existingExams.EnumerateArray());

            var taskObj = new
            {
                taskType = this.GetType().Name,
                title = this.Title,
                shortDescription = this.ShortDescription,
                description = this.Description,
                materialScope = this.MaterialScope,
                chosenSubject = this.ChosenSubject,
                dateOfCreation = this.DateOfCreation,
                deadline = this.Deadline,
                status = this.Status,
                isCompleted = this.IsCompleted
            };

            string taskJson = JsonSerializer.Serialize(taskObj);
            taskExams.Add(JsonDocument.Parse(taskJson).RootElement);

            var updatedProfile = new Dictionary<string, object>();
            foreach (var prop in root.EnumerateObject())
            {
                if (prop.Name != "taskExams")
                    updatedProfile[prop.Name] = JsonSerializer.Deserialize<object>(prop.Value.GetRawText());
            }

            updatedProfile["taskExams"] = taskExams;

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

            if (!root.TryGetProperty("taskExams", out JsonElement tasksElement) || tasksElement.ValueKind != JsonValueKind.Array)
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
