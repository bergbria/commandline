﻿// Copyright 2005-2015 Giacomo Stelluti Scala & Contributors. All rights reserved. See doc/License.md in the project root for license information.

using System;
using System.Globalization;

namespace CommandLine.Infrastructure
{
    internal static class StringExtensions
    {
        public static string ToOneCharString(this char c)
        {
            return new string(c, 1);
        }

        public static string ToStringInvariant<T>(this T value)
        {
            return Convert.ToString(value, CultureInfo.InvariantCulture);
        }

        public static string FormatInvariant(this string value, params object[] arguments)
        {
            return string.Format(CultureInfo.InvariantCulture, value, arguments);
        }

        public static string FormatLocal(this string value, params object[] arguments)
        {
            return string.Format(CultureInfo.CurrentCulture, value, arguments);
        }

        public static string Spaces(this int value)
        {
            return new string(' ', value);
        }

        public static bool EqualsOrdinal(this string strA, string strB)
        {
            return string.CompareOrdinal(strA, strB) == 0;
        }

        public static int SafeLength(this string value)
        {
            return value == null ? 0 : value.Length;
        }

        public static string JoinTo(this string value, string[] others)
        {
            return string.Join(string.Empty, others);
        }
    }
}