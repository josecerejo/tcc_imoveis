//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tcc_Imoveis.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class usuario_pesquisa_posicao
    {
        public int idUsuario_Pesquisa_Posicao { get; set; }
        public Nullable<int> idUsuario_Pesquisa { get; set; }
        public Nullable<float> latitude { get; set; }
        public Nullable<float> longitude { get; set; }
    
        public virtual usuario_pesquisa usuario_pesquisa { get; set; }
    }
}
