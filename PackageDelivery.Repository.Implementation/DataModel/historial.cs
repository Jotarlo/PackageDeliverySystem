//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PackageDelivery.Repository.Implementation.DataModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class historial
    {
        public long id { get; set; }
        public System.DateTime fechaIngreso { get; set; }
        public System.DateTime fechaSalida { get; set; }
        public string descripcion { get; set; }
        public Nullable<long> idPaquete { get; set; }
        public Nullable<long> idBodega { get; set; }
    
        public virtual bodega bodega { get; set; }
        public virtual paquete paquete { get; set; }
    }
}