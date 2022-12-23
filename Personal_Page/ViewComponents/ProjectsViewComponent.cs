using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Personal_Page.Data;
using Personal_Page.Models;

namespace Personal_Page.ViewComponents
{
	public class ProjectsViewComponent : ViewComponent
	{
		public IViewComponentResult Invoke()
        {
            var projects = Project_Store.GetList();
			return View("_Projects", projects);
		}
	}
}
