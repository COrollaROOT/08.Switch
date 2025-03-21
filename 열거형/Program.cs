namespace 열거형
{
    internal class Program
    {
        enum RockPaperScissor
        {
            Rock,
            Paper,
            Scissor
        }

        static void Main(string[] args)
        {
            RockPaperScissor commend;
            Console.WriteLine("묵 찌 빠");
            Console.WriteLine("1. 묵, 2. 찌, 3. 빠");
            string input = Console.ReadLine();
            Enum.TryParse(input, out commend);
            // 가위 바위 보 게임

            switch (commend)
            {
                case RockPaperScissor.Scissor:
                    Console.WriteLine("가위를 냅니다");
                    break;
                case RockPaperScissor.Rock:
                    Console.WriteLine("바위를 냅니다");
                    break;
                case RockPaperScissor.Paper:
                    Console.WriteLine("보를 냅니다");
                    break;
                default:
                    Console.WriteLine("잘못 냈습니다");
                    break;
            }
        }
    }
}
