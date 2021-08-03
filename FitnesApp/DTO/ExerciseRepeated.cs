using System;

namespace FitnesApp.DTO
{
    /// <inheritdoc />
    /// <summary>
    /// Класс хронящий данные о повторных упражнениях
    /// </summary>
    public class ExerciseRepeated : ExerciseBase
    {
        public int Repetitions { get; private set; }
        public double Weight { get; private set; }

        #region CTORs
        internal ExerciseRepeated(ExerciseInfo inf)
        {
            if (inf.Type != ExType.Repeated)
                throw new Exception("Не тот тип");
            Info = inf;
            //ExType = ExType.Repeated;
            StartTime = DateTime.Now;
        }

        //private ExerciseRepeated(int i, double weight, DateTime startTime)
        //{
        //    //ExType = ExType.Repeated;
        //    Weight = weight;
        //    StartTime = startTime;
        //    EndTime = DateTime.Now;
        //    Repetitions = i;
        //}
        #endregion

        public void SetEx(int repetitions, double weight)
        {
            if (EndTime != default(DateTime)) return;

            Repetitions = repetitions;
            Weight = weight;
            EndTime = DateTime.Now;
        }
    }
}