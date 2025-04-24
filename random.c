#include <stdio.h>
#include <stdlib.h>
#include <time.h>

int main() {
    srand(time(0));

    int min = 0;
    int max = 99;

    int ara[100] = {0};


    for (int i = 0; i < 10000000000; i++) {
        int r = (rand() % (max - min + 1)) + min;
        ara[r]++;
    }

    for (int i = 0; i < 100; i++) {
        if (ara[i] > 0) {
            printf("Number %d -  %d times\n", i, ara[i]);
        }
    }

    
    return 0;
}