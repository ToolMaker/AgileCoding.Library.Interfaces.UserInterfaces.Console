namespace AgileCoding.Library.Interfaces.UserInterfaces.Console
{
    using System.Collections.Generic;

    public interface IPrefixCommandCharacters
    {
        /// <summary>
        /// Samples: '/','-' 
        /// If a character is null then it means there is NO prefix
        /// </summary>
        List<char?> PreFixChars { get; set; }
    }
}
