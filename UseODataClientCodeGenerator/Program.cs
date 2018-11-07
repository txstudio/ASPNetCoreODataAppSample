using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseODataClientCodeGenerator
{
    class Program
    {
        /*
         * https://docs.microsoft.com/en-us/aspnet/web-api/overview/odata-support-in-aspnet-web-api/odata-v4/create-an-odata-v4-client-app
         * 
         * 安裝擴充套件
         * OData Client Code Generator
         * 
         * 安裝後關閉所有 Visual Studio 後會跳出詳細安裝畫面
         *      安裝完成後開啟 Visual Studio 套件就安裝完成
         * 
         * 專案中建立新項目
         *      選擇 "OData Client" 項目
         * 
         * 修改 *.tt 檔案中的
         * public const string MetadataDocumentUri = "";
         * 
         * 為 OData 服務的 URL 路徑 (http://url:port/odata/$metadata)
         * public const string MetadataDocumentUri = "http://localhost:53314/odata/$metadata";
         * 
         * 重新執行 *.tt 檔案
         */

        static void Main(string[] args)
        {
            string _requestUri = "http://localhost:53314/odata";

            var _container = new Default.Container(new Uri(_requestUri));
            var _totalCount = _container.Person.Count();

            var _persons = _container.Person.Where(x => x.FirstName == "Crystal" && x.LastName == "Huang");


            Console.WriteLine("total count: {0}", _totalCount);
            Console.WriteLine();
            Console.WriteLine("filter: FirstName=\"Crystal\"");

            foreach (var _person in _persons)
                Console.WriteLine(JsonConvert.SerializeObject(_person, Formatting.Indented));

            Console.WriteLine();
            Console.WriteLine("press any key to exit");
            Console.ReadKey();
        }
    }
}
