using Microsoft.EntityFrameworkCore;
using NoticiasApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NoticiasApi
{
    public class NoticiaDbContext : DbContext
    {
        public NoticiaDbContext(DbContextOptions opciones) :base(opciones)
        {
        }
        public DbSet<Noticia> Noticia { get; set; }
        public DbSet<Autor> Autor { get; set; }


    }
}
