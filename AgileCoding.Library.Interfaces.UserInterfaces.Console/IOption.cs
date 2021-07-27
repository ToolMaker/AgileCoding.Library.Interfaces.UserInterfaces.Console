namespace AgileCoding.Library.UserInterfaces.Console.Interfaces
{
    using System;

    public interface IOption : IHelpOptionCharacters, IPrefixCommandCharacters, IOptionNames
    {
        /// <summary>
        /// Function to validate anything including parameter criteria. No need to validate if required parameters are specified as this is done via the library.
        /// If this function is null then true is returned as there are no function to call. Also if this object is in IParameterList feel free to use the IParameterList.ValidationErrorMessage
        /// in the validation function to build error messages.
        /// </summary>
        Func<bool> ValidationFunction { get; set; }

        string ValidationErrorMessage { get; set; }

        bool IsRequired { get; set; }

        bool IsFlag { get; set; }

        StringComparison HelpKeyNameCaseComparrer { get; set; }
    }
}
