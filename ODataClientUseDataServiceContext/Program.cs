using System;
using System.Collections.Generic;
using System.Data.Services.Client;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODataClientUseDataServiceContext
{
    class Program
    {
        /* 此範例使用的是 full .net framework 4.5 */

        static void Main(string[] args)
        {
            string _baseAddress = "http://localhost:53314/";

            var _uri = new Uri(_baseAddress);

            DataServiceContext _context = new DataServiceContext(_uri);

        }
    }
}
