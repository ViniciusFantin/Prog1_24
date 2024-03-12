// OPERADORES 
int a = 3;
int b = a++; // ++ é um acumulador 
//Neste cas ++ vai somar a + 1 
WriteLine($"a é {a}, b é {b}");

int c = 3;
int d = ++c;

int p = 6;
p += 3; //Equivalente a p = p + 3;
p -= 3; //Equivalente a p = 3 - 3;
p *= 3; //Equivalente a p = p * 3;
p /=- 3; //Equivalente a p = p / 3;

//OPERADORES LóGICOS
bool b_A = true;
bool b_B = false;
WriteLine($"AND  | b_A  | b_B   " );
WriteLine($"b_A  | {b_A & b_A, -5}  | {b_A & b_B, -5}");
WriteLine($"b_B  | {b_B & b_A, -5}  | {b_B & b_B, -5}");
WriteLine();
WriteLine($"OR  | b_A  | b_B   " );
WriteLine($"b_A  | {b_A | b_A, -5}  | {b_A | b_B, -5}");
WriteLine($"b_B  | {b_B | b_A, -5}  | {b_B | b_B, -5}");
WriteLine($"XOR  | b_A  | b_B   " );
WriteLine($"b_A  | {b_A ^ b_A, -5}  | {b_A ^ b_B, -5}");
WriteLine($"b_B  | {b_B ^ b_A, -5}  | {b_B ^ b_B, -5}");