//*****************************************************************************
//** 2294. Partition Array Such That Maximum Difference Is K        leetcode **
//*****************************************************************************

#include <stdio.h>
#include <stdlib.h>

int cmp(const void *a, const void *b)
{
    return (*(int *)a - *(int *)b);
}

int partitionArray(int *nums, int numsSize, int k)
{
    qsort(nums, numsSize, sizeof(int), cmp);

    int subsequences = 1;
    int min_val = nums[0];

    for (int i = 1; i < numsSize; i++)
    {
        if (nums[i] - min_val > k)
        {
            min_val = nums[i];
            subsequences++;
        }
    }

    return subsequences;
}

int main()
{
    int nums[] = {3, 6, 1, 2, 5};
    int k = 2;
    int numsSize = sizeof(nums) / sizeof(nums[0]);

    int retval = partitionArray(nums, numsSize, k);
    printf("Subsequences: %d\n", retval);

    return 0;
}
