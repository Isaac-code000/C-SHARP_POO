using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Ex_03.Entities
{
    class Post
    {
        public string Title { get; set; }   
        public string Content { get; set; }
        public DateTime Moment { get; set; }
      
        public List<Coment> Coments { get; set; } = new List<Coment>();

        public Post(string title, string content, DateTime moment)
        {
            Title = title;
            Content = content;
            Moment = moment;
        }

        public void AddComent(Coment coment)
        {
            Coments.Add(coment); // Implementation for adding a comment to the post
        }

        public void RemoveComent(Coment coment)
        {
            Coments.Remove(coment); // Implementation for removing a comment from the post
        }




        override public string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Title);
            sb.AppendLine(Content);
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Coments: ");
            foreach (Coment coment in Coments)
            {
                sb.AppendLine(coment.Text);
            }
            return sb.ToString();
        }

    }
}
