namespace ceg_auto;

class Ceg (string cegNev, Benzinkut benzinkut, List<Auto> autok) {
   public string CegNev { get; set; } = cegNev;
   public Benzinkut Benzinkut { get; set; } = benzinkut;
   public List<Auto> Autok { get; set; } = autok;

   public void AutokElkuldese() {
      Random rnd = new();
      foreach (Auto auto in Autok) {
         auto.Utazik(rnd.Next(50, 201), Benzinkut);
      }
   }

}