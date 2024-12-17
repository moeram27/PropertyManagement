using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Utils
{
    public static class IdGenerator
    {
        private static int propertyId = 0;  
        private static int buyerId = 0;     


        public static int NextPropertyId()
        {
            return ++propertyId;
        }

        
        public static int NextBuyerId()
        {
            return ++buyerId; 
        }
    }
    
}
