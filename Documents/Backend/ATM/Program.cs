using System;

namespace ATM
{

    public class Program

    {
        public static string Stars = "\n *******************************************";
        public static int PinTRYS = 3;
        public static int PIN = 0000;
        public static int Savings_Balance = 12000000;
        public static int Current_Balance = 1000000;
        public static int amount;
        public static int account;
        public static int cardNumber;
        public static int PINin;

        static void Main(string[] args)
        {
            Initialize();
        }

        public static void Initialize()
        {
            Console.Clear();
            Console.WriteLine("\n" + Stars);
            Console.WriteLine("\n *********** Bienvenido a su cajero automatico ***********");
            Console.WriteLine("\n Por favor presione cualquier tecla para continuar");
            Console.ReadKey();
            Card();
        }
          
        public static void Card()
        {
            Console.Clear();
            Console.WriteLine("\n" + Stars);
            
            do
            {
                Console.Write("\n Por favor ingrese su numero de tarjeta: ");
                Console.WriteLine("");
                cardNumber = int.Parse(Console.ReadLine());

                if (cardNumber !=123)
                {
                    Console.WriteLine("\n No. de tarjeta equivocado");
                }
                else
                {
                    Menu();
                }
            }
            while (cardNumber != 123);
        }

        public static void Menu()
      {
          string option;
          Console.Clear();
          do
           {
              Console.Clear();
              Console.WriteLine("\n" + Stars);
              Console.WriteLine("\n *********** Bienvenido a su cajero automatico ***********");
              Console.WriteLine("\n" + Stars);
              Console.WriteLine("\n Seleccione la operación que desea realizar:");
              Console.WriteLine("\n 1.Retirar dinero");
              Console.WriteLine("\n 2.Ingresar dinero");
              Console.WriteLine("\n 3.Consultar saldo");
              Console.WriteLine("\n 4.Cambiar contraseña");
              Console.WriteLine("\n 5.Cancelar operacion");

              option = Console.ReadLine();

              switch (option)
              {
               case "1":
               Withdraw();
               break;

               case "2":
               Deposit();
               break;
                            
               case "3":
               Consult();
               break;

               case "4":
               ChangePIN();
               break;

               case "5":
               Console.WriteLine("Gracias por usar este cajero");
               System.Threading.Thread.Sleep(3000);
               Initialize();
               break;
               }

           Console.WriteLine();

           } while (option != "5");
         }

        public static void Withdraw()
        {
            Console.Clear();
            Console.WriteLine(Stars);
            Console.WriteLine("\n***************  RETIRO  ****************");
            Console.WriteLine("");
            Console.WriteLine("\n Por favor ingrese su PIN");
            PINin = int.Parse(Console.ReadLine());
            if (PINin == PIN)
            {
                Console.WriteLine("\n Por favor seleccione la cuenta de la que desea retirar dinero: ");
                Console.WriteLine("\n 1. Cuenta de ahorros");
                Console.WriteLine("\n 2. Cuenta de corriente");
                account = int.Parse(Console.ReadLine());
                Console.WriteLine("");

                if (account == 1)
                {
                    Console.WriteLine("\n Por favor ingrese la cantidad de dinero que desea retirar");
                    Console.WriteLine("");
                    amount = int.Parse(Console.ReadLine());

                    if (amount > Savings_Balance)
                    {
                        Console.WriteLine("\n Saldo insuficiente");
                        System.Threading.Thread.Sleep(3000);
                        Initialize();
                    }
                    else
                    {
                        Savings_Balance -= amount;
                        Console.WriteLine("\n Retiro exitoso");
                        System.Threading.Thread.Sleep(3000);
                        Initialize();
                    }
                }
                    if (account == 2)
                    {
                        Console.WriteLine("\n Por favor ingrese la cantidad de dinero que desea retirar");
                        Console.WriteLine("");
                        amount = int.Parse(Console.ReadLine());
                        if (amount > Current_Balance)
                        {
                            Console.WriteLine("\n Saldo insuficiente");
                            System.Threading.Thread.Sleep(3000);
                            Initialize();
                        }
                        else
                        {
                            Current_Balance -= amount;
                            Console.WriteLine("\n Retiro exitoso");
                            System.Threading.Thread.Sleep(3000);
                            Initialize();
                        }
                    }
            }
            else
            {
                Console.WriteLine("\n PIN incorrecto");
                System.Threading.Thread.Sleep(3000);
                Initialize();
            }

        }

