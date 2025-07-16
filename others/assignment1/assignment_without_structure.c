#include <stdio.h>
#include <stdlib.h>

int shapeIds[100];
int shapeTypes[100];

float circles[100];
float rectanglesH[100];
float rectanglesW[100];
float cubesH[100];
float cubesW[100];
float cubesD[100];

int shapeCount = 0;
int currentId = 1;

void addCircle()
{
    if (shapeCount >= 100) {
        return;
    }
    printf("What is the diameter: ");
    float d;
    scanf("%f", &d);
    shapeIds[shapeCount] = currentId++;
    shapeTypes[shapeCount] = 1;
    circles[shapeCount] = d;
    shapeCount++;
}

void addRectangle()
{
    if (shapeCount >= 100) {
        return;
    }
    float h, w;
    printf("What is the height: ");
    scanf("%f", &h);
    printf("What is the width: ");
    scanf("%f", &w);
    shapeIds[shapeCount] = currentId++;
    shapeTypes[shapeCount] = 2;
    rectanglesH[shapeCount] = h;
    rectanglesW[shapeCount] = w;
    shapeCount++;
}

void addCube()
{
    if (shapeCount >= 100) {
        return;
    }
    float h, w, d;
    printf("What is the height: ");
    scanf("%f", &h);
    printf("What is the width: ");
    scanf("%f", &w);
    printf("What is the depth: ");
    scanf("%f", &d);
    shapeIds[shapeCount] = currentId++;
    shapeTypes[shapeCount] = 3;
    cubesH[shapeCount] = h;
    cubesW[shapeCount] = w;
    cubesD[shapeCount] = d;
    shapeCount++;
}

void listItems()
{
    printf("Id\tType\t\tDimension\n");
    printf("====================================\n");
    for (int i = 0; i < shapeCount; i++)
    {
        printf("%d\t", shapeIds[i]);
        switch (shapeTypes[i])
        {
        case 1:
            printf("Circle\t\t%.2f\n", circles[i]);
            break;
        case 2:
            printf("Rectangle\t%.2f x %.2f\n", rectanglesH[i], rectanglesW[i]);
            break;
        case 3:
            printf("Cube\t\t%.2f x %.2f x %.2f\n", cubesH[i], cubesW[i], cubesD[i]);
            break;
        }
    }
}

void getStatistics()
{
    int countCircle = 0, countRectangle = 0, countCube = 0;
    float areaTotal = 0, areaCircle = 0, areaRectangle = 0, areaCube = 0;

    for (int i = 0; i < shapeCount; i++)
    {
        if (shapeTypes[i] == 1)
        {
            countCircle++;
            float r = circles[i] / 2;
            float area = 3.1416 * r * r;
            areaTotal += area;
            areaCircle += area;
        }
        else if (shapeTypes[i] == 2)
        {
            countRectangle++;
            float area = rectanglesH[i] * rectanglesW[i];
            areaTotal += area;
            areaRectangle += area;
        }
        else if (shapeTypes[i] == 3)
        {
            countCube++;
            float area = 6 * (cubesH[i] * cubesW[i]);
            areaTotal += area;
            areaCube += area;
        }
    }

    printf("Total shapes: %d\n", shapeCount);
    printf("Total number of Rectangles: %d\n", countRectangle);
    printf("Total number of Circles: %d\n", countCircle);
    printf("Total number of Cubes: %d\n", countCube);
    printf("Total area: %.2f\n", areaTotal);

    if (areaTotal > 0)
    {
        printf("The total area occupied by rectangles: %.2f (%.2f%%)\n", areaRectangle, (areaRectangle / areaTotal) * 100);
        printf("The total area occupied by circles: %.2f (%.2f%%)\n", areaCircle, (areaCircle / areaTotal) * 100);
        printf("The total area occupied by cubes: %.2f (%.2f%%)\n", areaCube, (areaCube / areaTotal) * 100);
    }
}

int main()
{
    int choice;
    while (1)
    {
        printf("\n======= Menu: ==========\n");
        printf("1. Add a Circle\n");
        printf("2. Add a Rectangle\n");
        printf("3. Add a Cube\n");
        printf("4. List Items\n");
        printf("5. Get Statistics\n");
        printf("6. Exit\n");

        printf("Enter your choice: ");
        scanf("%d", &choice);

        switch (choice)
        {
        case 1:
            addCircle();
            break;
        case 2:
            addRectangle();
            break;
        case 3:
            addCube();
            break;
        case 4:
            listItems();
            break;
        case 5:
            getStatistics();
            break;
        case 6:
            return 0;
        default:
            printf("Invalid choice\n");
        }
    }
    return 0;
}
