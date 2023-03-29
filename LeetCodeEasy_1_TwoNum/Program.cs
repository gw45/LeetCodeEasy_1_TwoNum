int[] numbs_1 = { 2, 7, 11, 15 };
int target_1 = 9;

int[] numbs_2 = { 3, 2, 4 };
int target_2 = 6;

int[] numbs_3 = { 3, 3 };
int target_3 = 6;

string outPut = "";
outPut = String.Join(",",  TwoSum(numbs_1, target_1));
Console.WriteLine($"Output 1: {outPut}");
outPut = "";

outPut = String.Join(",", TwoSum(numbs_2, target_2));
Console.WriteLine($"Output 2: {outPut}");
outPut = "";

outPut = String.Join(",", TwoSum(numbs_3, target_3));
Console.WriteLine($"Output 3: {outPut}");

static int[] TwoSum(int[] numbs, int target)
{
    int[] result = new int[2];
    for (int i = 0; i < numbs.Length -1; i++)
    {
        for (int j = i + 1; j < numbs.Length; j++)
        {
            if (numbs[i] + numbs[j] != target)
            { 
                continue;
            }
            else
            {
                result[0] = i;
                result[1] = j;
                return result;
            }
        }
        continue;
    }
    return result;
}
