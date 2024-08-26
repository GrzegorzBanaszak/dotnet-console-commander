

namespace customConsole.Classes
{
    public delegate void Execute();
    public class Command
    {
        public string Name { get; set; }
        private Execute Call { get; set; }

        public Command(string name, Execute call)
        {
            Name = name;
            Call = call;
        }



        public void Execute()
        {
            Call.Invoke();
        }
    }
}