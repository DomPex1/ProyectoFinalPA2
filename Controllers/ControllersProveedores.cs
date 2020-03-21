using Microsoft.EntityFrameworkCore;
using ProyectoFinalPA2.Data;
using ProyectoFinalPA2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ProyectoFinalPA2.Controllers
{
    public class ControllersProveedores
    {
        public bool Guardar(Proveedores proveedores)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                db.Proveedores.Add(proveedores);
                paso = db.SaveChanges() > 0;
            }
            catch (Exception)
            {

                throw;
            }



            return paso;
        }
        

        public bool Modificar(Proveedores proveedores)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                db.Entry(proveedores).State = EntityState.Modified;
                paso = db.SaveChanges() > 0;
            }
            catch (Exception)
            {

                throw;
            }
            return paso;
        }

        public Proveedores Buscar(int id)
        {
            Proveedores proveedores = new Proveedores();
            Contexto db = new Contexto();
            try
            {
                proveedores = db.Proveedores.Find(id);
            }
            catch (Exception)
            {

                throw;
            }

            return proveedores;
        }
        public bool Eliminar(int id)
        {
            Proveedores proveedores = new Proveedores();
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                var eliminar = db.Proveedores.Find(id);
                db.Entry(eliminar).State = EntityState.Deleted;
                paso = db.SaveChanges() > 0;
            }
            catch (Exception)
            {

                throw;
            }
            return paso;
        }
        public List<Proveedores> GetList(Expression<Func<Proveedores, bool>> expression)
        {
            List<Proveedores> lista = new List<Proveedores>();
            Contexto db = new Contexto();

            try
            {
                lista = db.Proveedores.Where(expression).ToList();
            }
            catch (Exception)
            {

                throw;
            }



            return lista;
        }
    }
}

