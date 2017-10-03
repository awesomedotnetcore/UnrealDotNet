﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generator.Metadata
{
    public class Delegate : Type
    {
        public List<Variable> Parametrs { get; set; }

        public Delegate(string Name)
        {
            Parametrs = new List<Variable>();
            this.Name = Name;
        }

        public IEnumerable<Type> Dependent
        {
            get
            {
                return Parametrs.Select(x => x.Type).Distinct();
            }
        }
    }
}
