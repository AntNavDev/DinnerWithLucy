using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DinnerWithLucy.Models
{
    public class Ingredient
    {
        public int Id { set; get; }
        public string Name { set; get; }

        public int Calories { set; get; }
    }
}
