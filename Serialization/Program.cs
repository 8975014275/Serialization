using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text.Json;

class Program
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Department { get; set; }
        public string Email { get; set; }
    }

    static void Main()
    {

        List<Employee> employees = new List<Employee>
        {
            new Employee { Id = 1, Name = "John Doe", Age = 30, Department = "IT", Email = "john.doe@example.com" },
            new Employee { Id = 2, Name = "Jane Doe", Age = 25, Department = "HR", Email = "jane.doe@example.com" }
        };

        string jsonString = JsonSerializer.Serialize(employees);
        Console.WriteLine(jsonString);
        List<Employee> deserializedEmployees = JsonSerializer.Deserialize<List<Employee>>(jsonString);

        // Printing deserialized employees
        Console.WriteLine("\nDeserialized Employees:");
        foreach (var emp in deserializedEmployees)
        {
            Console.WriteLine($"Id: {emp.Id}, Name: {emp.Name}, Age: {emp.Age}, Department: {emp.Department}, Email: {emp.Email}");
        }
        //string jsonString = "{\"Id\":1,\"Name\":\"John Doe\",\"Age\":30,\"Department\":\"IT\",\"Email\":\"john.doe@example.com\"}";

        //JObject data = JObject.Parse(jsonString);//remove slash
        //Console.WriteLine(data);

        //string jsonResponse = "{\"Table\":[{\"Column1\":\"\"}],\"Table1\":[{\"islistview\":true,\"isaddnew\":true,\"filters\":false,\"quickmenu\":false,\"iscontextmenu\":true,\"contextmenuid\":\"2690826F-D939-475C-8464-3E3CC7606353~459B3756-2684-49F8-88E2-F9DF2915B1A2~8E76CE35-0834-46E1-95B4-C586C93C3AD7\",\"issearchtab\":null,\"isprint\":null,\"isexport\":null,\"roleid\":\"44d7b0a9-1993-4b2b-8940-64944ad07fb2\",\"contextcolumn\":null}],\"Table2\":[{\"Column1\":\"\"}],\"Table3\":[{\"module_no\":\"BED5D25C-FB35-11EB-8697-9238275231ED\",\"txn_no\":\"9C3DDAB5-134A-4756-96C6-D1FDED900127\",\"contextmenujson\":\"[{\\\"menuid\\\":\\\"2690826F-D939-475C-8464-3E3CC7606353\\\",\\\"title\\\":\\\"All Details\\\",\\\"icon\\\":\\\"view_list\\\",\\\"Url\\\":\\\"\\\",\\\"functionname\\\":\\\"bindModal\\\",\\\"sequence\\\":1},{\\\"menuid\\\":\\\"8E76CE35-0834-46E1-95B4-C586C93C3AD7\\\",\\\"title\\\":\\\"Edit\\\",\\\"icon\\\":\\\"edit\\\",\\\"Url\\\":\\\"\\\",\\\"functionname\\\":\\\"Edit\\\",\\\"sequence\\\":2},{\\\"menuid\\\":\\\"459B3756-2684-49F8-88E2-F9DF2915B1A2\\\",\\\"title\\\":\\\"Delete\\\",\\\"icon\\\":\\\"delete\\\",\\\"Url\\\":\\\"\\\",\\\"functionname\\\":\\\"Delete\\\",\\\"sequence\\\":3}]\",\"Status\":\"Open\",\"Ticket Id\":\"TK0028\",\"Title\":\"Search issue\",\"Related To\":\"Search\",\"Problem Description\":\"Search issue\",\"Created Date\":\"2025-03-20 13:04:44.947\",\"Created by\":\"ChatAI ChatAI\"}]}";
        //JObject data = JObject.Parse(jsonResponse);//remove slash
        //JArray table3 = (JArray)data["Table3"];
        //Console.WriteLine(table3);

        //dynamic obj = JsonSerializer.Deserialize<ExpandoObject>(jsonString);

        //Console.WriteLine($"Id: {obj.Id}, Name: {obj.Name}, Department: {obj.Department}");
    }
}
