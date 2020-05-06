using System;
using System.Collections.Generic;
using System.Text;

namespace LV5
{
    interface IBillable
    {
        double Price { get; }
        string Description(int depth = 0);
    }
}
