using System.Linq.Expressions;
using System;
using LuisJose_AP1_P1.DAL;
using LuisJose_AP1_P1.Models;
using Microsoft.EntityFrameworkCore;

namespace LuisJose_AP1_P1.BLL
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
            return _context.Aportes.Any(a => a.AportesId == aportesId);
        }
        public bool Insertar(Aportes aportes)
        {
            _context.Aportes.Add(aportes);
            return _context.SaveChanges() > 0;
        }
        public bool Modificar(Aportes aportes)
        {
            var p = _context.Aportes.Find(aportes.AportesId);
            _context.Entry(p!).State = EntityState.Detached;
            _context.Entry(aportes).State = EntityState.Modified;
            return _context.SaveChanges() > 0;
        }

        
    }
}
