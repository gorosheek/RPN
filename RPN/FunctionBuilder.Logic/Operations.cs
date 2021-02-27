using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionBuilder.Logic
{
    public abstract class Operations
    {
        public abstract string Name { get; }
        public abstract int Priority { get; }
        public abstract double Calculate(double[] numbers);
    }
    public class Plus : Operations
    {
        public override string Name => "+";
        public override int Priority => 3;
        public override double Calculate(double[] numbers) { return numbers[1] + numbers[0]; }
    }
    public class Minus : Operations
    {
        public override string Name => "-";
        public override int Priority => 3;
        public override double Calculate(double[] numbers) { return numbers[1] - numbers[0]; }
    }
    public class Mult : Operations
    {
        public override string Name => "*";
        public override int Priority => 2;
        public override double Calculate(double[] numbers) { return numbers[1] * numbers[0]; }
    }
    public class Dev : Operations
    {
        public override string Name => "/";
        public override int Priority => 2;
        public override double Calculate(double[] numbers) { return numbers[1] / numbers[0]; }
    }
    public class Degree : Operations
    {
        public override string Name => "^";
        public override int Priority => 1;
        public override double Calculate(double[] numbers) { return Math.Pow(numbers[1], numbers[0]); }
    }
}
