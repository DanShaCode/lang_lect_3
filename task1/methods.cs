// МЕТОДЫ ========================================================================================================


// ВИД 1 ====================== НИЧЕГО НЕ ВОЗВРАЩАЕТ И НИЧЕГО НЕ ПРИНИМАЕТ
// void Method1()
// {
//     Console.WriteLine("Author ...");
// }
// Как вызвать?
// Method1();



//ВИД 2 ======================== НИЧЕГО НЕ ВОЗВРАЩАЮТ НО МОГУТ ПРИНИМАТЬ АРГУМЕНТЫ

// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }

// Method2("Message");
//================================================================================================================

// void Method567(string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
// }
// Method567(msg: "Text", count: 4);



//ВИД 3 ===================================== ЧТО-ТО ВОЗВРАЩАЮТ НО НИЧЕГО НЕ ПРИНИМАЮТ

// int Method3()
// {
//     return DateTime.Now.Year;
// }

// int year = Method3();
// Console.WriteLine(year);



// 4 ВИД =================================== ЧТО-ТО ПРИНИМАЮТ И ЧТО-ТО ВОЗВРАЩАЮТ

// string Method4(int count, string c)
// {
//     int i = 0;
//     string result = String.Empty;

//     while (i < count)
//     {
//         result = result + c;
//         i++;
//     }
//     return result;
// }

// string res = Method4(10, "asdasd");
// Console.WriteLine(res);