using System;
using System.Collections;
namespace HandsOnNonGenericCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie movie = new Movie()
            {
                MovoieId = 13232,
                MovieName = "Titanic",
                Year = 2000,
                Artists = new ArrayList() 
                { "Artist1", "Artist2", "Artist3" }
            
            };
        }
    }
}
