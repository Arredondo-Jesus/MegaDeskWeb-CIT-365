using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MegaDeskW
{
    public class Desk
    {
        public int width { get; set; }
        public int depth { get; set; }
        public int drawwers { get; set; }
        public int surface { get; set; }
        public enum material {
            Oak = 200,
            Laminate = 100,
            Pine = 50,
            Rossewood = 300,
            Veneer = 150
        };

        public string calculateSurface(int width, int depth) {
            int surface = depth * width;
            return surface.ToString();
        }
    }
}