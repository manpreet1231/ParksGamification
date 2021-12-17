using System;
using System.Collections.Generic;
using System.Text;

namespace Parks_Gamification.Models
{
    internal class Park
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Dimention Size { get; set; }

        public Location Address { get; set; } = new Location();
        public List<Amenity> Amenities { get; set; } = new List<Amenity>();

        public class Dimention
        {
           
            public string Width { get; set; }
            public string Length { get; set; }
            public string Height { get; set; }

        }


        public class Amenity {
            public Types Type { get; set; }
            public string Quantity { get; set; }
            public string Description { get; set; }

            public enum Types
            { 
                Swing,
                Slide,
                MonkeyBars,
                Bathroom,
                Pool,
                SkatePark,
                IceRink,
                SplashPad
            }
/*
            public enum Status
            {
                NotStarted = 0,
                Started = 1,
                Finished = 2
            }

            public enum Response
            {
                Success = 200,
                Redirect = 300,
                NotFound = 400
            }*/
        }

        public class Location
        {
            public int Number { get; set; }
            public string Street { get; set; }
            public string City { get; set; }
            public string Province { get; set; }
            public string PostalCode { get; set; }
            public string Country { get; set; }
        }
    }
}
