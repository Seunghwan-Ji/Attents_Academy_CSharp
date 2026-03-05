namespace Electronics
{
    class 컴퓨터 : 가전제품
    {
        private string _CPU;
        private string _RAM;
        private string _GPU;

        public 컴퓨터(float 높이, float 폭, float 깊이, string 제조년월일, string 제작회사명, float 중량, string 위치정보, string CPU, string RAM, string GPU)
            : base(높이, 폭, 깊이, 제조년월일, 제작회사명, 중량, 위치정보)
        {
            _CPU = CPU;
            _RAM = RAM;
            _GPU = GPU;
        }

        public new void Info()
        {
            base.Info();
            Console.WriteLine($"CPU: {_CPU}, RAM:{_RAM}, GPU: {_GPU}");
        }
    }
}
