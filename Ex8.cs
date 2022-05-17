public class Ex8 {
    /*Crie um programa com uma lista inicializada com os valores a seguir:
	{ 8, 9, 6, 3, 7, 2, 5, 4, 1, 2, 7, 8, 5, 9, 4, 2, 3 }
	O programa deve remover da lista todos os elementos pares e, ao fim, exibir a lista com os elementos separados por vírgula.
	Dica: use o método Remove(...) de listas e uma estrutura "do..while"*/
    public void Resposta () {

        List <int> lista1 = new List <int>() {8, 9, 6, 3, 7, 2, 5, 4, 1, 2, 7, 8, 5, 9, 4, 2, 3};
        Console.Write("\n-----------------------------------------------------\n\n\tLista antes: ");
        Console.WriteLine(string.Join(", ", lista1));
        int i = 0;
        lista1.RemoveAll(i => i % 2 == 0);
        Console.WriteLine($"\tLista depois: {string.Join(", ", lista1)}\n\n-----------------------------------------------------\n");
    }
}