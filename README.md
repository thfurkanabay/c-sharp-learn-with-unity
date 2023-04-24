# c-sharp-learn-with-unity

- [Run the app ](https://dotnet.microsoft.com/en-us/learn/dotnet/hello-world-tutorial/create)
- Console.WriteLine(" ");
- Console.ReadLine();

## Data Types

1. Önceden tanımlanmış veri türleri
1.1. Reference Type
1.2. Value Type
2. Kullanıcı tarafından tanımlanmış veri türleri

## Variables

Verilerin bellekte tutulması

I. Stack: genel olaak RAM anlarız. Stack bölgeleirne mikroişlemcilerin Stack Pointer ile direkt ulaşılabilir.
Stack Pointe ro anda bellekte çalışılan bölgenin adresini tutar.

II. Heap
Ramde bulunan hafıza alanı. Tüm C# nesneleri bu alanda oluşturulur. Stackten fark heap bölgesinde tahsisatı yapılacak nesnenin derleyici taraıfından bilinmesi zorunlu değildir.
Heapten bir alan tahsisatı yapılamsı için **new** anahtar kelimesi kullanılır. New ile yaratılmış veriler runtimeda dinamik olarak yaratılırlar yani derleme zamanında herhangi bir tahsisat yapılmaz.
Stacke göre yavaştır.
III. Register
allocation(stack and heap) a göre çok hızlıdır. sebebi ikincil bellekte değildir. mkrorişlemcinin içindedirç derleyivciler cok sık yaprıkları işlemleri registerlarda hız kazanmak içiçn tutarlar. Registera erişemeyiz derleyicinin işidir.
IV. Static
Bellekteki herhangi bit dabit bölge. Static alanlarda tutulan veriler programın bütün çalışma suresince saklanır. **static** anahtar kelimesi kullanılır.
V. Sabit
Constant sabit değerler. Bu değerlerin değiştirilmesi mümkün değildir. sadece okuma amaçlı olduğundan hızlılık için bazı durumlarda ROM da tutulurlar.
VI. RAM olmayan
Bellek bölgesini temsil etmeyen disk alanlarının temsik eder. bazılarını kalıcı olması istenir.bundan dolayı bazı veriler program sonlandığından disklere kaydedilir. Program calışmamdığında da verileri blmak istiyosak bunları kullanmalıyız.

### variables tanımlama
int a;
char e;
bool c

  
  
## const
  
- tanımlandıklarında ilk değer atanmalıdır.ilkdeğer verilmeyenler const olamazlar
- const ancak const ifadelerle ilk değer atanabilir.
- içsel tadsarım olarak zaten static olduğu için static olarak belirtmek hatalıdır.

  - const a; // derlenmez
  - static const a = 10 ; // static olmaz
  
## Value and Referance
variables bellekte tutualan verilerdir. aslında biz değişkeni kullanırekne o değişkenin bellekte tutulduğu adresteki veriyr ulaşıyoruz.
  values değişkenin değerini direkt ebellek bölgesinden alırlar.
  referans tipleri ise başka nesnelyr referans olarak kulanlırlar.
  referans tipleri bir çeşit bellek bölgesi olan heap alanında yaratılan veri türleriinin addreslerini saklarlar. values tipleri yaratıldıklarında stack te oluşturulurlar. referans tipleri ise heap dediğimiz bellek bölgesinde saklanırlar.
- CTS(Common type system)

  
![09fig01](https://user-images.githubusercontent.com/26336737/233734259-cc284cdf-f8ae-4829-acc2-342338a7a4c6.gif)
https://www.tutorialspoint.com/csharp/csharp_data_types.htm
  
### Value Types
- constructor (yapıcı işlevi)
- value_type = new int();
- https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/default-values
  
  
** 1. First c# program**
** 2. C# Datatypes**
** 3. Variables**
** 4. Variables tanımlama**
** 5. Variables faaliyet alanı**
** 6. Constant Expression**
- C# programlama dilinde, sabit ifadeler (constant expressions) programın farklı yerlerinde kullanılabilen ve değeri derleme zamanında bilinen ifadelerdir. Sabit ifadeler, bir veya daha fazla sabit ifadenin işlemleriyle oluşturulabilir ve değerleri programın derleme aşamasında belirlenir.
** 7. Value and Referance types**
** 8. Value Types**
** 9. Byte**

- **Problem**: You are creating a game where the player can collect coins. Each coin has a point value, and you want to store the point value of each coin in a byte array. Write a script that initializes the byte array with the point values of five different types of coins.

- We used a byte array in this example because each coin value is small and fits within the range of values that can be stored in a single byte (0 to 255). A byte is a value type in C# that can store an 8-bit unsigned integer, which means it can store values from 0 to 255.

- Using a byte array to store the point values of each coin allows us to efficiently use memory. If we were to use a larger data type, such as an int (which can store a 32-bit signed integer), we would be using more memory than we actually need.

- In general, using the appropriate data type for the values you need to store is important for optimizing memory usage and improving the performance of your code.


** 10. sbyte**
**Problem**: You are creating a game where the player can collect power-ups. Each power-up has a different effect on the player, and you want to store the effect of each power-up in an sbyte array. Write a script that initializes the sbyte array with the effects of three different power-ups.

- In the example script I provided earlier that used "sbyte", we used this data type to store the effects of different power-ups that the player can collect in a game. "sbyte" is a value type in C# that can store an 8-bit signed integer, which means it can store values from -128 to 127.
- Using "sbyte" in this case makes sense because the effects of the power-ups can be both positive and negative. For example, in the code snippet I provided, power-up 2 decreases the player's speed by 1, which is represented by the value -1. If we had used an unsigned data type like "byte", we wouldn't be able to represent negative values.

** 11. short**

- **Problem**: You are creating a game where the player can collect coins of different denominations. You want to keep track of the total value of the coins collected by the player, and you decide to store this value in a "short" data type to save memory. Write a script that initializes a "short" variable with the value of 0, and adds the value of three different coins to the variable.
-"short" is a value type in C# that can store a 16-bit signed integer, which means it can store values from -32,768 to 32,767. This is useful when you need to store integer values that are larger than what can be stored in a "byte" data type (-128 to 127), but smaller than what can be stored in an "int" data type (-2,147,483,648 to 2,147,483,647).
** 12. ushort**
** 13. int**
** 14. uint**
** 15. long**
** 16. ulong**
** 17. float**
** 18. double**
** 19. decimal**
** 20. bool**
** 21. char**
- byte: Suppose you are making a game where the player can collect coins. You can use a byte data type to represent the number of coins the player has collected since the byte data type can store values between 0 and 255.
- sbyte: Let's say you want to create a game where the player can move left or right. You can use an sbyte data type to represent the player's direction since the sbyte data type can store values between -128 and 127.
- short and ushort: Suppose you are creating a game where the player can choose a character class. You can use a short data type to represent the ID of each class since the short data type can store values between -32,768 and 32,767. If you want to ensure that only positive values are used for the ID, you can use an ushort data type instead, which can store values between 0 and 65,535.
- int and uint: Let's say you are making a game that uses a currency system. You can use an int data type to represent the player's balance since the int data type can store values between -2,147,483,648 and 2,147,483,647. If you want to ensure that only positive values are used for the balance, you can use a uint data type instead, which can store values between 0 and 4,294,967,295.
- long and ulong: Suppose you are creating a game that uses a timer to track how long the player has been playing. You can use a long data type to represent the number of milliseconds since the long data type can store values between -9,223,372,036,854,775,808 and 9,223,372,036,854,775,807. If you want to ensure that only positive values are used for the timer, you can use a ulong data type instead, which can store values between 0 and 18,446,744,073,709,551,615.
- float, double, and decimal: Let's say you are making a game that involves physics calculations. You can use a float data type to represent the position of objects since the float data type is a 32-bit floating-point number. If you need more precision, you can use a double data type instead, which is a 64-bit floating-point number. If you require even more precision, you can use a decimal data type, which is a 128-bit floating-point number.
- bool: Suppose you are making a game that uses a switch to turn on and off a specific feature. You can use a bool data type to represent the switch since the bool data type can store either true or false.
- char: Let's say you want to create a game that uses a password system. You can use a char data type to represent each character in the password since the char data type can store a single character.
** 22. Sabit ayırtaçalrı**
** 23. Referans tipleri**
<img width="584" alt="image" src="https://user-images.githubusercontent.com/26336737/233983246-872e7b11-3633-493f-baba-8de06c596510.png">

- Delegate: Delegate, C# programlama dilindeki bir referans türüdür ve metotları temsil eder. Delegate'ler, bir metoda referans olarak kullanılabilir ve o metotun tetiklenmesine neden olabilir. Delegate'ler, olay tabanlı programlamada ve çeşitli veri yapılarının sıralanmasında sıklıkla kullanılır.
** 24. string**
- String: String, C# programlama dilindeki bir referans türüdür ve metinsel verileri temsil eder. String, karakter dizisi olarak depolanır ve çeşitli işlevler (methods) içerir, örneğin metinleri birleştirmek veya parçalamak.
** 25. object**
** 26. var **
- 'var', C# 3.0 sürümünde eklenen bir anahtar kelimedir ve veri türü çıkarımı (data type inference) yapmak için kullanılır. 'var', bir değişkenin türünü belirtmek yerine, C# derleyicisinin değişkenin ilk değeri tarafından otomatik olarak türünü belirlemesine izin verir. Bu, kodun daha az yazılmasını ve daha okunaklı hale gelmesini sağlar.

- Örneğin, aşağıdaki kodda, 'var' kullanarak bir değişken oluşturuyoruz ve C# derleyicisi, ilk değerin bir dize olduğunu fark ederek 'message' değişkeninin bir dize olduğunu anlıyor:

`var message = "Hello World!";
Bu kod, aşağıdaki kodla aynı işi yapar:`

`string message = "Hello World!";`

- Ancak 'var' kullanımı daha az yazı gerektirir ve kodun okunabilirliğini artırır. 'var' sadece yerel değişkenler için kullanılabilir ve sadece ilk değer ataması yapılan değişkenler için kullanılabilir. Ayrıca, 'var' kullanımı, kodun açık ve anlaşılır olması için uygun bir şekilde kullanılmalıdır.
