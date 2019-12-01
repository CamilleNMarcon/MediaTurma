using MediaTurma.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaTurma.Repositorio
{
    public class AlunosRepositorio
    {
        private List<Alunos> Alunos { get; set; }
        public void Dados()

        {
            Alunos = new List<Alunos>();

            Alunos.Add(new Alunos("Anna", 4.0, 2.5, 6.0, 8.0 , 3));

            Alunos.Add(new Alunos("Thais", 7.0, 3.7, 6.4, 7.5 , 14 ));

            Alunos.Add(new Alunos("Giulia", 0.5, 2.7, 0.7, 1.5, 7 ));
           
            Alunos.Add(new Alunos("Camille", 0.0, 0.0, 0.0, 0.0, 50));


        }

        public AlunosRepositorio()
        {
            Dados();
        }

        public List<Alunos> SelecionarTodos()
        {
            return Alunos.OrderBy(t => t.NomeAluno).ToList();
        }
        public Alunos BuscarAluno(string nomeAluno)
        {
            return Alunos.FirstOrDefault(t => t.NomeAluno == nomeAluno);
        }
        public void IncluirAluno(Alunos alunos)
        {
            Alunos.Add(alunos);
        }

        public void EditarNota(Alunos alunos)
        {
            var meusAlunos = BuscarAluno(alunos.NomeAluno);
            int indice = Alunos.IndexOf(meusAlunos);
            Alunos[indice] = alunos;

        }

        public void ExcluirAluno(string nome)
        {
            var meusAlunos = BuscarAluno(nome);
            Alunos.Remove(meusAlunos);
        }



    }
}
