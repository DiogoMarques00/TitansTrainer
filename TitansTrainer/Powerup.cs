using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TitansTrainer
{
   public class Powerup
    {
        private int m_Nome;
        private double m_Bonus;

        public int Nome
        {
            get
            {
                return m_Nome;
            }
            set
            {
                m_Nome = value;
            }
        }

        public double Bonus
        {
            get
            {
                return m_Bonus;
            }
            set
            {
                m_Bonus = value;
            }
        }
            

    }
}
