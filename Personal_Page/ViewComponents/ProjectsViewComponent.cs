using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Personal_Page.Models;

namespace Personal_Page.ViewComponents
{
	public class ProjectsViewComponent : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			var project = new List<Project>
			{
				new Project(1,"text1","لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ و با استفاده از طراحان گرافیک است.","لورم ایپسوم","img1.jpg"),
				new Project(2,"text2","لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ و با استفاده از طراحان گرافیک است.","لورم ایپسوم","img2.jpg"),
				new Project(3,"text3","لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ و با استفاده از طراحان گرافیک است.","لورم ایپسوم","img3.jpg"),
				new Project(4,"text4","لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ و با استفاده از طراحان گرافیک است.","لورم ایپسوم","img4.jpg"),
				new Project(5,"text5","لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ و با استفاده از طراحان گرافیک است.","لورم ایپسوم","img5.jpg")

			};
			return View("_Projects",project);
		}
	}
}
