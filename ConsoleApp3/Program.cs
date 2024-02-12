using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
	internal class Program
	{
		static void Main(string[] args)
		{
		
				// Serializaion
				Employee empObj = new Employee();
				empObj.ID = 1;
				empObj.Name = "Soujanya";
				empObj.Salary = 30000;


			// Convert Employee object to JOSN string format
			string serializedData = Employee.Serialize(empObj);
			Console.WriteLine(serializedData);


			//deserialization
			Employee deserializedData = Employee.Deserialize(serializedData);
			Console.WriteLine(deserializedData.ID);
			Console.WriteLine(deserializedData.Name);
			Console.WriteLine(deserializedData.Salary);
			Console.ReadLine();



		}
	}
}
