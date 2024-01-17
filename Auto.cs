namespace ceg_auto;

class Auto (string nev, int fogyasztas, int tankMeret, int benzinSzint) : Sofor(nev, fogyasztas) {
   public string Nev { get; set; } = nev;
   public int Fogyasztas { get; set; } = fogyasztas; // liter/100km
   public int TankMeret { get; set; } = tankMeret;
   public int BenzinSzint { get; set; } = benzinSzint;

}