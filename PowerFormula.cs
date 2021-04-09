using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSUCalculator
{
    public static class PowerFormula
    {

        public static int PSURecommendedPower(Komputer komputer)
        {
            int RecommendedPower = Convert.ToInt32(Math.Ceiling(komputer.PurePower()*1.5D / 50)*50); //Batas aman PSU biasanya 150% dari beban TDP-TDP komponennya, Rekomendasi PSU merupakan kelipatan 50W (sesuai PSU dalam dunia nyata)
            return RecommendedPower;
        }
        public static double MonthlyPLNBill(Komputer komputer)
        {
            double PLNBill = 1444.70 * 30 * komputer.dailyUsage * komputer.PurePower() /1000 / komputer.efficiencyPSU; //Biaya bulanan dengan asumsi Rp1444,70/kWh, semakin besar efisiensi, semakin kecil biayanya (0<efisiensi<=1)
            return PLNBill;
        }
    }
}
