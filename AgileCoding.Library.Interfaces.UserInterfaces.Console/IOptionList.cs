namespace AgileCoding.Library.UserInterfaces.Console.Interfaces
{
    using System.Collections.Generic;
    using System.Text;

    public interface IOptionList : IList<IOption>
    {
        /// <summary>
        /// This is used to populate the validation error message when the validation of the value of the function parameter fails
        /// </summary>
        StringBuilder ValidationErrorMessage { get; set; }
    }
}
