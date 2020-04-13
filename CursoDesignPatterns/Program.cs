using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CursoDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            NotaFiscalBuilder criador = new NotaFiscalBuilder();
            criador
            .ParaEmpresa("Caelum Ensino e Inovação")
            .ComCnpj("23.456.789/0001-12")

            .comItem(new ItemDaNota("item 1", 100.0))
            .comItem(new ItemDaNota("item 2", 200.0))
            .NaDataAtual()
            .ComObservacoes("Uma obs qualquer");

            criador.AdicionaAcao(new EnviadorDeEmail());
            criador.AdicionaAcao(new NotaFiscalDAO());
            criador.AdicionaAcao(new EnviadorDeSms());

            NotaFiscal nf = criador.Constroi();

            Console.WriteLine(nf.ValorBruto);
            Console.WriteLine(nf.Impostos);

            Console.ReadKey();
        }
    }
}



