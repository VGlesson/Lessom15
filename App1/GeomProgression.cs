using System;

namespace App1
{
    class GeomProgression : ISeries
    {
        double first;
        double step;
        public Geom(double first, double step) { this.first = first; this.step = step; }
        public double GetElem(int n) { return first * Math.Pow(step, n - 1); }
        public double GetSumm(int n) { return first * ((1 - Math.Pow(step, n)) / (1 - step)); }

    }
}
