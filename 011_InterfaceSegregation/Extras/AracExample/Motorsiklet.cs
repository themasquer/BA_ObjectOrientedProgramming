namespace _011_InterfaceSegregation.Extras.AracExample
{
    class Motorsiklet : IArac
    {
        public int TekerlekSayisi { get; set; }
        public YakitTipiEnum YakitTipi { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public int BeygirGucu { get; set; }
        public int MotorHacmi { get; set; }

        public string AracBilgileriniGetir(string satirSonu = " ")
        {
            string arac = "";
            arac += "Tekerlek Sayısı: " + TekerlekSayisi + satirSonu;
            arac += "Yakıt Tipi: " + YakitTipi + satirSonu;
            arac += "Marka: " + Marka + satirSonu;
            arac += "Model: " + Model + satirSonu;
            arac += "Beygir Gücü: " + BeygirGucu + satirSonu;
            arac += "Motor Hacmi: " + MotorHacmi;
            return arac;
        }
    }
}
