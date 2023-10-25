//Create a Loop that prints all values from 1-255
for (int i = 1; i <=255; i++){
    Console.WriteLine(i);
}

// //Create a new loop that prints all values from 1-100 that are divisible by 3 or 5, but not both
for (int o=1; o<=100; o++){
    
    if (  o % 3 == 0 || o %5 ==0 ){
        Console.WriteLine(o);
    }
}

//Modify the previous loop to print "Fizz" for multiples of 3, "Buzz" for multiples of 5, and "FizzBuzz" for numbers that are multiples of both 3 and 5
for (int k =1; k<= 100; k++){
    if (k%3 ==0 && k % 5 == 0){
        Console.WriteLine("FizzBuzz");
    }
    else if (k%5 ==0){
        Console.WriteLine("Buzz");
    }
    else if ( k % 3== 0 ){
        Console.WriteLine("Fizz");        
    }
}

//(Optional) If you used "for" loops for your solution, try doing the same with "while" loops. Vice-versa if you used "while" loops!
 int j = 1;
 while (j<=255){
    Console.WriteLine(j);
    j++;
 };

int n=1;
while (n<=100){
    n++;
    if (  n % 3 == 0 || n %5 ==0 ){
        Console.WriteLine(n);
    }
}


int h=1;
while (h<=100){
    h++;
    if (h%3 ==0 && h % 5 == 0){
        Console.WriteLine("FizzBuzz");
    }
    else if (h%5 ==0){
        Console.WriteLine("Buzz");
    }
    else if ( h % 3== 0 ){
        Console.WriteLine("Fizz");        
    }
}