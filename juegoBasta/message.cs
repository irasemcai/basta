//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace juegoBasta
{
    using System;
    using System.Collections.Generic;
    
    public partial class message
    {
        public int idMessage { get; set; }
        public int idUserMssg { get; set; }
        public int idConversationMssg { get; set; }
        public string message1 { get; set; }
        public System.DateTime dateMssg { get; set; }
    
        public virtual conversation conversation { get; set; }
        public virtual user user { get; set; }
    }
}
