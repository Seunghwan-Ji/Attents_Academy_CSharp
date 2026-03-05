namespace Electronics
{
    class 냉장고 : 가전제품
    {
        private float _용량;
        private float _최대냉각온도;
        private float _전기사용량;

        public 냉장고(float 높이, float 폭, float 깊이, string 제조년월일, string 제작회사명, float 중량, string 위치정보, float 용량, float 최대냉각온도, float 전기사용량)
            : base(높이, 폭, 깊이, 제조년월일, 제작회사명, 중량, 위치정보)
        {
            _용량 = 용량;
            _최대냉각온도 = 최대냉각온도;
            _전기사용량 = 전기사용량;
        }

        public new void Info()
        {
            base.Info();
            Console.WriteLine($"용량: {_용량}, 최대냉각온도:{_최대냉각온도}, 전기사용량: {_전기사용량}");
        }
    }
}
