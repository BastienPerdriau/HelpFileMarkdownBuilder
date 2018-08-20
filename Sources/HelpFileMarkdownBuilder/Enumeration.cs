using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace HelpFileMarkdownBuilder
{
    /// <summary>
    /// Base class for custom enumerations
    /// </summary>
    public class Enumeration : IComparable
    {
        /// <summary>
        /// Key
        /// </summary>
        public int Key { get; internal set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="key">Key</param>
        protected Enumeration(int key)
        {
            Key = key;
        }

        /// <summary>
        /// Gets a list of available values
        /// </summary>
        /// <returns>List of values</returns>
        public static IEnumerable<T> List<T>() where T : Enumeration
        {
            FieldInfo[] fields = typeof(T).GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly);

            return fields.Select(f => f.GetValue(null)).Cast<T>();
        }

        /// <summary>
        /// Gets a dictionary of available values keyed by key
        /// </summary>
        /// <returns>Dictionary of values</returns>
        public static IDictionary<int, T> Dictionary<T>() where T : Enumeration
        {
            return List<T>().ToDictionary(l => l.Key);
        }

        /// <summary>
        /// Gets a value by it key
        /// </summary>
        /// <param name="key">Key</param>
        /// <returns>Value</returns>
        public static T FromKey<T>(int key) where T : Enumeration
        {
            return List<T>().Single(l => l.Key == key);
        }

        /// <summary>
        /// Determines whether two object instances are equal
        /// </summary>
        /// <param name="obj">The object to compare with the current object</param>
        /// <returns>True if the specified object is equal to the current object; otherwise, False</returns>
        public override bool Equals(object obj)
        {
            var otherValue = obj as Enumeration;
            if (otherValue == null)
            {
                return false;
            }
            var typeMatches = GetType().Equals(obj.GetType());
            var valueMatches = Key.Equals(otherValue.Key);
            return typeMatches && valueMatches;
        }

        /// <summary>
        /// Serves as the default hash function
        /// </summary>
        /// <returns>A hash code for the current object</returns>
        public override int GetHashCode()
        {
            return Key.GetHashCode();
        }

        /// <summary>
        /// Compares the current instance with another object of the same type and returns an integer that indicates whether the current instance precedes, follows, or occurs in the same position in the sort order as the other object
        /// </summary>
        /// <param name="obj">An object to compare with this instance</param>
        /// <returns>A value that indicates the relative order of the objects being compared</returns>
        public int CompareTo(object obj)
        {
            return Key.CompareTo(((Enumeration)obj).Key);
        }
    }
}
