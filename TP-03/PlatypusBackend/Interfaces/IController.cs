using System.Collections.Generic;

namespace BackendPlatypus.Interfaces
{
    public interface IController<T> where T : class
    {
        void DeleteItem(string id);

        IList<T> GetAll();
    }
}
