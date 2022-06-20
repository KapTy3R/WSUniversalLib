using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSUniversalLib
{
    public class Calculation
    {
        public static int GetQuantityForProduct(int productType, int materialType, int count, float width, float length)
        {
            int result = 0;
            double bMaterial=1, kProduct=1;
            if (productType > 3 || productType <= 0 || materialType > 2 || materialType <=0)            
            return -1;
            else
            {
                switch (materialType)
                {
                    case 1: bMaterial = 0.3; break;
                    case 2: bMaterial = 0.12; break;
                }

                switch (productType)
                {
                    case 1: kProduct = 1.1; break;
                    case 2: kProduct = 2.5; break;
                    case 3: kProduct = 8.43; break;
                }
                double temp = count*width*length * kProduct;
                result = Convert.ToInt32(Math.Ceiling(temp + ((temp * bMaterial) / 100.0)));
                return result;
            }
        }
    }
}
