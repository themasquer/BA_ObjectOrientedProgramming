using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_Classes.ArabalarProgramlariExampleV5
{
    class Araba
    {
        #region Properties
        public int Id { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public byte KapiSayisi { get; set; }
        public short BeygirGucu { get; set; }
        public ArabaTurleriEnum ArabaTuru { get; set; }
        public short MaksimumHiz { get; set; }
        public byte Cekis { get; set; }
        public double SifirdanYuzeHizlanma { get; set; }
        public double Agirlik { get; set; }
        public double MotorHacmi { get; set; }
        #endregion
    }
}
