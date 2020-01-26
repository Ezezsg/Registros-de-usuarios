using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Registros_de_usuarios.Models
{
    public class UserLogin
    {
        [EmailAddress]
        [Required(ErrorMessage = "<font color='red'>El email es requerido</font>")]
        [Display(Name = "Correo electrónico")]
        public String Email { get; set; }

        [StringLength(100, ErrorMessage = "El número de caracteres de {0} debe ser al menos {2}.</font>", MinimumLength = 3)]
        [Required(ErrorMessage = "<font color='red'>El password es requerido</font>")]
        [Display(Name = "Contraseña")]
        public String Password { get; set; }

        public String userName { get; set; }

        UserDataDataContext user = new UserDataDataContext();

        public bool login()
        {
            var query = from u in user.Users
                        where u.Email == Email && u.Password == Password
                        select u;
            if (query.Count() > 0)
            {
                //var query2 = from u in user.Users where u.Email == Email select u;
                var datos = query.ToList();
                foreach (var Data in datos)
                {
                    userName = Data.UserName;
                }
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}