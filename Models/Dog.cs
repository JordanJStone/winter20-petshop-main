using System;
using System.ComponentModel.DataAnnotations;

namespace petshop.Models
{
  public class Dog
  {


    public Dog(string name, string description, int age)
    {
      this.Name = name;
      this.Description = description;
      this.Age = age;

    }
    [Required]
    [MinLength(3)]
    public string Name { get; set; }
    [MaxLength(20)]
    public string Description { get; set; }
    public int Age { get; set; }
    public string Id { get; set; } = Guid.NewGuid().ToString();
  }
}