        public static void Deposit()
        {
            Console.Clear();
            Console.WriteLine(Stars);
            Console.WriteLine("\n***************  DEPOSITO  ****************");
            Console.WriteLine("");
            Console.WriteLine("\n Por favor ingrese su PIN");
            PINin = int.Parse(Console.ReadLine());
            if (PINin == PIN)
            {
                Console.WriteLine("\n Por favor seleccione la cuenta de a la cual desea depositar dinero: ");
                Console.WriteLine("\n 1. Cuenta de ahorros");
                Console.WriteLine("\n 2. Cuenta de corriente");
                account = int.Parse(Console.ReadLine());
                Console.WriteLine("");

                if (account == 1)
                {
                    Console.WriteLine("\n Por favor ingrese la cantidad de dinero que desea depositar");
                    Console.WriteLine("");
                    amount = int.Parse(Console.ReadLine());
                    Savings_Balance += amount;
                    Console.WriteLine("\n Deposito exitoso");
                    System.Threading.Thread.Sleep(3000);
                    Initialize();

                }
                if (account == 2)
                {
                    Console.WriteLine("\n Por favor ingrese la cantidad de dinero que desea depositar");
                    Console.WriteLine("");
                    amount = int.Parse(Console.ReadLine());
                    Current_Balance += amount;
                    Console.WriteLine("\n Deposito exitoso");
                    System.Threading.Thread.Sleep(3000);
                    Initialize();

                }
            }
            else
            {
                Console.WriteLine("\n PIN incorrecto");
                System.Threading.Thread.Sleep(3000);
                Initialize();
            }


        }

        public static void Consult()
        {
            Console.Clear();
            Console.WriteLine(Stars);
            Console.WriteLine("\n************  CONSULTAR SALDO  *************");
            Console.WriteLine("");
            Console.WriteLine("\n Por favor ingrese su PIN");
            PINin = int.Parse(Console.ReadLine());
            if (PINin == PIN)
            {
                Console.WriteLine("\n Por favor seleccione la cuenta de la que desea consular saldo: ");
                Console.WriteLine("\n 1. Cuenta de ahorros");
                Console.WriteLine("\n 2. Cuenta de corriente");
                account = int.Parse(Console.ReadLine());
                Console.WriteLine("");

                if (account == 1)
                {
                    Console.WriteLine("\n Saldo en cuenta de ahorros  " + Savings_Balance);
                    System.Threading.Thread.Sleep(5000);
                    Initialize();
                }
                if (account == 2)
                {
                    Console.WriteLine("\n Saldo en cuenta corriente   " + Current_Balance);
                    System.Threading.Thread.Sleep(5000);
                    Initialize();
                }
            }
            else
            {
                Console.WriteLine("\n PIN incorrecto");
                System.Threading.Thread.Sleep(3000);
                Initialize();
            }

        }


        public static void ChangePIN()
        {
            Console.Clear();
            int firstPIN, seconfPIN;
            Console.WriteLine(Stars);
            Console.WriteLine(Stars);
            Console.WriteLine("\n*************** CAMBIAR PIN ****************");
            Console.WriteLine("");
            Console.WriteLine("\n Por favor ingrese su PIN");
            PINin = int.Parse(Console.ReadLine());
            if (PINin == PIN)
            {
                Console.WriteLine("\n Ingrese su nuevo PIN : ");
                firstPIN = int.Parse(Console.ReadLine());
                Console.WriteLine("\n Re-ingrese su nuevo PIN: ");
                seconfPIN = int.Parse(Console.ReadLine());
                if (firstPIN == seconfPIN)
                {
                    Console.WriteLine("\n Su PIN fue cambaido con exito!");
                    PIN = firstPIN;
                }
                else
                {
                    Console.WriteLine("\n PIN con concuerda. Por favor intente nuevamente");
                    ChangePIN();
                }
            }
            else
            {
                Console.WriteLine("\n PIN incorrecto");
                System.Threading.Thread.Sleep(3000);
                Initialize();
            }

        }
    }

}


