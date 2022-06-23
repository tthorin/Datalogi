using Datalogi_Inlamning;

BinarySearchTree<int> myTree = new();
var sample = new int[999];
var rng = new Random();
for (int i = 0; i < 10; i++)
{
    //sample[i] = rng.Next(1,11);
    sample[i] = 1;
}
foreach (var num in sample)
{
    myTree.Insert(num);
}
Console.WriteLine(myTree.GetBalance());
Console.WriteLine("Done");