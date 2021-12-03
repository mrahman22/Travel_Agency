using System.Collections.Generic;

namespace Travel_Agency
{
    public interface IFetchData
    {
        List<T> GetData<T>(DataType dataType);
    }
}