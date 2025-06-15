using CRUDAppProject.CS.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Threading.Tasks;

namespace CRUDAppProject.CS.Base
{

    /// <summary>
    /// Klasa zawierająca listę przedmiotów oraz listę zadań
    /// </summary>

    public class RootObject
    {
        public List<string> ListOfSubjects { get; set; }
        public List<Base_Task> Tasks { get; set; }
    }


    /// <summary>
    /// Konwerter JSON służący do serializacji i deserializacji obiektów typu Base_Task
    /// </summary>

    public class TaskConverter : JsonConverter<Base_Task>
    {
        public override Base_Task Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            using var jsonDoc = JsonDocument.ParseValue(ref reader);
            var root = jsonDoc.RootElement;

            var taskType = root.GetProperty("taskType").GetString();

            return taskType switch
            {
                "CRUDAppProject.CS.Tasks.Task_Proj" => JsonSerializer.Deserialize<Task_Proj>(root.GetRawText(), options),
                "CRUDAppProject.CS.Tasks.Task_Exercise" => JsonSerializer.Deserialize<Task_Exercise>(root.GetRawText(), options),
                "CRUDAppProject.CS.Tasks.Task_Exam" => JsonSerializer.Deserialize<Task_Exam>(root.GetRawText(), options),

                "Task_Proj" => JsonSerializer.Deserialize<Task_Proj>(root.GetRawText(), options),
                "Task_Exercise" => JsonSerializer.Deserialize<Task_Exercise>(root.GetRawText(), options),
                "Task_Exam" => JsonSerializer.Deserialize<Task_Exam>(root.GetRawText(), options),

                _ => throw new NotSupportedException($"Nieznany typ zadania: {taskType}"),
                
            };

        }


        /// <summary>
        /// Serializuje obiekt typu <see cref="Base_Task"/> do formatu JSON.
        /// Uwzględnia rzeczywisty typ obiektu przy serializacji.
        /// </summary>
        /// <param name="writer">Obiekt zapisujący dane w formacie JSON.</param>
        /// <param name="value">Obiekt zadania, który ma zostać zserializowany.</param>
        /// <param name="options">Opcje używane podczas serializacji JSON.</param>

        public override void Write(Utf8JsonWriter writer, Base_Task value, JsonSerializerOptions options)
        {
            JsonSerializer.Serialize(writer, (object)value, value.GetType(), options);
        }
    }
}
