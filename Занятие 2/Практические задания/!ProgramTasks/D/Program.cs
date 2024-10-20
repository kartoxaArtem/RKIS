namespace D
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Test(true, "boss", 150);
            Test(true, "boss", 30);
            Test(true, "boss", 70);
            Test(false, "boss", 14);
            Test(true, "bot", 90);
            Test(false, "bot", 100000);
            Test(true, "bot", 999);
            Test(true, "bot", 78);
            Test(true, "bot", 44);
            Test(true, "bot", 2);
            Test(true, "bot", 91);
        }

        public static void Test(bool enemyInFront, string enemyName, int robotHealth)
        {
            Console.WriteLine(ShouldFire(enemyInFront, enemyName, robotHealth) == ShouldFire2(enemyInFront, enemyName, robotHealth));
        }

        public static bool ShouldFire(bool enemyInFront, string enemyName, int robotHealth)
        {
            bool shouldFire = true;
            if (enemyInFront == true)
            {
                if (enemyName == "boss")
                {
                    if (robotHealth < 50) shouldFire = false;
                    if (robotHealth > 100) shouldFire = true;
                }
            }
            else
            {
                return false;
            }
            return shouldFire;
        }

        public static bool ShouldFire2(bool enemyInFront, string enemyName, int robotHealth)
        {
            return enemyInFront && enemyName != "boss" || enemyInFront && (enemyName == "boss" && robotHealth >= 50);
        }
    }
}
