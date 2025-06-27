using System;

public class Ex5{

    public static void rodar(){
        int[] sorte=new int[5];
        sorte = sorteandoNumeros(sorte);

        tenteASorte(sorte);
        
    }
    
    public static void tenteASorte(int[] sorte) {
    int numero = 0, acertou = int.MaxValue;
    

        //continua executando enquanto não encontrar.
        while (acertou != numero) {

            //indica o que deve ser feito ao usuario.
            Console.WriteLine("\nTente acertar um dos 5 números do vetor que tem números inteiros entre 10 e 30");
            numero = int.Parse(Console.ReadLine());
  
            //testa todos os números no vetor e se acertar sai por aqui do for
            for (int i = 0; i < sorte.Length; i++) {
                if (sorte[i] == numero) {
                    acertou = sorte[i];
                }
            }

            //se não acertar vem pra cá
            if (acertou != numero) {
                Console.WriteLine("Não foi dessa vez, tente novamente.\n");
            }
        }
    //chega aqui só se tiver acertado
    Console.WriteLine("\nALELUIA CE ACERTOU!!!\nPARABÉNS!!!");
    }




    public static int[] sorteandoNumeros(int[] vetor){
        //criando objeto para Random(para pegar números aleatorios)
        Random r= new Random();
        for(int i=0;i<vetor.Length;i++){
            //usando valores aleatorios entre 10 e 30 para preencher o vetor de 5 valores
            vetor[i]=r.Next(10,31);

        }
        //retornando o vetor sorteado
        return vetor;
    }
        
}