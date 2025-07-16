#include <stdio.h>

struct shape
{
    int id;
    int identifier;
    int radius;
    int length;
    int width;
    double cirArea;
    double recArea;

};

int main()
{
    struct shape info[10];

    int i = 0;

    while (i < 10)
    {
        printf("---------------Menu----------------\n");
        printf("1. Add a circle\n");
        printf("2. Add a rectangle\n");
        printf("3. show statistics\n");

        int n;
        scanf("%d", &n);

        switch (n)
        {
        case 1:
            printf("Enter the radius of the circle: ");
            scanf("%d", &info[i].radius);
            info[i].id = i + 1;
            info[i].identifier = 1;
            info[i].cirArea = 3.14 * info[i].radius * info[i].radius;
            i++;
            break;

        case 2:
            printf("Enter length and widht of the rectangle: ");
            scanf("%d %d", &info[i].length, &info[i].width);
            info[i].id = i + 1;
            info[i].identifier = 2;
            info[i].recArea = info[i].length * info[i].width;
            i++;
            break;

        case 3:
            printf("Statistics:\n");
            for (int j = 0; j <= i; j++)
            {
                if (info[j].identifier == 1)
                {
                    printf("Circle percentage: %.2f\n", (info[j].cirArea / (info[j].cirArea + info[j].recArea)) * 100);
                }
                else if (info[j].identifier == 2)
                {
                    printf("Rectangle percentage: %.2f\n", (info[j].recArea / (info[j].cirArea + info[j].recArea)) * 100);
                }
            }
            break;

        default:
            break;
        }
    }
}
