
using System.ComponentModel.DataAnnotations;
using Abyster_Test_Project.SharedKernel;

namespace Abyster_Test_Project.Domain.Categorys.Dto;

public class CategoryDto : Common{
    
    [Required]
    public string libelle {get; set;}
}