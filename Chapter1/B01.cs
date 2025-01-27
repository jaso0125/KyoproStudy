namespace KyoproStudy.Chapter1
{
    public static partial class B01
    {
        public static int SumAandB(string a, string b)
        {
            var intA = int.Parse(a);
            var intB = int.Parse(b);

            return intA + intB;
        }
    }
}