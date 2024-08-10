using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicActivity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var playlist = new CircularLinkedList();

            // Add notes to the circular linked list
            playlist.AddNote("C", 500);
            playlist.AddNote("D", 500);
            playlist.AddNote("E", 500);
            playlist.AddNote("F", 500);
            playlist.AddNote("G", 500);

            // Start playing the notes in an infinite loop
            playlist.PlayNotes();

            // The program will continuously loop, so the console will remain open
            // To stop the program, you would typically press CTRL+C or close the console window
        }
    }
}
