using System;
using System.Collections.Generic;
using System.Text;

namespace LV5
{
    class Notebook
    {
        private List<Note> notes;
        ITheme groupTheme; 

        public Notebook(ITheme newTheme)
        {
            this.notes = new List<Note>();
            groupTheme = newTheme;
        }

        public void AddNote(Note note)
        {
            this.notes.Add(note);
            note.Theme = groupTheme;
        }

        public void ChangeTheme(ITheme theme)
        {
            foreach (Note note in this.notes)
            {
                note.Theme = theme;
            }
        }

        public void Display()
        {
            foreach (Note note in this.notes)
            {
                note.Show();
                Console.WriteLine("\n");
            }
        }
    }
}
