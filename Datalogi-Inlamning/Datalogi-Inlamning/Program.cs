using Datalogi_Inlamning;

BinarySearchTree<int> myTree = new();
const int SAMPLE_SIZE = 100;
var sample = new int[SAMPLE_SIZE];
var rng = new Random();
for (int i = 0; i < SAMPLE_SIZE; i++)
{
    //sample[i] = rng.Next(1,11);
    sample[i] = i;
}
foreach (var num in sample)
{
    myTree.Insert(num);
}
Console.WriteLine("balance: " + myTree.GetBalance());
Console.WriteLine("count: " + myTree.Count());
Console.WriteLine("Does 56 exist in tree: " + myTree.Exists(56));
Console.WriteLine("Does -56 exist in tree: " + myTree.Exists(-56));
Console.WriteLine("Does 566 exist in tree: " + myTree.Exists(566));
Console.WriteLine("Done");