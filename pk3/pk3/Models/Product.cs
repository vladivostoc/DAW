using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace pk3.Models
{
    public class Product
    {
        public int ProduvtID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float Price {get; set; }
        public string Category {get; set; }

    }
    }

// private string name;//atributo primario
//public string Name//propiedad 
  
//get {return name; }//permiten asignar valores de una manera controlada
//set {name = value;}