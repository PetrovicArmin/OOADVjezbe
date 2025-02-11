﻿using System;
using System.ComponentModel.DataAnnotations;

namespace PrvaASPNETAplikacija.Models
{
    public class Predmet
    {
        [Key]
        public int ID { get; set; }
        public string Naziv { get; set; }
        public double ECTS { get; set; }

        public Predmet() { }

        public int GenerišiID()
        {
            int id = 0;
            Random generator = new Random();
            for (int i = 0; i < 10; i++)
            {
                id += (int)Math.Pow(10, i) * generator.Next(0, 9);
            }
            return id;
        }
    }
}