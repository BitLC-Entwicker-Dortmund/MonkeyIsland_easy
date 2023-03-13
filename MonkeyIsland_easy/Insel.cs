using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonkeyIsland_easy {
    internal class Insel {
        private List<Pirat> piraten = new List<Pirat>();
        private Schiff schiff;
        private Strand strand = new Strand();
        private Kneipe kneipe = new Kneipe();

        // Methoden
        public Kneipe GetKneipe() {
            return kneipe;
        }

        public void SetKneipe(Kneipe k) {
            kneipe = k;
        }

        public Strand GetStrand() {
            return strand;
        }

        public void SetStrand(Strand s) {
            strand = s;
        }


    }
}
