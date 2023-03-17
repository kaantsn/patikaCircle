﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
    public class Action
    {
        public void DrawCircle(int radius)
        {

            for (double y = -radius; y <= radius; y++)
            {
                for (double x = -radius; x <= radius; x += 0.5)
                {
                    if ((x * x) + (y * y) >= radius * radius)
                    {
                        Console.Write("-");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

            
        }
    }
}
