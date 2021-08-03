using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnesApp.DTO
{
    public class Training: IEnumerable<ExerciseBase>
    {
        public DateTime StartTime { get; private set; }
        public DateTime EndTime { get; private set; }
        //public bool IsClosed { get; private set; } = false;

        //public int UserId { get; private set; }

        private readonly List<ExerciseBase> _trainList = new List<ExerciseBase>();

        public Training()
        {
            StartTime = DateTime.Now;
        }

        public void AddEx(ExerciseBase exercise)
        {
            _trainList.Add(exercise);
        }

        public void CloseTraining()
        {
            EndTime = DateTime.Now;
            //IsClosed = true;
        }

        public IEnumerator<ExerciseBase> GetEnumerator()
        {
            return _trainList.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
