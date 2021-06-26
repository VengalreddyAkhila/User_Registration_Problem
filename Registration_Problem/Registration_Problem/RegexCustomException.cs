using System;
using System.Collections.Generic;
using System.Text;

namespace Registration_Problem
{
    public class RegexCustomException : Exception
    {
        /// <summary>
        /// enum for exception type
        /// </summary>
        public enum InvalidUserDetails
        {
            NULL_MESSAGE, EMPTY_MESSAGE
        }
        //creating type variable of type exceptiontype
        private readonly InvalidUserDetails  type;

        ///<summary>
        ///parameterized  constructor sets the exception type and message
        ///</summary>
        public RegexCustomException(InvalidUserDetails  type, string message) : base(message)
        {
            this.type = type;
        }

    }
}
