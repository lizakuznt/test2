using System.Text.RegularExpressions;

namespace testpract
{
    public class Class1
    {
        public static bool AreCollectionsInOrder<T>(IEnumerable<T> expected, IEnumerable<T> actual)
        {
            IEnumerator<T> expectedEnumerator = expected.GetEnumerator();
            IEnumerator<T> actualEnumerator = actual.GetEnumerator();

            while (expectedEnumerator.MoveNext() && actualEnumerator.MoveNext())
            {
                if (!EqualityComparer<T>.Default.Equals(expectedEnumerator.Current, actualEnumerator.Current))
                {
                    return false;
                }
            }

            return true;
        }
    }
    
    public class Class2 
    {
        public static bool AreCollectionsEqualIgnoringOrder<T>(IEnumerable<T> expected, IEnumerable<T> actual)
        {
            if (expected == null && actual == null)
                return true;

            if (expected == null || actual == null)
                return false;

            return expected.Count() == actual.Count() && !expected.Except(actual).Any();
        }
    }

    public class Class3
    {
        public double CalculatePercent(double initialValue, double finalValue)
        {

            double delta = finalValue - initialValue;

            double percent = (delta / initialValue) * 100;

            return percent;
        }
    }
}