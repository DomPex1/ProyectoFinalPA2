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
    public class ControllersPedido
    {
        public bool Guardar(Pedidos pedidos)
        {
            bool paso = false;
            ControllersProducto Controproductos = new ControllersProducto();
            Productos productos = new Productos();
            Contexto db = new Contexto();
            try
            {

                foreach (var item in pedidos.Detalles)
                {
                    var producto = Controproductos.Buscar(pedidos.ProductoId);
                    producto.Cantidad -= item.Cantidad;
                    Controproductos.Modificar(producto);
                }
                db.Pedidos.Add(pedidos);
                paso = db.SaveChanges() > 0;


            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }
        public bool Eliminar(int id)
        {
            bool paso = false;
            Contexto db = new Contexto();
            ControllersProducto controllersproductos = new ControllersProducto();


            try
            {
                
                Pedidos pedidos = db.Pedidos.Where(e => e.PedidosId == id).Include(d => d.Detalles).FirstOrDefault();
                foreach (var item in pedidos.Detalles)
                {
                    var producto = controllersproductos.Buscar(item.ProductoId);
                    producto.Cantidad += item.Cantidad;
                    controllersproductos.Modificar(producto);
                }
                db.Entry(pedidos).State = EntityState.Deleted;
                paso = (db.SaveChanges() > 0);
            }
            catch (Exception)
            {
                throw;
            }

            return paso;
        }

        public Pedidos Buscar(int id)
        {
            Contexto db = new Contexto();
            Pedidos pedidos = new Pedidos();

            try
            {
                pedidos = db.Pedidos.Where(p => p.PedidosId == id)
                    .Include(p => p.Detalles)
                    .FirstOrDefault();

            }
            catch (Exception)
            {

                throw;
            }

            return pedidos;

        }

        public bool Modificar(Pedidos pedidos)
        {
            bool paso = false;
            Contexto db = new Contexto();
            ControllersProducto controllersproductos = new ControllersProducto();



            try
            {


                if (pedidos != null)
                {
                    foreach (var item in pedidos.Detalles)
                    {
                        db.Productos.Find(item.ProductoId).Cantidad += item.Cantidad;

                        if (!pedidos.Detalles.ToList().Exists(v => v.PedidosDetalleId == item.PedidosDetalleId))
                        {

                            db.Entry(item).State = EntityState.Deleted;
                        }
                    }

                    foreach (var item in pedidos.Detalles)
                    {
                        db.Productos.Find(item.ProductoId).Cantidad -= item.Cantidad;
                        var estado = item.PedidosDetalleId > 0 ? EntityState.Modified : EntityState.Added;

                        db.Entry(item).State = estado;
                    }

                    db.Entry(pedidos).State = EntityState.Modified;
                }

                if (db.SaveChanges() > 0)
                {
                    paso = true;
                }

            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        public List<Pedidos> GetList(Expression<Func<Pedidos, bool>> expression)
        {
            List<Pedidos> lista = new List<Pedidos>();
            Contexto db = new Contexto();
            try
            {
                lista = db.Pedidos.Where(expression).ToList();

            }
            catch (Exception)
            {

                throw;
            }
            return lista;
        }
    }
}
