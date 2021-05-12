using System;

namespace DatingProfile
{
    class Program
    {
        static void Main(string[] args)
        {
            Profile daniel = new Profile("Daniel Copetillo",24,"Athens, GA","USA","he/him");
            string[] hobbies = { "making music", "movies", "friends", "mixologist" };
            daniel.SetHobbies(hobbies);
            Console.WriteLine(sam.ViewProfile());

        }
        
    }
}