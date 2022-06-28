namespace _011_InterfaceSegregation.Extras.AracExample
{
    interface IArac
    {
        int TekerlekSayisi { get; set; }
        YakitTipiEnum YakitTipi { get; set; }
        string Marka { get; set; }
        string Model { get; set; }
        int BeygirGucu { get; set; }
        int MotorHacmi { get; set; }

        string AracBilgileriniGetir(string satirSonu = " ");
    }
}
