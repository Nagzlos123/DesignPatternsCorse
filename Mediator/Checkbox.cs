﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class Checkbox : Component
    {
        public void Select()
        {
            Console.WriteLine("Checkbox selected");

            this._mediator.Notify(this, "checkbocSelected");
        }

        public void SaveValue()
        {
            Console.WriteLine("Checkbox value saved");
        }
    }
}
