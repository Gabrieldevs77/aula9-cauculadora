namespace aula9_cauculadora
{
    public class Cauculadora
    {
        public  float num1 { get; set; }

        public float num2 { get; set; }

        public float resultado { get; set; }

        public string operador { get; set; }

            public void somar(){
                resultado = num1 + num2;
            }
            public void subtrair(){
                resultado = num1-num2;
            }
            public void multiplicar(){
                resultado = num1 * num2;
            }
            public void dividir(){
                resultado = num1 / num2;
            }
    }
}