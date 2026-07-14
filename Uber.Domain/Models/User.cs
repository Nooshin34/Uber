using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Text;
using Uber.Domain.Contracts;

namespace UberApp.Domain;

public class User :  IFullEntity<long>
{
    [Key]
    public long Id { get; set; }

    [Required]
    [MaxLength(100)]
    public string UserName { get; set; } = string.Empty;

    [Required]
    [JsonProperty]
    public string PasswordHash { get; private set; } = string.Empty;

    [Required]
    [MaxLength(100)]
    public string FirstName { get; set; } = string.Empty;

    [Required]
    [MaxLength(100)]
    public string LastName { get; set; } = string.Empty;

    [Phone]
    [MaxLength(20)]
    public string PhoneNumber { get; set; } = string.Empty;

    [ForeignKey(nameof(Role))]
    public int RoleId { get; set; }

    public bool IsActive { get; set; } = true;

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public DateTime? LastLoginAt { get; set; }
    public bool IsDeleted { get; set; }
    public DateTime DeletedAt { get; set; }
    public string FullName { get { return FirstName + " " + LastName; }}




    // Navigation Property
    public virtual Role? Role { get; set; }
    

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
        int id,
    string userName,
    string passwordHash,
    string firstName,
    string lastName,
    string phoneNumber,
    int roleId,
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
            Id = id,
            UserName = userName,
            PasswordHash = passwordHash,
            FirstName = firstName,
            LastName = lastName,
            PhoneNumber = phoneNumber,
            RoleId = roleId,
            IsActive = isActive,
            CreatedAt = DateTime.UtcNow,
            LastLoginAt = null
        };
    }


}






