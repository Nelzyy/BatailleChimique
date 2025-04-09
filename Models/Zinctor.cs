using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatailleChimique
{
    class Zinctor : Bateau
    {
        public Zinctor (int id) : base(id)
        {
            this.type = Type.Zinc;
        }
    }
}
