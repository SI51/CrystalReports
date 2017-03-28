using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrystalReports.Clases;

namespace CrystalReports.controlador
{
    class ProductoManager
    {
        public static List<String>ListarDeptos()
        {
            List<String> deptos = new List<string>();
            try
            {
                using (var ctx = new DataModel())
                {
                    var lista = ctx.productos.GroupBy(r => r.sDepartamento).ToList();
                    foreach (var item in lista)
                    {
                        deptos.Add(item.Key.ToString().ToUpper());
                    }
                    deptos.Add("TODOS");
                }
            }
            catch (Exception)
            {
                throw;
            }
            return deptos;
        }

        public static List<Productos> GetList()
        {
            //List<Productos> lstProducto = new List<Productos>();
            try
            {
                using (var ctx = new DataModel())
                {
                    return ctx.productos.Where(r => r.bStatus == true).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
            //return lstProducto;
        }
    }
}