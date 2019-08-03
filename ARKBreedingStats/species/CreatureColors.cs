﻿using System;
using System.Drawing;
using System.Linq;

namespace ARKBreedingStats.species
{
    static class CreatureColors
    {
        public static string creatureColorName(int colorId)
        {
            return values.Values.V.Colors.ByID(colorId).name;
        }

        public static Color creatureColor(int colorId)
        {
            return values.Values.V.Colors.ByID(colorId).color;
        }
    }
}
