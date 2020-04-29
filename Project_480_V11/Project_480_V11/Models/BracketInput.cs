using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlTypes;
using System.Linq;
using System.Threading.Tasks;

namespace Project_480_V11.Models
{
    public class BracketInput
    {
            [Key]
            [DatabaseGenerated(DatabaseGeneratedOption.None)]
            [Display(Name = "BrasketId")]
            public int BracketId { get; set; }

            [Required]
            [MaxLength(500)]
            //[DatabaseGenerated(DatabaseGeneratedOption.None)]
            [Display(Name = "FullName")]
            public string FullName { get; set; }

            [Required]
            //[MaxLength(500)]
           // [DatabaseGenerated(DatabaseGeneratedOption.None)]
            [Display(Name = "Rank")]
            public int Rank { get; set; }

            [Required]
            [MaxLength(500)]
           // [DatabaseGenerated(DatabaseGeneratedOption.None)]
            [Display(Name = "Localtion")]
            public string Localtion { get; set; }
       }
    }
