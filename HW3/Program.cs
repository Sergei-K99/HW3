using System.Collections;

namespace HW3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyArray array = new MyArray();// не совсем уверен, что именно так это должно работать (не совсем понял задание)
            array.Show();
            array.Show("Test");
            Console.WriteLine("Max:" + array.Max());
            Console.WriteLine("Min:" + array.Min());
            Console.WriteLine("Avg:" + array.Avg());
            Console.WriteLine("Search:" + array.Search(4));

            array.SortAsc();
            array.PrintArray();
            array.SortDesc();
            array.PrintArray();
            array.SortByParam(true);
            array.PrintArray();
        }
    }
}

interface IOutput
{
    void Show();
    void Show(string info);
}

interface IMath
{
    int Max();
    int Min();
    float Avg();
    bool Search(int valueToSearch);
}


interface ISort
{
    void SortAsc();
    void SortDesc();
    void SortByParam(bool isAsc);
}

class MyArray : IOutput, IMath, ISort
{
    Random r;
    public int[] mas;
    public MyArray()
    {
        r = new Random();
        mas = new int[5];
        for (int i = 0; i < mas.Length; i++)
        {
            mas[i] = r.Next(1, 10);
        }
    }
    public void Show()
    {
        foreach (int x in mas)
            Console.WriteLine(x);
    }
    public void Show(string info)
    {
        foreach (int x in mas)
        {
            Console.WriteLine($"{x} - {info}");
        }
    }

    public int Max()
    {
        int max = mas[0];
        foreach (int x in mas)
        {
            if (x > max)
            {
                max = x;
            }
        }
        return max;
    }
    public int Min()
    {
        int min = mas[0];
        foreach (int x in mas)
        {
            if (x < min)
            {
                min = x;
            }
        }
        return min;
    }
    public float Avg()
    {
        int avg = 0;
        foreach (int x in mas)
        {
            avg += x;
        }
        avg = avg / mas.Length;
        return avg;
    }
    public bool Search(int valueToSearch)
    {
        foreach (int x in mas)
        {
            if (x == valueToSearch)
            {
                return true;
            }
        }
        return false;
    }

    public void SortAsc()
    {
        int n = mas.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - 1 - i; j++)
            {
                if (mas[j] > mas[j + 1])
                {
                    int temp = mas[j];
                    mas[j] = mas[j + 1];
                    mas[j + 1] = temp;
                }
            }
        }
    }

    public void SortDesc()
    {
        int n = mas.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - 1 - i; j++)
            {
                if (mas[j] < mas[j + 1])
                {
                    int temp = mas[j];
                    mas[j] = mas[j + 1];
                    mas[j + 1] = temp;
                }
            }
        }
    }

    public void SortByParam(bool isAsc)
    {
        if (isAsc == true)
        {
            int n = mas.Length;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1 - i; j++)
                {
                    if (mas[j] > mas[j + 1])
                    {
                        int temp = mas[j];
                        mas[j] = mas[j + 1];
                        mas[j + 1] = temp;
                    }
                }
            }
        }
        else
        {
            int n = mas.Length;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1 - i; j++)
                {
                    if (mas[j] < mas[j + 1])
                    {
                        int temp = mas[j];
                        mas[j] = mas[j + 1];
                        mas[j + 1] = temp;
                    }
                }
            }
        }
    }
    public void PrintArray()
    {
        foreach (var item in mas)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}
