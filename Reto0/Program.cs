using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reto0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* C# en el framework .NET será el lenguaje a utilizar durante estos retos
            Aquí la página web oficial del lenguaje, junto a documentación de su aprendizaje:
            https://learn.microsoft.com/es-es/dotnet/ */

            // RETO 0: Introducción

            // Variable sin tipar
            var variableSinTipo = "Ejemplo de variable";

            // Variables tipadas: 

            // Variable de cadenas
            string variableString = "Hola.";

            // Variable de carácteres
            char variableChar = 'a';

            // Variable de enteros (con signo 32 bits)
            int variableNumero = 10;
            // Variable de enteros (con signo 64 bits)
            long variableLong = 10000000000L;
            // Variable de enteros (con signo 16 bits)
            short variableShort = 100;
            // Variable de enteros (sin signo 8 bits)
            byte variableByte = 100;
            // Variable de enteros (con signo 8 bits)
            sbyte variableSByte = -128;
            // Variable de decimal con alta precisión
            decimal variableDecimal = 123.456m;
            // Variable de decimal con precisión simple
            float variableFloat = 3.14f;
            // Variable de decimal con precisión doble
            double variableDouble = 3.141592653589793;

            // Variable booleana
            bool variableBool = false;

            // Variable de fecha y hora
            DateTime variableDateTime = DateTime.Now;
            // Variable de intervalo de tiempo
            TimeSpan variableTimeSpan = TimeSpan.FromDays(1);

            // Variable de cualquier tipo de objeto
            object variableObject = new object();
            // Variable de elusión de tiempo de compilación, resolución en tiempo de ejecución
            dynamic variableDynamic = 10;

            Console.WriteLine("¡Hola, C#!");
        }
    }
}
