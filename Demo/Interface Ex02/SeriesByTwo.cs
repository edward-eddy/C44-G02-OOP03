﻿namespace Demo.Interface_Ex02
{
    internal class SeriesByTwo : ISeries
    {
        public int Current { get; set; }

        public void Next()
        {
            Current += 2;
        }

        public void Reset()
        {
            Current = 0;
        }
    }
}
