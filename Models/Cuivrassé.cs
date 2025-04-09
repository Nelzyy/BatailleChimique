using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatailleChimique
{
    class Cuivrassé : Bateau
    {
        public Cuivrassé(int id) : base(id)
        {
            this.type = Type.Cuivre;
        }
    }
}
