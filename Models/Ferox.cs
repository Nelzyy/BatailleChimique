using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatailleChimique
{
    class Ferox : Bateau
    {
        public Ferox(int id) : base(id)
        {
            this.type = Type.Fer; 
        }
    }
}
