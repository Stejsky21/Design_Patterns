using System;
using System.Collections.Generic;
using System.Text;

namespace Navrhove_vzory
{
    class DataFactory
    {
        public IData GetData(int size)
        {
            if(size < 100)
            {
                return new MaleData();
            }
            else
            {
                return new VelkeData();
            }
        }
    }
}
