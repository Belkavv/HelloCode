﻿int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}

int[] array = {11, 21, 31, 41, 15, 61, 17, 18, 19};
// array[0] =  12;
// Console.WriteLine(array[0]);

int max = Max(
    Max(array[0], array[1], array[2]), 
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8]));

Console.WriteLine(max);

// int max = Max(
//     Max(array, b1, c1), 
//     Max(a1, b1, c1), 
//     Max(a3, b3, c3));

// // if(b1 > max) max = b1;
// // if(c1 > max) max = c1;

// // if(a2 > max) max = a2;
// // if(b2 > max) max = b2;
// // if(c2 > max) max = c2;

// // if(a3 > max) max = a3;
// // if(b3 > max) max = b3;
// // if(c3 > max) max = c3;

// Console.WriteLine(max);
