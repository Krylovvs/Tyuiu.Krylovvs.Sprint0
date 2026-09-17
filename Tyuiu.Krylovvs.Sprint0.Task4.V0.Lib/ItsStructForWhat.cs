using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.Krylovvs.Sprint0.Task4.V0.Lib
{
    public readonly record struct Num(int Value)
    {

        public static implicit operator Num(int Value)
            => new Num(Value);
        public static Num operator +(Num a, Num b) =>
            new(a.Value + b.Value);
        public static Num operator -(Num a, Num b) =>
            new(a.Value - b.Value);
        public static Num operator *(Num a, Num b) =>
            new(a.Value * b.Value);
        public static Num operator /(Num a, Num b)
        {
            if (b.Value == 0)
                throw new DivideByZeroException();

            return new Num(a.Value / b.Value);
        }
    }
}
