using CRUDAppProject.CS.Base;
using CRUDAppProject.CS.Interfaces;
using CRUDAppProject.Forms.Logged_in_forms;
using CRUDAppProject.Forms.Task_display_forms;
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

        public override void TaskCreator()
        {
            Form_CreateExam Screen_ExamCreator = new Form_CreateExam();
            Screen_ExamCreator.Show();
        }

        public override void TaskDisplayer()
        {
            Form_DisplayExam screenTaskDisplayer = new Form_DisplayExam(this);
            screenTaskDisplayer.Show();
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
            if (task is Task_Exam examTask)
            {
                for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
                    Application.OpenForms[i].Close();

                task.TaskDisplayer();
            }


            else
                throw new ArgumentException("FATAL: konflikt typów zadań", "FATALTaskTypeConflict");
        }

        public void EditTask(Base_Task task)
        {

        }

        public void RemoveTask(Base_Task task)
        {
            string filePath = Base_AppState.ChosenProfileFilePath;

            if (!File.Exists(filePath))
                throw new FileNotFoundException("Plik profilu nie istnieje.", filePath);

            string jsonString = File.ReadAllText(filePath);
            var jsonDoc = JsonDocument.Parse(jsonString);
            var root = jsonDoc.RootElement;

            if (!root.TryGetProperty("tasks", out JsonElement tasksElement) || tasksElement.ValueKind != JsonValueKind.Array)
                throw new JsonException("Brak listy zadań w pliku profilu.");

            List<JsonElement> updatedTasks = new List<JsonElement>();
            bool taskFound = false;

            foreach (JsonElement existingTask in tasksElement.EnumerateArray())
            {
                bool isMatch = false;

                if (existingTask.TryGetProperty("taskType", out JsonElement typeElem) &&
                    existingTask.TryGetProperty("title", out JsonElement titleElem) &&
                    existingTask.TryGetProperty("dateOfCreation", out JsonElement dateElem) &&
                    string.Equals(typeElem.GetString(), task.GetType().Name) &&
                    string.Equals(titleElem.GetString()?.Trim(), task.Title?.Trim(), StringComparison.OrdinalIgnoreCase) &&
                    DateTime.TryParse(dateElem.GetString(), out DateTime parsedDate) &&
                    parsedDate == task.DateOfCreation)
                {
                    isMatch = true;
                }

                if (!isMatch)
                    updatedTasks.Add(existingTask);
                else
                    taskFound = true;
            }

            if (!taskFound)
                throw new InvalidOperationException("Nie znaleziono zadania do usunięcia.");

            var updatedProfile = new Dictionary<string, object>();

            foreach (var prop in root.EnumerateObject())
            {
                if (prop.Name != "tasks")
                    updatedProfile[prop.Name] = JsonSerializer.Deserialize<object>(prop.Value.GetRawText());
            }

            updatedProfile["tasks"] = updatedTasks;

            var options = new JsonSerializerOptions { WriteIndented = true };
            string updatedJson = JsonSerializer.Serialize(updatedProfile, options);
            File.WriteAllText(filePath, updatedJson);
        }

        public override void ShowTaskCard(Panel panelToShowOn)
        {
            // Create a new card panel
            Panel cardPanel = new Panel
            {
                Size = new Size(Base_Task.CardLength, Base_Task.CardWidth),
                Location = new Point(10, SpaceBetweenCardsOnY), // vertical spacing
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.White,
                Cursor = Cursors.Hand
            };

            
            Label titleLabel = new Label
            {
                Text = this.ChosenSubject,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                Dock = DockStyle.Top,
                Height = 25,
                TextAlign = ContentAlignment.MiddleCenter
            };

            
            Label taskTye = new Label
            {
                Text = Base_Task.ListOfTaskTypes[2],
                Font = new Font("Segoe UI", 9),
                Dock = DockStyle.Top,
                Height = 20,
                TextAlign = ContentAlignment.MiddleCenter
            };

            // Quote
            Label shortDescriptionLabel = new Label
            {
                Text = this.ShortDescription,
                Font = new Font("Segoe UI", 9, FontStyle.Italic),
                Dock = DockStyle.Top,
                Height = 20,
                TextAlign = ContentAlignment.MiddleCenter
            };

            // Deadline
            Label deadlineLabel = new Label
            {
                Text = $"Termin: {this.Deadline.ToShortDateString()}",
                Font = new Font("Segoe UI", 9),
                Dock = DockStyle.Bottom,
                Height = 25,
                TextAlign = ContentAlignment.MiddleCenter
            };

            // Add Labels            
            
            cardPanel.Controls.Add(shortDescriptionLabel);
            cardPanel.Controls.Add(taskTye);
            cardPanel.Controls.Add(titleLabel);
            cardPanel.Controls.Add(deadlineLabel);

            cardPanel.Click += CardPanel_Click;
            foreach (Control control in cardPanel.Controls)
                control.Click += CardPanel_Click;

            panelToShowOn.Controls.Add(cardPanel);
            Base_AppState.CardCount++;
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
                materialScope = this.MaterialScope,
                chosenSubject = this.ChosenSubject,
                dateOfCreation = this.DateOfCreation,
                deadline = this.Deadline
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
                if (task.TryGetProperty("title", out JsonElement title))
                    Console.WriteLine($"Zadanie: {title.GetString()}");
        }

        public override void CardPanel_Click(object sender, EventArgs e) => DisplayTask(this);

    }
}
