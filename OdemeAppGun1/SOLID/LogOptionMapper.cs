namespace OdemeAppGun1.SOLID
{
    public static class LogOptionMapper
    {
        
        // Maps a user-friendly display name to the corresponding class name.
        // Maps the display name from the UI to the corresponding class name 
        public static string MapDisplayNameToClassName(string displayName)
        {
            return displayName switch
            {
                "Kredi Kartı" => "KrediKarti",
                "Mail Order"  => "MailOrder",
                "Apple Pay"   => "ApplePay",
                "BTK Coin"    => "BTKCoin",
                "Retina Pay"    => "RetinaPay",
                "Google Pay" => "GooglePay",
                "Nakit Ödeme" => "NakitOdeme",
                _             => string.Empty,
            };
        }
    }
}
