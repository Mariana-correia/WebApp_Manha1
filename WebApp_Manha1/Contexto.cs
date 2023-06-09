﻿using Microsoft.EntityFrameworkCore;
using WebApp_Manha1.Entidades;

namespace WebApp_Manha1
{
    public class Contexto : DbContext 
    {
        public Contexto(DbContextOptions<Contexto> opt ) : base( opt )
        {}

        public DbSet<Produtos> Produtos { get; set; }
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<PermissaoEntidade> PERMISSAO { get; set; }
    }
}
