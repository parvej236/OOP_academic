#include <stdio.h>
#include <stdlib.h>

struct Circle
{
    float diameter;
};

struct Rectangle
{
    float height;
    float width;
};

struct Cube
{
    float height;
    float width;
    float depth;
};

struct Shape
{
    int id;
    int type;
    struct Circle circle;
    struct Rectangle rectangle;
    struct Cube cube;
};

struct Shape shapes[100];
int count = 0;
int currentId = 1;

void addCircle()
{
    if (count >= 100)
    {
        return;
    }
    float d;
    printf("What is the diameter: ");
    scanf("%f", &d);

    shapes[count].id = currentId++;
    shapes[count].type = 1;
    shapes[count].circle.diameter = d;

    count++;
}

void addRectangle()
{
    if (count >= 100)
        return;
    float h, w;
    printf("What is the height: ");
    scanf("%f", &h);
    printf("What is the width: ");
    scanf("%f", &w);

    shapes[count].id = currentId++;
    shapes[count].type = 2;
    shapes[count].rectangle.height = h;
    shapes[count].rectangle.width = w;

    count++;
}

void addCube()
{
    if (count >= 100)
        return;
    float h, w, d;
    printf("What is the height: ");
    scanf("%f", &h);
    printf("What is the width: ");
    scanf("%f", &w);
    printf("What is the depth: ");
    scanf("%f", &d);

    shapes[count].id = currentId++;
    shapes[count].type = 3;
    shapes[count].cube.height = h;
    shapes[count].cube.width = w;
    shapes[count].cube.depth = d;

    count++;
}

void listItems()
{
    printf("\nId\tType\t\tDimension\n");
    printf("=======================================\n");
    for (int i = 0; i < count; i++)
    {
        printf("%d\t", shapes[i].id);
        if (shapes[i].type == 1)
        {
            printf("Circle\t\t%.2f\n", shapes[i].circle.diameter);
        }
        else if (shapes[i].type == 2)
        {
            printf("Rectangle\t%.2f x %.2f\n", shapes[i].rectangle.height, shapes[i].rectangle.width);
        }
        else if (shapes[i].type == 3)
        {
            printf("Cube\t\t%.2f x %.2f x %.2f\n",
                   shapes[i].cube.height,
                   shapes[i].cube.width,
                   shapes[i].cube.depth);
        }
    }
}

void getStatistics()
{
    int countCircle = 0, countRectangle = 0, countCube = 0;
    float areaCircle = 0, areaRectangle = 0, areaCube = 0, totalArea = 0;

    for (int i = 0; i < count; i++)
    {
        if (shapes[i].type == 1)
        {
            countCircle++;
            float r = shapes[i].circle.diameter / 2;
            float area = 3.1416 * r * r;
            areaCircle += area;
            totalArea += area;
        }
        else if (shapes[i].type == 2)
        {
            countRectangle++;
            float area = shapes[i].rectangle.height * shapes[i].rectangle.width;
            areaRectangle += area;
            totalArea += area;
        }
        else if (shapes[i].type == 3)
        {
            countCube++;
            float area = 6 * (shapes[i].cube.height * shapes[i].cube.width);
            areaCube += area;
            totalArea += area;
        }
    }

    printf("\nTotal shapes: %d\n", count);
    printf("Total number of Rectangles: %d\n", countRectangle);
    printf("Total number of Circles: %d\n", countCircle);
    printf("Total number of Cubes: %d\n", countCube);
    printf("Total area: %.2f\n", totalArea);

    if (totalArea > 0)
    {
        printf("The total area occupied by rectangles: %.2f (%.2f%%)\n", areaRectangle, (areaRectangle / totalArea) * 100);
        printf("The total area occupied by circles: %.2f (%.2f%%)\n", areaCircle, (areaCircle / totalArea) * 100);
        printf("The total area occupied by cubes: %.2f (%.2f%%)\n", areaCube, (areaCube / totalArea) * 100);
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
