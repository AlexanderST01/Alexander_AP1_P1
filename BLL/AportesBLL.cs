using Alexander_AP1_P1.DAL;
using Alexander_AP1_P1.Models;
using Microsoft.EntityFrameworkCore;

namespace Alexander_AP1_P1.BLL
{
    public class AportesBLL
    {
        private readonly Context _context;
        public AportesBLL(Context context)
        {
            _context = context;
        }
        public bool Existe(int aportesId)
        {
            return _context.Aportes.Any(i => i.AporteId == aportesId);
        }
        public bool Insertar(Aportes aportes)
        {
            _context.Aportes.Add(aportes);
            return _context.SaveChanges() > 0;
        }
        public bool Modificar(Aportes aportes)
        {
            _context.Aportes.Entry(_context.Aportes.Find(aportes.AporteId)!).State = EntityState.Detached;
            _context.Aportes.Entry(aportes).State = EntityState.Modified;
            return _context.SaveChanges() > 0;
        }
        public bool Guardar(Aportes aportes)
        {
            if (Existe(aportes.AporteId))
                return Modificar(aportes);
            else
                return Insertar(aportes);
        }
        public bool Eliminar(Aportes aportes)
        {
            _context.Aportes.Entry(_context.Aportes.Find(aportes.AporteId)!).State = EntityState.Detached;
            _context.Aportes.Entry(aportes).State = EntityState.Deleted;
            return _context.SaveChanges() > 0;
        }
        public Aportes? Buscar(int aportesId)
        {
            return _context.Aportes.Where(i =>i.AporteId == aportesId).AsNoTracking().FirstOrDefault();
        }
        public 
    }
}
