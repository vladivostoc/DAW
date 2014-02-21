using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace Pk2_RSVPwapp.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage="Por favor introduzca su nombre")]
        public string Name { get; set;}

         [Required(ErrorMessage = "Por favor introduzca su correo elctronico")]
        [RegularExpression(".+\\@.+\\..+",ErrorMessage="ingresa una cuenta de correo valida")]
        public string Email { get; set;}

         [Required(ErrorMessage = "Por favor introduzca su numero telefonico")]
        public string Phone { get; set;}

         [Required(ErrorMessage = "Por favor indique si asistira ono")]
        public bool? WillAttend { get; set;}
    }
}