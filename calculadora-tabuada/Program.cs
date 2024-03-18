Clear();

// Declaração de variáveis
double firstvalue = 0.0;
double secondvalue = 0.0;
double result = 0.0;
double tabuada = 0.0;
int option = 0;

//primeiro valor
Write("************ CALCULADORA ************\n"+
      "         insira um número\n"+
      "                      ");
firstvalue = Convert.ToDouble(ReadLine());
Clear();

Write("************ CALCULADORA ************\n"+
      "      Qual será a operação?\n"+
      "       1   +\n"+
      "       2   -\n"+
      "       3   *\n"+
      "       4   \\ \n"+
      "                      ");

option = Convert.ToInt32(ReadLine());
Clear();

// segundo valor
Write("************ CALCULADORA ************\n"+
      " Para começar, insira outro número\n"+
      "                      ");
secondvalue = Convert.ToDouble(ReadLine());
Clear();


Write("************ CALCULADORA ************\n");
switch(option){
    case 1:
        result = firstvalue+secondvalue;
        break;
    case 2:
        result = firstvalue-secondvalue;
        break;
    case 3:
        result = firstvalue*secondvalue;
        break;
    case 4:
        result = firstvalue/secondvalue;
        break;
    default:
        Write("Opção inválida.");
        break;
}
Write($"          O resultado é: {result}\n"+
       "---------------------------------------------\n"+
       "___________________ *TABUADA* ___________________\n");

for(int i=0; i<9; i++){
    WriteLine($"               {result} * {i+1} = {result*(i+1)}");
}