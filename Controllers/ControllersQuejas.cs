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
    public class ControllersQuejas
    {
        public bool Guardar(Quejas quejas)
        {
            bool paso = false;
            Contexto db = new Contexto();
            ControllersCliente controllersCliente = new ControllersCliente();
            try
            {
                var cliet = controllersCliente.Buscar(quejas.ClienteId);
                cliet.Quejas = "si";
                controllersCliente.Modificar(cliet);
                db.Quejas.Add(quejas);
                paso = db.SaveChanges() > 0;
            }
            catch (Exception)
            {

                throw;
            }



            return paso;
        }

        public bool Modificar(Quejas quejas)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                db.Database.ExecuteSqlRaw($"Delete From QuejasDetalles where QuejasId={quejas.QuejasId}");

                foreach (var item in quejas.Detalles)
                {
                    db.Entry(item).State = EntityState.Added;
                }

                db.Quejas.Add(quejas);
                db.Entry(quejas).State = EntityState.Modified;
                paso = db.SaveChanges() > 0;

            }
            catch (Exception)
            {

                throw;
            }
            return paso;
        }

        public Quejas Buscar(int id)
        {
            Contexto db = new Contexto();
            Quejas quejas = new Quejas();

            try
            {
                quejas = db.Quejas.Where(p => p.QuejasId == id)
                    .Include(p => p.Detalles)
                    .FirstOrDefault();

            }
            catch (Exception)
            {

                throw;
            }

            return quejas;

        }
        public bool Eliminar(int id)
        {
           // Quejas quejas = new Quejas();
            ControllersCliente controllersCliente = new ControllersCliente();
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                var quejas = Buscar(id);

                var cliet = controllersCliente.Buscar(quejas.ClienteId);
                cliet.Quejas = "No";
                controllersCliente.Modificar(cliet);


                var eliminar = db.Quejas.Find(id);
                db.Entry(eliminar).State = EntityState.Deleted;
                paso = db.SaveChanges() > 0;
            }
            catch (Exception)
            {

                throw;
            }
            return paso;
        }
        public List<Quejas> GetList(Expression<Func<Quejas, bool>> expression)
        {
            List<Quejas> lista = new List<Quejas>();
            Contexto db = new Contexto();

            try
            {
                lista = db.Quejas.Where(expression).ToList();
            }
            catch (Exception)
            {

                throw;
            }
            return lista;
        }
    }
}

