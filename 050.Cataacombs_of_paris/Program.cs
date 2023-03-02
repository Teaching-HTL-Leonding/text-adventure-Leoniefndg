
bool life = true;
bool flower = false;
bool stone = false;
bool card = false;
bool superPower = false;
bool exit = false;
bool goal = true;
bool weapon = false;
string directions;
string name;
string decision;
string use;
string cardSkip;
string goBack;
string question;

do
{
    void StartTheGame()
    {
        System.Console.WriteLine("Welcome to the Adventure Game!");
        System.Console.WriteLine("===============================");
        System.Console.WriteLine("As an avid traveler, you have decided to visit the Catacombs of Paris.");
        System.Console.WriteLine("However, during your exploration, you find yourself lost.");
        System.Console.WriteLine("You can choose to walk in multiple directions to find a way out.");
        System.Console.WriteLine("Let's start with your name: ");
        name = Console.ReadLine()!;
        System.Console.WriteLine($"Good luck {name}");
        StartRooms();

    }
    void StartRooms()
    {
        System.Console.WriteLine("You are at a crossroads, and you can choose to go down any of the four hallways. Where would you like to go? ");
        System.Console.WriteLine("Options: north/east/south/west");
        directions = Console.ReadLine()!;

        if (directions == "north")
        {
            System.Console.WriteLine("There is no more way to go");
            StartRooms();
        }
        else if (directions == "east")
        {
            ShowSkeleton();
        }

        else if (directions == "south")
        {
            HauntedRoom();
        }
        else if (directions == "west")
        {
            ShowShadowFigure();
        }
        else
        {
            System.Console.WriteLine("Incorrect input");
        }

    }
    void ShowShadowFigure()
    {
        System.Console.WriteLine("You see a dark shadowy figure appear in the distance. You are creped out.");
        System.Console.WriteLine("Where would you like to go?You can choose north,east or south.");
        directions = Console.ReadLine()!;

        switch (directions)
        {
            case "north":
                CameraScene();
                break;

            case "east":
                StartRooms();
                break;

            case "south":
                System.Console.WriteLine("There is no more way"); 
                ShowShadowFigure();
                break;

            default:
                System.Console.WriteLine("Your input is incorrect");
                break;
        }

    }
    void CameraScene()
    {
        System.Console.WriteLine("You see a camera that has been dropped on the ground. Someone has been here recently. ");
        System.Console.WriteLine("Where would you like to go?You can go north,south,east or west");
        directions = Console.ReadLine()!;

        switch (directions)
        {
            case "north":
                Exit();
                break;

            case "south":
                ShowShadowFigure();
                break;

            case "east":
                LastRoom();
                break;

            case "west":
                CardRoom();
                break;

            default:
                System.Console.WriteLine("Your input is incorrect");
                break;
        }
    }
    void HauntedRoom()
    {
        System.Console.WriteLine("You hear strange voices. You think you have awoken some of the dead.");
        System.Console.WriteLine(" Where would you like to go?You can go to north,east or west");
        directions = Console.ReadLine()!;

        switch (directions)
        {
            case "north":
                StartRooms();
                break;

            case "east":
                Exit();
                break;

            case "west":
                DeadRoom();
                break;

            default:
                System.Console.WriteLine("Your input is false");
                break;

        }
    }
    void ShowSkeleton()
    {
        System.Console.WriteLine("You see a wall of skeletons as you walk into the room. Someone is watching you.");
        System.Console.WriteLine(" Where would you like to go?You can go north, east or west");
        directions = Console.ReadLine()!;
        if (card == true)
        {
            System.Console.WriteLine("Be careful in the next room there is a monster, do you want to skip it?n/Remember you can use your card only once");
            cardSkip = Console.ReadLine()!;

            switch (cardSkip)
            {
                case "yes":
                    WitchRoom();
                    card = false;
                    break;

                case "no":
                    System.Console.WriteLine("Its ok may you can use it for a noter room");
                    break;

            }
        }

        switch (directions)
        {
            case "north":
                if (weapon == false)
                {
                    System.Console.WriteLine("There is no more way to go but you found a weapon");
                    weapon = true;
                    ShowSkeleton();

                }
                if (weapon == true)
                {
                    System.Console.WriteLine("There is no more way to go");
                    ShowSkeleton();
                }
                break;

            case "east":
                StrangeCreatureRoom();
                break;

            case "west":
                StartRooms();
                break;

            default:
                System.Console.WriteLine("your input is incorrect");
                break;
        }
    }
    void DeadRoom()
    {
        System.Console.WriteLine("Multiple monster-like creatures start emerging as you enter the room. ");
        if (superPower == true)
        {
            System.Console.WriteLine("Wow you survived!because of the super weapon you found");
        }
        if (superPower == false)
        {
            System.Console.WriteLine("You are killed.");
            life = false;
        }
    }
    void StrangeCreatureRoom()
    {
        switch (goal)
        {
            case true:
                System.Console.WriteLine("A strange monster-like creature has appeared. You can either run or fight it.");
                System.Console.WriteLine(" What would you like to do? fight or leave");
                System.Console.WriteLine("If you leave you will go back to the Skeleton room");
                decision = Console.ReadLine()!;

                switch (decision)
                {
                    case "fight":
                        if (weapon == true && superPower == true)
                        {
                            System.Console.WriteLine("you have two weapons which one do you want to use ?superWeapon or knife");
                            use = Console.ReadLine()!;

                            switch (use)
                            {
                                case "superWeapon":
                                    superPower = false;
                                    System.Console.WriteLine("You won");
                                    break;

                                case "knife":
                                    System.Console.WriteLine("Good decision, you won");
                                    break;
                            }
                            System.Console.WriteLine("Wow you won the fight");

                        }
                        else if (weapon == true)
                        {
                            System.Console.WriteLine("Wow you won !");
                        }
                        else if (weapon == false)
                        {
                            System.Console.WriteLine("im sorry you are dead");
                            life = false;
                        }
                        break;


                    case "leave":
                        ShowSkeleton();
                        break;

                }
                break;

            case false:
                System.Console.WriteLine("You have already fight and won");
                System.Console.WriteLine("You can go west or south ");
                directions = Console.ReadLine()!;

                switch (directions)
                {
                    case "west":
                        ShowSkeleton();
                        break;

                    case "south":
                        Exit();
                        break;

                    default:
                        System.Console.WriteLine("your input is false ");
                        break;
                }
                break;

        }


    }
    void Exit()
    {
        System.Console.WriteLine("You made it!and exit the game!");
        exit = true;

    }
    void LastRoom()
    {

        System.Console.WriteLine("You are in a room with super high walls and a stone in the middle");
        System.Console.WriteLine("WOW you found the SUPER-weapon on the stone!!You can use it only once");
        superPower = true;
        System.Console.WriteLine("where do you want to go now?west");
        directions = Console.ReadLine()!;

    }
    void CardRoom()
    {

        if (stone == true)
        {
            System.Console.WriteLine("you see the blue flower, but you need to answer a question");
            System.Console.WriteLine("Do you have to water flower?yes or no");
            question = Console.ReadLine()!;

            switch (question)
            {
                case "yes":
                    System.Console.WriteLine("yay you got the flower,you will go back to the witch");
                    flower = true;
                    WitchRoom();
                    break;

                case "no":
                    System.Console.WriteLine("Oh the answer is wrong, you will go back to the witch now");
                    flower = false;
                    WitchRoom();
                    break;

            }
        }
        else if (stone == false)
        {
            System.Console.WriteLine("You are in a room full of flowers with a strange number on a blue flower number->1234 ");
            System.Console.WriteLine("You found a special card where you can skip a room");
            card = true;
            System.Console.WriteLine("Where do you want to go?only south");
            directions = Console.ReadLine()!;
            switch (directions)
            {

                case "east":
                    CameraScene();
                    break;


                default:
                    System.Console.WriteLine("Your input is incorrect");
                    break;
            }

        }
    }
    void WitchRoom()
    {
        System.Console.WriteLine("Oh no there is a witch");
        System.Console.WriteLine("witch: Hello little human,");
        System.Console.WriteLine("I am Olivia and one of the strongest witches in the world, you have seen something i want to have ");
        System.Console.WriteLine("its a blue flower but I cant go there to get it because i can leave the room only with the flower");
        System.Console.WriteLine("If you get it for me i will kill you");
        System.Console.WriteLine("Wow the witch gave you a stone where you can get to the flower room again");
        System.Console.WriteLine("If you want to go there again you can say yes or no to not go there");
        goBack = Console.ReadLine()!;

        switch (goBack)
        {
            case "yes":
                stone = true;
                CardRoom();
                break;

            case "no":
                System.Console.WriteLine("Oh no the witch killed you");
                life = false;
                break;

        }

        if (flower == true)
        {
            System.Console.WriteLine("Witch: thank you for the flower!");
            System.Console.WriteLine("You have won the game");
            Exit();
        }
        if (flower == false)
        {
            System.Console.WriteLine("Witch: I see you was to dumb to bring me my flower");
            System.Console.WriteLine("oh no the witch killed you");
            life = false;
        }


    }
    StartTheGame();

} while (life == true && exit == false);