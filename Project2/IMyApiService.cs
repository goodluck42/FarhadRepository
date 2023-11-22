using System.Runtime.InteropServices.JavaScript;

namespace Project2;

public interface IMyApiService
{
    IEnumerable<int> GetData();
    void SaveData(IEnumerable<int> data);
}