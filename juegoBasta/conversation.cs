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
    
    public partial class conversation
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public conversation()
        {
            this.messages = new HashSet<message>();
            this.userConversations = new HashSet<userConversation>();
        }
    
        public int idConversation { get; set; }
        public System.DateTime dateConversation { get; set; }
        public int idTypeChat { get; set; }
    
        public virtual typeChat typeChat { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<message> messages { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<userConversation> userConversations { get; set; }
    }
}