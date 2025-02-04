﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CustomStack
{
    public class StackOfStrings: Stack<string>
    {
        public bool IsEmpty()
        {
            return this.Count == 0;
        }

        public Stack<string> AddRange(IEnumerable<string> collection)
        {
            foreach (var item in collection)
            {
                this.Push(item);
            }

            return this;
        }
    }
}
