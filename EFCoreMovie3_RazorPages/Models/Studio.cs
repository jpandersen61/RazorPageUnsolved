using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EFCoreMovie2_RazorPages.Models;

[Table("Studio")]
public partial class Studio
{
    [Key]
    public int Id { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Name { get; set; } = null!;

    [Column("HQCity")]
    [StringLength(30)]
    [Unicode(false)]
    public string Hqcity { get; set; } = null!;

    public int NoOfEmployees { get; set; }

    [InverseProperty("Studio")]
    public virtual ICollection<Movie> Movies { get; set; } = new List<Movie>();
}
