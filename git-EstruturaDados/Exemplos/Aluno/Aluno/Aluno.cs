    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aluno
{
    class Aluno
    {
        // Atributos

        // pode-se gerar as linhas abaixo para cada atributo
        // digitando-se: propfull <tab> <tab>

        private int ra;   // RA do aluno (atributo começa com letra minúscula)

        public int Ra     // propriedade correspondente (começa com letra maiúscula)
                          // a propriedade corresponde ao get e ao set 
        {
            get { return ra; }
            set { ra = value; }
        }

        private string nome;    // nome do aluno (atributo)

        public string Nome      // propriedade correspondente ao atributo nome
        {
            get { return nome; }
            set { nome = value; }
        }

        private float nota;     // nota do aluno (atributo)

        public float Nota       // propriedade correspondente ao atributo nota
        {
            get { return nota; }
            set { nota = value; }
        }

        private int falta;      // quantidade de faltas do aluno (atributo)

        public int Falta        // propriedade correspondente ao atributo falta
        {
            get { return falta; }
            set { falta = value; }
        }

        // Construtor

        /* Construtor vazio pode ser obtido digitando-se: ctor <tab> <tab> */
        /* Construtor com parâmetros pode ser obtido digitando-se Ctrl .
         * selecionar gerar construtor e selecionar os parâmetros desejados */
        public Aluno(int ra, string nome)  //no nosso exemplo, construtor recebe
                                           // ra e nome do aluno
        {
            this.ra = ra;
            this.nome = nome;
        }

        // Métodos
        public void VisualizarNota()
        {
            Console.WriteLine("A nota do aluno {0} é {1:F2}", nome, nota);
        }

        public void VisualizarFalta()
        {
            Console.WriteLine("A quantidade de faltas do aluno {0} é {1}", 
                               nome, falta);
        }


    }
}
