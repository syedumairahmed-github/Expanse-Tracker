﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Expanse_Tracker.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }

        public int CatogoryId { get; set; }
        public Category Category { get; set; }

        public int Amount { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string Note { get; set; }

        public DateTime Date { get; set; } = DateTime.Now;
    }
}
