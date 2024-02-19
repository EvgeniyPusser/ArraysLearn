//Console.Write($"\t1\t2\t3");
Console.Write("Put size of Array  ");
int n = Convert.ToInt32(Console.ReadLine());

int [,] table1 = new int[n, n];

for(int i = 0; i < n; i++){
    Console.Write($"{i + 1}");
    for (int j = 0; j < n; j++){
      //Console.Write($"\t{table1[i, j]}");
        table1[i, j] = (i + 1) * (j + 1);
    }
    Console.WriteLine();

}

for(int i = 0; i < n; i++){
    Console.Write($"{i + 1}");
    for (int j = 0; j < n; j++){
      Console.Write($"\t{table1[i, j]}");
       // table1[i, j] = (i + 1) * (j + 1);
    }
    Console.WriteLine();

}
