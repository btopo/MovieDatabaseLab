

bool continueLoop = true;

Console.WriteLine(" Hi welcome to the Movie Database lab. ");


List<movie> movies = new List<movie>()
{
    new movie ( "Dumb and Dumber", "Comedy"),
    new movie ( "Seven","Drama"),
    new movie ( "Avengers", "Action"),
    new movie ( "Dragon Ball Z", "Anime" ),
    new movie ( "Horrible Bosses", "Comedy"),
    new movie ( "Lion King","Family" ),
    new movie ( "Elf","Family"),
    new movie ( "Saving Private Ryan", "War"),
    new movie ( "Terminator 2","SciFi"),
    new movie ( "Wedding Crashers", "Romance")

};

while (continueLoop)
{
    Console.WriteLine("There are 10 Movies in this list. What category are you interested in? There is Comedy, Drama, Romance, Family, War, Scifi, and Anime. : ");
    string userEntry = Console.ReadLine();
    List<string> titles = movies 
        .Where(x => x.Category // Where is the condition 
        .Equals(userEntry, StringComparison.InvariantCultureIgnoreCase)) // equals user entry and ignoring case sensitivity
        .Select(x => x.Title) // of those results only selecting title
        .ToList();// Then create a list from that result. 
    Console.WriteLine($"These are the titles that match {userEntry}: ");
    foreach (string title in titles)
    {
        Console.WriteLine(title);
    }
    Console.WriteLine("do you want to check a different category? Y/N");
    var userDecicsion = Console.ReadLine();
    if (userDecicsion.Equals("Y", StringComparison.InvariantCultureIgnoreCase))
    {
       
    }
    else if (userDecicsion.Equals("N", StringComparison.InvariantCultureIgnoreCase))
    {
        continueLoop = false;
    }
       

}
public class movie
{
    public string Title { get; set; }
    public string Category { get; set; }

    // contructor method with 2 args 
    public movie(string title, string category)
    {
        Title = title;
        Category = category;
    }


}


