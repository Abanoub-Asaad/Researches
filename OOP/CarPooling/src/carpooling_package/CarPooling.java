package carpooling_package;

import java.util.ArrayList;
import java.util.Scanner;

public class CarPooling {

    public static ArrayList<Passenger> passengers_array = new ArrayList<Passenger>();
    public static ArrayList<Car> cars_array = new ArrayList<Car>();
    public static Scanner sc = new Scanner(System.in);
    private static int choice, choice_endOfStep;

    public static void main(String[] args) {

        Car car_obj = new Car();
        car_obj.intialize_cars();

        intialize();
        chooseFromHomePage();

    }

    public static void intialize() {
        System.out.println("----------------------------------------------------\n"
                + "Welcome, Our Dear Client\n\nSelect the operation that you want by choosing the number of the process");
        System.out.println("[1] " + "Subscribe\n" + "[2] " + "Un-Subscribe\n" + "[3] " + "Search for Route\n" + "[4] " + "Reserve a Ticket\n" + "[5] " + "Report Review\n\n");
        System.out.print("Your choice : ");
        choice = sc.nextInt();
    }

    public static void chooseFromHomePage() {
        if (choice == 1) {
            Process prosess_obj = new Process(1);
        } else if (choice == 2) {
            Process prosess_obj = new Process(2);
        } else if (choice == 3) {
            Process prosess_obj = new Process(3);
        } else if (choice == 4) {
            Process prosess_obj = new Process(4);
        }

    }

    public static void endOfStep() {

        System.out.println("-------------------------------------------------------");
        System.out.println("If You want to return to Menu choose [6]\nIf You want to exit choose[7]");
        choice_endOfStep = sc.nextInt();
        if (choice_endOfStep == 6) {
            intialize();
            chooseFromHomePage();
        } else if (choice_endOfStep == 7) {
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
            Passenger passenger_obj = new Subsciber();
        } else if (choice == 2) {
            Passenger passenger_obj = new Non_Subsciber();
        } else if (choice == 3) {
            Car car_obj = new Car();
            enterYourID();
        } else if (choice == 4) {
             
             
        }

        CarPooling.endOfStep();
    }

    public void enterYourID() {

        Car car_obj = new Car();
        boolean registerd = false;
        ArrayList<Passenger> passengers_array = CarPooling.passengers_array;
        int entered_id;
        System.out.println("Please, Enter Your ID to check If you're registered or not");
        entered_id = CarPooling.sc.nextInt();

        if (entered_id - 1 < passengers_array.size() && entered_id - 1 > -1) {
            registerd = true;
            System.out.println("You're registered in the System");

        }

        if (registerd) {
            car_obj.print_routes_of_cars();
            System.out.println("Choose your Route");
            car_obj.choose_Route(entered_id);
        } else {
            System.out.println("Sorry,You're not registered in the System\nSo register here");
            Passenger passenger_obj = new Non_Subsciber();
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

    Passenger() {
    }

}

//---------------------------------------------------------------------
class Subsciber extends Passenger {

    int num_trips = 0;

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
            ID = CarPooling.passengers_array.size();
        } else {
            System.out.println("\nSorry your age isn't allowed in subscribtion, So you're not subscribed\n");
            Passenger passenger_obj = new Non_Subsciber(passenger_name, passenger_age);
        }
    }

}

//---------------------------------------------------------------------
class Non_Subsciber extends Passenger {

    Non_Subsciber() {
        isSubscriber = false;
        enterName();
        enterAge();
        CarPooling.passengers_array.add(this);
        ID = CarPooling.passengers_array.size();
        System.out.println("\nYou're now a Non-Subsciber User\n");
        System.out.println("AND Your ID is :  " + ID);
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

    int capacity = 0;
    int car_code = 0;
    String start_from_car, end_to_car;

    Car(String start, String destination, int car_code, int capacity) {

        this.start_from_car = start;
        this.end_to_car = destination;
        this.capacity = capacity;
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

        Car car1 = new Car(from_car1, to_car1, 101, 5);
        Car car2 = new Car(from_car2, to_car2, 202, 3);
        Car car3 = new Car(from_car3, to_car3, 303, 4);
        Car car4 = new Car(from_car4, to_car4, 404, 10);
        Car car5 = new Car(from_car5, to_car5, 505, 4);
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
    }
}

//-----------------------------------
class Ticket {

    int car_code = 0;
    double price = 0.0;

    public Ticket() {
        
    }

}
