int[,] Create2dRandomIntArray(int row, int column)
{
    int[,] array = new int[row, column];
    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            array[i, j] = new Random().Next(0, 15);
    return array;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            Console.Write(arr[i, j] + "\t");
        Console.WriteLine();
    }
    Console.WriteLine();
}
// сортировка методом выбора 
/*
void SortDescendingOnRows(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1) - 1; j++)
        {
            for (int k = j + 1; k < arr.GetLength(1); k++)
            {
                if (arr[i, k] < arr[i,j])
                {
                    int temp = arr[i,j];
                    arr[i,j] = arr[i,k];
                    arr[i,k] = temp;
                }
            }
        }
    }
}
Console.Write("Input a row number: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a column number: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] newArray = Create2dRandomIntArray(row, column);
PrintArray(newArray);
SortDescendingOnRows(newArray);
PrintArray(newArray);*/

//---------------------------------------------------
// Задайте прямоугольный двумерный массив. Напишите программу, которая 
// будет находить строку с наименьшей суммой элементов.

// метод для нахождения массива сумм элементов по строкам
int[] FindArrayWithSumOnRows(int[,] array){
    int sum;
    int[] arraySumOnRows = new int[array.GetLength(0)];
    for(int i = 0; i < array.GetLength(0); i++){
        sum = 0;
        for(int j = 0; j < array.GetLength(1); j++) sum += array[i, j];
        arraySumOnRows[i] = sum;
    }
    return arraySumOnRows;
}

// метод для нахождения номера минимального элемента в массиве (строки с минимальной 
// суммой из предыдущего метода)
/*int FindRowWithMinSum(int[] arr){
    int minPos = 0;
    for(int i = 1; i < arr.Length; i++) 
        if(arr[i] < arr[minPos]) minPos = i;
    return minPos + 1;
}
// блок ввода-вывода данных
Console.Write("Input a row number: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a column number: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] newArray = Create2dRandomIntArray(row, column);
PrintArray(newArray);
int[] arr = FindArrayWithSumOnRows(newArray);
int rowNumber = FindRowWithMinSum(arr);
Console.WriteLine($"Row with min sum of elements has number {rowNumber}");*/

//-------------------------------------------
// Задайте две матрицы. Напишите программу, которая будет находить 
// произведение двух матриц

// матрицы можно перемножать только в том случае, если они согласованы
// то есть, число столбцов в 1й матрице дб равно числу строк во 2й
/*
bool IsAgreedMatrix(int[,] arr1, int[,] arr2){
    return arr1.GetLength(1) == arr2.GetLength(0);
}
int[,] FindMultiMatrix(int[,] arr1, int[,] arr2){
    int[,] matrix = new int[arr1.GetLength(0), arr2.GetLength(1)];
    if(IsAgreedMatrix(arr1, arr2)) {
        Console.WriteLine("Matrices are agreed :) ");
        for(int i = 0; i < matrix.GetLength(0); i++){
            for(int j = 0; j < matrix.GetLength(1); j++){
                for(int k = 0; k < arr1.GetLength(1); k++)
                    matrix[i,j] += arr1[i,k]*arr2[k,j];
            }
        }
    }
    else {
        Console.WriteLine("Matrices aren't agreed!!!");
        for(int i = 0; i < matrix.GetLength(0); i++){
            for(int j = 0; j < matrix.GetLength(1); j++){
                matrix[i,j] = -1;
            }
        }
    }
    return matrix;
} 
Console.Write("Input a row number of 1st matrix: ");
int r1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a column number of 1st matrix: ");
int c1 = Convert.ToInt32(Console.ReadLine());
int[,] newMatrix1 = Create2dRandomIntArray(r1, c1);
PrintArray(newMatrix1);
Console.Write("Input a row number of 2nd matrix: ");
int r2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a column number of 2nd matrix: ");
int c2 = Convert.ToInt32(Console.ReadLine());
int[,] newMatrix2 = Create2dRandomIntArray(r2, c2);
PrintArray(newMatrix2);
int[,] multiMatrix = FindMultiMatrix(newMatrix1, newMatrix2);
PrintArray(multiMatrix);*/

// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя 
// индексы каждого элемента.

// проведена аналогия с кубом, в котором строки - длина, столбцы - ширина, а третья
// размерность - высота
/*int[,,] Create3dIntArray(){
    Console.Write("Input a cells number on matrix length: ");
    int r1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a cells number on matrix width: ");
    int r2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a cells number on matrix height: ");
    int r3 = Convert.ToInt32(Console.ReadLine());
    int[,,] array = new int[r1, r2, r3];
    for(int i = 0; i < r1; i++){
        for(int j = 0; j < r2; j++){
            for(int k = 0; k < r3; k++){
                Console.Write($"Input element on cell ({i},{j},{k}) in range(10, 100): ");
                array[i,j,k] = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
    return array;
}
// логика вывода: по сути, 3d-матрица - матрица 2d-матриц. И можно представить,
// что в каждой ячейке некой мета-матрицы находится 2d-матрица
void Show3dArray(int[,,] arr){
    for(int i = 0; i < arr.GetLength(0); i++){
        for(int j = 0; j < arr.GetLength(1); j++){
            for(int k = 0; k < arr.GetLength(2); k++){
                Console.Write($"{arr[i,j,k]}({j}, {k}, {i})" + "\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
int[,,] newArray = Create3dIntArray();
Show3dArray(newArray);*/

// Напишите программу, которая заполнит спирально массив 4 на 4.
// постарался решить задачу в общем виде для любой прямоугольной матрицы

int[,] CreateSpiraleIntArray(int row, int column){
    int[,] array = new int[row, column];
    int count = 1;
    int i = 0, j = 0;
    int iUp = 0, iDown = 0, jLeft = 0, jRight = 0;
    // заполнение идет до тех пор, пока значение счетчика не сравняется с общим
    // количеством элементов в матрице (а это "кол-во строк*кол-во столбцов")
    while(count <= row*column){
        array[i, j] = count;
        if(i == iUp && j < column - 1 - jRight) j++;
        else if(j == column - 1 - jRight && i < row - 1 - iDown) i++;
        else if(i == row - 1 - iDown && j > jLeft) j--;
        else i--;

        if ( (i == iUp + 1) && (j == jLeft) && (jLeft != column - 1 - jRight ) ){
            iUp++;
            iDown++;
            jLeft++;
            jRight++;
        }
        count++;
    }
    return array;
}
Console.Write("Input a row number: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a column number: ");
int column = Convert.ToInt32(Console.ReadLine());

int[,] newSpiraleArr = CreateSpiraleIntArray(row, column);
PrintArray(newSpiraleArr);