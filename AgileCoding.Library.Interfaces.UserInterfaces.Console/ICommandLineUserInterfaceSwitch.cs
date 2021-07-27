namespace AgileCoding.Library.Interfaces.UserInterfaces.Console
{
    using System.Collections.Generic;
    using AgileCoding.Library.Interfaces.Logging;

    public interface ICommandLineUserInterfaceSwitch : IHelpOptionCharacters, IPrefixCommandCharacters
    {
        ILogger Logger { get; set; }

        List<ICommandLineUserInterface> UserInterfaces { get; set; }

        void RegisterUserInterface(ICommandLineUserInterface interfaceToRegister);

        void RegisterUserInterfaces(ICommandLineUserInterface[] interfacesToRegister);

        void ProcessCommandLineArgs(string[] args);
    }
}
