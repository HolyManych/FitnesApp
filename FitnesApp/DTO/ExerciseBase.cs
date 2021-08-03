using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnesApp.DTO
{
    /// <summary>
    /// Базовый класс для всех упражнений. Бланк для заполнения
    /// </summary>
    public abstract class ExerciseBase : IDisposable
    {
        public DateTime StartTime { get; protected set; }
        public DateTime EndTime { get; protected set; }
        //public string Rest { get; protected set; }
        public ExerciseInfo Info { get; protected set; }

        //TODO Check ExType for need
        //public ExType ExType { get; protected set; }
        //public String Name { get; protected set; }
        //Основная инфа об упражнении
        public void Dispose()
        {
        }
    }
}
