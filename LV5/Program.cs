using System;

namespace LV5
{
    class Program
    {
        static void Main(string[] args)
        {
            VirtualProxyDataset virtualDataset = new VirtualProxyDataset("csv.txt");
            User user = User.GenerateUser("Ana");
            ProtectionProxyDataset protectionDataset = new ProtectionProxyDataset(user);
            DataConsolePrinter printer = new DataConsolePrinter();
            printer.PrintDataConsole(virtualDataset);
            printer.PrintDataConsole(protectionDataset);

            CoralTheme coral = new CoralTheme();
            ReminderNote note = new ReminderNote("It's time for vacation!", coral);
            note.Show();

            GroupNote groupNoteOne = new GroupNote("Winter is coming.", coral);
            for(int i = 0; i < 5; i++)
            {
                string newMember = Console.ReadLine();
                groupNoteOne.AddMember(newMember);
            }
            groupNoteOne.Show();

            LightTheme light = new LightTheme();
            GroupNote groupNoteTwo = new GroupNote("Winter is here.", light);
            for (int i = 0; i < 5; i++)
            {
                string newMember = Console.ReadLine();
                groupNoteOne.AddMember(newMember);
            }
            groupNoteTwo.Show();

            Notebook notebook = new Notebook(coral);
            notebook.AddNote(groupNoteOne);
            notebook.AddNote(groupNoteTwo);
            notebook.ChangeTheme(coral);
            notebook.Display();
        }
    }
}
