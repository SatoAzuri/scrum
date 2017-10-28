using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1
{
    public class CitiesDataStore
    {
        public static CitiesDataStore Current { get; } = new CitiesDataStore();
        public List<CityDto> Cities { get; set; }

        public CitiesDataStore()
        {
            Cities = new List<CityDto>()
            {
                new CityDto()
                {
                    Id=1,
                    Name="Nastya",
                    Description="Awesome, Hot, Fun, Nice",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id=1,
                            Name = "Developer",
                            Description="Coding, front, back"
                        },
                         new PointOfInterestDto()
                        {
                            Id=2,
                            Name = "Mom",
                            Description="Kids, !Cook, Zumba"
                        }
                    }
                },
                new CityDto()
                {
                    Id=2,
                    Name="Pavan",
                    Description="Kind, Funny, Zen",
                     PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id=3,
                            Name = "Mentor",
                            Description="Help, Coding, Supervise"
                        },
                         new PointOfInterestDto()
                        {
                            Id=4,
                            Name = "Man",
                            Description="Girls, Drinks, Sport"
                        }
                    }
                },
                  new CityDto()
                {
                    Id=3,
                    Name="Gireesh",
                    Description="Smart, Fun, Leader",
                     PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id=5,
                            Name = "Leader",
                            Description="Motivated, Detail orientated, great commuticational skills"
                        }
                      
                    }
                }

            };

        }

    }
}
