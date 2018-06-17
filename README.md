# KalitimDemo

**_Bir sınıftan yeni bir sınıf oluşturma işlemine kalıtım denir. Kalıtım kullanımında hangi sınıftan kalıtım alınıyorsa o
sınıfa ait metotlar ve özellikler yeni sınıfta da olur. İstenirse yeni sınıfa farklı özellik ve metotlar eklenebilir.
Bir sınıf sadece bir sınıftan türetilebilir_**

**_Kalıtım Kullanım Örneği_**:

```C#
class Personel
{
public string adi,soyadi;
}
 
class akademikPersonel:Personel //personel sınıfından kalıtım yoluyla akademik personel sınıfı oluşturuldu.
{
public string unvan,mail;
}
 
class AnaProgram
{
static void Main(string[] args)
{
akademikPersonel kişi=new akademikPersonel();
kisi.adi="Burak";
kisi.soyadi="Ertan";
kisi.unvan="Avukat";
kisi.mail="burake@abcd.com";
Console.ReadKey();
}
}
```
**_Yukarıdaki örnekte personel sınıfından “akademikPersonel” isimli sınıf türetilerek “kişi” nesnesinde “Personel” sınıfına 
ait adi ve soyadi özelliklerine erişildiği görülmektedir_**.
