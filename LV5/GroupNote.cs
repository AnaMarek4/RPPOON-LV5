using System;
using System.Collections.Generic;
using System.Text;

namespace LV5
{
    class GroupNote : Note
    {
        private List<string> members = new List<string>();

        public GroupNote(string message, ITheme theme) : base(message, theme) { }

        public override void Show()
        {
            this.ChangeColor();
            Console.WriteLine("REMINDER: ");
            string framedMessage = this.GetFramedMessage();
            Console.WriteLine(framedMessage);
            Console.ResetColor();
            foreach(string people in members)
            {
                Console.WriteLine(people + ", ");
            }
        }

        public void AddMember(string addedMember)
        {
            members.Add(addedMember);
        }

        public void DeleteMember(string deletedMember)
        {
            for(int i = 0; i < members.Count; i++)
            {
                if(members[i] == deletedMember)
                {
                    members.RemoveAt(i);
                }
            }
        }
    }
}
