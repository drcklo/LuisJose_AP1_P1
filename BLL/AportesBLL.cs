﻿using System.Linq.Expressions;
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
        
    }
}
