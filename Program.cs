for(int i=1; i>=1 ;){
    
    Console.WriteLine("Escreva de 1 a 10, cada um vai abrir um programa diferente,para finalizar o programa digite 0.");
    i=int.Parse(Console.ReadLine());
    
    
        switch(i){ 

        case 1 :
            Ex1.rodar();
        break;
        
        case 2 :
            Ex2.rodar();
        break;
        
        case 3 :
            Ex3.rodar();
        break;
        
        case 4 :
            Ex4.rodar();
        break;
        
        case 5 :
            Ex5.rodar();
        break;
        
        case 6 :
            Ex6.rodar();
        break;
        
        case 7 :
            Ex7.rodar();
        break;
        
        case 8 :
            Ex8.rodar();
        break;
        
        case 9 :
            Ex9.rodar();
        break;
        
        case 10 :
            Ex10.rodar();
        break;
    }
}
