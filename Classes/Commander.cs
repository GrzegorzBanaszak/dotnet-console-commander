namespace customConsole.Classes
{
    public class Commander
    {
        private List<Command> _commands = new List<Command>();

        public Commander()
        {
            addCommand(new Command("help", () => Console.WriteLine("list of commands")));
        }

        private void addCommand(Command command)
        {
            _commands.Add(command);
        }

        private Command? FindCommand(string name)
        {

            return _commands.Find(c => c.Name.Equals(name));

        }

        public void Start()
        {
            string? input = "";

            while (input != "exit")
            {

                Console.Write("$ ");
                input = Console.ReadLine();

                if (input == String.Empty)
                {
                    Console.Write("$ ");
                    input = Console.ReadLine();
                }

                if (input != null)
                {
                    Command? command = FindCommand(input);
                    if (command != null)
                    {
                        command.Execute();
                    }
                    else
                    {
                        Console.WriteLine("Command not found");
                    }
                }
            }
        }
    }
}