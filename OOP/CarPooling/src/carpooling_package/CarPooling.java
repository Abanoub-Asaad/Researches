package carpooling_package;

import static carpooling_package.CarPooling.sc;
import java.util.ArrayList;
import java.util.Scanner;

public class CarPooling extends main_ {

    public static void main(String[] args) {

        Car car_obj = new Car();
        car_obj.intialize_cars();

        intialize_menu();

    }

}

//-----------------------------------------------------------------------------
class main_ {

    final int Alowed_age = 20;
    public static ArrayList<Passenger> passengers_array = new ArrayList<Passenger>();
    public static ArrayList<Car> cars_array = new ArrayList<Car>();
    public static Scanner sc = new Scanner(System.in);
    private static int choice_menu, choice_endOfStep;

    public static void intialize_menu() {
        System.out.println("----------------------------------------------------\n"
                + "Welcome, Our Dear Client\n\nSelect the operation that you want by choosing the number of the process");
        System.out.println("[1] " + "New User\n" + "[2] " + "Subscribe\n" + "[3] " + "Un-Subscribe\n" + "[4] " + "Search for Route and Reserve a Ticket\n\n");
        System.out.print("Your choice : ");
        choice_menu = sc.nextInt();
        chooseFromHomePage();
    }

    public static void chooseFromHomePage() {
        if (choice_menu == 1) {
            Process prosess_obj = new Process(1);
        } else if (choice_menu == 2) {
            Process prosess_obj = new Process(2);
        } else if (choice_menu == 3) {
            Process prosess_obj = new Process(3);
        } else if (choice_menu == 4) {
            Process prosess_obj = new Process(4);
        }

    }

    public static void endOfStep() {

        System.out.println("-------------------------------------------------------");
        System.out.println("If You want to return to Menu choose [5]\nIf You want to exit choose[6]");
        choice_endOfStep = sc.nextInt();
        if (choice_endOfStep == 5) {
            intialize_menu();
            chooseFromHomePage();
        } else if (choice_endOfStep == 6) {
            System.exit(0);
        }
    }
}
//---------------------------------------------------------------------

class Process {

    private int choice;

    public Process(int choice) {
        this.choice = choice;
        start();
    }

    void start() {
        if (choice == 1) {
            Passenger passenger_obj = new Non_Subsciber();
        } else if (choice == 2) {
            enterYourID(1);
        } else if (choice == 3) {
            enterYourID(2);
        } else if (choice == 4) {
            Car car_obj = new Car();
            enterYourID(3);
        }

        CarPooling.endOfStep();
    }

    public void enterYourID(int choice) {

        CarPooling car_pooling_obj = new CarPooling();
        Car car_obj = new Car();
        boolean registerd = false;
        ArrayList<Passenger> passengers_array = CarPooling.passengers_array;
        int entered_id;

        System.out.println("Please, Enter Your ID to check If you're registered or not");
        entered_id = CarPooling.sc.nextInt();

        if (entered_id - 1 < passengers_array.size() && entered_id - 1 > -1) {
            registerd = true;
            System.out.println("OK, You registered in the System Previously");

        }

        if (registerd) {

            Passenger passenger = passengers_array.get(entered_id - 1);
            if (choice == 1) {
                if (passenger.passenger_age >= car_pooling_obj.Alowed_age) {
                    if (passenger.isSubscriber) {
                        System.out.println("You're already a Subscriber\nAnd There's " + passenger.num_trips + " are available");
                    } else {
                        passenger.isSubscriber = true;
                        passenger.num_trips = 5;
                        System.out.println("You're now a Subscriber, Enjoy!");
                    }
                } else {
                    System.out.println("\nSorry your age isn't allowed in subscribtion, So you're not subscribed\n");
                }

            } else if (choice == 2) {
                if (!passenger.isSubscriber) {
                    System.out.println("You're already a Non-Subscriber");
                } else {
                    passenger.isSubscriber = false;
                    passenger.num_trips = 0;
                    System.out.println("You're now a Non-Subscriber User");
                }
            } else if (choice == 3) {
                car_obj.print_routes_of_cars();
                System.out.println("Choose your Route");
                car_obj.choose_Route(entered_id);
            }

        } else {
            System.out.println("Sorry,You're not registered in the System\n" + "Click [1] to enter Your ID again\nClick [2] to register");
            int choicee = CarPooling.sc.nextInt();
            if (choicee == 1) {
                enterYourID(choice);
            } else {
                Passenger passenger_obj = new Non_Subsciber();
            }

        }
    }
}

