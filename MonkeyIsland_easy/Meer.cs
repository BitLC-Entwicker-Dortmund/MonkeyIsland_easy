using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonkeyIsland_easy {
    internal class Meer {
        private List<Pirat> piraten = new List<Pirat>();

        private Schiff schiff;

        private List<Insel> inseln = new List<Insel>();

        public void AddInsel(Insel insel) {
            inseln.Add(insel);
        }

        public void SetSchiff(Schiff schiff) {
            this.schiff = schiff;
        }

        public Schiff GetSchiff() {
            return this.schiff;
        }

     }
}
