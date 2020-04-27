# MongoDb
Docker-MongoDb-dotNetCore-Test

	• Docker mongodb image'ını oluştur :Komut satırında :docker run -d --name MongoLand -p 27017:27017 mongo:latest
	• Çalışan docker listesine bakmak için :docker container ls
	• Linux işletim sistemli mongo imageımızın terminalinde kod yazabilmek için :docker exec -it MongoLand bash
	• Bu terminalde "mongo" yazarak mongo veritabanın arayüzüne erişebiliriz. Bundan sonra yazılacaklar mongo kodlarıdır :
		○ Show dbs	Mevcut databaseleri listeler
		Use newdatabasename	Yeni bir db oluşturur
		db.stats()	Mevcut database'in bilgilerini listeler
		db.createCollection("user")	Yeni collection (tablo) oluşturur
		db.user.insertMany([{	Collection'a örnek data aktarımı
		    "id": 1,
		    "name": "Leanne Graham",
		    "username": "Bret",
		    "email": "Sincere@april.biz"
		  },
		  {
		    "id": 2,
		    "name": "Ervin Howell",
		    "username": "Antonette",
		    "email": "Shanna@melissa.tv" 
		},
		  {
		    "id": 3,
		    "name": "Clementine Bauch",
		    "username": "Samantha",
		    "email": "Nathan@yesenia.net" 
		}])
		db.user.find().pretty()	Tablodaki tüm kayıtları verir
		db.user.find({"username":"Samantha"}).pretty()	Kullanıcı adı "Samantha" olan kayıtları listeler
		db.user.find({"id":{$gt:2}}).pretty() 	İd'si 2'den büyük olan kayıtları listeler
