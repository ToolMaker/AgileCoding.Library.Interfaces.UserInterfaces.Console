namespace AgileCoding.Library.UserInterfaces.Console.Interfaces
{
    using System;
    using System.Collections.Generic;

    public interface ICommandLineUserInterface : IHelpOptionCharacters, IPrefixCommandCharacters
    {
        IOptionList Parameters { get; set; }

        Func<bool, List<IOption>> ValidateParameters { get; set; }

        string InterfaceName { get; set; }

        StringComparison InterfaceCaseComparrer { get; set; }

        void DoWork();

        void ProcessCommandLineArgs(string[] args);

        void InitializeParameters();
    }
}
