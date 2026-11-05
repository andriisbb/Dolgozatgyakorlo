using System;
using System.Collections.Generic;
using System.Text;

namespace Dolgozatgyakorlo
{
    public static class KoltsegKalkulator
    {
        public static double BérletiDijKedvezmennyel(double alapAr, int napokSzama)
        {
            if( napokSzama< 6)
            {
                return (alapAr * napokSzama * 0.85);
            }
            else
            {
                return alapAr * napokSzama;
            }

        }

    }
}
