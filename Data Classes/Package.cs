using System;
using System.Collections.Generic;

namespace CSharp_CheatSheet
{
    public class Package
    {
        public string Company { get; set; }
        public double Weight { get; set; }
        public long TrackingNumber { get; set; }

        public static List<Package> GetAllPackage()
        {
            return new List<Package>()
            {
                new Package { Company = "Coho Vineyard", Weight = 25.2 },
                new Package { Company = "Lucerne Publishing", Weight = 18.7 },
                new Package { Company = "Wingtip Toys", Weight = 6.0 },
                new Package { Company = "Adventure Works", Weight = 33.8 },
                new Package { Company = "Mucho Sodas", Weight = 14.9, TrackingNumber = 89453312L },
                new Package { Company = "Weirdos Chocolatz", Weight = 8.3, TrackingNumber = 89112755L },
                new Package { Company = "Cyan Pencils", Weight = 2.0, TrackingNumber = 299456122L },
                new Package { Company = "Hunter Weaponery", Weight = 9.2, TrackingNumber = 4665518773L }
            };
        }
    }
}


