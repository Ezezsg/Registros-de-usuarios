using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Registros_de_usuarios.Models
{
    public class SignIn
    {
        [Required(ErrorMessage = "<font color='red'>El nombre es requerido</font>")]
        [Display(Name = "Nombre")]
        public String Name { get; set; }

        [Required(ErrorMessage = "<font color='red'>El apellido es requerido</font>")]
        [Display(Name = "Apellido")]
        public String LastName { get; set; }

        [Required(ErrorMessage = "<font color='red'>El usuario es requerido</font ")]
        [Display(Name = "Usuario")]
        public String User { get; set; }

        [EmailAddress]
        [Required(ErrorMessage = "<font color='red'>El email es requerido</font>")]
        [Display(Name = "Correo electrónico")]
        public String Email { get; set; }

        [StringLength(100, ErrorMessage = "<font color='red'>El número de caracteres de {0} debe ser al menos {2}.</font>", MinimumLength = 3)]
        [Required(ErrorMessage = "<font color='red'>El password es requerido</font>")]
        [Display(Name = "Contraseña")]
        public String Password { get; set; }

        UserDataDataContext user = new UserDataDataContext();
        Users obj = new Users();

        public bool signIn()
        {
            var query = from u in user.Users
                        where u.Email == Email ||
                        u.UserName == User
                        select u;
            if (query.Count() > 0)
            {
                return false;
            }
            else
            {
                obj.Name = Name;
                obj.LastName = LastName;
                obj.UserName = User;
                obj.Email = Email;
                obj.Password = Password;

                user.Users.InsertOnSubmit(obj);
                user.SubmitChanges();
                return true;
            }
        }
    }
}