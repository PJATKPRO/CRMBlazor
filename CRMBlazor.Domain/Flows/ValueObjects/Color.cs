using CRMBlazor.Domain.Base.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRMBlazor.Domain.Flows.ValueObjects
{
    public sealed class Color : ValueObject
    {
        public int R { get; }
        public int G { get; }
        public int B { get; }


        public static Color Create(int r, int g, int b)
        {
            return new Color(r, g, b);
        }

        /// <summary>
        /// Formats <see cref="Color"/> to rgb string
        /// </summary>
        /// <returns>Ex. rgb(12,12,12)</returns>
        public override string ToString()
        {
            return $"rgb({R},{G},{B})";
        }

        private Color(int r, int g, int b)
        {
            R = r;
            G = g;
            B = b;
        }

        public override IEnumerable<object> GetEqualityComponents()
        {
            yield return R;
            yield return G;
            yield return B;
        }
        private Color() { }
    }
}
