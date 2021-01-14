using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ListViewAppMVOP.Model
{
    class Bodies
    {
        public ObservableCollection<Body> AllBodies { get; set; }

        public Bodies()
        {
            AllBodies = new ObservableCollection<Body>();
            AllBodies.Add(new Body { Name = "Merkur", Gravity = "3,701 m / s²" });
            AllBodies.Add(new Body { Name = "Venuše", Gravity = "8,87 m/s²" });
            AllBodies.Add(new Body { Name = "Země", Gravity = "9,807 m / s²" });
            AllBodies.Add(new Body { Name = "Mars", Gravity = "3,711 m/s²" });
            AllBodies.Add(new Body { Name = "Jupiter", Gravity = "23,12  m / s²" });
            AllBodies.Add(new Body { Name = "Saturn", Gravity = "8,96 m/s² m / s²" });
            AllBodies.Add(new Body { Name = "Uran", Gravity = "8,69 m/s² m / s²" });
            AllBodies.Add(new Body { Name = "Neptun", Gravity = "11,15 m / s²" });
        }
    }
}
