# About Ef Core Migrations
Ef Core Migrations Approach

Kurulum için öncelikle Migrations klasörü yoksa veya silip yeniden oluşturmak istiyorsan

//dotnet ef migrations add MyFirstMigration

//dotnet ef database update

komutlarını çalıştır.

Daha sonrasında Migration.Bat daki komutları veya Migration.Bat ı çalıştır.

Migration.Bat daki Komutlar "IDesignTimeDbContextFactory" interface ini implemente eden "DesignTimeBlogContextFactory"
class ını bulup execute edeccektir !!!

Böylece Database oluşturulacaktır.
