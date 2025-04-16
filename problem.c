#include<stdio.h>

struct shape
{
    int id;
    int identifier;
    int radius;
    int length;
    int width;
    int area;
};

int main(){
   struct shape info[10];

   int i = 0;
   
   while (i<10)
   {
    printf("---------------Menu----------------\n");
    printf("1. Add a circle\n");
    printf("2. Add a square\n");
    printf("3. show list\n");
    printf("4. show statistics\n");
    printf("5. exit\n");

    int n;
    scanf("%d", &n);

    switch (n)
    {
    case 1:
        printf("Enter the radius of the circle: ");
        scanf("%d", &info[i].radius);
        info[i].id = i + 1;
        info[i].identifier = 1;
        info[i].area = 3.14 * info[i].radius * info[i].radius;
        i++;
        break;

    case 2:
        printf("Enter the length of the square: ");
        scanf("%d", &info[i].length);
        printf("Enter the width of the square: ");
        scanf("%d", &info[i].width);
        info[i].id = i + 1;
        info[i].identifier = 2;
        info[i].area = info[i].length * info[i].width;
        i++;
        break;

    case 3:
        for (int j = 0; j <= i; j++)
        {
            if (info[j].identifier == 1)
            {
                printf("Circle %d: Radius = %d, Area = %d\n", info[j].id, info[j].radius, info[j].area);
            }
            else if (info[j].identifier == 2)
            {
                printf("Square %d: Length = %d, Width = %d, Area = %d\n", info[j].id, info[j].length, info[j].width, info[j].area);
            }
        }
        break;

    case 4:
        int total_area = 0;
        int total_circles = 0;
        int total_squares = 0;
        for (int j = 0; j <= i; j++)
        {
            total_area += info[j].area;
            if (info[j].identifier == 1)
            {
                total_circles++;
            }
            else if (info[j].identifier == 2)
            {
                total_squares++;
            }
        }
        printf("Total Area: %d\n", total_area);
        printf("Total Circles: %d\n", total_circles);
        printf("Total Squares: %d\n", total_squares);
        break;

    case 5:
        printf("Exiting...\n");
        return 0;
        break;
    
    default:
        break;
    }
   }
}
