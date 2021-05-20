using System;
using System.Collections.Generic;
using System.Text;

namespace DesignParkingSystem
{
    public class ParkingSystem
    {
        private int bigParkingSpace;
        private int mediumParkingSpace;
        private int smallParkingSpace;

        public int BigParkingSpace { get { return bigParkingSpace; } set { bigParkingSpace = value; } }
        public int MediumParkingSpace { get { return mediumParkingSpace; } set { mediumParkingSpace = value; } }
        public int SmallParkingSpace { get { return smallParkingSpace; } set { smallParkingSpace = value; } }

        public ParkingSystem(int big, int medium, int small)
        {
            BigParkingSpace = big;
            MediumParkingSpace = medium;
            SmallParkingSpace = small;
        }

        public bool AddCar(int carType)
        {
            if (carType < 1)
            {
                throw new ArgumentOutOfRangeException("Car type is too small.");
            }

            if (carType > 3)
            {
                throw new ArgumentOutOfRangeException("Car type is too big.");
            }

            //if (BigParkingSpace < 1)
            //{
            //    throw new ArgumentOutOfRangeException("Big parking space is out of spots.");
            //}

            if (carType == 1 && BigParkingSpace > 0)
            {
                bigParkingSpace--;
                return true;
            }

            //if (MediumParkingSpace < 1)
            //{
            //    throw new ArgumentOutOfRangeException("Medium parking space is out of spots.");
            //}

            if (carType == 2 && MediumParkingSpace > 0)
            {
                MediumParkingSpace--;
                return true;
            }

            //if (SmallParkingSpace < 1)
            //{
            //    throw new ArgumentOutOfRangeException("Small parking space is out of spots.");
            //}

            if (carType == 3 && SmallParkingSpace > 0)
            {
                SmallParkingSpace--;
                return true;
            }

            return false;
        }
    }
}
