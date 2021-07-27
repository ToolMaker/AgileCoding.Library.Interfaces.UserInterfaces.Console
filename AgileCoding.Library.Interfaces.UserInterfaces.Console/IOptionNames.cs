namespace AgileCoding.Library.UserInterfaces.Console.Interfaces
{
    using System;
    using System.Collections.Generic;

    public interface IOptionNames
    {
        List<string> Keys { get; set; }

        int KeyIndex { get; set; }

        string Value { get; set; }

        List<string> KeysWithPrefixAdded { get; set; }

        StringComparison OptionNameCaseComparrer { get; set; }

        List<string> SampleValues { get; set; }
    }
}
