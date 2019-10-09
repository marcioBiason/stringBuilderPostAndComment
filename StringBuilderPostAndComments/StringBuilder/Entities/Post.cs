using System;
using System.Text;
using System.Collections.Generic;

namespace StringBuilderPost.Entities
{
    class Post
    {
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        public List<Comment> Comments { get; set; } = new List<Comment>();

        public Post()
        {
        }

        public Post(DateTime moment, string title, string content, int likes)
        {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;
        }
        
        //Metodo para adicionar um comentario
        public void AddComment(Comment comment)
        {
            Comments.Add(comment);
        }

        //Metodo para remover um comentario
        public void RemoveComment(Comment comment)
        {
            Comments.Remove(comment);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            //AppendLine Adiciona e pula a Linha
            sb.AppendLine(Title);
            //Append adiciona na mesma linha;
            sb.Append(Likes);
            sb.Append(" Likes - ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine(Content);
            sb.AppendLine("Comments: ");

            //Laco de repeticao para adicionar todos os comentarios no Post;
            foreach (Comment c in Comments)
            {
                sb.AppendLine(c.Text);
            }

            //Retornando a string COnstruida;
            return sb.ToString();
        }
    }
}
