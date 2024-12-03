using System;

namespace ExercisesPage
{
    public enum ExerciseType
    {
        Cardio,
        Strength,
        Flexibility
    }

    public class Exercise
    {
        public string Name { get; set; }
        public int Reps { get; set; }
        public int Sets { get; set; }
        public ExerciseType Type { get; set; }
        public string Equipment { get; set; }

        public string Display()
        {
            return $"{Name}: {Reps} reps, {Sets} sets, Type: {Type}, Equipment: {Equipment}";
        }
    }
}
