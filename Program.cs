Console.WriteLine("Ingresa un numero: ");
float num1 = Int32.Parse(Console.ReadLine());

Console.WriteLine("Ingresa el segundo numero: ");
float num2 = Int32.Parse(Console.ReadLine());

Console.WriteLine("Ingrese +, -, * o /");
String operador = Console.ReadLine();

float resultado;
switch (operador)
{
    case "+":
        resultado = num1 + num2;
        Console.WriteLine("La suma de " + num1 + " mas " + num2 + " es: " + resultado);
    break;
    case "-":
        resultado = num1 - num2;
        Console.WriteLine("La resta de " + num1 + " menos " + num2 + " es: " + resultado);
    break;
    case "*":
        resultado = num1 * num2;
        Console.WriteLine("El producto de " + num1 + " por " + num2 + " es: " + resultado);
    break;
    case "/":
        resultado = num1 / num2;
        Console.WriteLine("La division de " + num1 + " entre " + num2 + " es: " + resultado);
    break;
    default:
        Console.WriteLine("No ingresaste ningun operador");
    break;
}


//Console.WriteLine(num1);