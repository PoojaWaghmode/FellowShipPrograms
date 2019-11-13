// --------------------------------------------------------------------------------------------------------------------
// <copyright file=StringReplace.cs" company="Bridgelabz">
// Copyright © 2019 Company
// </copyright>
// <creator name="Pooja Waghmode"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Basic_Programs
{
    using System;
    /// <summary>
    /// This class For Replace The String Template
    /// </summary>
    class StringReplace
    {
        
        /// This Method Takes Input String and calls the method which will replace the template
        public void ReplaceString()
        {
            Utility u = new Utility();
            String str = "Hello <<Username>>,How Are You ?";
            Console.WriteLine(str);
            Utility.ReplaceTemplate(str);
        }
        
    }
}
