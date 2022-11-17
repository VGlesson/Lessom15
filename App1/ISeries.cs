using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    interface ISeries
    {
        void SetStart(int x);
        int GetNext();
        void Reset();
    }
    class ArithProgression : ISeries
    {
        int step;
        int startValue;
        int currrntValue;
        public int GetNext()
        {
            currrntValue += step;
            return currrntValue;
        }

        public void Reset()
        {
            currrntValue = startValue;
        }

        public void SetStart(int x)
        {
            startValue = x;
            currrntValue = startValue;
        }
        public void SetStep(int s)
        {
            step = s;
        }
    }
    class GeomProgression : ISeries

    {
        int step;
        int startValue;
        int currrntValue;
        public int GetNext()
        {
            currrntValue *= step;
            return currrntValue;
        }

        public void Reset()
        {
            currrntValue = startValue;
        }

        public void SetStart(int x)
        {
            startValue = x;
            currrntValue = startValue;
        }
        public void SetStep(int s)
        {
            step = s;
        }
    }
}

