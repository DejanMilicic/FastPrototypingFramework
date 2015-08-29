using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace Fpf
{
	using System.Reflection;
	using System.Web.Mvc;
	using System.Web.Routing;

	using Autofac;
	using Autofac.Core;
	using Autofac.Integration.Mvc;

	using Fpf.App_Start;
	using Fpf.Infrastructure;

	public class Global : System.Web.HttpApplication
	{

		protected void Application_Start(object sender, EventArgs e)
		{
			var builder = new ContainerBuilder();

			// Register your MVC controllers.
			builder.RegisterControllers(typeof(Fpf.Global).Assembly);

			// OPTIONAL: Register model binders that require DI.
			builder.RegisterModelBinders(Assembly.GetExecutingAssembly());
			builder.RegisterModelBinderProvider();

			// OPTIONAL: Register web abstractions like HttpContextBase.
			builder.RegisterModule<AutofacWebTypesModule>();

			// OPTIONAL: Enable property injection in view pages.
			builder.RegisterSource(new ViewRegistrationSource());

			// OPTIONAL: Enable property injection into action filters.
			builder.RegisterFilterProvider();


			builder.RegisterType<ControllerFactory>().As<IControllerFactory>();


			// Set the dependency resolver to be Autofac.
			var container = builder.Build();
			DependencyResolver.SetResolver(new AutofacDependencyResolver(container));


			/*
	

			var container = new Container();
			container.Options.DefaultScopedLifestyle = new WebRequestLifestyle();
			InitializeContainer(container);
			//container.RegisterMvcControllers(Assembly.GetExecutingAssembly());
			container.RegisterMvcIntegratedFilterProvider();
			RegisterGlobalFilters(GlobalFilters.Filters, container);

			container.Verify();
			DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));
			*/

			AreaRegistration.RegisterAllAreas();
			FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
			RouteConfig.RegisterRoutes(RouteTable.Routes);

			ViewEngines.Engines.Clear();
			ViewEngines.Engines.Add(new FeatureViewLocationRazorViewEngine());

		}

		protected void Session_Start(object sender, EventArgs e)
		{

		}

		protected void Application_BeginRequest(object sender, EventArgs e)
		{

		}

		protected void Application_AuthenticateRequest(object sender, EventArgs e)
		{

		}

		protected void Application_Error(object sender, EventArgs e)
		{

		}

		protected void Session_End(object sender, EventArgs e)
		{

		}

		protected void Application_End(object sender, EventArgs e)
		{

		}
	}
}