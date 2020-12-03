using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final.Data
{
    public class PFacturadoService
    {
        private readonly ApplicationDbContext dbContext;

        public PFacturadoService(ApplicationDbContext db)
        {
            dbContext = db;
        }
        public List<Producto_Facturado> GetProductoFacturado()
        {
            var emplist = dbContext.producto_facturado.ToList();
            return emplist;
        }
        public string Create(Producto_Facturado productof)
        {
            dbContext.producto_facturado.Add(productof);
            dbContext.SaveChanges();
            return "Save Successfully";
        }
        public Producto_Facturado GetProductoFacturadoById(int id)
        {
            Producto_Facturado productof = dbContext.producto_facturado.FirstOrDefault(s => s.IdProducto_Facturados == id);
            return productof;
        }
        public string UpdateProductoFacturado(Producto_Facturado productof)
        {
            dbContext.producto_facturado.Update(productof);
            dbContext.SaveChanges();
            return "Update Successfully";
        }
        public string DeleteProductoFacturado(Producto_Facturado productof)
        {
            dbContext.producto_facturado.Remove(productof);
            dbContext.SaveChanges();
            return "Delete Successfully";
        }
    }
}
