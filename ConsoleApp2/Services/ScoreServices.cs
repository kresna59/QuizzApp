using System.Text.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace QuizApp.Services
{
    public static class ScoreService
    {
        private static readonly string ScoreFile = "C:/Users/akay/source/repos/ConsoleApp2/ConsoleApp2/Data/ScoreLog.json";
        // Fungsi utama (untuk runtime biasa)  
        public static void SaveScore(int correct, int total)
        {
            SaveScore(correct, total, ScoreFile);
        }

        // Overload fungsi (untuk unit test)  
        public static void SaveScore(int correct, int total, string filePath)
        {
            if (correct < 0 || total <= 0 || correct > total)
                throw new ArgumentException("Skor tidak valid.");

            var result = new { timestamp = DateTime.Now, correct, total };
            List<object> allScores = new List<object>(); // Fixed to explicitly initialize the list  

            if (File.Exists(filePath))
            {
                var json = File.ReadAllText(filePath);
                allScores = JsonSerializer.Deserialize<List<object>>(json) ?? new List<object>();
            }

            allScores.Add(result);
            var updated = JsonSerializer.Serialize(allScores, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, updated);
        }
    }
}
