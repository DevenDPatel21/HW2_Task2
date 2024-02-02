// MIS 3033
// HW 2 Task 2
// Deven Patel
// 113566222


//Dictionary<key, value> dict_name;
// dict_name = new Dictrion

Dictionary<string, double> fruitDict= new Dictionary<string, double>();

fruitDict.Add("apples",0.99);
fruitDict.Add("oranges",0.5);
fruitDict.Add("bananas",0.5);
fruitDict.Add("grapes",2.99);
fruitDict.Add("blueberries",1.99);

Console.WriteLine("Fruit names: ");




for (int i = 0; i < fruitDict.Count; i++)
{
    Console.Write(fruitDict.Keys.ElementAt(i) + "   ");
}

Console.WriteLine("\n");
Console.Write("input the fruit name: ");
string userInputStr = Console.ReadLine();

if (fruitDict.ContainsKey(userInputStr))
{

    string outMesstr = string.Format($"The price of {userInputStr} is {fruitDict[userInputStr]}:C2");
    Console.WriteLine(outMesstr);
}
else
{
    Console.WriteLine("Sorry! Not found! Wrong fruit name !");
}
Console.ReadLine();