void UserTest(){
    UserManager userManager = new UserManager(new EFUserDal());
    // Add user 
    // User user1 = new User{FirstName = "Erhan", LastName = "BALKAN", Email = "erhannbalkann@gmail.com", Password = "123"};
    // User user2 = new User{FirstName = "Atilla", LastName = "CANBAZ", Email = "atillacanbaz@gmail.com", Password = "321"};
    User user3 = new User{FirstName = "Atakan", LastName = "Aydın", Email = "hakkiatakan@gmail.com", Password = "456"};

    // IResult result1 = userManager.Add(user1);
    // IResult result2 = userManager.Add(user2);
    IResult result3 = userManager.Add(user3);
    // System.Console.WriteLine(user1.FirstName + " ve " + user2.FirstName + " başarıyla eklendi.");        
    System.Console.WriteLine(user3.FirstName + " başarıyla eklendi.");
} 
 
void CustomerTest(){
    CustomerManager customerManager = new CustomerManager(new EFCustomerDal());
    // Customer customer1 = new Customer{CompanyName = "Balkan's"};
    // Customer customer2 = new Customer{CompanyName = "Martur"};
    Customer customer3 = new Customer{Id=3, CompanyName = "Fompak"};
    // IResult result1 = customerManager.Add(customer1);
    // IResult result2 = customerManager.Add(customer2);
    IResult result3 = customerManager.Add(customer3);
    System.Console.WriteLine(customer3.CompanyName + " başarıyla eklendi.");
}

void RentalTest(){
    RentalManager rentalManager = new RentalManager(new EFRentalDal());
    Rental rental1 = new Rental{
        CarId = 1,
        CustomerId = 1,
        RentDate = new DateTime(2022, 11, 11),
        ReturnDate = new DateTime(2022, 11, 15),
    };
    
    IResult result1 = rentalManager.Add(rental1);
    if (result1.State == true){
        System.Console.WriteLine(rental1.CarId +" ID'ye sahip araç kiralandı.");
    }else{
    System.Console.WriteLine("Araç teslim edilmediği için işlem yapılamıyor.");
    }
}
//UserTest();
//CustomerTest();
RentalTest();
