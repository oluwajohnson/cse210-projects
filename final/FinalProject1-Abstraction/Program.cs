using System;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {

        Video video = new Video();


        video._author = "Johnson";
        video._title = "Jesus Loves me";
        video._author = "Johnson";
        video._length = 30;
        video.AddVideo();
        video.ViewVideo();


        Comment comment = new Comment();
        comment._userName = "Demola";
        comment._comment = "This is lovely";
        comment.Commentator();


        // video.ViewVideo();
    }

}