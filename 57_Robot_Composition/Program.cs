namespace _57_Robot_Composition
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
        private readonly Arm _leftArm;
        private readonly Arm _rightArm;

        public Robot(string name, Arm leftArm, Arm rightArm)
        {
            _name = name;
            _leftArm = leftArm;
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

    class CannonArmRobot : Robot
    {
        public CannonArmRobot(CannonArm leftArm, CannonArm rightArm)
            : base("CannonArmRobot", leftArm, rightArm)
        {
            
        }        
    }

    class RocketArmRobot : Robot
    {
        public RocketArmRobot(RocketArm leftArm, RocketArm rightArm)
            : base("RocketArmRobot", leftArm, rightArm)
        {
            
        }
    }

    class SparkArmRobot : Robot
    {
        public SparkArmRobot(SparkArm leftArm, SparkArm rightArm)
            : base("SparkArmRobot", leftArm, rightArm)
        {
            
        }
    }

    class GunArmRobot : Robot
    {
        public GunArmRobot(GunArm leftArm, GunArm rightArm)
           : base("GunArmRobot", leftArm, rightArm)
        {

        }
    }

    class LeftGunArmRightRocketArmRobot : Robot
    {
        public LeftGunArmRightRocketArmRobot(GunArm leftArm, RocketArm rightArm)
           : base("왼건오로켓암로봇", leftArm, rightArm)
        {

        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            CannonArmRobot cannonArmRobot = new CannonArmRobot(new CannonArm(), new CannonArm());
            RocketArmRobot rocketArmRobot = new RocketArmRobot(new RocketArm(), new RocketArm());
            SparkArmRobot sparkArmRobot = new SparkArmRobot(new SparkArm(), new SparkArm());
            LeftGunArmRightRocketArmRobot lgunArmRrocketArmRobot = new LeftGunArmRightRocketArmRobot(new GunArm(), new RocketArm());

            cannonArmRobot.Info();
            Console.WriteLine();
            rocketArmRobot.Info();
            Console.WriteLine();
            sparkArmRobot.Info();
            Console.WriteLine();
            lgunArmRrocketArmRobot.Info();
        }
    }
}
