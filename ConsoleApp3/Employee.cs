using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp3
{
	public class Employee
	{
		public int ID { get; set; }
		public string Name { get; set; }
		public decimal Salary { get; set; }


		
		public static string Serialize(Employee employee)
		{
			return JsonConvert.SerializeObject(employee);
		}

		public static Employee Deserialize(string jsonData)
		{
			return JsonConvert.DeserializeObject<Employee>(jsonData);
		}
	}
}
