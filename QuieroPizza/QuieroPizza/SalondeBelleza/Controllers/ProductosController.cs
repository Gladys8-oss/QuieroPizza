using SalondeBelleza.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SalondeBelleza.Web.Controllers 
{
    public class ProductosController : Controller
    {
        // GET: Productos
        public ActionResult Index()
        {

            var producto1 = new ProductosModel();
            producto1.Id = 1;
            producto1.Descripcion = "Pizza 6 quesos";


            var producto2 = new ProductosModel();
            producto2.Id = 2;
            producto2.Descripcion = "Pizza 4 estaciones";

            var producto3 = new ProductosModel();
            producto3.Id = 3;
            producto3.Descripcion = "Pizza jamon y queso";

            var ListadeProductos = new List<ProductosModel>();
            ListadeProductos.Add(producto1);
            ListadeProductos.Add(producto2);
            ListadeProductos.Add(producto3);

            return View(ListadeProductos);
        }
    }
}