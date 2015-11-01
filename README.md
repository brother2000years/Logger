Статический класс для ведения логов. 
Для работы логгера его класс необходимо добавить в проект, где планируется его использование и в тех файлах проекта, 
где он будет использоваться, необходимо добавить строку "using LoggerEvsSpace;".
1. Чтобы вести запись логов в файл, нужно просто вызвать метод writeLog() и передать в него строку (типа string).
После этого произойдет запись в файл с расширением log, в папку Logs, которая будет находиться в той же директории,
что и исполняемый файл. Каждая запись будет идти с новой строки, а в начале записи будут указаны дата и время создания
записи. 
Пример: LoggerEvs.writeLog("Log example");
2. Чтобы выводить логируемые записи и в консоль, необходимо добавить ссылку на метод, который будет производить вывод в консоль,
в событие messageCame логгера. Функция должна быть типа: void writeToConsole(string message). В дальнейшем при каждом использовании 
метода writeLog() будет выводиться соответствующая запись в консоль в том виде, в котором она будет записываться в файл логов.
Пример:
static void Main(string[] args)
{
  LoggerEvs.messageCame += writeToConsole;            
  for (int i = 0; i < 10; i++ )
      LoggerEvs.writeLog("Test note №" + (i + 1).ToString());           
  Console.ReadKey();
}

public static void writeToConsole(string message)
{
   Console.Write(message);
}
