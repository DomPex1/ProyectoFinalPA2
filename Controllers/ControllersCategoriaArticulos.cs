using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProyectoFinalPA2.Data;
using ProyectoFinalPA2.Models;
namespace ProyectoFinalPA2.Controllers
{
    public class ControllersCategoriaArticulos
    {
        public bool Guardar(CategoriaArticulos categoriaArticulos)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                db.CategoriaArticulo.Add(categoriaArticulos);
                paso = db.SaveChanges() > 0;
            }
            catch (Exception)
            {

                throw;
            }



            return paso;
        }

        public bool Modificar(CategoriaArticulos categoriaArticulos)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                db.Entry(categoriaArticulos).State = EntityState.Modified;
                paso = db.SaveChanges() > 0;
            }
            catch (Exception)
            {

                throw;
            }
            return paso;
        }

        public CategoriaArticulos Buscar(int id)
        {
            CategoriaArticulos categoriaArticulos = new CategoriaArticulos();
            Contexto db = new Contexto();
            try
            {
                categoriaArticulos = db.CategoriaArticulo.Find(id);
            }
            catch (Exception)
            {

                throw;
            }

            return categoriaArticulos;
        }
        public bool Eliminar(int id)
        {
            CategoriaArticulos categoriaArticulos = new CategoriaArticulos();
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                var eliminar = db.CategoriaArticulo.Find(id);
                db.Entry(eliminar).State = EntityState.Deleted;
                paso = db.SaveChanges() > 0;
            }
            catch (Exception)
            {

                throw;
            }
            return paso;
        }
        public List<CategoriaArticulos> GetList(Expression<Func<CategoriaArticulos, bool>> expression)
        {
            List<CategoriaArticulos> lista = new List<CategoriaArticulos>();
            Contexto db = new Contexto();

            try
            {
                lista = db.CategoriaArticulo.Where(expression).ToList();
            }
            catch (Exception)
            {

                throw;
            }



            return lista;
        }
    }
}
