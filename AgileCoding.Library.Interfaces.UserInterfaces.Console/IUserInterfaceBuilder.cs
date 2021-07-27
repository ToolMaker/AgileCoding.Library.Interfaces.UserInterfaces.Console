namespace AgileCoding.Library.Interfaces.UserInterfaces.Console
{
    using AgileCoding.Library.Interfaces.Logging;

    public interface IUserInterfaceBuilder
    {
        ICommandLineUserInterface BuildUserInterface(ILogger logger, string[] helpKeys, char?[] optionPrefixes);
    }
}
