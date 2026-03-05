using System.Collections;

namespace _73_Collections_Stack_Exer
{
    // 브라우저 히스토리 시스템 (Stack 활용)
    // visit() : 새페이지 방문
    // GoBack() : 이전으로 가기
    // CurrentPage() : 현재 페이지 
    // HistroyCount() : 기록된  사이트 갯수
    class BrowserHistory
    {
        private Stack _history = new Stack(); // 방문 기록

        public BrowserHistory()
        {
            // 홈페이지로 시작
            _history.Push("홈페이지");
        }

        // 새페이지에 방문
        public void Visit(string url)
        {
            _history.Push(url);
            Console.WriteLine($"방문: {url}");
        }

        public void GoBack()
        {
            if (_history.Count > 1)   // 홈페이지는 남겨두기
            {
                string currentPage = _history.Pop() as string;
                Console.WriteLine($"뒤로가기: {currentPage} -> {CurrentPage()}");

            }
            else
            {
                Console.WriteLine($"저장된 페이지가 없습니다.");
            }
        }

        // 현재 페이지
        public string CurrentPage()
        {
            return _history.Peek() as string;
        }

        // 방문 기록 갯수
        public int HistoryCount()
        {
            return _history.Count;
        }
    }


    // 실행
    public class Program
    {
        public static void Main()
        {
            BrowserHistory browser = new BrowserHistory();

            Console.WriteLine($"시작: {browser.CurrentPage()}");
            Console.WriteLine();

            // 여러 사이트 방문
            browser.Visit("google.com");
            browser.Visit("youtube.com");
            browser.Visit("github.com");
            browser.Visit("stackoverflow.com");

            Console.WriteLine($"\n현재 페이지: {browser.CurrentPage()}");
            Console.WriteLine($"방문 기록: {browser.HistoryCount()}개");
            Console.WriteLine();

            // 뒤로가기 여러 번
            browser.GoBack(); // stackoverflow → github
            browser.GoBack(); // github → youtube  
            browser.GoBack(); // youtube → google
            browser.GoBack(); // google → 홈페이지
            browser.GoBack(); // 더 이상 갈 곳 없음

            Console.WriteLine($"\n최종 페이지: {browser.CurrentPage()}");
        }
    }
}
