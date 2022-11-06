namespace InterviewProblems;
public static class BucketSort
{
    public static List<Person> Sort(List<Person> input)
    {
        // The keys are people's ages
        Dictionary<int, List<Person>> buckets = new Dictionary<int, List<Person>>();

        foreach(Person p in input)
        {
            if (!buckets.TryGetValue(p.age, out _))
            {
                buckets[p.age] = new List<Person>();
            }

            buckets[p.age].Add(p);
        }

        List<Person> result = new List<Person>();

        // We assume all ages are in range [0, 1000[
        for (int i=0; i<1000; i++)
        {
            if (buckets.TryGetValue(i, out List<Person> list))
            {
                result.AddRange(list);
            }
        }

        return result;
    }
}

public struct Person
{
    public readonly int age;
    public readonly string name;

    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }
}
