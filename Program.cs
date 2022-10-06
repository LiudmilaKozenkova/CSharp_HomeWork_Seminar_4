// Есть магазин "Еда". В магазине есть охранник.
// Охранник ведёт запись всех, кто заходит в магазин.
//                       всех, кто выходит из магазина.
// Зайти и выйти можно в целый час.
// Выяснить в какой промежуток времени было больше всего посетителей.
// Данные вводятся парами: приход-уход. 
// Максимум 100 покупателей

// Входные данные      Ответ 
// 10-12               11-12
// 11-13
// 9-12


// // 1. Создать массив из 24 нулей
int[] time = new int[24];

// // 2. Распечатать массив
void Print(int[] array)
{
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

Print(time);

// // 3. Входные данные 1, конвертация строки в число, заполнение текущего массива
string client1 = "10-12";

string[] pair = client1.Split('-');
string pos1 = pair[0];
string pos2 = pair[1];
Console.WriteLine();
int intValue = Convert.ToInt32(pos1);
int intValue2 = Convert.ToInt32(pos2);

int[] Method(int[] array, int timeIn, int timeOut)
{
    for (int i = timeIn; i <= timeOut; i++)
    {
        array[i] += 1;
    }
    return array;
}

int[] result = Method(time, intValue, intValue2);
Print(result);

// Print(time);

// 4. Входные данные 2, конвертация строки в число, заполнение текущего массива
string client2 = "11-13";
string[] s = client2.Split('-');
string p1 = s[0];
string p2 = s[1];
Console.WriteLine();
int intV = Convert.ToInt32(p1);
int intV2 = Convert.ToInt32(p2);

int[] result2 = Method(time, intV, intV2);
Print(result2);

// 4. Входные данные 3, конвертация строки в число, заполнение текущего массива
string client3 = "9-12";

string[] a = client3.Split('-');
string po1 = s[0];
string po2 = s[1];
Console.WriteLine();
int intVa = Convert.ToInt32(po1);
int intVa2 = Convert.ToInt32(po2);

int[] result3 = Method(time, intVa, intVa2);
Print(result3);

// 5. Поиск максимального элемента
int SearchMax(int[] time)
{
    int count = time.Length;
    int max = time[0];
    int maxi = 0;
    for (int i = 0; i < count; i++)
    {
        if (time[i] > max) maxi = i;
    }
    return maxi;
}

int finalResult = SearchMax(time) - 1;
// Console.WriteLine(result);
Console.Write("Максимальное количество покупателей было в промежутке ");
Console.WriteLine($"{finalResult-1}-{finalResult}");


