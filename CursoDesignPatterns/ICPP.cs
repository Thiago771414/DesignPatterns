using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CursoDesignPatterns
{
    public class ICPP : TemplateDeImpostoCondicional
    {
        public override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor >= 500;
        }
        public override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.07;
        }

        public override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.05;
        }

        //public override double Calcula(Orcamento orcamento)
        //{
        //    if (orcamento.Valor >= 500)
        //    {
        //        return orcamento.Valor * 0.07;
        //    }

        //    return orcamento.Valor * 0.05;
        //}
       //public ICPP(Imposto outroImposto) : base(outroImposto) { }
       //public ICPP() : base() { }
       //public override double Calcula(Orcamento orcamento)
       //{
       //     if (orcamento.Valor >= 500)
       //     {
       //         return orcamento.Valor * 0.07 + CalculoDoOutroImposto(orcamento);
       //     }
       //     return orcamento.Valor * 0.05 + CalculoDoOutroImposto(orcamento);
       //}

        //public override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        //{
        //    return orcamento.Valor >= 500;
        //}

        //public override double MaximaTaxacao(Orcamento orcamento)
        //{
        //    return orcamento.Valor * 0.07;
        //}

        //public override double MinimaTaxacao(Orcamento orcamento)
        //{
        //    return orcamento.Valor * 0.05;
        //}

       
    }
}
