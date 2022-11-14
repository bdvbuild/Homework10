using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework10
{
    internal class Angle
    {
        int gradus;
        int min;
        int sec;
        public bool isCorrect = true;

        public int Gradus
        {
            get
            {
                return gradus;
            }
            set
            {
                if (gradus < 0)
                    isCorrect = false;
                else
                    gradus = value % 360;
            }
        }

        public int Min
        {
            get
            {
                return min;
            }
            set
            {
                if (min < 0)
                    isCorrect = false;
                else
                {
                    min = value % 60;
                    Gradus += value / 60;
                }
            }
        }

        public int Sec
        {
            get
            {
                return sec;
            }
            set
            {
                if (min < 0)
                    isCorrect = false;
                else
                {
                    sec = value % 60;
                    Min += value / 60;
                }
            }
        }
        public Angle(int gradus, int min, int sec)
        {
            Gradus = gradus;
            Min = min;
            Sec = sec;
        }

        public double ToRadians()
        {
            return gradus * (Math.PI / 180) + min * (Math.PI /( 180 * 60)) + sec * (Math.PI / (180 * 60 * 60));
        }
    }
}
