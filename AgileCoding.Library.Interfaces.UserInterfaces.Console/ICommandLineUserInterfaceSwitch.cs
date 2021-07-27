namespace AgileCoding.Library.Interfaces.UserInterfaces.Console
{
    using System.Collections.Generic;

    public interface ICommandLineUserInterfaceSwitch : IHelpOptionCharacters, IPrefixCommandCharacters
    {
        List<ICommandLineUserInterface> UserInterfaces { get; set; }

        void RegisterUserInterface(ICommandLineUserInterface interfaceToRegister);

        void RegisterUserInterfaces(ICommandLineUserInterface[] interfacesToRegister);

        void ProcessCommandLineArgs(string[] args);
    }
}
