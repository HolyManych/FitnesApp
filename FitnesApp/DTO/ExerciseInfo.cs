using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FitnesApp.DTO
{
    public class ExerciseInfo
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public ExType Type { get; private set; }

        //картинки
        //ссылки

        public ExerciseInfo(string name, string description, ExType type)
        {
            Name = name;
            Description = description;
            Type = type;
        }
    }



    

}