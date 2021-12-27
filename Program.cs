using System.Linq;

int[] array1 = { 1, 2, 3, 4 };
int[] array2 = { 1, 3, 14, 5, 7, 1, 23};
int[] array3 = { 2, -4, 16};
int[] array4 = { 11, 9, 8, 15};
// [1, 3, 14, 5, 7, 1, 23] -> [14, 23]
// [2, -4, 16] -> [16]
// [11, 9, 8, 15]

void PrintArray(int[] arr)
{
    int count = arr.Length;

    if (count == 0) Console.WriteLine("Пустой массив");
    else
    {
        for (int i = 0; i < count; i++)
        {
            Console.Write($"{arr[i]} ");
        }
        Console.WriteLine();
    }

}

int[] Selection1 (int[] arr, int find)  // формирование массива в размере исходного массива с нулевыми элементами
{
    int[] arrayNew = new int[arr.Length]; ;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > find)
        {
            arrayNew[i] = arr[i];
        }
    }
    return arrayNew;
}


int[] Selection2 (int[] arr, int find)  //предварительный подсчет элементов результирующего массива
{
    int m = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > find) m++;
    }
    int[] arrayNew = new int[m];
    
    m = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > find)
        {
            arrayNew[m] = arr[i];
            m++;
        }
    }
    return arrayNew;
}



//Array.ForEach(array, Console.WriteLine);

PrintArray(array2);

int[] arrayRez = Selection1(array2, 8);

arrayRez = arrayRez.Where(x => x != 0).ToArray();  // удаление нулевых элементов

Console.WriteLine("Новый массив с удалением нулевых элементов");

PrintArray(arrayRez);

arrayRez = Selection2(array2, 8);

Console.WriteLine("Новый массив с предварительным подсчетом элементов результирующего массива");

PrintArray(arrayRez);


