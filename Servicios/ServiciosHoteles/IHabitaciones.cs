﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ServiciosHoteles.Dominio;

namespace ServiciosHoteles
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IHabitaciones" in both code and config file together.
    [ServiceContract]
    public interface IHabitaciones
    {
        [OperationContract]
        List<Habitacion> ListarHabitacion();
    }
}
