/*16) Implementar un programa que permita al usuario ingresar números por la consola. Debe ingresarse
un número por línea finalizado el proceso cuando el usuario ingresa una línea vacía. A medida que se
van ingresando los valores el sistema debe mostrar por la consola la suma acumulada de los mismos.
Utilizar double.Parse() y try/catch para validar que la entrada ingresada sea un número válido,
en caso contrario advertir con un mensaje al usuario y proseguir con el ingreso de datos.*/
double suma = 0;
while (true)
{
    try 
    {
        string a  = Console.ReadLine();
        suma += double.Parse(a);
        Console.WriteLine("La suma es " + suma);

    }
    catch (FormatException e)
    {
        Console.WriteLine("El formato no es válido, por favor ingrese un número real");

    }


}