using System;
using System.Text.Json.Serialization;

namespace StudentMcpServer.Models;

[JsonSourceGenerationOptions(PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase)]
[JsonSerializable(typeof(List<Student>))]
[JsonSerializable(typeof(Student))]
internal sealed partial class StudentContext : JsonSerializerContext
{
}
