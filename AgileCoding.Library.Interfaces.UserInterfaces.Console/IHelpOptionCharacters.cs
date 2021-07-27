namespace AgileCoding.Library.Interfaces.UserInterfaces.Console
{
    using System;
    using System.Collections.Generic;

    public interface IHelpOptionCharacters
    {
        /// <summary>
        /// Samples: ?,help or h
        /// </summary>
        List<string> HelpKeys { get; set; }

        List<string> HelpKeysWithPrefixAdded { get; set; }

        StringComparison HelpKeyNameCaseComparrer { get; set; }

        Func<string> HelpDescriptionStringFunction { get; set; }
    }
}
