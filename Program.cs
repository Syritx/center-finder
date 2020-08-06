using System;

namespace center {

    class Program {

        static Vector3 pointA;
        static Vector3 pointB;

        static int pointsCount = 2; // the amount of coordinates (Vector3) variables there are

        public static void Main(string[] args) {

            #region GIVEN_COORDINATES

            pointA = new Vector3(10, 29, 47);
            pointB = new Vector3(36, 10, 92);

            Vector3 centerCoord;

            float xCenter = (pointA.x + pointB.x) / pointsCount; // calculating the centre of the x's
            float yCenter = (pointA.y + pointB.y) / pointsCount; // calculating the centre of the y's
            float zCenter = (pointA.z + pointB.z) / pointsCount; // calculating the centre of the z's

            centerCoord = new Vector3(xCenter, yCenter, zCenter);
            Console.WriteLine("X: {0} Y: {1} Z: {2}", centerCoord.x, centerCoord.y, centerCoord.z);

            #endregion

            // OR

            #region ARRAY_COORDINATES
            // Finds the center point using an array of points

            Vector3[] points =
            {
                new Vector3(48,234,29),
                new Vector3(93,2,10),
                new Vector3(37,10,49),
                new Vector3(10,37,180)
            };


            float xSum = 0;
            float ySum = 0;
            float zSum = 0;

            for (int i = 0; i < points.Length; i++)
            {
                xSum += points[i].x;
                ySum += points[i].y;
                zSum += points[i].z;
            }

            xCenter = xSum / points.Length;
            yCenter = ySum / points.Length;
            zCenter = zSum / points.Length;
            
            centerCoord = new Vector3(xCenter, yCenter, zCenter);
            Console.WriteLine("X: {0} Y: {1} Z: {2}", centerCoord.x, centerCoord.y, centerCoord.z);

            #endregion
        }
    }
}
