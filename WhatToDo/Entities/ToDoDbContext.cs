using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WhatToDo.Service.Model;

namespace WhatToDo.Service.Entities
{
    public class ToDoDbContext: DbContext
    {
        public ToDoDbContext(DbContextOptions options): base(options)
        {

        }
        public DbSet<ToDoItem> ToDoItem { get; set; }
    }
}
