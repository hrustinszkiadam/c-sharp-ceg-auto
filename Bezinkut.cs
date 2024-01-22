namespace ceg_auto;

class Benzinkut(int benzinMennyiseg, int literAr, int kasszaPenz) {
   public int BenzinMennyiseg { get; set; } = benzinMennyiseg;
   public int LiterAr { get; set; } = literAr;
   public int KasszaPenz { get; set; } = kasszaPenz;

   public void Tankol(Auto auto, int liter) {
      if(liter > BenzinMennyiseg) return;
      if (auto.BenzinSzint + liter > auto.TankMeret)
         liter = auto.TankMeret - auto.BenzinSzint;

      auto.BenzinSzint += liter;
      BenzinMennyiseg -= liter;
      auto.SoforPenz -= liter * LiterAr;
      KasszaPenz += liter * LiterAr;
   }
}