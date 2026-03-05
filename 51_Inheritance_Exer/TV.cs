namespace Electronics
{
    class TV : 가전제품
    {
        private float _화면사이즈;
        private string _해상도;

        public TV(float 높이, float 폭, float 깊이, string 제조년월일, string 제작회사명, float 중량, string 위치정보, float 화면사이즈, string 해상도)
            : base(높이, 폭, 깊이, 제조년월일, 제작회사명, 중량, 위치정보)
        {
            _화면사이즈 = 화면사이즈;
            _해상도 = 해상도;
        }

        public new void Info()
        {
            base.Info();
            Console.WriteLine($"화면사이즈: {_화면사이즈}, 해상도:{_해상도}");
        }
    }
}
