using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final.Data
{
    public class FacturaService
    {
        private readonly ApplicationDbContext dbContext;

        public FacturaService(ApplicationDbContext db)
        {
            dbContext = db;
        }
        public List<Factura> GetFactura()
        {
            var emplist = dbContext.factura.ToList();
            return emplist;
        }
        public string Create(Factura facturas)
        {
            
            dbContext.factura.Add(facturas);
            dbContext.SaveChanges();
            return "Save Successfully";
        }
        public Factura GetFacturaById(int id)
        {
            Factura facturas = dbContext.factura.FirstOrDefault(s => s.Id_Factura == id);
            return facturas;
        }
        public string UpdateFactura(Factura facturas)
        {
            dbContext.factura.Update(facturas);
            dbContext.SaveChanges();
            return "Update Successfully";
        }
        public string DeleteFactura(Factura facturas)
        {
            dbContext.factura.Remove(facturas);
            dbContext.SaveChanges();
            return "Delete Successfully";
        }


    }
}
