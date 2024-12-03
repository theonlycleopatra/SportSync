namespace ExercisesPage
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Exercise = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtboxSets = new System.Windows.Forms.TextBox();
            this.txtboxReps = new System.Windows.Forms.TextBox();
            this.txtboxEquipment = new System.Windows.Forms.TextBox();
            this.btnAddExercise = new System.Windows.Forms.Button();
            this.btnAddSets = new System.Windows.Forms.Button();
            this.btnAddReps = new System.Windows.Forms.Button();
            this.btnAddEquipment = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cmbExerciseType = new System.Windows.Forms.ComboBox();
            this.lstExercises = new System.Windows.Forms.ListBox();
            this.txtboxExercise = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Exercise
            // 
            this.Exercise.AutoSize = true;
            this.Exercise.Location = new System.Drawing.Point(117, 35);
            this.Exercise.Name = "Exercise";
            this.Exercise.Size = new System.Drawing.Size(69, 20);
            this.Exercise.TabIndex = 0;
            this.Exercise.Text = "Exercise";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sets";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Reps";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(100, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Equipment";
            // 
            // txtboxSets
            // 
            this.txtboxSets.Location = new System.Drawing.Point(217, 173);
            this.txtboxSets.Name = "txtboxSets";
            this.txtboxSets.Size = new System.Drawing.Size(121, 26);
            this.txtboxSets.TabIndex = 5;
            // 
            // txtboxReps
            // 
            this.txtboxReps.Location = new System.Drawing.Point(217, 116);
            this.txtboxReps.Name = "txtboxReps";
            this.txtboxReps.Size = new System.Drawing.Size(121, 26);
            this.txtboxReps.TabIndex = 6;
            // 
            // txtboxEquipment
            // 
            this.txtboxEquipment.Location = new System.Drawing.Point(217, 250);
            this.txtboxEquipment.Name = "txtboxEquipment";
            this.txtboxEquipment.Size = new System.Drawing.Size(121, 26);
            this.txtboxEquipment.TabIndex = 7;
            // 
            // btnAddExercise
            // 
            this.btnAddExercise.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddExercise.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddExercise.Location = new System.Drawing.Point(376, 32);
            this.btnAddExercise.Name = "btnAddExercise";
            this.btnAddExercise.Size = new System.Drawing.Size(215, 244);
            this.btnAddExercise.TabIndex = 8;
            this.btnAddExercise.Text = "Add";
            this.btnAddExercise.UseVisualStyleBackColor = false;
            this.btnAddExercise.Click += new System.EventHandler(this.btnAddExercise_Click);
            // 
            // btnAddSets
            // 
            this.btnAddSets.Location = new System.Drawing.Point(242, 20);
            this.btnAddSets.Name = "btnAddSets";
            this.btnAddSets.Size = new System.Drawing.Size(10, 10);
            this.btnAddSets.TabIndex = 9;
            this.btnAddSets.Text = "Add";
            this.btnAddSets.UseVisualStyleBackColor = true;
            this.btnAddSets.Click += new System.EventHandler(this.btnAddSets_Click);
            // 
            // btnAddReps
            // 
            this.btnAddReps.Location = new System.Drawing.Point(293, 20);
            this.btnAddReps.Name = "btnAddReps";
            this.btnAddReps.Size = new System.Drawing.Size(10, 10);
            this.btnAddReps.TabIndex = 10;
            this.btnAddReps.Text = "Add";
            this.btnAddReps.UseVisualStyleBackColor = true;
            this.btnAddReps.Click += new System.EventHandler(this.btnAddReps_Click);
            // 
            // btnAddEquipment
            // 
            this.btnAddEquipment.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddEquipment.Location = new System.Drawing.Point(258, 20);
            this.btnAddEquipment.Name = "btnAddEquipment";
            this.btnAddEquipment.Size = new System.Drawing.Size(10, 10);
            this.btnAddEquipment.TabIndex = 11;
            this.btnAddEquipment.Text = "Add";
            this.btnAddEquipment.UseVisualStyleBackColor = false;
            this.btnAddEquipment.Click += new System.EventHandler(this.btnAddEquipment_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(309, 508);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(76, 36);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmbExerciseType
            // 
            this.cmbExerciseType.FormattingEnabled = true;
            this.cmbExerciseType.Location = new System.Drawing.Point(217, 12);
            this.cmbExerciseType.Name = "cmbExerciseType";
            this.cmbExerciseType.Size = new System.Drawing.Size(121, 28);
            this.cmbExerciseType.TabIndex = 13;
            // 
            // lstExercises
            // 
            this.lstExercises.FormattingEnabled = true;
            this.lstExercises.ItemHeight = 20;
            this.lstExercises.Location = new System.Drawing.Point(64, 308);
            this.lstExercises.Name = "lstExercises";
            this.lstExercises.Size = new System.Drawing.Size(483, 124);
            this.lstExercises.TabIndex = 14;
            // 
            // txtboxExercise
            // 
            this.txtboxExercise.Location = new System.Drawing.Point(217, 50);
            this.txtboxExercise.Name = "txtboxExercise";
            this.txtboxExercise.Size = new System.Drawing.Size(121, 26);
            this.txtboxExercise.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 698);
            this.Controls.Add(this.txtboxExercise);
            this.Controls.Add(this.lstExercises);
            this.Controls.Add(this.cmbExerciseType);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAddEquipment);
            this.Controls.Add(this.btnAddReps);
            this.Controls.Add(this.btnAddSets);
            this.Controls.Add(this.btnAddExercise);
            this.Controls.Add(this.txtboxEquipment);
            this.Controls.Add(this.txtboxReps);
            this.Controls.Add(this.txtboxSets);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Exercise);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Exercise;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtboxSets;
        private System.Windows.Forms.TextBox txtboxReps;
        private System.Windows.Forms.TextBox txtboxEquipment;
        private System.Windows.Forms.Button btnAddExercise;
        private System.Windows.Forms.Button btnAddSets;
        private System.Windows.Forms.Button btnAddReps;
        private System.Windows.Forms.Button btnAddEquipment;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cmbExerciseType;
        private System.Windows.Forms.ListBox lstExercises;
        private System.Windows.Forms.TextBox txtboxExercise;
    }
}

