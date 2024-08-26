using customConsole.Classes;

namespace customConsole.Commands
{
    public class HelpCommand : ICommandLogic
    {
        public void Execute(string[]? args = null)
        {
            displayAllCommands();
        }

        private void displayAllCommands()
        {
            string commands = "commands.txt";

            try
            {
                string content = File.ReadAllText(commands);
                content.Split(" ").ToList().ForEach(c => Console.WriteLine(c));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}