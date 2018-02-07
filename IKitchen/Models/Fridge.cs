using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace IKitchen.Models
{
    public class Fridge
    {
        public int FridgeID { get; set; }
        public int IngredientID { get; set; }
        public double Amount { get; set; }
        public string Measure { get; set; }
        public DateTime UseByDate { get; set; }
        public DateTime PurchaseDate { get; set; }
    }
}