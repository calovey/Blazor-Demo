using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace SparseDemo.Shared
{
    public class DemoClass
    {
        [JsonPropertyName("Name")]
        public string name { get; set; }
        [JsonPropertyName("UserName")]
        public string username { get; set; }
        [JsonPropertyName("Password")]
        public string password { get; set; }
        [JsonPropertyName("Email")]
        public string email { get; set; }
    }

    public class DemoClasses
    {
        public IList<DemoClass> classes;
    }
}
