using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Auth_from_scratch.Models
{
    public class Usuario : IUser<short>
    {        
        public short Id {get; set;}
        public string UserName { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public bool Estatus { get; set; }
    }
}