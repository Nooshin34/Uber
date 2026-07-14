using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using UberApp.Domain;

namespace UberApp.Busineses;

//how to work with json file 
public class UserService
{
    public List<User> GetUsers()
    {
        List<User> users = new List<User>();
        string jsonDataStr = string.Empty;
        string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "users.json");
        if (File.Exists(filePath))
        {
            jsonDataStr = File.ReadAllText(filePath);
            if (!string.IsNullOrEmpty(jsonDataStr))
            {
                users = JsonConvert.DeserializeObject<List<User>>(jsonDataStr);
            }
        }
        return users;
    }
}
