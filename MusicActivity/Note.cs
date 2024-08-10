using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MusicActivity
{
    public class Note
    {
        public string Pitch { get; set; } // The pitch of the note (e.g., "C", "D#", "G")
        public int Duration { get; set; } // The duration of the note in milliseconds
        public Note Next { get; set; } // Reference to the next note in the circular linked list

        public Note(string pitch, int duration)
        {
            Pitch = pitch;
            Duration = duration;
        }
    }

    // Class to manage the circular linked list of notes
    public class CircularLinkedList
    {
        public Note Head { get; set; } // The first note in the list

        public void AddNote(string pitch, int duration)
        {
            var newNote = new Note(pitch, duration);

            if (Head == null)
            {
                Head = newNote;
                Head.Next = Head; // Points to itself, making the list circular
            }
            else
            {
                var current = Head;
                while (current.Next != Head)
                {
                    current = current.Next;
                }
                current.Next = newNote;
                newNote.Next = Head; // Points to the head, completing the circle
            }
        }

        public void PlayNotes()
        {
            var current = Head;
            if (current == null) return;

            do
            {
                Console.WriteLine($"Playing note: {current.Pitch} for {current.Duration} ms");
                Thread.Sleep(current.Duration); // Pause for the duration of the note
                current = current.Next; // Move to the next note
            } while (true); // Loop indefinitely
        }
    }
}
