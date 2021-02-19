using System;
using GREhigh.Infrastructure.Interfaces;

namespace GREhigh.Infratructure.SimpleRandomizer {
    public class SimpleRandomizer : IRandomizer {
        private static readonly Random _random = new();

    }
}
