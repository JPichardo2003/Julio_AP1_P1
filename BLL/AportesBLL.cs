using Julio_AP1_P1.DAL;
using Julio_AP1_P1.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Julio_AP1_P1.BLL
{
    public class AportesBLL
    {
        private readonly Context _contexto;

        public AportesBLL(Context contexto)
        {
            _contexto = contexto;
        }

        public bool Existe(int aporteid)
        {
            return _contexto.Aportes.Any(a => a.AporteId == aporteid);
        }

        public bool Insertar(Aportes aportes)
        {
            _contexto.Aportes.Add(aportes);
            return _contexto.SaveChanges() > 0;
        }

        public bool Modificar(Aportes aportes)
        {
            var p = _contexto.Aportes.Find(aportes.AporteId);
            _contexto.Entry(p!).State = EntityState.Detached;
            _contexto.Entry(aportes).State = EntityState.Modified;
            return _contexto.SaveChanges() > 0;
        }
        public bool Guardar(Aportes aportes)
        {
            if (!Existe(aportes.AporteId))
                return this.Insertar(aportes);
            else
                return this.Modificar(aportes);
        }
        public bool Eliminar(Aportes aportes)
        {
            var p = _contexto.Aportes.Find(aportes.AporteId);
            _contexto.Entry(p!).State = EntityState.Detached;
            _contexto.Entry(aportes).State = EntityState.Deleted;
            return _contexto.SaveChanges() > 0;
        }

        public Aportes? Buscar(int aporteid)
        {
            return _contexto.Aportes
                    .AsNoTracking()
                    .SingleOrDefault(a => a.AporteId == aporteid);
        }
        public List<Aportes> Listar(Expression<Func<Aportes, bool>> Criterio)
        {
            return _contexto.Aportes
                    .Where(Criterio)
                    .AsNoTracking()
                    .ToList();
        }
    }
}
