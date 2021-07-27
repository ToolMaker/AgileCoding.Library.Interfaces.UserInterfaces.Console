namespace AgileCoding.Library.UserInterfaces.Console.Interfaces
{
    using AgileCoding.Library.Interfaces.Logging;

    public interface IUserInterfaceBuilder
    {
        ICommandLineUserInterface BuildUserInterface(ILogger logger, string[] helpKeys, char?[] optionPrefixes);
    }
}
