namespace AgileCoding.Library.UserInterfaces.Console.Interfaces
{
    using AgileCoding.Library.Interfaces.Logging;

    public interface ICommandLineInterfaceBuilder
    {
        ICommandLineUserInterfaceSwitch UserInterfaceSwitch { get; set; }

        void InitializeCommandlineParamaters(ILogger logger);
    }
}
