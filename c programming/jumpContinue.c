#include<stdio.h>
void main()
{
	int i;
	for(i=1;i<=10;i++)
	{
		if(i%2==0)
		{
		continue;	
		}
		printf("num=%d\n",i);
	}
	printf("\nBye");
}