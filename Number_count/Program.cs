// int [] array = {23, 456, 67, 6};
         
//          for(int i = 0; i < array.Length; i++)
        
//      Console.Write(array[i]);
void Main(){
int [,]array = GenerateArray(4, 4, 1, 18);
PrintArray(array);
int minSumRow = FindMinSummRow(array);
Console.Write(minSumRow);


}

int[,] GenerateArray(int rows, int columns, int LeftRange, int RightRange){
   Random rand = new Random();
   int[,] array = new int [rows, columns];
   for( int i = 0; i < rows; i++)
     {for(int j = 0; j < columns; j++){
        array[i, j] = rand.Next(LeftRange, RightRange);
     }

     }return array;
}

void PrintArray(int [,] array){
    for(int i = 0; i < array.GetLength(0); i++){
        Console.WriteLine();
        for(int j = 0; j < array.GetLength(1); j++){
            Console.Write(array[i,j] +"  ");
        }
    }


}

int FindMinSummRow(int[,]array){
    int row_sum_sum = 0;
    for(int k = 0; k < array.GetLength(0); k++){
        row_sum_sum += array[0, k];}

   
   for(int i = 0; i < array.GetLength(0); i++){ 
        int row_sum = 0;
        for(int j = 0; j < array.GetLength(1); j++){
            row_sum += array[i,j];
        }if(row_sum < row_sum_sum){
            row_sum_sum = row_sum;
        }
   }return row_sum_sum;

}

Main();