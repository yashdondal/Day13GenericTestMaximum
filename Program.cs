namespace GenericFindMax
{
    public class Program
    {
        static void Main(string[] args)
        {
            FindMaxNo findMaxNo = new FindMaxNo();
            findMaxNo.MaximumNum(10, 20, 30);

            FindMaxString findMaxstring = new FindMaxString();
            findMaxstring.MaximumString("yash", "yashuuu", "yashuuuuu");

            FindMaxFloat findMaxfloat = new FindMaxFloat();
            findMaxfloat.MaximumFloat(21.3, 4.5, 6.7);
        }
    }
}
