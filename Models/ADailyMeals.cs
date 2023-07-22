using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class ADailyMeals
    {
        public ADailyMeals()
        {
            Avat = new HashSet<Avat>();
            Hvat = new HashSet<Hvat>();
        }

        public int MealId { get; set; }
        public string MealDescription { get; set; }
        public double? MealScore { get; set; }

        public virtual ICollection<Avat> Avat { get; set; }
        public virtual ICollection<Hvat> Hvat { get; set; }
    }
}
