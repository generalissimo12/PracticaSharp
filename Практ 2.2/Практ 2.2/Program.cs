using Практ_2._2;


internal class Program
{
    static void Main(string[] args)
    {
        List<Train> trains = new List<Train>();
        trains.Add(new Train("Moscow", 2, "9:00"));
        trains.Add(new Train("Novosibirsk", 3, "10:33"));

        int input = 0;
        Console.WriteLine("Введите номер поезда или \"1\" для выхода\n");

        while (input != 1)
        {
            string show = "";
            input = Convert.ToInt32(Console.ReadLine());
            if (input == 1) break;
            foreach (Train numTrain in trains)
            {
                if (numTrain.GetNumber == input)
                {
                    show = numTrain.ShowTrain();
                    break;
                }
            }

            if (show != "")
            {
                Console.WriteLine(show);
            }
            else
            {
                Console.WriteLine("Неверный номер поезда");
            }

        }
    }

}



