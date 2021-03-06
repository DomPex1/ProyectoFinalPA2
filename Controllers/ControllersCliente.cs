﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProyectoFinalPA2.Data;
using ProyectoFinalPA2.Models;

namespace ProyectoFinalPA2.Controllers
{
    public class ControllersCliente
    {
        public bool Guardar(Clientes clientes)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                db.Clientes.Add(clientes);
                paso = db.SaveChanges() > 0;
            }
            catch (Exception)
            {

                throw;
            }



            return paso;
        }

        public bool Modificar(Clientes clientes)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                db.Entry(clientes).State = EntityState.Modified;
                paso = db.SaveChanges() > 0;
            }
            catch (Exception)
            {

                throw;
            }
            return paso;
        }

        public Clientes Buscar(int id)
        {
            Clientes clientes = new Clientes();
            Contexto db = new Contexto();
            try
            {
                clientes = db.Clientes.Find(id);
            }
            catch (Exception)
            {

                throw;
            }

            return clientes;
        }
        public bool Eliminar(int id)
        {
            Clientes clientes = new Clientes();
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                var eliminar = db.Clientes.Find(id);
                db.Entry(eliminar).State = EntityState.Deleted;
                paso = db.SaveChanges() > 0;
            }
            catch (Exception)
            {

                throw;
            }
            return paso;
        }
        public List<Clientes> GetList(Expression<Func<Clientes, bool>> expression)
        {
            List<Clientes> lista = new List<Clientes>();
            Contexto db = new Contexto();

            try
            {
                lista = db.Clientes.Where(expression).ToList();
            }
            catch (Exception)
            {

                throw;
            }



            return lista;
        }
    }
}
