namespace backend.Models
{
    //TODO: Przemyśleć całkowite usunięcie  enumów
    public enum WineType
    {
        Red = 1,
        White = 2,
        Rose = 3
    }

    public enum IntensityLevel
    {
        Low = 1,     // Jasne / Niska
        Medium = 2,       // Średnie
        High = 3     // Głębokie / Wysoka
    }

    public enum SweetnessLevel
    {
        Dry = 1,        // Wytrawne
        OffDry = 2,     // Półwytrawne
        MediumSweet = 3,// Półsłodkie
        Sweet = 4       // Słodkie
    }

    public enum RepurchaseDecision
    {
        Yes = 1,  // Tak!
        Maybe = 2,// Może!
        No = 3    // Nie!
    }
}