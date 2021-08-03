using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FitnesApp.DTO
{
    /// <inheritdoc />
    /// <summary>
    /// Класс, хронящий все названия упражнений и ??выдающий бланки для заполнения??
    /// </summary>
    public class Exercieses : IEnumerable<ExerciseInfo>
    {
        private readonly List<ExerciseInfo> _listExerciseInfos = new List<ExerciseInfo>
        {
            new ExerciseInfo("Жим лежа", "", ExType.Repeated),
            new ExerciseInfo("Приседание со штангой", "", ExType.Repeated),
            new ExerciseInfo("Становая тяга", "", ExType.Repeated),
            new ExerciseInfo("Подъем на бицепс стоя", "", ExType.Repeated),
            new ExerciseInfo("Приседания в Гакке", "", ExType.Repeated),
            new ExerciseInfo("Становая тяга на прямых", "", ExType.Repeated),
            new ExerciseInfo("Отведения руки на верхнем блоке стоя", "", ExType.Repeated),
            new ExerciseInfo("Подтягивания", "", ExType.Repeated),
            new ExerciseInfo("Кроссовер", "", ExType.Repeated),
            new ExerciseInfo("Жим сидя гантелей", "", ExType.Repeated),
        };

        /// <summary>
        /// Возвращает список всех упражнений нужного типа
        /// </summary>
        /// <param name="type">Тип упражнений</param>
        /// <returns></returns>
        public IEnumerable<string> GetExerciseList(ExType type)
        {
            return _listExerciseInfos.Where(w => w.Type == type).Select(item => item.Name);
        }

        /// <summary>
        /// Возвращает список названий повторных упражнений
        /// </summary>
        /// <returns></returns>
        public IEnumerable<string> GetRepeatedExList()
        {
            return GetExerciseList(ExType.Repeated);
        }

        /// <summary>
        /// Выдает бланк для заполнения 
        /// </summary>
        /// <param name="exInfo">Инфо упражнения</param>
        /// <returns></returns>
        public ExerciseRepeated GetExerciseRepeatedBlanc(ExerciseInfo exInfo)
        {
            if (exInfo.Type == ExType.Repeated)
            {
                return new ExerciseRepeated(exInfo);
            }
            throw new Exception("Упражнение не того типа");
            //var q = _listExerciseInfos.Where(item => item.Type == ExType.Repeated).First(rep => rep.Name == name);
        }

        public IEnumerator<ExerciseInfo> GetEnumerator()
        {
            return _listExerciseInfos.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<ExerciseInfo>)_listExerciseInfos).GetEnumerator();
        }
    }
}