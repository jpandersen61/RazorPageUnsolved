using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EFCoreMovie2_RazorPages.Models;

[Table("Movie")]
public partial class Movie
{
    [Key]
    public int Id { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Title { get; set; } = null!;

    public int Year { get; set; }

    public int RunningTimeInMins { get; set; }

    public int StudioId { get; set; }

    [ForeignKey("StudioId")]
    [InverseProperty("Movies")]
    public virtual Studio Studio { get; set; } = null!;
}
