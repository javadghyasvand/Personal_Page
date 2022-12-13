using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Personal_Page.Models;

namespace Personal_Page.ViewComponents
{
	public class LatestAarticel : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			var _Aarticel = new List<Artical>
			{
				new Artical(1,"text1","لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ و با استفاده از طراحان گرافیک است.","img1.jpg"),
                new Artical(2,"text2","لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ و با استفاده از طراحان گرافیک است.","img2.jpg"),
                new Artical(3,"text3","لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ و با استفاده از طراحان گرافیک است.","img3.jpg"),
                new Artical(4,"text4","لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ و با استفاده از طراحان گرافیک است.","img4.jpg")

            };
			return View("_LatestAarticel", _Aarticel);
		}
	}
}
