

#region Write to File
//FileStream myFile = new FileStream("mydetails.txt",FileMode.Create,FileAccess.Write);
//StreamWriter pen = new StreamWriter(myFile);


//pen.WriteLine("Hello and welcome to my Biography");
//pen.WriteLine("I am From Mumbai");
//pen.WriteLine("My Name is Nikhil");
//pen.WriteLine("I am a working professional at Cognizant");
//pen.WriteLine("I do progragramming");
//pen.WriteLine("I play football");
//pen.WriteLine("I am into cloud technology");
//pen.WriteLine("you will get to know more soon");

//pen.Close();
//myFile.Close();
#endregion

#region Read From File

//FileStream myFile = new FileStream("mydetails.txt", FileMode.Open, FileAccess.Read);
//StreamReader eyes = new StreamReader(myFile);

//Console.WriteLine(eyes.ReadToEnd());

//eyes.Close();
//myFile.Close();

#endregion

Console.WriteLine("Please choose from the option");
int option = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("1. New File");
Console.WriteLine("2. Read File");

switch (option)
{

    case 1:
        Write_To_File();
        break;
    case 2:
        Read_From_File();
        break;
    default:
        Console.WriteLine("Sorry Wrong Option");
        break;
}


void Write_To_File()
{

    #region Write to File - 2


    //Console.WriteLine("Please Enter your name");

    //string guestName = Console.ReadLine();

    //FileStream guestFile = new FileStream(guestName + ".txt", FileMode.CreateNew, FileAccess.Write);
    //StreamWriter pen = new StreamWriter(guestFile);

    //bool continueWrite = true;
    //Console.WriteLine("Type Exit and enter to stop writting");
    //while (continueWrite)
    //{
    //    string data = Console.ReadLine();
    //    if (data == "Exit")
    //    {
    //        continueWrite = false;
    //        Console.WriteLine("Thank you for all the info");
    //    }
    //    pen.WriteLine(data);
    //}
    //pen.Close();
    //guestFile.Close();

    #endregion
}


void Read_From_File()
{
    #region Read From File -2 
    Console.WriteLine("Please Enter Your Name");

    string name = Console.ReadLine();

    if (File.Exists(name + ".txt"))
    {

        FileStream user = new FileStream(name + ".txt", FileMode.Open, FileAccess.Read);
        StreamReader read = new StreamReader(user);

        Console.WriteLine(read.ReadToEnd());

        read.Close();
        user.Close();
    }
    else
    {
        Console.WriteLine("Sorry file not found in system");
    }

    #endregion
}