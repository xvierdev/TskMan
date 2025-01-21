using System;
using TskMan.Entities.Exceptions;
namespace TskMan.Entities
{
    // Represents a user task.
    class ManTask
    {
        public string Title { get; set; }              // Title os task
        public string Content { get; set; }            // Task content
        public DateTime CreationDateTime { get; private set; } // Creation time

        public ManTask()
        {

        }
        public ManTask(string title, string content)
        {
            if (title == "")
            {
                throw new DomainException("Task title is empty.");
            }
            if (content == "")
            {
                throw new DomainException("Content is empty.");
            }
            Title = title;
            Content = content;
            CreationDateTime = DateTime.Now;
        }
    }
}