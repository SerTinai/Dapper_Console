using System;
using ConsoleApp1.Repostory;
using Json_Csharp.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace Json_Csharp
{
    internal class Program
    {
        internal static void Main(string[] args)
        {
          
            BrandRepository brandRepository = new BrandRepository();
            List<Brand> dataListBrand =  brandRepository.GetDatalist();
            string jsonDataBrand = JsonConvert.SerializeObject(dataListBrand);

            List<Brand> brands = JsonConvert.DeserializeObject<List<Brand>>(jsonDataBrand);
            List<Brand> JsonDataReadBrand = brands;

            List<Product> dataListProduct = new ProductRepository().GetDataList();
            string jsonDataListProduct = JsonConvert.SerializeObject(dataListProduct);
            string jsonDataProduct = JsonConvert.SerializeObject(dataListProduct[0]);

            Console.WriteLine(dataListProduct);
            Console.WriteLine(jsonDataListProduct);
            Console.WriteLine(jsonDataProduct);
            

            Console.ReadLine();
        }
    }
}
