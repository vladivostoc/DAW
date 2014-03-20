using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using pk3.Models;

namespace pk3.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult index()
        {

            return View();
        }

        
        public ViewResult AutoProperty()
        {
        //crear un objeto de la clase producto

           // Product myProduct = new Product(); //operador "new" y el constructor

            //establecer el valor de la propiedad
            
            /*myProduct.ProduvtID = 12;
            myProduct.Name = "Kayak";
            myProduct.Description = "Kioseka Blue";   //nombre del objeto, propiedad y valor
            myProduct.Category = "SPORTS";
            myProduct.Price = 12.5f;*/


            Product myProduct = new Product

            {
            ProduvtID = 12,
            Name = "Kayak",
            Description = "Kioseka Blue",  //nombre del objeto, propiedad y valor
            Category = "SPORTS",
            Price = 12.5f
            };
            
            //obtiene la propiedad

            string salida =
            String.Format("{0}-{1}-{2}-{3}-{4:C0}",
            myProduct.ProduvtID,
            myProduct.Name,
            myProduct.Description,
            myProduct.Category,
            myProduct.Price);


            //generar la vista

            return View("Results",
                (object)salida);

        }

        public ViewResult UseExtension()
        { 
        //creacion e inicializacionde Shoping cart (carrito de compras)
            ShopingCart cart = new ShopingCart
            {
                Products = new List<Product>
            {
            new Product{Name = "Kayak", Price = 350.0f},
            new Product{Name = "Lentes", Price = 1500.0f},
            new Product{Name = "Balon Football", Price = 50.0f},
            new Product{Name = "Disco Volador", Price = 130.0f},

            }
            };
            //Obtener el total de la compra
            double total = cart.TotalPrices();

            //renderear vista
            return View ("Results",
                (object)String.Format
                ("Total: {0:c}", total));

        }

         


        public ViewResult CreateCollection()
        {
       

            //Arrreglos de String
            string [] stringArray = { "manzana", "naranja", "lima" };

            //lista
            List<int> intList = new List<int> { 10, 20, 30, 40 };

            //Diccionario
            Dictionary<string, int> myDict = new Dictionary<string, int>
              {
              {"manzana", 10},
              {"naranja",20},
              {"lima",30}
              
        };
            return View("Results", (object)myDict["manzana"].ToString());
        }


    }
    

}
