using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiCommsP6
{
    public class Action
    {
        public Action(string title, Color color)
        {
            Title = title;
            Color = color;
        }

        public string Title { get; }
        public Color Color { get; }
    }
}
