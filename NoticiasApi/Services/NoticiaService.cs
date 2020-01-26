using Microsoft.EntityFrameworkCore;
using NoticiasApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace NoticiasApi.Services
{
    public class NoticiaService
    {
        private readonly NoticiaDbContext _noticiaDbCOntext;
        public NoticiaService(NoticiaDbContext noticiaDbContext)
        {
            _noticiaDbCOntext = noticiaDbContext;
        }
        public Boolean AgregarNoticia( Noticia _noticia)
        {
            try
            {
                _noticiaDbCOntext.Noticia.Add(_noticia);
                _noticiaDbCOntext.SaveChanges();

                return true;
            }
            catch (Exception e)
            {
                return false;
            }       

        }
        public List<Noticia> obtener()
        {
            var result = _noticiaDbCOntext.Noticia.Include(x => x.Autor).ToList();
            return result;


        }
        public Boolean EditarNoticia(Noticia _noticia)
        {
            try
            {
                var noticiaBd = _noticiaDbCOntext.Noticia.Where(b => b.NoticiaID == _noticia.NoticiaID).FirstOrDefault();
                noticiaBd.Titulo = _noticia.Titulo;
                noticiaBd.Descripcion = _noticia.Descripcion;

                _noticiaDbCOntext.SaveChanges();

                return true;
            }
            catch (Exception e)
            {
                return false;
            }

        }
        public Boolean EliminarNoticia(int IdNoticia)
        {
            try
            {
                var noticiaBd = _noticiaDbCOntext.Noticia.Where(b => b.NoticiaID ==IdNoticia).FirstOrDefault();
                _noticiaDbCOntext.Remove(noticiaBd);
                _noticiaDbCOntext.SaveChanges();

                return true;
            }
            catch (Exception e)
            {
                return false;
            }

        }
    }
}
