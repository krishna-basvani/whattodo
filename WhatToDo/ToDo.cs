using System;
using WhatToDo.Service.Entities;
using WhatToDo.Service.Model;

namespace WhatToDo.Service
{
    public class ToDo
    {
        private readonly ToDoDbContext _toDoContext;

        public ToDo(ToDoDbContext toDoContext)
        {
            _toDoContext = toDoContext;
        }

        public void Add(ToDoItem todo)
        {
            _toDoContext.ToDoItem.Add(todo);
            _toDoContext.SaveChanges();
        }
    }
}