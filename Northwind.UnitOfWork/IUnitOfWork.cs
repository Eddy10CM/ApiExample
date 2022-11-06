using Northwind.Repositories;

namespace Northwind.UnitOfWork
{
    public interface IUnitOfWork
    {
        public ICustomerRepository Customer { get; }
    }
}
