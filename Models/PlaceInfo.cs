﻿using System.Collections.Generic;
using System.Windows;

namespace course.Models
{
    internal class PlaceInfo
    {
        public string Name { get; set; }

        public Point Location { get; set; }
        public IEnumerable<ConfirmedCount> Counts { get; set; }
    }


}


