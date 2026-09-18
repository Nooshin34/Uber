using UberApp.Domain;

namespace Uber.Business.Interfaces
{
    public interface ICar : IBusiness<Car>
    {
        List<Car> GetByUserId(long userId);
    }
}
