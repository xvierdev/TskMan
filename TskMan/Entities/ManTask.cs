using System;
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
        public ManTask(string title, string content, DateTime creationDateTime)
        {
            Title = title;
            Content = content;
            CreationDateTime = creationDateTime;
        }
    }
}