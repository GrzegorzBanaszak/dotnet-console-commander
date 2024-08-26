

namespace customConsole.Classes
{
    public class Command : ICommand
    {
        private string _name;
        //Logika funkcji
        private ICommandLogic _logic;
        public string Name { get { return _name; } }

        public ICommandLogic Logic => _logic;

        public Command(string name, ICommandLogic logic)
        {
            _name = name;
            _logic = logic;
        }


        //Wywołanie logiki
        public void Execute(string[]? args = null)
        {
            _logic.Execute(args);
        }
    }
}