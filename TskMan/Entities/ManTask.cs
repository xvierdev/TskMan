using System;
using System.Text;
namespace TskMan.Entities
{
    // Represents a user task.
    class ManTask
    {
        public int Id { get; private set; }            // Task id
        public string Title { get; set; }              // Title os task
        public string Content { get; set; }            // Task content
        public DateTime CreationDateTime { get; private set; } // Creation time

        public ManTask()
        {

        }
        public ManTask(int id, string title, string content, DateTime creationDateTime)
        {
            Id = id;
            Title = title;
            Content = content;
            CreationDateTime = creationDateTime;
        }

        public override string ToString(){
            StringBuilder stringBuilder = new();
            stringBuilder.AppendLine($"Id: {Id}");
            stringBuilder.AppendLine($"Created: {CreationDateTime.ToString()}");
            stringBuilder.AppendLine($"Title: {Title}");
            stringBuilder.AppendLine($"Content: {Content}");
            return stringBuilder.ToString();
        }
    }
}