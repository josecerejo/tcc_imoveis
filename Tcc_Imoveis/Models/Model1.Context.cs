﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class tcc_imoveisEntities1 : DbContext
    {
        public tcc_imoveisEntities1()
            : base("name=tcc_imoveisEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<bairro> bairro { get; set; }
        public DbSet<cidade> cidade { get; set; }
        public DbSet<imovel> imovel { get; set; }
        public DbSet<imovel_anuncio> imovel_anuncio { get; set; }
        public DbSet<imovel_atributo> imovel_atributo { get; set; }
        public DbSet<imovel_atributo_tipo> imovel_atributo_tipo { get; set; }
        public DbSet<imovel_imagens> imovel_imagens { get; set; }
        public DbSet<imovel_tipo> imovel_tipo { get; set; }
        public DbSet<mensagem> mensagem { get; set; }
        public DbSet<pesquisa_condicoes> pesquisa_condicoes { get; set; }
        public DbSet<tipo_dado> tipo_dado { get; set; }
        public DbSet<tipo_usuario> tipo_usuario { get; set; }
        public DbSet<uf> uf { get; set; }
        public DbSet<usuario> usuario { get; set; }
        public DbSet<usuario_lista> usuario_lista { get; set; }
        public DbSet<usuario_lista_imovel> usuario_lista_imovel { get; set; }
        public DbSet<usuario_pesquisa> usuario_pesquisa { get; set; }
        public DbSet<usuario_pesquisa_imovel_atributo_tipo> usuario_pesquisa_imovel_atributo_tipo { get; set; }
        public DbSet<usuario_pesquisa_posicao> usuario_pesquisa_posicao { get; set; }
        public DbSet<view_imoveis_atendem_pelo_menos_uma_condicao_pesquisa> view_imoveis_atendem_pelo_menos_uma_condicao_pesquisa { get; set; }
        public DbSet<view_imoveis_atendem_tipo_atributo_pesquisa> view_imoveis_atendem_tipo_atributo_pesquisa { get; set; }
        public DbSet<view_imoveis_atendem_todas_condicoes_pesquisa> view_imoveis_atendem_todas_condicoes_pesquisa { get; set; }
        public DbSet<view_imoveis_seus_tipos_atributos> view_imoveis_seus_tipos_atributos { get; set; }
        public DbSet<view_pesquisa_usuario_tipos_atributos_imovel> view_pesquisa_usuario_tipos_atributos_imovel { get; set; }
    }
}
