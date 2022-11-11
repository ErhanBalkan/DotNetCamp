IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
IKrediManager tasitKrediManager = new TasitKrediManager();
IKrediManager konutKrediManager = new KonutKrediManager();

ILoggerService databaseLoggerService = new DatabaseLoggerService();
ILoggerService fileLoggerService = new FileLoggerService();
BasvuruManager basvuruManager = new BasvuruManager();
//basvuruManager.BasvuruYap(konutKrediManager);
basvuruManager.BasvuruYap(konutKrediManager,databaseLoggerService);
List<IKrediManager> krediler = new List<IKrediManager>(){ihtiyacKrediManager,tasitKrediManager,konutKrediManager};
//basvuruManager.KrediOnBilgilendirmesiYap(krediler);