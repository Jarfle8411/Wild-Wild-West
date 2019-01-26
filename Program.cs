using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WildWest
{
    class Shootout
    {
        static void Main(string[] args)
        {
            //Private Static void method
            //IntroductionIntoTheStory();
            //instance of public class sheriff and gunfighter
            Sheriff Columbia = new Sheriff();
            Sheriff Orangeburg = new Sheriff();
            Gunfighters ColumbiaGF = new Gunfighters();
            Gunfighters OrangeburgGF = new Gunfighters();
        }
        // Public class sheriff with variables
        public class Sheriff
        {
            int eyes, feet, hands;
            string name, emotions, conversation;
        }
        // Public class sheriff with variables
        public class Gunfighters
        {
            int eyes, feet, hands;
            string name, emotions, conversation;
        }
        // Public calss Introduction Into the Story method - method
        // with an array of elements listed inside of the method
        // which gets passed to the calling method in the main method - method
        public static void IntroductionIntoTheStory()
        {
            string[] storyline = { "Back in the days",
                                 "of the old west",
                                 "things were a bit",
                                 "disorderly to say",
                                 "the least. It did",
                                 "not take much to start a fight...",
                                 "This is a storyline of such of a event.",
                                 "The story law and gunfighters",
                                 "were often at odds. This",
                                 "is one account of such an event."
                                 };
            // foreach method which reads the array 
            // and prints the values to the console.
            foreach (string value in storyline)
            {
                Console.WriteLine("{0}",value);
            }
        }
    }
}
