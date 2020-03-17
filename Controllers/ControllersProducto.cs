using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProyectoFinalPA2.Models;
using ProyectoFinalPA2.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace ProyectoFinalPA2.Controllers
{
    public class ControllersProducto
    {
        public bool Guardar(Productos productos)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                db.Productos.Add(productos);
                paso = db.SaveChanges() > 0;
            }
            catch (Exception)
            {

                throw;
            }



            return paso;
        }

        public bool Modificar(Productos productos)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                db.Entry(productos).State = EntityState.Modified;
                paso = db.SaveChanges() > 0;
            }
            catch (Exception)
            {

                throw;
            }
            return paso;
        }

        public Productos Buscar(int id)
        {
            Productos productos = new Productos();
            Contexto db = new Contexto();
            try
            {
                productos = db.Productos.Find(id);
            }
            catch (Exception)
            {

                throw;
            }

            return productos;
        }
        public bool Eliminar(int id)
        {
            Productos productos = new Productos();
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                var eliminar = db.Productos.Find(id);
                db.Entry(eliminar).State = EntityState.Deleted;
                paso = db.SaveChanges() > 0;
            }
            catch (Exception)
            {

                throw;
            }
            return paso;
        }
        public List<Productos> GetList(Expression<Func<Productos, bool>> expression)
        {
            List<Productos> lista = new List<Productos>();
            Contexto db = new Contexto();

            try
            {
                lista = db.Productos.Where(expression).ToList();
            }
            catch (Exception)
            {

                throw;
            }
            return lista;
        }
    }
}
