using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotNumerics.LinearAlgebra;

namespace Studnia
{
    class QuantumWell
    {
        const double h = 1.055e-34;
        const double m = 9.109e-31;
        const double e = 1.602e-19;
        const double C = -h * h / (2 * 0.01 * m);

        //double width;
        //double barrierHeight;
        Matrix eigenVals;
        Matrix eigenVects;

        double[] energy;

        public double Width
        {
            get;
            set;
        }

        public double BarrierHeight
        {
            get;
            set;
        }

        public Matrix EigenVals
        {
            get { return eigenVals; }
        }

        public Matrix EigenVects
        {
            get { return eigenVects; }
        }

        public SymmetricBandMatrix VMatrix
        {
            get; set;
        }

        public SymmetricBandMatrix EkMatrix
        {
            get; set;
        }

        public SymmetricBandMatrix HMatrix
        {
            get; set;
        }
        public QuantumWell()
        {
        }

        public QuantumWell(double width, double barrierHeight)
        {
            this.Width = width;
            this.BarrierHeight = barrierHeight;
        }

        public void Schrodinger(double step, double range)
        {
            int size = (int)(range / step);

            EkMatrix = new SymmetricBandMatrix(size, 1);
            VMatrix = new SymmetricBandMatrix(size, 1);
            HMatrix = new SymmetricBandMatrix(size, 1);

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    // EkMatrix

                    if (i == j)
                        EkMatrix[i, j] = -2 * C / (step * step * 1e-18);
                    else if (Math.Abs(i - j) == 1)
                        EkMatrix[i, j] = 1 * C / (step * step * 1e-18);
                    else
                        EkMatrix[i, j] = 0;

                    //VMatrix

                    if (i == j && (j < (size - Width/step) / 2 || j > (size + Width / step) / 2))
                        VMatrix[i, j] = BarrierHeight * e;
                    else
                        VMatrix[i, j] = 0;
                }
            }

            HMatrix = EkMatrix + VMatrix;

            EigenSystem eigenSystem = new EigenSystem();


            eigenVals = eigenSystem.GetEigenvalues(HMatrix, out eigenVects);

            eigenVals.MultiplyInplace(1 / e);
            VMatrix.MultiplyInplace(1 / e);
            EkMatrix.MultiplyInplace(1 / e);
            HMatrix.MultiplyInplace(1 / e);
        }
    }
}
