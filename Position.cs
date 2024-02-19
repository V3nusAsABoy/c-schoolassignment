using System;
namespace cois2020assignment1
{
    public class Position
    {
        public double x { get; set; } // x coordinate
        public double y { get; set; } // y coordinate
        public double z { get; set; } // z cooordinate

        public Position(double dx, double dy, double dz) // constructor for Position with x, y, and z values
        {
            x = dx;
            y = dy;
            z = dz;
        }

        public static void limit(double dx, double dy, double dz) // limits a position to be more than -15.0 and less than 15.0
        {
            double[] values = new double[] { dx, dy, dz };
            for(int i = 0; i < 3; i++)
            {
                if (values[i] > 15.0)
                    values[i] = 15.0;
                if (values[i] < -15.0)
                    values[i] = -15.0;
            }
        }

        public static void randomPos(Position pos) // generates random position values
        {
            var random = new Random();
            pos.x = Math.Round(random.NextDouble() * (-15.0 - 15.0) + 15.0, 2);
            pos.y = Math.Round(random.NextDouble() * (-15.0 - 15.0) + 15.0, 2);
            pos.z = Math.Round(random.NextDouble() * (-15.0 - 15.0) + 15.0, 2);
        }

        public static void Move(double dx, double dy, double dz, Position pos) // moves position by a certain dx, dy, and dz values
        {
            pos.x += dx;
            pos.y += dy;
            pos.z += dz;
            pos.x = Math.Round(pos.x, 2);
            pos.y = Math.Round(pos.y, 2);
            pos.z = Math.Round(pos.z, 2);
            limit(pos.x, pos.y, pos.z);
        }
    }
}

