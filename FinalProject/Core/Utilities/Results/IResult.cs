public interface IResult
{
    // Sadece void operasyonlar içindir 
    // veri döndüren operasyonlar için ayrı interface olacak o da
    // buradan implement edip mesaj ve successi alacak ekstra data içerecek.
    bool Success{get;}
    string Message{get;}
    
}