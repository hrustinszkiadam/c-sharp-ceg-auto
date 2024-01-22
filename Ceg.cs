namespace ceg_auto;

class Ceg (string cegNev, List<Benzinkut> benzinkutak, List<Auto> autok) {
   public string CegNev { get; set; } = cegNev;
   public List<Benzinkut> Benzinkutak { get; set; } = benzinkutak;
   public List<Auto> Autok { get; set; } = autok;
}