using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Numerics;
using System.Text;
using Uber.Domain.Contracts;

namespace UberApp.Domain;

public class User :  IFullEntity<long>
{
    public User() { }

    public User(long id, string firstName, string lastName, string phone)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        PhoneNumber = phone;
        UserName = string.Empty; 
        PasswordHash = string.Empty;
        IsActive = true;
        CreatedAt = DateTime.UtcNow;
        IsDeleted = false;
        DeletedAt = new DateTime(1900, 1, 1); 
        LastLoginAt = null;
    }

    public long Id { get; set; }

    public string UserName { get; set; } = string.Empty;

    public string PasswordHash { get; set; } = string.Empty;

    public string FirstName { get; set; } = string.Empty;

    public string LastName { get; set; } = string.Empty;

    public string PhoneNumber { get; set; } = string.Empty;

    public bool IsActive { get; set; } = true;

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public DateTime? LastLoginAt { get; set; }
    public bool IsDeleted { get; set; }
    public DateTime DeletedAt { get; set; }
    public string FullName { get { return FirstName + " " + LastName; }}

    [System.ComponentModel.Browsable(false)]
    public ICollection<Car> Cars { get; set; } = new List<Car>();




    
    

    public void UpdateFirstName(string firstName)
    {
        if (string.IsNullOrWhiteSpace(firstName) || firstName.Length <= 2)
            throw new ArgumentException("نام را درست وارد نمایید.");

        FirstName = firstName;
    }

    public void UpdateLastName(string lastName)
    {
        if (string.IsNullOrWhiteSpace(lastName) || lastName.Length <= 2)
            throw new ArgumentException("نام خانوادگی را درست وارد نمایید.");

        LastName = lastName;
    }


    public static User Create(
        string userName,
        string passwordHash,
        string firstName,
        string lastName,
        string phoneNumber,
        bool isActive)
    {
        if (string.IsNullOrEmpty(firstName) || firstName.Length <= 2)
            throw new Exception("نام را درست وارد نمایید");

        if (string.IsNullOrEmpty(lastName) || lastName.Length <= 2)
            throw new Exception("نام خانوادگی را درست وارد نمایید");

        if (string.IsNullOrEmpty(phoneNumber) || phoneNumber.Length != 11)
            throw new Exception("شماره تلفن را درست وارد نمایید");

        return new User
        {
            UserName = userName,
            PasswordHash = passwordHash,
            FirstName = firstName,
            LastName = lastName,
            PhoneNumber = phoneNumber,
            IsActive = isActive,
            CreatedAt = DateTime.UtcNow,
            LastLoginAt = null,
            IsDeleted = false,
            DeletedAt = new DateTime(1900, 1, 1)
        };
    }


}






