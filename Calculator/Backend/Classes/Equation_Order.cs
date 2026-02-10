namespace Calculator.Backend.Classes
{
    internal class Equation_Order
    {
        public int Index { get; set; }
        public double First_Value { get; set; }
        public double Second_Value { get; set; }
        public char Operator { get; set; }
    }
}

//reindexing
//point based on wraped parentesis and operator

//for parentesis index create empty index for put result and delete two indexes after taht after calculate