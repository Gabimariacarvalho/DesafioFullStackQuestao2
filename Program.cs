
class Solution
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite caracteres para análise:");
        char[] input = Console.ReadLine().TrimEnd().ToCharArray();
        if (ValidaBalanceamento(input))
            Console.WriteLine("SIM");
        else
            Console.WriteLine("NÃO");
    }


    static Boolean ValidaBalanceamento(char[] input)
    {
        Stack<char> st = new Stack<char>();
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == '{' || input[i] == '(' || input[i] == '[')
                st.Push(input[i]);
            if (input[i] == '}' || input[i] == ')' || input[i] == ']')
            {
                if (st.Count == 0) return false;
                else if (!validaPar(st.Pop(), input[i])) return false;
            }
        }
        if (st.Count == 0) return true;
        else return false;
    }
    static bool validaPar(char caractere1, char caractere2)
    {
        if (caractere1 == '(' && caractere2 == ')') return true;
        else if (caractere1 == '{' && caractere2 == '}') return true;
        else if (caractere1 == '[' && caractere2 == ']') return true;
        else return false;
    }
}
