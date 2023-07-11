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

# Url Shortening

1- Create a shortening url via this end point
![image](https://user-images.githubusercontent.com/22656439/221718625-ae69b340-3011-4f10-a7e7-d9b9af56f046.png)

2- Get shortening url from data section

![image](https://user-images.githubusercontent.com/22656439/221718818-75f50322-56c7-49f3-8bda-8bd51af48fe9.png)

3- Paste url to browser url area

![image](https://user-images.githubusercontent.com/22656439/221718973-b9623948-fdf3-4324-a87b-ce562c292aa0.png)


---------------
You can create custom shorening url via this api

![image](https://user-images.githubusercontent.com/22656439/221719319-7fba07e8-701a-4535-a49c-cb461164eb17.png)


