
using CDatos.Manager;
using Modelos.Modelos;
using System.Collections.Generic;

namespace CNegocio.Ventanilla
{
    public class VentanillaMethods
    {
        private VentanillaManager ADVentanillaManager;

        public VentanillaMethods()
        {
            ADVentanillaManager = new VentanillaManager();
        }
        public bool Crear(VentanillaModel aVentanilla, int id_user)
        {
            return ADVentanillaManager.Insert(aVentanilla, id_user);
        }

        public bool Editar(VentanillaModel aVentanilla, int id_user)
        {
            return ADVentanillaManager.Update(aVentanilla, id_user);
        }

        public bool Eliminar(int aID_VentanillaModel)
        {
            return ADVentanillaManager.Delete(aID_VentanillaModel);
        }

        public VentanillaModel ObtenerUno(int aID_VentanillaModel)
        {
            return ADVentanillaManager.GetVentanillaModel(aID_VentanillaModel);
        }
        public VentanillaModel ObtenerUnoXUsuario(int Id_Usuario)
        {
            return ADVentanillaManager.GetVentanillaModelxUsuario(Id_Usuario);
        }

        public List<VentanillaModel> ObtenerTodos()
        {
            return ADVentanillaManager.VentanillaModelSelectAll();
        }
        public List<VentanillaModel> ObtenerVentanillasXSucursal(int sucursal, int turno)
        {
            return ADVentanillaManager.GetVentanillasXSucursal(sucursal,turno);
        }
        public List<string> GenerarDocumento()
        {
            GenerarDocumentoManager generarDocumentoManager = new GenerarDocumentoManager();
            return  generarDocumentoManager.GenerarDocumento();
        }
    }

}