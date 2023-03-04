
namespace Практ_2_5
{
    public class Del
    {
        private int a;
        private int b;

        public int A
        {
            get => this.a;
            set => this.a = value;
        }

        public int B
        {
            get => this.b;
            set => this.b = value;
        }
        public Del(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public Del()
        {
            a = 777;
            b = 1111;
        }

        ~Del()
        {
            Console.Write($"{a} has been deleted\n");
            Console.Write($"{b} has been deleted");
        }
    }
}