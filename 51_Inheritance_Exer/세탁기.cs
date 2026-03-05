namespace Electronics
{
    class 세탁기 : 가전제품
    {
        private float _세탁용량;
        private string _세탁수조방식;

        public 세탁기(float 높이, float 폭, float 깊이, string 제조년월일, string 제작회사명, float 중량, string 위치정보, float 세탁용량, string 세탁수조방식)
            : base(높이, 폭, 깊이, 제조년월일, 제작회사명, 중량, 위치정보)
        {
            _세탁용량 = 세탁용량;
            _세탁수조방식 = 세탁수조방식;
        }

        public new void Info()
        {
            base.Info();
            Console.WriteLine($"세탁용량: {_세탁용량}, 세탁수조방식:{_세탁수조방식}");
        }
    }
}
