using System;
using System.IO;

namespace QuizApp.Utils
{
    public static class Config
    {
        public static string BaseDirectory = AppDomain.CurrentDomain.BaseDirectory;

        public static string QuestionBankPath => Path.GetFullPath("C:/Users/akay/source/repos/ConsoleApp2/ConsoleApp2/Data/QuestionBank.json");

        public static string ScoreLogPath => Path.GetFullPath("C:/Users/akay/source/repos/ConsoleApp2/ConsoleApp2/Data/ScoreLog.json");
    }
}
