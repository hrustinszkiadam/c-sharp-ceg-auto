namespace ceg_auto;

class Benzinkut(double benzinMennyiseg, int literAr, int kasszaPenz) {
   public double BenzinMennyiseg { get; set; } = benzinMennyiseg;
   public int LiterAr { get; set; } = literAr;
   public int KasszaPenz { get; set; } = kasszaPenz;

   public void Tankol(Auto auto, double liter) {
      if(liter > BenzinMennyiseg) return;
      if (auto.BenzinSzint + liter > auto.TankMeret)
         liter = auto.TankMeret - auto.BenzinSzint;

      auto.BenzinSzint += liter;
      BenzinMennyiseg -= liter;
      auto.SoforPenz -= (int)(liter * LiterAr);
      KasszaPenz += (int)(liter * LiterAr);
   }
}