﻿using Modelos.Modelos;
using System.ServiceModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiciosBancarios.Backend
{
    [ServiceContract]
    interface IComponenteService
    {
        [OperationContract]
        bool Componente_Crear(ComponenteModel aComponente, int id_user);

        [OperationContract]
        bool Componente_Editar(ComponenteModel aComponente, int id_user);

        [OperationContract]
        bool Componente_Eliminar(int aID_Componente);

        [OperationContract]
        ComponenteModel Componente_ObtenerUno(int aID_Componente);

        [OperationContract]
        List<ComponenteModel> Componente_ObtenerTodos();

        [OperationContract]
        List<ComponenteModel> Componente_ObtenerComponentesRol(int aID_Rol);

        [OperationContract]
        List<ComponenteModel> ObtenerTodosComponentes();
        

    }
}
