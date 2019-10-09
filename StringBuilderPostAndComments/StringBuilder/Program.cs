using System;
using StringBuilderPost.Entities;

namespace StringBuilderPost
{
    class Program
    {
        static void Main(string[] args)
        {

            Comment c1 = new Comment("Have a nice trip!");
            Comment c2 = new Comment("Wow thats awesome!");

            Post p1 = new Post(
                DateTime.Parse("21/06/2018 13:05:44"),
                "Traveling to New Zeland",
                "I'm going to visit this wonderful country",
                12);

            p1.AddComment(c1);
            p1.AddComment(c2);

            Comment c3 = new Comment("Good Night");
            Comment c4 = new Comment("Boa noite, parça");

            Post p2 = new Post(
                DateTime.Now,
                "Good Night guys(us)/Boa noite parças(br)",
                "See you tomorrow ninjas(us)/ Até amanhã rapaize(br)",
                5);

            p2.AddComment(c3);
            p2.AddComment(c4);

            Console.WriteLine(p1);
            Console.WriteLine(p2);
        }
    }
}
