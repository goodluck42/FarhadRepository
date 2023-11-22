namespace Project2;

public class MongoApiService : IMyApiService
{
    private int _data = Random.Shared.Next();
    private Random _rnd;

    public MongoApiService(Random rnd)
    {
        _rnd = rnd;
    }
    
    public IEnumerable<int> GetData()
    {
        Console.WriteLine($"MongoApiService::GetData() {_data}");

        return new int[] { 13, 37, 42 };
    }

    public void SaveData(IEnumerable<int> data)
    {
    }
}