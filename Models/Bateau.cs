using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatailleChimique
{

    enum Type
    {
        Cuivre,
        Fer,
        Zinc
    }
    class Bateau
    {
        private int id;
        protected Type type;
        protected Bateau(int id)
        {
            this.id = id;
        }


    }
}
