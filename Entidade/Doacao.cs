//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entidade
{
    using System;
    using System.Collections.Generic;
    
    public partial class Doacao
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Doacao()
        {
            this.ProdutoDoacao = new HashSet<ProdutoDoacao>();
            this.PedidoAjudaDoacao = new HashSet<PedidoAjudaDoacao>();
        }
    
        public int IdDoacao { get; set; }
        public Nullable<int> IdLocalEntrega { get; set; }
        public string Descricao { get; set; }
        public Nullable<int> Status { get; set; }
        public string Observacao { get; set; }
    
        public virtual LocalEntrega LocalEntrega { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProdutoDoacao> ProdutoDoacao { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PedidoAjudaDoacao> PedidoAjudaDoacao { get; set; }
    }
}