//---------------------------------------------------------------------
interface passenger_interface {

    public void enterName();
    public void enterAge();

}

//---------------------------------------------------------------------
abstract class Passenger implements passenger_interface {

    int ID = 0;
    int chosen_route = 0;
    final int Alowed_age = 20;
    String passenger_name;
    int passenger_age;
    boolean isSubscriber = false;
    int num_trips = 0;

    Passenger() {
    }

}

//---------------------------------------------------------------------
class Subsciber extends Passenger {

    Subsciber() {

        enterName();
        enterAge();
        checkAge();
    }

    @Override
    public void enterName() {
        System.out.print("Please, Enter your name:  ");
        passenger_name = CarPooling.sc.next();
    }

    @Override
    public void enterAge() {
        System.out.print("Please, Enter your age:  ");
        passenger_age = CarPooling.sc.nextInt();
    }

    void checkAge() {
        if (passenger_age >= Alowed_age) {
            System.out.println("\nCongratulation - You've subscribed successfully\n");
            isSubscriber = true;
            CarPooling.passengers_array.add(this);
            this.ID = CarPooling.passengers_array.size();
            System.out.println("And Your ID is : " + ID);
            this.num_trips = 5;
        } else {
            System.out.println("\nSorry your age isn't allowed in subscribtion, So you're not subscribed\n");
            Passenger passenger_obj = new Non_Subsciber(passenger_name, passenger_age);
        }
    }

}

//---------------------------------------------------------------------
class Non_Subsciber extends Passenger {

    Non_Subsciber() {
        make_unsubscriber();
    }

    public void make_unsubscriber() {
        isSubscriber = false;
        enterName();
        enterAge();
        CarPooling.passengers_array.add(this);
        ID = CarPooling.passengers_array.size();
        System.out.println("\nYou're now a Non-Subsciber User\n");
        System.out.println("***************************************");
        System.out.println("AND Your ID is :  " + ID);
        System.out.println("***************************************");
    }

    Non_Subsciber(String name, int age) {

        this.passenger_name = passenger_name;
        this.passenger_age = passenger_age;
        this.isSubscriber = false;
        CarPooling.passengers_array.add(this);
        ID = CarPooling.passengers_array.size();
    }

    @Override
    public void enterName() {
        System.out.print("Please, Enter your name:  ");
        passenger_name = CarPooling.sc.next();
    }

    @Override
    public void enterAge() {
        System.out.print("Please, Enter your age:  ");
        passenger_age = CarPooling.sc.nextInt();
    }

}

//-------------------------------------
class Car {

    ArrayList<Car> cars_array = CarPooling.cars_array;

    final int num_trips_per_day_for_car = 10;
    int capacity = 0;
    int car_code = 0;
    String driver_name;
    String start_from_car, end_to_car;

    Car(String start, String destination, int car_code, int capacity, String driver_name) {

        this.start_from_car = start;
        this.end_to_car = destination;
        this.car_code = car_code;
        this.capacity = capacity;
        this.driver_name = driver_name;
        CarPooling.cars_array.add(this);
    }

    Car() {
    }

    public void intialize_cars() {

        String from_car1 = "Cairo";
        String to_car1 = "Ghamra";
        String from_car2 = "Shobra";
        String to_car2 = "6th of October";
        String from_car3 = "Giza";
        String to_car3 = "Nasr City";
        String from_car4 = "10th of Ramadan City";
        String to_car4 = "El Obour";
        String from_car5 = "Maadi";
        String to_car5 = "Old Cairo";

        Car car1 = new Car(from_car1, to_car1, 101, 5, "Ali");
        Car car2 = new Car(from_car2, to_car2, 202, 0, "Ahmed");
        Car car3 = new Car(from_car3, to_car3, 303, 4, "Mohamed");
        Car car4 = new Car(from_car4, to_car4, 404, 10, "Nada");
        Car car5 = new Car(from_car5, to_car5, 505, 4, "Nora");
    }

