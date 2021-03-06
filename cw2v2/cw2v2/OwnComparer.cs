﻿using System;
using System.Collections.Generic;
using System.Text;

namespace cw2v2
{
    public class OwnComparer : IEqualityComparer<Student>
    {

        public bool Equals(Student x, Student y)
        {
            return StringComparer
                .InvariantCultureIgnoreCase
                .Equals($"{x.FirstName} {x.LastName} {x.IndexNumber}",
                $"{y.FirstName} {y.LastName} {y.IndexNumber}");
        }

        public int GetHashCode(Student obj)
        {
            return StringComparer
                .CurrentCultureIgnoreCase
                .GetHashCode($"{obj.FirstName} {obj.LastName} {obj.IndexNumber}");
        }
    }
}