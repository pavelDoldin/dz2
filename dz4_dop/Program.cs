// task dop
// https://acmp.ru/asp/do/index.asp?main=task&id_course=1&id_section=5&id_topic=114&id_problem=702

Console.Clear();
Console.Write("Введиет количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int [n];
int[] arrayHelp = new int [n];
for (int i = 0; i < array.Length; i++)
    array [i] = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"[{string.Join(", ", array)}]");
int k = Convert.ToInt32(Console.ReadLine());
k = k % n;
if (k > 0)
{
    for (int i = 0; i < k; i++)
        arrayHelp[i] = array[n - k + i];
    for (int i = 0;i < n - k; i++ )
        arrayHelp[k + i] = array[i];

    Console.WriteLine($"[{string.Join(", ", arrayHelp)}]");
}
else
{
    k = (-1) * k;
    for (int i = 0; i < k; i++)
        arrayHelp[n - k + i] = array[i];
    for (int i = 0; i < n - k; i++)  
        arrayHelp[i] = array[k + i];
    Console.WriteLine($"[{string.Join(", ", arrayHelp)}]");
}
