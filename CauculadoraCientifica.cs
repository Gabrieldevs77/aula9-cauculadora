namespace aula9_cauculadora
{
    public class CauculadoraCientifica : Cauculadora
    {
        private string[] valores;
        private float val {get; set;}

        private float soma;
        public void CaucularMedia(string txtConsole){
            // Aplicamos o método split para separar os numeros atraves das virgulas
            valores = txtConsole.Split(",");
            // Varremos o array de acordo com o seu tamanho (Length)
            for (int i = 0; i < valores.Length; i++)
            {
                val = float.Parse(valores[i]);
                soma += val;
            }

            //  Retornar na variavel resultado o valor da média
            resultado = soma / valores.Length;
        }

        public void ManipularCalculos(string entradaUsuario){
            // Dividimos a entrada do usuario em um array
            string[] entrada = entradaUsuario.Split(' ');
            //  pegamos as entradas separada e atribuimos as nossas variaveis
            // entrada[0] = 12
            // entrada[1] = +
            // entrada[2] = 12
            num1 = float.Parse(entrada[0]);
            operador = entrada[1];
            num2 = float.Parse(entrada[2]);

            switch (operador){
                default:
                somar();
                break;

                case"+":
                somar();
                break;

                case "-":
                subtrair();
                break;

                case "x":
                multiplicar();
                break;

                case "/":
                dividir();
                break;
            }
        }
    }
}