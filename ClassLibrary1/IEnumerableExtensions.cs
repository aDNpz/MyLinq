using System;
using System.Collections.Generic;

namespace MyLinq.Logic
{
    public static class IENumerableExtensions
    {
        public static IEnumerable<T> Filter<T>(this IEnumerable<T> source, Predicate<T> predicate)
        {
            source.CheckArgument(nameof(source));
            predicate.CheckArgument(nameof(predicate));

            var result = new List<T>();

            foreach (var item in source)
            {
                if (predicate(item))
                {
                    result.Add(item);
                }
            }
            return result;
        }

        public static IEnumerable<TResult> Map<T, TResult>(this IEnumerable<T> source, Func<T, TResult> mapping)
        {
            source.CheckArgument(nameof(source));
            mapping.CheckArgument(nameof(mapping));

            var result = new List<TResult>();

            foreach (var item in source)
            {
                result.Add(mapping(item));
            }
            return result;
        }

        public static IEnumerable<T> ForEach<T>(this IEnumerable<T> source, Action<T> action)
        {
            source.CheckArgument(nameof(source));
            if (action != null)
            {
                foreach (var item in source)
                {
                    action(item);
                }
            }
            return source;
        }

        public static IEnumerable<T> ToList<T>(this IEnumerable<T> source)
        {
            source.CheckArgument(nameof(source));

            return new List<T>(source);
        }

        public static IEnumerable<T> ToArray<T>(this IEnumerable<T> source)
        {
            source.CheckArgument(nameof(source));

            var result = new List<T>();

            foreach (var item in source)
            {
                result.Add(item);
            }

            return result.ToArray();
        }

        public static IEnumerable<double> doubleSum<T>(this IEnumerable<T> source, Func<T, double> transform)
        {
            source.CheckArgument(nameof(source));

            var result = new List<double>();
            foreach (var item in source)
            {
                result.Add(transform(item));
            }
            return result;


        }



    }
}
