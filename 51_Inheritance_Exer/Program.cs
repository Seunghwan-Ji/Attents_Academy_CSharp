namespace Electronics
{
    // 가전제품 클래스를 만드세요
    // 가전제품 판매점에서 가전제품 관리를 위한 프로그램을 개발하려고 합니다.
    // 1차로 적용되어야 하는 가전제품은 TV, 냉장고, 세탁기입니다.
    // 가전제품이 공통으로 필요한 정보는 높이, 폭, 깊이, 제조년월일, 제작회사명, 중량, 위치정보(A지역 5칸)
    // TV는 화면사이즈, 해상도
    // 냉장고는 용량, 최대 냉각 온도, 전기 사용량
    // 세탁기는 세탁용량, 세탁수조방식(수직형(통돌이), 수평형(트롬))
    // 입니다.
    // 각각의 클래스를 만들고 값을 저장한 후에 출력하시고
    // 상속을 한 후에 컴퓨터를 추가하세요.
    // 각 클래스는 정보를 출력하는 기능
    // 보관되어있는 위치 정보를 출력하는 기능
    // 각 클래스를 따른 파일에 각각 구현 하시고
    // namespace Electronics 안에 구현하세요...

    class 가전제품
    {
        private float _높이;
        private float _폭;
        private float _깊이;
        private string _제조년월일;
        private string _제작회사명;
        private float _중량;
        private string _위치정보;

        public 가전제품(float 높이, float 폭, float 깊이, string 제조년월일, string 제작회사명, float 중량, string 위치정보)
        {
            _높이 = 높이;
            _폭 = 폭;
            _깊이 = 깊이;
            _제조년월일 = 제조년월일;
            _제작회사명 = 제작회사명;
            _중량 = 중량;
            _위치정보 = 위치정보;
        }

        public void Info()
        {
            Console.WriteLine($"높이: {_높이}, 폭: {_폭}, 깊이: {_깊이}, 제조년월일: {_제조년월일}, 제작회사명: {_제작회사명}, 중량: {_중량}, 위치정보: {_위치정보}");
        }

        public void LocationInfo()
        {
            Console.WriteLine($"보관된 위치: {_위치정보}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            TV tv = new TV(50.0f, 100.0f, 10.0f, "2023-01-01", "Samsung", 20.0f, "A지역 1칸", 55.0f, "4K");
            tv.Info();
            tv.LocationInfo();

            냉장고 refrigerator = new 냉장고(180.0f, 80.0f, 60.0f, "2022-05-01", "LG", 70.0f, "A지역 2칸", 300.0f, -18.0f, 150.0f);
            refrigerator.Info();
            refrigerator.LocationInfo();

            세탁기 washingMachine = new 세탁기(100.0f, 60.0f, 60.0f, "2021-10-01", "Whirlpool", 50.0f, "A지역 3칸", 7.0f, "수직형");
            washingMachine.Info();
            washingMachine.LocationInfo();

            컴퓨터 computer = new 컴퓨터(30.0f, 20.0f, 10.0f, "2024-01-01", "Dell", 5.0f, "A지역 4칸", "Intel i9", "32GB", "RTX5090");
            computer.Info();
            computer.LocationInfo();
        }
    }
}
