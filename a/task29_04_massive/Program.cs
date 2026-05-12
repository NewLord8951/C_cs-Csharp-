using System;

Console.Write("Введите размер массива: ");
int a = int.Parse(Console.ReadLine());
int[] h = new int[a];
for(int i = 0; i < a; i++) {
    Console.Write("Введите элемент массива: ");
    h[i] = int.Parse(Console.ReadLine());
}
for(int i = 1; i < a - 1; i++) {
    if(i == 2) {
        if(h[i] < h[i + 1]) {
            Console.Write("ЫA: ");
            Console.WriteLine(h[i]);
        }
    }
    if(h[i] < h[i - 1] && h[i] < h[i + 1]) {
        Console.Write("Ы: ");
        Console.WriteLine(h[i]);
    }
    if(i == a) {
        if(h[i] < h[i - 1]) {
            Console.Write("ЫS: ");
            Console.WriteLine(h[i]);
        }
    }
}