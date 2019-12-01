using MediaTurma.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;

namespace MediaTurma.Models
{
    public class Alunos
    {
        private AlunosRepositorio notas;
        public string NomeAluno { get; set; }
        public int TotalDeAulas { get; set; }
        public double FaltasPermitidas { get; set; }
        public double Nota1 { get; set; }
        public double Nota2 { get; set; }
        public double Nota3 { get; set; }
        public double Nota4 { get; set; }
        public string TotalMedia { get; set; }
        public int Faltas { get; set; }

        public double MediaAlunos { 
        get{
              return (Nota1 + Nota2 + Nota3 + Nota4) / 4;

            }

        }
       

        

         public string Status
        {
            get
            {
                
                TotalDeAulas = 50;
                FaltasPermitidas = TotalDeAulas * 0.25;

                if (Faltas >= FaltasPermitidas && MediaAlunos <= 7.0)
                {
                    return "REPROVADO";
                }
                else
                {
                    return "APROVADO";
                }

            }
            set { }
         }

        public string StatusCurso
        {
            get
            {
                if (Faltas <= 50 && MediaAlunos <= 0.0)
                {
                    return "DESISTENTE";
                }
                else
                {
                    return "CURSANDO";
                }
            }
            set { }
        }

        public Alunos(string nomeAluno, double nota1, double nota2, double nota3, double nota4, int faltas)
        {
            

            NomeAluno = nomeAluno;
            Nota1 = nota1;
            Nota2 = nota2;
            Nota3 = nota3;
            Nota4 = nota4;
            
            Faltas = faltas;

                        

        }

        public List<Alunos> RetornarAlunos()
        {
            return notas.SelecionarTodos();
        }

        public Alunos()
        {
            notas = new AlunosRepositorio();
         
        }

        public Alunos BuscarAluno(string nomeAluno)
        {
            return notas.BuscarAluno(nomeAluno);
        }

        public void IncluirAluno(Alunos alunos)
        {
            notas.IncluirAluno(alunos);
        }

        public void EditarNota(Alunos alunos)
        {
            notas.EditarNota(alunos);
        }

        public void ExcluirNota(string nomeAluno)
        {
            notas.ExcluirAluno(nomeAluno);
        }

    }

}

