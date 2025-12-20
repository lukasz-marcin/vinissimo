using backend.Models;
using System.ComponentModel.DataAnnotations;

namespace backend.DTOs
{
    public class TastingDtos
    {

        // Dane na liscie
        public class TastingListDto
        {
            public int Id { get; set; }
            public string Name { get; set; } = string.Empty;
            public string Producer { get; set; } = string.Empty;
            public int? Vintage { get; set; }
            public DateTime TastingDate { get; set; }
            public int Rating { get; set; } 
            public string Type { get; set; } = string.Empty; 
        }

        // Szczegóły
        public class TastingDetailDto : CreateTastingDto
        {
            public int Id { get; set; }
            public DateTime TastingDate { get; set; }
        }

        // Dodawanie i Edycja
        public class CreateTastingDto
        {
            [Required]
            [MaxLength(100)]
            public string Name { get; set; } = string.Empty;

            [MaxLength(50)]
            public string Producer { get; set; } = string.Empty;

            [MaxLength(50)]
            public string Region { get; set; } = string.Empty;

            [MaxLength(100)]
            public string Varietal { get; set; } = string.Empty;

            public int? Vintage { get; set; }
            public decimal? Price { get; set; }

            [Required]
            public WineType Type { get; set; } // Enum (1=Red, 2=White...)

            // --- OKO ---
            public IntensityLevel EyeIntensity { get; set; }
            public string EyeColor { get; set; } = string.Empty;
            public string? EyeOther { get; set; }

            // --- NOS ---
            public IntensityLevel NoseIntensity { get; set; }
            public string? AromasPrimary { get; set; }
            public string? AromasSecondary { get; set; }
            public string? AromasTertiary { get; set; }

            // --- USTA ---
            public SweetnessLevel Sweetness { get; set; }
            public double Acidity { get; set; }
            public double? Tannins { get; set; } // Nullable dla białego wina
            public double Alcohol { get; set; }
            public double Body { get; set; }
            public double FlavorIntensity { get; set; }
            public double Finish { get; set; }

            // --- WNIOSKI ---
            [Range(1, 10)]
            public int Rating { get; set; }

            [Range(1, 10)]
            public int QPrRatio { get; set; }

            public RepurchaseDecision Repurchase { get; set; }
            public string? Notes { get; set; }
        }
    }
}
