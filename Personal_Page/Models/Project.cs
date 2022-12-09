using System.Collections.Generic;

namespace Personal_Page.Models
{
	public class Project
	{
		public long Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public string Clinet { get; set; }
		public string Image { get; set; }


		public Project(long id, string name, string description, string clinet, string image)
		{
			Id = id;
			Name = name;
			Description = description;
			Clinet = clinet;
			Image = image;
		}
	}

	

	// public class Article
	// {
	// 	public long Id { get; set; }
	// 	public string title { get; set; }
	// 	public string Description { get; set; }
	// }
	//
	// public class IndexModel
	// {
	// 	public List<Project> Projects { get; set; }
	// 	public List<Article> Articles { get; set; }
	// }
}