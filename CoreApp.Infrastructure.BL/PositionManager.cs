using CoreApp.Interfaces.BL;
using CoreApp.Interfaces.Data;

namespace CoreApp.Infrastructure.BL
{
    public class PositionManager : IPositionManager
    {
        private IPositionRepository _repository;

        public PositionManager(IPositionRepository repository)
        {
            _repository = repository;
        }
    }
}