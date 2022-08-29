using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_POO_28082022
{
    public class Funcional
        {
            int Inteiro = +10;
            ushort InteiroSemSinal = 10;
            long InteiroLongo = 123456789L;
            string Texto = "Teste 123456789";
            float Real = +10.6f;
            double RealDePrecisao = +10.0123456789d;


        public int Novo1(int aux) => Inteiro = aux;

        public ushort Novo1(ushort aux)=> InteiroSemSinal = aux;
            
        public long Novo1(long aux)=> InteiroLongo = aux;

        public string Novo1(string aux)=> Texto = aux;

        public float Novo1(float aux)=> Real = aux;

        public double Novo1(double aux)=> RealDePrecisao = aux;




            public void imp1()
            {
                Console.WriteLine(Inteiro);
                Console.WriteLine(InteiroSemSinal);
                Console.WriteLine(InteiroLongo);
                Console.WriteLine(Texto);
                Console.WriteLine(Real);
                Console.WriteLine(RealDePrecisao);
            }
        }
    }

