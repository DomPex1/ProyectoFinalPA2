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
    public class ControllersTipoCliente
    {
        public bool Guardar(TipoCliente tipoCliente)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                db.TipoClientes.Add(tipoCliente);
                paso = db.SaveChanges() > 0;
            }
            catch (Exception)
            {

                throw;
            }



            return paso;
        }

        public bool Modificar(TipoCliente tipoCliente)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                db.Entry(tipoCliente).State = EntityState.Modified;
                paso = db.SaveChanges() > 0;
            }
            catch (Exception)
            {

                throw;
            }
            return paso;
        }

        public TipoCliente Buscar(int id)
        {
            TipoCliente tipoCliente = new TipoCliente();
            Contexto db = new Contexto();
            try
            {
                tipoCliente = db.TipoClientes.Find(id);
            }
            catch (Exception)
            {

                throw;
            }

            return tipoCliente;
        }
        public bool Eliminar(int id)
        {
            TipoCliente tipoCliente = new TipoCliente();
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                var eliminar = db.TipoClientes.Find(id);
                db.Entry(eliminar).State = EntityState.Deleted;
                paso = db.SaveChanges() > 0;
            }
            catch (Exception)
            {

                throw;
            }
            return paso;
        }
        public List<TipoCliente> GetList(Expression<Func<TipoCliente, bool>> expression)
        {
            List<TipoCliente> lista = new List<TipoCliente>();
            Contexto db = new Contexto();

            try
            {
                lista = db.TipoClientes.Where(expression).ToList();
            }
            catch (Exception)
            {

                throw;
            }



            return lista;
        }
    }
}

