

//Console.WriteLine("Hello and Welcome to Programming world");

//Console.WriteLine("This is second line");


using bankingAPP;

bool dotransaction = true;
Accounts accObj = new Accounts("Blank Account", "NA", 1000);

while (dotransaction)
{
    Console.WriteLine("~~~~~~~~~~~~~~~~ Welcome to Citi Bank ~~~~~~~~~~~~~");

    Console.WriteLine("Press Enter To Bank with us");
    Console.ReadLine();
    Console.Clear();


    Console.WriteLine("1. Open a New Account");
    Console.WriteLine("2. Check Balance");
    Console.WriteLine("3. Widraw");
    Console.WriteLine("4. Deposit");
    Console.WriteLine("5. Transfer");
    Console.WriteLine("6. Change Pin");
    Console.WriteLine("7. Exit");

    int userChoice = Convert.ToInt32(Console.ReadLine());


    switch (userChoice)
    {
        #region Case 1 - Create a new Account
        case 1:
            Console.WriteLine("Please provide details to open a new account");
             accObj = new Accounts("Blank Account", "NA", 1000);

            //Console.WriteLine("Enter Account Number");
            //accObj.AccountNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Account Name");
            accObj.AccountName = Console.ReadLine();
            Console.WriteLine("Enter Account Type");
            accObj.AccountType =  Console.ReadLine();
            Console.WriteLine("Enter Account Balance");
            accObj.AccountBalance = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Account Created Successfully, Account No is : " + accObj.AccountNo);

            //bydefault we keep account as Active



            break;
        #endregion

        #region Case 2 - Check Available Balance
        case 2:
            Console.WriteLine("Available balance is : " + accObj.AccountBalance);
            break;
        #endregion

        #region Case 3 - Widraw Amount
        case 3:
            Console.WriteLine("Please Enter Amount");
            int widraw_amount = Convert.ToInt32(Console.ReadLine());
            accObj.Widraw(widraw_amount);
            Console.WriteLine("Balance After Widrawal is : " + accObj.AccountBalance);
            break;
        #endregion

        #region Case 4 - Deposit Amount

        case 4:
            Console.WriteLine("Enter Deposit Amount");          
            int deposit_amount = Convert.ToInt32(Console.ReadLine());
            accObj.Deposit(deposit_amount);
            Console.WriteLine("Balance After Deposit is : " + accObj.AccountBalance);
            break;
        #endregion

        case 5:
            Console.WriteLine("Transfer Initialted");
            break;
        case 6:
            Console.WriteLine("Enter New Pin");
            break;
        case 7:
            Console.WriteLine("Thank you for banking with us, see you soon again ");
            dotransaction = false;
            break;
        default:
            Console.WriteLine("Sorry invalid option ");
            break;       

           
    }

}




