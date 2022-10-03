using System;

public class RandomizedSet
{
    List<int> _set;
    Random random = new Random();

    public RandomizedSet()
    {
        _set = new List<int>();
    }

    public bool Insert(int val)
    {
        if (_set.Contains(val))
        {
            Console.WriteLine("already exist" + val);
            return false;
        }
        else
        {
            Console.WriteLine("not exist" + val);
            _set.Add(val);
            return true;
        }
            
    }

    public bool Remove(int val)
    {
        if (_set.Contains(val))
        {
            Console.WriteLine("removed" + val);
            _set.Remove(val);
            return true;
        }
        else
        {
            Console.WriteLine("not found" + val);
            return false;
        }
    }

    public int GetRandom()
    {

        var index = random.Next(0, _set.Count);
        Console.WriteLine($"{_set.Count}, {index}");
        return _set[index];
    }
}
