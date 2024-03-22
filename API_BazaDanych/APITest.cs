using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace API_BazaDanych
{
    public class APITest
    {
        public HttpClient client;
        public async Task GetData()
        {
            client = new HttpClient();
            string call = "http://radoslaw.idzikowski.staff.iiar.pwr.wroc.pl/instruction/students.json";
            string response = await client.GetStringAsync(call);

            List<Student> students = JsonSerializer.Deserialize<List<Student>>(response);

            foreach(var student in students)
            {
                Console.WriteLine(student.Name);
            }
        }
    }
}
