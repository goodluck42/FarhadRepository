namespace Project2;

public class MsSqlApiService : IMyApiService
{
    private int _data = Random.Shared.Next();
    
    public IEnumerable<int> GetData()
    {
        Console.WriteLine($"MsSqlApiService::GetData() {_data}");

        return new int[] { 10, 20, 30 };
    }

    public void SaveData(IEnumerable<int> data)
    {
    }
}