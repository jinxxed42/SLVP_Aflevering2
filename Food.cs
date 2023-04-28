using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLVP_Aflevering2
{
    internal class Food
    {
        public string Name { get; private init; }
        public string Category { get; private init; }

        public double AgricultureCO2 { get; private init; }

        public double ILUCCO2 { get; private init; }

        public double ProductionCO2 { get; private init; }

        public double PackagingCO2 { get; private init; }

        public double TransportCO2 { get; private init; }

        public double StoreCO2 { get; private init; }

        public double CO2 { get; private set; }

        public Food(string name, string category, double agricultureCO2, double ilucCO2, double productionCO2, double packagingCO2, double transportCO2, double storeCO2)
        {
            Name = name;
            Category = category;
            AgricultureCO2 = agricultureCO2;
            ILUCCO2 = ilucCO2;
            ProductionCO2 = productionCO2;
            PackagingCO2 = packagingCO2;
            TransportCO2 = transportCO2;
            StoreCO2 = storeCO2;
            CalcCO2();
        }


        public void CalcCO2()
        {
            // Limiting to 2 decimal places since all values on the climate database is with at most 2 decimals.
            // This also hides the minor lack precision from adding multiple doubles together.
            CO2 = Math.Round(AgricultureCO2 + ILUCCO2 + ProductionCO2 + PackagingCO2 + TransportCO2 + StoreCO2, 2);
        }
    }
}
