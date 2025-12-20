using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace backend.Models
{
    public class Tasting
    {
        [Key]
        public int Id { get; set; }


        public int UserId { get; set; }
        [JsonIgnore]
        public User User { get; set; } = null!;

        // DATA
        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = string.Empty; // Nazwa wina

        [MaxLength(50)]
        public string Producer { get; set; } = string.Empty; // Miejsce Zakupu

        [MaxLength(50)]
        public string Region { get; set; } = string.Empty;

        [MaxLength(100)]
        public string Varietal { get; set; } = string.Empty; // Szczep

        public int? Vintage { get; set; } // Rocznik (może być null)

        [Column(TypeName = "decimal(18,2)")] // Precyzja dla ceny
        public decimal? Price { get; set; }



        public WineType Type { get; set; } // Czerwone, Białe, Różowe

        // EYE
        public IntensityLevel EyeIntensity { get; set; }

        [MaxLength(30)]
        public string EyeColor { get; set; } = string.Empty; //TODO: można zmienić na inta/enuma

        [MaxLength(100)]
        public string? EyeOther { get; set; }

        // NOSE
        public IntensityLevel NoseIntensity { get; set; } //TODO zmienić na double/decimal

        [MaxLength(200)]
        public string? AromasPrimary { get; set; }  //TODO: zastanowić się nad tym stringiem tu czy nie powinien być to enum na backendzie.

        [MaxLength(200)]
        public string? AromasSecondary { get; set; } // eg: beczka, masło

        [MaxLength(200)]
        public string? AromasTertiary { get; set; } 

        // MOUTH
        public SweetnessLevel Sweetness { get; set; }
        public double Acidity { get; set; }

        // Tanins only in red wine
        public double? Tannins { get; set; }

        public double Alcohol { get; set; }
        public double Body { get; set; }
        public double FlavorIntensity { get; set; }
        public double Finish { get; set; }

        // SUMMARY
        [Range(1, 10)]
        public int Rating { get; set; } // Twoja ocena /10

        [Range(1, 10)]
        public int QPrRatio { get; set; } // Cena-Jakość /10

        public RepurchaseDecision Repurchase { get; set; } // Czy kupić ponownie?

        [MaxLength(1000)]
        public string? Notes { get; set; } // Dodatkowe notatki


        // METADATA
        public DateTime TastingDate { get; set; } = DateTime.Now;
        public bool isPublic { get; set; } = true; // public by default


    }
}
