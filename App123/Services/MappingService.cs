using App123.Models;
using App123.Services.Inter;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms.Maps;

namespace App123.Services
{
    public class MappingService: IMapping
    {
        public Location GetNewLocation()
        {
            var myLocation = new Location("Address- CHANGE", "Description-CHANGE", new Position());
            return myLocation;
        }
    }
}
