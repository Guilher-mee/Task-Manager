using System;
using System.Collections.Generic;
using System.Text;

namespace TaskManager
{
    public class TaskItem 
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public bool Finished { get; set; }
    }
}
