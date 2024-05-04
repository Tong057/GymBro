﻿using System;
namespace GymBro.Models.Data.EntityFramework.Models
{
	public class ExerciseWeight
	{
		public int Id { get; set; }
		public double Weight { get; set; }

		public int ExerciseStatusId { get; set; }
		public ExerciseStatus ExerciseStatus { get; set; }

        public ExerciseWeight(double weight)
        {
			Weight = weight;
        }

        public ExerciseWeight()
		{
		}
	}
}

