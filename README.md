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
  
  
  
  
  
