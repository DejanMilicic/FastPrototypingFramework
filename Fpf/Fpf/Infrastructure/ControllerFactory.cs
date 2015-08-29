using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fpf.Infrastructure
{
	using System.Web.Mvc;
	using System.Web.Routing;

	public class ControllerFactory : DefaultControllerFactory
	{
		protected override Type GetControllerType(RequestContext requestContext, string controllerName)
		{
			return
				typeof(ControllerFactory).Assembly.GetType("Fpf.Features." + controllerName +
															".UiController");
		}

	}
}