    public void print_routes_of_cars() {

        System.out.println("-----------------------------------------------------");

        int i = 1;
        for (Car car : cars_array) {
            System.out.println("Click [ " + i + " ]  From :  " + car.start_from_car + "\n\t\t\t\t To :  " + car.end_to_car + "\n");
            ++i;
        }

    }

    public void choose_Route(int entered_id) {

        int chosen_route;
        chosen_route = CarPooling.sc.nextInt();
        CarPooling.passengers_array.get(entered_id - 1).chosen_route = chosen_route;

        System.out.println("You chosen Route Successfully\n");
        System.out.println("And its location : " + CarPooling.cars_array.get(chosen_route - 1).start_from_car);
        System.out.println("And its destination : " + CarPooling.cars_array.get(chosen_route - 1).end_to_car);

        //---
        car_code = CarPooling.cars_array.get(chosen_route - 1).car_code;

        System.out.println("\nClick [1] : Reserve a ticket\nClick [2] : Back to Menu");
        int ch = CarPooling.sc.nextInt();
        if (ch == 1) {
            Ticket ticket_obj = new Ticket();
            ticket_obj.reserve_ticket(entered_id, car_code);
        } else if (ch == 2) {
            CarPooling.intialize_menu();
        }

    }
}

//-----------------------------------
class Ticket {

    final double discount = 0.5;
    int car_code = 0;
    double price = 100;

    public Ticket() {

    }

    public void reserve_ticket(int user_id, int car_code) {
        this.car_code = car_code;
        check_valid_car(user_id, car_code);
    }

    public void check_valid_car(int user_id, int car_code) {

        for (Car car : CarPooling.cars_array) {

            if (car.car_code == car_code) {
                if (car.capacity > 0) {
                    --car.capacity;
                    check_discount(user_id);
                    System.out.println("------------------------------------------------------");
                    System.out.println("You reserved the ticket successfully and its price = " + price);
                    System.out.println("And its location : " + CarPooling.cars_array.get(car_code % 100).start_from_car);
                    System.out.println("And its destination : " + CarPooling.cars_array.get(car_code % 100).end_to_car);
                    System.out.println("------------------------------------------------------");
                    break;
                } else {
                    System.out.println("Ooh Sorry, the car isn't valid right now !\nChoose another route");
                    Car car_obj = new Car();
                    car_obj.choose_Route(user_id);
                    break;
                }
            }
        }

    }

    public void check_discount(int user_id) {

        Passenger cur_passenger = CarPooling.passengers_array.get(user_id - 1);
        if (cur_passenger.isSubscriber && cur_passenger.num_trips > 0) {
            this.price = 100 * discount;
            cur_passenger.num_trips--;
        } else {
            this.price = 100;
        }
        System.out.println("------------------------------------------------------");
        System.out.println("You reserved the ticket sucessfully and\nThe price =  " + price);
        System.out.println("And its location : " + CarPooling.cars_array.get(car_code % 100).start_from_car);
        System.out.println("And its destination : " + CarPooling.cars_array.get(car_code % 100).end_to_car);
        System.out.println("------------------------------------------------------");
        System.out.println("Click [1] If You want to write a review\nClick [2] Exit the program");

        int choice = CarPooling.sc.nextInt();
        if (choice == 1) {
            writeReview(true);
        } else {
            writeReview(false);
        }
    }

    public void writeReview(boolean ok) {
        String s;
        if (!ok) {
            System.exit(0);
        } else {
            System.out.println("Write Your Review HERE : ");
            s = CarPooling.sc.next();
            System.out.println("Done !!");
        }
    }
}
