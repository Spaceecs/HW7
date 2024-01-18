using PV321_CSharp;

Matrix matrix = new Matrix(5,5);
matrix.SetRandom();
int res = 0;
res = matrix.Less(6);
Console.WriteLine($"Result = {res}");
res = matrix.Greater(6);
Console.WriteLine($"Result = {res}");
matrix.ShowOdd();
matrix.ShowEven();
res = matrix.CountDistinct();
Console.WriteLine($"Result = {res}");
res = matrix.EqualToValue(5);
Console.WriteLine($"Result = {res}");