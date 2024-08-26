namespace customConsole.Classes
{


    public interface ICommand
    {
        string Name { get; }
        ICommandLogic Logic { get; }
        void Execute(string[]? args);
    }
}