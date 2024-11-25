using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class ProductManager
    {
        //Encapsulation,BİRDEN FAZLA PARAMETRE İLE ÜRÜNÜ ALMAK YERİNE DİREKT NESNEYİ ALMAK VE ATTRİBUTELARINA ULAŞMAK
        public void Add(Product product)
        {
            //Referans atama 
            //product.ProductName = "Kamera";   
            Console.WriteLine(product.ProductName + " Eklendi.");

        }
         
        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " Güncellendi.");
        }

     


    }
}
