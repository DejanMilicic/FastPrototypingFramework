﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fpf.Infrastructure
{
	using System.Web.Mvc;

	public class FeatureViewLocationRazorViewEngine : RazorViewEngine
	{
		public FeatureViewLocationRazorViewEngine()
		{
			ViewLocationFormats = new[]
			{
				"~/Features/{1}/{0}.cshtml",
				"~/Features/{1}/{0}.vbhtml",
				"~/Features/Shared/{0}.cshtml",
				"~/Features/Shared/{0}.vbhtml",
			};

			MasterLocationFormats = ViewLocationFormats;

			PartialViewLocationFormats = new[]
			{
				"~/Features/{1}/{0}.cshtml",
				"~/Features/{1}/{0}.vbhtml",
				"~/Features/Shared/{0}.cshtml",
				"~/Features/Shared/{0}.vbhtml",
			};
		}
	}
}