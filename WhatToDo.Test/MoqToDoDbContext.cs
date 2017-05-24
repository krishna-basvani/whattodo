using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WhatToDo.Service.Entities;
namespace WhatToDo.Test
{
    public class MoqToDoDbContext
    {
        public ToDoDbContext GetMoqDbContext()
        {
            var optionBuilder = new DbContextOptionsBuilder<ToDoDbContext>();
            optionBuilder.UseInMemoryDatabase();

            var context = new ToDoDbContext(optionBuilder.Options);

            return context;
        }
    }
}
