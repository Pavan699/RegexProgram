using System;
using System.Collections.Generic;
using System.Text;

namespace RegexProgram
{
    /// <summary>
    /// class for custom Exceptions inherited by Exception class
    /// </summary>
    public class CustomExcp : Exception
    {
        /// <summary>
        /// enums for the valid and invalid messages perpose
        /// </summary>
        public enum ExcpRegex
        {
            Invalid_Name,
            Null_String,
            Empty_String,
            Min_Length,
            Invalid_Phone_No,
            Invalid_Email,
            Wrong_Password
        }
        ExcpRegex excpRegex;
        /// <summary>
        /// Constructo for the Massege passing 
        /// </summary>
        /// <param name="excpRegex">object of the enum</param>
        /// <param name="massege">massege</param>
        public CustomExcp(ExcpRegex excpRegex, String massege) : base(massege)
        {
            this.excpRegex = excpRegex;
        }
    }
}
