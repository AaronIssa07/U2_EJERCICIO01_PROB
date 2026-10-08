using System;

Console.WriteLine("SISTEMA DE EVALUACIÓN DE CONSUMO ELÉCTRICO DE MOTOR DC");
Console.WriteLine();

// Creacion del objeto a través de la clase "Motor"
MotorDC motor1 = new MotorDC();

// Capturar las PROPIEDADES
Console.Write("Ingrese el identificador del motor: ");
motor1.Id = Console.ReadLine() ?? "Sin ID";

Console.Write("Ingrese el voltaje de alimentación (V): ");
motor1.Voltaje = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese la corriente consumida (A): ");
motor1.Corriente = Convert.ToDouble(Console.ReadLine());

// Creación de MÉTODOS para obtener resultados
double potenciaCalculada = motor1.CalcularPotencia();
string estadoConsumo = motor1.DeterminarEstadoConsumo();

// Mostrar resultados con unidades físicas
Console.WriteLine();
Console.WriteLine($"Motor ID: {motor1.Id}");
Console.WriteLine($"Voltaje: {motor1.Voltaje:F2} V");
Console.WriteLine($"Corriente: {motor1.Corriente:F2} A");
Console.WriteLine($"Potencia eléctrica: {potenciaCalculada:F2} W");
Console.WriteLine($"Estado de consumo: {estadoConsumo}");


// DEFINICIÓN DE LA CLASE
class MotorDC
{
    // PROPIEDADES
    public string Id { get; set; } = "";
    public double Voltaje { get; set; }
    public double Corriente { get; set; }

    // MÉTODOS
    // Método para calcular la potencia eléctrica (P = V * I)
    public double CalcularPotencia()
    {
        return Voltaje * Corriente;
    }

    // Método para determinar el estado según la potencia
    public string DeterminarEstadoConsumo()
    {
        if (CalcularPotencia() <= 120)
        {
            return "Consumo normal";
        }
        else
        {
            return "Consumo elevado";
        }
    }
}