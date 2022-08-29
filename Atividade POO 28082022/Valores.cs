using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_POO_28082022
{
    public class Valores
        {
            int Inteiro = +10;
            ushort InteiroSemSinal = 10;
            long InteiroLongo = 123456789L;
            string Texto = "Teste 123456789";
            float Real = +10.6f;
            double RealDePrecisao = +10.0123456789d;


            public int Novo(int aux)
            {
                Inteiro = aux;
                return Inteiro;
            }

            public ushort Novo(ushort aux)
            {
                InteiroSemSinal = aux;
                return InteiroSemSinal;
            }
            public long Novo(long aux)
            {
                InteiroLongo = aux;
                return InteiroLongo;
            }
            public string Novo(string aux)
            {
                Texto = aux;
                return Texto;
            }
            public float Novo(float aux)
            {
                Real = aux;
                return Real;
            }
            public double Novo(double aux)
            {
                RealDePrecisao = aux;
                return RealDePrecisao;
            }


        // impressão para teste
            public void imp()
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

