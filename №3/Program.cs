Console.Clear();
double[] num = { 3.14, 2.718, 1.618, 0.577, 1.414, 2.236, 0.866, 1.732, 1.155, 0.577 };

        double min = num[0];
        double max = num[0];

        for (int i = 1; i < num.Length; i++)
        {
            if (num[i] < min)
            {
                min = num[i];
            }
            if (num[i] > max)
            {
                max = num[i];
            }
        }

        double difference = max - min;

        Console.WriteLine("Разница между максимальным и минимальным элементами массива: " + difference);

