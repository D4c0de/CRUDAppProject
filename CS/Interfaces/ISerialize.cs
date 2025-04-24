using CRUDAppProject.CS.Base;
using CRUDAppProject.CS.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CRUDAppProject.CS.Interfaces
{
    interface ISerialize
    {

        public const string DefaultFilePath = "Data.json"; // Domyślna ścieżka do pliku JSON
        /// <summary>
        /// Zapisywanie danych związanych z zadaniami i profilem do pliku .json 
        /// <paramref name="Lista_zadań"/>Lista zadań
        /// <paramref name="filePath"/> Ścieżka do pliku
        /// </summary>
        public void SaveDataToFile(List<object> list, string filePath=DefaultFilePath) {


            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            };

            // Rozpoznaj, jaki to typ obiektów w liście
            if (list.Count == 0)
                throw new ArgumentException("Lista jest pusta. Nie można zapisać.");

            Type itemType = list[0].GetType();

            // Serializacja listy jako tego konkretnego typu
            string jsonString = JsonSerializer.Serialize(list, typeof(List<>).MakeGenericType(itemType), options);

            File.WriteAllText(filePath, jsonString);


        }


        /// <summary>
        /// Pobranie danych związanych z zadaniami i profilem z pliku .json
        /// <paramref name="filePath"/> Ścieżka do pliku 
        /// </summary>

        public List<object> LoadDataFromFile(string filePath = DefaultFilePath)
        {
            if (!File.Exists(filePath))
                throw new FileNotFoundException("Plik nie został znaleziony: " + filePath);

            string jsonString = File.ReadAllText(filePath);

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            List<object> result = new List<object>();

            try
            {
                var tasks = JsonSerializer.Deserialize<List<JsonElement>>(jsonString, options);

                foreach (var task in tasks)
                {
                    if (task.TryGetProperty("taskSource", out _))
                    {
                        var exercise = JsonSerializer.Deserialize<Task_Exercise>(task.GetRawText(), options);
                        result.Add(exercise);
                    }
                    else if (task.TryGetProperty("materialScope", out _))
                    {
                        var exam = JsonSerializer.Deserialize<Task_Exam>(task.GetRawText(), options);
                        result.Add(exam);
                    }
                    else if (task.TryGetProperty("Members", out _))
                    {
                        var exam = JsonSerializer.Deserialize<Task_Exam>(task.GetRawText(), options);
                        result.Add(exam);
                    }
                    else
                    {
                        throw new InvalidDataException("Nieznany typ zadania w pliku JSON.");
                    }
                }
            }
            catch (Exception ex)
            {
                throw new InvalidDataException("Wystąpił błąd podczas deserializacji: " + ex.Message);
            }

            return result;
        }
        /// <summary>
        /// Pobranie danych związanych z zadaniami i profilem z pliku .json
        /// <paramref name="ObjectListRef"/> Lista zadań
        /// <paramref name="filePath"/> Ścieżka do pliku 
        /// </summary>
        public void LoadDataFromFile(ref List<object> ObjectListRef ,string filePath = DefaultFilePath)
        {
            if (!File.Exists(filePath))
                throw new FileNotFoundException("Plik nie został znaleziony: " + filePath);

            string jsonString = File.ReadAllText(filePath);

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            List<object> result = new List<object>();

            try
            {
                var tasks = JsonSerializer.Deserialize<List<JsonElement>>(jsonString, options);

                foreach (var task in tasks)
                {
                    if (task.TryGetProperty("taskSource", out _))
                    {
                        var exercise = JsonSerializer.Deserialize<Task_Exercise>(task.GetRawText(), options);
                        result.Add(exercise);
                    }
                    else if (task.TryGetProperty("materialScope", out _))
                    {
                        var exam = JsonSerializer.Deserialize<Task_Exam>(task.GetRawText(), options);
                        result.Add(exam);
                    }
                    else if (task.TryGetProperty("Members", out _))
                    {
                        var exam = JsonSerializer.Deserialize<Task_Exam>(task.GetRawText(), options);
                        result.Add(exam);
                    }
                    else
                    {
                        throw new InvalidDataException("Nieznany typ zadania w pliku JSON.");
                    }
                }
            }
            catch (Exception ex)
            {
                throw new InvalidDataException("Wystąpił błąd podczas deserializacji: " + ex.Message);
            }

            ObjectListRef=result;
        }
    }
}
