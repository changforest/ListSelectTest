// See https://aka.ms/new-console-template for more information
using Newtonsoft.Json;

List<Member> membersList = new List<Member>();
membersList.Add(new() { Name = "大明", Age = 10, Photo = new() { "1.jpg", "2.jpg" } });
membersList.Add(new() { Name = "中明", Age = 8, Photo = new() { "3.jpg", "4.jpg" } });
membersList.Add(new() { Name = "小明", Age = 5, Photo = new() { "5.jpg", "6.jpg", "7.jpg" } });

List<string> nameList = membersList.Select(x => x.Name).ToList();

Console.WriteLine(JsonConvert.SerializeObject(nameList));
//["大明","中明","小明"]

public class Member
{
    public string Name { get; set; } = string.Empty;
    public int Age { get; set; }
    public List<string>? Photo { get; set; }
}