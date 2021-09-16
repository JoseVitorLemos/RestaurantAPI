using System;
using Microsoft.Extensions.Configuration;

namespace RestaurantAPI.Config
{
	public class DatabaseConfig
	{
		private IConfiguration config; 

		public static void DatabaseConfig()
		{
			public string Host = config.GetValue<string>("Host");
			Console.WriteLine(Host);
			/* string mysqlConnectionString = $"server=172.26.73.136;database=restaurant;user=root;password=secret"; */
		}
	}
}	
