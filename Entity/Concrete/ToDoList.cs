﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class ToDoList
    {
        [Key]
        public int ToDoListID { get; set; }
        public string Content { get; set; }
        public bool Status { get; set; }
    }
}