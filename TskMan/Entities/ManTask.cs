using System;
<<<<<<< HEAD
using TskMan.Entities.Exceptions;
=======
using System.Text;
>>>>>>> ca9b8b505946e048edf6d4b555579ebb5de1214e
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
<<<<<<< HEAD
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
=======
        public ManTask(int id, string title, string content, DateTime creationDateTime)
        {
            Id = id;
>>>>>>> ca9b8b505946e048edf6d4b555579ebb5de1214e
            Title = title;
            Content = content;
            CreationDateTime = DateTime.Now;
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