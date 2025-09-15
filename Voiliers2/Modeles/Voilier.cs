using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voiliers2.Modeles
{
    public class Voilier
    {
        #region Proprietes
        private int _capacite;

      
        #endregion

        #region Constructeurs
        public Voilier(int capacite)
        {
            Capacite = capacite;
        }

        #endregion

        #region Getters/Setters
        public int Capacite { get => _capacite; set => _capacite = value; }

        #endregion

        #region Methodes
        #endregion
    }
}
