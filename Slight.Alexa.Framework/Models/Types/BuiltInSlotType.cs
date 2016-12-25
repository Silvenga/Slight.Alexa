using System;

namespace Slight.Alexa.Framework.Models.Types
{
    public class BuiltInSlotType
    {
        /// <summary>
        /// Converts numeric words ("five") into digits (such as "5").
        /// </summary>
        public const string Number = "AMAZON.NUMBER";

        /// <summary>
        /// Converts words that indicate dates ("today", "tomorrow", or "july")
        /// into a date format (such as "2015-07-00T9").
        /// </summary>
        public const string Date = "AMAZON.DATE";

        /// <summary>
        /// Converts words that indicate time ("four in the morning", "two p m")
        /// into a time value ("04:00", "14:00").
        /// </summary>
        public const string Time = "AMAZON.TIME";

        /// <summary>
        /// Converts words that indicate durations ("five minutes") 
        /// into a numeric duration ("5M").
        /// </summary>
        public const string Duration = "AMAZON.DURATION";

        /// <summary>
        /// Provides handling for major cities in the United States. 
        /// 
        /// All cities with a population over 100,000 are included.
        /// </summary>
        public const string UsCity = "AMAZON.US_CITY";

        /// <summary>
        /// Maintained for backwards compatibility with skills produced 
        /// by earlier versions of the Alexa Skills Kit.
        /// </summary>
        [Obsolete("Use a custom slot type instead.")] public const string Literal = "AMAZON.LITERAL";
    }
}