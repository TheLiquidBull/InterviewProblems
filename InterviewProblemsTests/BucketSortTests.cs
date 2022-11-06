using FluentAssertions;
using InterviewProblems;

namespace InterviewProblemsTests;

[TestClass]
public class BucketSortTests
{
    [TestMethod]
    public void OutputMustBeSortedByAge()
    {
        // Arrange
        Person person1 = new Person("Alice", 30);
        Person person2 = new Person("Bob", 25);
        Person person3 = new Person("Charlie", 31);
        List<Person> input = new List<Person>
        {
            person1,
            person2,
            person3,
        };
        
        // Act
        List<Person> output = BucketSort.Sort(input);

        // Assert
        List<Person> expected = new List<Person>
        {
            person2,
            person1,
            person3,
        };

        output.Should().BeEquivalentTo(expected);
    }
}
