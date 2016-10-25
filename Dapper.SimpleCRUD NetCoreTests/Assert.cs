using System;
using System.Collections.Generic;
using System.Linq;

namespace Dapper.SimpleCRUD_NetCoreTests
{
    /// <summary>
    /// Assert extensions borrowed from Sam's code in DapperTests
    /// </summary>
    static class Assert
    {
        public static void IsEqualTo<T>(this T obj, T other)
        {
            Xunit.Assert.Equal(obj, other);
        }

        public static void IsSequenceEqualTo<T>(this IEnumerable<T> obj, IEnumerable<T> other)
        {
            Xunit.Assert.Equal(obj, other ?? new T[0]);
        }

        public static void IsFalse(this bool b)
        {
            Xunit.Assert.False(b);
        }

        public static void IsTrue(this bool b)
        {
            Xunit.Assert.True(b);
        }

        public static void IsNull(this object obj)
        {
            Xunit.Assert.Null(obj);
        }

    }
}