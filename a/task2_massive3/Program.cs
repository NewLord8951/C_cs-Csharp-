using System;
using System.Text.Json.Serialization;

Console.Write("Размер рваного массива: ");
int u = int.Parse(Console.ReadLine());
int[][] a = new int[u][];
int q = 0;
for (int i = 0; i < u; i++) {
    int s = int.Parse(Console.ReadLine("Размер одномерного массива: "));
    if(q < s){
        q = s;
    }

    int[] ar = new int [s];
    for (int j = 0; j < s; j++){
        ar[j] = int.Parse(Console.ReadLine("Элемент массива: "));
    }
    a[i] = ar;
}
Console.WriteLine("Рваный массив:");
for (int i = 0; i < u; i++) {
    Console.WriteLine(string.Join(" ", a[i]));
}
int[,] b = new int[u, q];
Array.Empty<int>(a);
bool r = !a.Any();
for(int i = 0; i < u; i++) {
    for(int j = 0; j < q; j++) {
        if(b[i, j].()) {
            b[i, j] = 0;
            Console.Write("Press F");
        }
        else {
            Console.Write("БЛ");
        }
        
    }
}