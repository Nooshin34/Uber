using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Uber.Domain.Contracts;

namespace UberApp.Domain;

public class Role : IEntity<int>
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(100)]
    public string RoleName { get; set; } = string.Empty;

    [MaxLength(500)]
    public string? Description { get; set; }

    // Navigation Property
    public virtual ICollection<User> Users { get; set; } = new List<User>();
    
}
