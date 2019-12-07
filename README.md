# GeekBrainsCSharpLevel1
 Курс GeekBrains "C# Уровень 1"

## Методичка 1. C# Уровень 1. 	Введение. Базовые типы данных. Консоль. Классы и методы.

1.	Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку:
	а) используя  склеивание;
    б) используя форматированный вывод;
    в) используя вывод со знаком $.
2.	Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах.
3.	а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);
	б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.
4.	Написать программу обмена значениями двух переменных:
	а) с использованием третьей переменной;
    б) *без использования третьей переменной.
5.	а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
	б) *Сделать задание, только вывод организовать в центре экрана.
	в) **Сделать задание б с использованием собственных методов (например, Print(string ms, int x,int y).
6.	*Создать класс с методами, которые могут пригодиться в вашей учебе (Print, Pause).

## Методичка 2. C# Уровень 1. Управляющие конструкции

1.  Написать метод, возвращающий минимальное из трёх чисел.
2.  Написать метод подсчета количества цифр числа.
3.  С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
4.  Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль. На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает. С помощью цикла do while ограничить ввод пароля тремя попытками.
5.  а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или всё в норме.
    б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
6.  *Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000. «Хорошим» называется число, которое делится на сумму своих цифр. Реализовать подсчёт времени выполнения программы, используя структуру DateTime.
7.  a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b).
    б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.

## Методичка 3. C# Уровень 1. Методы. От структур к объектам.

1.	а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры.
	б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса.
	в) Добавить диалог с использованием switch демонстрирующий работу класса.
2.	а)  С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке). Требуется подсчитать сумму всех нечётных положительных чисел. Сами числа и сумму вывести на экран, используя tryParse.
3.	*Описать класс дробей — рациональных чисел, являющихся отношением двух целых чисел. Предусмотреть методы сложения, вычитания, умножения и деления дробей. Написать программу, демонстрирующую все разработанные элементы класса.
	* Добавить свойства типа int для доступа к числителю и знаменателю;
	* Добавить свойство типа double только на чтение, чтобы получить десятичную дробь числа;
	** Добавить проверку, чтобы знаменатель не равнялся 0. Выбрасывать исключение ArgumentException("Знаменатель не может быть равен 0");
	*** Добавить упрощение дробей.
    
## Методичка 4. C# Уровень 1. Массивы. Текстовые файлы.

1.  Дан  целочисленный  массив  из 20 элементов.  Элементы  массива  могут принимать  целые  значения  от –10 000 до 10 000 включительно. Заполнить случайными числами.  Написать программу, позволяющую найти и вывести количество пар элементов массива, в которых только одно число делится на 3. В данной задаче под парой подразумевается два подряд идущих элемента массива. Например, для массива из пяти элементов: 6; 2; 9; –3; 6 ответ — 2. 
2.  Реализуйте задачу 1 в виде статического класса StaticClass;
а)  Класс должен содержать статический метод, который принимает на вход массив и решает задачу 1;
б)  *Добавьте статический метод для считывания массива из текстового файла. Метод должен возвращать массив целых чисел;
в)  **Добавьте обработку ситуации отсутствия файла на диске.
3.  а) Дописать класс для работы с одномерным массивом. Реализовать конструктор, создающий массив определенного размера и заполняющий массив числами от начального значения с заданным шагом. Создать свойство Sum, которое возвращает сумму элементов массива, метод Inverse, возвращающий новый массив с измененными знаками у всех элементов массива (старый массив, остается без изменений),  метод Multi, умножающий каждый элемент массива на определённое число, свойство MaxCount, возвращающее количество максимальных элементов. 
б)  **Создать библиотеку содержащую класс для работы с массивом. Продемонстрировать работу библиотеки
е)  ***Подсчитать частоту вхождения каждого элемента в массив (коллекция Dictionary<int,int>)
4.  Решить задачу с логинами из урока 2, только логины и пароли считать из файла в массив. Создайте структуру Account, содержащую Login и Password.
5.  *а) Реализовать библиотеку с классом для работы с двумерным массивом. Реализовать конструктор, заполняющий массив случайными числами. Создать методы, которые возвращают сумму всех элементов массива, сумму всех элементов массива больше заданного, свойство, возвращающее минимальный элемент массива, свойство, возвращающее максимальный элемент массива, метод, возвращающий номер максимального элемента массива (через параметры, используя модификатор ref или out).
**б) Добавить конструктор и методы, которые загружают данные из файла и записывают данные в файл.
**в) Обработать возможные исключительные ситуации при работе с файлами.
.

	
	
