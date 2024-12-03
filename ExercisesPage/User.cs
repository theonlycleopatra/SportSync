using System.Collections.Generic;

namespace ExercisesPage
{
    public class User
    {
        public string Name { get; set; }
        public List<Exercise> Exercises { get; set; } = new List<Exercise>();

        public void AddExercise(Exercise exercise)
        {
            Exercises.Add(exercise);
        }
    }
}
