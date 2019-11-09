using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos.Modelos;

namespace Modelos.Session
{
   public class Session : ISession
   {
      public string UserCodigo { get; set; }
      public string UserName { get; set; }
      public string UserNombreCompleto { get; set; }

      public string SucursalCodigo { get; set; }
      public string SucursalNombre { get; set; }
      public string VentanillaCodigo { get; set; }
      public string VentanillaDescripcion { get; set; }
      public TurnosModel Turno { get; set; }
      public string SucursalUbicacion { get; set; }
      public string SucursalCodigoBanco { get; set; }

      public List<RolesModel> UserRol { get; set; }
      public List<ComponenteModel> Componentes { get; set; }
    }
}
