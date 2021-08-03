using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using FitnesApp.DTO;

namespace ConsoleApp1
{
    internal class Program
    {
        private static void Main()
        {

            var exercieses = new Exercieses();
            var exInfo = exercieses.First(item => item.Type == ExType.Repeated);
            var training = new Training();

            //var ex = exercieses.GetExerciseRepeatedBlanc(exInfo);
            //trying to pull request;
            //trying to pull request2;
            //trying to pull request3;

            //ex.SetEx(10, 60);
            //training.AddEx(ex);
            //ex.SetEx(10, 70);
            //training.AddEx(ex);


            using (var ex = exercieses.GetExerciseRepeatedBlanc(exInfo))
            {
                ex.SetEx(10, 60);
                training.AddEx(ex);
            }

            foreach (var exe in training)
            {
                if (exe.Info.Type != ExType.Repeated) continue;
                var q = (ExerciseRepeated)exe;
                Console.WriteLine($"{q.Info.Name} - {q.Repetitions} повторы - {q.Weight} вес");
            }

            Console.WriteLine("Thats all");
            Console.ReadLine();

        }
    }

}
