﻿using System;
using SQLite;
using System.Collections.Generic;
using System.Text;

namespace PersonalAgenda.Models
{
    class Agenda
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }
    }
}
