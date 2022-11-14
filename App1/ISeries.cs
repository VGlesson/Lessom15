using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    interface ISeries
    {
        void SetStart(int х);
        int GetNext();
        void Reset();
    }

    class ArithProgression : ISeries
    {
        double first;
        double step;
        public ArithProgression(double first, double step) { this.first = first; this.step = step; }
        public double GetElem(int n) { return first + step * (n - 1); }

        public int GetNext()
        {
            throw new NotImplementedException();
        }

        public double GetSumm(int n) { return n * (first + GetElem(n)) / 2; }

        public void Reset()
        {
            throw new NotImplementedException();
        }

        public void SetStart(int х)
        {
            throw new NotImplementedException();
        }
    }

    class GeomProgression : ISeries
    {
        double first;
        double step;
        public GeomProgression(double first, double step) { this.first = first; this.step = step; }
        public double GetElem(int n) { return first * Math.Pow(step, n - 1); }

        public int GetNext()
        {
            throw new NotImplementedException();
        }

        public double GetSumm(int n) { return first * ((1 - Math.Pow(step, n)) / (1 - step)); }

        public void Reset()
        {
            throw new NotImplementedException();
        }

        public void SetStart(int х)
        {
            throw new NotImplementedException();
        }
    }
}
