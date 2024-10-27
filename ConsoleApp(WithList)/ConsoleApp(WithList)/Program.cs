using Core.Helpers;
using Core.Models;


namespace ConsoleApp_WithList_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hotel hotel1 = new Hotel("Mildom Hotel");
            Hotel hotel2 = new Hotel("Winter Park Hotel Boulevard");
            Hotel hotel3 = new Hotel("Wyndham Garden Hotel");

            AppDbContext.AddHotel(hotel1, hotel2, hotel3);


            Room room11 = new Room("TestRoom1", 80, 2);
            Room room12 = new Room("TestRoom2", 120, 4);
            Room room13 = new Room("TestRoom3", 155.5, 6);

            Room room21 = new Room("TestRoom4", 65, 1);
            Room room22 = new Room("TestRoom5", 99.9, 3);
            Room room23 = new Room("TestRoom6", 130, 5);

            Room room31 = new Room("TestRoom7", 90, 2);
            Room room32 = new Room("TestRoom8", 120, 4);
            Room room33 = new Room("TestRoom9", 170, 6);


            hotel1.AddRoom(room11, room12, room13);

            hotel2.AddRoom(room21, room22, room23);

            hotel3.AddRoom(room31, room32, room33);


            bool c = false;

            do
            {
                string choice = Helper.GetStringInput("1 - Enter system\n0 - Close app\n");

                switch (choice)
                {
                    case "1":
                        do
                        {
                            choice = Helper.GetStringInput("1 - Create hotel\n2 - Remove hotel\n3 - Show all hotels\n4 - Select hotel by name\n5 - Return to login screen\n0 - Close app\n\n");

                            switch (choice)
                            {
                                case "1":
                                    AppDbContext.AddHotel();
                                    break;

                                case "2":
                                    AppDbContext.RemoveHotel(Helper.GetStringInput("Enter name: "));
                                    break;

                                case "3":
                                    AppDbContext.ShowHotels();
                                    break;

                                case "4":
                                    Hotel sHotel = AppDbContext.GetHotel(Helper.GetStringInput("Enter name: "));
                                    if (sHotel != null)
                                    {
                                        Hotel curHotel = sHotel;

                                        do
                                        {
                                            choice = Helper.GetStringInput($"___Selected Hotel: {curHotel.Name}___\n\n1 - Create room\n2 - Remove room\n3 - Show all rooms\n4 - Reservation\n5 - Search room\n6 - Return to hotel management screen\n0 - Close app\n\n");

                                            switch (choice)
                                            {
                                                case "1":
                                                    curHotel.AddRoom();
                                                    break;

                                                case "2":
                                                    curHotel.RemoveRoom((ushort)Helper.GetDigitInput("Enter id: "));
                                                    break;

                                                case "3":
                                                    curHotel.ShowAllRooms();
                                                    break;

                                                case "4":
                                                    curHotel.MakeReservation(Helper.GetDigitInput("Enter Id: "), Helper.GetDigitInput("Enter person count: "));
                                                    break;

                                                case "5":
                                                    do
                                                    {
                                                        choice = Helper.GetStringInput("1 - By Id\t2 - By name\t3 - By price\t4 - By capacity\t5 - By Aviability\t6 - Return room management screen\t0 - Close app\n\n");

                                                        switch (choice)
                                                        {
                                                            case "1":
                                                                curHotel.FindRoomForId();
                                                                break;

                                                            case "2":
                                                                curHotel.FindRoomForName();
                                                                break;

                                                            case "3":
                                                                curHotel.FindAllRoomForPrice();
                                                                break;

                                                            case "4":
                                                                curHotel.FindAllRoomForCapacity();
                                                                break;

                                                            case "5":
                                                                curHotel.FindAllRoomForAvailability();
                                                                break;

                                                            case "6":
                                                                c = true;
                                                                break;

                                                            case "0":
                                                                return;

                                                            default:
                                                                break;
                                                        }
                                                    }
                                                    while (!c);
                                                    c = false;
                                                    break;

                                                case "6":
                                                    c = true;
                                                    break;

                                                case "0":
                                                    return;

                                                default:
                                                    break;
                                            }
                                        }
                                        while (!c);
                                    }

                                    else Console.WriteLine("There is no hotel with this name\n");
                                    break;

                                case "5":
                                    c = true;
                                    break;

                                case "0":
                                    return;

                                default:
                                    break;
                            }
                        }
                        while (!c);

                        c = false;
                        break;

                    case "0":
                        c = true;
                        break;

                    default:
                        break;
                }
            }
            while (!c);
        }
    }
}
