# ElectricalLab
Calculations on basics circuits

There are 3 methods on this library , CalcMono , CalcToPolar and CalcToRectangular. To use these methods the correct syntax is as follows.

CalcMono
var calc = objectname.CalcMono(Resistence_Value,Current_Value,Tension_Value); //the parameter to be calculated must be 0;
//The return of this method is a Tuple , so in order to return it the syntax is:
Console.WriteLine(calc.Item1 + "-" + calc.Item2.ToString());

CalcRectangular
objectname.CalcToRec(Real_part,Imaginary_part);
// the return for this method is a string , so in order to return it corectly:
string x = objectname.CalcToRetangular(Real_part,Imaginary_part);

CalcPolar
just as the retangular counterpart
objectname.CaclToPolar(Real_part,Imaginary_part);
string x = objectname.CaclToPolar(Real_part,Imaginary_part);


There are still more to come , recomend me any calculations that you like to use!!
