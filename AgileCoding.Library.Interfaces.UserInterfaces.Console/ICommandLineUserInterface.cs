namespace AgileCoding.Library.Interfaces.UserInterfaces.Console
{
    using AgileCoding.Library.Interfaces.Logging;
    using System;
    using System.Collections.Generic;

    public interface ICommandLineUserInterface : IHelpOptionCharacters, IPrefixCommandCharacters
    {
        IOptionList Parameters { get; set; }

        Func<bool, List<IOption>> ValidateParameters { get; set; }

        string InterfaceName { get; set; }

        StringComparison InterfaceCaseComparrer { get; set; }

        Action<ILogger> DoWork { get; set; }

        void ProcessCommandLineArgs(string[] args);

        void InitializeParameters();
    }
}
