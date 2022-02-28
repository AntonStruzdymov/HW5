using HWLibrary;
using HWLibrary2;

Cone UserCone = new Cone(9,10);
double result;
double result1;
result = UserCone.BaseArea();
result1 = UserCone.SurfaceArea();
Console.WriteLine($"Площадь основания = {Math.Round(result,2)}, Площадь поверхности = {Math.Round(result1, 2)}");

ArrayWorker UserArray = new ArrayWorker();
int[] testArray = UserArray.InvertArray(new int[] {1,2,3,4,5,6,7});

int[] testArray2 = UserArray.NewArray(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 52, 2);


