
using Matrix = Matrix_Multiplication.Matrix;

Matrix obj1 = new Matrix(1, 2, 3, 4);
Matrix obj2=new Matrix(5, 6, 7, 8);

Matrix multi = obj1 * obj2;

Console.WriteLine(multi);
