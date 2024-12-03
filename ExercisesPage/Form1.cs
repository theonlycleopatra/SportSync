using System;
using System.Linq;
using System.Windows.Forms;

namespace ExercisesPage
{
    public partial class Form1 : Form
    {
        private User user;

        public Form1()
        {
            InitializeComponent();
            user = new User { Name = "Joe Mama" };

            // Vul de ComboBox met ExerciseTypes
            cmbExerciseType.DataSource = Enum.GetValues(typeof(ExerciseType));
        }

        private void btnAddExercise_Click(object sender, EventArgs e)
        {
            try
            {
                // Valideer invoer
                if (string.IsNullOrWhiteSpace(txtboxExercise.Text))
                    throw new ArgumentException("Exercise name cannot be empty.");
                if (!int.TryParse(txtboxReps.Text, out int reps) || reps <= 0)
                    throw new ArgumentException("Reps must be a valid positive number.");
                if (!int.TryParse(txtboxSets.Text, out int sets) || sets <= 0)
                    throw new ArgumentException("Sets must be a valid positive number.");
                if (cmbExerciseType.SelectedItem == null)
                    throw new ArgumentException("Please select a valid exercise type.");
                string equipment = string.IsNullOrWhiteSpace(txtboxEquipment.Text) ? "None" : txtboxEquipment.Text;

                // Haal de naam van de oefening op uit de TextBox
                string name = txtboxExercise.Text;

                // Maak een nieuwe oefening
                var exercise = new Exercise
                {
                    Name = name,
                    Reps = reps,
                    Sets = sets,
                    Type = (ExerciseType)cmbExerciseType.SelectedItem,
                    Equipment = equipment
                };

                // Voeg de oefening toe aan de gebruiker
                user.AddExercise(exercise);

                // Toon in de ListBox
                lstExercises.Items.Add(exercise.Display());
                MessageBox.Show($"Exercise '{name}' added!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }


        private void btnAddReps_Click(object sender, EventArgs e)
        {
            if (user.Exercises.Count > 0 && int.TryParse(txtboxReps.Text, out int reps))
            {
                user.Exercises.Last().Reps = reps;
                MessageBox.Show($"Reps added: {reps}");
            }
            else
            {
                MessageBox.Show("Add an exercise first.");
            }
        }

        private void btnAddSets_Click(object sender, EventArgs e)
        {
            if (user.Exercises.Count > 0 && int.TryParse(txtboxSets.Text, out int sets))
            {
                user.Exercises.Last().Sets = sets;
                MessageBox.Show($"Sets added: {sets}");
            }
            else
            {
                MessageBox.Show("Add an exercise first.");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (user.Exercises.Count > 0)
            {
                // Maak een overzicht van oefeningen
                string exercises = string.Join(Environment.NewLine, user.Exercises.Select(exercise => exercise.Display()));
                MessageBox.Show($"Saved Exercises:\n{exercises}");
            }
            else
            {
                MessageBox.Show("No exercises to save.");
            }
        }

        private void btnAddEquipment_Click(object sender, EventArgs e)
        {
            if (user.Exercises.Count > 0)
            {
                user.Exercises.Last().Equipment = txtboxEquipment.Text;
                MessageBox.Show($"Equipment added: {txtboxEquipment.Text}");
            }
            else
            {
                MessageBox.Show("Add an exercise first.");
            }
        }
    }
}
