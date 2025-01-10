1.Purpose and Scope of the Project
This project has been developed to digitize film rental and sales processes,making it easier for users to create film lists,plan deliveries and handle payment transactions. The project is designed to optimize user experience
and manage business processes more efficiently.

2. General Structure of the Project
The project is built on a four-layered architecture.

MODEL: This layer defines the database entities and their relationships. For example, classes such as User, Film, and Membership are located here.
DAL (Data Access Layer): This layer is responsible for database operations (CRUD). A flexible data access mechanism has been established using a generic repository structure in this layer.
BLL (Business Logic Layer): This layer defines the business rules. Tasks such as user membership validation and delivery planning are performed here.
UI (MVC): This is the layer where interactions with users occur. Web user interfaces have been developed in this layer.

3. Technologies Used
- Backend: ASP.NET Core, Entity Framework Core  
- Frontend: HTML5, CSS3, Bootstrap, JavaScript  
- Database: Microsoft SQL Server  
- Others: SOLID principles, Generic Repository Pattern, MVC  

4. Key Features 
- Users can choose a membership type and make payments via credit card.  
- Users can create film lists and set delivery dates.  
- Management of delivery and order processes.  
- Integration of warehouse and courier management.  
- Process for replacing defective films.  
- Users can take advantage of film purchasing options.  

5. Project Workflow  
After registering in the system, users can select the films they want and create a list. Users set a delivery date and complete the payment process to place an order. The order is processed by the warehouse and courier and delivered to the user, with notifications sent via SMS and email. Each delivery is handled by a courier, and delivery processes are regularly tracked.  




1.Projenin Amac� ve Kapsam�
Bu proje,film kiralama ve sat�� s�re�lerini dijitalle�tirmek,kullan�c�lar film listesi olu�turma,teslimat planlama ve �deme i�lemlerini kolayla�t�rmak amac�yla geli�tirilmi�tir. Proje,kullan�c� deneyimini optimize etmek ve i� s�re�lerini daha verimli bir �ekilde y�netmek i�in tasarlanm��t�r.

2.Projenin Genel Yap�s�
Proje,d�rt katmanl� bir mimariye sahiptir.
MODEL: Veritaban� varl�klar�n ve ili�kilerinin tan�mland��� katmand�r. �rne�in: User,Film,Membership gibi s�n�flar burada yer al�r.
DAL(Data Access Layer):Veritaban� i�lemlerinin(CRUD) ger�ekle�tirildi�i katmand�r.Bu katmanda,generic repository yap�s� kullan�larak esnek bir veri eri�im mekanizmas� olu�turulmu�tur.
BLL(Business Logic Layer):�� kurallar�n�n tan�mland��� katmand�r. �rne�in kullan�c� �yelik do�rulama ve teslimat planlama gibi i�ler bu katmanda ger�ekle�tirilir.
UI(MVC):Kullan�c�larla etkile�imde bulunulan katmand�r.Web kullan�c� aray�zleri bu katmanda geli�tirilmi�tir.

3.Kullan�lan Teknolojiler
Backend:ASP.NET Core ,Entity Framework Core
Frontend: HTML5,CCS3,Bootstrap,Javascript
Veritaban�:Microsoft SQL Server
Di�er:SOLID prensipleri,Generic Repository Deseni,MVC

4.Temel �zellikler
Kullan�c�lar�n �yelik tipi se�erek kredi kart� ile �deme yapabilmesi.
Kullan�c�lar�n film listesi olu�turmas� ve teslimat tarihi belirlemesi.
Teslimat ve sipari� s�re�lerinin y�netimi.
Depo ve kurye y�netimi entegrasyonu.
Bozuk filmlerin tedarik s�reci.
Kullan�c�lar�n film sat�n alma se�eneklerinden faydalanabilmesi.

5.Proje Ak���
Kullan�c� sisteme �ye olduktan sonra, istedi�i filmleri se�erek bir liste olu�turabilir. Teslimat tarihi belirleyen kullan�c�, �deme i�lemini tamamlad�ktan sonra sipari�ini verir. Sipari�, depo ve kurye taraf�ndan i�lenir ve kullan�c�ya teslimat SMS ve e-posta ile bildirilir. Her teslimat bir kurye taraf�ndan ta��n�r ve teslimat s�re�leri d�zenli olarak takip edilir.


