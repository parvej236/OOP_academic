#include <stdio.h>
#include <stdlib.h>

struct Circle
{
    int id;
    float diameter;
};

struct Rectangle
{
    int id;
    float height;
    float width;
};

struct Cube
{
    int id;
    float height;
    float width;
    float depth;
};

struct Circle circles[100];
struct Rectangle rectangles[100];
struct Cube cubes[100];

int countCircles = 0;
int countRectangles = 0;
int countCubes = 0;
int currentId = 1;

void addCircle()
{
    if (countCircles >= 100)
        return;

    float d;
    printf("What is the diameter: ");
    scanf("%f", &d);

    circles[countCircles].id = currentId++;
    circles[countCircles].diameter = d;
    countCircles++;
}

void addRectangle()
{
    if (countRectangles >= 100)
        return;

    float h, w;
    printf("What is the height: ");
    scanf("%f", &h);
    printf("What is the width: ");
    scanf("%f", &w);

    rectangles[countRectangles].id = currentId++;
    rectangles[countRectangles].height = h;
    rectangles[countRectangles].width = w;
    countRectangles++;
}

void addCube()
{
    if (countCubes >= 100)
        return;

    float h, w, d;
    printf("What is the height: ");
    scanf("%f", &h);
    printf("What is the width: ");
    scanf("%f", &w);
    printf("What is the depth: ");
    scanf("%f", &d);

    cubes[countCubes].id = currentId++;
    cubes[countCubes].height = h;
    cubes[countCubes].width = w;
    cubes[countCubes].depth = d;
    countCubes++;
}

void listItems()
{
    printf("\nId\tType\t\tDimensions\n");
    printf("=========================================\n");

    for (int i = 0; i < countCircles; i++)
    {
        printf("%d\tCircle\t\t%.2f\n", circles[i].id, circles[i].diameter);
    }

    for (int i = 0; i < countRectangles; i++)
    {
        printf("%d\tRectangle\t%.2f x %.2f\n",
               rectangles[i].id,
               rectangles[i].height,
               rectangles[i].width);
    }

    for (int i = 0; i < countCubes; i++)
    {
        printf("%d\tCube\t\t%.2f x %.2f x %.2f\n",
               cubes[i].id,
               cubes[i].height,
               cubes[i].width,
               cubes[i].depth);
    }
}

void getStatistics()
{
    int totalShapes = countCircles + countRectangles + countCubes;
    float totalArea = 0, areaCircles = 0, areaRectangles = 0, areaCubes = 0;

    for (int i = 0; i < countCircles; i++)
    {
        float r = circles[i].diameter / 2;
        float area = 3.1416 * r * r;
        areaCircles += area;
        totalArea += area;
    }

    for (int i = 0; i < countRectangles; i++)
    {
        float area = rectangles[i].height * rectangles[i].width;
        areaRectangles += area;
        totalArea += area;
    }

    for (int i = 0; i < countCubes; i++)
    {
        float area = 6 * (cubes[i].height * cubes[i].width);
        areaCubes += area;
        totalArea += area;
    }

    printf("\nTotal shapes: %d\n", totalShapes);
    printf("Total number of Rectangles: %d\n", countRectangles);
    printf("Total number of Circles: %d\n", countCircles);
    printf("Total number of Cubes: %d\n", countCubes);
    printf("Total area: %.2f\n", totalArea);

    if (totalArea > 0)
    {
        printf("The total area occupied by rectangles: %.2f (%.2f%%)\n", areaRectangles, (areaRectangles / totalArea) * 100);
        printf("The total area occupied by circles: %.2f (%.2f%%)\n", areaCircles, (areaCircles / totalArea) * 100);
        printf("The total area occupied by cubes: %.2f (%.2f%%)\n", areaCubes, (areaCubes / totalArea) * 100);
    }
}

int main()
{
    int choice;
    while (1)
    {
        printf("\nMenu:\n");
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
            exit(0);
        default:
            printf("Invalid choice.\n");
        }
    }

    return 0;
}
