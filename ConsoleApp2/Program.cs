using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuizApp.Services;
using System.Windows.Forms;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
            Console.WriteLine("=== Sistem Quiz ===");
            Console.WriteLine("1. Mulai Quiz");
            Console.WriteLine("2. Tambah Soal (Admin)");
            Console.Write("Pilih opsi: ");
            var input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    var quiz = new QuizService("C:/Users/akay/source/repos/ConsoleApp2/ConsoleApp2/Data/QuestionBank.json");
                    quiz.StartQuiz();
                    break;
                case "2":
                    AdminService.AddQuestion();
                    break;
                default:
                    Console.WriteLine("Opsi tidak dikenal.");
                    break;
            }
        }
    }
}
