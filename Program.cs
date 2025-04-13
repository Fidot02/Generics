
//Storing and Retriving Items using Generic

using Generics;

Stotage<string> stotage = new Stotage<string>();

stotage.StoreItem("Boy");

stotage.RetrieveItem();
Console.WriteLine();

Stotage<int> intStotage = new Stotage<int>();

intStotage.StoreItem(30);

intStotage.RetrieveItem();
Console.WriteLine();

Stotage<float> floatStotage = new Stotage<float>();
floatStotage.StoreItem(12f);
floatStotage.RetrieveItem();

Console.ReadKey();

