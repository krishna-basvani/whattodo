using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using WhatToDo.Service.Model;
using WhatToDo.Service;

namespace WhatToDo.Test
{
    [TestClass]
    public class ToDoTest
    {
        [TestMethod]
        public void AddNewToDoTest()
        {
            var todo = new ToDoItem()
            {
                Subject = "Something",
                Date = DateTime.Now
            };

            var context = new MoqToDoDbContext();

            var todoService = new ToDo(context.GetMoqDbContext());
            todoService.Add(todo);

            Assert.IsTrue(todo.Id > 0);
        }
    }
}
