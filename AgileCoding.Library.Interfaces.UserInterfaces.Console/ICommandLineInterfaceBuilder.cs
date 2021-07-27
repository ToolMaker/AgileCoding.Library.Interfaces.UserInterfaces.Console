namespace AgileCoding.Library.Interfaces.UserInterfaces.Console
{
    using AgileCoding.Library.Interfaces.Logging;

    public interface ICommandLineInterfaceBuilder
    {
        ICommandLineUserInterfaceSwitch UserInterfaceSwitch { get; set; }

        void InitializeCommandlineParamaters(ILogger logger);
    }
}
