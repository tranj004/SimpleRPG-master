using Engine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class World
    {
        private readonly List<Locations> _locations = new List<Locations>();

        internal void AddLocation(Locations location)
        {
            _locations.Add(location);
        }

        public Locations LocationAt(int xCoordinate, int yCoordinate)
        {
            foreach (Locations loc in _locations)
            {
                if (loc.XCoordinate == xCoordinate && loc.YCoordinate == yCoordinate)
                {
                    return loc;
                }
            }

            return null;
        }
    }
}
