#include<stdio.h>
void main()
{
	int row, col;
	for(row=1;row<=5;row++)
	{
		for(col=1;col<=row;col++)
		{
			printf("* ");
		}
		printf("\n");
	}
}

//ALGORITHM
//1. start
//2. declare row,col
//3. for row=1;row<=5;row++ then
//4. for col=1;col<=row;col++ then,
//    4.1) print "* "
//5. print "\n"
//6. stop
