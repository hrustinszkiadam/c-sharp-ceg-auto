namespace ceg_auto;

class Auto (string nev, string soforNev, int soforPenz, int fogyasztas, int tankMeret, int benzinSzint): Sofor(soforNev, soforPenz) {
   public string Nev { get; set; } = nev;
   public int Fogyasztas { get; set; } = fogyasztas; // liter/100km
   public int TankMeret { get; set; } = tankMeret;
   public int BenzinSzint { get; set; } = benzinSzint;

   public void Utazik(int km, Benzinkut kut) {
      int szuksegesBenzin = km * Fogyasztas / 100;
      if(BenzinSzint - szuksegesBenzin < 0) {
         Tankol(kut);
         Utazik(km, kut);
      }
      BenzinSzint -= szuksegesBenzin;      
   }

   public void Tankol(Benzinkut kut) {
      int liter = TankMeret - BenzinSzint;
      int fizetendo = liter * kut.LiterAr;
      if (SoforPenz < fizetendo) return;
      kut.Tankol(this, liter);
   }

}