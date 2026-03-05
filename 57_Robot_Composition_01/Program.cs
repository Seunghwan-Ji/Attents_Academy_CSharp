namespace _57_Robot_Composition_01
{
    class Arm
    {
        private string _name;

        public Arm(string name)
        {
            _name = name;
        }

        public void Info()
        {
            Console.WriteLine($"{_name}");
        }
    }

    class CannonArm : Arm
    {
        public CannonArm()
            : base("CannonArm")
        {

        }
    }

    class RocketArm : Arm
    {
        public RocketArm()
            : base("RocketArm")
        {

        }
    }

    class SparkArm : Arm
    {
        public SparkArm()
            : base("SparkArm")
        {

        }
    }

    class GunArm : Arm
    {
        public GunArm()
           : base("GunArm") { }
    }

    class Robot
    {
        private string _name;
        private Arm _leftArm;
        private Arm _rightArm;

        public Robot(string name, Arm leftArm, Arm rightArm)
        {
            _name = name;
            _leftArm = leftArm;
            _rightArm = rightArm;
        }

        public void SetLeftArm(Arm leftArm)
        {
            _leftArm = leftArm;
        }

        public void SetRightArm(Arm rightArm)
        {
            _rightArm = rightArm;
        }

        public void Info()
        {
            Console.WriteLine($"-- {_name} --");
            Console.Write("왼쪽팔: ");
            _leftArm.Info();
            Console.Write("오른쪽팔: ");
            _rightArm.Info();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Robot cannonArmRobot = new Robot("CannonArmRobot", new CannonArm(), new CannonArm());
            Robot rocketArmRobot = new Robot("RocketArmRobot", new RocketArm(), new RocketArm());
            Robot sparkArmRobot = new Robot("SparkArmRobot", new SparkArm(), new SparkArm());
            Robot lgunArmRrocketArmRobot = new Robot("왼건오로켓암로봇", new GunArm(), new RocketArm());

            cannonArmRobot.Info();
            Console.WriteLine();

            rocketArmRobot.Info();
            Console.WriteLine();

            sparkArmRobot.Info();
            Console.WriteLine();

            lgunArmRrocketArmRobot.Info();
            Console.WriteLine();

            lgunArmRrocketArmRobot.SetLeftArm(new SparkArm());
            lgunArmRrocketArmRobot.Info();
        }
    }
}
