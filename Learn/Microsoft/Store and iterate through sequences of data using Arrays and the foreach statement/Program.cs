string[] fraudulentOrderIds = {"B123",
"C234",
"A345",
"C15",
"B177",
"G3003",
"C235",
"B179"};

foreach (string fraudulentOrderId in fraudulentOrderIds)
{
    if (fraudulentOrderId.StartsWith("B"))
    {
        Console.WriteLine(fraudulentOrderId);
    }
}