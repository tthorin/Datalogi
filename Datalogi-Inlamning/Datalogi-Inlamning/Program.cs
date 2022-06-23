using Datalogi_Inlamning;

BinarySearchTree<int> myTree = new();
const int SAMPLE_SIZE = 999;
var sample = new int[SAMPLE_SIZE];
var rng = new Random();
for (int i = 0; i < SAMPLE_SIZE; i++)
{
    //sample[i] = rng.Next(1,11);
    sample[i] = 1;
}
foreach (var num in sample)
{
    myTree.Insert(num);
}
Console.WriteLine("balance: " + myTree.GetBalance());
Console.WriteLine("count: " + myTree.Count());
Console.WriteLine("Done");