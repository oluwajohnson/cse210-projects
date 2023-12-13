// A code template for the category of things known as Person. The
// responsibility of a Person is to hold and display personal information.
public class Video
{
    // The C# convention is to start member variables with an underscore _


    public string _title = "";
    public string _author = "";
    public int _length = 0;

    // A special method, called a constructor that is invoked using the  
    // new keyword followed by the class name and parentheses.
    public Video()
    {
    }

    List<string> Add_Video = new List<string>();

    public void AddVideo()
    {
        Add_Video.Add($"Youtube {_title}, with {_author} and {_length} seconds duration");

    }
    public void ViewVideo()
    {
        foreach (string videos in Add_Video)
        {

            Console.WriteLine(videos);

        }
    }


}