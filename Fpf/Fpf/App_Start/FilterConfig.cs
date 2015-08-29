using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fpf.App_Start
{
	using System.Web.Mvc;

	using Fpf.Infrastructure;

	public class FilterConfig
	{
		public static void RegisterGlobalFilters(GlobalFilterCollection filters)
		{
			//filters.Add(new HandleErrorAttribute());
			//filters.Add(new ValidatorActionFilter());
			//filters.Add(new MvcTransactionFilter());
		}
	}
}