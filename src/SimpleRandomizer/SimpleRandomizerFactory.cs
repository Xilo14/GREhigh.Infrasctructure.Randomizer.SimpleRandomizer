using GREhigh.Infrastructure.Interfaces;

namespace GREhigh.Infratructure.SimpleRandomizer {
    public class SimpleRandomizerFactory : IInfrastructureFactory<IRandomizer> {
        public IRandomizer GetInfrastructure() {
            return new SimpleRandomizer();
        }
    }
}
