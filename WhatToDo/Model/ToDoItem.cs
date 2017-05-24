using System;

namespace WhatToDo.Service.Model
{
    public class ToDoItem
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public DateTime Date { get; set; }
    }
}