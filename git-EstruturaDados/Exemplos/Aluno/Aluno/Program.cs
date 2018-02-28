using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aluno
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cria objeto a1 da classe Aluno
            Aluno a1 = new Aluno(40437, "Igor");
            // Configura a nota do aluno a1
            a1.Nota = 7.5f;  // corresponde a:  a1.setNota(7.5f);
            a1.Falta = 0;    // corresponde a:  a1.setFalta(0);

            // Exibe dados do aluno utilizando as propriedades
            // a1.Nome dentro do Console.WriteLine equivale a a1.GetNome()
            Console.WriteLine("O aluno " + a1.Nome + " de RA " + a1.Ra +
                     " tem nota " + a1.Nota + " e " + a1.Falta + " falta(s)" );

            Console.WriteLine();
            // Chama método VisualizarNota do objeto a1
            a1.VisualizarNota();
            Console.WriteLine();
            // Chama método VisualizarFalta do objeto a1
            a1.VisualizarFalta();

            // para manter a console aberta
            Console.ReadKey();

        }
    }
}
